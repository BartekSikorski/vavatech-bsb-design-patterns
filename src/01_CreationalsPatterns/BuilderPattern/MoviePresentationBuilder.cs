namespace BuilderPattern
{
    // Concrete Builder B
    public class MoviePresentationBuilder : IPresentationBuilder
    {
        // Product 
        private Movie movie = new Movie();

        public void AddFooter()
        {
            movie.AddFrame("The End", 10);
        }

        public void AddSlide(Slide slide)
        {
            movie.AddFrame(slide.Text, 3);
        }

        // Returns Product B
        public Movie GetMovie()
        {
            return movie;
        }
    }
}
