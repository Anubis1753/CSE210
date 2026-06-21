class Dog : Animal 
{
    public Dog(string name) : base(name)
            {
                
            }


    // Overidden behavior
    public override void MakeNoise()
    {
        Console.WriteLine($"{_name} says 'bark!");
    }
}