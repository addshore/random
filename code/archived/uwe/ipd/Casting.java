package assignment1;

/**
 *
 * -creationdate = 25-Oct-2011
 * -version      = 1
 * 
 */

import java.util.Scanner;

public class Casting {

    public static void main(String[] args) {
        
        //Create the scanner
        Scanner scan = new Scanner (System.in);
        
        //And the variables we will store our numbers in 
        double number1,number2,number1dbl,number2dbl,result2;
        int number1int,number2int,result1;

        //Collect the numbers and store them in variables
        System.out.print ("Enter number 1: ");
        number1 = scan.nextDouble();
        System.out.print ("Enter number 2: ");
        number2 = scan.nextDouble();
        
        //Cast the doubles to ints
        number1int = (int) number1;
        number2int = (int) number2;
        //Cast the ints to doubles
        number1dbl = (double) number1int;
        number2dbl = (double) number2int;
        
        result1 = number2int / number1int;
        result2 = number2dbl / number1dbl;
        
        //Output the results
        System.out.println ("Integer result = " + result1 );
        System.out.println ("Double result = " + result2 );
    }
}
