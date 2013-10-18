/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package assignment2;

import java.util.Scanner;

public class Oddy {
    
    public static void main(String[] args) {
        
        //set some stuff up
        Scanner scan = new Scanner (System.in);
        int total = 0;
        
        //tell the user what to do
        System.out.print("Please enter two integers: ");
        //read the two numbers
        int num1 = scan.nextInt();
        int num2 = scan.nextInt();
        //lets swap them around so they are in order of size
        if(num1 > num2)
        {
            int num3 = num2;
            num2 = num1;
            num1 = num3;
        }
        
        //Set the counter to the lower of the two numbers
        int i = num1;
        //Start the loop (while still in the range)
        do{
            if ( i%2 != 0 )
            {
                total = total + i;
            }
            //increment the counter.
            i = i + 1;
        } while(i < num2 +1);
        
        System.out.println(total);
    }
}
