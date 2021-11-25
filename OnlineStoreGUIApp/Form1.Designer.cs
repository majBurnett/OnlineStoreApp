namespace OnlineStoreGUIApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_findproduct = new System.Windows.Forms.Button();
            this.btn_updatelist = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rb_showselectedItem = new System.Windows.Forms.RadioButton();
            this.btn_sellproduct = new System.Windows.Forms.Button();
            this.btn_createproduct = new System.Windows.Forms.Button();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.txt_Type = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_inventoryList = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lst_findList = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lst_soldList = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_findproduct);
            this.groupBox1.Controls.Add(this.btn_updatelist);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rb_showselectedItem);
            this.groupBox1.Controls.Add(this.btn_sellproduct);
            this.groupBox1.Controls.Add(this.btn_createproduct);
            this.groupBox1.Controls.Add(this.txt_Amount);
            this.groupBox1.Controls.Add(this.txt_Price);
            this.groupBox1.Controls.Add(this.txt_Model);
            this.groupBox1.Controls.Add(this.txt_Type);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 355);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a Product";
            // 
            // btn_findproduct
            // 
            this.btn_findproduct.Location = new System.Drawing.Point(55, 222);
            this.btn_findproduct.Name = "btn_findproduct";
            this.btn_findproduct.Size = new System.Drawing.Size(97, 23);
            this.btn_findproduct.TabIndex = 11;
            this.btn_findproduct.Text = "Find Product";
            this.btn_findproduct.UseVisualStyleBackColor = true;
            this.btn_findproduct.Click += new System.EventHandler(this.btn_findproduct_Click);
            // 
            // btn_updatelist
            // 
            this.btn_updatelist.Location = new System.Drawing.Point(55, 193);
            this.btn_updatelist.Name = "btn_updatelist";
            this.btn_updatelist.Size = new System.Drawing.Size(97, 23);
            this.btn_updatelist.TabIndex = 7;
            this.btn_updatelist.Text = "Update List";
            this.btn_updatelist.UseVisualStyleBackColor = true;
            this.btn_updatelist.Click += new System.EventHandler(this.btn_updatelist_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 124);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(84, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Add Product";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // rb_showselectedItem
            // 
            this.rb_showselectedItem.AutoSize = true;
            this.rb_showselectedItem.Location = new System.Drawing.Point(10, 141);
            this.rb_showselectedItem.Name = "rb_showselectedItem";
            this.rb_showselectedItem.Size = new System.Drawing.Size(117, 17);
            this.rb_showselectedItem.TabIndex = 9;
            this.rb_showselectedItem.TabStop = true;
            this.rb_showselectedItem.Text = "View Specific Items";
            this.rb_showselectedItem.UseVisualStyleBackColor = true;
            this.rb_showselectedItem.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btn_sellproduct
            // 
            this.btn_sellproduct.Location = new System.Drawing.Point(55, 251);
            this.btn_sellproduct.Name = "btn_sellproduct";
            this.btn_sellproduct.Size = new System.Drawing.Size(97, 23);
            this.btn_sellproduct.TabIndex = 2;
            this.btn_sellproduct.Text = "Sell Product";
            this.btn_sellproduct.UseVisualStyleBackColor = true;
            this.btn_sellproduct.Click += new System.EventHandler(this.btn_sellproduct_Click);
            // 
            // btn_createproduct
            // 
            this.btn_createproduct.Location = new System.Drawing.Point(55, 164);
            this.btn_createproduct.Name = "btn_createproduct";
            this.btn_createproduct.Size = new System.Drawing.Size(97, 23);
            this.btn_createproduct.TabIndex = 8;
            this.btn_createproduct.Text = "Create a product";
            this.btn_createproduct.UseVisualStyleBackColor = true;
            this.btn_createproduct.Click += new System.EventHandler(this.btn_createproduct_Click);
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(55, 98);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(100, 20);
            this.txt_Amount.TabIndex = 7;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(55, 72);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(100, 20);
            this.txt_Price.TabIndex = 6;
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(55, 46);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(100, 20);
            this.txt_Model.TabIndex = 5;
            // 
            // txt_Type
            // 
            this.txt_Type.Location = new System.Drawing.Point(55, 20);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(100, 20);
            this.txt_Type.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_inventoryList);
            this.groupBox2.Location = new System.Drawing.Point(234, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Inventory";
            // 
            // lst_inventoryList
            // 
            this.lst_inventoryList.FormattingEnabled = true;
            this.lst_inventoryList.Location = new System.Drawing.Point(6, 20);
            this.lst_inventoryList.Name = "lst_inventoryList";
            this.lst_inventoryList.Size = new System.Drawing.Size(240, 394);
            this.lst_inventoryList.TabIndex = 0;
            this.lst_inventoryList.SelectedIndexChanged += new System.EventHandler(this.lst_inventoryList_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lst_findList);
            this.groupBox3.Location = new System.Drawing.Point(492, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 425);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Find Inventory";
            // 
            // lst_findList
            // 
            this.lst_findList.FormattingEnabled = true;
            this.lst_findList.Location = new System.Drawing.Point(6, 20);
            this.lst_findList.Name = "lst_findList";
            this.lst_findList.Size = new System.Drawing.Size(239, 394);
            this.lst_findList.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lst_soldList);
            this.groupBox4.Location = new System.Drawing.Point(749, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 425);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "In Stock";
            // 
            // lst_soldList
            // 
            this.lst_soldList.FormattingEnabled = true;
            this.lst_soldList.Location = new System.Drawing.Point(6, 19);
            this.lst_soldList.Name = "lst_soldList";
            this.lst_soldList.Size = new System.Drawing.Size(240, 394);
            this.lst_soldList.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 670);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.TextBox txt_Type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_createproduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_inventoryList;
        private System.Windows.Forms.Button btn_sellproduct;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lst_findList;
        private System.Windows.Forms.Button btn_updatelist;
        private System.Windows.Forms.RadioButton rb_showselectedItem;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btn_findproduct;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lst_soldList;
    }
}

