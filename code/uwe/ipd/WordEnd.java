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
    
public class WordEnd {

    public static void main(String[] args) {
        
        String result = "";
        String word;
        int c;
        
        Scanner scan = new Scanner(System.in);
      
        System.out.print("Enter a word: ");
        word = scan.next();
        c = word.length()-1;
      
        while (c >= 0){
            result = word.charAt(c)+result;
            c--;
            System.out.print(result + ",");
        }
        System.out.println("\n");//needed newline
    }

}
//}
