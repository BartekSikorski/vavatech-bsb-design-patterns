namespace BuilderPattern
{
    // Concrete Builder A
    public class PdfPresentationBuilder : IPresentationBuilder
    {
        // Product
        private PdfDocument pdf = new PdfDocument();

        public void AddFooter()
        {            
        }

        public void AddSlide(Slide slide)
        {
            pdf.AddPage(slide.Text);
        }

        // Returns Product A
        public PdfDocument GetPdfDocument()
        {
            return pdf;
        }
    }
}
