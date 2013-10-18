/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package assignment3;

/**
 *
 * -creationdate = 14-Mar-2012
 * -version      = 1
 * 
 */
public class Metal {
    
     private String name;
     private int costPerUnitWeight ;
    
    Metal(String value, int cpuw)
    {
        name = value;
        costPerUnitWeight = cpuw;
    }

    public String getName() {return name;}
    public void setName(String name) {this.name = name;}
    
    public int getCostPerUnitWeight() {return costPerUnitWeight;}
    public void setCostPerUnitWeight(int costPerUnitWeight) {this.costPerUnitWeight = costPerUnitWeight;}
    
}
