/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package csp2;

import java.io.*;
import java.net.*;
 
public class Client {
    //define states
    private static final int WAITTEXT = 1;
    private static final int WAITFILE = 2;
    //and our current state
    private static int state = WAITTEXT;
    
    public static void main(String[] args) throws IOException {
 
        Socket ourSocket = null;
        PrintWriter out = null;
        BufferedReader in = null;
        InputStream is = null;
 
        //try and connect
        try {
            ourSocket = new Socket("127.0.0.1", 2222);
            out = new PrintWriter(ourSocket.getOutputStream(), true);
            is = ourSocket.getInputStream();
            in = new BufferedReader(new InputStreamReader(is));
        } catch (UnknownHostException e) {
            System.err.println("Can't find host: 127.0.0.1");
            System.exit(1);
        } catch (IOException e) {
            System.err.println("Couldn't get I/O for the connection to 127.0.0.1");
            System.exit(1);
        }
 
        //set up
        BufferedReader stdIn = new BufferedReader(new InputStreamReader(System.in));
        String fromServer;
        String fromUser;
        OUTER:
        while ((fromServer = in.readLine()) != null) {
            //if we are waiting for text do the below
            if(state == WAITTEXT){
                System.out.println("Server: " + fromServer);
                switch (fromServer) {
                    case "Connection Closed":
                        break OUTER;
                    case "Sending File":
                        state = WAITFILE;
                        break;
                }
                if(state == WAITTEXT){
                    fromUser = stdIn.readLine();
                    if (fromUser != null) {
                        System.out.println("Client: " + fromUser);
                        out.println(fromUser);
                    }
                }else if(state == WAITFILE){
                    int bytesRead;
                    int current = 0;
                    String name = in.readLine();
                    int size = Integer.parseInt(in.readLine());
                    byte [] mybytearray = new byte [size];
                    //InputStream is = ourSocket.getInputStream();
                    FileOutputStream fos = new FileOutputStream(name.toString().replace("my","new"));
                    BufferedOutputStream bos;
                    bos = new BufferedOutputStream(fos);
                    bytesRead = is.read(mybytearray,0,mybytearray.length);
                    current = bytesRead;
                    do {
                        bytesRead = is.read(mybytearray,current,(mybytearray.length-current));
                        if(bytesRead >= 0) {
                            current += bytesRead;
                        }
                    } while (bytesRead != 0);
                    bos.write(mybytearray,0,current);
                    bos.flush();
                    bos.close();
                    System.out.println("Client: Received to "+name.toString().replace("my","new"));
                    state = WAITTEXT;
                }
            }
        }
 
        //close everything
        out.close();
        in.close();
        stdIn.close();
        ourSocket.close();
    }
}