namespace Tyuiu.ZairovAR.Sprint6.TaskReview.V8
{
    partial class FormMain
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonMatrix = new System.Windows.Forms.Button();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.groupBoxArraySize = new System.Windows.Forms.GroupBox();
            this.labelColumns = new System.Windows.Forms.Label();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.labelRows = new System.Windows.Forms.Label();
            this.textboxN = new System.Windows.Forms.TextBox();
            this.groupBoxSumSize = new System.Windows.Forms.GroupBox();
            this.labelColum_R = new System.Windows.Forms.Label();
            this.textBoxColum_C = new System.Windows.Forms.TextBox();
            this.labelMinusStop = new System.Windows.Forms.Label();
            this.textBoxMinusStop = new System.Windows.Forms.TextBox();
            this.labelMinusStart = new System.Windows.Forms.Label();
            this.textBoxMinusStart = new System.Windows.Forms.TextBox();
            this.groupBoxRandomSize = new System.Windows.Forms.GroupBox();
            this.labelRandomStop = new System.Windows.Forms.Label();
            this.textBoxRandomStop = new System.Windows.Forms.TextBox();
            this.labelRandomStart = new System.Windows.Forms.Label();
            this.textBoxRandomStart = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.panelLeft.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.groupBoxArraySize.SuspendLayout();
            this.groupBoxSumSize.SuspendLayout();
            this.groupBoxRandomSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.buttonResult);
            this.panelLeft.Controls.Add(this.buttonMatrix);
            this.panelLeft.Controls.Add(this.groupBoxResult);
            this.panelLeft.Controls.Add(this.groupBoxArraySize);
            this.panelLeft.Controls.Add(this.groupBoxSumSize);
            this.panelLeft.Controls.Add(this.groupBoxRandomSize);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(314, 516);
            this.panelLeft.TabIndex = 4;
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(11, 471);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(296, 46);
            this.buttonResult.TabIndex = 3;
            this.buttonResult.Text = "Выполнить вычисление ";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonMatrix
            // 
            this.buttonMatrix.Location = new System.Drawing.Point(11, 419);
            this.buttonMatrix.Name = "buttonMatrix";
            this.buttonMatrix.Size = new System.Drawing.Size(296, 46);
            this.buttonMatrix.TabIndex = 3;
            this.buttonMatrix.Text = "Вывести матрицу ";
            this.buttonMatrix.UseVisualStyleBackColor = true;
            this.buttonMatrix.Click += new System.EventHandler(this.buttonMatrix_Click);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.textBoxResult);
            this.groupBoxResult.Location = new System.Drawing.Point(12, 361);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(295, 52);
            this.groupBoxResult.TabIndex = 0;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Сумма:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(9, 19);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(158, 20);
            this.textBoxResult.TabIndex = 1;
            // 
            // groupBoxArraySize
            // 
            this.groupBoxArraySize.Controls.Add(this.labelColumns);
            this.groupBoxArraySize.Controls.Add(this.textBoxM);
            this.groupBoxArraySize.Controls.Add(this.labelRows);
            this.groupBoxArraySize.Controls.Add(this.textboxN);
            this.groupBoxArraySize.Location = new System.Drawing.Point(12, 12);
            this.groupBoxArraySize.Name = "groupBoxArraySize";
            this.groupBoxArraySize.Size = new System.Drawing.Size(199, 102);
            this.groupBoxArraySize.TabIndex = 2;
            this.groupBoxArraySize.TabStop = false;
            this.groupBoxArraySize.Text = "Укажите размерность массива:";
            // 
            // labelColumns
            // 
            this.labelColumns.AutoSize = true;
            this.labelColumns.Location = new System.Drawing.Point(6, 55);
            this.labelColumns.Name = "labelColumns";
            this.labelColumns.Size = new System.Drawing.Size(161, 13);
            this.labelColumns.TabIndex = 0;
            this.labelColumns.Text = "Количество столбцов M (M>1):";
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(9, 71);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(158, 20);
            this.textBoxM.TabIndex = 1;
            this.textBoxM.Text = "10";
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Location = new System.Drawing.Point(6, 16);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(141, 13);
            this.labelRows.TabIndex = 0;
            this.labelRows.Text = "Количество строк N (N>1):";
            // 
            // textboxN
            // 
            this.textboxN.Location = new System.Drawing.Point(9, 32);
            this.textboxN.Name = "textboxN";
            this.textboxN.Size = new System.Drawing.Size(158, 20);
            this.textboxN.TabIndex = 1;
            this.textboxN.Text = "10";
            // 
            // groupBoxSumSize
            // 
            this.groupBoxSumSize.Controls.Add(this.labelColum_R);
            this.groupBoxSumSize.Controls.Add(this.textBoxColum_C);
            this.groupBoxSumSize.Controls.Add(this.labelMinusStop);
            this.groupBoxSumSize.Controls.Add(this.textBoxMinusStop);
            this.groupBoxSumSize.Controls.Add(this.labelMinusStart);
            this.groupBoxSumSize.Controls.Add(this.textBoxMinusStart);
            this.groupBoxSumSize.Location = new System.Drawing.Point(12, 228);
            this.groupBoxSumSize.Name = "groupBoxSumSize";
            this.groupBoxSumSize.Size = new System.Drawing.Size(295, 133);
            this.groupBoxSumSize.TabIndex = 2;
            this.groupBoxSumSize.TabStop = false;
            this.groupBoxSumSize.Text = "Укажите диапазон суммы чётных значений массива:";
            // 
            // labelColum_R
            // 
            this.labelColum_R.AutoSize = true;
            this.labelColum_R.Location = new System.Drawing.Point(6, 94);
            this.labelColum_R.Name = "labelColum_R";
            this.labelColum_R.Size = new System.Drawing.Size(109, 13);
            this.labelColum_R.TabIndex = 0;
            this.labelColum_R.Text = "Укажите столбец C:";
            // 
            // textBoxColum_C
            // 
            this.textBoxColum_C.Location = new System.Drawing.Point(9, 107);
            this.textBoxColum_C.Name = "textBoxColum_C";
            this.textBoxColum_C.Size = new System.Drawing.Size(158, 20);
            this.textBoxColum_C.TabIndex = 1;
            this.textBoxColum_C.Text = "1";
            // 
            // labelMinusStop
            // 
            this.labelMinusStop.AutoSize = true;
            this.labelMinusStop.Location = new System.Drawing.Point(6, 55);
            this.labelMinusStop.Name = "labelMinusStop";
            this.labelMinusStop.Size = new System.Drawing.Size(34, 13);
            this.labelMinusStop.TabIndex = 0;
            this.labelMinusStop.Text = "До L:";
            // 
            // textBoxMinusStop
            // 
            this.textBoxMinusStop.Location = new System.Drawing.Point(9, 71);
            this.textBoxMinusStop.Name = "textBoxMinusStop";
            this.textBoxMinusStop.Size = new System.Drawing.Size(158, 20);
            this.textBoxMinusStop.TabIndex = 1;
            this.textBoxMinusStop.Text = "2";
            // 
            // labelMinusStart
            // 
            this.labelMinusStart.AutoSize = true;
            this.labelMinusStart.Location = new System.Drawing.Point(6, 16);
            this.labelMinusStart.Name = "labelMinusStart";
            this.labelMinusStart.Size = new System.Drawing.Size(33, 13);
            this.labelMinusStart.TabIndex = 0;
            this.labelMinusStart.Text = "От K:";
            // 
            // textBoxMinusStart
            // 
            this.textBoxMinusStart.Location = new System.Drawing.Point(9, 32);
            this.textBoxMinusStart.Name = "textBoxMinusStart";
            this.textBoxMinusStart.Size = new System.Drawing.Size(158, 20);
            this.textBoxMinusStart.TabIndex = 1;
            this.textBoxMinusStart.Text = "0";
            // 
            // groupBoxRandomSize
            // 
            this.groupBoxRandomSize.Controls.Add(this.labelRandomStop);
            this.groupBoxRandomSize.Controls.Add(this.textBoxRandomStop);
            this.groupBoxRandomSize.Controls.Add(this.labelRandomStart);
            this.groupBoxRandomSize.Controls.Add(this.textBoxRandomStart);
            this.groupBoxRandomSize.Location = new System.Drawing.Point(12, 120);
            this.groupBoxRandomSize.Name = "groupBoxRandomSize";
            this.groupBoxRandomSize.Size = new System.Drawing.Size(199, 102);
            this.groupBoxRandomSize.TabIndex = 2;
            this.groupBoxRandomSize.TabStop = false;
            this.groupBoxRandomSize.Text = "Укажите диапазон значений:";
            // 
            // labelRandomStop
            // 
            this.labelRandomStop.AutoSize = true;
            this.labelRandomStop.Location = new System.Drawing.Point(6, 55);
            this.labelRandomStop.Name = "labelRandomStop";
            this.labelRandomStop.Size = new System.Drawing.Size(40, 13);
            this.labelRandomStop.TabIndex = 0;
            this.labelRandomStop.Text = "До n2:";
            // 
            // textBoxRandomStop
            // 
            this.textBoxRandomStop.Location = new System.Drawing.Point(9, 71);
            this.textBoxRandomStop.Name = "textBoxRandomStop";
            this.textBoxRandomStop.Size = new System.Drawing.Size(158, 20);
            this.textBoxRandomStop.TabIndex = 1;
            this.textBoxRandomStop.Text = "9";
            // 
            // labelRandomStart
            // 
            this.labelRandomStart.AutoSize = true;
            this.labelRandomStart.Location = new System.Drawing.Point(6, 16);
            this.labelRandomStart.Name = "labelRandomStart";
            this.labelRandomStart.Size = new System.Drawing.Size(38, 13);
            this.labelRandomStart.TabIndex = 0;
            this.labelRandomStart.Text = "От n1:";
            // 
            // textBoxRandomStart
            // 
            this.textBoxRandomStart.Location = new System.Drawing.Point(9, 32);
            this.textBoxRandomStart.Name = "textBoxRandomStart";
            this.textBoxRandomStart.Size = new System.Drawing.Size(158, 20);
            this.textBoxRandomStart.TabIndex = 1;
            this.textBoxRandomStart.Text = "1";
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(314, 0);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.Size = new System.Drawing.Size(595, 516);
            this.dataGridViewMatrix.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 516);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Controls.Add(this.panelLeft);
            this.Name = "FormMain";
            this.Text = "Спринт ревью | Вариант 8 | Заиров А.Р.";
            this.panelLeft.ResumeLayout(false);
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.groupBoxArraySize.ResumeLayout(false);
            this.groupBoxArraySize.PerformLayout();
            this.groupBoxSumSize.ResumeLayout(false);
            this.groupBoxSumSize.PerformLayout();
            this.groupBoxRandomSize.ResumeLayout(false);
            this.groupBoxRandomSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonMatrix;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.GroupBox groupBoxArraySize;
        private System.Windows.Forms.Label labelColumns;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.TextBox textboxN;
        private System.Windows.Forms.GroupBox groupBoxSumSize;
        private System.Windows.Forms.Label labelColum_R;
        private System.Windows.Forms.TextBox textBoxColum_C;
        private System.Windows.Forms.Label labelMinusStop;
        private System.Windows.Forms.TextBox textBoxMinusStop;
        private System.Windows.Forms.Label labelMinusStart;
        private System.Windows.Forms.TextBox textBoxMinusStart;
        private System.Windows.Forms.GroupBox groupBoxRandomSize;
        private System.Windows.Forms.Label labelRandomStop;
        private System.Windows.Forms.TextBox textBoxRandomStop;
        private System.Windows.Forms.Label labelRandomStart;
        private System.Windows.Forms.TextBox textBoxRandomStart;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
    }
}

