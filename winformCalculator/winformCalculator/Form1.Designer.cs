namespace winformCalculator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlStandard = new System.Windows.Forms.Panel();
            this.txtShowCount = new System.Windows.Forms.TextBox();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.BtnSq = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnNegate = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.pnlStandard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStandard
            // 
            this.pnlStandard.Controls.Add(this.txtShowCount);
            this.pnlStandard.Controls.Add(this.txtShow);
            this.pnlStandard.Controls.Add(this.btnEqual);
            this.pnlStandard.Controls.Add(this.btnBack);
            this.pnlStandard.Controls.Add(this.btnClearEntry);
            this.pnlStandard.Controls.Add(this.btnClear);
            this.pnlStandard.Controls.Add(this.btnSqrt);
            this.pnlStandard.Controls.Add(this.btnReciprocal);
            this.pnlStandard.Controls.Add(this.btnPercent);
            this.pnlStandard.Controls.Add(this.btn9);
            this.pnlStandard.Controls.Add(this.BtnSq);
            this.pnlStandard.Controls.Add(this.btn8);
            this.pnlStandard.Controls.Add(this.btn7);
            this.pnlStandard.Controls.Add(this.btn6);
            this.pnlStandard.Controls.Add(this.btn5);
            this.pnlStandard.Controls.Add(this.btn4);
            this.pnlStandard.Controls.Add(this.btn3);
            this.pnlStandard.Controls.Add(this.btn2);
            this.pnlStandard.Controls.Add(this.btn1);
            this.pnlStandard.Controls.Add(this.btn0);
            this.pnlStandard.Controls.Add(this.btnAdd);
            this.pnlStandard.Controls.Add(this.btnMul);
            this.pnlStandard.Controls.Add(this.btnSub);
            this.pnlStandard.Controls.Add(this.btnDiv);
            this.pnlStandard.Controls.Add(this.btnNegate);
            this.pnlStandard.Controls.Add(this.btnPoint);
            this.pnlStandard.Location = new System.Drawing.Point(0, -1);
            this.pnlStandard.Name = "pnlStandard";
            this.pnlStandard.Size = new System.Drawing.Size(400, 547);
            this.pnlStandard.TabIndex = 30;
            // 
            // txtShowCount
            // 
            this.txtShowCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtShowCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShowCount.Font = new System.Drawing.Font("微软雅黑", 12.2F);
            this.txtShowCount.Location = new System.Drawing.Point(13, 46);
            this.txtShowCount.Name = "txtShowCount";
            this.txtShowCount.Size = new System.Drawing.Size(378, 27);
            this.txtShowCount.TabIndex = 25;
            this.txtShowCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtShow
            // 
            this.txtShow.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShow.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtShow.Location = new System.Drawing.Point(7, 104);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(384, 80);
            this.txtShow.TabIndex = 24;
            this.txtShow.Text = "0";
            this.txtShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtShow.TextChanged += new System.EventHandler(this.txtShow_TextChanged);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("宋体", 16F);
            this.btnEqual.Location = new System.Drawing.Point(300, 488);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(91, 52);
            this.btnEqual.TabIndex = 23;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("微软雅黑 Light", 12F);
            this.btnBack.Location = new System.Drawing.Point(300, 200);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 52);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "🔙";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.Font = new System.Drawing.Font("微软雅黑 Light", 12F);
            this.btnClearEntry.Location = new System.Drawing.Point(106, 200);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(91, 52);
            this.btnClearEntry.TabIndex = 1;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微软雅黑 Light", 12F);
            this.btnClear.Location = new System.Drawing.Point(203, 200);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 52);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("微软雅黑 Light", 12F);
            this.btnSqrt.Location = new System.Drawing.Point(203, 258);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(91, 52);
            this.btnSqrt.TabIndex = 6;
            this.btnSqrt.Text = "²√x";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.Font = new System.Drawing.Font("微软雅黑 Light", 12F);
            this.btnReciprocal.Location = new System.Drawing.Point(10, 257);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(91, 52);
            this.btnReciprocal.TabIndex = 4;
            this.btnReciprocal.Text = "1/x";
            this.btnReciprocal.UseVisualStyleBackColor = true;
            this.btnReciprocal.Click += new System.EventHandler(this.btnReciprocal_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.Font = new System.Drawing.Font("微软雅黑 Light", 12F);
            this.btnPercent.Location = new System.Drawing.Point(10, 199);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(91, 52);
            this.btnPercent.TabIndex = 0;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = true;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn9.Location = new System.Drawing.Point(203, 316);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(91, 52);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // BtnSq
            // 
            this.BtnSq.Font = new System.Drawing.Font("微软雅黑 Light", 12F);
            this.BtnSq.Location = new System.Drawing.Point(106, 258);
            this.BtnSq.Name = "BtnSq";
            this.BtnSq.Size = new System.Drawing.Size(91, 52);
            this.BtnSq.TabIndex = 5;
            this.BtnSq.Text = "x²";
            this.BtnSq.UseVisualStyleBackColor = true;
            this.BtnSq.Click += new System.EventHandler(this.BtnSq_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn8.Location = new System.Drawing.Point(106, 316);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(91, 52);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn7.Location = new System.Drawing.Point(10, 315);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(91, 52);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn6.Location = new System.Drawing.Point(203, 374);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(91, 52);
            this.btn6.TabIndex = 14;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn5.Location = new System.Drawing.Point(106, 374);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(91, 52);
            this.btn5.TabIndex = 13;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn4.Location = new System.Drawing.Point(10, 373);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(91, 52);
            this.btn4.TabIndex = 12;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn3.Location = new System.Drawing.Point(203, 432);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(91, 52);
            this.btn3.TabIndex = 18;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn2.Location = new System.Drawing.Point(106, 432);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(91, 52);
            this.btn2.TabIndex = 17;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn1.Location = new System.Drawing.Point(9, 431);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(91, 52);
            this.btn1.TabIndex = 16;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn0.Location = new System.Drawing.Point(106, 489);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(91, 52);
            this.btn0.TabIndex = 21;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("宋体", 16F);
            this.btnAdd.Location = new System.Drawing.Point(300, 432);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 52);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnMul
            // 
            this.btnMul.Font = new System.Drawing.Font("宋体", 14F);
            this.btnMul.Location = new System.Drawing.Point(300, 316);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(91, 52);
            this.btnMul.TabIndex = 11;
            this.btnMul.Text = "×";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnSub
            // 
            this.btnSub.Font = new System.Drawing.Font("宋体", 14F);
            this.btnSub.Location = new System.Drawing.Point(300, 374);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(91, 52);
            this.btnSub.TabIndex = 15;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("微软雅黑 Light", 12F);
            this.btnDiv.Location = new System.Drawing.Point(300, 258);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(91, 52);
            this.btnDiv.TabIndex = 7;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnNegate
            // 
            this.btnNegate.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNegate.Location = new System.Drawing.Point(9, 489);
            this.btnNegate.Name = "btnNegate";
            this.btnNegate.Size = new System.Drawing.Size(91, 52);
            this.btnNegate.TabIndex = 20;
            this.btnNegate.Text = "+/-";
            this.btnNegate.UseVisualStyleBackColor = true;
            this.btnNegate.Click += new System.EventHandler(this.btnNegate_Click);
            // 
            // btnPoint
            // 
            this.btnPoint.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPoint.Location = new System.Drawing.Point(203, 489);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(91, 52);
            this.btnPoint.TabIndex = 22;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 545);
            this.Controls.Add(this.pnlStandard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlStandard.ResumeLayout(false);
            this.pnlStandard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStandard;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button BtnSq;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnNegate;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.TextBox txtShowCount;

    }
}

