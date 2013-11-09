package assignment2;

public class Book {
    
    private String name;
    private int price;   
    private int number;
    
    public Book(String x){name = x;}
    public int calcTotalValue(){return (price*number);}

    public String getName(){return name;}
    public void setName(String setName) {name = setName;}
    public int getPrice() {return price;}
    public void setPrice(int setPrice) {price = setPrice;}
    public int getNumber() {return number;}
    public void setNumber(int setNumber) {number = setNumber;}
       
}