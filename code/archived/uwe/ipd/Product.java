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
public class Product {
    
    private String type;
    private Metal metal;
    private int weight;
    
    Product(String type, Metal metal, int weight)
    {    
        this.type=type;
        this.metal=metal;
        this.weight=weight;
    }

    public String getType() {return type;}
    public void setType(String type) {this.type = type;}
    
    public Metal getMetal(){return metal;}
    public void setMetal(Metal name){this.metal=name;}
    
    public int getWeight() {return weight;}
    public void setWeight(int weight) {this.weight = weight;}
    
    public int calcMetalCost(){return(weight*metal.getCostPerUnitWeight());   }
    
}
