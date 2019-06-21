namespace AminatK
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.hard = new System.Windows.Forms.Label();
            this.Pump = new System.Windows.Forms.Label();
            this.Presure = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hardTextBox = new System.Windows.Forms.TextBox();
            this.pressureTextBox = new System.Windows.Forms.TextBox();
            this.PKX = new System.Windows.Forms.Label();
            this.flowTextBox = new System.Windows.Forms.TextBox();
            this.mixOut = new System.Windows.Forms.Label();
            this.nCount = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hard
            // 
            this.hard.AutoSize = true;
            this.hard.Location = new System.Drawing.Point(12, 22);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(67, 26);
            this.hard.TabIndex = 0;
            this.hard.Text = "Жесткость,\r\n мг-экв/л";
            // 
            // Pump
            // 
            this.Pump.AutoSize = true;
            this.Pump.Location = new System.Drawing.Point(278, 22);
            this.Pump.Name = "Pump";
            this.Pump.Size = new System.Drawing.Size(39, 13);
            this.Pump.TabIndex = 0;
            this.Pump.Text = "Насос";
            // 
            // Presure
            // 
            this.Presure.AutoSize = true;
            this.Presure.Location = new System.Drawing.Point(120, 22);
            this.Presure.Name = "Presure";
            this.Presure.Size = new System.Drawing.Size(123, 13);
            this.Presure.TabIndex = 0;
            this.Presure.Text = "Противодавление, атм";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Расход воды м3/час";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Разбавление";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Дозация на насосе";
            // 
            // hardTextBox
            // 
            this.hardTextBox.Location = new System.Drawing.Point(12, 52);
            this.hardTextBox.Name = "hardTextBox";
            this.hardTextBox.Size = new System.Drawing.Size(64, 20);
            this.hardTextBox.TabIndex = 1;
            // 
            // pressureTextBox
            // 
            this.pressureTextBox.Location = new System.Drawing.Point(150, 52);
            this.pressureTextBox.Name = "pressureTextBox";
            this.pressureTextBox.Size = new System.Drawing.Size(64, 20);
            this.pressureTextBox.TabIndex = 1;
            // 
            // PKX
            // 
            this.PKX.AutoSize = true;
            this.PKX.Location = new System.Drawing.Point(289, 52);
            this.PKX.Name = "PKX";
            this.PKX.Size = new System.Drawing.Size(28, 13);
            this.PKX.TabIndex = 0;
            this.PKX.Text = "PKX";
            // 
            // flowTextBox
            // 
            this.flowTextBox.Location = new System.Drawing.Point(397, 45);
            this.flowTextBox.Name = "flowTextBox";
            this.flowTextBox.Size = new System.Drawing.Size(64, 20);
            this.flowTextBox.TabIndex = 2;
            // 
            // mixOut
            // 
            this.mixOut.AutoSize = true;
            this.mixOut.Location = new System.Drawing.Point(54, 179);
            this.mixOut.Name = "mixOut";
            this.mixOut.Size = new System.Drawing.Size(22, 13);
            this.mixOut.TabIndex = 0;
            this.mixOut.Text = "1:5";
            // 
            // nCount
            // 
            this.nCount.AutoSize = true;
            this.nCount.Location = new System.Drawing.Point(394, 179);
            this.nCount.Name = "nCount";
            this.nCount.Size = new System.Drawing.Size(24, 13);
            this.nCount.TabIndex = 0;
            this.nCount.Text = "N:1";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(12, 94);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(449, 23);
            this.button.TabIndex = 3;
            this.button.Text = "Рассчитать";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 229);
            this.Controls.Add(this.button);
            this.Controls.Add(this.flowTextBox);
            this.Controls.Add(this.pressureTextBox);
            this.Controls.Add(this.hardTextBox);
            this.Controls.Add(this.nCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mixOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PKX);
            this.Controls.Add(this.Pump);
            this.Controls.Add(this.Presure);
            this.Controls.Add(this.hard);
            this.Name = "Form1";
            this.Text = "Аминат К";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hard;
        private System.Windows.Forms.Label Pump;
        private System.Windows.Forms.Label Presure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hardTextBox;
        private System.Windows.Forms.TextBox pressureTextBox;
        private System.Windows.Forms.Label PKX;
        private System.Windows.Forms.TextBox flowTextBox;
        private System.Windows.Forms.Label mixOut;
        private System.Windows.Forms.Label nCount;
        private System.Windows.Forms.Button button;
    }
}

