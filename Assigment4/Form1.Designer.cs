namespace Assigment4
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbl_number = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_object_name = new System.Windows.Forms.Label();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.text_ObjectName = new System.Windows.Forms.TextBox();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.lbl_number.Location = new System.Drawing.Point(59, 215);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(141, 39);
            this.lbl_number.TabIndex = 0;
            this.lbl_number.Text = "Number";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.lbl_Date.Location = new System.Drawing.Point(771, 215);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(90, 39);
            this.lbl_Date.TabIndex = 1;
            this.lbl_Date.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(697, 277);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 22);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbl_object_name
            // 
            this.lbl_object_name.AutoSize = true;
            this.lbl_object_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.lbl_object_name.Location = new System.Drawing.Point(17, 52);
            this.lbl_object_name.Name = "lbl_object_name";
            this.lbl_object_name.Size = new System.Drawing.Size(220, 39);
            this.lbl_object_name.TabIndex = 3;
            this.lbl_object_name.Text = "Object Name";
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(80, 277);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(120, 22);
            this.txt_Number.TabIndex = 4;
            // 
            // text_ObjectName
            // 
            this.text_ObjectName.Location = new System.Drawing.Point(24, 130);
            this.text_ObjectName.Name = "text_ObjectName";
            this.text_ObjectName.Size = new System.Drawing.Size(217, 22);
            this.text_ObjectName.TabIndex = 5;
            this.text_ObjectName.TextChanged += new System.EventHandler(this.text_ObjectName_TextChanged);
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.lbl_Count.Location = new System.Drawing.Point(431, 76);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(109, 39);
            this.lbl_Count.TabIndex = 6;
            this.lbl_Count.Text = "Count";
            // 
            // txt_Count
            // 
            this.txt_Count.Location = new System.Drawing.Point(438, 130);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(100, 22);
            this.txt_Count.TabIndex = 7;
            this.txt_Count.TextChanged += new System.EventHandler(this.txt_Count_TextChanged);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(460, 277);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 22);
            this.txt_price.TabIndex = 8;
            this.txt_price.TextChanged += new System.EventHandler(this.txt_price_TextChanged);
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.lbl_Price.Location = new System.Drawing.Point(463, 190);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(97, 39);
            this.lbl_Price.TabIndex = 9;
            this.lbl_Price.Text = "Price";
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.btn_Add.Location = new System.Drawing.Point(121, 380);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(116, 46);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.btn_Cancel.Location = new System.Drawing.Point(484, 380);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(162, 46);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F);
            this.label1.Location = new System.Drawing.Point(759, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Inventory Unit";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(807, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 22);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 448);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1113, 306);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 752);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_Count);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.text_ObjectName);
            this.Controls.Add(this.txt_Number);
            this.Controls.Add(this.lbl_object_name);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_number);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_object_name;
        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.TextBox text_ObjectName;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.TextBox txt_Count;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

