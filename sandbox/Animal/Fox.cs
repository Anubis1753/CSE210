class Fox : Animal 
{
    public Fox(string name) : base(name)
        {
                
        }


    // Overidden behavior
    public override void MakeNoise()
    {
        Console.WriteLine($"{_name} says 'Ringa Dinga Dina!");
    }
}