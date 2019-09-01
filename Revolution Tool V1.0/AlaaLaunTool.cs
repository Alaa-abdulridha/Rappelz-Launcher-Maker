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
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Text;
    using System.Windows.Forms;

    public class AlaaLaunTool : Form
    {
        private Button button1;
        private Button button2;
        private IContainer components = null;
        private Label label11;
        private Label label14;
        private Label label15;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox2;
        private Label label16;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox8;
        private RichTextBox richTextBox1;
        private Label label12;
        private TextBox textBox10;
        private Label label13;
        private TextBox textBox11;
        private Label label17;
        private TextBox textBox14;
        private Label label18;
        private TextBox textBox15;
        private Label label19;
        private TextBox textBox16;
        private TextBox textBox17;
        private Label label20;
        private TextBox textBox18;
        private Label label21;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label22;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem abouToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label label29;
        private Label label30;
        private Label label28;
        private Label label26;
        private TextBox textBox22;
        private Label label25;
        private TextBox textBox21;
        private Label label24;
        private TextBox textBox20;
        private Label label23;
        private TextBox textBox19;
        private ComboBox comboBox1;
        private GroupBox groupBox3;
        private Label label1;
        private Label label27;
        private TextBox textBox9;

        public AlaaLaunTool()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] buffer = File.ReadAllBytes(@".\plugins\Launcher\" + this.comboBox1.Text + "RevolutionLauncher");
            byte[] buffer2 = File.ReadAllBytes(@".\plugins\Launcher\RevolutionLauncherSTRING");
            try
            {
                File.Delete(@".\plugins\Launcher\Launcher.exe");
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.ToString());
            }
            try
            {
                File.AppendAllText(@".\plugins\Launcher\Launcher.exe", "");
            }
            catch (Exception exception2)
            {
                MessageBox.Show(exception2.ToString());
            }
            using (FileStream stream = new FileStream(@".\plugins\Launcher\Launcher.exe", FileMode.Open, FileAccess.ReadWrite))
            {
                new BinaryWriter(stream);
                stream.Write(buffer, 0, buffer.Length);
                stream.Write(Encoding.UTF8.GetBytes(this.textBox1.Text), 0, this.textBox1.Text.Length);
                stream.Write(buffer2, 0, buffer2.Length);
                MessageBox.Show("Done! the launcher is ready");
                Process.Start("explorer.exe", @"/select,.\plugins\Launcher\Launcher.exe");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Rtf = richTextBox1.Rtf.Replace("+ this.textBox4.Text +", this.textBox4.Text);
            richTextBox1.Rtf = richTextBox1.Rtf.Replace("+ this.textBox7.Text +", this.textBox7.Text);

            richTextBox1.Rtf = richTextBox1.Rtf.Replace("+ this.textBox8.Text +", this.textBox8.Text);
            richTextBox1.Rtf = richTextBox1.Rtf.Replace("+ this.textBox2.Text +", this.textBox2.Text);
            richTextBox1.Rtf = richTextBox1.Rtf.Replace("+ this.textBox5.Text +", this.textBox5.Text);
            richTextBox1.Rtf = richTextBox1.Rtf.Replace("+ this.textBox6.Text +", this.textBox6.Text);
            richTextBox1.Rtf = richTextBox1.Rtf.Replace("+ this.textBox9.Text +", this.textBox9.Text);
            richTextBox1.Rtf = richTextBox1.Rtf.Replace("+ this.textBox3.Text +", this.textBox3.Text);
            richTextBox1.Rtf = richTextBox1.Rtf.Replace("+ this.textBox12.Text +", this.textBox12.Text);
            richTextBox1.Rtf = richTextBox1.Rtf.Replace("+ this.textBox13.Text +", this.textBox13.Text);
            richTextBox1.Rtf = richTextBox1.Rtf.Replace("+ this.textBox18.Text +", this.textBox18.Text);
            richTextBox1.Rtf = richTextBox1.Rtf.Replace("+ this.textBox19.Text +", this.textBox19.Text);
            richTextBox1.Rtf = richTextBox1.Rtf.Replace("+ this.textBox20.Text +", this.textBox20.Text);
            richTextBox1.Rtf = richTextBox1.Rtf.Replace("+ this.textBox21.Text +", this.textBox21.Text);
            richTextBox1.Rtf = richTextBox1.Rtf.Replace("+ this.textBox22.Text +", this.textBox22.Text);

            richTextBox1.Rtf = richTextBox1.Rtf.Replace("+ this.textBox17.Text +", this.textBox17.Text);
            richTextBox1.Rtf = richTextBox1.Rtf.Replace("+ this.textBox16.Text +", this.textBox16.Text);
            richTextBox1.Rtf = richTextBox1.Rtf.Replace("+ this.textBox15.Text +", this.textBox15.Text);
            richTextBox1.Rtf = richTextBox1.Rtf.Replace("+ this.textBox14.Text +", this.textBox14.Text);
            richTextBox1.Rtf = richTextBox1.Rtf.Replace("+ this.textBox10.Text +", this.textBox10.Text);
            richTextBox1.Rtf = richTextBox1.Rtf.Replace("+ this.textBox11.Text +", this.textBox11.Text);


            string contents = richTextBox1.Text;
            try
            {
                File.Delete(@".\plugins\rappelz\index.html");
                File.AppendAllText(@".\plugins\rappelz\index.html", contents);
                MessageBox.Show("Done ! now you must upload this files ");
                Process.Start("explorer.exe", @".\plugins\rappelz");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlaaLaunTool));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSlateGray;
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(530, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Make the launcher";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(161, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "http://127.0.0.1/rappelz/launcher.html";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Html Launcher URL :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(312, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "#1 Html launcher & string";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(572, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "Make the html launcher";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Auth Ip:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox2.Location = new System.Drawing.Point(182, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(334, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "127.0.0.1";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(96, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Patch Server:";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox9.Location = new System.Drawing.Point(182, 69);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(334, 20);
            this.textBox9.TabIndex = 20;
            this.textBox9.Text = "patch.rappelz.gamepower7.com";
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(121, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "home url:";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox12.Location = new System.Drawing.Point(182, 95);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(334, 20);
            this.textBox12.TabIndex = 26;
            this.textBox12.Text = "http://rappelz.gamepower7.com";
            this.textBox12.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(101, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Register Url:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox13.Location = new System.Drawing.Point(182, 121);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(334, 20);
            this.textBox13.TabIndex = 28;
            this.textBox13.Text = "http://rappelaz.gamepower7.com/registeruser/";
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Maroon;
            this.label16.Location = new System.Drawing.Point(170, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(297, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "ex, launch.gamepower7.com/rappelz/launcher.html";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox3.ForeColor = System.Drawing.Color.Maroon;
            this.textBox3.Location = new System.Drawing.Point(124, 417);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(387, 20);
            this.textBox3.TabIndex = 33;
            this.textBox3.Text = "Maintenance weekly every Monday from 9:00 pm until 1:30";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "News:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.Location = new System.Drawing.Point(155, 167);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(68, 20);
            this.textBox4.TabIndex = 35;
            this.textBox4.Text = "4500";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox5.Location = new System.Drawing.Point(156, 199);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(68, 20);
            this.textBox5.TabIndex = 36;
            this.textBox5.Text = "ME";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox6.Location = new System.Drawing.Point(155, 231);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(68, 20);
            this.textBox6.TabIndex = 37;
            this.textBox6.Text = "0";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox7.Location = new System.Drawing.Point(155, 262);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(98, 20);
            this.textBox7.TabIndex = 38;
            this.textBox7.Text = "Windows-1256";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(95, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 14);
            this.label6.TabIndex = 39;
            this.label6.Text = "Auth port:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Country:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Locale:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Use Nprotect?:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "SFrame Name:";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox8.Location = new System.Drawing.Point(155, 297);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(99, 20);
            this.textBox8.TabIndex = 43;
            this.textBox8.Text = "SFrame.exe";
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(663, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(86, 96);
            this.richTextBox1.TabIndex = 45;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.Visible = false;
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(300, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 14);
            this.label12.TabIndex = 48;
            this.label12.Text = "Help Url Width Frame:";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox10.Location = new System.Drawing.Point(424, 161);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(68, 20);
            this.textBox10.TabIndex = 47;
            this.textBox10.Text = "620";
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(297, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 14);
            this.label13.TabIndex = 50;
            this.label13.Text = "Help Url Heigth Frame:";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox11.Location = new System.Drawing.Point(424, 194);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(68, 20);
            this.textBox11.TabIndex = 49;
            this.textBox11.Text = "633";
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Tai Le", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(299, 230);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 14);
            this.label17.TabIndex = 52;
            this.label17.Text = "Cash Url Width Frame:";
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox14.Location = new System.Drawing.Point(424, 227);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(68, 20);
            this.textBox14.TabIndex = 51;
            this.textBox14.Text = "800";
            this.textBox14.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Tai Le", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(296, 262);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(126, 14);
            this.label18.TabIndex = 54;
            this.label18.Text = "Cash Url Heigth Frame:";
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox15.Location = new System.Drawing.Point(424, 259);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(68, 20);
            this.textBox15.TabIndex = 53;
            this.textBox15.Text = "690";
            this.textBox15.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Tai Le", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(315, 297);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(107, 14);
            this.label19.TabIndex = 56;
            this.label19.Text = "Allow Double exec:";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox16.Location = new System.Drawing.Point(424, 293);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(68, 20);
            this.textBox16.TabIndex = 55;
            this.textBox16.Text = "1";
            this.textBox16.TextChanged += new System.EventHandler(this.textBox16_TextChanged);
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox17.ForeColor = System.Drawing.Color.DarkMagenta;
            this.textBox17.Location = new System.Drawing.Point(238, 391);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(273, 20);
            this.textBox17.TabIndex = 57;
            this.textBox17.Text = "The Update is complete :)";
            this.textBox17.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(76, 394);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(162, 13);
            this.label20.TabIndex = 58;
            this.label20.Text = "Update Complete Message:";
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox18.Location = new System.Drawing.Point(366, 339);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(68, 20);
            this.textBox18.TabIndex = 59;
            this.textBox18.Text = "1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Tai Le", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(183, 342);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(177, 14);
            this.label21.TabIndex = 60;
            this.label21.Text = "Network Max Message Proccess:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.textBox22);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.textBox21);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.textBox20);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.textBox19);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(53, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 226);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ARGUMENT Values";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Tai Le", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Green;
            this.label29.Location = new System.Drawing.Point(516, 152);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(100, 28);
            this.label29.TabIndex = 71;
            this.label29.Text = "You can use your \r\nown Arg Values";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Tai Le", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.Maroon;
            this.label30.Location = new System.Drawing.Point(483, 152);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(36, 14);
            this.label30.TabIndex = 70;
            this.label30.Text = "Note:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Tai Le", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Green;
            this.label28.Location = new System.Drawing.Point(516, 180);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(105, 28);
            this.label28.TabIndex = 69;
            this.label28.Text = "You must use the\r\n values one by one";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Tai Le", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(483, 115);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(100, 14);
            this.label26.TabIndex = 67;
            this.label26.Text = "Optional Value #4";
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.Color.OliveDrab;
            this.textBox22.Location = new System.Drawing.Point(589, 112);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(101, 20);
            this.textBox22.TabIndex = 66;
            this.textBox22.TextChanged += new System.EventHandler(this.textBox22_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Tai Le", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(483, 75);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(100, 14);
            this.label25.TabIndex = 65;
            this.label25.Text = "Optional Value #3";
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.Color.OliveDrab;
            this.textBox21.Location = new System.Drawing.Point(589, 75);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(101, 20);
            this.textBox21.TabIndex = 64;
            this.textBox21.TextChanged += new System.EventHandler(this.textBox21_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Tai Le", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(483, 46);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(100, 14);
            this.label24.TabIndex = 63;
            this.label24.Text = "Optional Value #2";
            // 
            // textBox20
            // 
            this.textBox20.BackColor = System.Drawing.Color.OliveDrab;
            this.textBox20.Location = new System.Drawing.Point(589, 41);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(101, 20);
            this.textBox20.TabIndex = 62;
            this.textBox20.TextChanged += new System.EventHandler(this.textBox20_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Tai Le", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(483, 13);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(100, 14);
            this.label23.TabIndex = 61;
            this.label23.Text = "Optional Value #1";
            // 
            // textBox19
            // 
            this.textBox19.BackColor = System.Drawing.Color.OliveDrab;
            this.textBox19.Location = new System.Drawing.Point(589, 11);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(101, 20);
            this.textBox19.TabIndex = 48;
            this.textBox19.TextChanged += new System.EventHandler(this.textBox19_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(57, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 122);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server IP and Url\'s";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Indigo;
            this.label22.Location = new System.Drawing.Point(170, 118);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(296, 13);
            this.label22.TabIndex = 63;
            this.label22.Text = "NOTE*: All the values is The official default values";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abouToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 64;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abouToolStripMenuItem
            // 
            this.abouToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.abouToolStripMenuItem.Name = "abouToolStripMenuItem";
            this.abouToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.abouToolStripMenuItem.Text = "Menu";
            this.abouToolStripMenuItem.Click += new System.EventHandler(this.abouToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "RZ_ME",
            "RZ_ME_LOCAL",
            "RZ_US",
            "RZ_MASG",
            "RZ_KR",
            "RZ_KTS",
            "RZ_TR",
            "RZ_RU",
            "RZ_DE",
            "RZ_FR"});
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox1.Items.AddRange(new object[] {
            "RZ_DE",
            "RZ_FR",
            "RZ_KR",
            "RZ_ME",
            "RZ_RU",
            "RZ_TR",
            "RZ_US"});
            this.comboBox1.Location = new System.Drawing.Point(164, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 65;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.ForeColor = System.Drawing.Color.Green;
            this.groupBox3.Location = new System.Drawing.Point(53, 457);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(696, 147);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "The EXE Launcher and the App_Name";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.DarkRed;
            this.label27.Location = new System.Drawing.Point(305, 27);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(171, 13);
            this.label27.TabIndex = 67;
            this.label27.Text = "*RZ_ME is the default value.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(74, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "APP_NAME :";
            // 
            // AlaaLaunTool
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(784, 608);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlaaLaunTool";
            this.Text = "Make Official launcher";
            this.Load += new System.EventHandler(this.AlaaLaunTool_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AlaaLaunTool_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void abouToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   AlaaAbout f2 = new AlaaAbout();
           // f2.ShowDialog(); // Shows Form2
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}

