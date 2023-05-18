using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.AbstractClass
{
    abstract class WebPageTemplate
    {
        public void DisplayPage()
        {
            RenderHeader();
            RenderContent();
            RenderFooter();
        }
        protected abstract void RenderContent();

        protected virtual void RenderHeader()
        {
            Console.WriteLine("<header>Common header content</header>");
        }
        protected virtual void RenderFooter()
        {
            Console.WriteLine("<footer>Common footer content</footer>");
        }
    }
}
