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
public class Fruit {
    
    public static void main(String[] args) {
        
        //Give the user the list
        System.out.println ("A Apple");
        System.out.println ("B Blueberry");
        System.out.println ("C Currant");
        System.out.println ("D Dragon Fruit");
        System.out.println ("E Elderberry");
        System.out.println ("F Finger Lime");
        System.out.println ("Choose a fruit from menu above: ");
        
        //Read the input
        //This line is converted to capital before getting the char to ensure it is capital too
        
        
        Scanner sc = new Scanner(System.in);
        char choice = sc.findInLine(".").charAt(0);
        choice = Character.toUpperCase(choice);
        //Scanner scan = new Scanner (System.in);
        
        //String line = scan.next().toUpperCase();
        //String line = scan.nextLine().toUpperCase();
        //char choice = line.charAt(0);
        String returnString;
        
        
        //if(line.length() == 1){
            switch (choice) {
                case 'A':  returnString = "You chose "+'"'+"Apple"+'"';
                         break;
                case 'B':  returnString = "You chose "+'"'+"Blueberry"+'"';
                         break;
                case 'C':  returnString = "You chose "+'"'+"Currant"+'"';
                         break;
                case 'D':  returnString = "You chose "+'"'+"Dragon Fruit"+'"';
                         break;
                case 'E':  returnString = "You chose "+'"'+"Elderberry"+'"';
                         break;
                case 'F':  returnString = "You chose "+'"'+"Finger Lime"+'"';
                         break;
                default: returnString = "That fruit is not on the list";
                         break;
            }
        //}
        //else
        //{
        //    returnString = "That fruit is not on the list";
        //}
        
        System.out.println (returnString);
        
    }
}
