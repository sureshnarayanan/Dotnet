using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    //The composite pattern describes that a group of objects is to be treated in the same way as a single instance of an object. The intent of a composite is 
   //to "compose" objects into tree structures to represent part-whole hierarchies. Implementing the composite pattern lets clients treat individual objects and 
    //compositions uniformly.When dealing with Tree-structured data, programmers often have to discriminate between a leaf-node and a branch. This makes code more 
    //complex, and therefore, error prone. The solution is an interface that allows treating complex and primitive objects uniformly. In object-oriented programming,
    //a composite is an object designed as a composition of one-or-more similar objects, all exhibiting similar functionality. This is known as a "has-a" 
    //relationship between objects.The key concept is that you can manipulate a single instance of the object just as you would manipulate a group of them. 
    //The operations you can perform on all the composite objects often have a least common denominator relationship. For example, if defining a system to portray 
    //grouped shapes on a screen, it would be useful to define resizing a group of shapes to have the same effect (in some sense) as resizing a single shape
    class CompositePattern
    {
        public void ExecutePattern()
        {
            DocumentList d = new DocumentList();
            d.Add(new TextDocument());
            d.Add(new TextDocument());
            d.Add(new XMLDocument());
            d.Add(new XMLDocument());

            d.GetDocument();
        }

        public interface IDocument //Component
        {
            void GetDocument();
        }


        class TextDocument : IDocument
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


        public class DocumentList : IDocument //Composite
        {
            List<IDocument> documentList;

            public DocumentList()
            {
                documentList = new List<IDocument>();
            }

            public void Add(IDocument document)
            {
                documentList.Add(document);
            }

            public void GetDocument()
            {
                foreach (IDocument d in documentList)
                {
                    d.GetDocument();
                }
            }
        }
       
    }

      
}
