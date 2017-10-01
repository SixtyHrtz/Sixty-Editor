using System.Drawing;
using System.Windows.Forms;

namespace Sixty_Editor_WinForms
{
    public static class Helper
    {
        public static int GetTextWidth(string text)
        {
            return TextRenderer.MeasureText(text, SystemFonts.DefaultFont).Width;
        }
    }
}
