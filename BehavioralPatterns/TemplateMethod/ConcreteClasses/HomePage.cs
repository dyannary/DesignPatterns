using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.AbstractClass;

namespace TemplateMethod.ConcreteClasses
{
    class HomePage : WebPageTemplate
    {
        protected override void RenderContent()
        {
            Console.WriteLine("<h1>Welcome to the Homepage</h1>");
            Console.WriteLine("<p>This is the main content of the homepage.</p>");
        }
    }
}

