namespace GUI_Module
{
    partial class Home
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
        private void InitializeComponent1()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backOfHouseGUIControl11 = new GUI_Module.backOfHouseGUIControl1();
            this.frontOfHouseControl11 = new GUI_Module.frontOfHouseControl1();
            this.inventoryControl11 = new GUI_Module.inventoryControl1();
            this.dishesControl11 = new GUI_Module.dishesControl1();
            this.homeControl1 = new GUI_Module.homeControl1();
            this.KitchenControl = new GUI_Module.KitchenControl();
            this.contactUsControl11 = new GUI_Module.contactUsControl1();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(2, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(880, 47);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Restaurant Management System";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.SidePanel);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(2, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 548);
            this.panel2.TabIndex = 8;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SidePanel.Location = new System.Drawing.Point(4, 9);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(18, 40);
            this.SidePanel.TabIndex = 14;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button10.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button10.Location = new System.Drawing.Point(0, 318);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(203, 52);
            this.button10.TabIndex = 13;
            this.button10.Text = "Contact Us";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(10, 452);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 85);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button9.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button9.Location = new System.Drawing.Point(0, 266);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(203, 52);
            this.button9.TabIndex = 12;
            this.button9.Text = "Back of House";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button8.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button8.Location = new System.Drawing.Point(0, 214);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(203, 52);
            this.button8.TabIndex = 11;
            this.button8.Text = "Front of House";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button7.Location = new System.Drawing.Point(0, 162);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(203, 52);
            this.button7.TabIndex = 11;
            this.button7.Text = "Inventory";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button6.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button6.Location = new System.Drawing.Point(0, 56);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(203, 52);
            this.button6.TabIndex = 10;
            this.button6.Text = "Kitchen";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button5.Location = new System.Drawing.Point(0, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(203, 52);
            this.button5.TabIndex = 9;
            this.button5.Text = "Home";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(0, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 52);
            this.button1.TabIndex = 15;
            this.button1.Text = "Dishes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 40);
            this.label1.TabIndex = 16;
            this.label1.Text = "Restaurant Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // backOfHouseGUIControl11
            // 
            this.backOfHouseGUIControl11.BackColor = System.Drawing.Color.Pink;
            this.backOfHouseGUIControl11.Location = new System.Drawing.Point(212, 52);
            this.backOfHouseGUIControl11.Name = "backOfHouseGUIControl11";
            this.backOfHouseGUIControl11.Size = new System.Drawing.Size(670, 548);
            this.backOfHouseGUIControl11.TabIndex = 21;
            this.backOfHouseGUIControl11.Load += new System.EventHandler(this.backOfHouseGUIControl11_Load);
            // 
            // frontOfHouseControl11
            // 
            this.frontOfHouseControl11.BackColor = System.Drawing.Color.Pink;
            this.frontOfHouseControl11.Location = new System.Drawing.Point(212, 52);
            this.frontOfHouseControl11.Name = "frontOfHouseControl11";
            this.frontOfHouseControl11.Size = new System.Drawing.Size(670, 548);
            this.frontOfHouseControl11.TabIndex = 20;
            this.frontOfHouseControl11.Load += new System.EventHandler(this.frontOfHouseControl11_Load);
            // 
            // inventoryControl11
            // 
            this.inventoryControl11.BackColor = System.Drawing.Color.Pink;
            this.inventoryControl11.Location = new System.Drawing.Point(211, 52);
            this.inventoryControl11.Name = "inventoryControl11";
            this.inventoryControl11.Size = new System.Drawing.Size(670, 548);
            this.inventoryControl11.TabIndex = 19;
            this.inventoryControl11.Load += new System.EventHandler(this.inventoryControl11_Load);
            // 
            // dishesControl11
            // 
            this.dishesControl11.BackColor = System.Drawing.Color.Pink;
            this.dishesControl11.Location = new System.Drawing.Point(211, 52);
            this.dishesControl11.Name = "dishesControl11";
            this.dishesControl11.Size = new System.Drawing.Size(670, 548);
            this.dishesControl11.TabIndex = 18;
            this.dishesControl11.Load += new System.EventHandler(this.dishesControl11_Load);
            // 
            // homeControl1
            // 
            this.homeControl1.BackColor = System.Drawing.Color.Pink;
            this.homeControl1.Location = new System.Drawing.Point(211, 52);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(670, 548);
            this.homeControl1.TabIndex = 17;
            this.homeControl1.Load += new System.EventHandler(this.homeControl1_Load_1);
            // 
            // KitchenControl
            // 
            this.KitchenControl.BackColor = System.Drawing.Color.Pink;
            this.KitchenControl.Location = new System.Drawing.Point(211, 52);
            this.KitchenControl.Name = "KitchenControl";
            this.KitchenControl.Size = new System.Drawing.Size(670, 548);
            this.KitchenControl.TabIndex = 15;
            this.KitchenControl.Load += new System.EventHandler(this.kitchenControl1_Load);
            // 
            // contactUsControl11
            // 
            this.contactUsControl11.BackColor = System.Drawing.Color.Pink;
            this.contactUsControl11.Location = new System.Drawing.Point(211, 52);
            this.contactUsControl11.Name = "contactUsControl11";
            this.contactUsControl11.Size = new System.Drawing.Size(670, 548);
            this.contactUsControl11.TabIndex = 22;
            this.contactUsControl11.Load += new System.EventHandler(this.contactUsControl11_Load);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(880, 601);
            this.Controls.Add(this.contactUsControl11);
            this.Controls.Add(this.backOfHouseGUIControl11);
            this.Controls.Add(this.frontOfHouseControl11);
            this.Controls.Add(this.inventoryControl11);
            this.Controls.Add(this.dishesControl11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.homeControl1);
            this.Controls.Add(this.KitchenControl);
            this.Name = "Home";
            this.Text = "RMS";
            this.Load += new System.EventHandler(this.RMS_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel SidePanel;
        private KitchenControl KitchenControl;
        private System.Windows.Forms.Label label1;
        private homeControl1 homeControl1;
        private System.Windows.Forms.Button button1;
        private dishesControl1 dishesControl11;
        private inventoryControl1 inventoryControl11;
        private frontOfHouseControl1 frontOfHouseControl11;
        private backOfHouseGUIControl1 backOfHouseGUIControl11;
        private contactUsControl1 contactUsControl11;
    }
}