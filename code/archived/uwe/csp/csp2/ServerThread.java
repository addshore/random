/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package csp2;

import java.io.*;
import java.net.*;

public class ServerThread extends Thread {
    private Socket socket = null;
    //private String execLocation;
    private OutputStream os;
    private PrintWriter out;
    private BufferedReader in;

    public ServerThread(Socket socket) {
	super("ServerThread");
	this.socket = socket;
        //this.execLocation = getClass().getProtectionDomain().getCodeSource().getLocation().toString();
    }

    public void run() {

	try {
            os = socket.getOutputStream();
            out = new PrintWriter(os,true);
            in = new BufferedReader(new InputStreamReader(socket.getInputStream()));

	    String inputLine, outputLine;
	    Protocol csp = new Protocol();
	    outputLine = csp.processInput(null);
	    out.println(outputLine);
            OUTER:
            while ((inputLine = in.readLine()) != null) {
                outputLine = csp.processInput(inputLine);
                switch (outputLine) {
                    case "Connection closed":
                        break OUTER;
                    case "The program displays a message - Another? Y or N?":
                        sendFile("myProgram.jar");
                        counterInc(0);
                        break;
                    case "This picture shows a man at work - Another? Y or N?":
                        sendFile("myPicture.jpg");
                        counterInc(1);
                        break;
                    case "The book is about unknowns - Another? Y or N?":
                        sendFile("myBook.txt");
                        counterInc(2);
                        break;
                }
                os.flush();
                out.println(outputLine);
            }
            
            //close everything
	    out.close();
	    in.close();
	    socket.close();
            os.close();

            //catch any errors
	} catch (IOException e) {
	}
    }
    
    private void sendFile(String location) throws FileNotFoundException, IOException{
        out.println("Sending File");
        File myFile = new File (location);
        out.println(location);
        out.println(myFile.length());
        byte [] mybytearray = new byte [(int)myFile.length()];
        FileInputStream fis = new FileInputStream(myFile);
        BufferedInputStream bis = new BufferedInputStream(fis);
        bis.read(mybytearray,0,mybytearray.length);
        os.write(mybytearray,0,mybytearray.length);
        os.flush();
    }
    
    private void counterInc(int counter)
    {
        //increment the correct counter
        
        //if the counter is locked wait
        do {
            //by sleeping
            try {
                Thread.sleep(1000);
            } catch (InterruptedException ex) {
                System.out.println("sleep interrupted");
            }
        } while(Server.lock[counter] == true);
        
        //when it isnt locked, lock it and do out update
        Server.lock[counter] = true;
        
        ///MUST REMAIN THE SAME BELOW
        int tmp=Server.counter[counter];
        try {
            Thread.sleep(5000);
        } catch (InterruptedException ex) {
            System.out.println("sleep interrupted");
        }
        Server.counter[counter]=tmp+1;
        ///MUST REMAIN THE SAME ABOVE
        
        //then remove the lock
        Server.lock[counter] = false;
        
        //output the data
        System.out.println(socket.getInetAddress().getHostAddress()+" - "+socket.getInetAddress().getHostName());
        System.out.println("Downloads: Program="+Server.counter[0]+" Picture="+Server.counter[1]+" E-book="+Server.counter[2]);
    }
}