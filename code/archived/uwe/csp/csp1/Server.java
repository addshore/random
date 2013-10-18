/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package csp1;

import java.io.*;
import java.net.*;
 
public class Server {
    
    public static int[] counter = new int[3];
    public static boolean[] lock = new boolean[3];
    
    public static void main(String[] args) throws IOException {
        
        counter[0] = 0;
        counter[1] = 0;
        counter[2] = 0;
        lock[0] = false;
        lock[1] = false;
        lock[2] = false;
        
        ServerSocket serverSocket = null;
        boolean listening = true;

        try {
            serverSocket = new ServerSocket(2222);
        } catch (IOException e) {
            System.err.println("Could not listen on port: 2222.");
            System.exit(-1);
        }

        while (listening) {
            new ServerThread(serverSocket.accept()).start();
        }

        serverSocket.close();
    }
}