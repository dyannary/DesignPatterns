using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.AbstractClass;

namespace TemplateMethod.ConcreteClasses
{
    class AboutPage : WebPageTemplate
    {
        protected override void RenderContent()
        {
            Console.WriteLine("<h1>About Us</h1>");
            Console.WriteLine("<p>This page provides information about our company.</p>");
        }

        protected override void RenderHeader()
        {
            Console.WriteLine("<header>About Us header content</header>");
        }
    }
}
