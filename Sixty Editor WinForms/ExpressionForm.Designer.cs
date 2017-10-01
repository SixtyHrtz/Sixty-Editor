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
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.rbMethod = new System.Windows.Forms.RadioButton();
            this.lMethod = new System.Windows.Forms.Label();
            this.flpMethod = new System.Windows.Forms.FlowLayoutPanel();
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
            this.cbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.Location = new System.Drawing.Point(96, 39);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(356, 21);
            this.cbMethod.TabIndex = 2;
            this.cbMethod.SelectedIndexChanged += new System.EventHandler(this.MethodSelectedIndexChanged);
            // 
            // rbMethod
            // 
            this.rbMethod.AutoSize = true;
            this.rbMethod.Location = new System.Drawing.Point(12, 40);
            this.rbMethod.Name = "rbMethod";
            this.rbMethod.Size = new System.Drawing.Size(57, 17);
            this.rbMethod.TabIndex = 3;
            this.rbMethod.Text = "Метод";
            this.rbMethod.UseVisualStyleBackColor = true;
            // 
            // lMethod
            // 
            this.lMethod.AutoSize = true;
            this.lMethod.Location = new System.Drawing.Point(93, 63);
            this.lMethod.Name = "lMethod";
            this.lMethod.Size = new System.Drawing.Size(45, 13);
            this.lMethod.TabIndex = 4;
            this.lMethod.Text = "lMethod";
            // 
            // flpMethod
            // 
            this.flpMethod.Location = new System.Drawing.Point(96, 79);
            this.flpMethod.Name = "flpMethod";
            this.flpMethod.Size = new System.Drawing.Size(356, 161);
            this.flpMethod.TabIndex = 5;
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
            this.Controls.Add(this.flpMethod);
            this.Controls.Add(this.lMethod);
            this.Controls.Add(this.rbMethod);
            this.Controls.Add(this.cbMethod);
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
        private System.Windows.Forms.ComboBox cbMethod;
        private System.Windows.Forms.RadioButton rbMethod;
        private System.Windows.Forms.Label lMethod;
        private System.Windows.Forms.FlowLayoutPanel flpMethod;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.RadioButton rbValue;
    }
}