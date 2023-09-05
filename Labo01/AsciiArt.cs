public class AsciiArt
{
    public string CreateStaircase(int height, int width)
    {
        string staircase = "";

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < height; j++)
            {
                for (int space = 0; space < (5 - i - 1) * width; space++)
                {
                    staircase += " ";
                }

                for (int k = 0; k < width + i * width; k++) // Modification ici
                {
                    staircase += "#";
                }

                staircase += "\n";
            }
            
        }

        return staircase;
    }
}
