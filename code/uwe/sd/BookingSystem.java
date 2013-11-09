package OFI;

//Imports for arraylists and the scanner
import java.util.ArrayList;
import java.util.Scanner;
import java.util.concurrent.atomic.AtomicInteger;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class BookingSystem {
    
    //Start the program and give initial options
    public static void main(String[] args) {
        
        //Create an empty bookings list for bookings
        ArrayList<Booking> bookings = new ArrayList<Booking>();
        
        //Setup availible rooms in a list
        ArrayList<Room> rooms = new ArrayList<Room>();
        rooms.add(new Room(1,1,30));
        rooms.add(new Room(2,1,30));
        rooms.add(new Room(3,1,30));
        rooms.add(new Room(4,1,30));
        rooms.add(new Room(5,2,40));
        rooms.add(new Room(6,2,40));
        rooms.add(new Room(7,3,50));
        rooms.add(new Room(8,3,50));
        
        boolean run = true;//Currently we want to run
        
        while(run == true)//Only continue if we want to run
        {
            switch (questionAskInt("What would you like to do?",new String[]{"Book a room","Exit the program"})) {
                case 1://What type of room would you like to book?
                    int tType;//Initiate the variable t (temporary) Type (of room)
                    switch (questionAskInt("What type of room would you like to book?",new String[]{"Single","Double","Family"})) {
                        case 1://single room
                            tType = 1;//Set the temp type to the selected type
                            System.out.print("Your room will contain an internet connection and a minibar\n");//Say what is contained in the room
                            break;
                        case 2://double room
                            tType = 2;
                            System.out.print("Your room will contain a minibar and a tv\n");
                            break;
                        case 3://family room
                            tType = 3;
                            System.out.print("Your room will contain an internet connection and a tv\n");
                            break;
                        default://Error
                            tType = 0;
                            break;
                    }
                    
                    //What day would you like to start your stay on?
                    int tStart = 0;//1-30 (Start a temp variable to store the day)
                    while (tStart == 0){ //While the temp is = 0 (not a day)
                        //What day in april would you like to start your stay?
                        tStart = questionAskInt("What day of the month in April would you like to start your stay?\n"
                                + "Please answer simply with the number day. e.g. '15'");
                        //There are 30 days in april so we want a day from 1 - 30.
                        //If the day entered is not between these then set the temp value back to 0
                        if (tStart < 0 || tStart > 30){tStart = 0;}
                    }
                    //How many nights would you like to stay for?
                    int tLength = questionAskInt("How many nights would you like to stay for?\n"
                            + "Please answer using a number.");
                    
                    //Check the availibility of a room with the specifications given
                    int tRoom = 0;
                    if(tStart + tLength <= 30)
                    {
                        tRoom = checkAvailibility(tType,tStart,tLength,rooms,bookings);
                    }
                    
                    //If tRoom has been set to a room (so not zero)
                    if (tRoom != 0){
                        
                        //Create a room object for the room we are booking
                        Room selectedRoom = null;
                        //Search through the rooms until the correct room number is found and set that to our object
                        for (final Room room : rooms) {
                            if(room.getNumber() == tRoom){selectedRoom = room;}
                        }
                        
                        //Do they want the room?
                        System.out.print("A room is availible and it will cost £"+(selectedRoom.getCost() * tLength)+"\n"); //Calculate the price
                        //Are they happy
                        switch (questionAskInt("Are you happy with this price?",new String[]{"Yes","No"})){
                            case 1://if yes
                               
                                //Get the details for the booking
                                String tName = questionAskString("What is your name?");
                                
                                //Get the email for the customer
                                String tEmail = null;
                                while(tEmail == null)//Keep going until we have a correct email
                                {
                                    tEmail = questionAskString("What is your email address?");
                                    //Check the email against the regex 
                                    String regexExpresion = "^[\\w\\.-]+@([\\w\\-]+\\.)+[A-Z]{2,4}$";  
                                    CharSequence regexToCheck = tEmail;    
                                    Pattern regexPattern = Pattern.compile(regexExpresion,Pattern.CASE_INSENSITIVE);  
                                    Matcher regexMatcher = regexPattern.matcher(regexToCheck);  
                                    if(regexMatcher.matches() != true){
                                        tEmail = null;
                                        System.out.print("Email address not recognised, Please try again.\n");
                                    }
                                }
                                
                                //Create the customer with the details above
                                Customer tCustomer = new Customer(tName,tEmail);
                                
                                //Make the booking with said details
                                Booking tBooking = new Booking(tStart,tLength,selectedRoom,bookings);
                                
                                //Output the final info they need
                                System.out.print("Your reservation number is " + tBooking.getId() + "\n");
                                System.out.print("Please now enter your card details\n");
                                
                                //Get card details
                                String tCardno = questionAskString("What is your card number?");
                                String tCardissue = questionAskString("What is your card issue date? (Format 'mm/yy')");
                                String tCardexpire = questionAskString("What is your card expire date? (Format 'mm/yy')");
                                
                                //Add the card details to customer
                                tCustomer.setCard(new Card(tCardno,tCardissue,tCardexpire));
                                //tCustomer.addCardDetails(tCardno,tCardissue,tCardexpire);
                                
                                //Here the card will be passed off to some other function (in our case it is an empty function that returns true.
                                //In the real case this woudl carry out the transaction and return true if successfull and false if not.
                                if (doPayment(selectedRoom.getCost() * tBooking.getLength(),tCustomer)){
                                    //Payment successfull
                                    System.out.print("Payment and booking confirmed!\n");
                                    System.out.print("Your reservation number is "+tBooking.getId()+"\n");
                                    bookings.add(tBooking);//Add the booking to our confirmed bookings
                                }else{
                                    //Payment unsuccessfull
                                    System.out.print("Payment unsuccesfull!\n");
                                }
                                
                                break;
                            case 2://no
                                System.out.print("We are sorry to hear that you are not happy with our prices\n");
                                break;
                        }
                    }
                    else
                    {
                        //No rooms availible
                        if(tStart + tLength <= 30)
                        {
                            System.out.print("Unfortunatly you cannot book in during the days specified. Please try again.\n");
                        }
                        else
                        {
                            System.out.print("Unfortunatly there are no rooms availible. Please try again.\n");
                        }
                    }
                    
                    
                    break;
                case 2://yes (to closing)
                    //Are you sure (a good idea as if they are all details of bookings would be lost)
                    switch (questionAskInt("Are you sure?",new String[]{"Yes","No"})) {
                        case 1:
                            run = false; //we dont want to keep running
                            break;
                    }
                    break;
            }
        } 
    }
    
    //This is a fake make payment function
    static boolean doPayment(int eAmmount, Customer eCustomer){
        //Return true if successfull
        //Return false if not
        return true;
    }
    
    //Check the avilibility of rooms
    static int checkAvailibility(int type, int start, int length,ArrayList<Room> rooms,ArrayList<Booking> bookings){
        
        //Set a temp room number = 0 (no room)
        int tRoom = 0;
        
        //determine what days we want to book the room for and set to the list
        ArrayList<Integer> daysWanted = new ArrayList<Integer>();
        for(int i = 0;i < length;i++)
            {
                daysWanted.add(start+i);
            }
        
        //lets check every room to see if ti is availible
        for ( Room room : rooms) {
          //Check the room is the right type
          if(room.getType() == type && tRoom == 0){
              
              //We will presume this is the room we will use for now
              tRoom = room.getNumber();
              
              //For every booking we already have recorded
              for (final Booking booking : bookings) {
                  //Where our current room number is the same as that in a booking (so if there is a booking attached to the room)
                  //Then we must check it is not booked for our days
                  if (room.getNumber() == booking.getRoom().getNumber())
                  {
                      
                      //Get the list of days the room is already booked for
                       ArrayList<Integer> daysBooked = new ArrayList<Integer>();
                       for(int i = 0;i < booking.getLength();i++)
                       {
                           daysBooked.add(booking.getStart()+i);
                       }
                       
                       //Check to make sure wanted days do not match booked days
                       for (final int dayWanted : daysWanted)
                       {
                           for (final int dayBooked : daysBooked)
                           {
                               if (dayWanted == dayBooked)
                               {
                                   //As the room is already booked for one of our days we can set the room back to 0
                                   tRoom = 0;
                               }
                           }
                       }
                       
                  }
              }
              
              
          }
        }
        
        //Returns 0 if there is no room
        //Returns with the room number is there is a room
        return tRoom;
    }
    
    ///Ask a question to the user and return the answer (number in array)
    static int questionAskInt(String question, String[] answers)
    {
        int result = 0;
        
        while(result == 0){
            //Start our scanner
            Scanner scan = new Scanner (System.in);

            //Output the question and answeres
            System.out.print (question+"\n");
            for(int i=0; i<answers.length; i++)
            {
                System.out.print ((i+1)+" - "+answers[i]+"\n");
            }
            //Get the answer use has given
            System.out.print ("Answer: ");
            
            //Restrict the input to only be integers
            while (!scan.hasNextInt()) {
                System.out.print("Please enter an integer answer\n");
                scan.next();
            } 
            result = scan.nextInt();
            
            //If it is not in bounds then reset and try again
            if(result < 1 || result > answers.length){
                result = 0;
                System.out.print("Please enter an integer within the bounds.");
            }
        }
        return result;
    }
        static int questionAskInt(String question)
    {
        //Start our scanner
        Scanner scan = new Scanner (System.in);
        //Output the question and answeres
        System.out.print (question+"\n");
        //Get the answer use has given
        System.out.print ("Answer: ");
        //Restrict the input to only be integers
        while (!scan.hasNextInt()) {
            System.out.print("Please enter an integer answer\n");
            scan.next();
        } 
        return scan.nextInt();
    }
        static String questionAskString(String question)
    {
        //Start our scanner
        Scanner scan = new Scanner (System.in);
        //Output the question and answeres
        System.out.print (question+"\n");
        //Get the answer use has given
        System.out.print ("Answer: ");
        return scan.nextLine();
    }
    
}

class Room {
    
    Room(int eNumber, int eType, int eCost){
        number = eNumber;
        type = eType;
        cost = eCost;
    }
    
    private int number;//Room number
    private int type;//Type of room (1,single - 2,double - 3,family)
    private int cost;//Cost of room per night
    
    public int getNumber(){return number;}
    public int getType(){return type;}
    public int getCost(){return cost;}
    
}

class Booking {
        
    Booking(int eStart, int eLength, Room eRoom,ArrayList<Booking> bookings)
    {
        //find out what booking ID we should have
        id = 1;
        for (final Booking booking : bookings) {
            id = booking.id+1;
        }
        
        //Set everything else
        start = eStart;
        length = eLength;
        room = eRoom;
    }
    
    private int id;//Booking id or booking reference
    private int start;//Start date of stay
    private int length;//Number of days in stay
    private Room room;//Room that has been booked
    private Customer customer;//Customer that has booked room
    
    public int getId(){return id;}
    public int getStart(){return start;}
    public int getLength(){return length;}
    public Room getRoom(){return room;}
    public Customer getCustomer(){return customer;}
    
    public void setCustomer(Customer eCustomer){
        customer = eCustomer;
    }
    
}

class Customer {
    
    Customer(String eName, String eEmail)
    {
        id = getNextId();
        name = eName;
        email = eEmail;
    }
    
    private int id;//Id of the customer
    private String name;//Name of customer
    private String email;//Email of customer
    private Card card;
    
    private static AtomicInteger nextId = new AtomicInteger(0);
    private static int getNextId() {
        return nextId.incrementAndGet();
    }
    
    public int getId(){return id;}
    public String getName(){return name;}
    public String getEmail(){return email;}
    public Card getCard(){return card;}
    
    public void setCard(Card eCard){
        card = eCard;
    }
        
}

class Card
{
    Card(String eNumber, String eIssue, String eExpiry)
    {
        number = eNumber;
        issue = eIssue;
        expiry = eExpiry;
    }
    
    private String number;//Number of card
    private String issue;//Issue number of card
    private String expiry;//Expiry of card
    
    public String getNumber(){return number;}
    public String getIssue(){return issue;}
    public String getExpiry(){return expiry;}
    
}