/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package assignment2;

import java.util.Scanner;
import java.lang.Math;
import java.text.DecimalFormat;
import java.text.NumberFormat;

public class PowerSquare {
    
    public static void main(String[] args) {
        
        System.out.print("Enter 2 numbers: ");//what to do
        Scanner scan = new Scanner (System.in);// start the scanner
        double num1 = scan.nextDouble();//read dbl 1
        double num2 = scan.nextDouble();//read dbl 2
        num2 = Math.abs(num2);//make sure we dont sqrt a negative in a second
        num1 = num1 * num1 * num1;//cube num1
        num2 = Math.sqrt(num2);//sqrt num2
        double result = Math.max(num2, num1); //find the largest number
        
        NumberFormat formatter = new DecimalFormat("#0.00"); //setup the mask
        System.out.println(formatter.format(result));//print output
        
        
    }
}
