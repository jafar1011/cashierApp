using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data.SQLite;

namespace cashier
{
    public partial class Form1 : Form
    {
        string cashiername;
        Color tempcolor; bool tcolor = false;
        Button[,] menuButtons = new Button[10, 18];
        string businessname;
        string businesslogo;
        int totalprice = 0;
        int receiptitems=0;
        int itemcount=1;
        string type="سفري";
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        string dbpassword;
        string backupdbpassword;

        public Form1()
        {
            InitializeComponent();
            
        }
      


            private void InitializeComponent()
            {
                this.components = new System.ComponentModel.Container();
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
                this.panel1 = new System.Windows.Forms.Panel();
                this.button20 = new System.Windows.Forms.Button();
                this.textBox1 = new System.Windows.Forms.TextBox();
                this.label1 = new System.Windows.Forms.Label();
                this.button19 = new System.Windows.Forms.Button();
                this.panel2 = new System.Windows.Forms.Panel();
                this.richTextBox1 = new System.Windows.Forms.RichTextBox();
                this.menupanel = new System.Windows.Forms.Panel();
                this.secbutton10 = new System.Windows.Forms.Button();
                this.secbutton9 = new System.Windows.Forms.Button();
                this.secbutton8 = new System.Windows.Forms.Button();
                this.pictureBox2 = new System.Windows.Forms.PictureBox();
                this.secbutton7 = new System.Windows.Forms.Button();
                this.secbutton6 = new System.Windows.Forms.Button();
                this.secbutton5 = new System.Windows.Forms.Button();
                this.secbutton4 = new System.Windows.Forms.Button();
                this.secbutton3 = new System.Windows.Forms.Button();
                this.secbutton2 = new System.Windows.Forms.Button();
                this.secbutton1 = new System.Windows.Forms.Button();
                this.sectionspanel = new System.Windows.Forms.Panel();
                this.button4 = new System.Windows.Forms.Button();
                this.seccheckBox10 = new System.Windows.Forms.CheckBox();
                this.sectextBox10 = new System.Windows.Forms.TextBox();
                this.label11 = new System.Windows.Forms.Label();
                this.seccheckBox9 = new System.Windows.Forms.CheckBox();
                this.sectextBox9 = new System.Windows.Forms.TextBox();
                this.label10 = new System.Windows.Forms.Label();
                this.button30 = new System.Windows.Forms.Button();
                this.seccheckBox8 = new System.Windows.Forms.CheckBox();
                this.seccheckBox7 = new System.Windows.Forms.CheckBox();
                this.seccheckBox6 = new System.Windows.Forms.CheckBox();
                this.seccheckBox5 = new System.Windows.Forms.CheckBox();
                this.seccheckBox4 = new System.Windows.Forms.CheckBox();
                this.seccheckBox3 = new System.Windows.Forms.CheckBox();
                this.seccheckBox2 = new System.Windows.Forms.CheckBox();
                this.seccheckBox1 = new System.Windows.Forms.CheckBox();
                this.sectextBox8 = new System.Windows.Forms.TextBox();
                this.sectextBox7 = new System.Windows.Forms.TextBox();
                this.sectextBox6 = new System.Windows.Forms.TextBox();
                this.sectextBox5 = new System.Windows.Forms.TextBox();
                this.sectextBox4 = new System.Windows.Forms.TextBox();
                this.sectextBox3 = new System.Windows.Forms.TextBox();
                this.sectextBox2 = new System.Windows.Forms.TextBox();
                this.sectextBox1 = new System.Windows.Forms.TextBox();
                this.label9 = new System.Windows.Forms.Label();
                this.label8 = new System.Windows.Forms.Label();
                this.label7 = new System.Windows.Forms.Label();
                this.label6 = new System.Windows.Forms.Label();
                this.label5 = new System.Windows.Forms.Label();
                this.label4 = new System.Windows.Forms.Label();
                this.label3 = new System.Windows.Forms.Label();
                this.label2 = new System.Windows.Forms.Label();
                this.colorDialog1 = new System.Windows.Forms.ColorDialog();
                this.button27 = new System.Windows.Forms.Button();
                this.button28 = new System.Windows.Forms.Button();
                this.button29 = new System.Windows.Forms.Button();
                this.settingspanel = new System.Windows.Forms.Panel();
                this.button46 = new System.Windows.Forms.Button();
                this.button45 = new System.Windows.Forms.Button();
                this.button43 = new System.Windows.Forms.Button();
                this.button42 = new System.Windows.Forms.Button();
                this.button35 = new System.Windows.Forms.Button();
                this.button31 = new System.Windows.Forms.Button();
                this.button26 = new System.Windows.Forms.Button();
                this.label20 = new System.Windows.Forms.Label();
                this.button1 = new System.Windows.Forms.Button();
                this.receiptpanel = new System.Windows.Forms.Panel();
                this.label19 = new System.Windows.Forms.Label();
                this.textBox4 = new System.Windows.Forms.TextBox();
                this.label17 = new System.Windows.Forms.Label();
                this.button3 = new System.Windows.Forms.Button();
                this.button2 = new System.Windows.Forms.Button();
                this.mealspanel = new System.Windows.Forms.Panel();
                this.label43 = new System.Windows.Forms.Label();
                this.panel19 = new System.Windows.Forms.Panel();
                this.richTextBox2 = new System.Windows.Forms.RichTextBox();
                this.label42 = new System.Windows.Forms.Label();
                this.label41 = new System.Windows.Forms.Label();
                this.button22 = new System.Windows.Forms.Button();
                this.label14 = new System.Windows.Forms.Label();
                this.label13 = new System.Windows.Forms.Label();
                this.comboBox2 = new System.Windows.Forms.ComboBox();
                this.comboBox1 = new System.Windows.Forms.ComboBox();
                this.label12 = new System.Windows.Forms.Label();
                this.button21 = new System.Windows.Forms.Button();
                this.editingpanel = new System.Windows.Forms.Panel();
                this.checkBox1 = new System.Windows.Forms.CheckBox();
                this.button25 = new System.Windows.Forms.Button();
                this.button24 = new System.Windows.Forms.Button();
                this.button23 = new System.Windows.Forms.Button();
                this.textBox3 = new System.Windows.Forms.TextBox();
                this.textBox2 = new System.Windows.Forms.TextBox();
                this.label16 = new System.Windows.Forms.Label();
                this.label15 = new System.Windows.Forms.Label();
                this.m1btn5 = new System.Windows.Forms.Button();
                this.m1btn11 = new System.Windows.Forms.Button();
                this.m1btn17 = new System.Windows.Forms.Button();
                this.m1btn6 = new System.Windows.Forms.Button();
                this.m1btn12 = new System.Windows.Forms.Button();
                this.m1btn18 = new System.Windows.Forms.Button();
                this.m1btn3 = new System.Windows.Forms.Button();
                this.m1btn9 = new System.Windows.Forms.Button();
                this.m1btn15 = new System.Windows.Forms.Button();
                this.m1btn4 = new System.Windows.Forms.Button();
                this.m1btn10 = new System.Windows.Forms.Button();
                this.m1btn16 = new System.Windows.Forms.Button();
                this.m1btn1 = new System.Windows.Forms.Button();
                this.m1btn7 = new System.Windows.Forms.Button();
                this.m1btn13 = new System.Windows.Forms.Button();
                this.m1btn2 = new System.Windows.Forms.Button();
                this.m1btn8 = new System.Windows.Forms.Button();
                this.m1btn14 = new System.Windows.Forms.Button();
                this.panel3 = new System.Windows.Forms.Panel();
                this.panel4 = new System.Windows.Forms.Panel();
                this.m2btn14 = new System.Windows.Forms.Button();
                this.m2btn8 = new System.Windows.Forms.Button();
                this.m2btn2 = new System.Windows.Forms.Button();
                this.m2btn13 = new System.Windows.Forms.Button();
                this.m2btn7 = new System.Windows.Forms.Button();
                this.m2btn1 = new System.Windows.Forms.Button();
                this.m2btn16 = new System.Windows.Forms.Button();
                this.m2btn10 = new System.Windows.Forms.Button();
                this.m2btn4 = new System.Windows.Forms.Button();
                this.m2btn15 = new System.Windows.Forms.Button();
                this.m2btn9 = new System.Windows.Forms.Button();
                this.m2btn3 = new System.Windows.Forms.Button();
                this.m2btn18 = new System.Windows.Forms.Button();
                this.m2btn12 = new System.Windows.Forms.Button();
                this.m2btn6 = new System.Windows.Forms.Button();
                this.m2btn17 = new System.Windows.Forms.Button();
                this.m2btn11 = new System.Windows.Forms.Button();
                this.m2btn5 = new System.Windows.Forms.Button();
                this.panel5 = new System.Windows.Forms.Panel();
                this.m3btn14 = new System.Windows.Forms.Button();
                this.m3btn8 = new System.Windows.Forms.Button();
                this.m3btn2 = new System.Windows.Forms.Button();
                this.m3btn13 = new System.Windows.Forms.Button();
                this.m3btn7 = new System.Windows.Forms.Button();
                this.m3btn1 = new System.Windows.Forms.Button();
                this.m3btn16 = new System.Windows.Forms.Button();
                this.m3btn10 = new System.Windows.Forms.Button();
                this.m3btn4 = new System.Windows.Forms.Button();
                this.m3btn15 = new System.Windows.Forms.Button();
                this.m3btn9 = new System.Windows.Forms.Button();
                this.m3btn3 = new System.Windows.Forms.Button();
                this.m3btn18 = new System.Windows.Forms.Button();
                this.m3btn12 = new System.Windows.Forms.Button();
                this.m3btn6 = new System.Windows.Forms.Button();
                this.m3btn17 = new System.Windows.Forms.Button();
                this.m3btn11 = new System.Windows.Forms.Button();
                this.m3btn5 = new System.Windows.Forms.Button();
                this.panel6 = new System.Windows.Forms.Panel();
                this.m4btn14 = new System.Windows.Forms.Button();
                this.m4btn8 = new System.Windows.Forms.Button();
                this.m4btn2 = new System.Windows.Forms.Button();
                this.m4btn13 = new System.Windows.Forms.Button();
                this.m4btn7 = new System.Windows.Forms.Button();
                this.m4btn1 = new System.Windows.Forms.Button();
                this.m4btn16 = new System.Windows.Forms.Button();
                this.m4btn10 = new System.Windows.Forms.Button();
                this.m4btn4 = new System.Windows.Forms.Button();
                this.m4btn15 = new System.Windows.Forms.Button();
                this.m4btn9 = new System.Windows.Forms.Button();
                this.m4btn3 = new System.Windows.Forms.Button();
                this.m4btn18 = new System.Windows.Forms.Button();
                this.m4btn12 = new System.Windows.Forms.Button();
                this.m4btn6 = new System.Windows.Forms.Button();
                this.m4btn17 = new System.Windows.Forms.Button();
                this.m4btn11 = new System.Windows.Forms.Button();
                this.m4btn5 = new System.Windows.Forms.Button();
                this.panel7 = new System.Windows.Forms.Panel();
                this.m5btn14 = new System.Windows.Forms.Button();
                this.m5btn8 = new System.Windows.Forms.Button();
                this.m5btn2 = new System.Windows.Forms.Button();
                this.m5btn13 = new System.Windows.Forms.Button();
                this.m5btn7 = new System.Windows.Forms.Button();
                this.m5btn1 = new System.Windows.Forms.Button();
                this.m5btn16 = new System.Windows.Forms.Button();
                this.m5btn10 = new System.Windows.Forms.Button();
                this.m5btn4 = new System.Windows.Forms.Button();
                this.m5btn15 = new System.Windows.Forms.Button();
                this.m5btn9 = new System.Windows.Forms.Button();
                this.m5btn3 = new System.Windows.Forms.Button();
                this.m5btn18 = new System.Windows.Forms.Button();
                this.m5btn12 = new System.Windows.Forms.Button();
                this.m5btn6 = new System.Windows.Forms.Button();
                this.m5btn17 = new System.Windows.Forms.Button();
                this.m5btn11 = new System.Windows.Forms.Button();
                this.m5btn5 = new System.Windows.Forms.Button();
                this.panel8 = new System.Windows.Forms.Panel();
                this.m6btn14 = new System.Windows.Forms.Button();
                this.m6btn8 = new System.Windows.Forms.Button();
                this.m6btn2 = new System.Windows.Forms.Button();
                this.m6btn13 = new System.Windows.Forms.Button();
                this.m6btn7 = new System.Windows.Forms.Button();
                this.m6btn1 = new System.Windows.Forms.Button();
                this.m6btn16 = new System.Windows.Forms.Button();
                this.m6btn10 = new System.Windows.Forms.Button();
                this.m6btn4 = new System.Windows.Forms.Button();
                this.m6btn15 = new System.Windows.Forms.Button();
                this.m6btn9 = new System.Windows.Forms.Button();
                this.m6btn3 = new System.Windows.Forms.Button();
                this.m6btn18 = new System.Windows.Forms.Button();
                this.m6btn12 = new System.Windows.Forms.Button();
                this.m6btn6 = new System.Windows.Forms.Button();
                this.m6btn17 = new System.Windows.Forms.Button();
                this.m6btn11 = new System.Windows.Forms.Button();
                this.m6btn5 = new System.Windows.Forms.Button();
                this.panel9 = new System.Windows.Forms.Panel();
                this.m7btn14 = new System.Windows.Forms.Button();
                this.m7btn8 = new System.Windows.Forms.Button();
                this.m7btn2 = new System.Windows.Forms.Button();
                this.m7btn13 = new System.Windows.Forms.Button();
                this.m7btn7 = new System.Windows.Forms.Button();
                this.m7btn1 = new System.Windows.Forms.Button();
                this.m7btn16 = new System.Windows.Forms.Button();
                this.m7btn10 = new System.Windows.Forms.Button();
                this.m7btn4 = new System.Windows.Forms.Button();
                this.m7btn15 = new System.Windows.Forms.Button();
                this.m7btn9 = new System.Windows.Forms.Button();
                this.m7btn3 = new System.Windows.Forms.Button();
                this.m7btn18 = new System.Windows.Forms.Button();
                this.m7btn12 = new System.Windows.Forms.Button();
                this.m7btn6 = new System.Windows.Forms.Button();
                this.m7btn17 = new System.Windows.Forms.Button();
                this.m7btn11 = new System.Windows.Forms.Button();
                this.m7btn5 = new System.Windows.Forms.Button();
                this.panel10 = new System.Windows.Forms.Panel();
                this.m8btn14 = new System.Windows.Forms.Button();
                this.m8btn8 = new System.Windows.Forms.Button();
                this.m8btn2 = new System.Windows.Forms.Button();
                this.m8btn13 = new System.Windows.Forms.Button();
                this.m8btn7 = new System.Windows.Forms.Button();
                this.m8btn1 = new System.Windows.Forms.Button();
                this.m8btn16 = new System.Windows.Forms.Button();
                this.m8btn10 = new System.Windows.Forms.Button();
                this.m8btn4 = new System.Windows.Forms.Button();
                this.m8btn15 = new System.Windows.Forms.Button();
                this.m8btn9 = new System.Windows.Forms.Button();
                this.m8btn3 = new System.Windows.Forms.Button();
                this.m8btn18 = new System.Windows.Forms.Button();
                this.m8btn12 = new System.Windows.Forms.Button();
                this.m8btn6 = new System.Windows.Forms.Button();
                this.m8btn17 = new System.Windows.Forms.Button();
                this.m8btn11 = new System.Windows.Forms.Button();
                this.m8btn5 = new System.Windows.Forms.Button();
                this.panel11 = new System.Windows.Forms.Panel();
                this.m9btn14 = new System.Windows.Forms.Button();
                this.m9btn8 = new System.Windows.Forms.Button();
                this.m9btn2 = new System.Windows.Forms.Button();
                this.m9btn13 = new System.Windows.Forms.Button();
                this.m9btn7 = new System.Windows.Forms.Button();
                this.m9btn1 = new System.Windows.Forms.Button();
                this.m9btn16 = new System.Windows.Forms.Button();
                this.m9btn10 = new System.Windows.Forms.Button();
                this.m9btn4 = new System.Windows.Forms.Button();
                this.m9btn15 = new System.Windows.Forms.Button();
                this.m9btn9 = new System.Windows.Forms.Button();
                this.m9btn3 = new System.Windows.Forms.Button();
                this.m9btn18 = new System.Windows.Forms.Button();
                this.m9btn12 = new System.Windows.Forms.Button();
                this.m9btn6 = new System.Windows.Forms.Button();
                this.m9btn17 = new System.Windows.Forms.Button();
                this.m9btn11 = new System.Windows.Forms.Button();
                this.m9btn5 = new System.Windows.Forms.Button();
                this.panel12 = new System.Windows.Forms.Panel();
                this.m10btn14 = new System.Windows.Forms.Button();
                this.m10btn8 = new System.Windows.Forms.Button();
                this.m10btn2 = new System.Windows.Forms.Button();
                this.m10btn13 = new System.Windows.Forms.Button();
                this.m10btn7 = new System.Windows.Forms.Button();
                this.m10btn1 = new System.Windows.Forms.Button();
                this.m10btn16 = new System.Windows.Forms.Button();
                this.m10btn10 = new System.Windows.Forms.Button();
                this.m10btn4 = new System.Windows.Forms.Button();
                this.m10btn15 = new System.Windows.Forms.Button();
                this.m10btn9 = new System.Windows.Forms.Button();
                this.m10btn3 = new System.Windows.Forms.Button();
                this.m10btn18 = new System.Windows.Forms.Button();
                this.m10btn12 = new System.Windows.Forms.Button();
                this.m10btn6 = new System.Windows.Forms.Button();
                this.m10btn17 = new System.Windows.Forms.Button();
                this.m10btn11 = new System.Windows.Forms.Button();
                this.m10btn5 = new System.Windows.Forms.Button();
                this.button5 = new System.Windows.Forms.Button();
                this.timer1 = new System.Windows.Forms.Timer(this.components);
                this.panel13 = new System.Windows.Forms.Panel();
                this.button12 = new System.Windows.Forms.Button();
                this.button13 = new System.Windows.Forms.Button();
                this.button14 = new System.Windows.Forms.Button();
                this.button9 = new System.Windows.Forms.Button();
                this.button10 = new System.Windows.Forms.Button();
                this.button11 = new System.Windows.Forms.Button();
                this.button8 = new System.Windows.Forms.Button();
                this.button7 = new System.Windows.Forms.Button();
                this.label23 = new System.Windows.Forms.Label();
                this.textBox5 = new System.Windows.Forms.TextBox();
                this.button6 = new System.Windows.Forms.Button();
                this.label22 = new System.Windows.Forms.Label();
                this.panel14 = new System.Windows.Forms.Panel();
                this.textBox6 = new System.Windows.Forms.TextBox();
                this.button16 = new System.Windows.Forms.Button();
                this.button15 = new System.Windows.Forms.Button();
                this.button17 = new System.Windows.Forms.Button();
                this.button18 = new System.Windows.Forms.Button();
                this.dbpanel = new System.Windows.Forms.Panel();
                this.button39 = new System.Windows.Forms.Button();
                this.panel16 = new System.Windows.Forms.Panel();
                this.label35 = new System.Windows.Forms.Label();
                this.button38 = new System.Windows.Forms.Button();
                this.txtTotalSum = new System.Windows.Forms.TextBox();
                this.label34 = new System.Windows.Forms.Label();
                this.label33 = new System.Windows.Forms.Label();
                this.label32 = new System.Windows.Forms.Label();
                this.label31 = new System.Windows.Forms.Label();
                this.label29 = new System.Windows.Forms.Label();
                this.panel15 = new System.Windows.Forms.Panel();
                this.textBox10 = new System.Windows.Forms.TextBox();
                this.label30 = new System.Windows.Forms.Label();
                this.label28 = new System.Windows.Forms.Label();
                this.txtYearFilter = new System.Windows.Forms.TextBox();
                this.label18 = new System.Windows.Forms.Label();
                this.comboBox3 = new System.Windows.Forms.ComboBox();
                this.label24 = new System.Windows.Forms.Label();
                this.button32 = new System.Windows.Forms.Button();
                this.dataGridView1 = new System.Windows.Forms.DataGridView();
                this.passpanel = new System.Windows.Forms.Panel();
                this.button34 = new System.Windows.Forms.Button();
                this.label25 = new System.Windows.Forms.Label();
                this.button33 = new System.Windows.Forms.Button();
                this.textBox7 = new System.Windows.Forms.TextBox();
                this.pwchangepanel = new System.Windows.Forms.Panel();
                this.button37 = new System.Windows.Forms.Button();
                this.button36 = new System.Windows.Forms.Button();
                this.textBox9 = new System.Windows.Forms.TextBox();
                this.textBox8 = new System.Windows.Forms.TextBox();
                this.label27 = new System.Windows.Forms.Label();
                this.label26 = new System.Windows.Forms.Label();
                this.panel17 = new System.Windows.Forms.Panel();
                this.button40 = new System.Windows.Forms.Button();
                this.label38 = new System.Windows.Forms.Label();
                this.label37 = new System.Windows.Forms.Label();
                this.label36 = new System.Windows.Forms.Label();
                this.btnDeleteReceipts = new System.Windows.Forms.Button();
                this.cmbDeleteMonth = new System.Windows.Forms.ComboBox();
                this.txtDeleteYear = new System.Windows.Forms.TextBox();
                this.button41 = new System.Windows.Forms.Button();
                this.label39 = new System.Windows.Forms.Label();
                this.panel18 = new System.Windows.Forms.Panel();
                this.label40 = new System.Windows.Forms.Label();
                this.comboBox4 = new System.Windows.Forms.ComboBox();
                this.button44 = new System.Windows.Forms.Button();
                this.label21 = new System.Windows.Forms.Label();
                this.panel20 = new System.Windows.Forms.Panel();
                this.button47 = new System.Windows.Forms.Button();
                this.label48 = new System.Windows.Forms.Label();
                this.label47 = new System.Windows.Forms.Label();
                this.label46 = new System.Windows.Forms.Label();
                this.label45 = new System.Windows.Forms.Label();
                this.pictureBox1 = new System.Windows.Forms.PictureBox();
                this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
                this.panel1.SuspendLayout();
                this.panel2.SuspendLayout();
                this.menupanel.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
                this.sectionspanel.SuspendLayout();
                this.settingspanel.SuspendLayout();
                this.receiptpanel.SuspendLayout();
                this.mealspanel.SuspendLayout();
                this.panel19.SuspendLayout();
                this.editingpanel.SuspendLayout();
                this.panel3.SuspendLayout();
                this.panel4.SuspendLayout();
                this.panel5.SuspendLayout();
                this.panel6.SuspendLayout();
                this.panel7.SuspendLayout();
                this.panel8.SuspendLayout();
                this.panel9.SuspendLayout();
                this.panel10.SuspendLayout();
                this.panel11.SuspendLayout();
                this.panel12.SuspendLayout();
                this.panel13.SuspendLayout();
                this.panel14.SuspendLayout();
                this.dbpanel.SuspendLayout();
                this.panel16.SuspendLayout();
                this.panel15.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
                this.passpanel.SuspendLayout();
                this.pwchangepanel.SuspendLayout();
                this.panel17.SuspendLayout();
                this.panel18.SuspendLayout();
                this.panel20.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
                this.SuspendLayout();
                // 
                // panel1
                // 
                this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.panel1.Controls.Add(this.button20);
                this.panel1.Controls.Add(this.textBox1);
                this.panel1.Controls.Add(this.label1);
                this.panel1.Controls.Add(this.button19);
                this.panel1.Location = new System.Drawing.Point(502, 275);
                this.panel1.Name = "panel1";
                this.panel1.Size = new System.Drawing.Size(350, 177);
                this.panel1.TabIndex = 19;
                this.panel1.Visible = false;
                // 
                // button20
                // 
                this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button20.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button20.ForeColor = System.Drawing.Color.White;
                this.button20.Location = new System.Drawing.Point(97, 118);
                this.button20.Name = "button20";
                this.button20.Size = new System.Drawing.Size(54, 33);
                this.button20.TabIndex = 3;
                this.button20.Text = "رجوع";
                this.button20.UseVisualStyleBackColor = false;
                this.button20.Click += new System.EventHandler(this.button20_Click);
                // 
                // textBox1
                // 
                this.textBox1.Location = new System.Drawing.Point(87, 67);
                this.textBox1.Name = "textBox1";
                this.textBox1.Size = new System.Drawing.Size(184, 20);
                this.textBox1.TabIndex = 2;
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Font = new System.Drawing.Font("Arial", 20F);
                this.label1.Location = new System.Drawing.Point(123, 18);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(115, 32);
                this.label1.TabIndex = 1;
                this.label1.Text = "اسم الكاشير";
                // 
                // button19
                // 
                this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button19.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button19.ForeColor = System.Drawing.Color.White;
                this.button19.Location = new System.Drawing.Point(208, 118);
                this.button19.Name = "button19";
                this.button19.Size = new System.Drawing.Size(54, 33);
                this.button19.TabIndex = 0;
                this.button19.Text = "حفظ";
                this.button19.UseVisualStyleBackColor = false;
                this.button19.Click += new System.EventHandler(this.button19_Click);
                // 
                // panel2
                // 
                this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.panel2.Controls.Add(this.richTextBox1);
                this.panel2.Location = new System.Drawing.Point(18, 346);
                this.panel2.Name = "panel2";
                this.panel2.Size = new System.Drawing.Size(278, 397);
                this.panel2.TabIndex = 20;
                // 
                // richTextBox1
                // 
                this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.richTextBox1.Location = new System.Drawing.Point(12, 18);
                this.richTextBox1.Name = "richTextBox1";
                this.richTextBox1.ReadOnly = true;
                this.richTextBox1.Size = new System.Drawing.Size(253, 356);
                this.richTextBox1.TabIndex = 0;
                this.richTextBox1.Text = "";
                // 
                // menupanel
                // 
                this.menupanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                            | System.Windows.Forms.AnchorStyles.Right)));
                this.menupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.menupanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.menupanel.Controls.Add(this.secbutton10);
                this.menupanel.Controls.Add(this.secbutton9);
                this.menupanel.Controls.Add(this.secbutton8);
                this.menupanel.Controls.Add(this.pictureBox2);
                this.menupanel.Controls.Add(this.secbutton7);
                this.menupanel.Controls.Add(this.secbutton6);
                this.menupanel.Controls.Add(this.secbutton5);
                this.menupanel.Controls.Add(this.secbutton4);
                this.menupanel.Controls.Add(this.secbutton3);
                this.menupanel.Controls.Add(this.secbutton2);
                this.menupanel.Controls.Add(this.secbutton1);
                this.menupanel.Location = new System.Drawing.Point(0, 0);
                this.menupanel.Name = "menupanel";
                this.menupanel.Size = new System.Drawing.Size(1377, 58);
                this.menupanel.TabIndex = 22;
                // 
                // secbutton10
                // 
                this.secbutton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.secbutton10.Cursor = System.Windows.Forms.Cursors.Hand;
                this.secbutton10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.secbutton10.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.secbutton10.ForeColor = System.Drawing.Color.Black;
                this.secbutton10.Location = new System.Drawing.Point(14, 11);
                this.secbutton10.Name = "secbutton10";
                this.secbutton10.Size = new System.Drawing.Size(117, 35);
                this.secbutton10.TabIndex = 9;
                this.secbutton10.Text = "button26";
                this.secbutton10.UseVisualStyleBackColor = false;
                this.secbutton10.Visible = false;
                this.secbutton10.Click += new System.EventHandler(this.secbutton10_Click);
                // 
                // secbutton9
                // 
                this.secbutton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.secbutton9.Cursor = System.Windows.Forms.Cursors.Hand;
                this.secbutton9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.secbutton9.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.secbutton9.ForeColor = System.Drawing.Color.Black;
                this.secbutton9.Location = new System.Drawing.Point(137, 11);
                this.secbutton9.Name = "secbutton9";
                this.secbutton9.Size = new System.Drawing.Size(117, 35);
                this.secbutton9.TabIndex = 8;
                this.secbutton9.Text = "button26";
                this.secbutton9.UseVisualStyleBackColor = false;
                this.secbutton9.Visible = false;
                this.secbutton9.Click += new System.EventHandler(this.secbutton9_Click);
                // 
                // secbutton8
                // 
                this.secbutton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.secbutton8.Cursor = System.Windows.Forms.Cursors.Hand;
                this.secbutton8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.secbutton8.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.secbutton8.ForeColor = System.Drawing.Color.Black;
                this.secbutton8.Location = new System.Drawing.Point(260, 11);
                this.secbutton8.Name = "secbutton8";
                this.secbutton8.Size = new System.Drawing.Size(117, 35);
                this.secbutton8.TabIndex = 7;
                this.secbutton8.Text = "button26";
                this.secbutton8.UseVisualStyleBackColor = false;
                this.secbutton8.Visible = false;
                this.secbutton8.Click += new System.EventHandler(this.secbutton8_Click);
                // 
                // pictureBox2
                // 
                this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
                this.pictureBox2.Image = global::الكاشير.Properties.Resources.settings;
                this.pictureBox2.Location = new System.Drawing.Point(1305, 5);
                this.pictureBox2.Name = "pictureBox2";
                this.pictureBox2.Size = new System.Drawing.Size(48, 47);
                this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                this.pictureBox2.TabIndex = 21;
                this.pictureBox2.TabStop = false;
                this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
                // 
                // secbutton7
                // 
                this.secbutton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.secbutton7.Cursor = System.Windows.Forms.Cursors.Hand;
                this.secbutton7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.secbutton7.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.secbutton7.ForeColor = System.Drawing.Color.Black;
                this.secbutton7.Location = new System.Drawing.Point(383, 11);
                this.secbutton7.Name = "secbutton7";
                this.secbutton7.Size = new System.Drawing.Size(117, 35);
                this.secbutton7.TabIndex = 6;
                this.secbutton7.Text = "button26";
                this.secbutton7.UseVisualStyleBackColor = false;
                this.secbutton7.Visible = false;
                this.secbutton7.Click += new System.EventHandler(this.secbutton7_Click);
                // 
                // secbutton6
                // 
                this.secbutton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.secbutton6.Cursor = System.Windows.Forms.Cursors.Hand;
                this.secbutton6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.secbutton6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.secbutton6.ForeColor = System.Drawing.Color.Black;
                this.secbutton6.Location = new System.Drawing.Point(506, 11);
                this.secbutton6.Name = "secbutton6";
                this.secbutton6.Size = new System.Drawing.Size(117, 35);
                this.secbutton6.TabIndex = 5;
                this.secbutton6.Text = "button25";
                this.secbutton6.UseVisualStyleBackColor = false;
                this.secbutton6.Visible = false;
                this.secbutton6.Click += new System.EventHandler(this.secbutton6_Click);
                // 
                // secbutton5
                // 
                this.secbutton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.secbutton5.Cursor = System.Windows.Forms.Cursors.Hand;
                this.secbutton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.secbutton5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.secbutton5.ForeColor = System.Drawing.Color.Black;
                this.secbutton5.Location = new System.Drawing.Point(629, 11);
                this.secbutton5.Name = "secbutton5";
                this.secbutton5.Size = new System.Drawing.Size(117, 35);
                this.secbutton5.TabIndex = 4;
                this.secbutton5.Text = "button24";
                this.secbutton5.UseVisualStyleBackColor = false;
                this.secbutton5.Visible = false;
                this.secbutton5.Click += new System.EventHandler(this.secbutton5_Click);
                // 
                // secbutton4
                // 
                this.secbutton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.secbutton4.Cursor = System.Windows.Forms.Cursors.Hand;
                this.secbutton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.secbutton4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.secbutton4.ForeColor = System.Drawing.Color.Black;
                this.secbutton4.Location = new System.Drawing.Point(752, 11);
                this.secbutton4.Name = "secbutton4";
                this.secbutton4.Size = new System.Drawing.Size(117, 35);
                this.secbutton4.TabIndex = 3;
                this.secbutton4.Text = "button23";
                this.secbutton4.UseVisualStyleBackColor = false;
                this.secbutton4.Visible = false;
                this.secbutton4.Click += new System.EventHandler(this.secbutton4_Click);
                // 
                // secbutton3
                // 
                this.secbutton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.secbutton3.Cursor = System.Windows.Forms.Cursors.Hand;
                this.secbutton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.secbutton3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.secbutton3.ForeColor = System.Drawing.Color.Black;
                this.secbutton3.Location = new System.Drawing.Point(876, 11);
                this.secbutton3.Name = "secbutton3";
                this.secbutton3.Size = new System.Drawing.Size(117, 35);
                this.secbutton3.TabIndex = 2;
                this.secbutton3.Text = "button22";
                this.secbutton3.UseVisualStyleBackColor = false;
                this.secbutton3.Visible = false;
                this.secbutton3.Click += new System.EventHandler(this.secbutton3_Click);
                // 
                // secbutton2
                // 
                this.secbutton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.secbutton2.Cursor = System.Windows.Forms.Cursors.Hand;
                this.secbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.secbutton2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.secbutton2.ForeColor = System.Drawing.Color.Black;
                this.secbutton2.Location = new System.Drawing.Point(999, 11);
                this.secbutton2.Name = "secbutton2";
                this.secbutton2.Size = new System.Drawing.Size(117, 35);
                this.secbutton2.TabIndex = 1;
                this.secbutton2.Text = "secbutton2";
                this.secbutton2.UseVisualStyleBackColor = false;
                this.secbutton2.Visible = false;
                this.secbutton2.Click += new System.EventHandler(this.secbutton2_Click);
                // 
                // secbutton1
                // 
                this.secbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.secbutton1.Cursor = System.Windows.Forms.Cursors.Hand;
                this.secbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.secbutton1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.secbutton1.ForeColor = System.Drawing.Color.White;
                this.secbutton1.Location = new System.Drawing.Point(1122, 11);
                this.secbutton1.Name = "secbutton1";
                this.secbutton1.Size = new System.Drawing.Size(117, 35);
                this.secbutton1.TabIndex = 0;
                this.secbutton1.Text = "menubutton1";
                this.secbutton1.UseVisualStyleBackColor = false;
                this.secbutton1.Click += new System.EventHandler(this.secbutton1_Click);
                // 
                // sectionspanel
                // 
                this.sectionspanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.sectionspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.sectionspanel.Controls.Add(this.button4);
                this.sectionspanel.Controls.Add(this.seccheckBox10);
                this.sectionspanel.Controls.Add(this.sectextBox10);
                this.sectionspanel.Controls.Add(this.label11);
                this.sectionspanel.Controls.Add(this.seccheckBox9);
                this.sectionspanel.Controls.Add(this.sectextBox9);
                this.sectionspanel.Controls.Add(this.label10);
                this.sectionspanel.Controls.Add(this.button30);
                this.sectionspanel.Controls.Add(this.seccheckBox8);
                this.sectionspanel.Controls.Add(this.seccheckBox7);
                this.sectionspanel.Controls.Add(this.seccheckBox6);
                this.sectionspanel.Controls.Add(this.seccheckBox5);
                this.sectionspanel.Controls.Add(this.seccheckBox4);
                this.sectionspanel.Controls.Add(this.seccheckBox3);
                this.sectionspanel.Controls.Add(this.seccheckBox2);
                this.sectionspanel.Controls.Add(this.seccheckBox1);
                this.sectionspanel.Controls.Add(this.sectextBox8);
                this.sectionspanel.Controls.Add(this.sectextBox7);
                this.sectionspanel.Controls.Add(this.sectextBox6);
                this.sectionspanel.Controls.Add(this.sectextBox5);
                this.sectionspanel.Controls.Add(this.sectextBox4);
                this.sectionspanel.Controls.Add(this.sectextBox3);
                this.sectionspanel.Controls.Add(this.sectextBox2);
                this.sectionspanel.Controls.Add(this.sectextBox1);
                this.sectionspanel.Controls.Add(this.label9);
                this.sectionspanel.Controls.Add(this.label8);
                this.sectionspanel.Controls.Add(this.label7);
                this.sectionspanel.Controls.Add(this.label6);
                this.sectionspanel.Controls.Add(this.label5);
                this.sectionspanel.Controls.Add(this.label4);
                this.sectionspanel.Controls.Add(this.label3);
                this.sectionspanel.Controls.Add(this.label2);
                this.sectionspanel.Location = new System.Drawing.Point(396, 117);
                this.sectionspanel.Name = "sectionspanel";
                this.sectionspanel.Size = new System.Drawing.Size(543, 483);
                this.sectionspanel.TabIndex = 24;
                this.sectionspanel.Visible = false;
                // 
                // button4
                // 
                this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button4.ForeColor = System.Drawing.Color.White;
                this.button4.Location = new System.Drawing.Point(442, 436);
                this.button4.Name = "button4";
                this.button4.Size = new System.Drawing.Size(78, 35);
                this.button4.TabIndex = 41;
                this.button4.Text = "تعديل";
                this.button4.UseVisualStyleBackColor = false;
                this.button4.Click += new System.EventHandler(this.button4_Click_1);
                // 
                // seccheckBox10
                // 
                this.seccheckBox10.AutoSize = true;
                this.seccheckBox10.Cursor = System.Windows.Forms.Cursors.Hand;
                this.seccheckBox10.Location = new System.Drawing.Point(85, 402);
                this.seccheckBox10.Name = "seccheckBox10";
                this.seccheckBox10.Size = new System.Drawing.Size(99, 17);
                this.seccheckBox10.TabIndex = 39;
                this.seccheckBox10.Text = "تفعيل القائمة 10";
                this.seccheckBox10.UseVisualStyleBackColor = true;
                this.seccheckBox10.CheckedChanged += new System.EventHandler(this.seccheckBox10_CheckedChanged);
                // 
                // sectextBox10
                // 
                this.sectextBox10.Location = new System.Drawing.Point(199, 399);
                this.sectextBox10.Name = "sectextBox10";
                this.sectextBox10.Size = new System.Drawing.Size(162, 20);
                this.sectextBox10.TabIndex = 38;
                // 
                // label11
                // 
                this.label11.AutoSize = true;
                this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label11.Location = new System.Drawing.Point(377, 399);
                this.label11.Name = "label11";
                this.label11.Size = new System.Drawing.Size(113, 19);
                this.label11.TabIndex = 37;
                this.label11.Text = "اسم القائمة 10";
                // 
                // seccheckBox9
                // 
                this.seccheckBox9.AutoSize = true;
                this.seccheckBox9.Cursor = System.Windows.Forms.Cursors.Hand;
                this.seccheckBox9.Location = new System.Drawing.Point(85, 359);
                this.seccheckBox9.Name = "seccheckBox9";
                this.seccheckBox9.Size = new System.Drawing.Size(93, 17);
                this.seccheckBox9.TabIndex = 35;
                this.seccheckBox9.Text = "تفعيل القائمة 9";
                this.seccheckBox9.UseVisualStyleBackColor = true;
                this.seccheckBox9.CheckedChanged += new System.EventHandler(this.seccheckBox9_CheckedChanged);
                // 
                // sectextBox9
                // 
                this.sectextBox9.Location = new System.Drawing.Point(199, 356);
                this.sectextBox9.Name = "sectextBox9";
                this.sectextBox9.Size = new System.Drawing.Size(162, 20);
                this.sectextBox9.TabIndex = 34;
                // 
                // label10
                // 
                this.label10.AutoSize = true;
                this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label10.Location = new System.Drawing.Point(384, 355);
                this.label10.Name = "label10";
                this.label10.Size = new System.Drawing.Size(104, 19);
                this.label10.TabIndex = 33;
                this.label10.Text = "اسم القائمة 9";
                // 
                // button30
                // 
                this.button30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button30.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button30.ForeColor = System.Drawing.Color.White;
                this.button30.Location = new System.Drawing.Point(25, 436);
                this.button30.Name = "button30";
                this.button30.Size = new System.Drawing.Size(77, 35);
                this.button30.TabIndex = 24;
                this.button30.Text = "رجوع";
                this.button30.UseVisualStyleBackColor = false;
                this.button30.Click += new System.EventHandler(this.button30_Click);
                // 
                // seccheckBox8
                // 
                this.seccheckBox8.AutoSize = true;
                this.seccheckBox8.Cursor = System.Windows.Forms.Cursors.Hand;
                this.seccheckBox8.Location = new System.Drawing.Point(85, 321);
                this.seccheckBox8.Name = "seccheckBox8";
                this.seccheckBox8.Size = new System.Drawing.Size(93, 17);
                this.seccheckBox8.TabIndex = 23;
                this.seccheckBox8.Text = "تفعيل القائمة 8";
                this.seccheckBox8.UseVisualStyleBackColor = true;
                this.seccheckBox8.CheckedChanged += new System.EventHandler(this.seccheckBox8_CheckedChanged);
                // 
                // seccheckBox7
                // 
                this.seccheckBox7.AutoSize = true;
                this.seccheckBox7.Cursor = System.Windows.Forms.Cursors.Hand;
                this.seccheckBox7.Location = new System.Drawing.Point(85, 276);
                this.seccheckBox7.Name = "seccheckBox7";
                this.seccheckBox7.Size = new System.Drawing.Size(93, 17);
                this.seccheckBox7.TabIndex = 22;
                this.seccheckBox7.Text = "تفعيل القائمة 7";
                this.seccheckBox7.UseVisualStyleBackColor = true;
                this.seccheckBox7.CheckedChanged += new System.EventHandler(this.seccheckBox7_CheckedChanged);
                // 
                // seccheckBox6
                // 
                this.seccheckBox6.AutoSize = true;
                this.seccheckBox6.Cursor = System.Windows.Forms.Cursors.Hand;
                this.seccheckBox6.Location = new System.Drawing.Point(85, 235);
                this.seccheckBox6.Name = "seccheckBox6";
                this.seccheckBox6.Size = new System.Drawing.Size(93, 17);
                this.seccheckBox6.TabIndex = 21;
                this.seccheckBox6.Text = "تفعيل القائمة 6";
                this.seccheckBox6.UseVisualStyleBackColor = true;
                this.seccheckBox6.CheckedChanged += new System.EventHandler(this.seccheckBox6_CheckedChanged);
                // 
                // seccheckBox5
                // 
                this.seccheckBox5.AutoSize = true;
                this.seccheckBox5.Cursor = System.Windows.Forms.Cursors.Hand;
                this.seccheckBox5.Location = new System.Drawing.Point(85, 195);
                this.seccheckBox5.Name = "seccheckBox5";
                this.seccheckBox5.Size = new System.Drawing.Size(93, 17);
                this.seccheckBox5.TabIndex = 20;
                this.seccheckBox5.Text = "تفعيل القائمة 5";
                this.seccheckBox5.UseVisualStyleBackColor = true;
                this.seccheckBox5.CheckedChanged += new System.EventHandler(this.seccheckBox5_CheckedChanged);
                // 
                // seccheckBox4
                // 
                this.seccheckBox4.AutoSize = true;
                this.seccheckBox4.Cursor = System.Windows.Forms.Cursors.Hand;
                this.seccheckBox4.Location = new System.Drawing.Point(85, 154);
                this.seccheckBox4.Name = "seccheckBox4";
                this.seccheckBox4.Size = new System.Drawing.Size(93, 17);
                this.seccheckBox4.TabIndex = 19;
                this.seccheckBox4.Text = "تفعيل القائمة 4";
                this.seccheckBox4.UseVisualStyleBackColor = true;
                this.seccheckBox4.CheckedChanged += new System.EventHandler(this.seccheckBox4_CheckedChanged);
                // 
                // seccheckBox3
                // 
                this.seccheckBox3.AutoSize = true;
                this.seccheckBox3.Cursor = System.Windows.Forms.Cursors.Hand;
                this.seccheckBox3.Location = new System.Drawing.Point(85, 118);
                this.seccheckBox3.Name = "seccheckBox3";
                this.seccheckBox3.Size = new System.Drawing.Size(93, 17);
                this.seccheckBox3.TabIndex = 18;
                this.seccheckBox3.Text = "تفعيل القائمة 3";
                this.seccheckBox3.UseVisualStyleBackColor = true;
                this.seccheckBox3.CheckedChanged += new System.EventHandler(this.seccheckBox3_CheckedChanged);
                // 
                // seccheckBox2
                // 
                this.seccheckBox2.AutoSize = true;
                this.seccheckBox2.Cursor = System.Windows.Forms.Cursors.Hand;
                this.seccheckBox2.Location = new System.Drawing.Point(85, 77);
                this.seccheckBox2.Name = "seccheckBox2";
                this.seccheckBox2.Size = new System.Drawing.Size(93, 17);
                this.seccheckBox2.TabIndex = 17;
                this.seccheckBox2.Text = "تفعيل القائمة 2";
                this.seccheckBox2.UseVisualStyleBackColor = true;
                this.seccheckBox2.CheckedChanged += new System.EventHandler(this.seccheckBox2_CheckedChanged);
                // 
                // seccheckBox1
                // 
                this.seccheckBox1.AutoSize = true;
                this.seccheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
                this.seccheckBox1.Location = new System.Drawing.Point(85, 32);
                this.seccheckBox1.Name = "seccheckBox1";
                this.seccheckBox1.Size = new System.Drawing.Size(93, 17);
                this.seccheckBox1.TabIndex = 16;
                this.seccheckBox1.Text = "تفعيل القائمة 1";
                this.seccheckBox1.UseVisualStyleBackColor = true;
                this.seccheckBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
                // 
                // sectextBox8
                // 
                this.sectextBox8.Location = new System.Drawing.Point(199, 318);
                this.sectextBox8.Name = "sectextBox8";
                this.sectextBox8.Size = new System.Drawing.Size(162, 20);
                this.sectextBox8.TabIndex = 15;
                // 
                // sectextBox7
                // 
                this.sectextBox7.Location = new System.Drawing.Point(199, 273);
                this.sectextBox7.Name = "sectextBox7";
                this.sectextBox7.Size = new System.Drawing.Size(162, 20);
                this.sectextBox7.TabIndex = 14;
                // 
                // sectextBox6
                // 
                this.sectextBox6.Location = new System.Drawing.Point(199, 232);
                this.sectextBox6.Name = "sectextBox6";
                this.sectextBox6.Size = new System.Drawing.Size(162, 20);
                this.sectextBox6.TabIndex = 13;
                // 
                // sectextBox5
                // 
                this.sectextBox5.Location = new System.Drawing.Point(199, 193);
                this.sectextBox5.Name = "sectextBox5";
                this.sectextBox5.Size = new System.Drawing.Size(162, 20);
                this.sectextBox5.TabIndex = 12;
                // 
                // sectextBox4
                // 
                this.sectextBox4.Location = new System.Drawing.Point(199, 152);
                this.sectextBox4.Name = "sectextBox4";
                this.sectextBox4.Size = new System.Drawing.Size(162, 20);
                this.sectextBox4.TabIndex = 11;
                // 
                // sectextBox3
                // 
                this.sectextBox3.Location = new System.Drawing.Point(199, 115);
                this.sectextBox3.Name = "sectextBox3";
                this.sectextBox3.Size = new System.Drawing.Size(162, 20);
                this.sectextBox3.TabIndex = 10;
                // 
                // sectextBox2
                // 
                this.sectextBox2.Location = new System.Drawing.Point(199, 74);
                this.sectextBox2.Name = "sectextBox2";
                this.sectextBox2.Size = new System.Drawing.Size(162, 20);
                this.sectextBox2.TabIndex = 9;
                // 
                // sectextBox1
                // 
                this.sectextBox1.Location = new System.Drawing.Point(199, 30);
                this.sectextBox1.Name = "sectextBox1";
                this.sectextBox1.Size = new System.Drawing.Size(162, 20);
                this.sectextBox1.TabIndex = 8;
                // 
                // label9
                // 
                this.label9.AutoSize = true;
                this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label9.Location = new System.Drawing.Point(384, 317);
                this.label9.Name = "label9";
                this.label9.Size = new System.Drawing.Size(104, 19);
                this.label9.TabIndex = 7;
                this.label9.Text = "اسم القائمة 8";
                // 
                // label8
                // 
                this.label8.AutoSize = true;
                this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label8.Location = new System.Drawing.Point(384, 271);
                this.label8.Name = "label8";
                this.label8.Size = new System.Drawing.Size(104, 19);
                this.label8.TabIndex = 6;
                this.label8.Text = "اسم القائمة 7";
                // 
                // label7
                // 
                this.label7.AutoSize = true;
                this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label7.Location = new System.Drawing.Point(384, 230);
                this.label7.Name = "label7";
                this.label7.Size = new System.Drawing.Size(104, 19);
                this.label7.TabIndex = 5;
                this.label7.Text = "اسم القائمة 6";
                // 
                // label6
                // 
                this.label6.AutoSize = true;
                this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label6.Location = new System.Drawing.Point(384, 191);
                this.label6.Name = "label6";
                this.label6.Size = new System.Drawing.Size(104, 19);
                this.label6.TabIndex = 4;
                this.label6.Text = "اسم القائمة 5";
                // 
                // label5
                // 
                this.label5.AutoSize = true;
                this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label5.Location = new System.Drawing.Point(384, 152);
                this.label5.Name = "label5";
                this.label5.Size = new System.Drawing.Size(104, 19);
                this.label5.TabIndex = 3;
                this.label5.Text = "اسم القائمة 4";
                // 
                // label4
                // 
                this.label4.AutoSize = true;
                this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label4.Location = new System.Drawing.Point(384, 113);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(104, 19);
                this.label4.TabIndex = 2;
                this.label4.Text = "اسم القائمة 3";
                // 
                // label3
                // 
                this.label3.AutoSize = true;
                this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label3.Location = new System.Drawing.Point(384, 72);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(104, 19);
                this.label3.TabIndex = 1;
                this.label3.Text = "اسم القائمة 2";
                // 
                // label2
                // 
                this.label2.AutoSize = true;
                this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label2.Location = new System.Drawing.Point(384, 28);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(104, 19);
                this.label2.TabIndex = 0;
                this.label2.Text = "اسم القائمة 1";
                // 
                // button27
                // 
                this.button27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button27.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button27.ForeColor = System.Drawing.Color.White;
                this.button27.Location = new System.Drawing.Point(20, 370);
                this.button27.Name = "button27";
                this.button27.Size = new System.Drawing.Size(126, 43);
                this.button27.TabIndex = 0;
                this.button27.Text = "اغلاق";
                this.button27.UseVisualStyleBackColor = false;
                this.button27.Click += new System.EventHandler(this.button27_Click);
                // 
                // button28
                // 
                this.button28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button28.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button28.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button28.ForeColor = System.Drawing.Color.White;
                this.button28.Location = new System.Drawing.Point(22, 80);
                this.button28.Name = "button28";
                this.button28.Size = new System.Drawing.Size(155, 50);
                this.button28.TabIndex = 1;
                this.button28.Text = "الأقسام";
                this.button28.UseVisualStyleBackColor = false;
                this.button28.Click += new System.EventHandler(this.button28_Click);
                // 
                // button29
                // 
                this.button29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button29.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button29.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button29.ForeColor = System.Drawing.Color.White;
                this.button29.Location = new System.Drawing.Point(187, 80);
                this.button29.Name = "button29";
                this.button29.Size = new System.Drawing.Size(155, 50);
                this.button29.TabIndex = 2;
                this.button29.Text = "الوجبات";
                this.button29.UseVisualStyleBackColor = false;
                this.button29.Click += new System.EventHandler(this.button29_Click);
                // 
                // settingspanel
                // 
                this.settingspanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.settingspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.settingspanel.Controls.Add(this.button46);
                this.settingspanel.Controls.Add(this.button45);
                this.settingspanel.Controls.Add(this.button43);
                this.settingspanel.Controls.Add(this.button42);
                this.settingspanel.Controls.Add(this.button35);
                this.settingspanel.Controls.Add(this.button31);
                this.settingspanel.Controls.Add(this.button26);
                this.settingspanel.Controls.Add(this.label20);
                this.settingspanel.Controls.Add(this.button1);
                this.settingspanel.Controls.Add(this.button29);
                this.settingspanel.Controls.Add(this.button28);
                this.settingspanel.Controls.Add(this.button27);
                this.settingspanel.Location = new System.Drawing.Point(400, 144);
                this.settingspanel.Name = "settingspanel";
                this.settingspanel.Size = new System.Drawing.Size(537, 425);
                this.settingspanel.TabIndex = 23;
                this.settingspanel.Visible = false;
                // 
                // button46
                // 
                this.button46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button46.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button46.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button46.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button46.ForeColor = System.Drawing.Color.White;
                this.button46.Location = new System.Drawing.Point(187, 313);
                this.button46.Name = "button46";
                this.button46.Size = new System.Drawing.Size(155, 50);
                this.button46.TabIndex = 28;
                this.button46.Text = "حول";
                this.button46.UseVisualStyleBackColor = false;
                this.button46.Click += new System.EventHandler(this.button46_Click);
                // 
                // button45
                // 
                this.button45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button45.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button45.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button45.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button45.ForeColor = System.Drawing.Color.White;
                this.button45.Location = new System.Drawing.Point(22, 247);
                this.button45.Name = "button45";
                this.button45.Size = new System.Drawing.Size(155, 50);
                this.button45.TabIndex = 27;
                this.button45.Text = "إلغاء اخر طلب";
                this.button45.UseVisualStyleBackColor = false;
                this.button45.Click += new System.EventHandler(this.button45_Click);
                // 
                // button43
                // 
                this.button43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button43.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button43.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button43.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button43.ForeColor = System.Drawing.Color.White;
                this.button43.Location = new System.Drawing.Point(187, 247);
                this.button43.Name = "button43";
                this.button43.Size = new System.Drawing.Size(155, 50);
                this.button43.TabIndex = 26;
                this.button43.Text = "الكاشير";
                this.button43.UseVisualStyleBackColor = false;
                this.button43.Click += new System.EventHandler(this.button43_Click);
                // 
                // button42
                // 
                this.button42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button42.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button42.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button42.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button42.ForeColor = System.Drawing.Color.White;
                this.button42.Location = new System.Drawing.Point(354, 247);
                this.button42.Name = "button42";
                this.button42.Size = new System.Drawing.Size(155, 50);
                this.button42.TabIndex = 25;
                this.button42.Text = "التعليمات";
                this.button42.UseVisualStyleBackColor = false;
                this.button42.Click += new System.EventHandler(this.button42_Click);
                // 
                // button35
                // 
                this.button35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button35.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button35.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button35.ForeColor = System.Drawing.Color.White;
                this.button35.Location = new System.Drawing.Point(22, 164);
                this.button35.Name = "button35";
                this.button35.Size = new System.Drawing.Size(155, 50);
                this.button35.TabIndex = 24;
                this.button35.Text = "تغيير كلمة السر";
                this.button35.UseVisualStyleBackColor = false;
                this.button35.Click += new System.EventHandler(this.button35_Click);
                // 
                // button31
                // 
                this.button31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button31.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button31.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button31.ForeColor = System.Drawing.Color.White;
                this.button31.Location = new System.Drawing.Point(187, 164);
                this.button31.Name = "button31";
                this.button31.Size = new System.Drawing.Size(155, 50);
                this.button31.TabIndex = 23;
                this.button31.Text = "البيانات";
                this.button31.UseVisualStyleBackColor = false;
                this.button31.Click += new System.EventHandler(this.button31_Click);
                // 
                // button26
                // 
                this.button26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button26.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button26.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button26.ForeColor = System.Drawing.Color.White;
                this.button26.Location = new System.Drawing.Point(353, 164);
                this.button26.Name = "button26";
                this.button26.Size = new System.Drawing.Size(155, 50);
                this.button26.TabIndex = 22;
                this.button26.Text = "صفر رقم الطلب";
                this.button26.UseVisualStyleBackColor = false;
                this.button26.Click += new System.EventHandler(this.button26_Click);
                // 
                // label20
                // 
                this.label20.AutoSize = true;
                this.label20.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label20.Location = new System.Drawing.Point(216, 20);
                this.label20.Name = "label20";
                this.label20.Size = new System.Drawing.Size(103, 29);
                this.label20.TabIndex = 20;
                this.label20.Text = "الأعدادات";
                // 
                // button1
                // 
                this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button1.ForeColor = System.Drawing.Color.White;
                this.button1.Location = new System.Drawing.Point(353, 80);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(155, 50);
                this.button1.TabIndex = 19;
                this.button1.Text = "الوصل";
                this.button1.UseVisualStyleBackColor = false;
                this.button1.Click += new System.EventHandler(this.button1_Click);
                // 
                // receiptpanel
                // 
                this.receiptpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.receiptpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.receiptpanel.Controls.Add(this.label19);
                this.receiptpanel.Controls.Add(this.textBox4);
                this.receiptpanel.Controls.Add(this.label17);
                this.receiptpanel.Controls.Add(this.button3);
                this.receiptpanel.Controls.Add(this.button2);
                this.receiptpanel.Location = new System.Drawing.Point(550, 230);
                this.receiptpanel.Name = "receiptpanel";
                this.receiptpanel.Size = new System.Drawing.Size(318, 200);
                this.receiptpanel.TabIndex = 37;
                this.receiptpanel.Visible = false;
                // 
                // label19
                // 
                this.label19.AutoSize = true;
                this.label19.Location = new System.Drawing.Point(134, 122);
                this.label19.Name = "label19";
                this.label19.Size = new System.Drawing.Size(125, 13);
                this.label19.TabIndex = 6;
                this.label19.Text = "الاسم  سيطبع على الوصل*";
                // 
                // textBox4
                // 
                this.textBox4.Location = new System.Drawing.Point(74, 63);
                this.textBox4.Name = "textBox4";
                this.textBox4.Size = new System.Drawing.Size(124, 20);
                this.textBox4.TabIndex = 3;
                // 
                // label17
                // 
                this.label17.AutoSize = true;
                this.label17.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label17.Location = new System.Drawing.Point(209, 65);
                this.label17.Name = "label17";
                this.label17.Size = new System.Drawing.Size(94, 19);
                this.label17.TabIndex = 2;
                this.label17.Text = "اسم المطعم";
                // 
                // button3
                // 
                this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button3.ForeColor = System.Drawing.Color.White;
                this.button3.Location = new System.Drawing.Point(229, 153);
                this.button3.Name = "button3";
                this.button3.Size = new System.Drawing.Size(74, 31);
                this.button3.TabIndex = 1;
                this.button3.Text = "حفظ";
                this.button3.UseVisualStyleBackColor = false;
                this.button3.Click += new System.EventHandler(this.button3_Click);
                // 
                // button2
                // 
                this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button2.ForeColor = System.Drawing.Color.White;
                this.button2.Location = new System.Drawing.Point(13, 153);
                this.button2.Name = "button2";
                this.button2.Size = new System.Drawing.Size(74, 31);
                this.button2.TabIndex = 0;
                this.button2.Text = "رجوع";
                this.button2.UseVisualStyleBackColor = false;
                this.button2.Click += new System.EventHandler(this.button2_Click);
                // 
                // mealspanel
                // 
                this.mealspanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.mealspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.mealspanel.Controls.Add(this.label43);
                this.mealspanel.Controls.Add(this.panel19);
                this.mealspanel.Controls.Add(this.label42);
                this.mealspanel.Controls.Add(this.label41);
                this.mealspanel.Controls.Add(this.button22);
                this.mealspanel.Controls.Add(this.label14);
                this.mealspanel.Controls.Add(this.label13);
                this.mealspanel.Controls.Add(this.comboBox2);
                this.mealspanel.Controls.Add(this.comboBox1);
                this.mealspanel.Controls.Add(this.label12);
                this.mealspanel.Controls.Add(this.button21);
                this.mealspanel.Cursor = System.Windows.Forms.Cursors.Default;
                this.mealspanel.Location = new System.Drawing.Point(302, 166);
                this.mealspanel.Name = "mealspanel";
                this.mealspanel.Size = new System.Drawing.Size(792, 380);
                this.mealspanel.TabIndex = 26;
                this.mealspanel.Visible = false;
                // 
                // label43
                // 
                this.label43.AutoSize = true;
                this.label43.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label43.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
                this.label43.Location = new System.Drawing.Point(26, 283);
                this.label43.Name = "label43";
                this.label43.Size = new System.Drawing.Size(358, 19);
                this.label43.TabIndex = 21;
                this.label43.Text = "بعد اختيار العنصر يمكنك تعديل الاسم والسعر وغيرها";
                // 
                // panel19
                // 
                this.panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.panel19.Controls.Add(this.richTextBox2);
                this.panel19.Location = new System.Drawing.Point(408, 155);
                this.panel19.Name = "panel19";
                this.panel19.Size = new System.Drawing.Size(332, 186);
                this.panel19.TabIndex = 20;
                // 
                // richTextBox2
                // 
                this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
                this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.richTextBox2.Location = new System.Drawing.Point(2, 5);
                this.richTextBox2.Name = "richTextBox2";
                this.richTextBox2.ReadOnly = true;
                this.richTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this.richTextBox2.Size = new System.Drawing.Size(296, 169);
                this.richTextBox2.TabIndex = 0;
                this.richTextBox2.Text = "1       2       3       4         5         6\n\n\n7       8       9      10       1" +
                    "1       12\n\n\n13    14     15      16       17       18";
                // 
                // label42
                // 
                this.label42.AutoSize = true;
                this.label42.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label42.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
                this.label42.Location = new System.Drawing.Point(426, 90);
                this.label42.Name = "label42";
                this.label42.Size = new System.Drawing.Size(0, 19);
                this.label42.TabIndex = 19;
                // 
                // label41
                // 
                this.label41.AutoSize = true;
                this.label41.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label41.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
                this.label41.Location = new System.Drawing.Point(447, 59);
                this.label41.Name = "label41";
                this.label41.Size = new System.Drawing.Size(262, 19);
                this.label41.TabIndex = 18;
                this.label41.Text = "يوجد 10 قوائم من اليمين لليسار 1-10";
                // 
                // button22
                // 
                this.button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button22.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button22.ForeColor = System.Drawing.Color.White;
                this.button22.Location = new System.Drawing.Point(267, 327);
                this.button22.Name = "button22";
                this.button22.Size = new System.Drawing.Size(95, 32);
                this.button22.TabIndex = 17;
                this.button22.Text = "اختيار";
                this.button22.UseVisualStyleBackColor = false;
                this.button22.Click += new System.EventHandler(this.button22_Click);
                // 
                // label14
                // 
                this.label14.AutoSize = true;
                this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label14.Location = new System.Drawing.Point(341, 12);
                this.label14.Name = "label14";
                this.label14.Size = new System.Drawing.Size(98, 19);
                this.label14.TabIndex = 16;
                this.label14.Text = "تعديل العناصر";
                // 
                // label13
                // 
                this.label13.AutoSize = true;
                this.label13.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label13.Location = new System.Drawing.Point(205, 136);
                this.label13.Name = "label13";
                this.label13.Size = new System.Drawing.Size(113, 19);
                this.label13.TabIndex = 15;
                this.label13.Text = "اختر رقم العنصر";
                // 
                // comboBox2
                // 
                this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.comboBox2.FormattingEnabled = true;
                this.comboBox2.Items.AddRange(new object[] {
            "القائمة 1",
            "القائمة 2",
            "القائمة 3",
            "القائمة 4",
            "القائمة 5",
            "القائمة 6",
            "القائمة 7",
            "القائمة 8",
            "القائمة 9",
            "القائمة 10"});
                this.comboBox2.Location = new System.Drawing.Point(70, 78);
                this.comboBox2.Name = "comboBox2";
                this.comboBox2.Size = new System.Drawing.Size(121, 21);
                this.comboBox2.TabIndex = 14;
                // 
                // comboBox1
                // 
                this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.comboBox1.FormattingEnabled = true;
                this.comboBox1.Items.AddRange(new object[] {
            "العنصر 1",
            "العنصر 2",
            "العنصر 3",
            "العنصر 4",
            "العنصر 5",
            "العنصر 6",
            "العنصر 7",
            "العنصر 8",
            "العنصر 9",
            "العنصر 10",
            "العنصر 11",
            "العنصر 12",
            "العنصر 13",
            "العنصر 14",
            "العنصر 15",
            "العنصر 16",
            "العنصر 17",
            "العنصر 18"});
                this.comboBox1.Location = new System.Drawing.Point(70, 138);
                this.comboBox1.Name = "comboBox1";
                this.comboBox1.Size = new System.Drawing.Size(121, 21);
                this.comboBox1.TabIndex = 13;
                // 
                // label12
                // 
                this.label12.AutoSize = true;
                this.label12.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label12.Location = new System.Drawing.Point(219, 79);
                this.label12.Name = "label12";
                this.label12.Size = new System.Drawing.Size(77, 19);
                this.label12.TabIndex = 1;
                this.label12.Text = "اختر قائمة";
                // 
                // button21
                // 
                this.button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button21.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button21.ForeColor = System.Drawing.Color.White;
                this.button21.Location = new System.Drawing.Point(30, 327);
                this.button21.Name = "button21";
                this.button21.Size = new System.Drawing.Size(95, 32);
                this.button21.TabIndex = 0;
                this.button21.Text = "رجوع";
                this.button21.UseVisualStyleBackColor = false;
                this.button21.Click += new System.EventHandler(this.button21_Click);
                // 
                // editingpanel
                // 
                this.editingpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.editingpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.editingpanel.Controls.Add(this.checkBox1);
                this.editingpanel.Controls.Add(this.button25);
                this.editingpanel.Controls.Add(this.button24);
                this.editingpanel.Controls.Add(this.button23);
                this.editingpanel.Controls.Add(this.textBox3);
                this.editingpanel.Controls.Add(this.textBox2);
                this.editingpanel.Controls.Add(this.label16);
                this.editingpanel.Controls.Add(this.label15);
                this.editingpanel.Location = new System.Drawing.Point(437, 244);
                this.editingpanel.Name = "editingpanel";
                this.editingpanel.Size = new System.Drawing.Size(387, 208);
                this.editingpanel.TabIndex = 27;
                this.editingpanel.Visible = false;
                // 
                // checkBox1
                // 
                this.checkBox1.AutoSize = true;
                this.checkBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.checkBox1.Location = new System.Drawing.Point(128, 117);
                this.checkBox1.Name = "checkBox1";
                this.checkBox1.Size = new System.Drawing.Size(110, 26);
                this.checkBox1.TabIndex = 9;
                this.checkBox1.Text = "اخفاء / اظهار";
                this.checkBox1.UseVisualStyleBackColor = true;
                this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
                // 
                // button25
                // 
                this.button25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button25.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button25.ForeColor = System.Drawing.Color.White;
                this.button25.Location = new System.Drawing.Point(273, 159);
                this.button25.Name = "button25";
                this.button25.Size = new System.Drawing.Size(85, 36);
                this.button25.TabIndex = 8;
                this.button25.Text = "تعديل";
                this.button25.UseVisualStyleBackColor = false;
                this.button25.Click += new System.EventHandler(this.button25_Click);
                // 
                // button24
                // 
                this.button24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button24.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button24.ForeColor = System.Drawing.Color.White;
                this.button24.Location = new System.Drawing.Point(24, 158);
                this.button24.Name = "button24";
                this.button24.Size = new System.Drawing.Size(85, 36);
                this.button24.TabIndex = 7;
                this.button24.Text = "رجوع";
                this.button24.UseVisualStyleBackColor = false;
                this.button24.Click += new System.EventHandler(this.button24_Click);
                // 
                // button23
                // 
                this.button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button23.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button23.ForeColor = System.Drawing.Color.White;
                this.button23.Location = new System.Drawing.Point(141, 82);
                this.button23.Name = "button23";
                this.button23.Size = new System.Drawing.Size(75, 26);
                this.button23.TabIndex = 6;
                this.button23.Text = "اللون";
                this.button23.UseVisualStyleBackColor = false;
                this.button23.Click += new System.EventHandler(this.button23_Click);
                // 
                // textBox3
                // 
                this.textBox3.Location = new System.Drawing.Point(112, 51);
                this.textBox3.Name = "textBox3";
                this.textBox3.Size = new System.Drawing.Size(140, 20);
                this.textBox3.TabIndex = 5;
                // 
                // textBox2
                // 
                this.textBox2.Location = new System.Drawing.Point(112, 15);
                this.textBox2.Name = "textBox2";
                this.textBox2.Size = new System.Drawing.Size(140, 20);
                this.textBox2.TabIndex = 4;
                // 
                // label16
                // 
                this.label16.AutoSize = true;
                this.label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label16.Location = new System.Drawing.Point(299, 50);
                this.label16.Name = "label16";
                this.label16.Size = new System.Drawing.Size(50, 19);
                this.label16.TabIndex = 3;
                this.label16.Text = "السعر";
                // 
                // label15
                // 
                this.label15.AutoSize = true;
                this.label15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label15.Location = new System.Drawing.Point(285, 15);
                this.label15.Name = "label15";
                this.label15.Size = new System.Drawing.Size(87, 19);
                this.label15.TabIndex = 2;
                this.label15.Text = "اسم المنتج";
                // 
                // m1btn5
                // 
                this.m1btn5.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m1btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m1btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m1btn5.Location = new System.Drawing.Point(244, 5);
                this.m1btn5.Name = "m1btn5";
                this.m1btn5.Size = new System.Drawing.Size(211, 70);
                this.m1btn5.TabIndex = 6;
                this.m1btn5.Text = "button4";
                this.m1btn5.UseVisualStyleBackColor = true;
                this.m1btn5.Click += new System.EventHandler(this.m1btn5_Click);
                // 
                // m1btn11
                // 
                this.m1btn11.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m1btn11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m1btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m1btn11.Location = new System.Drawing.Point(244, 85);
                this.m1btn11.Name = "m1btn11";
                this.m1btn11.Size = new System.Drawing.Size(211, 70);
                this.m1btn11.TabIndex = 7;
                this.m1btn11.Text = "button5";
                this.m1btn11.UseVisualStyleBackColor = true;
                this.m1btn11.Click += new System.EventHandler(this.m1btn11_Click);
                // 
                // m1btn17
                // 
                this.m1btn17.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m1btn17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m1btn17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m1btn17.Location = new System.Drawing.Point(244, 163);
                this.m1btn17.Name = "m1btn17";
                this.m1btn17.Size = new System.Drawing.Size(211, 70);
                this.m1btn17.TabIndex = 8;
                this.m1btn17.Text = "button6";
                this.m1btn17.UseVisualStyleBackColor = true;
                this.m1btn17.Click += new System.EventHandler(this.m1btn17_Click);
                // 
                // m1btn6
                // 
                this.m1btn6.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m1btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m1btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m1btn6.Location = new System.Drawing.Point(17, 5);
                this.m1btn6.Name = "m1btn6";
                this.m1btn6.Size = new System.Drawing.Size(211, 70);
                this.m1btn6.TabIndex = 9;
                this.m1btn6.Text = "button1";
                this.m1btn6.UseVisualStyleBackColor = true;
                this.m1btn6.Click += new System.EventHandler(this.m1btn6_Click);
                // 
                // m1btn12
                // 
                this.m1btn12.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m1btn12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m1btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m1btn12.Location = new System.Drawing.Point(17, 85);
                this.m1btn12.Name = "m1btn12";
                this.m1btn12.Size = new System.Drawing.Size(211, 70);
                this.m1btn12.TabIndex = 10;
                this.m1btn12.Text = "button2";
                this.m1btn12.UseVisualStyleBackColor = true;
                this.m1btn12.Click += new System.EventHandler(this.m1btn12_Click);
                // 
                // m1btn18
                // 
                this.m1btn18.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m1btn18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m1btn18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m1btn18.Location = new System.Drawing.Point(17, 163);
                this.m1btn18.Name = "m1btn18";
                this.m1btn18.Size = new System.Drawing.Size(211, 70);
                this.m1btn18.TabIndex = 11;
                this.m1btn18.Text = "button3";
                this.m1btn18.UseVisualStyleBackColor = true;
                this.m1btn18.Click += new System.EventHandler(this.m1btn18_Click);
                // 
                // m1btn3
                // 
                this.m1btn3.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m1btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m1btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m1btn3.Location = new System.Drawing.Point(695, 7);
                this.m1btn3.Name = "m1btn3";
                this.m1btn3.Size = new System.Drawing.Size(211, 70);
                this.m1btn3.TabIndex = 12;
                this.m1btn3.Text = "button12";
                this.m1btn3.UseVisualStyleBackColor = true;
                this.m1btn3.Click += new System.EventHandler(this.m1btn3_Click);
                // 
                // m1btn9
                // 
                this.m1btn9.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m1btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m1btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m1btn9.Location = new System.Drawing.Point(695, 86);
                this.m1btn9.Name = "m1btn9";
                this.m1btn9.Size = new System.Drawing.Size(211, 70);
                this.m1btn9.TabIndex = 13;
                this.m1btn9.Text = "button11";
                this.m1btn9.UseVisualStyleBackColor = true;
                this.m1btn9.Click += new System.EventHandler(this.m1btn9_Click);
                // 
                // m1btn15
                // 
                this.m1btn15.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m1btn15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m1btn15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m1btn15.Location = new System.Drawing.Point(695, 165);
                this.m1btn15.Name = "m1btn15";
                this.m1btn15.Size = new System.Drawing.Size(211, 70);
                this.m1btn15.TabIndex = 14;
                this.m1btn15.Text = "button10";
                this.m1btn15.UseVisualStyleBackColor = true;
                this.m1btn15.Click += new System.EventHandler(this.m1btn15_Click);
                // 
                // m1btn4
                // 
                this.m1btn4.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m1btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m1btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m1btn4.Location = new System.Drawing.Point(468, 7);
                this.m1btn4.Name = "m1btn4";
                this.m1btn4.Size = new System.Drawing.Size(211, 70);
                this.m1btn4.TabIndex = 15;
                this.m1btn4.Text = "button9";
                this.m1btn4.UseVisualStyleBackColor = true;
                this.m1btn4.Click += new System.EventHandler(this.m1btn4_Click);
                // 
                // m1btn10
                // 
                this.m1btn10.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m1btn10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m1btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m1btn10.Location = new System.Drawing.Point(468, 87);
                this.m1btn10.Name = "m1btn10";
                this.m1btn10.Size = new System.Drawing.Size(211, 70);
                this.m1btn10.TabIndex = 16;
                this.m1btn10.Text = "button8";
                this.m1btn10.UseVisualStyleBackColor = true;
                this.m1btn10.Click += new System.EventHandler(this.m1btn10_Click);
                // 
                // m1btn16
                // 
                this.m1btn16.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m1btn16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m1btn16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m1btn16.Location = new System.Drawing.Point(468, 163);
                this.m1btn16.Name = "m1btn16";
                this.m1btn16.Size = new System.Drawing.Size(211, 70);
                this.m1btn16.TabIndex = 17;
                this.m1btn16.Text = "button7";
                this.m1btn16.UseVisualStyleBackColor = true;
                this.m1btn16.Click += new System.EventHandler(this.m1btn16_Click);
                // 
                // m1btn1
                // 
                this.m1btn1.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m1btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m1btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m1btn1.Location = new System.Drawing.Point(1146, 7);
                this.m1btn1.Name = "m1btn1";
                this.m1btn1.Size = new System.Drawing.Size(211, 70);
                this.m1btn1.TabIndex = 18;
                this.m1btn1.Text = "button18";
                this.m1btn1.UseVisualStyleBackColor = true;
                this.m1btn1.Click += new System.EventHandler(this.m1btn1_Click);
                // 
                // m1btn7
                // 
                this.m1btn7.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m1btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m1btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m1btn7.Location = new System.Drawing.Point(1146, 87);
                this.m1btn7.Name = "m1btn7";
                this.m1btn7.Size = new System.Drawing.Size(211, 70);
                this.m1btn7.TabIndex = 19;
                this.m1btn7.Text = "button17";
                this.m1btn7.UseVisualStyleBackColor = true;
                this.m1btn7.Click += new System.EventHandler(this.m1btn7_Click);
                // 
                // m1btn13
                // 
                this.m1btn13.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m1btn13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m1btn13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m1btn13.Location = new System.Drawing.Point(1146, 166);
                this.m1btn13.Name = "m1btn13";
                this.m1btn13.Size = new System.Drawing.Size(211, 70);
                this.m1btn13.TabIndex = 20;
                this.m1btn13.Text = "button16";
                this.m1btn13.UseVisualStyleBackColor = true;
                this.m1btn13.Click += new System.EventHandler(this.m1btn13_Click);
                // 
                // m1btn2
                // 
                this.m1btn2.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m1btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m1btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m1btn2.Location = new System.Drawing.Point(919, 8);
                this.m1btn2.Name = "m1btn2";
                this.m1btn2.Size = new System.Drawing.Size(211, 70);
                this.m1btn2.TabIndex = 21;
                this.m1btn2.Text = "button15";
                this.m1btn2.UseVisualStyleBackColor = true;
                this.m1btn2.Click += new System.EventHandler(this.m1btn2_Click);
                // 
                // m1btn8
                // 
                this.m1btn8.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m1btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m1btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m1btn8.Location = new System.Drawing.Point(919, 87);
                this.m1btn8.Name = "m1btn8";
                this.m1btn8.Size = new System.Drawing.Size(211, 70);
                this.m1btn8.TabIndex = 22;
                this.m1btn8.Text = "button14";
                this.m1btn8.UseVisualStyleBackColor = true;
                this.m1btn8.Click += new System.EventHandler(this.m1btn8_Click);
                // 
                // m1btn14
                // 
                this.m1btn14.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m1btn14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m1btn14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m1btn14.Location = new System.Drawing.Point(919, 166);
                this.m1btn14.Name = "m1btn14";
                this.m1btn14.Size = new System.Drawing.Size(211, 70);
                this.m1btn14.TabIndex = 23;
                this.m1btn14.Text = "button13";
                this.m1btn14.UseVisualStyleBackColor = true;
                this.m1btn14.Click += new System.EventHandler(this.m1btn14_Click);
                // 
                // panel3
                // 
                this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.panel3.Controls.Add(this.m1btn14);
                this.panel3.Controls.Add(this.m1btn8);
                this.panel3.Controls.Add(this.m1btn2);
                this.panel3.Controls.Add(this.m1btn13);
                this.panel3.Controls.Add(this.m1btn7);
                this.panel3.Controls.Add(this.m1btn1);
                this.panel3.Controls.Add(this.m1btn16);
                this.panel3.Controls.Add(this.m1btn10);
                this.panel3.Controls.Add(this.m1btn4);
                this.panel3.Controls.Add(this.m1btn15);
                this.panel3.Controls.Add(this.m1btn9);
                this.panel3.Controls.Add(this.m1btn3);
                this.panel3.Controls.Add(this.m1btn18);
                this.panel3.Controls.Add(this.m1btn12);
                this.panel3.Controls.Add(this.m1btn6);
                this.panel3.Controls.Add(this.m1btn17);
                this.panel3.Controls.Add(this.m1btn11);
                this.panel3.Controls.Add(this.m1btn5);
                this.panel3.Location = new System.Drawing.Point(0, 80);
                this.panel3.Name = "panel3";
                this.panel3.Size = new System.Drawing.Size(1377, 246);
                this.panel3.TabIndex = 25;
                // 
                // panel4
                // 
                this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.panel4.Controls.Add(this.m2btn14);
                this.panel4.Controls.Add(this.m2btn8);
                this.panel4.Controls.Add(this.m2btn2);
                this.panel4.Controls.Add(this.m2btn13);
                this.panel4.Controls.Add(this.m2btn7);
                this.panel4.Controls.Add(this.m2btn1);
                this.panel4.Controls.Add(this.m2btn16);
                this.panel4.Controls.Add(this.m2btn10);
                this.panel4.Controls.Add(this.m2btn4);
                this.panel4.Controls.Add(this.m2btn15);
                this.panel4.Controls.Add(this.m2btn9);
                this.panel4.Controls.Add(this.m2btn3);
                this.panel4.Controls.Add(this.m2btn18);
                this.panel4.Controls.Add(this.m2btn12);
                this.panel4.Controls.Add(this.m2btn6);
                this.panel4.Controls.Add(this.m2btn17);
                this.panel4.Controls.Add(this.m2btn11);
                this.panel4.Controls.Add(this.m2btn5);
                this.panel4.Location = new System.Drawing.Point(0, 80);
                this.panel4.Name = "panel4";
                this.panel4.Size = new System.Drawing.Size(1377, 246);
                this.panel4.TabIndex = 28;
                this.panel4.Visible = false;
                // 
                // m2btn14
                // 
                this.m2btn14.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m2btn14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m2btn14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m2btn14.Location = new System.Drawing.Point(919, 166);
                this.m2btn14.Name = "m2btn14";
                this.m2btn14.Size = new System.Drawing.Size(211, 70);
                this.m2btn14.TabIndex = 23;
                this.m2btn14.Text = "button13";
                this.m2btn14.UseVisualStyleBackColor = true;
                this.m2btn14.Click += new System.EventHandler(this.m2btn14_Click);
                // 
                // m2btn8
                // 
                this.m2btn8.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m2btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m2btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m2btn8.Location = new System.Drawing.Point(919, 87);
                this.m2btn8.Name = "m2btn8";
                this.m2btn8.Size = new System.Drawing.Size(211, 70);
                this.m2btn8.TabIndex = 22;
                this.m2btn8.Text = "button14";
                this.m2btn8.UseVisualStyleBackColor = true;
                this.m2btn8.Click += new System.EventHandler(this.m2btn8_Click);
                // 
                // m2btn2
                // 
                this.m2btn2.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m2btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m2btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m2btn2.Location = new System.Drawing.Point(919, 8);
                this.m2btn2.Name = "m2btn2";
                this.m2btn2.Size = new System.Drawing.Size(211, 70);
                this.m2btn2.TabIndex = 21;
                this.m2btn2.Text = "button15";
                this.m2btn2.UseVisualStyleBackColor = true;
                this.m2btn2.Click += new System.EventHandler(this.m2btn2_Click);
                // 
                // m2btn13
                // 
                this.m2btn13.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m2btn13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m2btn13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m2btn13.Location = new System.Drawing.Point(1146, 166);
                this.m2btn13.Name = "m2btn13";
                this.m2btn13.Size = new System.Drawing.Size(211, 70);
                this.m2btn13.TabIndex = 20;
                this.m2btn13.Text = "button16";
                this.m2btn13.UseVisualStyleBackColor = true;
                this.m2btn13.Click += new System.EventHandler(this.m2btn13_Click);
                // 
                // m2btn7
                // 
                this.m2btn7.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m2btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m2btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m2btn7.Location = new System.Drawing.Point(1146, 87);
                this.m2btn7.Name = "m2btn7";
                this.m2btn7.Size = new System.Drawing.Size(211, 70);
                this.m2btn7.TabIndex = 19;
                this.m2btn7.Text = "button17";
                this.m2btn7.UseVisualStyleBackColor = true;
                this.m2btn7.Click += new System.EventHandler(this.m2btn7_Click);
                // 
                // m2btn1
                // 
                this.m2btn1.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m2btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m2btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m2btn1.Location = new System.Drawing.Point(1146, 8);
                this.m2btn1.Name = "m2btn1";
                this.m2btn1.Size = new System.Drawing.Size(211, 70);
                this.m2btn1.TabIndex = 18;
                this.m2btn1.Text = "button18";
                this.m2btn1.UseVisualStyleBackColor = true;
                this.m2btn1.Click += new System.EventHandler(this.m2btn1_Click);
                // 
                // m2btn16
                // 
                this.m2btn16.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m2btn16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m2btn16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m2btn16.Location = new System.Drawing.Point(468, 163);
                this.m2btn16.Name = "m2btn16";
                this.m2btn16.Size = new System.Drawing.Size(211, 70);
                this.m2btn16.TabIndex = 17;
                this.m2btn16.Text = "button7";
                this.m2btn16.UseVisualStyleBackColor = true;
                this.m2btn16.Click += new System.EventHandler(this.m2btn16_Click);
                // 
                // m2btn10
                // 
                this.m2btn10.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m2btn10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m2btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m2btn10.Location = new System.Drawing.Point(468, 87);
                this.m2btn10.Name = "m2btn10";
                this.m2btn10.Size = new System.Drawing.Size(211, 70);
                this.m2btn10.TabIndex = 16;
                this.m2btn10.Text = "button8";
                this.m2btn10.UseVisualStyleBackColor = true;
                this.m2btn10.Click += new System.EventHandler(this.m2btn10_Click);
                // 
                // m2btn4
                // 
                this.m2btn4.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m2btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m2btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m2btn4.Location = new System.Drawing.Point(468, 7);
                this.m2btn4.Name = "m2btn4";
                this.m2btn4.Size = new System.Drawing.Size(211, 70);
                this.m2btn4.TabIndex = 15;
                this.m2btn4.Text = "button9";
                this.m2btn4.UseVisualStyleBackColor = true;
                this.m2btn4.Click += new System.EventHandler(this.m2btn4_Click);
                // 
                // m2btn15
                // 
                this.m2btn15.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m2btn15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m2btn15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m2btn15.Location = new System.Drawing.Point(695, 165);
                this.m2btn15.Name = "m2btn15";
                this.m2btn15.Size = new System.Drawing.Size(211, 70);
                this.m2btn15.TabIndex = 14;
                this.m2btn15.Text = "button10";
                this.m2btn15.UseVisualStyleBackColor = true;
                this.m2btn15.Click += new System.EventHandler(this.m2btn15_Click);
                // 
                // m2btn9
                // 
                this.m2btn9.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m2btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m2btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m2btn9.Location = new System.Drawing.Point(695, 86);
                this.m2btn9.Name = "m2btn9";
                this.m2btn9.Size = new System.Drawing.Size(211, 70);
                this.m2btn9.TabIndex = 13;
                this.m2btn9.Text = "button11";
                this.m2btn9.UseVisualStyleBackColor = true;
                this.m2btn9.Click += new System.EventHandler(this.m2btn9_Click);
                // 
                // m2btn3
                // 
                this.m2btn3.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m2btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m2btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m2btn3.Location = new System.Drawing.Point(695, 7);
                this.m2btn3.Name = "m2btn3";
                this.m2btn3.Size = new System.Drawing.Size(211, 70);
                this.m2btn3.TabIndex = 12;
                this.m2btn3.Text = "button12";
                this.m2btn3.UseVisualStyleBackColor = true;
                this.m2btn3.Click += new System.EventHandler(this.m2btn3_Click);
                // 
                // m2btn18
                // 
                this.m2btn18.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m2btn18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m2btn18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m2btn18.Location = new System.Drawing.Point(17, 163);
                this.m2btn18.Name = "m2btn18";
                this.m2btn18.Size = new System.Drawing.Size(211, 70);
                this.m2btn18.TabIndex = 11;
                this.m2btn18.Text = "button3";
                this.m2btn18.UseVisualStyleBackColor = true;
                this.m2btn18.Click += new System.EventHandler(this.m2btn18_Click);
                // 
                // m2btn12
                // 
                this.m2btn12.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m2btn12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m2btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m2btn12.Location = new System.Drawing.Point(17, 85);
                this.m2btn12.Name = "m2btn12";
                this.m2btn12.Size = new System.Drawing.Size(211, 70);
                this.m2btn12.TabIndex = 10;
                this.m2btn12.Text = "button2";
                this.m2btn12.UseVisualStyleBackColor = true;
                this.m2btn12.Click += new System.EventHandler(this.m2btn12_Click);
                // 
                // m2btn6
                // 
                this.m2btn6.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m2btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m2btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m2btn6.Location = new System.Drawing.Point(17, 5);
                this.m2btn6.Name = "m2btn6";
                this.m2btn6.Size = new System.Drawing.Size(211, 70);
                this.m2btn6.TabIndex = 9;
                this.m2btn6.Text = "button1";
                this.m2btn6.UseVisualStyleBackColor = true;
                this.m2btn6.Click += new System.EventHandler(this.m2btn6_Click);
                // 
                // m2btn17
                // 
                this.m2btn17.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m2btn17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m2btn17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m2btn17.Location = new System.Drawing.Point(244, 163);
                this.m2btn17.Name = "m2btn17";
                this.m2btn17.Size = new System.Drawing.Size(211, 70);
                this.m2btn17.TabIndex = 8;
                this.m2btn17.Text = "button6";
                this.m2btn17.UseVisualStyleBackColor = true;
                this.m2btn17.Click += new System.EventHandler(this.m2btn17_Click);
                // 
                // m2btn11
                // 
                this.m2btn11.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m2btn11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m2btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m2btn11.Location = new System.Drawing.Point(244, 85);
                this.m2btn11.Name = "m2btn11";
                this.m2btn11.Size = new System.Drawing.Size(211, 70);
                this.m2btn11.TabIndex = 7;
                this.m2btn11.Text = "button5";
                this.m2btn11.UseVisualStyleBackColor = true;
                this.m2btn11.Click += new System.EventHandler(this.m2btn11_Click);
                // 
                // m2btn5
                // 
                this.m2btn5.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m2btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m2btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m2btn5.Location = new System.Drawing.Point(244, 5);
                this.m2btn5.Name = "m2btn5";
                this.m2btn5.Size = new System.Drawing.Size(211, 70);
                this.m2btn5.TabIndex = 6;
                this.m2btn5.Text = "button4";
                this.m2btn5.UseVisualStyleBackColor = true;
                this.m2btn5.Click += new System.EventHandler(this.m2btn5_Click);
                // 
                // panel5
                // 
                this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.panel5.Controls.Add(this.m3btn14);
                this.panel5.Controls.Add(this.m3btn8);
                this.panel5.Controls.Add(this.m3btn2);
                this.panel5.Controls.Add(this.m3btn13);
                this.panel5.Controls.Add(this.m3btn7);
                this.panel5.Controls.Add(this.m3btn1);
                this.panel5.Controls.Add(this.m3btn16);
                this.panel5.Controls.Add(this.m3btn10);
                this.panel5.Controls.Add(this.m3btn4);
                this.panel5.Controls.Add(this.m3btn15);
                this.panel5.Controls.Add(this.m3btn9);
                this.panel5.Controls.Add(this.m3btn3);
                this.panel5.Controls.Add(this.m3btn18);
                this.panel5.Controls.Add(this.m3btn12);
                this.panel5.Controls.Add(this.m3btn6);
                this.panel5.Controls.Add(this.m3btn17);
                this.panel5.Controls.Add(this.m3btn11);
                this.panel5.Controls.Add(this.m3btn5);
                this.panel5.Location = new System.Drawing.Point(0, 80);
                this.panel5.Name = "panel5";
                this.panel5.Size = new System.Drawing.Size(1377, 246);
                this.panel5.TabIndex = 29;
                this.panel5.Visible = false;
                // 
                // m3btn14
                // 
                this.m3btn14.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m3btn14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m3btn14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m3btn14.Location = new System.Drawing.Point(919, 166);
                this.m3btn14.Name = "m3btn14";
                this.m3btn14.Size = new System.Drawing.Size(211, 70);
                this.m3btn14.TabIndex = 23;
                this.m3btn14.Text = "button13";
                this.m3btn14.UseVisualStyleBackColor = true;
                this.m3btn14.Click += new System.EventHandler(this.m3btn14_Click);
                // 
                // m3btn8
                // 
                this.m3btn8.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m3btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m3btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m3btn8.Location = new System.Drawing.Point(919, 87);
                this.m3btn8.Name = "m3btn8";
                this.m3btn8.Size = new System.Drawing.Size(211, 70);
                this.m3btn8.TabIndex = 22;
                this.m3btn8.Text = "button14";
                this.m3btn8.UseVisualStyleBackColor = true;
                this.m3btn8.Click += new System.EventHandler(this.m3btn8_Click);
                // 
                // m3btn2
                // 
                this.m3btn2.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m3btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m3btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m3btn2.Location = new System.Drawing.Point(919, 8);
                this.m3btn2.Name = "m3btn2";
                this.m3btn2.Size = new System.Drawing.Size(211, 70);
                this.m3btn2.TabIndex = 21;
                this.m3btn2.Text = "button15";
                this.m3btn2.UseVisualStyleBackColor = true;
                this.m3btn2.Click += new System.EventHandler(this.m3btn2_Click_1);
                // 
                // m3btn13
                // 
                this.m3btn13.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m3btn13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m3btn13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m3btn13.Location = new System.Drawing.Point(1146, 166);
                this.m3btn13.Name = "m3btn13";
                this.m3btn13.Size = new System.Drawing.Size(211, 70);
                this.m3btn13.TabIndex = 20;
                this.m3btn13.Text = "button16";
                this.m3btn13.UseVisualStyleBackColor = true;
                this.m3btn13.Click += new System.EventHandler(this.m3btn13_Click);
                // 
                // m3btn7
                // 
                this.m3btn7.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m3btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m3btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m3btn7.Location = new System.Drawing.Point(1146, 87);
                this.m3btn7.Name = "m3btn7";
                this.m3btn7.Size = new System.Drawing.Size(211, 70);
                this.m3btn7.TabIndex = 19;
                this.m3btn7.Text = "button17";
                this.m3btn7.UseVisualStyleBackColor = true;
                this.m3btn7.Click += new System.EventHandler(this.m3btn7_Click);
                // 
                // m3btn1
                // 
                this.m3btn1.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m3btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m3btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m3btn1.Location = new System.Drawing.Point(1146, 7);
                this.m3btn1.Name = "m3btn1";
                this.m3btn1.Size = new System.Drawing.Size(211, 70);
                this.m3btn1.TabIndex = 18;
                this.m3btn1.Text = "button18";
                this.m3btn1.UseVisualStyleBackColor = true;
                this.m3btn1.Click += new System.EventHandler(this.m3btn1_Click);
                // 
                // m3btn16
                // 
                this.m3btn16.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m3btn16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m3btn16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m3btn16.Location = new System.Drawing.Point(468, 163);
                this.m3btn16.Name = "m3btn16";
                this.m3btn16.Size = new System.Drawing.Size(211, 70);
                this.m3btn16.TabIndex = 17;
                this.m3btn16.Text = "button7";
                this.m3btn16.UseVisualStyleBackColor = true;
                this.m3btn16.Click += new System.EventHandler(this.m3btn16_Click);
                // 
                // m3btn10
                // 
                this.m3btn10.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m3btn10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m3btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m3btn10.Location = new System.Drawing.Point(468, 87);
                this.m3btn10.Name = "m3btn10";
                this.m3btn10.Size = new System.Drawing.Size(211, 70);
                this.m3btn10.TabIndex = 16;
                this.m3btn10.Text = "button8";
                this.m3btn10.UseVisualStyleBackColor = true;
                this.m3btn10.Click += new System.EventHandler(this.m3btn10_Click);
                // 
                // m3btn4
                // 
                this.m3btn4.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m3btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m3btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m3btn4.Location = new System.Drawing.Point(468, 7);
                this.m3btn4.Name = "m3btn4";
                this.m3btn4.Size = new System.Drawing.Size(211, 70);
                this.m3btn4.TabIndex = 15;
                this.m3btn4.Text = "button9";
                this.m3btn4.UseVisualStyleBackColor = true;
                this.m3btn4.Click += new System.EventHandler(this.m3btn4_Click);
                // 
                // m3btn15
                // 
                this.m3btn15.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m3btn15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m3btn15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m3btn15.Location = new System.Drawing.Point(695, 165);
                this.m3btn15.Name = "m3btn15";
                this.m3btn15.Size = new System.Drawing.Size(211, 70);
                this.m3btn15.TabIndex = 14;
                this.m3btn15.Text = "button10";
                this.m3btn15.UseVisualStyleBackColor = true;
                this.m3btn15.Click += new System.EventHandler(this.m3btn15_Click);
                // 
                // m3btn9
                // 
                this.m3btn9.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m3btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m3btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m3btn9.Location = new System.Drawing.Point(695, 86);
                this.m3btn9.Name = "m3btn9";
                this.m3btn9.Size = new System.Drawing.Size(211, 70);
                this.m3btn9.TabIndex = 13;
                this.m3btn9.Text = "button11";
                this.m3btn9.UseVisualStyleBackColor = true;
                this.m3btn9.Click += new System.EventHandler(this.m3btn9_Click);
                // 
                // m3btn3
                // 
                this.m3btn3.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m3btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m3btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m3btn3.Location = new System.Drawing.Point(695, 7);
                this.m3btn3.Name = "m3btn3";
                this.m3btn3.Size = new System.Drawing.Size(211, 70);
                this.m3btn3.TabIndex = 12;
                this.m3btn3.Text = "button12";
                this.m3btn3.UseVisualStyleBackColor = true;
                this.m3btn3.Click += new System.EventHandler(this.m3btn3_Click);
                // 
                // m3btn18
                // 
                this.m3btn18.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m3btn18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m3btn18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m3btn18.Location = new System.Drawing.Point(17, 163);
                this.m3btn18.Name = "m3btn18";
                this.m3btn18.Size = new System.Drawing.Size(211, 70);
                this.m3btn18.TabIndex = 11;
                this.m3btn18.Text = "button3";
                this.m3btn18.UseVisualStyleBackColor = true;
                this.m3btn18.Click += new System.EventHandler(this.m3btn18_Click);
                // 
                // m3btn12
                // 
                this.m3btn12.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m3btn12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m3btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m3btn12.Location = new System.Drawing.Point(17, 85);
                this.m3btn12.Name = "m3btn12";
                this.m3btn12.Size = new System.Drawing.Size(211, 70);
                this.m3btn12.TabIndex = 10;
                this.m3btn12.Text = "button2";
                this.m3btn12.UseVisualStyleBackColor = true;
                this.m3btn12.Click += new System.EventHandler(this.m3btn12_Click);
                // 
                // m3btn6
                // 
                this.m3btn6.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m3btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m3btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m3btn6.Location = new System.Drawing.Point(17, 5);
                this.m3btn6.Name = "m3btn6";
                this.m3btn6.Size = new System.Drawing.Size(211, 70);
                this.m3btn6.TabIndex = 9;
                this.m3btn6.Text = "button1";
                this.m3btn6.UseVisualStyleBackColor = true;
                this.m3btn6.Click += new System.EventHandler(this.m3btn6_Click);
                // 
                // m3btn17
                // 
                this.m3btn17.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m3btn17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m3btn17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m3btn17.Location = new System.Drawing.Point(244, 163);
                this.m3btn17.Name = "m3btn17";
                this.m3btn17.Size = new System.Drawing.Size(211, 70);
                this.m3btn17.TabIndex = 8;
                this.m3btn17.Text = "button6";
                this.m3btn17.UseVisualStyleBackColor = true;
                this.m3btn17.Click += new System.EventHandler(this.m3btn17_Click);
                // 
                // m3btn11
                // 
                this.m3btn11.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m3btn11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m3btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m3btn11.Location = new System.Drawing.Point(244, 85);
                this.m3btn11.Name = "m3btn11";
                this.m3btn11.Size = new System.Drawing.Size(211, 70);
                this.m3btn11.TabIndex = 7;
                this.m3btn11.Text = "button5";
                this.m3btn11.UseVisualStyleBackColor = true;
                this.m3btn11.Click += new System.EventHandler(this.m3btn11_Click);
                // 
                // m3btn5
                // 
                this.m3btn5.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m3btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m3btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m3btn5.Location = new System.Drawing.Point(244, 5);
                this.m3btn5.Name = "m3btn5";
                this.m3btn5.Size = new System.Drawing.Size(211, 70);
                this.m3btn5.TabIndex = 6;
                this.m3btn5.Text = "button4";
                this.m3btn5.UseVisualStyleBackColor = true;
                this.m3btn5.Click += new System.EventHandler(this.m3btn5_Click);
                // 
                // panel6
                // 
                this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.panel6.Controls.Add(this.m4btn14);
                this.panel6.Controls.Add(this.m4btn8);
                this.panel6.Controls.Add(this.m4btn2);
                this.panel6.Controls.Add(this.m4btn13);
                this.panel6.Controls.Add(this.m4btn7);
                this.panel6.Controls.Add(this.m4btn1);
                this.panel6.Controls.Add(this.m4btn16);
                this.panel6.Controls.Add(this.m4btn10);
                this.panel6.Controls.Add(this.m4btn4);
                this.panel6.Controls.Add(this.m4btn15);
                this.panel6.Controls.Add(this.m4btn9);
                this.panel6.Controls.Add(this.m4btn3);
                this.panel6.Controls.Add(this.m4btn18);
                this.panel6.Controls.Add(this.m4btn12);
                this.panel6.Controls.Add(this.m4btn6);
                this.panel6.Controls.Add(this.m4btn17);
                this.panel6.Controls.Add(this.m4btn11);
                this.panel6.Controls.Add(this.m4btn5);
                this.panel6.Location = new System.Drawing.Point(0, 80);
                this.panel6.Name = "panel6";
                this.panel6.Size = new System.Drawing.Size(1377, 246);
                this.panel6.TabIndex = 30;
                this.panel6.Visible = false;
                // 
                // m4btn14
                // 
                this.m4btn14.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m4btn14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m4btn14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m4btn14.Location = new System.Drawing.Point(919, 166);
                this.m4btn14.Name = "m4btn14";
                this.m4btn14.Size = new System.Drawing.Size(211, 70);
                this.m4btn14.TabIndex = 23;
                this.m4btn14.Text = "button13";
                this.m4btn14.UseVisualStyleBackColor = true;
                this.m4btn14.Click += new System.EventHandler(this.m4btn14_Click);
                // 
                // m4btn8
                // 
                this.m4btn8.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m4btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m4btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m4btn8.Location = new System.Drawing.Point(919, 87);
                this.m4btn8.Name = "m4btn8";
                this.m4btn8.Size = new System.Drawing.Size(211, 70);
                this.m4btn8.TabIndex = 22;
                this.m4btn8.Text = "button14";
                this.m4btn8.UseVisualStyleBackColor = true;
                this.m4btn8.Click += new System.EventHandler(this.m4btn8_Click);
                // 
                // m4btn2
                // 
                this.m4btn2.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m4btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m4btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m4btn2.Location = new System.Drawing.Point(919, 8);
                this.m4btn2.Name = "m4btn2";
                this.m4btn2.Size = new System.Drawing.Size(211, 70);
                this.m4btn2.TabIndex = 21;
                this.m4btn2.Text = "button15";
                this.m4btn2.UseVisualStyleBackColor = true;
                this.m4btn2.Click += new System.EventHandler(this.m4btn2_Click);
                // 
                // m4btn13
                // 
                this.m4btn13.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m4btn13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m4btn13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m4btn13.Location = new System.Drawing.Point(1146, 166);
                this.m4btn13.Name = "m4btn13";
                this.m4btn13.Size = new System.Drawing.Size(211, 70);
                this.m4btn13.TabIndex = 20;
                this.m4btn13.Text = "button16";
                this.m4btn13.UseVisualStyleBackColor = true;
                this.m4btn13.Click += new System.EventHandler(this.m4btn13_Click);
                // 
                // m4btn7
                // 
                this.m4btn7.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m4btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m4btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m4btn7.Location = new System.Drawing.Point(1146, 87);
                this.m4btn7.Name = "m4btn7";
                this.m4btn7.Size = new System.Drawing.Size(211, 70);
                this.m4btn7.TabIndex = 19;
                this.m4btn7.Text = "button17";
                this.m4btn7.UseVisualStyleBackColor = true;
                this.m4btn7.Click += new System.EventHandler(this.m4btn7_Click);
                // 
                // m4btn1
                // 
                this.m4btn1.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m4btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m4btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m4btn1.Location = new System.Drawing.Point(1146, 7);
                this.m4btn1.Name = "m4btn1";
                this.m4btn1.Size = new System.Drawing.Size(211, 70);
                this.m4btn1.TabIndex = 18;
                this.m4btn1.Text = "button18";
                this.m4btn1.UseVisualStyleBackColor = true;
                this.m4btn1.Click += new System.EventHandler(this.m4btn1_Click);
                // 
                // m4btn16
                // 
                this.m4btn16.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m4btn16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m4btn16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m4btn16.Location = new System.Drawing.Point(468, 163);
                this.m4btn16.Name = "m4btn16";
                this.m4btn16.Size = new System.Drawing.Size(211, 70);
                this.m4btn16.TabIndex = 17;
                this.m4btn16.Text = "button7";
                this.m4btn16.UseVisualStyleBackColor = true;
                this.m4btn16.Click += new System.EventHandler(this.m4btn16_Click);
                // 
                // m4btn10
                // 
                this.m4btn10.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m4btn10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m4btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m4btn10.Location = new System.Drawing.Point(468, 87);
                this.m4btn10.Name = "m4btn10";
                this.m4btn10.Size = new System.Drawing.Size(211, 70);
                this.m4btn10.TabIndex = 16;
                this.m4btn10.Text = "button8";
                this.m4btn10.UseVisualStyleBackColor = true;
                this.m4btn10.Click += new System.EventHandler(this.m4btn10_Click);
                // 
                // m4btn4
                // 
                this.m4btn4.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m4btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m4btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m4btn4.Location = new System.Drawing.Point(468, 7);
                this.m4btn4.Name = "m4btn4";
                this.m4btn4.Size = new System.Drawing.Size(211, 70);
                this.m4btn4.TabIndex = 15;
                this.m4btn4.Text = "button9";
                this.m4btn4.UseVisualStyleBackColor = true;
                this.m4btn4.Click += new System.EventHandler(this.m4btn4_Click);
                // 
                // m4btn15
                // 
                this.m4btn15.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m4btn15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m4btn15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m4btn15.Location = new System.Drawing.Point(695, 165);
                this.m4btn15.Name = "m4btn15";
                this.m4btn15.Size = new System.Drawing.Size(211, 70);
                this.m4btn15.TabIndex = 14;
                this.m4btn15.Text = "button10";
                this.m4btn15.UseVisualStyleBackColor = true;
                this.m4btn15.Click += new System.EventHandler(this.m4btn15_Click);
                // 
                // m4btn9
                // 
                this.m4btn9.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m4btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m4btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m4btn9.Location = new System.Drawing.Point(695, 86);
                this.m4btn9.Name = "m4btn9";
                this.m4btn9.Size = new System.Drawing.Size(211, 70);
                this.m4btn9.TabIndex = 13;
                this.m4btn9.Text = "button11";
                this.m4btn9.UseVisualStyleBackColor = true;
                this.m4btn9.Click += new System.EventHandler(this.m4btn9_Click);
                // 
                // m4btn3
                // 
                this.m4btn3.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m4btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m4btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m4btn3.Location = new System.Drawing.Point(695, 7);
                this.m4btn3.Name = "m4btn3";
                this.m4btn3.Size = new System.Drawing.Size(211, 70);
                this.m4btn3.TabIndex = 12;
                this.m4btn3.Text = "button12";
                this.m4btn3.UseVisualStyleBackColor = true;
                this.m4btn3.Click += new System.EventHandler(this.m4btn3_Click);
                // 
                // m4btn18
                // 
                this.m4btn18.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m4btn18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m4btn18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m4btn18.Location = new System.Drawing.Point(17, 163);
                this.m4btn18.Name = "m4btn18";
                this.m4btn18.Size = new System.Drawing.Size(211, 70);
                this.m4btn18.TabIndex = 11;
                this.m4btn18.Text = "button3";
                this.m4btn18.UseVisualStyleBackColor = true;
                this.m4btn18.Click += new System.EventHandler(this.m4btn18_Click);
                // 
                // m4btn12
                // 
                this.m4btn12.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m4btn12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m4btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m4btn12.Location = new System.Drawing.Point(17, 85);
                this.m4btn12.Name = "m4btn12";
                this.m4btn12.Size = new System.Drawing.Size(211, 70);
                this.m4btn12.TabIndex = 10;
                this.m4btn12.Text = "button2";
                this.m4btn12.UseVisualStyleBackColor = true;
                this.m4btn12.Click += new System.EventHandler(this.m4btn12_Click);
                // 
                // m4btn6
                // 
                this.m4btn6.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m4btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m4btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m4btn6.Location = new System.Drawing.Point(17, 5);
                this.m4btn6.Name = "m4btn6";
                this.m4btn6.Size = new System.Drawing.Size(211, 70);
                this.m4btn6.TabIndex = 9;
                this.m4btn6.Text = "button1";
                this.m4btn6.UseVisualStyleBackColor = true;
                this.m4btn6.Click += new System.EventHandler(this.m4btn6_Click);
                // 
                // m4btn17
                // 
                this.m4btn17.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m4btn17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m4btn17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m4btn17.Location = new System.Drawing.Point(244, 163);
                this.m4btn17.Name = "m4btn17";
                this.m4btn17.Size = new System.Drawing.Size(211, 70);
                this.m4btn17.TabIndex = 8;
                this.m4btn17.Text = "button6";
                this.m4btn17.UseVisualStyleBackColor = true;
                this.m4btn17.Click += new System.EventHandler(this.m4btn17_Click);
                // 
                // m4btn11
                // 
                this.m4btn11.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m4btn11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m4btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m4btn11.Location = new System.Drawing.Point(244, 85);
                this.m4btn11.Name = "m4btn11";
                this.m4btn11.Size = new System.Drawing.Size(211, 70);
                this.m4btn11.TabIndex = 7;
                this.m4btn11.Text = "button5";
                this.m4btn11.UseVisualStyleBackColor = true;
                this.m4btn11.Click += new System.EventHandler(this.m4btn11_Click);
                // 
                // m4btn5
                // 
                this.m4btn5.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m4btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m4btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m4btn5.Location = new System.Drawing.Point(244, 5);
                this.m4btn5.Name = "m4btn5";
                this.m4btn5.Size = new System.Drawing.Size(211, 70);
                this.m4btn5.TabIndex = 6;
                this.m4btn5.Text = "button4";
                this.m4btn5.UseVisualStyleBackColor = true;
                this.m4btn5.Click += new System.EventHandler(this.m4btn5_Click);
                // 
                // panel7
                // 
                this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.panel7.Controls.Add(this.m5btn14);
                this.panel7.Controls.Add(this.m5btn8);
                this.panel7.Controls.Add(this.m5btn2);
                this.panel7.Controls.Add(this.m5btn13);
                this.panel7.Controls.Add(this.m5btn7);
                this.panel7.Controls.Add(this.m5btn1);
                this.panel7.Controls.Add(this.m5btn16);
                this.panel7.Controls.Add(this.m5btn10);
                this.panel7.Controls.Add(this.m5btn4);
                this.panel7.Controls.Add(this.m5btn15);
                this.panel7.Controls.Add(this.m5btn9);
                this.panel7.Controls.Add(this.m5btn3);
                this.panel7.Controls.Add(this.m5btn18);
                this.panel7.Controls.Add(this.m5btn12);
                this.panel7.Controls.Add(this.m5btn6);
                this.panel7.Controls.Add(this.m5btn17);
                this.panel7.Controls.Add(this.m5btn11);
                this.panel7.Controls.Add(this.m5btn5);
                this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.panel7.Location = new System.Drawing.Point(0, 80);
                this.panel7.Name = "panel7";
                this.panel7.Size = new System.Drawing.Size(1377, 246);
                this.panel7.TabIndex = 31;
                this.panel7.Visible = false;
                // 
                // m5btn14
                // 
                this.m5btn14.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m5btn14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m5btn14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m5btn14.Location = new System.Drawing.Point(919, 166);
                this.m5btn14.Name = "m5btn14";
                this.m5btn14.Size = new System.Drawing.Size(211, 70);
                this.m5btn14.TabIndex = 23;
                this.m5btn14.Text = "button13";
                this.m5btn14.UseVisualStyleBackColor = true;
                this.m5btn14.Click += new System.EventHandler(this.m5btn14_Click);
                // 
                // m5btn8
                // 
                this.m5btn8.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m5btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m5btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m5btn8.Location = new System.Drawing.Point(919, 87);
                this.m5btn8.Name = "m5btn8";
                this.m5btn8.Size = new System.Drawing.Size(211, 70);
                this.m5btn8.TabIndex = 22;
                this.m5btn8.Text = "button14";
                this.m5btn8.UseVisualStyleBackColor = true;
                this.m5btn8.Click += new System.EventHandler(this.m5btn8_Click);
                // 
                // m5btn2
                // 
                this.m5btn2.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m5btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m5btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m5btn2.Location = new System.Drawing.Point(919, 8);
                this.m5btn2.Name = "m5btn2";
                this.m5btn2.Size = new System.Drawing.Size(211, 70);
                this.m5btn2.TabIndex = 21;
                this.m5btn2.Text = "button15";
                this.m5btn2.UseVisualStyleBackColor = true;
                this.m5btn2.Click += new System.EventHandler(this.m5btn2_Click);
                // 
                // m5btn13
                // 
                this.m5btn13.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m5btn13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m5btn13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m5btn13.Location = new System.Drawing.Point(1146, 166);
                this.m5btn13.Name = "m5btn13";
                this.m5btn13.Size = new System.Drawing.Size(211, 70);
                this.m5btn13.TabIndex = 20;
                this.m5btn13.Text = "button16";
                this.m5btn13.UseVisualStyleBackColor = true;
                this.m5btn13.Click += new System.EventHandler(this.m5btn13_Click);
                // 
                // m5btn7
                // 
                this.m5btn7.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m5btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m5btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m5btn7.Location = new System.Drawing.Point(1146, 87);
                this.m5btn7.Name = "m5btn7";
                this.m5btn7.Size = new System.Drawing.Size(211, 70);
                this.m5btn7.TabIndex = 19;
                this.m5btn7.Text = "button17";
                this.m5btn7.UseVisualStyleBackColor = true;
                this.m5btn7.Click += new System.EventHandler(this.m5btn7_Click);
                // 
                // m5btn1
                // 
                this.m5btn1.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m5btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m5btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m5btn1.Location = new System.Drawing.Point(1146, 7);
                this.m5btn1.Name = "m5btn1";
                this.m5btn1.Size = new System.Drawing.Size(211, 70);
                this.m5btn1.TabIndex = 18;
                this.m5btn1.Text = "button18";
                this.m5btn1.UseVisualStyleBackColor = true;
                this.m5btn1.Click += new System.EventHandler(this.m5btn1_Click);
                // 
                // m5btn16
                // 
                this.m5btn16.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m5btn16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m5btn16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m5btn16.Location = new System.Drawing.Point(468, 163);
                this.m5btn16.Name = "m5btn16";
                this.m5btn16.Size = new System.Drawing.Size(211, 70);
                this.m5btn16.TabIndex = 17;
                this.m5btn16.Text = "button7";
                this.m5btn16.UseVisualStyleBackColor = true;
                this.m5btn16.Click += new System.EventHandler(this.m5btn16_Click);
                // 
                // m5btn10
                // 
                this.m5btn10.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m5btn10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m5btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m5btn10.Location = new System.Drawing.Point(468, 87);
                this.m5btn10.Name = "m5btn10";
                this.m5btn10.Size = new System.Drawing.Size(211, 70);
                this.m5btn10.TabIndex = 16;
                this.m5btn10.Text = "button8";
                this.m5btn10.UseVisualStyleBackColor = true;
                this.m5btn10.Click += new System.EventHandler(this.m5btn10_Click);
                // 
                // m5btn4
                // 
                this.m5btn4.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m5btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m5btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m5btn4.Location = new System.Drawing.Point(468, 7);
                this.m5btn4.Name = "m5btn4";
                this.m5btn4.Size = new System.Drawing.Size(211, 70);
                this.m5btn4.TabIndex = 15;
                this.m5btn4.Text = "button9";
                this.m5btn4.UseVisualStyleBackColor = true;
                this.m5btn4.Click += new System.EventHandler(this.m5btn4_Click);
                // 
                // m5btn15
                // 
                this.m5btn15.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m5btn15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m5btn15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m5btn15.Location = new System.Drawing.Point(695, 165);
                this.m5btn15.Name = "m5btn15";
                this.m5btn15.Size = new System.Drawing.Size(211, 70);
                this.m5btn15.TabIndex = 14;
                this.m5btn15.Text = "button10";
                this.m5btn15.UseVisualStyleBackColor = true;
                this.m5btn15.Click += new System.EventHandler(this.m5btn15_Click);
                // 
                // m5btn9
                // 
                this.m5btn9.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m5btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m5btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m5btn9.Location = new System.Drawing.Point(695, 86);
                this.m5btn9.Name = "m5btn9";
                this.m5btn9.Size = new System.Drawing.Size(211, 70);
                this.m5btn9.TabIndex = 13;
                this.m5btn9.Text = "button11";
                this.m5btn9.UseVisualStyleBackColor = true;
                this.m5btn9.Click += new System.EventHandler(this.m5btn9_Click);
                // 
                // m5btn3
                // 
                this.m5btn3.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m5btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m5btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m5btn3.Location = new System.Drawing.Point(695, 7);
                this.m5btn3.Name = "m5btn3";
                this.m5btn3.Size = new System.Drawing.Size(211, 70);
                this.m5btn3.TabIndex = 12;
                this.m5btn3.Text = "button12";
                this.m5btn3.UseVisualStyleBackColor = true;
                this.m5btn3.Click += new System.EventHandler(this.m5btn3_Click);
                // 
                // m5btn18
                // 
                this.m5btn18.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m5btn18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m5btn18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m5btn18.Location = new System.Drawing.Point(17, 163);
                this.m5btn18.Name = "m5btn18";
                this.m5btn18.Size = new System.Drawing.Size(211, 70);
                this.m5btn18.TabIndex = 11;
                this.m5btn18.Text = "button3";
                this.m5btn18.UseVisualStyleBackColor = true;
                this.m5btn18.Click += new System.EventHandler(this.m5btn18_Click);
                // 
                // m5btn12
                // 
                this.m5btn12.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m5btn12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m5btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m5btn12.Location = new System.Drawing.Point(17, 85);
                this.m5btn12.Name = "m5btn12";
                this.m5btn12.Size = new System.Drawing.Size(211, 70);
                this.m5btn12.TabIndex = 10;
                this.m5btn12.Text = "button2";
                this.m5btn12.UseVisualStyleBackColor = true;
                this.m5btn12.Click += new System.EventHandler(this.m5btn12_Click);
                // 
                // m5btn6
                // 
                this.m5btn6.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m5btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m5btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m5btn6.Location = new System.Drawing.Point(17, 5);
                this.m5btn6.Name = "m5btn6";
                this.m5btn6.Size = new System.Drawing.Size(211, 70);
                this.m5btn6.TabIndex = 9;
                this.m5btn6.Text = "button1";
                this.m5btn6.UseVisualStyleBackColor = true;
                this.m5btn6.Click += new System.EventHandler(this.m5btn6_Click);
                // 
                // m5btn17
                // 
                this.m5btn17.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m5btn17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m5btn17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m5btn17.Location = new System.Drawing.Point(244, 163);
                this.m5btn17.Name = "m5btn17";
                this.m5btn17.Size = new System.Drawing.Size(211, 70);
                this.m5btn17.TabIndex = 8;
                this.m5btn17.Text = "button6";
                this.m5btn17.UseVisualStyleBackColor = true;
                this.m5btn17.Click += new System.EventHandler(this.m5btn17_Click);
                // 
                // m5btn11
                // 
                this.m5btn11.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m5btn11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m5btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m5btn11.Location = new System.Drawing.Point(244, 85);
                this.m5btn11.Name = "m5btn11";
                this.m5btn11.Size = new System.Drawing.Size(211, 70);
                this.m5btn11.TabIndex = 7;
                this.m5btn11.Text = "button5";
                this.m5btn11.UseVisualStyleBackColor = true;
                this.m5btn11.Click += new System.EventHandler(this.m5btn11_Click);
                // 
                // m5btn5
                // 
                this.m5btn5.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m5btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m5btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m5btn5.Location = new System.Drawing.Point(244, 5);
                this.m5btn5.Name = "m5btn5";
                this.m5btn5.Size = new System.Drawing.Size(211, 70);
                this.m5btn5.TabIndex = 6;
                this.m5btn5.Text = "button4";
                this.m5btn5.UseVisualStyleBackColor = true;
                this.m5btn5.Click += new System.EventHandler(this.m5btn5_Click);
                // 
                // panel8
                // 
                this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.panel8.Controls.Add(this.m6btn14);
                this.panel8.Controls.Add(this.m6btn8);
                this.panel8.Controls.Add(this.m6btn2);
                this.panel8.Controls.Add(this.m6btn13);
                this.panel8.Controls.Add(this.m6btn7);
                this.panel8.Controls.Add(this.m6btn1);
                this.panel8.Controls.Add(this.m6btn16);
                this.panel8.Controls.Add(this.m6btn10);
                this.panel8.Controls.Add(this.m6btn4);
                this.panel8.Controls.Add(this.m6btn15);
                this.panel8.Controls.Add(this.m6btn9);
                this.panel8.Controls.Add(this.m6btn3);
                this.panel8.Controls.Add(this.m6btn18);
                this.panel8.Controls.Add(this.m6btn12);
                this.panel8.Controls.Add(this.m6btn6);
                this.panel8.Controls.Add(this.m6btn17);
                this.panel8.Controls.Add(this.m6btn11);
                this.panel8.Controls.Add(this.m6btn5);
                this.panel8.Location = new System.Drawing.Point(0, 80);
                this.panel8.Name = "panel8";
                this.panel8.Size = new System.Drawing.Size(1377, 246);
                this.panel8.TabIndex = 32;
                this.panel8.Visible = false;
                // 
                // m6btn14
                // 
                this.m6btn14.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m6btn14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m6btn14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m6btn14.Location = new System.Drawing.Point(919, 166);
                this.m6btn14.Name = "m6btn14";
                this.m6btn14.Size = new System.Drawing.Size(211, 70);
                this.m6btn14.TabIndex = 23;
                this.m6btn14.Text = "button13";
                this.m6btn14.UseVisualStyleBackColor = true;
                this.m6btn14.Click += new System.EventHandler(this.m6btn14_Click);
                // 
                // m6btn8
                // 
                this.m6btn8.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m6btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m6btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m6btn8.Location = new System.Drawing.Point(919, 87);
                this.m6btn8.Name = "m6btn8";
                this.m6btn8.Size = new System.Drawing.Size(211, 70);
                this.m6btn8.TabIndex = 22;
                this.m6btn8.Text = "button14";
                this.m6btn8.UseVisualStyleBackColor = true;
                this.m6btn8.Click += new System.EventHandler(this.m6btn8_Click);
                // 
                // m6btn2
                // 
                this.m6btn2.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m6btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m6btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m6btn2.Location = new System.Drawing.Point(919, 8);
                this.m6btn2.Name = "m6btn2";
                this.m6btn2.Size = new System.Drawing.Size(211, 70);
                this.m6btn2.TabIndex = 21;
                this.m6btn2.Text = "button15";
                this.m6btn2.UseVisualStyleBackColor = true;
                this.m6btn2.Click += new System.EventHandler(this.m6btn2_Click);
                // 
                // m6btn13
                // 
                this.m6btn13.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m6btn13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m6btn13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m6btn13.Location = new System.Drawing.Point(1146, 166);
                this.m6btn13.Name = "m6btn13";
                this.m6btn13.Size = new System.Drawing.Size(211, 70);
                this.m6btn13.TabIndex = 20;
                this.m6btn13.Text = "button16";
                this.m6btn13.UseVisualStyleBackColor = true;
                this.m6btn13.Click += new System.EventHandler(this.m6btn13_Click);
                // 
                // m6btn7
                // 
                this.m6btn7.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m6btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m6btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m6btn7.Location = new System.Drawing.Point(1146, 87);
                this.m6btn7.Name = "m6btn7";
                this.m6btn7.Size = new System.Drawing.Size(211, 70);
                this.m6btn7.TabIndex = 19;
                this.m6btn7.Text = "button17";
                this.m6btn7.UseVisualStyleBackColor = true;
                this.m6btn7.Click += new System.EventHandler(this.m6btn7_Click);
                // 
                // m6btn1
                // 
                this.m6btn1.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m6btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m6btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m6btn1.Location = new System.Drawing.Point(1146, 7);
                this.m6btn1.Name = "m6btn1";
                this.m6btn1.Size = new System.Drawing.Size(211, 70);
                this.m6btn1.TabIndex = 18;
                this.m6btn1.Text = "button18";
                this.m6btn1.UseVisualStyleBackColor = true;
                this.m6btn1.Click += new System.EventHandler(this.m6btn1_Click);
                // 
                // m6btn16
                // 
                this.m6btn16.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m6btn16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m6btn16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m6btn16.Location = new System.Drawing.Point(468, 163);
                this.m6btn16.Name = "m6btn16";
                this.m6btn16.Size = new System.Drawing.Size(211, 70);
                this.m6btn16.TabIndex = 17;
                this.m6btn16.Text = "button7";
                this.m6btn16.UseVisualStyleBackColor = true;
                this.m6btn16.Click += new System.EventHandler(this.m6btn16_Click);
                // 
                // m6btn10
                // 
                this.m6btn10.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m6btn10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m6btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m6btn10.Location = new System.Drawing.Point(468, 87);
                this.m6btn10.Name = "m6btn10";
                this.m6btn10.Size = new System.Drawing.Size(211, 70);
                this.m6btn10.TabIndex = 16;
                this.m6btn10.Text = "button8";
                this.m6btn10.UseVisualStyleBackColor = true;
                this.m6btn10.Click += new System.EventHandler(this.m6btn10_Click);
                // 
                // m6btn4
                // 
                this.m6btn4.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m6btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m6btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m6btn4.Location = new System.Drawing.Point(468, 7);
                this.m6btn4.Name = "m6btn4";
                this.m6btn4.Size = new System.Drawing.Size(211, 70);
                this.m6btn4.TabIndex = 15;
                this.m6btn4.Text = "button9";
                this.m6btn4.UseVisualStyleBackColor = true;
                this.m6btn4.Click += new System.EventHandler(this.m6btn4_Click);
                // 
                // m6btn15
                // 
                this.m6btn15.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m6btn15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m6btn15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m6btn15.Location = new System.Drawing.Point(695, 165);
                this.m6btn15.Name = "m6btn15";
                this.m6btn15.Size = new System.Drawing.Size(211, 70);
                this.m6btn15.TabIndex = 14;
                this.m6btn15.Text = "button10";
                this.m6btn15.UseVisualStyleBackColor = true;
                this.m6btn15.Click += new System.EventHandler(this.m6btn15_Click);
                // 
                // m6btn9
                // 
                this.m6btn9.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m6btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m6btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m6btn9.Location = new System.Drawing.Point(695, 86);
                this.m6btn9.Name = "m6btn9";
                this.m6btn9.Size = new System.Drawing.Size(211, 70);
                this.m6btn9.TabIndex = 13;
                this.m6btn9.Text = "button11";
                this.m6btn9.UseVisualStyleBackColor = true;
                this.m6btn9.Click += new System.EventHandler(this.m6btn9_Click);
                // 
                // m6btn3
                // 
                this.m6btn3.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m6btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m6btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m6btn3.Location = new System.Drawing.Point(695, 7);
                this.m6btn3.Name = "m6btn3";
                this.m6btn3.Size = new System.Drawing.Size(211, 70);
                this.m6btn3.TabIndex = 12;
                this.m6btn3.Text = "button12";
                this.m6btn3.UseVisualStyleBackColor = true;
                this.m6btn3.Click += new System.EventHandler(this.m6btn3_Click);
                // 
                // m6btn18
                // 
                this.m6btn18.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m6btn18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m6btn18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m6btn18.Location = new System.Drawing.Point(17, 163);
                this.m6btn18.Name = "m6btn18";
                this.m6btn18.Size = new System.Drawing.Size(211, 70);
                this.m6btn18.TabIndex = 11;
                this.m6btn18.Text = "button3";
                this.m6btn18.UseVisualStyleBackColor = true;
                this.m6btn18.Click += new System.EventHandler(this.m6btn18_Click);
                // 
                // m6btn12
                // 
                this.m6btn12.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m6btn12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m6btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m6btn12.Location = new System.Drawing.Point(17, 85);
                this.m6btn12.Name = "m6btn12";
                this.m6btn12.Size = new System.Drawing.Size(211, 70);
                this.m6btn12.TabIndex = 10;
                this.m6btn12.Text = "button2";
                this.m6btn12.UseVisualStyleBackColor = true;
                this.m6btn12.Click += new System.EventHandler(this.m6btn12_Click);
                // 
                // m6btn6
                // 
                this.m6btn6.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m6btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m6btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m6btn6.Location = new System.Drawing.Point(17, 5);
                this.m6btn6.Name = "m6btn6";
                this.m6btn6.Size = new System.Drawing.Size(211, 70);
                this.m6btn6.TabIndex = 9;
                this.m6btn6.Text = "button1";
                this.m6btn6.UseVisualStyleBackColor = true;
                this.m6btn6.Click += new System.EventHandler(this.m6btn6_Click);
                // 
                // m6btn17
                // 
                this.m6btn17.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m6btn17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m6btn17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m6btn17.Location = new System.Drawing.Point(244, 163);
                this.m6btn17.Name = "m6btn17";
                this.m6btn17.Size = new System.Drawing.Size(211, 70);
                this.m6btn17.TabIndex = 8;
                this.m6btn17.Text = "button6";
                this.m6btn17.UseVisualStyleBackColor = true;
                this.m6btn17.Click += new System.EventHandler(this.m6btn17_Click);
                // 
                // m6btn11
                // 
                this.m6btn11.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m6btn11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m6btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m6btn11.Location = new System.Drawing.Point(244, 85);
                this.m6btn11.Name = "m6btn11";
                this.m6btn11.Size = new System.Drawing.Size(211, 70);
                this.m6btn11.TabIndex = 7;
                this.m6btn11.Text = "button5";
                this.m6btn11.UseVisualStyleBackColor = true;
                this.m6btn11.Click += new System.EventHandler(this.m6btn11_Click);
                // 
                // m6btn5
                // 
                this.m6btn5.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m6btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m6btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m6btn5.Location = new System.Drawing.Point(244, 5);
                this.m6btn5.Name = "m6btn5";
                this.m6btn5.Size = new System.Drawing.Size(211, 70);
                this.m6btn5.TabIndex = 6;
                this.m6btn5.Text = "button4";
                this.m6btn5.UseVisualStyleBackColor = true;
                this.m6btn5.Click += new System.EventHandler(this.m6btn5_Click);
                // 
                // panel9
                // 
                this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                            | System.Windows.Forms.AnchorStyles.Right)));
                this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.panel9.Controls.Add(this.m7btn14);
                this.panel9.Controls.Add(this.m7btn8);
                this.panel9.Controls.Add(this.m7btn2);
                this.panel9.Controls.Add(this.m7btn13);
                this.panel9.Controls.Add(this.m7btn7);
                this.panel9.Controls.Add(this.m7btn1);
                this.panel9.Controls.Add(this.m7btn16);
                this.panel9.Controls.Add(this.m7btn10);
                this.panel9.Controls.Add(this.m7btn4);
                this.panel9.Controls.Add(this.m7btn15);
                this.panel9.Controls.Add(this.m7btn9);
                this.panel9.Controls.Add(this.m7btn3);
                this.panel9.Controls.Add(this.m7btn18);
                this.panel9.Controls.Add(this.m7btn12);
                this.panel9.Controls.Add(this.m7btn6);
                this.panel9.Controls.Add(this.m7btn17);
                this.panel9.Controls.Add(this.m7btn11);
                this.panel9.Controls.Add(this.m7btn5);
                this.panel9.Location = new System.Drawing.Point(0, 80);
                this.panel9.Name = "panel9";
                this.panel9.Size = new System.Drawing.Size(1377, 246);
                this.panel9.TabIndex = 33;
                this.panel9.Visible = false;
                // 
                // m7btn14
                // 
                this.m7btn14.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m7btn14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m7btn14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m7btn14.Location = new System.Drawing.Point(919, 166);
                this.m7btn14.Name = "m7btn14";
                this.m7btn14.Size = new System.Drawing.Size(211, 70);
                this.m7btn14.TabIndex = 23;
                this.m7btn14.Text = "button13";
                this.m7btn14.UseVisualStyleBackColor = true;
                this.m7btn14.Click += new System.EventHandler(this.m7btn14_Click);
                // 
                // m7btn8
                // 
                this.m7btn8.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m7btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m7btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m7btn8.Location = new System.Drawing.Point(919, 87);
                this.m7btn8.Name = "m7btn8";
                this.m7btn8.Size = new System.Drawing.Size(211, 70);
                this.m7btn8.TabIndex = 22;
                this.m7btn8.Text = "button14";
                this.m7btn8.UseVisualStyleBackColor = true;
                this.m7btn8.Click += new System.EventHandler(this.m7btn8_Click);
                // 
                // m7btn2
                // 
                this.m7btn2.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m7btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m7btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m7btn2.Location = new System.Drawing.Point(919, 8);
                this.m7btn2.Name = "m7btn2";
                this.m7btn2.Size = new System.Drawing.Size(211, 70);
                this.m7btn2.TabIndex = 21;
                this.m7btn2.Text = "button15";
                this.m7btn2.UseVisualStyleBackColor = true;
                this.m7btn2.Click += new System.EventHandler(this.m7btn2_Click);
                // 
                // m7btn13
                // 
                this.m7btn13.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m7btn13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m7btn13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m7btn13.Location = new System.Drawing.Point(1146, 166);
                this.m7btn13.Name = "m7btn13";
                this.m7btn13.Size = new System.Drawing.Size(211, 70);
                this.m7btn13.TabIndex = 20;
                this.m7btn13.Text = "button16";
                this.m7btn13.UseVisualStyleBackColor = true;
                this.m7btn13.Click += new System.EventHandler(this.m7btn13_Click);
                // 
                // m7btn7
                // 
                this.m7btn7.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m7btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m7btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m7btn7.Location = new System.Drawing.Point(1146, 87);
                this.m7btn7.Name = "m7btn7";
                this.m7btn7.Size = new System.Drawing.Size(211, 70);
                this.m7btn7.TabIndex = 19;
                this.m7btn7.Text = "button17";
                this.m7btn7.UseVisualStyleBackColor = true;
                this.m7btn7.Click += new System.EventHandler(this.m7btn7_Click);
                // 
                // m7btn1
                // 
                this.m7btn1.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m7btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m7btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m7btn1.Location = new System.Drawing.Point(1146, 7);
                this.m7btn1.Name = "m7btn1";
                this.m7btn1.Size = new System.Drawing.Size(211, 70);
                this.m7btn1.TabIndex = 18;
                this.m7btn1.Text = "button18";
                this.m7btn1.UseVisualStyleBackColor = true;
                this.m7btn1.Click += new System.EventHandler(this.m7btn1_Click);
                // 
                // m7btn16
                // 
                this.m7btn16.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m7btn16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m7btn16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m7btn16.Location = new System.Drawing.Point(468, 163);
                this.m7btn16.Name = "m7btn16";
                this.m7btn16.Size = new System.Drawing.Size(211, 70);
                this.m7btn16.TabIndex = 17;
                this.m7btn16.Text = "button7";
                this.m7btn16.UseVisualStyleBackColor = true;
                this.m7btn16.Click += new System.EventHandler(this.m7btn16_Click);
                // 
                // m7btn10
                // 
                this.m7btn10.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m7btn10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m7btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m7btn10.Location = new System.Drawing.Point(468, 87);
                this.m7btn10.Name = "m7btn10";
                this.m7btn10.Size = new System.Drawing.Size(211, 70);
                this.m7btn10.TabIndex = 16;
                this.m7btn10.Text = "button8";
                this.m7btn10.UseVisualStyleBackColor = true;
                this.m7btn10.Click += new System.EventHandler(this.m7btn10_Click);
                // 
                // m7btn4
                // 
                this.m7btn4.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m7btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m7btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m7btn4.Location = new System.Drawing.Point(468, 7);
                this.m7btn4.Name = "m7btn4";
                this.m7btn4.Size = new System.Drawing.Size(211, 70);
                this.m7btn4.TabIndex = 15;
                this.m7btn4.Text = "button9";
                this.m7btn4.UseVisualStyleBackColor = true;
                this.m7btn4.Click += new System.EventHandler(this.m7btn4_Click);
                // 
                // m7btn15
                // 
                this.m7btn15.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m7btn15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m7btn15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m7btn15.Location = new System.Drawing.Point(695, 165);
                this.m7btn15.Name = "m7btn15";
                this.m7btn15.Size = new System.Drawing.Size(211, 70);
                this.m7btn15.TabIndex = 14;
                this.m7btn15.Text = "button10";
                this.m7btn15.UseVisualStyleBackColor = true;
                this.m7btn15.Click += new System.EventHandler(this.m7btn15_Click);
                // 
                // m7btn9
                // 
                this.m7btn9.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m7btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m7btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m7btn9.Location = new System.Drawing.Point(695, 86);
                this.m7btn9.Name = "m7btn9";
                this.m7btn9.Size = new System.Drawing.Size(211, 70);
                this.m7btn9.TabIndex = 13;
                this.m7btn9.Text = "button11";
                this.m7btn9.UseVisualStyleBackColor = true;
                this.m7btn9.Click += new System.EventHandler(this.m7btn9_Click);
                // 
                // m7btn3
                // 
                this.m7btn3.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m7btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m7btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m7btn3.Location = new System.Drawing.Point(695, 7);
                this.m7btn3.Name = "m7btn3";
                this.m7btn3.Size = new System.Drawing.Size(211, 70);
                this.m7btn3.TabIndex = 12;
                this.m7btn3.Text = "button12";
                this.m7btn3.UseVisualStyleBackColor = true;
                this.m7btn3.Click += new System.EventHandler(this.m7btn3_Click);
                // 
                // m7btn18
                // 
                this.m7btn18.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m7btn18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m7btn18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m7btn18.Location = new System.Drawing.Point(17, 163);
                this.m7btn18.Name = "m7btn18";
                this.m7btn18.Size = new System.Drawing.Size(211, 70);
                this.m7btn18.TabIndex = 11;
                this.m7btn18.Text = "button3";
                this.m7btn18.UseVisualStyleBackColor = true;
                this.m7btn18.Click += new System.EventHandler(this.m7btn18_Click);
                // 
                // m7btn12
                // 
                this.m7btn12.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m7btn12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m7btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m7btn12.Location = new System.Drawing.Point(17, 85);
                this.m7btn12.Name = "m7btn12";
                this.m7btn12.Size = new System.Drawing.Size(211, 70);
                this.m7btn12.TabIndex = 10;
                this.m7btn12.Text = "button2";
                this.m7btn12.UseVisualStyleBackColor = true;
                this.m7btn12.Click += new System.EventHandler(this.m7btn12_Click);
                // 
                // m7btn6
                // 
                this.m7btn6.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m7btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m7btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m7btn6.Location = new System.Drawing.Point(17, 5);
                this.m7btn6.Name = "m7btn6";
                this.m7btn6.Size = new System.Drawing.Size(211, 70);
                this.m7btn6.TabIndex = 9;
                this.m7btn6.Text = "button1";
                this.m7btn6.UseVisualStyleBackColor = true;
                this.m7btn6.Click += new System.EventHandler(this.m7btn6_Click);
                // 
                // m7btn17
                // 
                this.m7btn17.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m7btn17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m7btn17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m7btn17.Location = new System.Drawing.Point(244, 163);
                this.m7btn17.Name = "m7btn17";
                this.m7btn17.Size = new System.Drawing.Size(211, 70);
                this.m7btn17.TabIndex = 8;
                this.m7btn17.Text = "button6";
                this.m7btn17.UseVisualStyleBackColor = true;
                this.m7btn17.Click += new System.EventHandler(this.m7btn17_Click);
                // 
                // m7btn11
                // 
                this.m7btn11.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m7btn11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m7btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m7btn11.Location = new System.Drawing.Point(244, 85);
                this.m7btn11.Name = "m7btn11";
                this.m7btn11.Size = new System.Drawing.Size(211, 70);
                this.m7btn11.TabIndex = 7;
                this.m7btn11.Text = "button5";
                this.m7btn11.UseVisualStyleBackColor = true;
                this.m7btn11.Click += new System.EventHandler(this.m7btn11_Click);
                // 
                // m7btn5
                // 
                this.m7btn5.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m7btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m7btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m7btn5.Location = new System.Drawing.Point(244, 5);
                this.m7btn5.Name = "m7btn5";
                this.m7btn5.Size = new System.Drawing.Size(211, 70);
                this.m7btn5.TabIndex = 6;
                this.m7btn5.Text = "button4";
                this.m7btn5.UseVisualStyleBackColor = true;
                this.m7btn5.Click += new System.EventHandler(this.m7btn5_Click);
                // 
                // panel10
                // 
                this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.panel10.Controls.Add(this.m8btn14);
                this.panel10.Controls.Add(this.m8btn8);
                this.panel10.Controls.Add(this.m8btn2);
                this.panel10.Controls.Add(this.m8btn13);
                this.panel10.Controls.Add(this.m8btn7);
                this.panel10.Controls.Add(this.m8btn1);
                this.panel10.Controls.Add(this.m8btn16);
                this.panel10.Controls.Add(this.m8btn10);
                this.panel10.Controls.Add(this.m8btn4);
                this.panel10.Controls.Add(this.m8btn15);
                this.panel10.Controls.Add(this.m8btn9);
                this.panel10.Controls.Add(this.m8btn3);
                this.panel10.Controls.Add(this.m8btn18);
                this.panel10.Controls.Add(this.m8btn12);
                this.panel10.Controls.Add(this.m8btn6);
                this.panel10.Controls.Add(this.m8btn17);
                this.panel10.Controls.Add(this.m8btn11);
                this.panel10.Controls.Add(this.m8btn5);
                this.panel10.Location = new System.Drawing.Point(0, 80);
                this.panel10.Name = "panel10";
                this.panel10.Size = new System.Drawing.Size(1377, 246);
                this.panel10.TabIndex = 34;
                this.panel10.Visible = false;
                // 
                // m8btn14
                // 
                this.m8btn14.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m8btn14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m8btn14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m8btn14.Location = new System.Drawing.Point(919, 166);
                this.m8btn14.Name = "m8btn14";
                this.m8btn14.Size = new System.Drawing.Size(211, 70);
                this.m8btn14.TabIndex = 23;
                this.m8btn14.Text = "button13";
                this.m8btn14.UseVisualStyleBackColor = true;
                this.m8btn14.Click += new System.EventHandler(this.m8btn14_Click);
                // 
                // m8btn8
                // 
                this.m8btn8.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m8btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m8btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m8btn8.Location = new System.Drawing.Point(919, 87);
                this.m8btn8.Name = "m8btn8";
                this.m8btn8.Size = new System.Drawing.Size(211, 70);
                this.m8btn8.TabIndex = 22;
                this.m8btn8.Text = "button14";
                this.m8btn8.UseVisualStyleBackColor = true;
                this.m8btn8.Click += new System.EventHandler(this.m8btn8_Click);
                // 
                // m8btn2
                // 
                this.m8btn2.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m8btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m8btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m8btn2.Location = new System.Drawing.Point(919, 8);
                this.m8btn2.Name = "m8btn2";
                this.m8btn2.Size = new System.Drawing.Size(211, 70);
                this.m8btn2.TabIndex = 21;
                this.m8btn2.Text = "button15";
                this.m8btn2.UseVisualStyleBackColor = true;
                this.m8btn2.Click += new System.EventHandler(this.m8btn2_Click);
                // 
                // m8btn13
                // 
                this.m8btn13.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m8btn13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m8btn13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m8btn13.Location = new System.Drawing.Point(1146, 166);
                this.m8btn13.Name = "m8btn13";
                this.m8btn13.Size = new System.Drawing.Size(211, 70);
                this.m8btn13.TabIndex = 20;
                this.m8btn13.Text = "button16";
                this.m8btn13.UseVisualStyleBackColor = true;
                this.m8btn13.Click += new System.EventHandler(this.m8btn13_Click);
                // 
                // m8btn7
                // 
                this.m8btn7.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m8btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m8btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m8btn7.Location = new System.Drawing.Point(1146, 87);
                this.m8btn7.Name = "m8btn7";
                this.m8btn7.Size = new System.Drawing.Size(211, 70);
                this.m8btn7.TabIndex = 19;
                this.m8btn7.Text = "button17";
                this.m8btn7.UseVisualStyleBackColor = true;
                this.m8btn7.Click += new System.EventHandler(this.m8btn7_Click);
                // 
                // m8btn1
                // 
                this.m8btn1.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m8btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m8btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m8btn1.Location = new System.Drawing.Point(1146, 7);
                this.m8btn1.Name = "m8btn1";
                this.m8btn1.Size = new System.Drawing.Size(211, 70);
                this.m8btn1.TabIndex = 18;
                this.m8btn1.Text = "button18";
                this.m8btn1.UseVisualStyleBackColor = true;
                this.m8btn1.Click += new System.EventHandler(this.m8btn1_Click);
                // 
                // m8btn16
                // 
                this.m8btn16.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m8btn16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m8btn16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m8btn16.Location = new System.Drawing.Point(468, 163);
                this.m8btn16.Name = "m8btn16";
                this.m8btn16.Size = new System.Drawing.Size(211, 70);
                this.m8btn16.TabIndex = 17;
                this.m8btn16.Text = "button7";
                this.m8btn16.UseVisualStyleBackColor = true;
                this.m8btn16.Click += new System.EventHandler(this.m8btn16_Click);
                // 
                // m8btn10
                // 
                this.m8btn10.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m8btn10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m8btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m8btn10.Location = new System.Drawing.Point(468, 87);
                this.m8btn10.Name = "m8btn10";
                this.m8btn10.Size = new System.Drawing.Size(211, 70);
                this.m8btn10.TabIndex = 16;
                this.m8btn10.Text = "button8";
                this.m8btn10.UseVisualStyleBackColor = true;
                this.m8btn10.Click += new System.EventHandler(this.m8btn10_Click);
                // 
                // m8btn4
                // 
                this.m8btn4.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m8btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m8btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m8btn4.Location = new System.Drawing.Point(468, 7);
                this.m8btn4.Name = "m8btn4";
                this.m8btn4.Size = new System.Drawing.Size(211, 70);
                this.m8btn4.TabIndex = 15;
                this.m8btn4.Text = "button9";
                this.m8btn4.UseVisualStyleBackColor = true;
                this.m8btn4.Click += new System.EventHandler(this.m8btn4_Click);
                // 
                // m8btn15
                // 
                this.m8btn15.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m8btn15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m8btn15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m8btn15.Location = new System.Drawing.Point(695, 165);
                this.m8btn15.Name = "m8btn15";
                this.m8btn15.Size = new System.Drawing.Size(211, 70);
                this.m8btn15.TabIndex = 14;
                this.m8btn15.Text = "button10";
                this.m8btn15.UseVisualStyleBackColor = true;
                this.m8btn15.Click += new System.EventHandler(this.m8btn15_Click);
                // 
                // m8btn9
                // 
                this.m8btn9.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m8btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m8btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m8btn9.Location = new System.Drawing.Point(695, 86);
                this.m8btn9.Name = "m8btn9";
                this.m8btn9.Size = new System.Drawing.Size(211, 70);
                this.m8btn9.TabIndex = 13;
                this.m8btn9.Text = "button11";
                this.m8btn9.UseVisualStyleBackColor = true;
                this.m8btn9.Click += new System.EventHandler(this.m8btn9_Click);
                // 
                // m8btn3
                // 
                this.m8btn3.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m8btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m8btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m8btn3.Location = new System.Drawing.Point(695, 7);
                this.m8btn3.Name = "m8btn3";
                this.m8btn3.Size = new System.Drawing.Size(211, 70);
                this.m8btn3.TabIndex = 12;
                this.m8btn3.Text = "button12";
                this.m8btn3.UseVisualStyleBackColor = true;
                this.m8btn3.Click += new System.EventHandler(this.m8btn3_Click);
                // 
                // m8btn18
                // 
                this.m8btn18.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m8btn18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m8btn18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m8btn18.Location = new System.Drawing.Point(17, 163);
                this.m8btn18.Name = "m8btn18";
                this.m8btn18.Size = new System.Drawing.Size(211, 70);
                this.m8btn18.TabIndex = 11;
                this.m8btn18.Text = "button3";
                this.m8btn18.UseVisualStyleBackColor = true;
                this.m8btn18.Click += new System.EventHandler(this.m8btn18_Click);
                // 
                // m8btn12
                // 
                this.m8btn12.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m8btn12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m8btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m8btn12.Location = new System.Drawing.Point(17, 85);
                this.m8btn12.Name = "m8btn12";
                this.m8btn12.Size = new System.Drawing.Size(211, 70);
                this.m8btn12.TabIndex = 10;
                this.m8btn12.Text = "button2";
                this.m8btn12.UseVisualStyleBackColor = true;
                this.m8btn12.Click += new System.EventHandler(this.m8btn12_Click);
                // 
                // m8btn6
                // 
                this.m8btn6.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m8btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m8btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m8btn6.Location = new System.Drawing.Point(17, 5);
                this.m8btn6.Name = "m8btn6";
                this.m8btn6.Size = new System.Drawing.Size(211, 70);
                this.m8btn6.TabIndex = 9;
                this.m8btn6.Text = "button1";
                this.m8btn6.UseVisualStyleBackColor = true;
                this.m8btn6.Click += new System.EventHandler(this.m8btn6_Click);
                // 
                // m8btn17
                // 
                this.m8btn17.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m8btn17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m8btn17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m8btn17.Location = new System.Drawing.Point(244, 163);
                this.m8btn17.Name = "m8btn17";
                this.m8btn17.Size = new System.Drawing.Size(211, 70);
                this.m8btn17.TabIndex = 8;
                this.m8btn17.Text = "button6";
                this.m8btn17.UseVisualStyleBackColor = true;
                this.m8btn17.Click += new System.EventHandler(this.m8btn17_Click);
                // 
                // m8btn11
                // 
                this.m8btn11.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m8btn11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m8btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m8btn11.Location = new System.Drawing.Point(244, 85);
                this.m8btn11.Name = "m8btn11";
                this.m8btn11.Size = new System.Drawing.Size(211, 70);
                this.m8btn11.TabIndex = 7;
                this.m8btn11.Text = "button5";
                this.m8btn11.UseVisualStyleBackColor = true;
                this.m8btn11.Click += new System.EventHandler(this.m8btn11_Click);
                // 
                // m8btn5
                // 
                this.m8btn5.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m8btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m8btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m8btn5.Location = new System.Drawing.Point(244, 5);
                this.m8btn5.Name = "m8btn5";
                this.m8btn5.Size = new System.Drawing.Size(211, 70);
                this.m8btn5.TabIndex = 6;
                this.m8btn5.Text = "button4";
                this.m8btn5.UseVisualStyleBackColor = true;
                this.m8btn5.Click += new System.EventHandler(this.m8btn5_Click);
                // 
                // panel11
                // 
                this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.panel11.Controls.Add(this.m9btn14);
                this.panel11.Controls.Add(this.m9btn8);
                this.panel11.Controls.Add(this.m9btn2);
                this.panel11.Controls.Add(this.m9btn13);
                this.panel11.Controls.Add(this.m9btn7);
                this.panel11.Controls.Add(this.m9btn1);
                this.panel11.Controls.Add(this.m9btn16);
                this.panel11.Controls.Add(this.m9btn10);
                this.panel11.Controls.Add(this.m9btn4);
                this.panel11.Controls.Add(this.m9btn15);
                this.panel11.Controls.Add(this.m9btn9);
                this.panel11.Controls.Add(this.m9btn3);
                this.panel11.Controls.Add(this.m9btn18);
                this.panel11.Controls.Add(this.m9btn12);
                this.panel11.Controls.Add(this.m9btn6);
                this.panel11.Controls.Add(this.m9btn17);
                this.panel11.Controls.Add(this.m9btn11);
                this.panel11.Controls.Add(this.m9btn5);
                this.panel11.Location = new System.Drawing.Point(0, 80);
                this.panel11.Name = "panel11";
                this.panel11.Size = new System.Drawing.Size(1377, 246);
                this.panel11.TabIndex = 35;
                this.panel11.Visible = false;
                // 
                // m9btn14
                // 
                this.m9btn14.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m9btn14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m9btn14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m9btn14.Location = new System.Drawing.Point(919, 166);
                this.m9btn14.Name = "m9btn14";
                this.m9btn14.Size = new System.Drawing.Size(211, 70);
                this.m9btn14.TabIndex = 23;
                this.m9btn14.Text = "button13";
                this.m9btn14.UseVisualStyleBackColor = true;
                this.m9btn14.Click += new System.EventHandler(this.m9btn14_Click);
                // 
                // m9btn8
                // 
                this.m9btn8.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m9btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m9btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m9btn8.Location = new System.Drawing.Point(919, 87);
                this.m9btn8.Name = "m9btn8";
                this.m9btn8.Size = new System.Drawing.Size(211, 70);
                this.m9btn8.TabIndex = 22;
                this.m9btn8.Text = "button14";
                this.m9btn8.UseVisualStyleBackColor = true;
                this.m9btn8.Click += new System.EventHandler(this.m9btn8_Click);
                // 
                // m9btn2
                // 
                this.m9btn2.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m9btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m9btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m9btn2.Location = new System.Drawing.Point(919, 8);
                this.m9btn2.Name = "m9btn2";
                this.m9btn2.Size = new System.Drawing.Size(211, 70);
                this.m9btn2.TabIndex = 21;
                this.m9btn2.Text = "button15";
                this.m9btn2.UseVisualStyleBackColor = true;
                this.m9btn2.Click += new System.EventHandler(this.m9btn2_Click);
                // 
                // m9btn13
                // 
                this.m9btn13.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m9btn13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m9btn13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m9btn13.Location = new System.Drawing.Point(1146, 166);
                this.m9btn13.Name = "m9btn13";
                this.m9btn13.Size = new System.Drawing.Size(211, 70);
                this.m9btn13.TabIndex = 20;
                this.m9btn13.Text = "button16";
                this.m9btn13.UseVisualStyleBackColor = true;
                this.m9btn13.Click += new System.EventHandler(this.m9btn13_Click);
                // 
                // m9btn7
                // 
                this.m9btn7.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m9btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m9btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m9btn7.Location = new System.Drawing.Point(1146, 87);
                this.m9btn7.Name = "m9btn7";
                this.m9btn7.Size = new System.Drawing.Size(211, 70);
                this.m9btn7.TabIndex = 19;
                this.m9btn7.Text = "button17";
                this.m9btn7.UseVisualStyleBackColor = true;
                this.m9btn7.Click += new System.EventHandler(this.m9btn7_Click);
                // 
                // m9btn1
                // 
                this.m9btn1.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m9btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m9btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m9btn1.Location = new System.Drawing.Point(1146, 7);
                this.m9btn1.Name = "m9btn1";
                this.m9btn1.Size = new System.Drawing.Size(211, 70);
                this.m9btn1.TabIndex = 18;
                this.m9btn1.Text = "button18";
                this.m9btn1.UseVisualStyleBackColor = true;
                this.m9btn1.Click += new System.EventHandler(this.m9btn1_Click);
                // 
                // m9btn16
                // 
                this.m9btn16.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m9btn16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m9btn16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m9btn16.Location = new System.Drawing.Point(468, 163);
                this.m9btn16.Name = "m9btn16";
                this.m9btn16.Size = new System.Drawing.Size(211, 70);
                this.m9btn16.TabIndex = 17;
                this.m9btn16.Text = "button7";
                this.m9btn16.UseVisualStyleBackColor = true;
                this.m9btn16.Click += new System.EventHandler(this.m9btn16_Click);
                // 
                // m9btn10
                // 
                this.m9btn10.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m9btn10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m9btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m9btn10.Location = new System.Drawing.Point(468, 87);
                this.m9btn10.Name = "m9btn10";
                this.m9btn10.Size = new System.Drawing.Size(211, 70);
                this.m9btn10.TabIndex = 16;
                this.m9btn10.Text = "button8";
                this.m9btn10.UseVisualStyleBackColor = true;
                this.m9btn10.Click += new System.EventHandler(this.m9btn10_Click);
                // 
                // m9btn4
                // 
                this.m9btn4.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m9btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m9btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m9btn4.Location = new System.Drawing.Point(468, 7);
                this.m9btn4.Name = "m9btn4";
                this.m9btn4.Size = new System.Drawing.Size(211, 70);
                this.m9btn4.TabIndex = 15;
                this.m9btn4.Text = "button9";
                this.m9btn4.UseVisualStyleBackColor = true;
                this.m9btn4.Click += new System.EventHandler(this.m9btn4_Click);
                // 
                // m9btn15
                // 
                this.m9btn15.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m9btn15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m9btn15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m9btn15.Location = new System.Drawing.Point(695, 165);
                this.m9btn15.Name = "m9btn15";
                this.m9btn15.Size = new System.Drawing.Size(211, 70);
                this.m9btn15.TabIndex = 14;
                this.m9btn15.Text = "button10";
                this.m9btn15.UseVisualStyleBackColor = true;
                this.m9btn15.Click += new System.EventHandler(this.m9btn15_Click);
                // 
                // m9btn9
                // 
                this.m9btn9.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m9btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m9btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m9btn9.Location = new System.Drawing.Point(695, 86);
                this.m9btn9.Name = "m9btn9";
                this.m9btn9.Size = new System.Drawing.Size(211, 70);
                this.m9btn9.TabIndex = 13;
                this.m9btn9.Text = "button11";
                this.m9btn9.UseVisualStyleBackColor = true;
                this.m9btn9.Click += new System.EventHandler(this.m9btn9_Click);
                // 
                // m9btn3
                // 
                this.m9btn3.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m9btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m9btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m9btn3.Location = new System.Drawing.Point(695, 7);
                this.m9btn3.Name = "m9btn3";
                this.m9btn3.Size = new System.Drawing.Size(211, 70);
                this.m9btn3.TabIndex = 12;
                this.m9btn3.Text = "button12";
                this.m9btn3.UseVisualStyleBackColor = true;
                this.m9btn3.Click += new System.EventHandler(this.m9btn3_Click);
                // 
                // m9btn18
                // 
                this.m9btn18.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m9btn18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m9btn18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m9btn18.Location = new System.Drawing.Point(17, 163);
                this.m9btn18.Name = "m9btn18";
                this.m9btn18.Size = new System.Drawing.Size(211, 70);
                this.m9btn18.TabIndex = 11;
                this.m9btn18.Text = "button3";
                this.m9btn18.UseVisualStyleBackColor = true;
                this.m9btn18.Click += new System.EventHandler(this.m9btn18_Click);
                // 
                // m9btn12
                // 
                this.m9btn12.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m9btn12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m9btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m9btn12.Location = new System.Drawing.Point(17, 85);
                this.m9btn12.Name = "m9btn12";
                this.m9btn12.Size = new System.Drawing.Size(211, 70);
                this.m9btn12.TabIndex = 10;
                this.m9btn12.Text = "button2";
                this.m9btn12.UseVisualStyleBackColor = true;
                this.m9btn12.Click += new System.EventHandler(this.m9btn12_Click);
                // 
                // m9btn6
                // 
                this.m9btn6.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m9btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m9btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m9btn6.Location = new System.Drawing.Point(17, 5);
                this.m9btn6.Name = "m9btn6";
                this.m9btn6.Size = new System.Drawing.Size(211, 70);
                this.m9btn6.TabIndex = 9;
                this.m9btn6.Text = "button1";
                this.m9btn6.UseVisualStyleBackColor = true;
                this.m9btn6.Click += new System.EventHandler(this.m9btn6_Click);
                // 
                // m9btn17
                // 
                this.m9btn17.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m9btn17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m9btn17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m9btn17.Location = new System.Drawing.Point(244, 163);
                this.m9btn17.Name = "m9btn17";
                this.m9btn17.Size = new System.Drawing.Size(211, 70);
                this.m9btn17.TabIndex = 8;
                this.m9btn17.Text = "button6";
                this.m9btn17.UseVisualStyleBackColor = true;
                this.m9btn17.Click += new System.EventHandler(this.m9btn17_Click);
                // 
                // m9btn11
                // 
                this.m9btn11.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m9btn11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m9btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m9btn11.Location = new System.Drawing.Point(244, 85);
                this.m9btn11.Name = "m9btn11";
                this.m9btn11.Size = new System.Drawing.Size(211, 70);
                this.m9btn11.TabIndex = 7;
                this.m9btn11.Text = "button5";
                this.m9btn11.UseVisualStyleBackColor = true;
                this.m9btn11.Click += new System.EventHandler(this.m9btn11_Click);
                // 
                // m9btn5
                // 
                this.m9btn5.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m9btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m9btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m9btn5.Location = new System.Drawing.Point(244, 5);
                this.m9btn5.Name = "m9btn5";
                this.m9btn5.Size = new System.Drawing.Size(211, 70);
                this.m9btn5.TabIndex = 6;
                this.m9btn5.Text = "button4";
                this.m9btn5.UseVisualStyleBackColor = true;
                this.m9btn5.Click += new System.EventHandler(this.m9btn5_Click);
                // 
                // panel12
                // 
                this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.panel12.Controls.Add(this.m10btn14);
                this.panel12.Controls.Add(this.m10btn8);
                this.panel12.Controls.Add(this.m10btn2);
                this.panel12.Controls.Add(this.m10btn13);
                this.panel12.Controls.Add(this.m10btn7);
                this.panel12.Controls.Add(this.m10btn1);
                this.panel12.Controls.Add(this.m10btn16);
                this.panel12.Controls.Add(this.m10btn10);
                this.panel12.Controls.Add(this.m10btn4);
                this.panel12.Controls.Add(this.m10btn15);
                this.panel12.Controls.Add(this.m10btn9);
                this.panel12.Controls.Add(this.m10btn3);
                this.panel12.Controls.Add(this.m10btn18);
                this.panel12.Controls.Add(this.m10btn12);
                this.panel12.Controls.Add(this.m10btn6);
                this.panel12.Controls.Add(this.m10btn17);
                this.panel12.Controls.Add(this.m10btn11);
                this.panel12.Controls.Add(this.m10btn5);
                this.panel12.Location = new System.Drawing.Point(0, 80);
                this.panel12.Name = "panel12";
                this.panel12.Size = new System.Drawing.Size(1377, 246);
                this.panel12.TabIndex = 36;
                this.panel12.Visible = false;
                // 
                // m10btn14
                // 
                this.m10btn14.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m10btn14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m10btn14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m10btn14.Location = new System.Drawing.Point(919, 166);
                this.m10btn14.Name = "m10btn14";
                this.m10btn14.Size = new System.Drawing.Size(211, 70);
                this.m10btn14.TabIndex = 23;
                this.m10btn14.Text = "button13";
                this.m10btn14.UseVisualStyleBackColor = true;
                this.m10btn14.Click += new System.EventHandler(this.m10btn14_Click);
                // 
                // m10btn8
                // 
                this.m10btn8.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m10btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m10btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m10btn8.Location = new System.Drawing.Point(919, 87);
                this.m10btn8.Name = "m10btn8";
                this.m10btn8.Size = new System.Drawing.Size(211, 70);
                this.m10btn8.TabIndex = 22;
                this.m10btn8.Text = "button14";
                this.m10btn8.UseVisualStyleBackColor = true;
                this.m10btn8.Click += new System.EventHandler(this.m10btn8_Click);
                // 
                // m10btn2
                // 
                this.m10btn2.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m10btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m10btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m10btn2.Location = new System.Drawing.Point(919, 8);
                this.m10btn2.Name = "m10btn2";
                this.m10btn2.Size = new System.Drawing.Size(211, 70);
                this.m10btn2.TabIndex = 21;
                this.m10btn2.Text = "button15";
                this.m10btn2.UseVisualStyleBackColor = true;
                this.m10btn2.Click += new System.EventHandler(this.m10btn2_Click);
                // 
                // m10btn13
                // 
                this.m10btn13.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m10btn13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m10btn13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m10btn13.Location = new System.Drawing.Point(1146, 166);
                this.m10btn13.Name = "m10btn13";
                this.m10btn13.Size = new System.Drawing.Size(211, 70);
                this.m10btn13.TabIndex = 20;
                this.m10btn13.Text = "button16";
                this.m10btn13.UseVisualStyleBackColor = true;
                this.m10btn13.Click += new System.EventHandler(this.m10btn13_Click);
                // 
                // m10btn7
                // 
                this.m10btn7.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m10btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m10btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m10btn7.Location = new System.Drawing.Point(1146, 87);
                this.m10btn7.Name = "m10btn7";
                this.m10btn7.Size = new System.Drawing.Size(211, 70);
                this.m10btn7.TabIndex = 19;
                this.m10btn7.Text = "button17";
                this.m10btn7.UseVisualStyleBackColor = true;
                this.m10btn7.Click += new System.EventHandler(this.m10btn7_Click);
                // 
                // m10btn1
                // 
                this.m10btn1.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m10btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m10btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m10btn1.Location = new System.Drawing.Point(1146, 7);
                this.m10btn1.Name = "m10btn1";
                this.m10btn1.Size = new System.Drawing.Size(211, 70);
                this.m10btn1.TabIndex = 18;
                this.m10btn1.Text = "button18";
                this.m10btn1.UseVisualStyleBackColor = true;
                this.m10btn1.Click += new System.EventHandler(this.m10btn1_Click);
                // 
                // m10btn16
                // 
                this.m10btn16.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m10btn16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m10btn16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m10btn16.Location = new System.Drawing.Point(468, 163);
                this.m10btn16.Name = "m10btn16";
                this.m10btn16.Size = new System.Drawing.Size(211, 70);
                this.m10btn16.TabIndex = 17;
                this.m10btn16.Text = "button7";
                this.m10btn16.UseVisualStyleBackColor = true;
                this.m10btn16.Click += new System.EventHandler(this.m10btn16_Click);
                // 
                // m10btn10
                // 
                this.m10btn10.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m10btn10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m10btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m10btn10.Location = new System.Drawing.Point(468, 87);
                this.m10btn10.Name = "m10btn10";
                this.m10btn10.Size = new System.Drawing.Size(211, 70);
                this.m10btn10.TabIndex = 16;
                this.m10btn10.Text = "button8";
                this.m10btn10.UseVisualStyleBackColor = true;
                this.m10btn10.Click += new System.EventHandler(this.m10btn10_Click);
                // 
                // m10btn4
                // 
                this.m10btn4.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m10btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m10btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m10btn4.Location = new System.Drawing.Point(468, 7);
                this.m10btn4.Name = "m10btn4";
                this.m10btn4.Size = new System.Drawing.Size(211, 70);
                this.m10btn4.TabIndex = 15;
                this.m10btn4.Text = "button9";
                this.m10btn4.UseVisualStyleBackColor = true;
                this.m10btn4.Click += new System.EventHandler(this.m10btn4_Click);
                // 
                // m10btn15
                // 
                this.m10btn15.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m10btn15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m10btn15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m10btn15.Location = new System.Drawing.Point(695, 165);
                this.m10btn15.Name = "m10btn15";
                this.m10btn15.Size = new System.Drawing.Size(211, 70);
                this.m10btn15.TabIndex = 14;
                this.m10btn15.Text = "button10";
                this.m10btn15.UseVisualStyleBackColor = true;
                this.m10btn15.Click += new System.EventHandler(this.m10btn15_Click);
                // 
                // m10btn9
                // 
                this.m10btn9.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m10btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m10btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m10btn9.Location = new System.Drawing.Point(695, 86);
                this.m10btn9.Name = "m10btn9";
                this.m10btn9.Size = new System.Drawing.Size(211, 70);
                this.m10btn9.TabIndex = 13;
                this.m10btn9.Text = "button11";
                this.m10btn9.UseVisualStyleBackColor = true;
                this.m10btn9.Click += new System.EventHandler(this.m10btn9_Click);
                // 
                // m10btn3
                // 
                this.m10btn3.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m10btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m10btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m10btn3.Location = new System.Drawing.Point(695, 7);
                this.m10btn3.Name = "m10btn3";
                this.m10btn3.Size = new System.Drawing.Size(211, 70);
                this.m10btn3.TabIndex = 12;
                this.m10btn3.Text = "button12";
                this.m10btn3.UseVisualStyleBackColor = true;
                this.m10btn3.Click += new System.EventHandler(this.m10btn3_Click);
                // 
                // m10btn18
                // 
                this.m10btn18.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m10btn18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m10btn18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m10btn18.Location = new System.Drawing.Point(17, 163);
                this.m10btn18.Name = "m10btn18";
                this.m10btn18.Size = new System.Drawing.Size(211, 70);
                this.m10btn18.TabIndex = 11;
                this.m10btn18.Text = "button3";
                this.m10btn18.UseVisualStyleBackColor = true;
                this.m10btn18.Click += new System.EventHandler(this.m10btn18_Click);
                // 
                // m10btn12
                // 
                this.m10btn12.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m10btn12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m10btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m10btn12.Location = new System.Drawing.Point(17, 85);
                this.m10btn12.Name = "m10btn12";
                this.m10btn12.Size = new System.Drawing.Size(211, 70);
                this.m10btn12.TabIndex = 10;
                this.m10btn12.Text = "button2";
                this.m10btn12.UseVisualStyleBackColor = true;
                this.m10btn12.Click += new System.EventHandler(this.m10btn12_Click);
                // 
                // m10btn6
                // 
                this.m10btn6.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m10btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m10btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m10btn6.Location = new System.Drawing.Point(17, 5);
                this.m10btn6.Name = "m10btn6";
                this.m10btn6.Size = new System.Drawing.Size(211, 70);
                this.m10btn6.TabIndex = 9;
                this.m10btn6.Text = "button1";
                this.m10btn6.UseVisualStyleBackColor = true;
                this.m10btn6.Click += new System.EventHandler(this.m10btn6_Click);
                // 
                // m10btn17
                // 
                this.m10btn17.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m10btn17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m10btn17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m10btn17.Location = new System.Drawing.Point(244, 163);
                this.m10btn17.Name = "m10btn17";
                this.m10btn17.Size = new System.Drawing.Size(211, 70);
                this.m10btn17.TabIndex = 8;
                this.m10btn17.Text = "button6";
                this.m10btn17.UseVisualStyleBackColor = true;
                this.m10btn17.Click += new System.EventHandler(this.m10btn17_Click);
                // 
                // m10btn11
                // 
                this.m10btn11.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m10btn11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m10btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m10btn11.Location = new System.Drawing.Point(244, 85);
                this.m10btn11.Name = "m10btn11";
                this.m10btn11.Size = new System.Drawing.Size(211, 70);
                this.m10btn11.TabIndex = 7;
                this.m10btn11.Text = "button5";
                this.m10btn11.UseVisualStyleBackColor = true;
                this.m10btn11.Click += new System.EventHandler(this.m10btn11_Click);
                // 
                // m10btn5
                // 
                this.m10btn5.Cursor = System.Windows.Forms.Cursors.Hand;
                this.m10btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.m10btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.m10btn5.Location = new System.Drawing.Point(244, 5);
                this.m10btn5.Name = "m10btn5";
                this.m10btn5.Size = new System.Drawing.Size(211, 70);
                this.m10btn5.TabIndex = 6;
                this.m10btn5.Text = "button4";
                this.m10btn5.UseVisualStyleBackColor = true;
                this.m10btn5.Click += new System.EventHandler(this.m10btn5_Click);
                // 
                // button5
                // 
                this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button5.ForeColor = System.Drawing.Color.White;
                this.button5.Location = new System.Drawing.Point(376, 612);
                this.button5.Name = "button5";
                this.button5.Size = new System.Drawing.Size(124, 75);
                this.button5.TabIndex = 38;
                this.button5.Text = "وصل جديد";
                this.button5.UseVisualStyleBackColor = false;
                this.button5.Click += new System.EventHandler(this.button5_Click);
                // 
                // timer1
                // 
                this.timer1.Interval = 1000;
                this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
                // 
                // panel13
                // 
                this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.panel13.Controls.Add(this.button12);
                this.panel13.Controls.Add(this.button13);
                this.panel13.Controls.Add(this.button14);
                this.panel13.Controls.Add(this.button9);
                this.panel13.Controls.Add(this.button10);
                this.panel13.Controls.Add(this.button11);
                this.panel13.Controls.Add(this.button8);
                this.panel13.Controls.Add(this.button7);
                this.panel13.Controls.Add(this.label23);
                this.panel13.Controls.Add(this.textBox5);
                this.panel13.Controls.Add(this.button6);
                this.panel13.Controls.Add(this.label22);
                this.panel13.Location = new System.Drawing.Point(526, 344);
                this.panel13.Name = "panel13";
                this.panel13.Size = new System.Drawing.Size(298, 332);
                this.panel13.TabIndex = 39;
                // 
                // button12
                // 
                this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button12.ForeColor = System.Drawing.Color.White;
                this.button12.Location = new System.Drawing.Point(14, 196);
                this.button12.Name = "button12";
                this.button12.Size = new System.Drawing.Size(62, 59);
                this.button12.TabIndex = 16;
                this.button12.Text = "9";
                this.button12.UseVisualStyleBackColor = false;
                this.button12.Click += new System.EventHandler(this.button12_Click);
                // 
                // button13
                // 
                this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button13.ForeColor = System.Drawing.Color.White;
                this.button13.Location = new System.Drawing.Point(121, 197);
                this.button13.Name = "button13";
                this.button13.Size = new System.Drawing.Size(62, 59);
                this.button13.TabIndex = 15;
                this.button13.Text = "8";
                this.button13.UseVisualStyleBackColor = false;
                this.button13.Click += new System.EventHandler(this.button13_Click);
                // 
                // button14
                // 
                this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button14.ForeColor = System.Drawing.Color.White;
                this.button14.Location = new System.Drawing.Point(222, 196);
                this.button14.Name = "button14";
                this.button14.Size = new System.Drawing.Size(62, 59);
                this.button14.TabIndex = 14;
                this.button14.Text = "7";
                this.button14.UseVisualStyleBackColor = false;
                this.button14.Click += new System.EventHandler(this.button14_Click);
                // 
                // button9
                // 
                this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button9.ForeColor = System.Drawing.Color.White;
                this.button9.Location = new System.Drawing.Point(13, 119);
                this.button9.Name = "button9";
                this.button9.Size = new System.Drawing.Size(62, 59);
                this.button9.TabIndex = 13;
                this.button9.Text = "6";
                this.button9.UseVisualStyleBackColor = false;
                this.button9.Click += new System.EventHandler(this.button9_Click);
                // 
                // button10
                // 
                this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button10.ForeColor = System.Drawing.Color.White;
                this.button10.Location = new System.Drawing.Point(121, 120);
                this.button10.Name = "button10";
                this.button10.Size = new System.Drawing.Size(62, 59);
                this.button10.TabIndex = 12;
                this.button10.Text = "5";
                this.button10.UseVisualStyleBackColor = false;
                this.button10.Click += new System.EventHandler(this.button10_Click);
                // 
                // button11
                // 
                this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button11.ForeColor = System.Drawing.Color.White;
                this.button11.Location = new System.Drawing.Point(222, 120);
                this.button11.Name = "button11";
                this.button11.Size = new System.Drawing.Size(62, 59);
                this.button11.TabIndex = 11;
                this.button11.Text = "4";
                this.button11.UseVisualStyleBackColor = false;
                this.button11.Click += new System.EventHandler(this.button11_Click);
                // 
                // button8
                // 
                this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button8.ForeColor = System.Drawing.Color.White;
                this.button8.Location = new System.Drawing.Point(13, 43);
                this.button8.Name = "button8";
                this.button8.Size = new System.Drawing.Size(62, 59);
                this.button8.TabIndex = 10;
                this.button8.Text = "3";
                this.button8.UseVisualStyleBackColor = false;
                this.button8.Click += new System.EventHandler(this.button8_Click);
                // 
                // button7
                // 
                this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button7.ForeColor = System.Drawing.Color.White;
                this.button7.Location = new System.Drawing.Point(121, 43);
                this.button7.Name = "button7";
                this.button7.Size = new System.Drawing.Size(62, 59);
                this.button7.TabIndex = 9;
                this.button7.Text = "2";
                this.button7.UseVisualStyleBackColor = false;
                this.button7.Click += new System.EventHandler(this.button7_Click);
                // 
                // label23
                // 
                this.label23.AutoSize = true;
                this.label23.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label23.Location = new System.Drawing.Point(77, 275);
                this.label23.Name = "label23";
                this.label23.Size = new System.Drawing.Size(154, 19);
                this.label23.TabIndex = 8;
                this.label23.Text = " أو أدخل عدد بالأسفل";
                // 
                // textBox5
                // 
                this.textBox5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.textBox5.Location = new System.Drawing.Point(108, 299);
                this.textBox5.Name = "textBox5";
                this.textBox5.Size = new System.Drawing.Size(93, 27);
                this.textBox5.TabIndex = 7;
                this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
                // 
                // button6
                // 
                this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button6.ForeColor = System.Drawing.Color.White;
                this.button6.Location = new System.Drawing.Point(222, 43);
                this.button6.Name = "button6";
                this.button6.Size = new System.Drawing.Size(62, 59);
                this.button6.TabIndex = 1;
                this.button6.Text = "1";
                this.button6.UseVisualStyleBackColor = false;
                this.button6.Click += new System.EventHandler(this.button6_Click);
                // 
                // label22
                // 
                this.label22.AutoSize = true;
                this.label22.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label22.Location = new System.Drawing.Point(131, 7);
                this.label22.Name = "label22";
                this.label22.Size = new System.Drawing.Size(42, 19);
                this.label22.TabIndex = 0;
                this.label22.Text = "العدد";
                // 
                // panel14
                // 
                this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.panel14.Controls.Add(this.textBox6);
                this.panel14.Controls.Add(this.button16);
                this.panel14.Controls.Add(this.button15);
                this.panel14.Location = new System.Drawing.Point(361, 394);
                this.panel14.Name = "panel14";
                this.panel14.Size = new System.Drawing.Size(156, 199);
                this.panel14.TabIndex = 40;
                // 
                // textBox6
                // 
                this.textBox6.Location = new System.Drawing.Point(27, 91);
                this.textBox6.Name = "textBox6";
                this.textBox6.ReadOnly = true;
                this.textBox6.Size = new System.Drawing.Size(96, 20);
                this.textBox6.TabIndex = 2;
                // 
                // button16
                // 
                this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button16.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button16.ForeColor = System.Drawing.Color.White;
                this.button16.Location = new System.Drawing.Point(8, 115);
                this.button16.Name = "button16";
                this.button16.Size = new System.Drawing.Size(138, 76);
                this.button16.TabIndex = 1;
                this.button16.Text = "صالة";
                this.button16.UseVisualStyleBackColor = false;
                this.button16.Click += new System.EventHandler(this.button16_Click);
                // 
                // button15
                // 
                this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button15.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button15.ForeColor = System.Drawing.Color.White;
                this.button15.Location = new System.Drawing.Point(8, 9);
                this.button15.Name = "button15";
                this.button15.Size = new System.Drawing.Size(138, 76);
                this.button15.TabIndex = 0;
                this.button15.Text = "سفري";
                this.button15.UseVisualStyleBackColor = false;
                this.button15.Click += new System.EventHandler(this.button15_Click);
                // 
                // button17
                // 
                this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(59)))));
                this.button17.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button17.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button17.ForeColor = System.Drawing.Color.OldLace;
                this.button17.Location = new System.Drawing.Point(839, 592);
                this.button17.Name = "button17";
                this.button17.Size = new System.Drawing.Size(156, 84);
                this.button17.TabIndex = 41;
                this.button17.Text = "طبع";
                this.button17.UseVisualStyleBackColor = false;
                this.button17.Click += new System.EventHandler(this.button17_Click);
                // 
                // button18
                // 
                this.button18.Location = new System.Drawing.Point(1058, 494);
                this.button18.Name = "button18";
                this.button18.Size = new System.Drawing.Size(65, 91);
                this.button18.TabIndex = 42;
                this.button18.Text = "preview";
                this.button18.UseVisualStyleBackColor = true;
                this.button18.Visible = false;
                this.button18.Click += new System.EventHandler(this.button18_Click);
                // 
                // dbpanel
                // 
                this.dbpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(237)))), ((int)(((byte)(244)))));
                this.dbpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.dbpanel.Controls.Add(this.button39);
                this.dbpanel.Controls.Add(this.panel16);
                this.dbpanel.Controls.Add(this.label34);
                this.dbpanel.Controls.Add(this.label33);
                this.dbpanel.Controls.Add(this.label32);
                this.dbpanel.Controls.Add(this.label31);
                this.dbpanel.Controls.Add(this.label29);
                this.dbpanel.Controls.Add(this.panel15);
                this.dbpanel.Controls.Add(this.label24);
                this.dbpanel.Controls.Add(this.button32);
                this.dbpanel.Controls.Add(this.dataGridView1);
                this.dbpanel.Location = new System.Drawing.Point(105, 122);
                this.dbpanel.Name = "dbpanel";
                this.dbpanel.Size = new System.Drawing.Size(1154, 429);
                this.dbpanel.TabIndex = 43;
                this.dbpanel.Visible = false;
                // 
                // button39
                // 
                this.button39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button39.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button39.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button39.ForeColor = System.Drawing.Color.White;
                this.button39.Location = new System.Drawing.Point(264, 359);
                this.button39.Name = "button39";
                this.button39.Size = new System.Drawing.Size(88, 44);
                this.button39.TabIndex = 38;
                this.button39.Text = "حذف البيانات";
                this.button39.UseVisualStyleBackColor = false;
                this.button39.Click += new System.EventHandler(this.button39_Click);
                // 
                // panel16
                // 
                this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.panel16.Controls.Add(this.label35);
                this.panel16.Controls.Add(this.button38);
                this.panel16.Controls.Add(this.txtTotalSum);
                this.panel16.Cursor = System.Windows.Forms.Cursors.Default;
                this.panel16.Location = new System.Drawing.Point(529, 63);
                this.panel16.Name = "panel16";
                this.panel16.Size = new System.Drawing.Size(548, 137);
                this.panel16.TabIndex = 37;
                // 
                // label35
                // 
                this.label35.AutoSize = true;
                this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label35.Location = new System.Drawing.Point(295, 74);
                this.label35.Name = "label35";
                this.label35.Size = new System.Drawing.Size(185, 24);
                this.label35.TabIndex = 36;
                this.label35.Text = "إجمالي المبيعات حسب الفرز ";
                this.label35.Visible = false;
                // 
                // button38
                // 
                this.button38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button38.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button38.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button38.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button38.ForeColor = System.Drawing.Color.White;
                this.button38.Location = new System.Drawing.Point(411, 11);
                this.button38.Name = "button38";
                this.button38.Size = new System.Drawing.Size(126, 46);
                this.button38.TabIndex = 35;
                this.button38.Text = "اظهار المبيعات";
                this.button38.UseVisualStyleBackColor = false;
                this.button38.Click += new System.EventHandler(this.button38_Click);
                // 
                // txtTotalSum
                // 
                this.txtTotalSum.Location = new System.Drawing.Point(41, 77);
                this.txtTotalSum.Name = "txtTotalSum";
                this.txtTotalSum.Size = new System.Drawing.Size(248, 20);
                this.txtTotalSum.TabIndex = 34;
                this.txtTotalSum.Visible = false;
                // 
                // label34
                // 
                this.label34.AutoSize = true;
                this.label34.Location = new System.Drawing.Point(137, 28);
                this.label34.Name = "label34";
                this.label34.Size = new System.Drawing.Size(15, 13);
                this.label34.TabIndex = 33;
                this.label34.Text = "ت";
                // 
                // label33
                // 
                this.label33.AutoSize = true;
                this.label33.Location = new System.Drawing.Point(420, 28);
                this.label33.Name = "label33";
                this.label33.Size = new System.Drawing.Size(42, 13);
                this.label33.TabIndex = 32;
                this.label33.Text = "الكاشير";
                // 
                // label32
                // 
                this.label32.AutoSize = true;
                this.label32.Location = new System.Drawing.Point(322, 27);
                this.label32.Name = "label32";
                this.label32.Size = new System.Drawing.Size(32, 13);
                this.label32.TabIndex = 31;
                this.label32.Text = "المبلغ";
                // 
                // label31
                // 
                this.label31.AutoSize = true;
                this.label31.Location = new System.Drawing.Point(225, 27);
                this.label31.Name = "label31";
                this.label31.Size = new System.Drawing.Size(38, 13);
                this.label31.TabIndex = 30;
                this.label31.Text = "التاريخ";
                // 
                // label29
                // 
                this.label29.AutoSize = true;
                this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label29.Location = new System.Drawing.Point(1010, 366);
                this.label29.Name = "label29";
                this.label29.Size = new System.Drawing.Size(73, 20);
                this.label29.TabIndex = 28;
                this.label29.Text = " : فرز حسب";
                // 
                // panel15
                // 
                this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.panel15.Controls.Add(this.textBox10);
                this.panel15.Controls.Add(this.label30);
                this.panel15.Controls.Add(this.label28);
                this.panel15.Controls.Add(this.txtYearFilter);
                this.panel15.Controls.Add(this.label18);
                this.panel15.Controls.Add(this.comboBox3);
                this.panel15.Location = new System.Drawing.Point(383, 343);
                this.panel15.Name = "panel15";
                this.panel15.Size = new System.Drawing.Size(611, 67);
                this.panel15.TabIndex = 29;
                // 
                // textBox10
                // 
                this.textBox10.Cursor = System.Windows.Forms.Cursors.IBeam;
                this.textBox10.Location = new System.Drawing.Point(6, 24);
                this.textBox10.Name = "textBox10";
                this.textBox10.Size = new System.Drawing.Size(100, 20);
                this.textBox10.TabIndex = 0;
                // 
                // label30
                // 
                this.label30.AutoSize = true;
                this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label30.Location = new System.Drawing.Point(107, 23);
                this.label30.Name = "label30";
                this.label30.Size = new System.Drawing.Size(77, 20);
                this.label30.TabIndex = 29;
                this.label30.Text = ": اسم الكاشير";
                // 
                // label28
                // 
                this.label28.AutoSize = true;
                this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label28.Location = new System.Drawing.Point(537, 24);
                this.label28.Name = "label28";
                this.label28.Size = new System.Drawing.Size(61, 20);
                this.label28.TabIndex = 27;
                this.label28.Text = ": حدد العام";
                // 
                // txtYearFilter
                // 
                this.txtYearFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
                this.txtYearFilter.Location = new System.Drawing.Point(434, 25);
                this.txtYearFilter.Name = "txtYearFilter";
                this.txtYearFilter.Size = new System.Drawing.Size(100, 20);
                this.txtYearFilter.TabIndex = 26;
                // 
                // label18
                // 
                this.label18.AutoSize = true;
                this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label18.Location = new System.Drawing.Point(334, 22);
                this.label18.Name = "label18";
                this.label18.Size = new System.Drawing.Size(69, 20);
                this.label18.TabIndex = 24;
                this.label18.Text = ": حدد الشهر";
                // 
                // comboBox3
                // 
                this.comboBox3.Cursor = System.Windows.Forms.Cursors.Hand;
                this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.comboBox3.FormattingEnabled = true;
                this.comboBox3.Location = new System.Drawing.Point(212, 23);
                this.comboBox3.Name = "comboBox3";
                this.comboBox3.Size = new System.Drawing.Size(121, 21);
                this.comboBox3.TabIndex = 23;
                // 
                // label24
                // 
                this.label24.AutoSize = true;
                this.label24.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label24.Location = new System.Drawing.Point(555, 11);
                this.label24.Name = "label24";
                this.label24.Size = new System.Drawing.Size(72, 25);
                this.label24.TabIndex = 22;
                this.label24.Text = "البيانات";
                // 
                // button32
                // 
                this.button32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button32.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button32.ForeColor = System.Drawing.Color.White;
                this.button32.Location = new System.Drawing.Point(20, 362);
                this.button32.Name = "button32";
                this.button32.Size = new System.Drawing.Size(88, 44);
                this.button32.TabIndex = 1;
                this.button32.Text = "رجوع";
                this.button32.UseVisualStyleBackColor = false;
                this.button32.Click += new System.EventHandler(this.button32_Click);
                // 
                // dataGridView1
                // 
                this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.dataGridView1.Location = new System.Drawing.Point(56, 46);
                this.dataGridView1.Name = "dataGridView1";
                this.dataGridView1.Size = new System.Drawing.Size(1040, 291);
                this.dataGridView1.TabIndex = 0;
                // 
                // passpanel
                // 
                this.passpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.passpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.passpanel.Controls.Add(this.button34);
                this.passpanel.Controls.Add(this.label25);
                this.passpanel.Controls.Add(this.button33);
                this.passpanel.Controls.Add(this.textBox7);
                this.passpanel.Location = new System.Drawing.Point(543, 260);
                this.passpanel.Name = "passpanel";
                this.passpanel.Size = new System.Drawing.Size(288, 187);
                this.passpanel.TabIndex = 44;
                this.passpanel.Visible = false;
                // 
                // button34
                // 
                this.button34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button34.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button34.ForeColor = System.Drawing.Color.White;
                this.button34.Location = new System.Drawing.Point(34, 124);
                this.button34.Name = "button34";
                this.button34.Size = new System.Drawing.Size(87, 39);
                this.button34.TabIndex = 3;
                this.button34.Text = "رجوع";
                this.button34.UseVisualStyleBackColor = false;
                this.button34.Click += new System.EventHandler(this.button34_Click);
                // 
                // label25
                // 
                this.label25.AutoSize = true;
                this.label25.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label25.Location = new System.Drawing.Point(124, 17);
                this.label25.Name = "label25";
                this.label25.Size = new System.Drawing.Size(40, 19);
                this.label25.TabIndex = 2;
                this.label25.Text = "الرمز";
                // 
                // button33
                // 
                this.button33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button33.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button33.ForeColor = System.Drawing.Color.White;
                this.button33.Location = new System.Drawing.Point(178, 124);
                this.button33.Name = "button33";
                this.button33.Size = new System.Drawing.Size(87, 39);
                this.button33.TabIndex = 1;
                this.button33.Text = "ادخال";
                this.button33.UseVisualStyleBackColor = false;
                this.button33.Click += new System.EventHandler(this.button33_Click);
                // 
                // textBox7
                // 
                this.textBox7.Location = new System.Drawing.Point(94, 72);
                this.textBox7.Name = "textBox7";
                this.textBox7.PasswordChar = '*';
                this.textBox7.Size = new System.Drawing.Size(100, 20);
                this.textBox7.TabIndex = 0;
                // 
                // pwchangepanel
                // 
                this.pwchangepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.pwchangepanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.pwchangepanel.Controls.Add(this.button37);
                this.pwchangepanel.Controls.Add(this.button36);
                this.pwchangepanel.Controls.Add(this.textBox9);
                this.pwchangepanel.Controls.Add(this.textBox8);
                this.pwchangepanel.Controls.Add(this.label27);
                this.pwchangepanel.Controls.Add(this.label26);
                this.pwchangepanel.Location = new System.Drawing.Point(557, 235);
                this.pwchangepanel.Name = "pwchangepanel";
                this.pwchangepanel.Size = new System.Drawing.Size(298, 211);
                this.pwchangepanel.TabIndex = 45;
                this.pwchangepanel.Visible = false;
                // 
                // button37
                // 
                this.button37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button37.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button37.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button37.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button37.ForeColor = System.Drawing.Color.White;
                this.button37.Location = new System.Drawing.Point(193, 157);
                this.button37.Name = "button37";
                this.button37.Size = new System.Drawing.Size(88, 36);
                this.button37.TabIndex = 5;
                this.button37.Text = "تغيير";
                this.button37.UseVisualStyleBackColor = false;
                this.button37.Click += new System.EventHandler(this.button37_Click);
                // 
                // button36
                // 
                this.button36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button36.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button36.ForeColor = System.Drawing.Color.White;
                this.button36.Location = new System.Drawing.Point(21, 157);
                this.button36.Name = "button36";
                this.button36.Size = new System.Drawing.Size(88, 36);
                this.button36.TabIndex = 4;
                this.button36.Text = "رجوع";
                this.button36.UseVisualStyleBackColor = false;
                this.button36.Click += new System.EventHandler(this.button36_Click);
                // 
                // textBox9
                // 
                this.textBox9.Location = new System.Drawing.Point(37, 97);
                this.textBox9.Name = "textBox9";
                this.textBox9.PasswordChar = '*';
                this.textBox9.Size = new System.Drawing.Size(100, 20);
                this.textBox9.TabIndex = 3;
                // 
                // textBox8
                // 
                this.textBox8.Location = new System.Drawing.Point(37, 32);
                this.textBox8.Name = "textBox8";
                this.textBox8.PasswordChar = '*';
                this.textBox8.Size = new System.Drawing.Size(100, 20);
                this.textBox8.TabIndex = 2;
                // 
                // label27
                // 
                this.label27.AutoSize = true;
                this.label27.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label27.Location = new System.Drawing.Point(146, 94);
                this.label27.Name = "label27";
                this.label27.Size = new System.Drawing.Size(135, 19);
                this.label27.TabIndex = 1;
                this.label27.Text = "كلمة السر الجديدة";
                // 
                // label26
                // 
                this.label26.AutoSize = true;
                this.label26.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label26.Location = new System.Drawing.Point(146, 29);
                this.label26.Name = "label26";
                this.label26.Size = new System.Drawing.Size(130, 19);
                this.label26.TabIndex = 0;
                this.label26.Text = "كلمة السر الحالية";
                // 
                // panel17
                // 
                this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.panel17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.panel17.Controls.Add(this.button40);
                this.panel17.Controls.Add(this.label38);
                this.panel17.Controls.Add(this.label37);
                this.panel17.Controls.Add(this.label36);
                this.panel17.Controls.Add(this.btnDeleteReceipts);
                this.panel17.Controls.Add(this.cmbDeleteMonth);
                this.panel17.Controls.Add(this.txtDeleteYear);
                this.panel17.Location = new System.Drawing.Point(566, 212);
                this.panel17.Name = "panel17";
                this.panel17.Size = new System.Drawing.Size(277, 204);
                this.panel17.TabIndex = 46;
                this.panel17.Visible = false;
                // 
                // button40
                // 
                this.button40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button40.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button40.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button40.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.button40.ForeColor = System.Drawing.Color.White;
                this.button40.Location = new System.Drawing.Point(25, 164);
                this.button40.Name = "button40";
                this.button40.Size = new System.Drawing.Size(75, 32);
                this.button40.TabIndex = 31;
                this.button40.Text = "رجوع";
                this.button40.UseVisualStyleBackColor = false;
                this.button40.Click += new System.EventHandler(this.button40_Click);
                // 
                // label38
                // 
                this.label38.AutoSize = true;
                this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label38.Location = new System.Drawing.Point(113, 14);
                this.label38.Name = "label38";
                this.label38.Size = new System.Drawing.Size(77, 20);
                this.label38.TabIndex = 30;
                this.label38.Text = "حذف البيانات";
                // 
                // label37
                // 
                this.label37.AutoSize = true;
                this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label37.Location = new System.Drawing.Point(169, 111);
                this.label37.Name = "label37";
                this.label37.Size = new System.Drawing.Size(69, 20);
                this.label37.TabIndex = 29;
                this.label37.Text = ": حدد الشهر";
                // 
                // label36
                // 
                this.label36.AutoSize = true;
                this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label36.Location = new System.Drawing.Point(169, 62);
                this.label36.Name = "label36";
                this.label36.Size = new System.Drawing.Size(61, 20);
                this.label36.TabIndex = 28;
                this.label36.Text = ": حدد العام";
                // 
                // btnDeleteReceipts
                // 
                this.btnDeleteReceipts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.btnDeleteReceipts.Cursor = System.Windows.Forms.Cursors.Hand;
                this.btnDeleteReceipts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.btnDeleteReceipts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.btnDeleteReceipts.ForeColor = System.Drawing.Color.White;
                this.btnDeleteReceipts.Location = new System.Drawing.Point(182, 164);
                this.btnDeleteReceipts.Name = "btnDeleteReceipts";
                this.btnDeleteReceipts.Size = new System.Drawing.Size(75, 32);
                this.btnDeleteReceipts.TabIndex = 2;
                this.btnDeleteReceipts.Text = "حذف";
                this.btnDeleteReceipts.UseVisualStyleBackColor = false;
                this.btnDeleteReceipts.Click += new System.EventHandler(this.btnDeleteReceipts_Click);
                // 
                // cmbDeleteMonth
                // 
                this.cmbDeleteMonth.FormattingEnabled = true;
                this.cmbDeleteMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
                this.cmbDeleteMonth.Location = new System.Drawing.Point(42, 110);
                this.cmbDeleteMonth.Name = "cmbDeleteMonth";
                this.cmbDeleteMonth.Size = new System.Drawing.Size(121, 21);
                this.cmbDeleteMonth.TabIndex = 1;
                // 
                // txtDeleteYear
                // 
                this.txtDeleteYear.Location = new System.Drawing.Point(63, 64);
                this.txtDeleteYear.Name = "txtDeleteYear";
                this.txtDeleteYear.Size = new System.Drawing.Size(100, 20);
                this.txtDeleteYear.TabIndex = 0;
                // 
                // button41
                // 
                this.button41.Location = new System.Drawing.Point(1066, 626);
                this.button41.Name = "button41";
                this.button41.Size = new System.Drawing.Size(65, 56);
                this.button41.TabIndex = 47;
                this.button41.Text = "wipe";
                this.button41.UseVisualStyleBackColor = true;
                this.button41.Visible = false;
                this.button41.Click += new System.EventHandler(this.button41_Click);
                // 
                // label39
                // 
                this.label39.AutoSize = true;
                this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label39.Location = new System.Drawing.Point(1245, 340);
                this.label39.Name = "label39";
                this.label39.Size = new System.Drawing.Size(82, 25);
                this.label39.TabIndex = 48;
                this.label39.Text = "label39";
                // 
                // panel18
                // 
                this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.panel18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.panel18.Controls.Add(this.label40);
                this.panel18.Controls.Add(this.comboBox4);
                this.panel18.Controls.Add(this.button44);
                this.panel18.Controls.Add(this.label21);
                this.panel18.Location = new System.Drawing.Point(365, 250);
                this.panel18.Name = "panel18";
                this.panel18.Size = new System.Drawing.Size(732, 216);
                this.panel18.TabIndex = 49;
                this.panel18.Visible = false;
                // 
                // label40
                // 
                this.label40.AutoSize = true;
                this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label40.Location = new System.Drawing.Point(349, 9);
                this.label40.Name = "label40";
                this.label40.Size = new System.Drawing.Size(75, 20);
                this.label40.TabIndex = 27;
                this.label40.Text = "قسم التعليمات";
                // 
                // comboBox4
                // 
                this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.comboBox4.FormattingEnabled = true;
                this.comboBox4.Items.AddRange(new object[] {
            "طريقة تسجيل الطلبات",
            "تعديل القوائم والأصناف",
            "إدارة المبيعات"});
                this.comboBox4.Location = new System.Drawing.Point(91, 9);
                this.comboBox4.Name = "comboBox4";
                this.comboBox4.Size = new System.Drawing.Size(208, 21);
                this.comboBox4.TabIndex = 26;
                this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
                // 
                // button44
                // 
                this.button44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button44.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button44.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button44.ForeColor = System.Drawing.Color.White;
                this.button44.Location = new System.Drawing.Point(13, 168);
                this.button44.Name = "button44";
                this.button44.Size = new System.Drawing.Size(77, 35);
                this.button44.TabIndex = 25;
                this.button44.Text = "رجوع";
                this.button44.UseVisualStyleBackColor = false;
                this.button44.Click += new System.EventHandler(this.button44_Click);
                // 
                // label21
                // 
                this.label21.AutoSize = true;
                this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label21.Location = new System.Drawing.Point(7, 47);
                this.label21.Name = "label21";
                this.label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                this.label21.Size = new System.Drawing.Size(60, 20);
                this.label21.TabIndex = 0;
                this.label21.Text = "label21";
                this.label21.TextAlign = System.Drawing.ContentAlignment.TopRight;
                // 
                // panel20
                // 
                this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(216)))), ((int)(((byte)(226)))));
                this.panel20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.panel20.Controls.Add(this.button47);
                this.panel20.Controls.Add(this.label48);
                this.panel20.Controls.Add(this.label47);
                this.panel20.Controls.Add(this.label46);
                this.panel20.Controls.Add(this.label45);
                this.panel20.Controls.Add(this.pictureBox1);
                this.panel20.Location = new System.Drawing.Point(384, 102);
                this.panel20.Name = "panel20";
                this.panel20.Size = new System.Drawing.Size(588, 489);
                this.panel20.TabIndex = 50;
                this.panel20.Visible = false;
                // 
                // button47
                // 
                this.button47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(107)))), ((int)(((byte)(143)))));
                this.button47.Cursor = System.Windows.Forms.Cursors.Hand;
                this.button47.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                this.button47.ForeColor = System.Drawing.Color.White;
                this.button47.Location = new System.Drawing.Point(249, 429);
                this.button47.Name = "button47";
                this.button47.Size = new System.Drawing.Size(100, 43);
                this.button47.TabIndex = 6;
                this.button47.Text = "رجوع";
                this.button47.UseVisualStyleBackColor = false;
                this.button47.Click += new System.EventHandler(this.button47_Click);
                // 
                // label48
                // 
                this.label48.AutoSize = true;
                this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label48.Location = new System.Drawing.Point(248, 356);
                this.label48.Name = "label48";
                this.label48.Size = new System.Drawing.Size(25, 16);
                this.label48.TabIndex = 5;
                this.label48.Text = "1.0";
                // 
                // label47
                // 
                this.label47.AutoSize = true;
                this.label47.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label47.Location = new System.Drawing.Point(265, 351);
                this.label47.Name = "label47";
                this.label47.Size = new System.Drawing.Size(99, 23);
                this.label47.TabIndex = 4;
                this.label47.Text = " : نسخة البرنامج";
                // 
                // label46
                // 
                this.label46.AutoSize = true;
                this.label46.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label46.Location = new System.Drawing.Point(221, 327);
                this.label46.Name = "label46";
                this.label46.Size = new System.Drawing.Size(177, 23);
                this.label46.TabIndex = 3;
                this.label46.Text = "برنامج الكاشير لادارة المطاعم";
                // 
                // label45
                // 
                this.label45.AutoSize = true;
                this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label45.Location = new System.Drawing.Point(200, 199);
                this.label45.Name = "label45";
                this.label45.Size = new System.Drawing.Size(181, 25);
                this.label45.TabIndex = 2;
                this.label45.Text = "Thuraya Software";
                // 
                // pictureBox1
                // 
                this.pictureBox1.Image = global::الكاشير.Properties.Resources.Artboard_3;
                this.pictureBox1.Location = new System.Drawing.Point(99, -120);
                this.pictureBox1.Name = "pictureBox1";
                this.pictureBox1.Size = new System.Drawing.Size(393, 387);
                this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                this.pictureBox1.TabIndex = 0;
                this.pictureBox1.TabStop = false;
                // 
                // Form1
                // 
                this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(237)))), ((int)(((byte)(244)))));
                this.ClientSize = new System.Drawing.Size(1370, 749);
                this.Controls.Add(this.editingpanel);
                this.Controls.Add(this.panel14);
                this.Controls.Add(this.label39);
                this.Controls.Add(this.button41);
                this.Controls.Add(this.button18);
                this.Controls.Add(this.button17);
                this.Controls.Add(this.button5);
                this.Controls.Add(this.menupanel);
                this.Controls.Add(this.panel2);
                this.Controls.Add(this.panel9);
                this.Controls.Add(this.panel10);
                this.Controls.Add(this.panel8);
                this.Controls.Add(this.panel7);
                this.Controls.Add(this.panel5);
                this.Controls.Add(this.panel4);
                this.Controls.Add(this.panel11);
                this.Controls.Add(this.panel12);
                this.Controls.Add(this.panel3);
                this.Controls.Add(this.panel6);
                this.Controls.Add(this.panel13);
                this.Controls.Add(this.panel18);
                this.Controls.Add(this.panel1);
                this.Controls.Add(this.receiptpanel);
                this.Controls.Add(this.panel17);
                this.Controls.Add(this.pwchangepanel);
                this.Controls.Add(this.passpanel);
                this.Controls.Add(this.mealspanel);
                this.Controls.Add(this.sectionspanel);
                this.Controls.Add(this.panel20);
                this.Controls.Add(this.settingspanel);
                this.Controls.Add(this.dbpanel);
                this.ForeColor = System.Drawing.SystemColors.ControlText;
                this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                this.Name = "Form1";
                this.Load += new System.EventHandler(this.Form1_Load);
                this.panel1.ResumeLayout(false);
                this.panel1.PerformLayout();
                this.panel2.ResumeLayout(false);
                this.menupanel.ResumeLayout(false);
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
                this.sectionspanel.ResumeLayout(false);
                this.sectionspanel.PerformLayout();
                this.settingspanel.ResumeLayout(false);
                this.settingspanel.PerformLayout();
                this.receiptpanel.ResumeLayout(false);
                this.receiptpanel.PerformLayout();
                this.mealspanel.ResumeLayout(false);
                this.mealspanel.PerformLayout();
                this.panel19.ResumeLayout(false);
                this.editingpanel.ResumeLayout(false);
                this.editingpanel.PerformLayout();
                this.panel3.ResumeLayout(false);
                this.panel4.ResumeLayout(false);
                this.panel5.ResumeLayout(false);
                this.panel6.ResumeLayout(false);
                this.panel7.ResumeLayout(false);
                this.panel8.ResumeLayout(false);
                this.panel9.ResumeLayout(false);
                this.panel10.ResumeLayout(false);
                this.panel11.ResumeLayout(false);
                this.panel12.ResumeLayout(false);
                this.panel13.ResumeLayout(false);
                this.panel13.PerformLayout();
                this.panel14.ResumeLayout(false);
                this.panel14.PerformLayout();
                this.dbpanel.ResumeLayout(false);
                this.dbpanel.PerformLayout();
                this.panel16.ResumeLayout(false);
                this.panel16.PerformLayout();
                this.panel15.ResumeLayout(false);
                this.panel15.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
                this.passpanel.ResumeLayout(false);
                this.passpanel.PerformLayout();
                this.pwchangepanel.ResumeLayout(false);
                this.pwchangepanel.PerformLayout();
                this.panel17.ResumeLayout(false);
                this.panel17.PerformLayout();
                this.panel18.ResumeLayout(false);
                this.panel18.PerformLayout();
                this.panel20.ResumeLayout(false);
                this.panel20.PerformLayout();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
                ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
                this.ResumeLayout(false);
                this.PerformLayout();

            }




            private void Form1_Load(object sender, EventArgs e)
            {
               
                foreach (Control ctrl in this.Controls)
                {
                    ctrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                }
                this.AutoScaleMode = AutoScaleMode.Dpi;
                string receiptPath = Path.Combine(Application.StartupPath, "receipt.txt");
                string databasePath = Path.Combine(Application.StartupPath, "data.txt");
                label42.Text = "يوجد 18 عنصر لكل قائمة من اليمين لليسار \n         الشكل تحت يوضح ترتيبها";
                label21.Text = "١- اختر القائمة المناسبة من القوائم الجانبية.\n" +
               "٢- اضغط على زر الصنف المطلوب، وسيُضاف مباشرة إلى الوصل مع السعر والكمية.\n" +
               "٣- يمكنك تغيير الكمية من خلال أدوات التحكم، كما يمكنك إدخال اسم الكاشير واختيار نوع الطلب (محلي أو سفري).\n" +
               "٤- بعد الانتهاء من الطلب، اضغط على زر طباعة لطباعة الوصل، وسيتم حفظ البيانات تلقائيًا في قاعدة البيانات مع التاريخ والوقت.";
                this.Text = "الكاشير";
                comboBox3.SelectedIndexChanged += Filter_Changed;
                txtYearFilter.TextChanged += Filter_Changed;
                textBox10.TextChanged += Filter_Changed;
                LoadReceiptsWithFlexibleFilters(null, null, null);
                UpdateTotalSumFromGrid();
                LoadAllReceipts();
                comboBox3.Items.AddRange(new object[] {"الكل","1", "2", "3", "4", "5", "6","7", "8", "9", "10", "11", "12"});
                cashiername = GetMenuItemByRow(31);
                dbpassword = GetMenuItemByRow(758);
                backupdbpassword = GetMenuItemByRow(759);
                button5.PerformClick();
                WindowState = FormWindowState.Maximized;
                timer1.Start();
                richTextBox1.Text = File.ReadAllText(receiptPath);
                for (int menuIndex = 0; menuIndex < 10; menuIndex++)
                {
                    for (int btnIndex = 0; btnIndex < 18; btnIndex++)
                    {
                        string buttonName = string.Format("m{0}btn{1}", menuIndex + 1, btnIndex + 1);
                        var field = this.GetType().GetField(buttonName, System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
                        if (field != null)
                        {
                            var button = field.GetValue(this) as Button;
                            menuButtons[menuIndex, btnIndex] = button;
                        }
                        else
                        {
                            MessageBox.Show("Button not found: " + buttonName);
                        }
                    }
                }

                for (int i = 0; i < 10; i++)  // Loop through 10 menus
                {
                    for (int j = 0; j < 18; j++)  // Loop through 18 buttons per menu
                    {
                        Button btn = menuButtons[i, j];

                        // Calculate the row number for the button
                        int rownum = (i * 72) + (j * 4) + 34;  // 72 lines per menu, 4 lines per button, starting at line 34

                        // Set button text
                        btn.Text = GetMenuItemByRow(rownum) + " " + GetMenuItemByRow(rownum + 1);

                        // Set button color
                        btn.BackColor = ColorTranslator.FromHtml(GetMenuItemByRow(rownum + 2));

                        // Set visibility based on retrieved data
                        if (GetMenuItemByRow(rownum + 3) == "true")
                        {
                            btn.Visible = true;
                        }
                        else
                        {
                            btn.Visible = false;
                        }
                    }
                }
                businessname = GetMenuItemByRow(754);
                businesslogo = GetMenuItemByRow(755);
                textBox1.Text = GetMenuItemByRow(31);
                //menus //1
                secbutton1.Text = GetMenuItemByRow(1);
                
                sectextBox1.Text = GetMenuItemByRow(1);
                if (GetMenuItemByRow(2) == "true")
                {
                    seccheckBox1.Checked = true;
                }
                label39.Text =secbutton1.Text;
                //2
                secbutton2.Text = GetMenuItemByRow(3);
                
                sectextBox2.Text = GetMenuItemByRow(3);
                if (GetMenuItemByRow(4) == "true")
                {
                    seccheckBox2.Checked = true;
                }
                //3
                secbutton3.Text = GetMenuItemByRow(5);
                
                sectextBox3.Text = GetMenuItemByRow(5);
                if (GetMenuItemByRow(6) == "true")
                {
                    seccheckBox3.Checked = true;
                }
                //4
                secbutton4.Text = GetMenuItemByRow(7);
               
                sectextBox4.Text = GetMenuItemByRow(7);
                if (GetMenuItemByRow(8) == "true")
                {
                    seccheckBox4.Checked = true;
                }
                //5
                secbutton5.Text = GetMenuItemByRow(9);
                
                sectextBox5.Text = GetMenuItemByRow(9);
                if (GetMenuItemByRow(10) == "true")
                {
                    seccheckBox5.Checked = true;
                }
                //6
                secbutton6.Text = GetMenuItemByRow(11);
               
                sectextBox6.Text = GetMenuItemByRow(11);
                if (GetMenuItemByRow(12) == "true")
                {
                    seccheckBox6.Checked = true;
                }
                //7
                secbutton7.Text = GetMenuItemByRow(13);
              
                sectextBox7.Text = GetMenuItemByRow(13);
                if (GetMenuItemByRow(14) == "true")
                {
                    seccheckBox7.Checked = true;
                }
                //8
                secbutton8.Text = GetMenuItemByRow(15);
               
                sectextBox8.Text = GetMenuItemByRow(15);
                if (GetMenuItemByRow(16) == "true")
                {
                    seccheckBox8.Checked = true;
                }

                //9
                secbutton9.Text = GetMenuItemByRow(25);
             
                sectextBox9.Text = GetMenuItemByRow(25);
                if (GetMenuItemByRow(26) == "true")
                {
                    seccheckBox9.Checked = true;
                }
                //10
                secbutton10.Text = GetMenuItemByRow(27);
               
                sectextBox10.Text = GetMenuItemByRow(27);
                if (GetMenuItemByRow(28) == "true")
                {
                    seccheckBox10.Checked = true;
                }
                secbutton1.BackColor = Color.FromArgb(56, 92, 133);
            }

            string filePath = Path.Combine(Application.StartupPath, "data.txt");
            string[] menuItems = { "Burger", "Fries", "Pizza", "Soda", "Salad" };
            //get data row item
            string GetMenuItemByRow(int rowNumber)
            {
                string filePath = Path.Combine(Application.StartupPath, "data.txt");

                if (File.Exists(filePath))
                {
                    string[] menuItems = File.ReadAllLines(filePath);

                    if (rowNumber >= 0 && rowNumber < menuItems.Length)
                    {
                        return menuItems[rowNumber]; // Return the item at the given row number
                    }
                    else
                    {
                        return "Invalid row number!";
                    }
                }
                return "File not found!";
            }
       

            //add item to data
            static void AddMenuItemAtRow(string newItem, int rowNumber)
            {
                string filePath = Path.Combine(Application.StartupPath, "data.txt");
                List<string> menuItems = File.ReadAllLines(filePath).ToList();

                if (rowNumber >= 0 && rowNumber < menuItems.Count) // Overwrite existing row
                {
                    menuItems[rowNumber] = newItem;
                }
                else if (rowNumber == menuItems.Count) // Append to the end if it's the next row
                {
                    menuItems.Add(newItem);
                }
                else
                {
                    Console.WriteLine("Invalid row number for insertion.");
                    return;
                }

                File.WriteAllLines(filePath, menuItems);
            }
            string GetMenuItemByRow2(int rowNumber)
            {
                string filePath = Path.Combine(Application.StartupPath, "receipt.txt");

                if (File.Exists(filePath))
                {
                    string[] menuItems = File.ReadAllLines(filePath);

                    if (rowNumber >= 0 && rowNumber < menuItems.Length)
                    {
                        return menuItems[rowNumber]; // Return the item at the given row number
                    }
                    else
                    {
                        return "Invalid row number!";
                    }
                }
                return "File not found!";
            }

            //add item to data
            static void AddMenuItemAtRow2(string newItem, int rowNumber)
            {
                string filePath = Path.Combine(Application.StartupPath, "receipt.txt");
                List<string> menuItems = File.ReadAllLines(filePath).ToList();

                if (rowNumber >= 0 && rowNumber < menuItems.Count) // Overwrite existing row
                {
                    menuItems[rowNumber] = newItem;
                }
                else if (rowNumber == menuItems.Count) // Append to the end if it's the next row
                {
                    menuItems.Add(newItem);
                }
                else
                {
                    Console.WriteLine("Invalid row number for insertion.");
                    return;
                }

                File.WriteAllLines(filePath, menuItems);
            }


            //delete item from data
            private void DeleteMenuItem(int rowNumber)
            {
                string filePath = Path.Combine(Application.StartupPath, "data.txt");

                if (File.Exists(filePath))
                {
                    List<string> menuItems = File.ReadAllLines(filePath).ToList();

                    if (rowNumber >= 0 && rowNumber < menuItems.Count)
                    {
                        menuItems.RemoveAt(rowNumber);
                        File.WriteAllLines(filePath, menuItems);
                    }
                }
            }



            

            private void button19_Click(object sender, EventArgs e)
            {
                cashiername = textBox1.Text;
                AddMenuItemAtRow(textBox1.Text, 31);
                panel1.Visible = false;
            }

            private void button20_Click(object sender, EventArgs e)
            {
                panel1.Visible = false;
            }

            private void pictureBox2_Click(object sender, EventArgs e)
            {
                settingspanel.Visible = true;
                settingspanel.BringToFront();
            }

            private void button27_Click(object sender, EventArgs e)
            {
                settingspanel.Visible = false;
            }

            private void button30_Click(object sender, EventArgs e)
            {
                sectionspanel.Visible = false;
                settingspanel.Visible = true;
                if (seccheckBox1.Checked)
                {
                    secbutton1.Visible = true; AddMenuItemAtRow(sectextBox1.Text, 1);
                    AddMenuItemAtRow("true", 2); secbutton1.Text = GetMenuItemByRow(1);
                }
                else
                {
                    secbutton1.Visible = false;
                    AddMenuItemAtRow("false", 2);
                }
                if (seccheckBox2.Checked)
                {
                    secbutton2.Visible = true;
                    AddMenuItemAtRow(sectextBox2.Text, 3);
                    AddMenuItemAtRow("true", 4);
                    secbutton2.Text = GetMenuItemByRow(3);
                }
                else
                {
                    secbutton2.Visible = false;
                    AddMenuItemAtRow("false", 4);
                }
                if (seccheckBox3.Checked)
                {
                    secbutton3.Visible = true;
                    AddMenuItemAtRow(sectextBox3.Text, 5);
                    AddMenuItemAtRow("true", 6);
                    secbutton3.Text = GetMenuItemByRow(5);
                }
                else
                {
                    secbutton3.Visible = false;
                    AddMenuItemAtRow("false", 6);
                }
                if (seccheckBox4.Checked)
                {
                    secbutton4.Visible = true;
                    AddMenuItemAtRow(sectextBox4.Text, 7);
                    AddMenuItemAtRow("true", 8);
                    secbutton4.Text = GetMenuItemByRow(7);
                }
                else
                {
                    secbutton4.Visible = false;
                    AddMenuItemAtRow("false", 8);
                }
                if (seccheckBox5.Checked)
                {
                    secbutton5.Visible = true; AddMenuItemAtRow(sectextBox5.Text, 9);
                    AddMenuItemAtRow("true", 10); secbutton5.Text = GetMenuItemByRow(9);
                }
                else
                {
                    secbutton5.Visible = false;
                    AddMenuItemAtRow("false", 10);
                }
                if (seccheckBox6.Checked)
                {
                    secbutton6.Visible = true;
                    AddMenuItemAtRow(sectextBox6.Text, 11);
                    AddMenuItemAtRow("true", 12);
                    secbutton6.Text = GetMenuItemByRow(11);
                }
                else
                {
                    secbutton6.Visible = false;
                    AddMenuItemAtRow("false", 12);
                }
                if (seccheckBox7.Checked)
                {
                    secbutton7.Visible = true;
                    AddMenuItemAtRow(sectextBox7.Text, 13);
                    AddMenuItemAtRow("true", 14);
                    secbutton7.Text = GetMenuItemByRow(13);
                }
                else
                {
                    secbutton7.Visible = false;
                    AddMenuItemAtRow("false", 14);
                }
                if (seccheckBox8.Checked)
                {
                    secbutton8.Visible = true; AddMenuItemAtRow(sectextBox8.Text, 15);
                    AddMenuItemAtRow("true", 16); secbutton8.Text = GetMenuItemByRow(15);
                }
                else
                {
                    secbutton8.Visible = false;
                    AddMenuItemAtRow("false", 16);
                }
                if (seccheckBox9.Checked)
                {
                    secbutton9.Visible = true; AddMenuItemAtRow(sectextBox9.Text, 25);
                    AddMenuItemAtRow("true", 26); secbutton9.Text = GetMenuItemByRow(25);
                }
                else
                {
                    secbutton9.Visible = false;
                    AddMenuItemAtRow("false", 26);
                }
                if (seccheckBox10.Checked)
                {
                    secbutton10.Visible = true; AddMenuItemAtRow(sectextBox10.Text, 27);
                    AddMenuItemAtRow("true", 28); secbutton10.Text = GetMenuItemByRow(27);
                }
                else
                {
                    secbutton10.Visible = false;
                    AddMenuItemAtRow("false", 28);
                }
            }

            private void button28_Click(object sender, EventArgs e)
            {
                sectionspanel.Visible = true;
                sectionspanel.BringToFront();
                settingspanel.Visible = false;


            }

            private void checkBox1_CheckedChanged(object sender, EventArgs e)
            {
                if (seccheckBox1.Checked)
                {
                    secbutton1.Visible = true;
                    AddMenuItemAtRow(sectextBox1.Text, 1);
                    AddMenuItemAtRow("true", 2);
                    secbutton1.Text = GetMenuItemByRow(1);
                }
                else
                {
                    secbutton1.Visible = false;
                    AddMenuItemAtRow("false", 2);
                }
            }

            private void seccheckBox2_CheckedChanged(object sender, EventArgs e)
            {
                if (seccheckBox2.Checked)
                {
                    secbutton2.Visible = true;
                    AddMenuItemAtRow(sectextBox2.Text, 3);
                    AddMenuItemAtRow("true", 4);
                    secbutton2.Text = GetMenuItemByRow(3);
                }
                else
                {
                    secbutton2.Visible = false;
                    AddMenuItemAtRow("false", 4);
                }
            }

            private void seccheckBox3_CheckedChanged(object sender, EventArgs e)
            {
                if (seccheckBox3.Checked)
                {
                    secbutton3.Visible = true;
                    AddMenuItemAtRow(sectextBox3.Text, 5);
                    AddMenuItemAtRow("true", 6);
                    secbutton3.Text = GetMenuItemByRow(5);
                }
                else
                {
                    secbutton3.Visible = false;
                    AddMenuItemAtRow("false", 6);
                }
            }

            private void seccheckBox4_CheckedChanged(object sender, EventArgs e)
            {
                if (seccheckBox4.Checked)
                {
                    secbutton4.Visible = true;
                    AddMenuItemAtRow(sectextBox4.Text, 7);
                    AddMenuItemAtRow("true", 8);
                    secbutton4.Text = GetMenuItemByRow(7);
                }
                else
                {
                    secbutton4.Visible = false;
                    AddMenuItemAtRow("false", 8);
                }
            }

            private void seccheckBox5_CheckedChanged(object sender, EventArgs e)
            {
                if (seccheckBox5.Checked)
                {
                    secbutton5.Visible = true;
                    AddMenuItemAtRow(sectextBox5.Text, 9);
                    AddMenuItemAtRow("true", 10);
                    secbutton5.Text = GetMenuItemByRow(9);
                }
                else
                {
                    secbutton5.Visible = false;
                    AddMenuItemAtRow("false", 10);
                }
            }

            private void seccheckBox6_CheckedChanged(object sender, EventArgs e)
            {
                if (seccheckBox6.Checked)
                {
                    secbutton6.Visible = true;
                    AddMenuItemAtRow(sectextBox6.Text, 11);
                    AddMenuItemAtRow("true", 12);
                    secbutton6.Text = GetMenuItemByRow(11);
                }
                else
                {
                    secbutton6.Visible = false;
                    AddMenuItemAtRow("false", 12);
                }
            }

            private void seccheckBox7_CheckedChanged(object sender, EventArgs e)
            {
                if (seccheckBox7.Checked)
                {
                    secbutton7.Visible = true;
                    AddMenuItemAtRow(sectextBox7.Text, 13);
                    AddMenuItemAtRow("true", 14);
                    secbutton7.Text = GetMenuItemByRow(13);
                }
                else
                {
                    secbutton7.Visible = false;
                    AddMenuItemAtRow("false", 14);
                }
            }

            private void seccheckBox8_CheckedChanged(object sender, EventArgs e)
            {
                if (seccheckBox8.Checked)
                {
                    secbutton8.Visible = true;
                    AddMenuItemAtRow(sectextBox8.Text, 15);
                    AddMenuItemAtRow("true", 16);
                    secbutton8.Text = GetMenuItemByRow(15);
                }
                else
                {
                    secbutton8.Visible = false;
                    AddMenuItemAtRow("false", 16);
                }
            }

            private void seccheckBox9_CheckedChanged(object sender, EventArgs e)
            {
                if (seccheckBox9.Checked)
                {
                    secbutton9.Visible = true;
                    AddMenuItemAtRow(sectextBox9.Text, 25);
                    AddMenuItemAtRow("true", 26);
                    secbutton9.Text = GetMenuItemByRow(25);
                }
                else
                {
                    secbutton9.Visible = false;
                    AddMenuItemAtRow("false", 26);
                }
            }
            private void seccheckBox10_CheckedChanged(object sender, EventArgs e)
            {
                if (seccheckBox10.Checked)
                {
                    secbutton10.Visible = true;
                    AddMenuItemAtRow(sectextBox10.Text, 27);
                    AddMenuItemAtRow("true", 28);
                    secbutton10.Text = GetMenuItemByRow(27);
                }
                else
                {
                    secbutton10.Visible = false;
                    AddMenuItemAtRow("false", 28);
                }
            }





            private void seccolorbtn1_Click(object sender, EventArgs e)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    secbutton1.BackColor = colorDialog1.Color;
                    string colorHex = ColorTranslator.ToHtml(colorDialog1.Color);
                    AddMenuItemAtRow(colorHex, 17);
                }
            }

            private void seccolorbtn2_Click(object sender, EventArgs e)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    secbutton2.BackColor = colorDialog1.Color;
                    string colorHex = ColorTranslator.ToHtml(colorDialog1.Color);
                    AddMenuItemAtRow(colorHex, 18);
                }
            }

            private void seccolorbtn3_Click(object sender, EventArgs e)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    secbutton3.BackColor = colorDialog1.Color;
                    string colorHex = ColorTranslator.ToHtml(colorDialog1.Color);
                    AddMenuItemAtRow(colorHex, 19);
                }
            }

            private void seccolorbtn4_Click(object sender, EventArgs e)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    secbutton4.BackColor = colorDialog1.Color;
                    string colorHex = ColorTranslator.ToHtml(colorDialog1.Color);
                    AddMenuItemAtRow(colorHex, 20);
                }
            }

            private void seccolorbtn5_Click(object sender, EventArgs e)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    secbutton5.BackColor = colorDialog1.Color;
                    string colorHex = ColorTranslator.ToHtml(colorDialog1.Color);
                    AddMenuItemAtRow(colorHex, 21);
                }
            }

            private void seccolorbtn6_Click(object sender, EventArgs e)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    secbutton6.BackColor = colorDialog1.Color;
                    string colorHex = ColorTranslator.ToHtml(colorDialog1.Color);
                    AddMenuItemAtRow(colorHex, 22);
                }
            }

            private void seccolorbtn7_Click(object sender, EventArgs e)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    secbutton7.BackColor = colorDialog1.Color;
                    string colorHex = ColorTranslator.ToHtml(colorDialog1.Color);
                    AddMenuItemAtRow(colorHex, 23);
                }
            }

            private void seccolorbtn8_Click(object sender, EventArgs e)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    secbutton8.BackColor = colorDialog1.Color;
                    string colorHex = ColorTranslator.ToHtml(colorDialog1.Color);
                    AddMenuItemAtRow(colorHex, 24);
                }
            }

            private void seccolorbtn9_Click(object sender, EventArgs e)
            {

                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    secbutton9.BackColor = colorDialog1.Color;
                    string colorHex = ColorTranslator.ToHtml(colorDialog1.Color);
                    AddMenuItemAtRow(colorHex, 29);
                }
            }

            private void seccolorbtn10_Click(object sender, EventArgs e)
            {

                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    secbutton10.BackColor = colorDialog1.Color;
                    string colorHex = ColorTranslator.ToHtml(colorDialog1.Color);
                    AddMenuItemAtRow(colorHex, 30);
                }
            }

            private void button21_Click(object sender, EventArgs e)
            {
                mealspanel.Visible = false;
                settingspanel.Visible = true;
            }

            private void button29_Click(object sender, EventArgs e)
            {
                mealspanel.Visible = true;
                mealspanel.BringToFront();
                settingspanel.Visible = false;
            }

            private void button22_Click(object sender, EventArgs e)
            {
                if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
                {
                    MessageBox.Show("اختر العنصر والقائمة");
                }
                else
                {
                    editingpanel.Visible = true;
                    editingpanel.BringToFront();
                    mealspanel.Visible = false;
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 18; j++)
                        {

                            if (comboBox2.SelectedIndex == i && comboBox1.SelectedIndex == j)
                            {
                                AddMenuItemAtRow(i.ToString(), 32);
                                AddMenuItemAtRow(j.ToString(), 33);
                                break;
                            }
                        }
                    }
                }
            }

            private void button24_Click(object sender, EventArgs e)
            {
                editingpanel.Visible = false;
                mealspanel.Visible = true;
                mealspanel.BringToFront();
            }

            private void button25_Click(object sender, EventArgs e)
            {
                if (textBox2.Text == null || textBox3.Text == null)
                {
                    MessageBox.Show("املأ الحقول");
                }
                else
                {

                    int menunum, itemnum;
                    string price = textBox3.Text;
                    int.TryParse(GetMenuItemByRow(32), out menunum); // Get menu number (zero-based)
                    int.TryParse(GetMenuItemByRow(33), out itemnum); // Get item number (zero-based)

                    // Row calculation formula for the button:
                    int rownum = (menunum * 72) + (itemnum * 4) + 34;  // 72 lines per menu, 4 lines per button, starting at line 34

                    // Store the button data
                    AddMenuItemAtRow(textBox2.Text, rownum); // Button text
                    AddMenuItemAtRow(textBox3.Text, rownum + 1); // Button price
                    if (tcolor == true)
                    {
                        string colorHex = ColorTranslator.ToHtml(tempcolor);
                        AddMenuItemAtRow(colorHex, rownum + 2); // Button color
                    }
                    menuButtons[menunum, itemnum].Text = textBox2.Text + " " + textBox3.Text;
                    menuButtons[menunum, itemnum].BackColor = tempcolor;

                    if (checkBox1.Checked)
                    {
                        menuButtons[menunum, itemnum].Visible = true;
                        AddMenuItemAtRow("true", rownum + 3); // Button visibility
                    }
                    else
                    {
                        menuButtons[menunum, itemnum].Visible = false;
                        AddMenuItemAtRow("false", rownum + 3); // Button visibility
                    }

                    MessageBox.Show("تم التعديل"); // Inform user of the edit

                }
            }

            private void button23_Click(object sender, EventArgs e)
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    tempcolor = colorDialog1.Color;
                    tcolor = true;
                }
            }

            private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
            {

            }

            private void secbutton1_Click(object sender, EventArgs e)
            {
                secbutton1.BackColor = Color.FromArgb(56, 92, 133);
                secbutton1.ForeColor = Color.White;
                secbutton2.BackColor = Color.FromArgb(207, 216, 226);
                secbutton2.ForeColor = Color.Black;
                secbutton3.BackColor = Color.FromArgb(207, 216, 226);
                secbutton3.ForeColor = Color.Black;
                secbutton4.BackColor = Color.FromArgb(207, 216, 226);
                secbutton4.ForeColor = Color.Black;
                secbutton5.BackColor = Color.FromArgb(207, 216, 226);
                secbutton5.ForeColor = Color.Black;
                secbutton6.BackColor = Color.FromArgb(207, 216, 226);
                secbutton6.ForeColor = Color.Black;
                secbutton7.BackColor = Color.FromArgb(207, 216, 226);
                secbutton7.ForeColor = Color.Black;
                secbutton8.BackColor = Color.FromArgb(207, 216, 226);
                secbutton8.ForeColor = Color.Black;
                secbutton9.BackColor = Color.FromArgb(207, 216, 226);
                secbutton9.ForeColor = Color.Black;
                secbutton10.BackColor = Color.FromArgb(207, 216, 226);
                secbutton10.ForeColor = Color.Black;
                label39.Text = secbutton1.Text;
                panel3.Visible = true;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                panel10.Visible = false;
                panel11.Visible = false;
                panel12.Visible = false;

            }

            private void secbutton2_Click(object sender, EventArgs e)
            {
                secbutton1.BackColor = Color.FromArgb(207, 216, 226);
                secbutton1.ForeColor = Color.Black;
                secbutton2.BackColor = Color.FromArgb(56, 92, 133);
                secbutton2.ForeColor = Color.White;
                secbutton3.BackColor = Color.FromArgb(207, 216, 226);
                secbutton3.ForeColor = Color.Black;
                secbutton4.BackColor = Color.FromArgb(207, 216, 226);
                secbutton4.ForeColor = Color.Black;
                secbutton5.BackColor = Color.FromArgb(207, 216, 226);
                secbutton5.ForeColor = Color.Black;
                secbutton6.BackColor = Color.FromArgb(207, 216, 226);
                secbutton6.ForeColor = Color.Black;
                secbutton7.BackColor = Color.FromArgb(207, 216, 226);
                secbutton7.ForeColor = Color.Black;
                secbutton8.BackColor = Color.FromArgb(207, 216, 226);
                secbutton8.ForeColor = Color.Black;
                secbutton9.BackColor = Color.FromArgb(207, 216, 226);
                secbutton9.ForeColor = Color.Black;
                secbutton10.BackColor = Color.FromArgb(207, 216, 226);
                secbutton10.ForeColor = Color.Black;
                label39.Text = secbutton2.Text;
                panel3.Visible = false;
                panel4.Visible = true;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                panel10.Visible = false;
                panel11.Visible = false;
                panel12.Visible = false;
            }

            private void secbutton3_Click(object sender, EventArgs e)
            {
                secbutton1.BackColor = Color.FromArgb(207, 216, 226);
                secbutton1.ForeColor = Color.Black;
                secbutton2.BackColor = Color.FromArgb(207, 216, 226);
                secbutton2.ForeColor = Color.Black;
                secbutton3.BackColor = Color.FromArgb(56, 92, 133);
                secbutton3.ForeColor = Color.White;
                secbutton4.BackColor = Color.FromArgb(207, 216, 226);
                secbutton4.ForeColor = Color.Black;
                secbutton5.BackColor = Color.FromArgb(207, 216, 226);
                secbutton5.ForeColor = Color.Black;
                secbutton6.BackColor = Color.FromArgb(207, 216, 226);
                secbutton6.ForeColor = Color.Black;
                secbutton7.BackColor = Color.FromArgb(207, 216, 226);
                secbutton7.ForeColor = Color.Black;
                secbutton8.BackColor = Color.FromArgb(207, 216, 226);
                secbutton8.ForeColor = Color.Black;
                secbutton9.BackColor = Color.FromArgb(207, 216, 226);
                secbutton9.ForeColor = Color.Black;
                secbutton10.BackColor = Color.FromArgb(207, 216, 226);
                secbutton10.ForeColor = Color.Black;
                label39.Text = secbutton3.Text;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = true;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                panel10.Visible = false;
                panel11.Visible = false;
                panel12.Visible = false;
            }

            private void secbutton4_Click(object sender, EventArgs e)
            {
                secbutton1.BackColor = Color.FromArgb(207, 216, 226);
                secbutton1.ForeColor = Color.Black;
                secbutton2.BackColor = Color.FromArgb(207, 216, 226);
                secbutton2.ForeColor = Color.Black;
                secbutton3.BackColor = Color.FromArgb(207, 216, 226);
                secbutton3.ForeColor = Color.Black;
                secbutton4.BackColor = Color.FromArgb(56, 92, 133);
                secbutton4.ForeColor = Color.White;
                secbutton5.BackColor = Color.FromArgb(207, 216, 226);
                secbutton5.ForeColor = Color.Black;
                secbutton6.BackColor = Color.FromArgb(207, 216, 226);
                secbutton6.ForeColor = Color.Black;
                secbutton7.BackColor = Color.FromArgb(207, 216, 226);
                secbutton7.ForeColor = Color.Black;
                secbutton8.BackColor = Color.FromArgb(207, 216, 226);
                secbutton8.ForeColor = Color.Black;
                secbutton9.BackColor = Color.FromArgb(207, 216, 226);
                secbutton9.ForeColor = Color.Black;
                secbutton10.BackColor = Color.FromArgb(207, 216, 226);
                secbutton10.ForeColor = Color.Black;
                label39.Text = secbutton4.Text;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = true;
                panel7.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                panel10.Visible = false;
                panel11.Visible = false;
                panel12.Visible = false;
            }

            private void secbutton5_Click(object sender, EventArgs e)
            {
                secbutton1.BackColor = Color.FromArgb(207, 216, 226);
                secbutton1.ForeColor = Color.Black;
                secbutton2.BackColor = Color.FromArgb(207, 216, 226);
                secbutton2.ForeColor = Color.Black;
                secbutton3.BackColor = Color.FromArgb(207, 216, 226);
                secbutton3.ForeColor = Color.Black;
                secbutton4.BackColor = Color.FromArgb(207, 216, 226);
                secbutton4.ForeColor = Color.Black;
                secbutton5.BackColor = Color.FromArgb(56, 92, 133);
                secbutton5.ForeColor = Color.White;
                secbutton6.BackColor = Color.FromArgb(207, 216, 226);
                secbutton6.ForeColor = Color.Black;
                secbutton7.BackColor = Color.FromArgb(207, 216, 226);
                secbutton7.ForeColor = Color.Black;
                secbutton8.BackColor = Color.FromArgb(207, 216, 226);
                secbutton8.ForeColor = Color.Black;
                secbutton9.BackColor = Color.FromArgb(207, 216, 226);
                secbutton9.ForeColor = Color.Black;
                secbutton10.BackColor = Color.FromArgb(207, 216, 226);
                secbutton10.ForeColor = Color.Black;
                label39.Text = secbutton5.Text;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = true;
                panel8.Visible = false;
                panel9.Visible = false;
                panel10.Visible = false;
                panel11.Visible = false;
                panel12.Visible = false;
            }

            private void secbutton6_Click(object sender, EventArgs e)
            {
                secbutton1.BackColor = Color.FromArgb(207, 216, 226);
                secbutton1.ForeColor = Color.Black;
                secbutton2.BackColor = Color.FromArgb(207, 216, 226);
                secbutton2.ForeColor = Color.Black;
                secbutton3.BackColor = Color.FromArgb(207, 216, 226);
                secbutton3.ForeColor = Color.Black;
                secbutton4.BackColor = Color.FromArgb(207, 216, 226);
                secbutton4.ForeColor = Color.Black;
                secbutton5.BackColor = Color.FromArgb(207, 216, 226);
                secbutton5.ForeColor = Color.Black;
                secbutton6.BackColor = Color.FromArgb(56, 92, 133);
                secbutton6.ForeColor = Color.White;
                secbutton7.BackColor = Color.FromArgb(207, 216, 226);
                secbutton7.ForeColor = Color.Black;
                secbutton8.BackColor = Color.FromArgb(207, 216, 226);
                secbutton8.ForeColor = Color.Black;
                secbutton9.BackColor = Color.FromArgb(207, 216, 226);
                secbutton9.ForeColor = Color.Black;
                secbutton10.BackColor = Color.FromArgb(207, 216, 226);
                secbutton10.ForeColor = Color.Black;
                label39.Text = secbutton6.Text;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = true;
                panel9.Visible = false;
                panel10.Visible = false;
                panel11.Visible = false;
                panel12.Visible = false;
            }

            private void secbutton7_Click(object sender, EventArgs e)
            {
                secbutton1.BackColor = Color.FromArgb(207, 216, 226);
                secbutton1.ForeColor = Color.Black;
                secbutton2.BackColor = Color.FromArgb(207, 216, 226);
                secbutton2.ForeColor = Color.Black;
                secbutton3.BackColor = Color.FromArgb(207, 216, 226);
                secbutton3.ForeColor = Color.Black;
                secbutton4.BackColor = Color.FromArgb(207, 216, 226);
                secbutton4.ForeColor = Color.Black;
                secbutton5.BackColor = Color.FromArgb(207, 216, 226);
                secbutton5.ForeColor = Color.Black;
                secbutton6.BackColor = Color.FromArgb(207, 216, 226);
                secbutton6.ForeColor = Color.Black;
                secbutton7.BackColor = Color.FromArgb(56, 92, 133);
                secbutton7.ForeColor = Color.White;
                secbutton8.BackColor = Color.FromArgb(207, 216, 226);
                secbutton8.ForeColor = Color.Black;
                secbutton9.BackColor = Color.FromArgb(207, 216, 226);
                secbutton9.ForeColor = Color.Black;
                secbutton10.BackColor = Color.FromArgb(207, 216, 226);
                secbutton10.ForeColor = Color.Black;
                label39.Text = secbutton7.Text;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
                panel9.Visible = true;
                panel10.Visible = false;
                panel11.Visible = false;
                panel12.Visible = false;
            }

            private void secbutton8_Click(object sender, EventArgs e)
            {
                secbutton1.BackColor = Color.FromArgb(207, 216, 226);
                secbutton1.ForeColor = Color.Black;
                secbutton2.BackColor = Color.FromArgb(207, 216, 226);
                secbutton2.ForeColor = Color.Black;
                secbutton3.BackColor = Color.FromArgb(207, 216, 226);
                secbutton3.ForeColor = Color.Black;
                secbutton4.BackColor = Color.FromArgb(207, 216, 226);
                secbutton4.ForeColor = Color.Black;
                secbutton5.BackColor = Color.FromArgb(207, 216, 226);
                secbutton5.ForeColor = Color.Black;
                secbutton6.BackColor = Color.FromArgb(207, 216, 226);
                secbutton6.ForeColor = Color.Black;
                secbutton7.BackColor = Color.FromArgb(207, 216, 226);
                secbutton7.ForeColor = Color.Black;
                secbutton8.BackColor = Color.FromArgb(56, 92, 133);
                secbutton8.ForeColor = Color.White;
                secbutton9.BackColor = Color.FromArgb(207, 216, 226);
                secbutton9.ForeColor = Color.Black;
                secbutton10.BackColor = Color.FromArgb(207, 216, 226);
                secbutton10.ForeColor = Color.Black;
                label39.Text = secbutton8.Text;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                panel10.Visible = true;
                panel11.Visible = false;
                panel12.Visible = false;
            }

            private void secbutton9_Click(object sender, EventArgs e)
            {
                secbutton1.BackColor = Color.FromArgb(207, 216, 226);
                secbutton1.ForeColor = Color.Black;
                secbutton2.BackColor = Color.FromArgb(207, 216, 226);
                secbutton2.ForeColor = Color.Black;
                secbutton3.BackColor = Color.FromArgb(207, 216, 226);
                secbutton3.ForeColor = Color.Black;
                secbutton4.BackColor = Color.FromArgb(207, 216, 226);
                secbutton4.ForeColor = Color.Black;
                secbutton5.BackColor = Color.FromArgb(207, 216, 226);
                secbutton5.ForeColor = Color.Black;
                secbutton6.BackColor = Color.FromArgb(207, 216, 226);
                secbutton6.ForeColor = Color.Black;
                secbutton7.BackColor = Color.FromArgb(207, 216, 226);
                secbutton7.ForeColor = Color.Black;
                secbutton8.BackColor = Color.FromArgb(207, 216, 226);
                secbutton8.ForeColor = Color.Black;
                secbutton9.BackColor = Color.FromArgb(56, 92, 133);
                secbutton9.ForeColor = Color.White;
                secbutton10.BackColor = Color.FromArgb(207, 216, 226);
                secbutton10.ForeColor = Color.Black;
                label39.Text = secbutton9.Text;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                panel10.Visible = false;
                panel11.Visible = true;
                panel12.Visible = false;
            }

            private void secbutton10_Click(object sender, EventArgs e)
            {
                secbutton1.BackColor = Color.FromArgb(207, 216, 226);
                secbutton1.ForeColor = Color.Black;
                secbutton2.BackColor = Color.FromArgb(207, 216, 226);
                secbutton2.ForeColor = Color.Black;
                secbutton3.BackColor = Color.FromArgb(207, 216, 226);
                secbutton3.ForeColor = Color.Black;
                secbutton4.BackColor = Color.FromArgb(207, 216, 226);
                secbutton4.ForeColor = Color.Black;
                secbutton5.BackColor = Color.FromArgb(207, 216, 226);
                secbutton5.ForeColor = Color.Black;
                secbutton6.BackColor = Color.FromArgb(207, 216, 226);
                secbutton6.ForeColor = Color.Black;
                secbutton7.BackColor = Color.FromArgb(207, 216, 226);
                secbutton7.ForeColor = Color.Black;
                secbutton8.BackColor = Color.FromArgb(207, 216, 226);
                secbutton8.ForeColor = Color.Black;
                secbutton9.BackColor = Color.FromArgb(207, 216, 226);
                secbutton9.ForeColor = Color.Black;
                secbutton10.BackColor = Color.FromArgb(56, 92, 133);
                secbutton10.ForeColor = Color.White;
                label39.Text = secbutton10.Text;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                panel10.Visible = false;
                panel11.Visible = false;
                panel12.Visible = true;
                panel12.BringToFront();
            }

            private void button1_Click(object sender, EventArgs e)
            {
               
                receiptpanel.Visible = true;
                receiptpanel.BringToFront();

            }

            private void button2_Click(object sender, EventArgs e)
            {
                receiptpanel.Visible = false;
                settingspanel.Visible = true;
                settingspanel.BringToFront();
            }

            private void button3_Click(object sender, EventArgs e)
            {
                if (textBox4.Text == "")
                {
                    MessageBox.Show("املأ الحقول");
                }
                else
                {
                    AddMenuItemAtRow(textBox4.Text, 754);
                    AddMenuItemAtRow(businesslogo, 755);
                    receiptpanel.Visible = false;
                    settingspanel.Visible = true;
                    settingspanel.BringToFront();
                    MessageBox.Show("تم الحفظ");
                }
            }

            private void button4_Click(object sender, EventArgs e)
            {
                // Create a new OpenFileDialog
                OpenFileDialog openFileDialog = new OpenFileDialog();

                // Set the filter to accept only image files
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tiff";

                // Show the dialog and check if the user selected a file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the file path
                    businesslogo = openFileDialog.FileName;

                    // Do something with the file (e.g., display the image in a PictureBox)
                    MessageBox.Show("تم الأختيار");
                }
            }

            private void button5_Click(object sender, EventArgs e)
            {
                totalprice = 0;
                receiptitems = 0;
                string receiptPath = Path.Combine(Application.StartupPath, "receipt.txt");
                using (StreamWriter writer = new StreamWriter(receiptPath))
                {
                    writer.WriteLine("====================================");
                    writer.WriteLine("                                      " + GetMenuItemByRow(754)); // Restaurant name (line 754 in the txt file)
                    writer.WriteLine("====================================");

                    // Write receipt date and time in Arabic format
                    writer.WriteLine("التاريخ: " + DateTime.Now.ToString("yyyy-MM-dd                    الوقت: HH:mm:ss"));
                    writer.WriteLine("رقم الطلب: "+ GetMenuItemByRow(756)+"                                نوع الطلب: "+type );  // Starting receipt number

                    writer.WriteLine("---------------------------------------------------------------");

                    // Write items (loop through buttons or menu items)
                    writer.WriteLine("    :الطلبات:        السعر:  العدد:      الإجمالي");
                    writer.WriteLine("\n\n\n\n\n\n\n\n\n");
                    writer.WriteLine("---------------------------------------------------------------");
                    writer.WriteLine("المجموع: {0} دينار                                    الكاشير: {1}", totalprice, cashiername);
                    writer.WriteLine("---------------------------------------------------------------");
                    writer.WriteLine("                             شكراً لزيارتكم");
                }
            }

            private void timer1_Tick(object sender, EventArgs e)
            {
                string receiptPath = Path.Combine(Application.StartupPath, "receipt.txt");
                
                // Read all lines from the file
                string[] lines = File.ReadAllLines(receiptPath);

                // Create a list to hold non-empty lines
                List<string> nonEmptyLines = new List<string>();

                // Iterate through each line and add it to the list if it's not empty or whitespace
                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        nonEmptyLines.Add(line);
                    }
                }

                
                richTextBox1.Text = string.Join(Environment.NewLine, nonEmptyLines);
            }

          

            private void button6_Click(object sender, EventArgs e)
            {
                itemcount = 1;
                textBox5.Text = itemcount.ToString();
            }

            private void button7_Click(object sender, EventArgs e)
            {
                itemcount = 2;
                textBox5.Text = itemcount.ToString();
            }

            private void button8_Click(object sender, EventArgs e)
            {
                itemcount = 3;
                textBox5.Text = itemcount.ToString();
            }

            private void button11_Click(object sender, EventArgs e)
            {
                itemcount = 4;
                textBox5.Text = itemcount.ToString();
            }

            private void button10_Click(object sender, EventArgs e)
            {
                itemcount = 5;
                textBox5.Text = itemcount.ToString();
            }

            private void button9_Click(object sender, EventArgs e)
            {
                itemcount = 6;
                textBox5.Text = itemcount.ToString();
            }

            private void button14_Click(object sender, EventArgs e)
            {
                itemcount = 7;
                textBox5.Text = itemcount.ToString();
            }

            private void button13_Click(object sender, EventArgs e)
            {
                itemcount = 8;
                textBox5.Text = itemcount.ToString();
            }

            private void button12_Click(object sender, EventArgs e)
            {
                itemcount = 9;
                textBox5.Text = itemcount.ToString();
            }

            private void textBox5_TextChanged(object sender, EventArgs e)
            {
                itemcount = int.Parse(textBox5.Text);
            }

            private void button15_Click(object sender, EventArgs e)
            {
                type = button15.Text;
                textBox6.Text = type;
                AddMenuItemAtRow2("رقم الطلب: "+ GetMenuItemByRow(756)+"                            نوع الطلب: "+type,4 );
            }

            private void button16_Click(object sender, EventArgs e)
            {
                type = button16.Text;
                textBox6.Text = type;
                AddMenuItemAtRow2("رقم الطلب: "+ GetMenuItemByRow(756)+"                            نوع الطلب: "+type,4 );
            }

            private void AddItemToReceipt(int nameRow, int priceRow)
            {
                if (receiptitems < 10)
                {
                    int rowNumber = 7 + receiptitems;
                    AddMenuItemAtRow2(string.Format(" {0,-10}{1,8}{2,5}{3,11} دينار", GetMenuItemByRow(nameRow), GetMenuItemByRow(priceRow), itemcount, int.Parse(GetMenuItemByRow(priceRow)) * itemcount), rowNumber);
                    receiptitems++;
                    totalprice += int.Parse(GetMenuItemByRow(priceRow)) * itemcount;
                    AddMenuItemAtRow2(string.Format("المجموع: {0:N0} دينار                            الكاشير: {1}", totalprice, cashiername), 18);
                    AddMenuItemAtRow2("رقم الطلب: " + GetMenuItemByRow(756) + "                            نوع الطلب: " + type, 4);
                }
                else
                {
                    MessageBox.Show("الوصل ممتلئ");
                }
            }

        private void m1btn1_Click(object sender, EventArgs e) { AddItemToReceipt(34, 35); }
        private void m1btn2_Click(object sender, EventArgs e) { AddItemToReceipt(38, 39); }
        private void m1btn3_Click(object sender, EventArgs e) { AddItemToReceipt(42, 43); }
        private void m1btn4_Click(object sender, EventArgs e) { AddItemToReceipt(46, 47); }
        private void m1btn5_Click(object sender, EventArgs e) { AddItemToReceipt(50, 51); }
        private void m1btn6_Click(object sender, EventArgs e) { AddItemToReceipt(54, 55); }
        private void m1btn7_Click(object sender, EventArgs e) { AddItemToReceipt(58, 59); }
        private void m1btn8_Click(object sender, EventArgs e) { AddItemToReceipt(62, 63); }
        private void m1btn9_Click(object sender, EventArgs e) { AddItemToReceipt(66, 67); }
        private void m1btn10_Click(object sender, EventArgs e) { AddItemToReceipt(70, 71); }
        private void m1btn11_Click(object sender, EventArgs e) { AddItemToReceipt(74, 75); }
        private void m1btn12_Click(object sender, EventArgs e) { AddItemToReceipt(78, 79); }
        private void m1btn13_Click(object sender, EventArgs e) { AddItemToReceipt(82, 83); }
        private void m1btn14_Click(object sender, EventArgs e) { AddItemToReceipt(86, 87); }
        private void m1btn15_Click(object sender, EventArgs e) { AddItemToReceipt(90, 91); }
        private void m1btn16_Click(object sender, EventArgs e) { AddItemToReceipt(94, 95); }
        private void m1btn17_Click(object sender, EventArgs e) { AddItemToReceipt(98, 99); }
        private void m1btn18_Click(object sender, EventArgs e) { AddItemToReceipt(102, 103); }

        private void m2btn1_Click(object sender, EventArgs e) { AddItemToReceipt(106, 107); }
        private void m2btn2_Click(object sender, EventArgs e) { AddItemToReceipt(110, 111); }
        private void m2btn3_Click(object sender, EventArgs e) { AddItemToReceipt(114, 115); }
        private void m2btn4_Click(object sender, EventArgs e) { AddItemToReceipt(118, 119); }
        private void m2btn5_Click(object sender, EventArgs e) { AddItemToReceipt(122, 123); }
        private void m2btn6_Click(object sender, EventArgs e) { AddItemToReceipt(126, 127); }
        private void m2btn7_Click(object sender, EventArgs e) { AddItemToReceipt(130, 131); }
        private void m2btn8_Click(object sender, EventArgs e) { AddItemToReceipt(134, 135); }
        private void m2btn9_Click(object sender, EventArgs e) { AddItemToReceipt(138, 139); }
        private void m2btn10_Click(object sender, EventArgs e) { AddItemToReceipt(142, 143); }
        private void m2btn11_Click(object sender, EventArgs e) { AddItemToReceipt(146, 147); }
        private void m2btn12_Click(object sender, EventArgs e) { AddItemToReceipt(150, 151); }
        private void m2btn13_Click(object sender, EventArgs e) { AddItemToReceipt(154, 155); }
        private void m2btn14_Click(object sender, EventArgs e) { AddItemToReceipt(158, 159); }
        private void m2btn15_Click(object sender, EventArgs e) { AddItemToReceipt(162, 163); }
        private void m2btn16_Click(object sender, EventArgs e) { AddItemToReceipt(166, 167); }
        private void m2btn17_Click(object sender, EventArgs e) { AddItemToReceipt(170, 171); }
        private void m2btn18_Click(object sender, EventArgs e) { AddItemToReceipt(174, 175); }


        private void m3btn1_Click(object sender, EventArgs e) { AddItemToReceipt(178, 179); }
        private void m3btn2_Click_1(object sender, EventArgs e) { AddItemToReceipt(182, 183); }
        private void m3btn3_Click(object sender, EventArgs e) { AddItemToReceipt(186, 187); }
        private void m3btn4_Click(object sender, EventArgs e) { AddItemToReceipt(190, 191); }
        private void m3btn5_Click(object sender, EventArgs e) { AddItemToReceipt(194, 195); }
        private void m3btn6_Click(object sender, EventArgs e) { AddItemToReceipt(198, 199); }
        private void m3btn7_Click(object sender, EventArgs e) { AddItemToReceipt(202, 203); }
        private void m3btn8_Click(object sender, EventArgs e) { AddItemToReceipt(206, 207); }
        private void m3btn9_Click(object sender, EventArgs e) { AddItemToReceipt(210, 211); }
        private void m3btn10_Click(object sender, EventArgs e) { AddItemToReceipt(214, 215); }
        private void m3btn11_Click(object sender, EventArgs e) { AddItemToReceipt(218, 219); }
        private void m3btn12_Click(object sender, EventArgs e) { AddItemToReceipt(222, 223); }
        private void m3btn13_Click(object sender, EventArgs e) { AddItemToReceipt(226, 227); }
        private void m3btn14_Click(object sender, EventArgs e) { AddItemToReceipt(230, 231); }
        private void m3btn15_Click(object sender, EventArgs e) { AddItemToReceipt(234, 235); }
        private void m3btn16_Click(object sender, EventArgs e) { AddItemToReceipt(238, 239); }
        private void m3btn17_Click(object sender, EventArgs e) { AddItemToReceipt(242, 243); }
        private void m3btn18_Click(object sender, EventArgs e) { AddItemToReceipt(246, 247); }



        private void m4btn1_Click(object sender, EventArgs e) { AddItemToReceipt(250, 251); }
        private void m4btn2_Click(object sender, EventArgs e) { AddItemToReceipt(254, 255); }
        private void m4btn3_Click(object sender, EventArgs e) { AddItemToReceipt(258, 259); }
        private void m4btn4_Click(object sender, EventArgs e) { AddItemToReceipt(262, 263); }
        private void m4btn5_Click(object sender, EventArgs e) { AddItemToReceipt(266, 267); }
        private void m4btn6_Click(object sender, EventArgs e) { AddItemToReceipt(270, 271); }
        private void m4btn7_Click(object sender, EventArgs e) { AddItemToReceipt(274, 275); }
        private void m4btn8_Click(object sender, EventArgs e) { AddItemToReceipt(278, 279); }
        private void m4btn9_Click(object sender, EventArgs e) { AddItemToReceipt(282, 283); }
        private void m4btn10_Click(object sender, EventArgs e) { AddItemToReceipt(286, 287); }
        private void m4btn11_Click(object sender, EventArgs e) { AddItemToReceipt(290, 291); }
        private void m4btn12_Click(object sender, EventArgs e) { AddItemToReceipt(294, 295); }
        private void m4btn13_Click(object sender, EventArgs e) { AddItemToReceipt(298, 299); }
        private void m4btn14_Click(object sender, EventArgs e) { AddItemToReceipt(302, 303); }
        private void m4btn15_Click(object sender, EventArgs e) { AddItemToReceipt(306, 307); }
        private void m4btn16_Click(object sender, EventArgs e) { AddItemToReceipt(310, 311); }
        private void m4btn17_Click(object sender, EventArgs e) { AddItemToReceipt(314, 315); }
        private void m4btn18_Click(object sender, EventArgs e) { AddItemToReceipt(318, 319); }



        private void m5btn1_Click(object sender, EventArgs e) { AddItemToReceipt(322, 323); }
        private void m5btn2_Click(object sender, EventArgs e) { AddItemToReceipt(326, 327); }
        private void m5btn3_Click(object sender, EventArgs e) { AddItemToReceipt(330, 331); }
        private void m5btn4_Click(object sender, EventArgs e) { AddItemToReceipt(334, 335); }
        private void m5btn5_Click(object sender, EventArgs e) { AddItemToReceipt(338, 339); }
        private void m5btn6_Click(object sender, EventArgs e) { AddItemToReceipt(342, 343); }
        private void m5btn7_Click(object sender, EventArgs e) { AddItemToReceipt(346, 347); }
        private void m5btn8_Click(object sender, EventArgs e) { AddItemToReceipt(350, 351); }
        private void m5btn9_Click(object sender, EventArgs e) { AddItemToReceipt(354, 355); }
        private void m5btn10_Click(object sender, EventArgs e) { AddItemToReceipt(358, 359); }
        private void m5btn11_Click(object sender, EventArgs e) { AddItemToReceipt(362, 363); }
        private void m5btn12_Click(object sender, EventArgs e) { AddItemToReceipt(366, 367); }
        private void m5btn13_Click(object sender, EventArgs e) { AddItemToReceipt(370, 371); }
        private void m5btn14_Click(object sender, EventArgs e) { AddItemToReceipt(374, 375); }
        private void m5btn15_Click(object sender, EventArgs e) { AddItemToReceipt(378, 379); }
        private void m5btn16_Click(object sender, EventArgs e) { AddItemToReceipt(382, 383); }
        private void m5btn17_Click(object sender, EventArgs e) { AddItemToReceipt(386, 387); }
        private void m5btn18_Click(object sender, EventArgs e) { AddItemToReceipt(390, 391); }



        private void m6btn1_Click(object sender, EventArgs e) { AddItemToReceipt(394, 395); }
        private void m6btn2_Click(object sender, EventArgs e) { AddItemToReceipt(398, 399); }
        private void m6btn3_Click(object sender, EventArgs e) { AddItemToReceipt(402, 403); }
        private void m6btn4_Click(object sender, EventArgs e) { AddItemToReceipt(406, 407); }
        private void m6btn5_Click(object sender, EventArgs e) { AddItemToReceipt(410, 411); }
        private void m6btn6_Click(object sender, EventArgs e) { AddItemToReceipt(414, 415); }
        private void m6btn7_Click(object sender, EventArgs e) { AddItemToReceipt(418, 419); }
        private void m6btn8_Click(object sender, EventArgs e) { AddItemToReceipt(422, 423); }
        private void m6btn9_Click(object sender, EventArgs e) { AddItemToReceipt(426, 427); }
        private void m6btn10_Click(object sender, EventArgs e) { AddItemToReceipt(430, 431); }
        private void m6btn11_Click(object sender, EventArgs e) { AddItemToReceipt(434, 435); }
        private void m6btn12_Click(object sender, EventArgs e) { AddItemToReceipt(438, 439); }
        private void m6btn13_Click(object sender, EventArgs e) { AddItemToReceipt(442, 443); }
        private void m6btn14_Click(object sender, EventArgs e) { AddItemToReceipt(446, 447); }
        private void m6btn15_Click(object sender, EventArgs e) { AddItemToReceipt(450, 451); }
        private void m6btn16_Click(object sender, EventArgs e) { AddItemToReceipt(454, 455); }
        private void m6btn17_Click(object sender, EventArgs e) { AddItemToReceipt(458, 459); }
        private void m6btn18_Click(object sender, EventArgs e) { AddItemToReceipt(462, 463); }



        private void m7btn1_Click(object sender, EventArgs e) { AddItemToReceipt(466, 467); }
        private void m7btn2_Click(object sender, EventArgs e) { AddItemToReceipt(470, 471); }
        private void m7btn3_Click(object sender, EventArgs e) { AddItemToReceipt(474, 475); }
        private void m7btn4_Click(object sender, EventArgs e) { AddItemToReceipt(478, 479); }
        private void m7btn5_Click(object sender, EventArgs e) { AddItemToReceipt(482, 483); }
        private void m7btn6_Click(object sender, EventArgs e) { AddItemToReceipt(486, 487); }
        private void m7btn7_Click(object sender, EventArgs e) { AddItemToReceipt(490, 491); }
        private void m7btn8_Click(object sender, EventArgs e) { AddItemToReceipt(494, 495); }
        private void m7btn9_Click(object sender, EventArgs e) { AddItemToReceipt(498, 499); }
        private void m7btn10_Click(object sender, EventArgs e) { AddItemToReceipt(502, 503); }
        private void m7btn11_Click(object sender, EventArgs e) { AddItemToReceipt(506, 507); }
        private void m7btn12_Click(object sender, EventArgs e) { AddItemToReceipt(510, 511); }
        private void m7btn13_Click(object sender, EventArgs e) { AddItemToReceipt(514, 515); }
        private void m7btn14_Click(object sender, EventArgs e) { AddItemToReceipt(518, 519); }
        private void m7btn15_Click(object sender, EventArgs e) { AddItemToReceipt(522, 523); }
        private void m7btn16_Click(object sender, EventArgs e) { AddItemToReceipt(526, 527); }
        private void m7btn17_Click(object sender, EventArgs e) { AddItemToReceipt(530, 531); }
        private void m7btn18_Click(object sender, EventArgs e) { AddItemToReceipt(534, 535); }



            private void m8btn1_Click(object sender, EventArgs e) { AddItemToReceipt(538, 539); }
            private void m8btn2_Click(object sender, EventArgs e) { AddItemToReceipt(542, 543); }
            private void m8btn3_Click(object sender, EventArgs e) { AddItemToReceipt(546, 547); }
            private void m8btn4_Click(object sender, EventArgs e) { AddItemToReceipt(550, 551); }
            private void m8btn5_Click(object sender, EventArgs e) { AddItemToReceipt(554, 555); }
            private void m8btn6_Click(object sender, EventArgs e) { AddItemToReceipt(558, 559); }
            private void m8btn7_Click(object sender, EventArgs e) { AddItemToReceipt(562, 563); }
            private void m8btn8_Click(object sender, EventArgs e) { AddItemToReceipt(566, 567); }
            private void m8btn9_Click(object sender, EventArgs e) { AddItemToReceipt(570, 571); }
            private void m8btn10_Click(object sender, EventArgs e) { AddItemToReceipt(574, 575); }

            private void m8btn11_Click(object sender, EventArgs e) { AddItemToReceipt(578, 579); }
            private void m8btn12_Click(object sender, EventArgs e) { AddItemToReceipt(582, 583); }
            private void m8btn13_Click(object sender, EventArgs e) { AddItemToReceipt(586, 587); }
            private void m8btn14_Click(object sender, EventArgs e) { AddItemToReceipt(590, 591); }
            private void m8btn15_Click(object sender, EventArgs e) { AddItemToReceipt(594, 595); }
            private void m8btn16_Click(object sender, EventArgs e) { AddItemToReceipt(598, 599); }
            private void m8btn17_Click(object sender, EventArgs e) { AddItemToReceipt(602, 603); }
            private void m8btn18_Click(object sender, EventArgs e) { AddItemToReceipt(606, 607); }

            private void m9btn1_Click(object sender, EventArgs e) { AddItemToReceipt(610, 611); }
            private void m9btn2_Click(object sender, EventArgs e) { AddItemToReceipt(614, 615); }
            private void m9btn3_Click(object sender, EventArgs e) { AddItemToReceipt(618, 619); }
            private void m9btn4_Click(object sender, EventArgs e) { AddItemToReceipt(622, 623); }
            private void m9btn5_Click(object sender, EventArgs e) { AddItemToReceipt(626, 627); }
            private void m9btn6_Click(object sender, EventArgs e) { AddItemToReceipt(630, 631); }
            private void m9btn7_Click(object sender, EventArgs e) { AddItemToReceipt(634, 635); }
            private void m9btn8_Click(object sender, EventArgs e) { AddItemToReceipt(638, 639); }
            private void m9btn9_Click(object sender, EventArgs e) { AddItemToReceipt(642, 643); }
            private void m9btn10_Click(object sender, EventArgs e) { AddItemToReceipt(646, 647); }
            private void m9btn11_Click(object sender, EventArgs e) { AddItemToReceipt(650, 651); }
            private void m9btn12_Click(object sender, EventArgs e) { AddItemToReceipt(654, 655); }
            private void m9btn13_Click(object sender, EventArgs e) { AddItemToReceipt(658, 659); }
            private void m9btn14_Click(object sender, EventArgs e) { AddItemToReceipt(662, 663); }
            private void m9btn15_Click(object sender, EventArgs e) { AddItemToReceipt(666, 667); }
            private void m9btn16_Click(object sender, EventArgs e) { AddItemToReceipt(670, 671); }
            private void m9btn17_Click(object sender, EventArgs e) { AddItemToReceipt(674, 675); }
            private void m9btn18_Click(object sender, EventArgs e) { AddItemToReceipt(678, 679); }

            private void m10btn1_Click(object sender, EventArgs e) { AddItemToReceipt(682, 683); }
            private void m10btn2_Click(object sender, EventArgs e) { AddItemToReceipt(686, 687); }
            private void m10btn3_Click(object sender, EventArgs e) { AddItemToReceipt(690, 691); }
            private void m10btn4_Click(object sender, EventArgs e) { AddItemToReceipt(694, 695); }
            private void m10btn5_Click(object sender, EventArgs e) { AddItemToReceipt(698, 699); }
            private void m10btn6_Click(object sender, EventArgs e) { AddItemToReceipt(702, 703); }
            private void m10btn7_Click(object sender, EventArgs e) { AddItemToReceipt(706, 707); }
            private void m10btn8_Click(object sender, EventArgs e) { AddItemToReceipt(710, 711); }
            private void m10btn9_Click(object sender, EventArgs e) { AddItemToReceipt(714, 715); }
            private void m10btn10_Click(object sender, EventArgs e) { AddItemToReceipt(718, 719); }
            private void m10btn11_Click(object sender, EventArgs e) { AddItemToReceipt(722, 723); }
            private void m10btn12_Click(object sender, EventArgs e) { AddItemToReceipt(726, 727); }
            private void m10btn13_Click(object sender, EventArgs e) { AddItemToReceipt(730, 731); }
            private void m10btn14_Click(object sender, EventArgs e) { AddItemToReceipt(734, 735); }
            private void m10btn15_Click(object sender, EventArgs e) { AddItemToReceipt(738, 739); }
            private void m10btn16_Click(object sender, EventArgs e) { AddItemToReceipt(742, 743); }
            private void m10btn17_Click(object sender, EventArgs e) { AddItemToReceipt(746, 747); }
            private void m10btn18_Click(object sender, EventArgs e) { AddItemToReceipt(750, 751); }


            private void button17_Click(object sender, EventArgs e)
            {
                //db
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                decimal totalAmount = totalprice; 
                string cashierName = cashiername;
                if (totalprice != 0)
                {
                    InsertReceipt(date, totalAmount, cashierName);
                }

                int receiptNumber = int.Parse(GetMenuItemByRow(756)) + 1;
                AddMenuItemAtRow(receiptNumber.ToString(), 756);
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += new PrintPageEventHandler(PrintReceipt);
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
                
            }
            public void InsertReceipt(string date, decimal totalAmount, string cashierName)
            {
                string connectionString = @"Data Source=receipt_database.db;Version=3;";
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string insertQuery = @"
            INSERT INTO Receipts (Date, TotalAmount, CashierName) 
            VALUES (@Date, @TotalAmount, @CashierName)";

                    using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Date", date);
                        cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        cmd.Parameters.AddWithValue("@CashierName", cashierName);

                        cmd.ExecuteNonQuery();
                    }
                }

                // After adding the data, refresh the DataGridView and update the total sum
                LoadReceiptsWithFlexibleFilters(null, null, null); // You can call this with appropriate filters if needed
                UpdateTotalSumFromGrid(); // Recalculate the total sum based on the updated DataGridView
            }
            public void LoadReceiptsByMonth(int year, int month)
            {
                string connectionString = @"Data Source=receipt_database.db;Version=3;";
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
            SELECT * FROM Receipts
            WHERE strftime('%Y', Date) = @Year 
              AND strftime('%m', Date) = @Month";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Year", year.ToString());
                        cmd.Parameters.AddWithValue("@Month", month.ToString("D2")); // pads with 0

                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            private void PrintReceipt(object sender, PrintPageEventArgs e)
            {
                string receiptPath = Path.Combine(Application.StartupPath, "receipt.txt"); // Change to your actual file path
                if (File.Exists(receiptPath))
                {
                    string[] lines = File.ReadAllLines(receiptPath); // Read all lines into an array
                    Font printFont = new Font("Arial", 12);
                    float yPos = 10; // Starting position for printing
                    float lineHeight = printFont.GetHeight(e.Graphics);

                    foreach (string line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line)) // Ignore empty lines
                        {
                            e.Graphics.DrawString(line, printFont, Brushes.Black, new PointF(10, yPos));
                            yPos += lineHeight; // Move to the next line
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Receipt file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void button18_Click(object sender, EventArgs e)
            {
                printDocument.PrintPage += new PrintPageEventHandler(PrintReceipt);
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog(); // Show the preview dialog
            }

            private void button26_Click(object sender, EventArgs e)
            {
                AddMenuItemAtRow("1", 756);
                
            }

            private void button31_Click(object sender, EventArgs e)
            {
                
                  // Set the connection string
        string connectionString = @"Data Source=receipt_database.db;Version=3;";

        // Create a new SQLite connection
        using (SQLiteConnection conn = new SQLiteConnection(connectionString))
        {
            // Open the connection
            conn.Open();

            // Define a query to select data from the Receipts table
            string query = "SELECT * FROM Receipts";

            // Create a SQLiteDataAdapter to fill a DataTable
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, conn);

            // Create a DataTable to hold the retrieved data
            DataTable dataTable = new DataTable();

            // Fill the DataTable with data
            dataAdapter.Fill(dataTable);

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dataTable;

            // Close the connection
            conn.Close();
        }
        
        passpanel.Visible = true;
        passpanel.BringToFront();
    
            }

            private void button32_Click(object sender, EventArgs e)
            {
                dbpanel.Visible = false;
                settingspanel.Visible = true;
                settingspanel.BringToFront();
            }

            private void button33_Click(object sender, EventArgs e)
            {
                if (textBox7.Text == GetMenuItemByRow(758) || textBox7.Text == GetMenuItemByRow(759))
                {
                    passpanel.Visible = false;
                    settingspanel.Visible = false;
                    dbpanel.Visible = true;
                    dbpanel.BringToFront();
                    textBox7.Text = "";
                }
                else
                    MessageBox.Show("الرمز خطأ");
            }

            private void button34_Click(object sender, EventArgs e)
            {
                passpanel.Visible = false;
                settingspanel.Visible = true;
                settingspanel.BringToFront();
            }

            private void button35_Click(object sender, EventArgs e)
            {
                pwchangepanel.Visible = true;
                pwchangepanel.BringToFront();
            }

            private void button36_Click(object sender, EventArgs e)
            {
                pwchangepanel.Visible = false;
                settingspanel.Visible = true;
                settingspanel.BringToFront();
            }

            private void button37_Click(object sender, EventArgs e)
            {
                if (textBox8.Text == "" || textBox9.Text == "")
                {
                    MessageBox.Show("املأ الحقول");
                }
                else
                {
                    if (textBox8.Text == GetMenuItemByRow(758) || textBox8.Text == GetMenuItemByRow(759))
                    {
                        AddMenuItemAtRow(textBox9.Text, 758);
                        textBox8.Text = "";
                        textBox9.Text = "";
                        MessageBox.Show("تم تغيير الرمز");
                    }
                    else
                        MessageBox.Show("الرمز الحالي خاطئ");
                }
            }

            private void button4_Click_1(object sender, EventArgs e)
            {
                if (seccheckBox1.Checked)
                {
                    secbutton1.Visible = true; AddMenuItemAtRow(sectextBox1.Text, 1);
                    AddMenuItemAtRow("true", 2); secbutton1.Text = GetMenuItemByRow(1);
                }
                else
                {
                    secbutton1.Visible = false;
                    AddMenuItemAtRow("false", 2);
                }
                if (seccheckBox2.Checked)
                {
                    secbutton2.Visible = true;
                    AddMenuItemAtRow(sectextBox2.Text, 3);
                    AddMenuItemAtRow("true", 4);
                    secbutton2.Text = GetMenuItemByRow(3);
                }
                else
                {
                    secbutton2.Visible = false;
                    AddMenuItemAtRow("false", 4);
                }
                if (seccheckBox3.Checked)
                {
                    secbutton3.Visible = true;
                    AddMenuItemAtRow(sectextBox3.Text, 5);
                    AddMenuItemAtRow("true", 6);
                    secbutton3.Text = GetMenuItemByRow(5);
                }
                else
                {
                    secbutton3.Visible = false;
                    AddMenuItemAtRow("false", 6);
                }
                if (seccheckBox4.Checked)
                {
                    secbutton4.Visible = true;
                    AddMenuItemAtRow(sectextBox4.Text, 7);
                    AddMenuItemAtRow("true", 8);
                    secbutton4.Text = GetMenuItemByRow(7);
                }
                else
                {
                    secbutton4.Visible = false;
                    AddMenuItemAtRow("false", 8);
                }
                if (seccheckBox5.Checked)
                {
                    secbutton5.Visible = true; AddMenuItemAtRow(sectextBox5.Text, 9);
                    AddMenuItemAtRow("true", 10); secbutton5.Text = GetMenuItemByRow(9);
                }
                else
                {
                    secbutton5.Visible = false;
                    AddMenuItemAtRow("false", 10);
                }
                if (seccheckBox6.Checked)
                {
                    secbutton6.Visible = true;
                    AddMenuItemAtRow(sectextBox6.Text, 11);
                    AddMenuItemAtRow("true", 12);
                    secbutton6.Text = GetMenuItemByRow(11);
                }
                else
                {
                    secbutton6.Visible = false;
                    AddMenuItemAtRow("false", 12);
                }
                if (seccheckBox7.Checked)
                {
                    secbutton7.Visible = true;
                    AddMenuItemAtRow(sectextBox7.Text, 13);
                    AddMenuItemAtRow("true", 14);
                    secbutton7.Text = GetMenuItemByRow(13);
                }
                else
                {
                    secbutton7.Visible = false;
                    AddMenuItemAtRow("false", 14);
                }
                if (seccheckBox8.Checked)
                {
                    secbutton8.Visible = true; AddMenuItemAtRow(sectextBox8.Text, 15);
                    AddMenuItemAtRow("true", 16); secbutton8.Text = GetMenuItemByRow(15);
                }
                else
                {
                    secbutton8.Visible = false;
                    AddMenuItemAtRow("false", 16);
                }
                if (seccheckBox9.Checked)
                {
                    secbutton9.Visible = true; AddMenuItemAtRow(sectextBox9.Text, 25);
                    AddMenuItemAtRow("true", 26); secbutton9.Text = GetMenuItemByRow(25);
                }
                else
                {
                    secbutton9.Visible = false;
                    AddMenuItemAtRow("false", 26);
                }
                if (seccheckBox10.Checked)
                {
                    secbutton10.Visible = true; AddMenuItemAtRow(sectextBox10.Text, 27);
                    AddMenuItemAtRow("true", 28); secbutton10.Text = GetMenuItemByRow(27);
                }
                else
                {
                    secbutton10.Visible = false;
                    AddMenuItemAtRow("false", 28);
                }
                MessageBox.Show("تم التعديل");
            }


                //db sort
            private void LoadReceiptsWithFlexibleFilters(int? year, int? month, string cashierName)
            {
                string connectionString = @"Data Source=receipt_database.db;Version=3;";
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();

                    List<string> conditions = new List<string>();
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.Connection = conn;

                    if (year.HasValue)
                    {
                        conditions.Add("strftime('%Y', Date) = @Year");
                        cmd.Parameters.AddWithValue("@Year", year.Value.ToString());
                    }

                    if (month.HasValue)
                    {
                        conditions.Add("strftime('%m', Date) = @Month");
                        cmd.Parameters.AddWithValue("@Month", month.Value.ToString("D2"));
                    }

                    if (!string.IsNullOrWhiteSpace(cashierName))
                    {
                        conditions.Add("CashierName LIKE @CashierName");
                        cmd.Parameters.AddWithValue("@CashierName", "%" + cashierName + "%");
                    }

                    string whereClause = "";
                    if (conditions.Count > 0)
                    {
                        whereClause = "WHERE " + string.Join(" AND ", conditions.ToArray());
                    }

                    string query = "SELECT * FROM Receipts " + whereClause;
                    cmd.CommandText = query;

                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                       
                    }
                }
                UpdateTotalSumFromGrid();
            }
            private void LoadAllReceipts()
            {
                string connectionString = @"Data Source=receipt_database.db;Version=3;";
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Receipts";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                            UpdateTotalSumFromGrid(); // call here so it works immediately
                        }
                    }
                }
            }
            private void Filter_Changed(object sender, EventArgs e)
            {
                int year;
                bool isYearValid = int.TryParse(txtYearFilter.Text.Trim(), out year);
                int? selectedYear = isYearValid ? year : (int?)null;

                // Adjust for "All Months" at index 0
                int selectedIndex = comboBox3.SelectedIndex;
                int? month = (selectedIndex > 0) ? selectedIndex : (int?)null;

                string cashierName = textBox10.Text.Trim();

                // Load based on any combination of filters
                LoadReceiptsWithFlexibleFilters(selectedYear, month, cashierName);
            }



        //db totalamount sum

            private void UpdateTotalSumFromGrid()
            {
                double sum = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["TotalAmount"].Value != null)
                    {
                        double value;
                        if (double.TryParse(row.Cells["TotalAmount"].Value.ToString(), out value))
                        {
                            sum += value;
                        }
                    }
                }

                txtTotalSum.Text = sum.ToString("N0"); // Show 2 decimal places
            }

            private void button38_Click(object sender, EventArgs e)
            {
                if (txtTotalSum.Visible == false)
                {
                    txtTotalSum.Visible = true;
                    label35.Visible = true;
                    button38.Text="إخفاء المبيعات";
                }
                else
                {
                    txtTotalSum.Visible = false;
                    label35.Visible = false;
                    button38.Text = "إظهار المبيعات";
                }
            }
        //db delete option
            private void button39_Click(object sender, EventArgs e)
            {
                panel17.Visible = true;
                panel17.BringToFront();
            }



        private void DeleteReceiptsByYear(int year)
            {
    string connectionString = @"Data Source=receipt_database.db;Version=3;";
    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
    {
        conn.Open();
        string query = "DELETE FROM Receipts WHERE strftime('%Y', Date) = @Year";
        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@Year", year.ToString());
            cmd.ExecuteNonQuery();
        }
    }
        }



        private void DeleteReceiptsByMonthAndYear(int month, int year)
{
    string connectionString = @"Data Source=receipt_database.db;Version=3;";
    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
    {
        conn.Open();
        string query = @"
            DELETE FROM Receipts 
            WHERE strftime('%Y', Date) = @Year 
              AND strftime('%m', Date) = @Month";
        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@Year", year.ToString());
            cmd.Parameters.AddWithValue("@Month", month.ToString("D2"));
            cmd.ExecuteNonQuery();
        }
    }}

            private void btnDeleteReceipts_Click(object sender, EventArgs e)
            {
              string yearText = txtDeleteYear.Text.Trim();
    int year;

    if (!int.TryParse(yearText, out year))
    {
        MessageBox.Show("الرجاء إدخال سنة صحيحة.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }

    int selectedMonthIndex = cmbDeleteMonth.SelectedIndex;
    int? month = selectedMonthIndex != -1 ? selectedMonthIndex + 1 : (int?)null;

    if (!month.HasValue)
    {
        // No month selected, delete whole year
        if (MessageBox.Show("هل أنت متأكد أنك تريد حذف كل السجلات لسنة " + year + "؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            DeleteReceiptsByYear(year);
            LoadReceiptsWithFlexibleFilters(year, null, null);
        }
    }
    else
    {
        // Year + month selected
        if (MessageBox.Show("هل أنت متأكد أنك تريد حذف السجلات لشهر " + (month) + " من سنة " + year + "؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            DeleteReceiptsByMonthAndYear(month.Value, year);
            LoadReceiptsWithFlexibleFilters(year, month, null);
            MessageBox.Show("تم الحذف");
        }
    }

               

            }

            private void button40_Click(object sender, EventArgs e)
            {
                panel17.Visible = false;
            }

            private void button41_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("هل أنت متأكد أنك تريد حذف جميع السجلات وإعادة تعيين الرقم التسلسلي؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string connectionString = @"Data Source=receipt_database.db;Version=3;";

                    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                    {
                        conn.Open();

                        // Delete all records
                        string deleteQuery = "DELETE FROM Receipts";
                        using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        // Reset auto-increment ID
                        string resetQuery = "DELETE FROM sqlite_sequence WHERE name = 'Receipts'";
                        using (SQLiteCommand cmd = new SQLiteCommand(resetQuery, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Refresh the grid and total sum (with no filters)
                    LoadReceiptsWithFlexibleFilters(null, null, null);

                    MessageBox.Show("تم حذف جميع السجلات وإعادة تعيين الرقم التسلسلي.", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
            private void button43_Click(object sender, EventArgs e)
            {
                panel1.Visible = true;
                panel1.BringToFront();
            }

            private void button42_Click(object sender, EventArgs e)
            {
                panel18.Visible = true;
                panel18.BringToFront();
            }

            private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (comboBox4.SelectedIndex == 0)
                {
                    label21.Text = "١- اختر القائمة المناسبة من القوائم الجانبية.\n" +
                 "٢- اضغط على زر الصنف المطلوب، وسيُضاف مباشرة إلى الوصل مع السعر والكمية.\n" +
                 "٣- يمكنك تغيير الكمية من خلال أدوات التحكم، كما يمكنك إدخال اسم الكاشير واختيار نوع الطلب (محلي أو سفري).\n" +
                 "٤- بعد الانتهاء من الطلب، اضغط على زر طباعة لطباعة الوصل، وسيتم حفظ البيانات تلقائيًا في قاعدة البيانات مع التاريخ والوقت.";

                }
                if (comboBox4.SelectedIndex == 1)
                {
                    label21.Text = "لتعديل أسماء القوائم أو الأصناف (مثل تغيير بيبسي إلى كوكاكولا أو تعديل الأسعار)، قم بما يلي:\n" +
               "١- اضغط على زر الإعدادات ثم الأقسام لتعديل القوائم أو الوجبات لتعديل العناصر من الواجهة الرئيسية.\n" +
               "٢- ستظهر لك نافذة تحتوي على كل القوائم والأزرار المرتبطة بها.\n" +
               "٣- اختر الزر الذي تريد تعديله، يوجد ١٠ قوائم، وكل منها تحتوي على ١٨ زرًا للوجبات، ثم عدّل الاسم أو السعر حسب الحاجة.\n" +
               "٤- بعد الانتهاء من التعديلات، اضغط على حفظ، وسيتم حفظ التغييرات تلقائيًا في ملف الإعدادات.";
                }

                if (comboBox4.SelectedIndex == 2)
                {
                    label21.Text = "من خلال قسم البيانات يمكنك:\n" +
               "١- مراجعة الطلبات والمبيعات.\n" +
               "٢- حذف المبيعات حسب الشهر أو السنة.\n" +
               "٣- حذف قاعدة البيانات بالكامل لبدء استخدام جديد.";
                }

            }

            private void button44_Click(object sender, EventArgs e)
            {
                panel18.Visible = false;
            }

            public void btnCancelLastReceipt()

            {
                // Arabic confirmation message
                DialogResult result = MessageBox.Show("هل أنت متأكد أنك تريد حذف آخر طلب؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string connectionString = @"Data Source=receipt_database.db;Version=3;";
                        using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                        {
                            conn.Open();
                            string deleteQuery = "DELETE FROM Receipts WHERE rowid = (SELECT MAX(rowid) FROM Receipts)";

                            using (SQLiteCommand cmd = new SQLiteCommand(deleteQuery, conn))
                            {
                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("تم حذف آخر طلب بنجاح.", "تم الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                                }
                                else
                                {
                                    MessageBox.Show("لا توجد طلبات لحذفها.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("حدث خطأ أثناء الحذف: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    }
                }
                LoadReceiptsWithFlexibleFilters(null, null, null);
            }

            private void button45_Click(object sender, EventArgs e)
            {
                btnCancelLastReceipt();
            }

            private void button46_Click(object sender, EventArgs e)
            {
                panel20.Visible = true;
                panel20.BringToFront();
            }

            private void button47_Click(object sender, EventArgs e)
            {
                panel20.Visible = false;
            }

        


       

            

                   
                    
                
            

          

           





























        }
    }

