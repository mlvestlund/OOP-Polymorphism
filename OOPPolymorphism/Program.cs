namespace OOPPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry rectangle = new Rectangle();
            Console.WriteLine($"Area rektangel: {rectangle.Area():0.#}");

            Geometry square = new Square();
            Console.WriteLine($"Area fyrkant: {square.Area():0.#}");

            Geometry circle = new Circle();
            Console.WriteLine($"Area cirkel: {circle.Area():0.#}");

            Geometry parallelogram = new Parallelogram();
            Console.WriteLine($"Area parallellogram: {parallelogram.Area():0.#}");

            Geometry ellipse = new Ellipse();
            Console.WriteLine($"Area ellips: {ellipse.Area():0.#}");
        }
    }
}