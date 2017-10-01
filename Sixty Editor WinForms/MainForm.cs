using Sixty_Editor_DLL;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sixty_Editor_WinForms
{
    public partial class MainForm : Form
    {
        #region TEMP 
        private List<IExpression> expressions;
        #endregion

        private List<LinkLabel> actionLinkList;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            actionLinkList = new List<LinkLabel>();

            #region TEMP
            expressions = new List<IExpression>
            {
                new Integer(10, "A")
            };

            foreach (IExpression expression in expressions)
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
            #endregion

            UpdateActionInfo();
        }

        private void UpdateActionInfo()
        {
            #region TEMP
            foreach (LinkLabel link in actionLinkList)
            {
                link.Text = ((IExpression)link.Tag).ToString();
                link.Width = Helper.GetTextWidth(link.Text);
            }
            #endregion
        }

        private void EvaluateClick(object sender, System.EventArgs e)
        {
            #region TEMP
            foreach (IExpression expression in expressions)
                MessageBox.Show(expression.Evaluate().BaseValue);
            #endregion
        }
    }
}
