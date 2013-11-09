/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package assignment3;

import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

/**
 *
 * -creationdate = 14-Mar-2012
 * -version      = 1
 * 
 */

public class NumbersInFile {

    public static void main(String[] args) throws FileNotFoundException {

        //definaitions
        int wc = 0;
        int tot =0;
        String loc;
        
        //get the location
        Scanner scan = new Scanner(System.in);
        System.out.println("Enter location of input file:");
        
        //start
        loc = scan.next();
        Scanner fileScanner = new Scanner(new File(loc));
        
        //For each of the scans
      while (fileScanner.hasNext()){
          
          if (fileScanner.hasNextInt()){
               tot = tot + fileScanner.nextInt();
          }
          else
          {
              fileScanner.next();
              wc++;
          }
             
      }
      
        //Final output
        System.out.print(tot + " ");
        System.out.println(wc);
    }

}
