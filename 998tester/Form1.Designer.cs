namespace _998tester
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            button5 = new Button();
            button4 = new Button();
            label8 = new Label();
            label7 = new Label();
            button3 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            statusStrip1 = new StatusStrip();
            label9 = new Label();
            label11 = new Label();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(339, 25);
            label1.TabIndex = 1;
            label1.Text = "Welcome to the 998Toolbox by Lixkote.";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 28);
            label2.Name = "label2";
            label2.Size = new Size(597, 45);
            label2.TabIndex = 2;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 88);
            label3.Name = "label3";
            label3.Size = new Size(253, 15);
            label3.TabIndex = 3;
            label3.Text = "More info on the project's official github page:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(257, 88);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(217, 15);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://github.com/Lixkote/998Toolbox";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(0, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 142);
            tabControl1.TabIndex = 6;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(linkLabel1);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 25);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 113);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Info";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox5);
            tabPage1.Controls.Add(pictureBox4);
            tabPage1.Controls.Add(pictureBox3);
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 25);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 113);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Theme";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Interface.replace;
            pictureBox5.InitialImage = Interface.replace;
            pictureBox5.Location = new Point(550, 16);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 32);
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Interface.extract;
            pictureBox4.BackgroundImageLayout = ImageLayout.Center;
            pictureBox4.Location = new Point(487, 16);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Interface.test;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(120, 16);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Interface.save;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(62, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Interface.open;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(12, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Segoe UI", 60F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(603, 3);
            label10.Name = "label10";
            label10.Size = new Size(2, 108);
            label10.TabIndex = 17;
            // 
            // button5
            // 
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.Location = new Point(536, 6);
            button5.Name = "button5";
            button5.Size = new Size(61, 64);
            button5.TabIndex = 16;
            button5.Text = "Replace";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.UseVisualStyleBackColor = true;
            button5.UseWaitCursor = true;
            // 
            // button4
            // 
            button4.Location = new Point(477, 6);
            button4.Name = "button4";
            button4.Size = new Size(53, 64);
            button4.TabIndex = 14;
            button4.Text = "Extract";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = true;
            button4.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(164, 16);
            label8.Name = "label8";
            label8.Size = new Size(299, 45);
            label8.TabIndex = 13;
            label8.Text = "Note: To test the modified ribbon,\r\nplease first replace the the UiRibbonRes.dll \r\nfile in \"C:\\Windows\\System32\" with your modified one.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Segoe UI", 60F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(469, 3);
            label7.Name = "label7";
            label7.Size = new Size(2, 108);
            label7.TabIndex = 12;
            // 
            // button3
            // 
            button3.Location = new Point(114, 6);
            button3.Name = "button3";
            button3.Size = new Size(44, 64);
            button3.TabIndex = 11;
            button3.Text = "Test";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            button3.UseWaitCursor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(232, 85);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 10;
            label6.Text = "Test the ribbon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 85);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 9;
            label5.Text = "File";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 60F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(106, 2);
            label4.Name = "label4";
            label4.Size = new Size(2, 108);
            label4.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(56, 6);
            button2.Name = "button2";
            button2.Size = new Size(44, 64);
            button2.TabIndex = 1;
            button2.Text = "Save";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Location = new Point(6, 6);
            button1.Name = "button1";
            button1.Size = new Size(44, 64);
            button1.TabIndex = 0;
            button1.Text = "Open";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12.75F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(34, 199);
            label9.Name = "label9";
            label9.Size = new Size(658, 46);
            label9.TabIndex = 5;
            label9.Text = "(In future versions of the app, here you will be able to see the bitmap previews and more,\r\nlike in msstyle editor)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12.75F, FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(34, 267);
            label11.Name = "label11";
            label11.Size = new Size(685, 46);
            label11.TabIndex = 8;
            label11.Text = "(The current version is only able to preview already modified 998 ribbon, to use this function,\r\nplease choose the \"Theme\" tab at the top and click \"Test\".\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(statusStrip1);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "998Toolbox Release 1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel linkLabel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private StatusStrip statusStrip1;
        private Label label4;
        private Button button2;
        private Button button1;
        private Label label8;
        private Label label7;
        private Button button3;
        private Label label6;
        private Label label5;
        private Button button4;
        private Label label10;
        private Button button5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label label9;
        private Label label11;
    }
}