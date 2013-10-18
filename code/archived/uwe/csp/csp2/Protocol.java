/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package csp2;

public class Protocol {
    //define our statuses
    private static final int WAITING = 0;
    private static final int SENTTERMS = 1;
    private static final int SENTOPTIONS = 2;
    private static final int ANOTHER = 3;
 
    //and our current state
    private int state = WAITING;
 
    public String processInput(String theInput) {
        String theOutput = null;
 
        //Is the client waiting?
        if (state == WAITING) {
            theOutput = "Terms of reference. Do you accept? Y or N";
            state = SENTTERMS;
        //Have we sent the client the terms?
        } else if (state == SENTTERMS) {
            if (theInput.equalsIgnoreCase("Y")) {
                theOutput = "1. computer program 2. picture 3. e-book";
                state = SENTOPTIONS;
            } else if (theInput.equalsIgnoreCase("N")) {
                theOutput = "Connection closed";
            } else {
                theOutput = "Invalid input ---Terms of reference. Do you accept? Y or N";
            }
        //Have we sent the client the options?
        } else if (state == SENTOPTIONS) {
            state = ANOTHER;
            if (theInput.equalsIgnoreCase("1")) {
                theOutput = "The program displays a message - Another? Y or N?";
            } else if (theInput.equalsIgnoreCase("2")) {
                theOutput = "This picture shows a man at work - Another? Y or N?";
            } else if (theInput.equalsIgnoreCase("3")) {
                theOutput = "The book is about unknowns - Another? Y or N?";
            } else {
                //if we are sending options then overwrit the previous state
                state = SENTOPTIONS;
                theOutput = "Invalid choice --- 1. computer program 2. picture 3. e-book";
            }
        //Have we asked if they want another?
        } else if (state == ANOTHER) {
            if (theInput.equalsIgnoreCase("Y")) {
                theOutput = "1. computer program 2. picture 3. e-book";
                state = SENTOPTIONS;
            } else if (theInput.equalsIgnoreCase("N")) {
                theOutput = "Connection closed";
            } else {
                theOutput = "Invalid input --- Another? Y or N";
            }
        }
        //return the output
        return theOutput;
    }
}