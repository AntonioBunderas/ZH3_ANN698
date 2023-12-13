namespace ZH3_ANN698
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            telephoneBookBindingSource = new BindingSource(components);
            label1 = new Label();
            comboBox2 = new ComboBox();
            telephoneBookBindingSource1 = new BindingSource(components);
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)telephoneBookBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)telephoneBookBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 41);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            button2.Text = "Name";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 70);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 0;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 99);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 0;
            button4.Text = "Remove";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(93, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(695, 404);
            panel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.DataSource = telephoneBookBindingSource;
            comboBox1.DisplayMember = "PostalCodeId";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(93, 422);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.ValueMember = "PostalCodeId";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // telephoneBookBindingSource
            // 
            telephoneBookBindingSource.DataSource = typeof(Models.TelephoneBook);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 426);
            label1.Name = "label1";
            label1.Size = new Size(214, 15);
            label1.TabIndex = 3;
            label1.Text = "Quanity of Peoples On this Postal Code";
            // 
            // comboBox2
            // 
            comboBox2.DataSource = telephoneBookBindingSource1;
            comboBox2.DisplayMember = "Region";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 128);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(75, 23);
            comboBox2.TabIndex = 2;
            comboBox2.ValueMember = "Region";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // telephoneBookBindingSource1
            // 
            telephoneBookBindingSource1.DataSource = typeof(Models.TelephoneBook);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 165);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 4;
            label2.Text = "No/ppl:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)telephoneBookBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)telephoneBookBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private ComboBox comboBox1;
        private Label label1;
        private BindingSource telephoneBookBindingSource;
        private ComboBox comboBox2;
        private BindingSource telephoneBookBindingSource1;
        private Label label2;
    }
}