
//''''''''''''''''''''''''''''''''''''''''
//'Simple tool Coded by GhostInformatics '
//'                   @                  '
//'           Revolution Team            '
//'                                      '
//'                2015           v2.0   '
//''''''''''''''''''''''''''''''''''''''''


// The tool made by Ghost Informatics @ Revolution team
// This tool is updated on 9/13/2017 9:39 PM KSA 
// Version 2.0.0 Released .. Royal Team & Revolution Team
// This tool is not public yet .. no one allowd to use except R&R => Mean Revolution & Royal :p
// Thanks to who helped me .. (Gruce,Mohcen)
// @2017 All right's saved Revolution Team
namespace Revolution_Tool_V1._0
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    public class AlaaTool : Form
    {
        private Button button1;
        private Button button2;
        private Button button3;
        private IContainer components = null;
        //Revolution team
        public AlaaTool()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlaaLaunTool f2 = new AlaaLaunTool();
            f2.ShowDialog(); // Shows Launcher Forms
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlaaTool));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(164, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Make A launcher";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ActDeactButton);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(164, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Launcher Arguments";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Enabled = false;
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(164, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "GG Removal Tool";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AlaaTool
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(528, 335);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlaaTool";
            this.Text = "Revolution Launcher Tools GI";
            this.Load += new System.EventHandler(this.RevoBatLan_Load);
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void RevoBatLan_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ActDeactButton(object sender, EventArgs e)
        {
            AlaaLaunTool f2 = new AlaaLaunTool();
            f2.ShowDialog(); // Shows Launcher Tools Forms
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arguments f2 = new Arguments();
            f2.ShowDialog(); // Shows Arguments Forms
        }

        private void button3_Click(object sender, EventArgs e)
        {
          //deleted project
        }
    }
}

