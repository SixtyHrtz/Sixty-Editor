using System;

namespace Sixty_Editor_DLL
{
    public static class MathSE
    {
        public static int Random(int min, int max)
        {
            System.Random random = new System.Random((int)DateTime.Now.Ticks);
            return random.Next(min, max + 1);
        }
    }
}
