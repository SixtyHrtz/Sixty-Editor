namespace Sixty_Editor_WinForms
{
    partial class MainForm
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
            this.flpExpressions = new System.Windows.Forms.FlowLayoutPanel();
            this.bEvaluate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpExpressions
            // 
            this.flpExpressions.Location = new System.Drawing.Point(12, 12);
            this.flpExpressions.Name = "flpExpressions";
            this.flpExpressions.Size = new System.Drawing.Size(440, 228);
            this.flpExpressions.TabIndex = 0;
            // 
            // bEvaluate
            // 
            this.bEvaluate.Location = new System.Drawing.Point(377, 246);
            this.bEvaluate.Name = "bEvaluate";
            this.bEvaluate.Size = new System.Drawing.Size(75, 23);
            this.bEvaluate.TabIndex = 2;
            this.bEvaluate.Text = "Вывести";
            this.bEvaluate.UseVisualStyleBackColor = true;
            this.bEvaluate.Click += new System.EventHandler(this.EvaluateClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.bEvaluate);
            this.Controls.Add(this.flpExpressions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sixty Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpExpressions;
        private System.Windows.Forms.Button bEvaluate;
    }
}