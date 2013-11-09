/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package csp1;

import java.io.*;
import java.net.*;

public class ServerThread extends Thread {
    private Socket socket = null;

    public ServerThread(Socket socket) {
	super("ServerThread");
	this.socket = socket;
    }

    public void run() {

	try {
	    PrintWriter out = new PrintWriter(socket.getOutputStream(), true);
	    BufferedReader in = new BufferedReader(new InputStreamReader(socket.getInputStream()));

	    String inputLine, outputLine;
	    Protocol csp = new Protocol();
	    outputLine = csp.processInput(null);
	    out.println(outputLine);

            //while we have input lines
	    while ((inputLine = in.readLine()) != null) {
		outputLine = csp.processInput(inputLine);
		if (outputLine.equals("Connection closed")) {
                    break;
                //if a file has been downloaded then output the client and counters
                }else if (outputLine.equals("The program displays a message - Another? Y or N?")){
                    counterInc(0);
                }else if (outputLine.equals("This picture shows a man at work - Another? Y or N?")){
                    counterInc(1);
                }else if (outputLine.equals("The book is about unknowns - Another? Y or N?")) {
                    counterInc(2);
                }
                out.println(outputLine);
	    }
            
            //close everything
	    out.close();
	    in.close();
	    socket.close();

            //catch any errors
	} catch (IOException e) {
	    e.printStackTrace();
	}
    }
    
    //increment a counter
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