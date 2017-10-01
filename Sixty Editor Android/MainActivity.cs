using Android.App;
using Android.OS;
using Android.Widget;
using Sixty_Editor_DLL;
using System.Collections.Generic;

namespace Sixty_Editor_Android
{
    [Activity(Label = "Sixty Editor", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        #region TEMP
        private List<IExpression> expressions;
        #endregion

        private List<TextView> actionLinkList;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            actionLinkList = new List<TextView>();

            expressions = new List<IExpression>
                {
                    new Integer(10, "A")
                };

            foreach (IExpression expression in expressions)
            {
                TextView link = new TextView(this)
                {
                    //Tag = expression
                };

                link.Click += (se, ea) =>
                {
                    //ExpressionForm.ShowSubForm(expression);
                    //UpdateActionInfo();
                };

                actionLinkList.Add(link);
            }

            //UpdateActionInfo();
        }

        private void UpdateActionInfo()
        {
            foreach (TextView link in actionLinkList)
            {
                link.Text = ((IExpression)link.Tag).ToString();
            }
        }

        private void EvaluateClick(object sender, System.EventArgs e)
        {

        }
    }
}

