using Sixty_Editor_DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sixty_Editor_WinForms
{
    // TODO : Создание и работа констант схожим с методами образом
    // TODO : Создание методов и констант один раз, потом брать ссылки
    // TODO : Сброс метода или значения в зависимости от типа при выходе

    public partial class ExpressionForm : Form
    {
        private IExpression expression;
        private IMethod method;

        private List<LinkLabel> methodLinkList;

        public ExpressionForm(IExpression expression)
        {
            InitializeComponent();
            methodLinkList = new List<LinkLabel>();

            this.expression = expression;

            ShowAllowedControls();
            SetExpressionType();
            FillComboBoxItems();
            SetExpressionValues();
        }

        private void ShowAllowedControls()
        {
            if (!expression.AllowedExpressionType.HasFlag(ExpressionType.Constant))
            {
                cbConstant.Visible = false;
                rbConstant.Visible = false;
            }
            if (!expression.AllowedExpressionType.HasFlag(ExpressionType.Method))
            {
                cbMethod.Visible = false;
                rbMethod.Visible = false;
                lMethod.Visible = false;
                flpMethod.Visible = false;
            }
            if (!expression.AllowedExpressionType.HasFlag(ExpressionType.Value))
            {
                rbValue.Visible = false;
                tbValue.Visible = false;
            }
        }

        private void SetExpressionType()
        {
            switch (expression.ExpressionType)
            {
                case ExpressionType.Constant: rbConstant.Checked = true; break;
                case ExpressionType.Method: rbMethod.Checked = true; break;
                case ExpressionType.Value: rbValue.Checked = true; break;
            }
        }

        private void FillComboBoxItems()
        {
            if (expression.AllowedExpressionType.HasFlag(ExpressionType.Constant))
            {
                cbConstant.Items.AddRange(expression.Constants);
                if (cbConstant.Items.Count != 0)
                    cbConstant.SelectedIndex = 0;
            }
            if (expression.AllowedExpressionType.HasFlag(ExpressionType.Method))
            {
                cbMethod.Items.AddRange(expression.Methods);
                if (cbMethod.Items.Count != 0)
                    cbMethod.SelectedIndex = 0;
            }
        }

        private void SetExpressionValues()
        {
            switch (expression.ExpressionType)
            {
                case ExpressionType.Constant:
                    cbConstant.SelectedItem = expression.Constants.First(x => x.Value == expression.BaseValue);
                    break;
                case ExpressionType.Method:
                    cbMethod.SelectedItem = expression.Methods.First(x => x.Type == method.Type);
                    method = expression.Method;
                    CreateMethodControls();
                    break;
                case ExpressionType.Value:
                    tbValue.Text = expression.BaseValue;
                    break;
            }
        }

        private void MethodSelectedIndexChanged(object sender, EventArgs e)
        {
            method = ((IMethodInfo)cbMethod.SelectedItem).GetMethod();
            CreateMethodControls();
        }

        private void CreateMethodControls()
        {
            foreach (LinkLabel link in methodLinkList)
                link.Dispose();
            methodLinkList.Clear();

            foreach (IExpression expression in method.Expressions)
            {
                LinkLabel link = new LinkLabel()
                {
                    Parent = flpMethod,
                    Tag = expression
                };

                link.Click += (se, ea) =>
                {
                    ShowSubForm(expression);
                    UpdateMethodInfo();
                };

                methodLinkList.Add(link);
            }

            UpdateMethodInfo();
        }

        private void UpdateMethodInfo()
        {
            foreach (LinkLabel link in methodLinkList)
            {
                link.Text = ((IExpression)link.Tag).ToString();
                link.Width = Helper.GetTextWidth(link.Text);
            }

            lMethod.Text = method.Inspect();
            rbMethod.Checked = true;
        }

        public static void ShowSubForm(IExpression expression)
        {
            ExpressionForm form = new ExpressionForm(expression);
            form.ShowDialog();
            form.Close();
        }

        private void ConstantSelectedIndexChanged(object sender, System.EventArgs e)
        {
            rbConstant.Checked = true;
        }

        private void ValueTextChanged(object sender, System.EventArgs e)
        {
            rbValue.Checked = true;
        }

        private void SaveClick(object sender, System.EventArgs e)
        {
            if (rbConstant.Checked)
            {
                expression.BaseValue = ((IConstantInfo)cbConstant.SelectedItem).Value;
                expression.ExpressionType = ExpressionType.Constant;
            }
            else if (rbMethod.Checked)
            {
                expression.Method = method;
                expression.ExpressionType = ExpressionType.Method;
            }
            else if (rbValue.Checked)
            {
                expression.BaseValue = tbValue.Text;
                expression.ExpressionType = ExpressionType.Value;
            }

            Close();
        }
    }
}
