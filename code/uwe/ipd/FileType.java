/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package assignment2;

import java.util.Scanner;

public class FileType {
    
    public static void main(String[] args) {
        

        System.out.println ("Enter file names (blank line to end) :");
        String currline;
        Scanner scan = new Scanner (System.in);
        do{
            currline = scan.nextLine();
            if(currline.endsWith(".txt"))
            {
                System.out.println("Text File: "+ currline);
            }
            else if(currline.contains((CharSequence)"del"))
            {
                System.out.println("Delete: "+ currline);
            }
            
        } while( !"".equals(currline));
    }
}
