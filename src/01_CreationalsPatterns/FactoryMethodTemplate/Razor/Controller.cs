using System.Collections.Generic;

namespace FactoryMethodTemplate.Razor
{
    public class Controller
    {
        public string Render(string viewName, IDictionary<string, object> context)
        {
            var engine = CreateEngine(); // Factory Method
            var html = engine.Render(viewName, context);

            return html;
        }

        protected virtual IViewEngine CreateEngine()
        {
            return new RazorViewEngine();
        }
    }

    public class HugoController : Controller
    {
        protected override IViewEngine CreateEngine()
        {
            return new HugoViewEngine();
        }
    }
}
