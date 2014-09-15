using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    //An adapter helps two incompatible interfaces to work together. This is the real world definition for an adapter. 
    //The adapter design pattern is used when you want two different classes with incompatible interfaces to work together. 
    //Interfaces may be incompatible but the inner functionality should suit the need. 
    //The Adapter pattern allows otherwise incompatible classes to work together by converting the interface of one class into an interface expected by the clients
    //The adapter pattern is useful in situations where an already existing class provides some or all of the services you need but does not use the interface you need
    class AdapterPattern
    {
        public void ExecutePattern()
        {
            TextDocument d = new DocumentAdapter();
            Console.Write("Using Adapter calling GetTextDocument: ");
            d.GetTextDocument();

        }

        class TextDocument//Target or final class that will be used
        {
            public virtual void GetTextDocument()
            {
                Console.WriteLine("Returns Text Document");
            }
        }

        class DocumentAdapter : TextDocument //Adapter adapts the text document to generate XML
        {
            public override void GetTextDocument()
            {
                //override the textdocument method and returns the XML Document instead of text document
                new XMLDocument().GetXMLDocument();
            }
        }

        class XMLDocument //Adaptee
        {
            public void GetXMLDocument()
            {
                Console.WriteLine("Returns XML Document");
            }
        }

    }

}
