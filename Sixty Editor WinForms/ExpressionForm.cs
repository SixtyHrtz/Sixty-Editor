using Sixty_Editor_DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sixty_Editor_WinForms
{
    // TODO : Создание и работа констант схожим с функциями образом
    // TODO : Создание функций и констант один раз, потом брать ссылки
    // TODO : Сброс функции или значения в зависимости от типа при выходе

    public partial class ExpressionForm : Form
    {
        private IExpression expression;
        private IFunction function;

        private List<LinkLabel> functionLinkList;

        public ExpressionForm(IExpression expression)
        {
            InitializeComponent();
            functionLinkList = new List<LinkLabel>();

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
            if (!expression.AllowedExpressionType.HasFlag(ExpressionType.Function))
            {
                cbFunction.Visible = false;
                rbFunction.Visible = false;
                lFunction.Visible = false;
                flpFunction.Visible = false;
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
                case ExpressionType.Function: rbFunction.Checked = true; break;
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
            if (expression.AllowedExpressionType.HasFlag(ExpressionType.Function))
            {
                cbFunction.Items.AddRange(expression.Functions);
                if (cbFunction.Items.Count != 0)
                    cbFunction.SelectedIndex = 0;
            }
        }

        private void SetExpressionValues()
        {
            switch (expression.ExpressionType)
            {
                case ExpressionType.Constant:
                    cbConstant.SelectedItem = expression.Constants.First(x => x.Value == expression.BaseValue);
                    break;
                case ExpressionType.Function:
                    cbFunction.SelectedItem = expression.Functions.First(x => x.Type == function.Type);
                    function = expression.Function;
                    CreateFunctionControls();
                    break;
                case ExpressionType.Value:
                    tbValue.Text = expression.BaseValue;
                    break;
            }
        }

        private void FunctionSelectedIndexChanged(object sender, EventArgs e)
        {
            function = ((IFunctionInfo)cbFunction.SelectedItem).GetFunction();
            CreateFunctionControls();
        }

        private void CreateFunctionControls()
        {
            foreach (LinkLabel link in functionLinkList)
                link.Dispose();
            functionLinkList.Clear();

            foreach (IExpression expression in function.Expressions)
            {
                LinkLabel link = new LinkLabel()
                {
                    Parent = flpFunction,
                    Tag = expression
                };

                link.Click += (se, ea) =>
                {
                    ShowSubForm(expression);
                    UpdateFunctionInfo();
                };

                functionLinkList.Add(link);
            }

            UpdateFunctionInfo();
        }

        private void UpdateFunctionInfo()
        {
            foreach (LinkLabel link in functionLinkList)
            {
                link.Text = ((IExpression)link.Tag).ToString();
                link.Width = Helper.GetTextWidth(link.Text);
            }

            lFunction.Text = function.Inspect();
            rbFunction.Checked = true;
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
            else if (rbFunction.Checked)
            {
                expression.Function = function;
                expression.ExpressionType = ExpressionType.Function;
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
