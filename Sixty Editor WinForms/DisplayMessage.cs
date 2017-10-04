using System.Windows.Forms;
using Action = Sixty_Editor_DLL.Action;
using String = Sixty_Editor_DLL.String;

namespace Sixty_Editor_WinForms
{
    public class DisplayMessage : Action
    {
        public override string Template { get { return "DisplayMessage(@String)"; } }

        private String str = new String("string", "String");

        public DisplayMessage()
        {
            SetExpressions(str);
        }

        public override void Execute()
        {
            MessageBox.Show(str);
        }
    }
}
