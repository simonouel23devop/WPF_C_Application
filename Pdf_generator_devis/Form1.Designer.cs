namespace Pdf_generator_devis
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
            Information = new TextBox();
            label2 = new Label();
            label3 = new Label();
            client = new TextBox();
            label4 = new Label();
            estimate = new TextBox();
            textBox1 = new TextBox();
            product = new Label();
            price = new Label();
            prix = new TextBox();
            Quantity = new Label();
            qty = new TextBox();
            generate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(264, 24);
            label1.Name = "label1";
            label1.Size = new Size(305, 46);
            label1.TabIndex = 0;
            label1.Text = "PDF generator v1.0";
            label1.Click += label1_Click;
            // 
            // Information
            // 
            Information.Location = new Point(42, 122);
            Information.Multiline = true;
            Information.Name = "Information";
            Information.Size = new Size(261, 117);
            Information.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 93);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 2;
            label2.Text = "Coordonates";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(492, 93);
            label3.Name = "label3";
            label3.Size = new Size(136, 20);
            label3.TabIndex = 4;
            label3.Text = "Client Coordonates";
            // 
            // client
            // 
            client.Location = new Point(487, 122);
            client.Multiline = true;
            client.Name = "client";
            client.Size = new Size(261, 117);
            client.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 289);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 5;
            label4.Text = "Estimate title";
            // 
            // estimate
            // 
            estimate.Location = new Point(42, 324);
            estimate.Name = "estimate";
            estimate.Size = new Size(440, 27);
            estimate.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 409);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 27);
            textBox1.TabIndex = 7;
            // 
            // product
            // 
            product.AutoSize = true;
            product.Location = new Point(42, 377);
            product.Name = "product";
            product.Size = new Size(101, 20);
            product.TabIndex = 8;
            product.Text = "Product name";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(308, 377);
            price.Name = "price";
            price.Size = new Size(41, 20);
            price.TabIndex = 10;
            price.Text = "Price";
            // 
            // prix
            // 
            prix.Location = new Point(308, 409);
            prix.Name = "prix";
            prix.Size = new Size(242, 27);
            prix.TabIndex = 9;
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Location = new Point(573, 377);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(65, 20);
            Quantity.TabIndex = 12;
            Quantity.Text = "Quantity";
            // 
            // qty
            // 
            qty.Location = new Point(573, 409);
            qty.Name = "qty";
            qty.Size = new Size(242, 27);
            qty.TabIndex = 11;
            // 
            // generate
            // 
            generate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 10);
            generate.ForeColor = SystemColors.HotTrack;
            generate.Location = new Point(324, 489);
            generate.Name = "generate";
            generate.Size = new Size(191, 57);
            generate.TabIndex = 13;
            generate.Text = "Generate !";
            generate.UseVisualStyleBackColor = true;
            generate.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(913, 604);
            Controls.Add(generate);
            Controls.Add(Quantity);
            Controls.Add(qty);
            Controls.Add(price);
            Controls.Add(prix);
            Controls.Add(product);
            Controls.Add(textBox1);
            Controls.Add(estimate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(client);
            Controls.Add(label2);
            Controls.Add(Information);
            Controls.Add(label1);
            ForeColor = SystemColors.HighlightText;
            Name = "Form1";
            Text = "PDF generator v1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Information;
        private Label label2;
        private Label label3;
        private TextBox client;
        private Label label4;
        private TextBox estimate;
        private TextBox textBox1;
        private Label product;
        private Label price;
        private TextBox prix;
        private Label Quantity;
        private TextBox qty;
        private Button generate;
    }
}
