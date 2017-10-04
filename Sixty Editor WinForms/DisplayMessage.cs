using System.Windows.Forms;
using Action = Sixty_Editor_DLL.Action;
using String = Sixty_Editor_DLL.String;

namespace Sixty_Editor_WinForms
{
    public class DisplayMessage : Action
    {
        public override string Template { get { return "DisplayMessage(@msg)"; } }

        private String msg = new String("message", "msg");

        public DisplayMessage()
        {
            SetExpressions(msg);
        }

        public override void Execute()
        {
            MessageBox.Show(msg);
        }
    }
}
