namespace ShopRite
{
    partial class StaffPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.barcodeText = new System.Windows.Forms.TextBox();
            this.quantityText = new System.Windows.Forms.TextBox();
            this.addtocart = new System.Windows.Forms.Button();
            this.preView = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.DataGridView();
            this.namee = new System.Windows.Forms.TextBox();
            this.Product = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(609, 233);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(494, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Barcode:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(483, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity:";
            // 
            // barcodeText
            // 
            this.barcodeText.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeText.Location = new System.Drawing.Point(619, 103);
            this.barcodeText.Margin = new System.Windows.Forms.Padding(2);
            this.barcodeText.Name = "barcodeText";
            this.barcodeText.Size = new System.Drawing.Size(102, 28);
            this.barcodeText.TabIndex = 4;
            this.barcodeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // quantityText
            // 
            this.quantityText.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityText.Location = new System.Drawing.Point(619, 143);
            this.quantityText.Margin = new System.Windows.Forms.Padding(2);
            this.quantityText.Name = "quantityText";
            this.quantityText.Size = new System.Drawing.Size(102, 28);
            this.quantityText.TabIndex = 5;
            this.quantityText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addtocart
            // 
            this.addtocart.BackColor = System.Drawing.Color.Red;
            this.addtocart.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtocart.ForeColor = System.Drawing.Color.White;
            this.addtocart.Location = new System.Drawing.Point(557, 291);
            this.addtocart.Margin = new System.Windows.Forms.Padding(2);
            this.addtocart.Name = "addtocart";
            this.addtocart.Size = new System.Drawing.Size(172, 46);
            this.addtocart.TabIndex = 6;
            this.addtocart.Text = "AddToCart";
            this.addtocart.UseVisualStyleBackColor = false;
            // 
            // preView
            // 
            this.preView.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preView.Location = new System.Drawing.Point(764, 327);
            this.preView.Margin = new System.Windows.Forms.Padding(2);
            this.preView.Name = "preView";
            this.preView.Size = new System.Drawing.Size(140, 46);
            this.preView.TabIndex = 7;
            this.preView.Text = "PreView";
            this.preView.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(213, 25);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 44);
            this.name.TabIndex = 10;
            // 
            // search
            // 
            this.search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.search.Location = new System.Drawing.Point(116, 90);
            this.search.Margin = new System.Windows.Forms.Padding(2);
            this.search.Name = "search";
            this.search.RowHeadersWidth = 51;
            this.search.RowTemplate.Height = 24;
            this.search.Size = new System.Drawing.Size(363, 276);
            this.search.TabIndex = 11;
            // 
            // namee
            // 
            this.namee.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namee.Location = new System.Drawing.Point(618, 182);
            this.namee.Margin = new System.Windows.Forms.Padding(2);
            this.namee.Name = "namee";
            this.namee.Size = new System.Drawing.Size(102, 28);
            this.namee.TabIndex = 13;
            this.namee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Product
            // 
            this.Product.AutoSize = true;
            this.Product.BackColor = System.Drawing.Color.Red;
            this.Product.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product.ForeColor = System.Drawing.Color.White;
            this.Product.Location = new System.Drawing.Point(496, 182);
            this.Product.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(118, 27);
            this.Product.TabIndex = 12;
            this.Product.Text = "Product:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(618, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // StaffPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::ShopRite.Properties.Resources.TZN75B2QRRALPGLAC332LQK5NA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 416);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.namee);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.search);
            this.Controls.Add(this.name);
            this.Controls.Add(this.preView);
            this.Controls.Add(this.addtocart);
            this.Controls.Add(this.quantityText);
            this.Controls.Add(this.barcodeText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StaffPage";
            this.Text = "Home page ";
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox barcodeText;
        private System.Windows.Forms.TextBox quantityText;
        private System.Windows.Forms.Button addtocart;
        private System.Windows.Forms.Button preView;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.DataGridView search;
        private System.Windows.Forms.TextBox namee;
        private System.Windows.Forms.Label Product;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}