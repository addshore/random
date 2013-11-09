package assignment2;

public class Town {

        private String name;
        private int population;
        
        public Town()
        {
            name = "AnyTown";
            population = 10000;
        }
        
        public Town(String x,int y)
        {
            name = x;
            population = y;
        }
        
    public String getName(){return name;}
    public void setName(String x) {name = x;}
    public int getPopulation() {return population;}
    public void setPopulation(int x) {population = x;}
    
    public Town calcBiggest(Town town) {        
        if(town.population > population)
        {return town;}
        else
        {return this;}
        
    }
        
}
