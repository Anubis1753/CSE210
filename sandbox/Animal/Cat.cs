class Cat : Animal 
{
    public Cat(string name) : base(name)
        {
                
        }


    // Overidden behavior
    public override void MakeNoise()
    {
        Console.WriteLine($"{_name} says 'meow!");
    }
}