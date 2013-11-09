/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package assignment2;

import java.util.Scanner;

public class Repeated {
    
    public static void main(String[] args) {
        
        System.out.println("Please enter lines of text:");
        Scanner scan = new Scanner(System.in);
        String previous = "";
        String current = "";
        
        do{
            current = scan.nextLine();
            if( (previous.equals(current)) && (!previous.equals("")))
            {
                System.out.println("Repeated: " + current);
            }
            previous = current;
        } while(!previous.equals(""));
        
        System.err.println("Farewell");
        
    }
}
