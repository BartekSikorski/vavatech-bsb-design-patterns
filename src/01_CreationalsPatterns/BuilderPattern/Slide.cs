using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Slide
    {
        public string Text { get; }

        public Slide(string text)
        {
            Text = text;
        }
    }

    // Director
    public class Presentation
    {
        private List<Slide> slides = new List<Slide>();

        public void AddSlide(Slide slide)
        {
            slides.Add(slide);
        }

        public void Export(IPresentationBuilder builder)
        {
            builder.AddSlide(new Slide("Copyright"));

            foreach (Slide slide in slides)
            {
                builder.AddSlide(slide);
            }

            builder.AddFooter();
        }
    }

    public enum PresentationFormat
    {
        PDF,
        Image,
        PowerPoint,
        Movie
    }

    public class PdfDocument
    {
        public void AddPage(string text)
        {
            Console.WriteLine($"Add {text} to page to PDF");
        }
    }

    public class Movie
    {
        public void AddFrame(string text, int duration)
        {
            Console.WriteLine($"Add {text} to frame to the movie");
        }
    }
}
