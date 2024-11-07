using GOF.Creationals._FactoryMethod.Generic;
using GOF.Creationals._FactoryMethod.RealWorld;

namespace GOF.Creationals._FactoryMethod
{
    /// <summary>
    /// <para>The Factory Method design pattern defines an interface for creating an object, but let subclasses decide which class to instantiate.</para>
    /// <para>This pattern lets a class defer instantiation to subclasses.</para>
    /// </summary>
    internal class FactoryMethodPattern : IDesignPattern
    {
        public void GenericCase()
        {
            Creator[] creators = [new ConcreteCreatorA(), new ConcreteCreatorB()];

            foreach(var creator in creators)
            {
                Product product = creator.FactoryMethod();

                Console.WriteLine("Created {0}", product.GetType().Name);
            }
        }
        
        public void RealLifeCase()
        {
            List<Document> documents = [new Resume(), new Report()];

            documents.ForEach(document =>
            {
                document.CreatePages();

                Console.WriteLine($"{document} --");
                document.Pages.ForEach(page => Console.WriteLine($" {page} "));
                Console.WriteLine();
            });
        }
    }
}
