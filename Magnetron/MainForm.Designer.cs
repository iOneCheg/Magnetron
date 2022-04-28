namespace Magnetron
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox_SystemParameters = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownKCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVCathode = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCathodeRadius = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAnodeRadius = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.buttonStartWorking = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox_SystemParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVCathode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCathodeRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnodeRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_SystemParameters
            // 
            this.groupBox_SystemParameters.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox_SystemParameters.Controls.Add(this.numericUpDownB);
            this.groupBox_SystemParameters.Controls.Add(this.numericUpDownAnodeRadius);
            this.groupBox_SystemParameters.Controls.Add(this.numericUpDownCathodeRadius);
            this.groupBox_SystemParameters.Controls.Add(this.numericUpDownVCathode);
            this.groupBox_SystemParameters.Controls.Add(this.numericUpDownKCount);
            this.groupBox_SystemParameters.Controls.Add(this.label5);
            this.groupBox_SystemParameters.Controls.Add(this.label4);
            this.groupBox_SystemParameters.Controls.Add(this.label3);
            this.groupBox_SystemParameters.Controls.Add(this.label2);
            this.groupBox_SystemParameters.Controls.Add(this.label1);
            this.groupBox_SystemParameters.Location = new System.Drawing.Point(818, 12);
            this.groupBox_SystemParameters.Name = "groupBox_SystemParameters";
            this.groupBox_SystemParameters.Size = new System.Drawing.Size(238, 169);
            this.groupBox_SystemParameters.TabIndex = 0;
            this.groupBox_SystemParameters.TabStop = false;
            this.groupBox_SystemParameters.Text = "Параметры системы";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кол-во частиц, генерир. катодом за ед. времени:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Напряжение на катоде:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Радиус катода:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Радиус анода:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Напряженность магн. поля (B):";
            // 
            // numericUpDownKCount
            // 
            this.numericUpDownKCount.Location = new System.Drawing.Point(180, 19);
            this.numericUpDownKCount.Name = "numericUpDownKCount";
            this.numericUpDownKCount.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownKCount.TabIndex = 5;
            this.numericUpDownKCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownVCathode
            // 
            this.numericUpDownVCathode.Location = new System.Drawing.Point(180, 52);
            this.numericUpDownVCathode.Name = "numericUpDownVCathode";
            this.numericUpDownVCathode.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownVCathode.TabIndex = 6;
            this.numericUpDownVCathode.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownCathodeRadius
            // 
            this.numericUpDownCathodeRadius.Location = new System.Drawing.Point(180, 78);
            this.numericUpDownCathodeRadius.Name = "numericUpDownCathodeRadius";
            this.numericUpDownCathodeRadius.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownCathodeRadius.TabIndex = 7;
            // 
            // numericUpDownAnodeRadius
            // 
            this.numericUpDownAnodeRadius.Location = new System.Drawing.Point(180, 104);
            this.numericUpDownAnodeRadius.Name = "numericUpDownAnodeRadius";
            this.numericUpDownAnodeRadius.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownAnodeRadius.TabIndex = 8;
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(180, 130);
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownB.TabIndex = 9;
            // 
            // buttonStartWorking
            // 
            this.buttonStartWorking.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonStartWorking.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartWorking.Location = new System.Drawing.Point(831, 196);
            this.buttonStartWorking.Name = "buttonStartWorking";
            this.buttonStartWorking.Size = new System.Drawing.Size(220, 52);
            this.buttonStartWorking.TabIndex = 1;
            this.buttonStartWorking.Text = "Начать моделирование";
            this.buttonStartWorking.UseVisualStyleBackColor = true;
            // 
            // button
            // 
            this.button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.Location = new System.Drawing.Point(831, 267);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(220, 52);
            this.button.TabIndex = 2;
            this.button.Text = "Построить ВАХ";
            this.button.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(800, 800);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 816);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button);
            this.Controls.Add(this.buttonStartWorking);
            this.Controls.Add(this.groupBox_SystemParameters);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Моделирование магнетрона";
            this.groupBox_SystemParameters.ResumeLayout(false);
            this.groupBox_SystemParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVCathode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCathodeRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnodeRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_SystemParameters;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.NumericUpDown numericUpDownAnodeRadius;
        private System.Windows.Forms.NumericUpDown numericUpDownCathodeRadius;
        private System.Windows.Forms.NumericUpDown numericUpDownVCathode;
        private System.Windows.Forms.NumericUpDown numericUpDownKCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStartWorking;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

