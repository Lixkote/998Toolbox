using RibbonLib;
using RibbonLib.Interop;

namespace _998tester
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            ribbon1 = new Ribbon();
            label1 = new Label();
            SuspendLayout();
            // 
            // ribbon1
            // 
            ribbon1.Location = new Point(0, 0);
            ribbon1.Name = "ribbon1";
            ribbon1.ResourceIdentifier = null;
            ribbon1.ResourceName = "_998tester.RibbonMarkup.ribbon";
            ribbon1.ShortcutTableResourceName = null;
            ribbon1.Size = new Size(800, 193);
            ribbon1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 214);
            label1.Name = "label1";
            label1.Size = new Size(768, 32);
            label1.TabIndex = 1;
            label1.Text = "Here you can test and preview your modified UIRibbonRes/998 ribbon.";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(ribbon1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Ribbon Preview";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Ribbon ribbon1;
        private Label label1;
    }
}