using System;
namespace Flyweight
{
    /// <summary>

    /// A 'ConcreteFlyweight' class

    /// </summary>

    class CharacterA : Character

    {

        // Constructor

        public CharacterA()

        {

            this.symbol = 'A';

            this.height = 100;

            this.width = 120;

            this.ascent = 70;

            this.descent = 0;

        }

 

        public override void Display(int pointSize)

        {

            this.pointSize = pointSize;

            Console.WriteLine(this.symbol +

                              " (pointsize " + this.pointSize + ")");

        }

    }

 

    /// <summary>

    /// A 'ConcreteFlyweight' class

    /// </summary>

    class CharacterB : Character

    {

        // Constructor

        public CharacterB()

        {

            this.symbol = 'B';

            this.height = 100;

            this.width = 140;

            this.ascent = 72;

            this.descent = 0;

        }

 

        public override void Display(int pointSize)

        {

            this.pointSize = pointSize;

            Console.WriteLine(this.symbol +

                              " (pointsize " + this.pointSize + ")");

        }

 

    }

 

    // ... C, D, E, etc.

 

    /// <summary>

    /// A 'ConcreteFlyweight' class

    /// </summary>

    class CharacterZ : Character

    {

        // Constructor

        public CharacterZ()

        {

            this.symbol = 'Z';

            this.height = 100;

            this.width = 100;

            this.ascent = 68;

            this.descent = 0;

        }

 

        public override void Display(int pointSize)

        {

            this.pointSize = pointSize;

            Console.WriteLine(this.symbol +

                              " (pointsize " + this.pointSize + ")");

        }

    }
}