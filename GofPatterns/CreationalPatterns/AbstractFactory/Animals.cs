using System;

namespace AbstractFactory
{
    /// <summary>
    /// The 'ProductA1' class
    /// </summary>
    public class Wildebeest : Herbivore
    {

    }

    /// <summary>
    /// The 'ProductB1' class
    /// </summary
    public class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Wildebeest
            Console.WriteLine(this.GetType().Name + " come " + h.GetType().Name);
        }

    }

    /// <summary>
    /// The 'ProductA2' class
    /// </summary>
    public class Bison : Herbivore
    {

    }

    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Bison
            Console.WriteLine(this.GetType().Name + " come " + h.GetType().Name);
        }
    }
}