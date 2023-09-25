using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodTemplate.Razor
{
    public interface IViewEngine
    {
        string Render(string viewName, IDictionary<string, object> context);
    }

    public class RazorViewEngine : IViewEngine
    {
        public string Render(string viewName, IDictionary<string, object> context)
        {
            return "View rendered by Razor";
        }
    }

    public class HugoViewEngine : IViewEngine
    {
        public string Render(string viewName, IDictionary<string, object> context)
        {
            return "View rendered by Hugo";
        }
    }
}
