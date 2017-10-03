using Sixty_Editor_DLL;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sixty_Editor_WinForms
{
    public partial class MainForm : Form
    {
        private Action action;

        private List<LinkLabel> actionLinkList;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            action = new Wait();

            actionLinkList = new List<LinkLabel>();

            foreach (IExpression expression in action.Expressions)
            {
                LinkLabel link = new LinkLabel()
                {
                    Parent = flpExpressions,
                    Tag = expression
                };

                link.Click += (se, ea) =>
                {
                    ExpressionForm.ShowSubForm(expression);
                    UpdateActionInfo();
                };

                actionLinkList.Add(link);
            }

            UpdateActionInfo();
        }

        private void UpdateActionInfo()
        {
            foreach (LinkLabel link in actionLinkList)
            {
                link.Text = ((IExpression)link.Tag).ToString();
                link.Width = Helper.GetTextWidth(link.Text);
            }
        }

        private async void EvaluateClick(object sender, System.EventArgs e)
        {
            await Task.Run(() =>
            {
                action.Evaluate();
            });
        }
    }
}
