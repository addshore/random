/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package assignment2;

import java.io.IOException;
import java.util.ArrayList;
import java.util.Scanner;

public class BigWord {
    
    public static void main(String[] args) throws IOException {
        
        //define stuff
        ArrayList<String> inputarray = new ArrayList<String>(); 
        String result = "";
        String input;
        
        //start the scanner
        System.out.print ("Please enter 3 words: ");
        Scanner scan = new Scanner (System.in);
        
        //Read all of the words over multiple lines
        do{
        input = scan.nextLine(); //read a line

        String words[] = input.split(" ");//split the line whenever there is a space (to parse the words individually)
        for(String word : words)
        {
            if(word.length() > 0)//make sure the array entry is a word and not empty before adding it to the list
            {
                inputarray.add(word);
            }
        }
        
        
        } while(inputarray.size() < 3); //make sure we have 3 words else keep trying
        
        //convert the array list to a string array
        String[] words = inputarray.toArray(new String[inputarray.size()]);  
        
        //Check to find the biggest word
        for(int i = 0; i < words.length; i++){
            if( words[i].length() > result.length() ){
                result = words[i];
            }
        }      
        
        //output result
        System.out.println(result);

        
    }
}