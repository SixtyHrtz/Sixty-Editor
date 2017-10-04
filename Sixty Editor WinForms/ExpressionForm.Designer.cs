namespace Sixty_Editor_WinForms
{
    partial class ExpressionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbConstant = new System.Windows.Forms.ComboBox();
            this.rbConstant = new System.Windows.Forms.RadioButton();
            this.cbFunction = new System.Windows.Forms.ComboBox();
            this.rbFunction = new System.Windows.Forms.RadioButton();
            this.lFunction = new System.Windows.Forms.Label();
            this.flpFunction = new System.Windows.Forms.FlowLayoutPanel();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.rbValue = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cbConstant
            // 
            this.cbConstant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConstant.FormattingEnabled = true;
            this.cbConstant.Location = new System.Drawing.Point(96, 12);
            this.cbConstant.Name = "cbConstant";
            this.cbConstant.Size = new System.Drawing.Size(356, 21);
            this.cbConstant.TabIndex = 0;
            this.cbConstant.SelectedIndexChanged += new System.EventHandler(this.ConstantSelectedIndexChanged);
            // 
            // rbConstant
            // 
            this.rbConstant.AutoSize = true;
            this.rbConstant.Location = new System.Drawing.Point(12, 13);
            this.rbConstant.Name = "rbConstant";
            this.rbConstant.Size = new System.Drawing.Size(78, 17);
            this.rbConstant.TabIndex = 1;
            this.rbConstant.Text = "Константа";
            this.rbConstant.UseVisualStyleBackColor = true;
            // 
            // cbMethod
            // 
            this.cbFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFunction.FormattingEnabled = true;
            this.cbFunction.Location = new System.Drawing.Point(96, 39);
            this.cbFunction.Name = "cbMethod";
            this.cbFunction.Size = new System.Drawing.Size(356, 21);
            this.cbFunction.TabIndex = 2;
            this.cbFunction.SelectedIndexChanged += new System.EventHandler(this.FunctionSelectedIndexChanged);
            // 
            // rbMethod
            // 
            this.rbFunction.AutoSize = true;
            this.rbFunction.Location = new System.Drawing.Point(12, 40);
            this.rbFunction.Name = "rbMethod";
            this.rbFunction.Size = new System.Drawing.Size(57, 17);
            this.rbFunction.TabIndex = 3;
            this.rbFunction.Text = "Метод";
            this.rbFunction.UseVisualStyleBackColor = true;
            // 
            // lMethod
            // 
            this.lFunction.AutoSize = true;
            this.lFunction.Location = new System.Drawing.Point(93, 63);
            this.lFunction.Name = "lMethod";
            this.lFunction.Size = new System.Drawing.Size(45, 13);
            this.lFunction.TabIndex = 4;
            this.lFunction.Text = "lMethod";
            // 
            // flpMethod
            // 
            this.flpFunction.Location = new System.Drawing.Point(96, 79);
            this.flpFunction.Name = "flpMethod";
            this.flpFunction.Size = new System.Drawing.Size(356, 161);
            this.flpFunction.TabIndex = 5;
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(96, 248);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(275, 20);
            this.tbValue.TabIndex = 6;
            this.tbValue.TextChanged += new System.EventHandler(this.ValueTextChanged);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(377, 246);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 7;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.SaveClick);
            // 
            // rbValue
            // 
            this.rbValue.AutoSize = true;
            this.rbValue.Checked = true;
            this.rbValue.Location = new System.Drawing.Point(12, 249);
            this.rbValue.Name = "rbValue";
            this.rbValue.Size = new System.Drawing.Size(73, 17);
            this.rbValue.TabIndex = 8;
            this.rbValue.TabStop = true;
            this.rbValue.Text = "Значение";
            this.rbValue.UseVisualStyleBackColor = true;
            // 
            // ExpressionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.rbValue);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.flpFunction);
            this.Controls.Add(this.lFunction);
            this.Controls.Add(this.rbFunction);
            this.Controls.Add(this.cbFunction);
            this.Controls.Add(this.rbConstant);
            this.Controls.Add(this.cbConstant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ExpressionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expression Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbConstant;
        private System.Windows.Forms.RadioButton rbConstant;
        private System.Windows.Forms.ComboBox cbFunction;
        private System.Windows.Forms.RadioButton rbFunction;
        private System.Windows.Forms.Label lFunction;
        private System.Windows.Forms.FlowLayoutPanel flpFunction;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.RadioButton rbValue;
    }
}