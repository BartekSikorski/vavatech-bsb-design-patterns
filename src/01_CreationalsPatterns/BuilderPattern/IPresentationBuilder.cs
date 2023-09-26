using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BuilderPattern
{
    // Abstract Builder
    public interface IPresentationBuilder
    {
        void AddSlide(Slide slide);
        void AddFooter();
    }
}
