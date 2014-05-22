using DungeonSharp;

namespace Demo
{
    internal class Program
    {
        private static void Main()
        {
            Grid<Tile> tiles = Generator.Generate(5, 4, 8);
            Renderer.Render(tiles);
        }
    }
}
