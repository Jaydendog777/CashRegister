namespace CashRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.shopLabel = new System.Windows.Forms.Label();
            this.reciptLabel = new System.Windows.Forms.Label();
            this.rugbyBallCount = new System.Windows.Forms.Label();
            this.rugbyBallInput = new System.Windows.Forms.TextBox();
            this.rugbyCleatsLabel = new System.Windows.Forms.Label();
            this.rugbyCleatsInput = new System.Windows.Forms.TextBox();
            this.rugbyJerseyLabel = new System.Windows.Forms.Label();
            this.rugbyJerseyInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.reciptNameLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.pricesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shopLabel
            // 
            this.shopLabel.BackColor = System.Drawing.Color.Firebrick;
            this.shopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.shopLabel.Location = new System.Drawing.Point(0, -4);
            this.shopLabel.Name = "shopLabel";
            this.shopLabel.Size = new System.Drawing.Size(646, 52);
            this.shopLabel.TabIndex = 0;
            this.shopLabel.Text = "Rugby Shop";
            this.shopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reciptLabel
            // 
            this.reciptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reciptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptLabel.Location = new System.Drawing.Point(328, 61);
            this.reciptLabel.Name = "reciptLabel";
            this.reciptLabel.Size = new System.Drawing.Size(299, 458);
            this.reciptLabel.TabIndex = 1;
            // 
            // rugbyBallCount
            // 
            this.rugbyBallCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rugbyBallCount.Location = new System.Drawing.Point(1, 74);
            this.rugbyBallCount.Name = "rugbyBallCount";
            this.rugbyBallCount.Size = new System.Drawing.Size(211, 28);
            this.rugbyBallCount.TabIndex = 2;
            this.rugbyBallCount.Text = "# of Rugby Balls";
            this.rugbyBallCount.Click += new System.EventHandler(this.rugbyBallCount_Click);
            // 
            // rugbyBallInput
            // 
            this.rugbyBallInput.Location = new System.Drawing.Point(211, 79);
            this.rugbyBallInput.Name = "rugbyBallInput";
            this.rugbyBallInput.Size = new System.Drawing.Size(100, 22);
            this.rugbyBallInput.TabIndex = 3;
            // 
            // rugbyCleatsLabel
            // 
            this.rugbyCleatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rugbyCleatsLabel.Location = new System.Drawing.Point(1, 121);
            this.rugbyCleatsLabel.Name = "rugbyCleatsLabel";
            this.rugbyCleatsLabel.Size = new System.Drawing.Size(203, 28);
            this.rugbyCleatsLabel.TabIndex = 4;
            this.rugbyCleatsLabel.Text = "# of Pairs of Cleats";
            // 
            // rugbyCleatsInput
            // 
            this.rugbyCleatsInput.Location = new System.Drawing.Point(211, 125);
            this.rugbyCleatsInput.Name = "rugbyCleatsInput";
            this.rugbyCleatsInput.Size = new System.Drawing.Size(100, 22);
            this.rugbyCleatsInput.TabIndex = 5;
            // 
            // rugbyJerseyLabel
            // 
            this.rugbyJerseyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rugbyJerseyLabel.Location = new System.Drawing.Point(1, 163);
            this.rugbyJerseyLabel.Name = "rugbyJerseyLabel";
            this.rugbyJerseyLabel.Size = new System.Drawing.Size(203, 28);
            this.rugbyJerseyLabel.TabIndex = 6;
            this.rugbyJerseyLabel.Text = "# of Jerseys";
            // 
            // rugbyJerseyInput
            // 
            this.rugbyJerseyInput.Location = new System.Drawing.Point(211, 167);
            this.rugbyJerseyInput.Name = "rugbyJerseyInput";
            this.rugbyJerseyInput.Size = new System.Drawing.Size(100, 22);
            this.rugbyJerseyInput.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(67, 210);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(157, 48);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate Total";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(1, 273);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(126, 28);
            this.subtotalLabel.TabIndex = 9;
            this.subtotalLabel.Text = "Subtotal";
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutput.Location = new System.Drawing.Point(105, 273);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(217, 28);
            this.subtotalOutput.TabIndex = 10;
            this.subtotalOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // taxLabel
            // 
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(1, 301);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(126, 28);
            this.taxLabel.TabIndex = 11;
            this.taxLabel.Text = "Tax";
            // 
            // taxOutput
            // 
            this.taxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(110, 301);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(212, 28);
            this.taxOutput.TabIndex = 12;
            this.taxOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(1, 329);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(126, 28);
            this.totalLabel.TabIndex = 13;
            this.totalLabel.Text = "Total";
            // 
            // totalOutput
            // 
            this.totalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(100, 329);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(222, 28);
            this.totalOutput.TabIndex = 14;
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(1, 380);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(126, 28);
            this.tenderedLabel.TabIndex = 15;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(211, 386);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(100, 22);
            this.tenderedInput.TabIndex = 16;
            // 
            // changeButton
            // 
            this.changeButton.Enabled = false;
            this.changeButton.Location = new System.Drawing.Point(67, 428);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(157, 48);
            this.changeButton.TabIndex = 17;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(1, 491);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(126, 28);
            this.changeLabel.TabIndex = 18;
            this.changeLabel.Text = "Change";
            // 
            // changeOutput
            // 
            this.changeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(95, 491);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(227, 28);
            this.changeOutput.TabIndex = 19;
            this.changeOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // printButton
            // 
            this.printButton.Enabled = false;
            this.printButton.Location = new System.Drawing.Point(67, 535);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(157, 48);
            this.printButton.TabIndex = 20;
            this.printButton.Text = "Print Recipt";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // reciptNameLabel
            // 
            this.reciptNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptNameLabel.Location = new System.Drawing.Point(386, 75);
            this.reciptNameLabel.Name = "reciptNameLabel";
            this.reciptNameLabel.Size = new System.Drawing.Size(188, 28);
            this.reciptNameLabel.TabIndex = 21;
            this.reciptNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(498, 535);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(129, 48);
            this.newOrderButton.TabIndex = 22;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // pricesButton
            // 
            this.pricesButton.Location = new System.Drawing.Point(328, 535);
            this.pricesButton.Name = "pricesButton";
            this.pricesButton.Size = new System.Drawing.Size(136, 48);
            this.pricesButton.TabIndex = 23;
            this.pricesButton.Text = "Prices";
            this.pricesButton.UseVisualStyleBackColor = true;
            this.pricesButton.Click += new System.EventHandler(this.pricesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 595);
            this.Controls.Add(this.pricesButton);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.reciptNameLabel);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.rugbyJerseyInput);
            this.Controls.Add(this.rugbyJerseyLabel);
            this.Controls.Add(this.rugbyCleatsInput);
            this.Controls.Add(this.rugbyCleatsLabel);
            this.Controls.Add(this.rugbyBallInput);
            this.Controls.Add(this.rugbyBallCount);
            this.Controls.Add(this.reciptLabel);
            this.Controls.Add(this.shopLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RugbyShop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shopLabel;
        private System.Windows.Forms.Label reciptLabel;
        private System.Windows.Forms.Label rugbyBallCount;
        private System.Windows.Forms.TextBox rugbyBallInput;
        private System.Windows.Forms.Label rugbyCleatsLabel;
        private System.Windows.Forms.TextBox rugbyCleatsInput;
        private System.Windows.Forms.Label rugbyJerseyLabel;
        private System.Windows.Forms.TextBox rugbyJerseyInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label reciptNameLabel;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button pricesButton;
    }
}

