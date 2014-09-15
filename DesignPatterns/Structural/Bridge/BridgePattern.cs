using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
   //The bridge pattern is a design pattern used in software engineering which is meant to "decouple an abstraction from its implementation so that the two can 
    //vary independently". The bridge uses encapsulation, aggregation, and can use inheritance to separate responsibilities into different classes.
    //When a class varies often, the features of object-oriented programming become very useful because changes to a program's code can be made easily with 
    //minimal prior knowledge about the program. The bridge pattern is useful when both the class as well as what it does vary often. The class itself can be 
    //thought of as the implementation and what the class can do as the abstraction. The bridge pattern can also be thought of as two layers of abstraction
    class BridgePattern
    {
        public void ExecutePattern()
        {
            DocumentBase d = new GeneralDocument(new TextDocument());           
            d.GetDocument();

            d = new GeneralDocument(new XMLDocument());
            d.GetDocument();
          
        }

        interface IDocument //Implementor
        {
            void GetDocument();
        }

        abstract class DocumentBase //Abstraction
        {
            protected IDocument document;
            public DocumentBase(IDocument d)
            {
                document = d;
            }

            public abstract void GetDocument();
        }

        class GeneralDocument : DocumentBase //RefinedAbstraction
        {
            public GeneralDocument(IDocument d)
                : base(d)
            {

            }
            public override void GetDocument()
            {
                Console.Write("Called From General Document:");
                document.GetDocument();
            }
        }

        class TextDocument : IDocument //ConcreteImplementor
        {
            public void GetDocument()
            {
                Console.WriteLine("Text Document");
            }
        }

        class XMLDocument : IDocument //ConcreteImplementor
        {
            public void GetDocument()
            {
                Console.WriteLine("XML Document");
            }
        }
       
    }

}
