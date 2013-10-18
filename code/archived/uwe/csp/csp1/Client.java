/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package csp1;

import java.io.*;
import java.net.*;
 
public class Client {
    
    public static void main(String[] args) throws IOException {
 
        Socket ourSocket = null;
        PrintWriter out = null;
        BufferedReader in = null;
 
        //try and connect
        try {
            ourSocket = new Socket("127.0.0.1", 2222);
            out = new PrintWriter(ourSocket.getOutputStream(), true);
            in = new BufferedReader(new InputStreamReader(ourSocket.getInputStream()));
        } catch (UnknownHostException e) {
            System.err.println("Can't find host: 127.0.0.1");
            System.exit(1);
        } catch (IOException e) {
            System.err.println("Couldn't get I/O for the connection to 127.0.0.1");
            System.exit(1);
        }
 
        BufferedReader stdIn = new BufferedReader(new InputStreamReader(System.in));
        String fromServer;
        String fromUser;
 
        //while connected
        while ((fromServer = in.readLine()) != null) {
            System.out.println("Server: " + fromServer);
            if (fromServer.equals("Connection Closed")) {
                //close
                break;
                
            }
             
            fromUser = stdIn.readLine();
            if (fromUser != null) {
                    System.out.println("Client: " + fromUser);
                    out.println(fromUser);
            }
        }
 
        //close everything
        out.close();
        in.close();
        stdIn.close();
        ourSocket.close();
    }
}