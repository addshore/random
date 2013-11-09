/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package assignment3;

import java.util.Scanner;

/**
 *
 * -creationdate = 14-Mar-2012
 * -version      = 1
 * 
 */

public class Longer {

    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);
        System.out.print("Enter 2 words: ");
        
        String w1, w2,r;
        w1 = scan.next();
        w2 = scan.next();
        
        
        System.out.println(longest(w1,w2));
    }
    
    public static String longest(String w1, String w2) {
        if (w2.length() > w1.length()) {return w2;} else {return w1;}
    }
}
