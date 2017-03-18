public class Chef
{
    public void Cook()
    {
        Potato potato = GetPotato();
        Carrot carrot = GetCarrot();
        Bowl bowl = GetBowl();

        Peel(potato);
        Peel(carrot);

        Cut(potato);
        Cut(carrot);

        bowl.Add(carrot);
        bowl.Add(potato);
    }

    private Potato GetPotato()
    {
        //...
    }

    private Carrot GetCarrot()
    {
        //...
    }

    private Bowl GetBowl()
    {
        //... 
    }

    private void Cut(Vegetable potato)
    {
        //...
    }
}