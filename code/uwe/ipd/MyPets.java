package assignment3;

import java.util.ArrayList;

/**
 *
 * -creationdate = 14-Mar-2012
 * -version      = 1
 * 
 */
public class MyPets {
    
    private ArrayList<Pet> pets = new ArrayList<Pet>();
    public MyPets() {}
    
    public Pet oldest() {
        
        int oldest = 0;
        Pet oldestPet;
        Pet currentPet;
        
        if (!pets.isEmpty())
        {
            
            oldestPet = pets.get(0);
            
            for (int index = 0; index <= (pets.size()-1); index++)
            {
                
                currentPet = pets.get(index);
                
                if (currentPet.age > oldest)
                {
                    oldestPet = currentPet;
                    oldest = currentPet.age;
                }
            }
            
            return oldestPet;
            
        }
        else //of (!pets.isEmpty())
        {
            return null;
        }
    }
	
    public int numberOfPets() {return pets.size();}
    public void addPet(Pet newPet) {pets.add(newPet);}
    public boolean removePet(Pet dead) {boolean removed = pets.remove(dead);return removed;}
    public void replacePet(Pet oldPet, Pet newPet) {int index = pets.indexOf(oldPet);pets.set(index, newPet);}
    
}
