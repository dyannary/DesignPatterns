using TemplateMethod.AbstractClass;
using TemplateMethod.ConcreteClasses;

WebPageTemplate homePage = new HomePage();
homePage.DisplayPage();

Console.WriteLine();

WebPageTemplate aboutPage = new AboutPage();
aboutPage.DisplayPage();