using System.Collections.Generic;

namespace FactoryMethod
{
    /// <summary>

    /// The 'Creator' abstract class

    /// </summary>

    public abstract class Document

    {
        // Constructor calls abstract Factory method

        public Document()
        {
            CreatePages();
        }

        public List<Page> Pages { get; } = new List<Page>();

        // Factory Method
        public abstract void CreatePages();

    }
}