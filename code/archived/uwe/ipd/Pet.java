package assignment3;

/**
 *
 * -creationdate = 14-Mar-2012
 * -version      = 1
 * 
 */
public class Pet {
    
    String name;
    String species;
    int age;
    
    public Pet(String name, String species, int age)
    {
        this.name = name;
        this.species = species;
        this.age = age;
    }
    
    public String getName() {return name;}
    public void setName(String name) {this.name = name;}
    public String getSpecies() {return species;}
    public void setSpecies(String species) {this.species = species;}
    public int getAge() {return age;}
    public void setAge(int age) {this.age = age;}
    
    //needs override as toString
    @Override
    public String toString() {
        return (name + " (" + species + ") aged " + age);
    }
    
}
