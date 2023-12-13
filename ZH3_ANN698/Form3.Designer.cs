namespace ZH3_ANN698
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            telephoneBookBindingSource = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            postalCodeBindingSource = new BindingSource(components);
            personIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sexDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            postalCodeIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            postalCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)telephoneBookBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)postalCodeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { personIdDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, regionDataGridViewTextBoxColumn, sexDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, postalCodeIdDataGridViewTextBoxColumn, postalCodeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = telephoneBookBindingSource;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 406);
            dataGridView1.TabIndex = 0;
            // 
            // telephoneBookBindingSource
            // 
            telephoneBookBindingSource.DataSource = typeof(Models.TelephoneBook);
            // 
            // button1
            // 
            button1.Location = new Point(12, 424);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 424);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 425);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 428);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 3;
            label1.Text = "Search by Name";
            // 
            // postalCodeBindingSource
            // 
            postalCodeBindingSource.DataSource = typeof(Models.PostalCode);
            // 
            // personIdDataGridViewTextBoxColumn
            // 
            personIdDataGridViewTextBoxColumn.DataPropertyName = "PersonId";
            personIdDataGridViewTextBoxColumn.HeaderText = "PersonId";
            personIdDataGridViewTextBoxColumn.Name = "personIdDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // regionDataGridViewTextBoxColumn
            // 
            regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            regionDataGridViewTextBoxColumn.HeaderText = "Region";
            regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // postalCodeIdDataGridViewTextBoxColumn
            // 
            postalCodeIdDataGridViewTextBoxColumn.DataPropertyName = "PostalCodeId";
            postalCodeIdDataGridViewTextBoxColumn.DataSource = postalCodeBindingSource;
            postalCodeIdDataGridViewTextBoxColumn.DisplayMember = "Code";
            postalCodeIdDataGridViewTextBoxColumn.HeaderText = "PostalCodeId";
            postalCodeIdDataGridViewTextBoxColumn.Name = "postalCodeIdDataGridViewTextBoxColumn";
            postalCodeIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            postalCodeIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            postalCodeIdDataGridViewTextBoxColumn.ValueMember = "PostalCodeId";
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
            postalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode";
            postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)telephoneBookBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)postalCodeBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource telephoneBookBindingSource;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn postalCodeIdDataGridViewTextBoxColumn;
        private BindingSource postalCodeBindingSource;
        private DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
    }
}