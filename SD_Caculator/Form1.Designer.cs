namespace Math_Deviations
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblDeviation = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.lblDeviationDisplay = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblVariationDisplay = new System.Windows.Forms.Label();
            this.lblCountDisplay = new System.Windows.Forms.Label();
            this.lblVariance = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Vani", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(162, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(411, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Standard Deviation from a Dataset";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Vani", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(657, 238);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(53, 29);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Font = new System.Drawing.Font("Vani", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(570, 286);
            this.lblCount.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(56, 25);
            this.lblCount.TabIndex = 5;
            this.lblCount.Text = "Count";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.BackColor = System.Drawing.Color.Transparent;
            this.lblInstructions.Font = new System.Drawing.Font("Vani", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(580, 158);
            this.lblInstructions.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(134, 75);
            this.lblInstructions.TabIndex = 9;
            this.lblInstructions.Text = "Enter numbers and press add to fill dataset";
            // 
            // lblDeviation
            // 
            this.lblDeviation.AutoSize = true;
            this.lblDeviation.BackColor = System.Drawing.Color.Transparent;
            this.lblDeviation.Font = new System.Drawing.Font("Vani", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviation.Location = new System.Drawing.Point(467, 403);
            this.lblDeviation.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblDeviation.Name = "lblDeviation";
            this.lblDeviation.Size = new System.Drawing.Size(101, 25);
            this.lblDeviation.TabIndex = 10;
            this.lblDeviation.Text = "Deviation = ";
            // 
            // txtAdd
            // 
            this.txtAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdd.Font = new System.Drawing.Font("Vani", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd.Location = new System.Drawing.Point(570, 235);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(78, 34);
            this.txtAdd.TabIndex = 0;
            // 
            // lblDeviationDisplay
            // 
            this.lblDeviationDisplay.AutoSize = true;
            this.lblDeviationDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblDeviationDisplay.Font = new System.Drawing.Font("Vani", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviationDisplay.Location = new System.Drawing.Point(570, 402);
            this.lblDeviationDisplay.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblDeviationDisplay.Name = "lblDeviationDisplay";
            this.lblDeviationDisplay.Size = new System.Drawing.Size(54, 34);
            this.lblDeviationDisplay.TabIndex = 12;
            this.lblDeviationDisplay.Text = "###";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculate.Font = new System.Drawing.Font("Vani", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(521, 323);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(98, 33);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblVariationDisplay
            // 
            this.lblVariationDisplay.AutoSize = true;
            this.lblVariationDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblVariationDisplay.Font = new System.Drawing.Font("Vani", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariationDisplay.Location = new System.Drawing.Point(570, 366);
            this.lblVariationDisplay.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblVariationDisplay.Name = "lblVariationDisplay";
            this.lblVariationDisplay.Size = new System.Drawing.Size(54, 34);
            this.lblVariationDisplay.TabIndex = 11;
            this.lblVariationDisplay.Text = "###";
            // 
            // lblCountDisplay
            // 
            this.lblCountDisplay.AutoSize = true;
            this.lblCountDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblCountDisplay.Font = new System.Drawing.Font("Vani", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDisplay.Location = new System.Drawing.Point(654, 281);
            this.lblCountDisplay.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblCountDisplay.Name = "lblCountDisplay";
            this.lblCountDisplay.Size = new System.Drawing.Size(54, 34);
            this.lblCountDisplay.TabIndex = 13;
            this.lblCountDisplay.Text = "###";
            // 
            // lblVariance
            // 
            this.lblVariance.AutoSize = true;
            this.lblVariance.BackColor = System.Drawing.Color.Transparent;
            this.lblVariance.Font = new System.Drawing.Font("Vani", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariance.Location = new System.Drawing.Point(474, 366);
            this.lblVariance.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblVariance.Name = "lblVariance";
            this.lblVariance.Size = new System.Drawing.Size(94, 25);
            this.lblVariance.TabIndex = 14;
            this.lblVariance.Text = "Variance = ";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoad.Font = new System.Drawing.Font("Vani", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(616, 111);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLoad.Size = new System.Drawing.Size(87, 29);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Vani", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(607, 54);
            this.label1.MaximumSize = new System.Drawing.Size(150, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.label1.Size = new System.Drawing.Size(116, 54);
            this.label1.TabIndex = 17;
            this.label1.Text = "Load dataset from file";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Vani", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(635, 323);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 33);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Vani", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 403);
            this.label2.MaximumSize = new System.Drawing.Size(150, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Standard";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 462);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblVariance);
            this.Controls.Add(this.lblCountDisplay);
            this.Controls.Add(this.lblDeviationDisplay);
            this.Controls.Add(this.lblVariationDisplay);
            this.Controls.Add(this.lblDeviation);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(756, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(756, 500);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Standard Deviation Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblDeviation;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label lblDeviationDisplay;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblVariationDisplay;
        private System.Windows.Forms.Label lblCountDisplay;
        private System.Windows.Forms.Label lblVariance;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
    }
}

