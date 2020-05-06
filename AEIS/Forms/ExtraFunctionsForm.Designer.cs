namespace AEIS.Forms
{
    partial class ExtraFunctionsForm
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
            this.numericUpDownE = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownK = new System.Windows.Forms.NumericUpDown();
            this.labelMinEfficiency = new System.Windows.Forms.Label();
            this.labelResources = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelUsageEnd = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownE
            // 
            this.numericUpDownE.DecimalPlaces = 2;
            this.numericUpDownE.Location = new System.Drawing.Point(204, 33);
            this.numericUpDownE.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownE.Name = "numericUpDownE";
            this.numericUpDownE.Size = new System.Drawing.Size(128, 20);
            this.numericUpDownE.TabIndex = 15;
            // 
            // numericUpDownK
            // 
            this.numericUpDownK.DecimalPlaces = 2;
            this.numericUpDownK.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownK.Location = new System.Drawing.Point(204, 7);
            this.numericUpDownK.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownK.Name = "numericUpDownK";
            this.numericUpDownK.Size = new System.Drawing.Size(128, 20);
            this.numericUpDownK.TabIndex = 14;
            // 
            // labelMinEfficiency
            // 
            this.labelMinEfficiency.AutoSize = true;
            this.labelMinEfficiency.Location = new System.Drawing.Point(12, 35);
            this.labelMinEfficiency.Name = "labelMinEfficiency";
            this.labelMinEfficiency.Size = new System.Drawing.Size(186, 13);
            this.labelMinEfficiency.TabIndex = 13;
            this.labelMinEfficiency.Text = "Минимальная эффективность (E0):";
            // 
            // labelResources
            // 
            this.labelResources.AutoSize = true;
            this.labelResources.Location = new System.Drawing.Point(12, 9);
            this.labelResources.Name = "labelResources";
            this.labelResources.Size = new System.Drawing.Size(132, 13);
            this.labelResources.TabIndex = 12;
            this.labelResources.Text = "Остаточные ресурсы (k):";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy.MM.dd HH:mm:ss";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(204, 59);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(128, 20);
            this.dateTimePicker.TabIndex = 17;
            // 
            // labelUsageEnd
            // 
            this.labelUsageEnd.AutoSize = true;
            this.labelUsageEnd.Location = new System.Drawing.Point(12, 65);
            this.labelUsageEnd.Name = "labelUsageEnd";
            this.labelUsageEnd.Size = new System.Drawing.Size(146, 13);
            this.labelUsageEnd.TabIndex = 16;
            this.labelUsageEnd.Text = "Окончание использования:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Применить к графику";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExtraFunctionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 120);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelUsageEnd);
            this.Controls.Add(this.numericUpDownE);
            this.Controls.Add(this.numericUpDownK);
            this.Controls.Add(this.labelMinEfficiency);
            this.Controls.Add(this.labelResources);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExtraFunctionsForm";
            this.Text = "Дополнительные функции";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownE;
        private System.Windows.Forms.NumericUpDown numericUpDownK;
        private System.Windows.Forms.Label labelMinEfficiency;
        private System.Windows.Forms.Label labelResources;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelUsageEnd;
        private System.Windows.Forms.Button button1;
    }
}