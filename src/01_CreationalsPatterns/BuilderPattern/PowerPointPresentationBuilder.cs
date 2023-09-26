using System.Runtime.InteropServices;

namespace BuilderPattern
{
    public class PowerPointPresentationBuilder : IPresentationBuilder
    {
        private readonly Orientation orientation;

        public PowerPointPresentationBuilder(Orientation orientation)
        {
            this.orientation = orientation;
        }

        // Product
        PowerPointDocument document = new PowerPointDocument();

        public void AddSlide(Slide slide)
        {
            document.Add(slide.Text);
        }

        public PowerPointDocument GetDocument()
        {
            return document;
        }

        public void AddFooter()
        {
            document.Add("Thank you!");
        }
    }

    public enum Orientation
    {
        Portrait,
        Landscape,
    }
}
