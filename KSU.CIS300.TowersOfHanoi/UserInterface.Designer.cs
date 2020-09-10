namespace KSU.CIS300.TowersOfHanoi
{
    partial class UserInterface
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
            this.uxNew = new System.Windows.Forms.Button();
            this.uxNewNumeric = new System.Windows.Forms.NumericUpDown();
            this.uxMoveCount = new System.Windows.Forms.Label();
            this.uxCount = new System.Windows.Forms.Label();
            this.uxDelayNumeric = new System.Windows.Forms.NumericUpDown();
            this.uxSolve = new System.Windows.Forms.Button();
            this.uxDelay = new System.Windows.Forms.Label();
            this.uxFlow1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uxFlow2 = new System.Windows.Forms.FlowLayoutPanel();
            this.uxFlow3 = new System.Windows.Forms.FlowLayoutPanel();
            this.uxLeft1 = new System.Windows.Forms.Button();
            this.uxLeft2 = new System.Windows.Forms.Button();
            this.uxLeft3 = new System.Windows.Forms.Button();
            this.uxRight2 = new System.Windows.Forms.Button();
            this.uxRight3 = new System.Windows.Forms.Button();
            this.uxRight1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxNewNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxDelayNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // uxNew
            // 
            this.uxNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNew.Location = new System.Drawing.Point(34, 12);
            this.uxNew.Name = "uxNew";
            this.uxNew.Size = new System.Drawing.Size(110, 52);
            this.uxNew.TabIndex = 0;
            this.uxNew.Text = "New";
            this.uxNew.UseVisualStyleBackColor = true;
           /// this.uxNew.Click += new System.EventHandler(this.uxNew_Click);
            // 
            // uxNewNumeric
            // 
            this.uxNewNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNewNumeric.Location = new System.Drawing.Point(152, 15);
            this.uxNewNumeric.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.uxNewNumeric.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.uxNewNumeric.Name = "uxNewNumeric";
            this.uxNewNumeric.Size = new System.Drawing.Size(74, 39);
            this.uxNewNumeric.TabIndex = 1;
            this.uxNewNumeric.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
           /// this.uxNewNumeric.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // uxMoveCount
            // 
            this.uxMoveCount.AutoSize = true;
            this.uxMoveCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMoveCount.Location = new System.Drawing.Point(298, 22);
            this.uxMoveCount.Name = "uxMoveCount";
            this.uxMoveCount.Size = new System.Drawing.Size(175, 32);
            this.uxMoveCount.TabIndex = 2;
            this.uxMoveCount.Text = "Move Count:";
            // 
            // uxCount
            // 
            this.uxCount.AutoSize = true;
            this.uxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCount.Location = new System.Drawing.Point(489, 22);
            this.uxCount.Name = "uxCount";
            this.uxCount.Size = new System.Drawing.Size(31, 32);
            this.uxCount.TabIndex = 3;
            this.uxCount.Text = "0";
            // 
            // uxDelayNumeric
            // 
            this.uxDelayNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDelayNumeric.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.uxDelayNumeric.Location = new System.Drawing.Point(837, 20);
            this.uxDelayNumeric.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.uxDelayNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxDelayNumeric.Name = "uxDelayNumeric";
            this.uxDelayNumeric.Size = new System.Drawing.Size(100, 39);
            this.uxDelayNumeric.TabIndex = 5;
            this.uxDelayNumeric.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // uxSolve
            // 
            this.uxSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSolve.Location = new System.Drawing.Point(620, 15);
            this.uxSolve.Name = "uxSolve";
            this.uxSolve.Size = new System.Drawing.Size(110, 49);
            this.uxSolve.TabIndex = 4;
            this.uxSolve.Text = "Solve";
            this.uxSolve.UseVisualStyleBackColor = true;
            // 
            // uxDelay
            // 
            this.uxDelay.AutoSize = true;
            this.uxDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxDelay.Location = new System.Drawing.Point(735, 20);
            this.uxDelay.Name = "uxDelay";
            this.uxDelay.Size = new System.Drawing.Size(96, 32);
            this.uxDelay.TabIndex = 6;
            this.uxDelay.Text = "Delay:";
///            this.uxDelay.Click += new System.EventHandler(this.label1_Click);
            // 
            // uxFlow1
            // 
            this.uxFlow1.BackColor = System.Drawing.SystemColors.Control;
            this.uxFlow1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.uxFlow1.Location = new System.Drawing.Point(10, 85);
            this.uxFlow1.Name = "uxFlow1";
            this.uxFlow1.Size = new System.Drawing.Size(286, 663);
            this.uxFlow1.TabIndex = 7;
            // 
            // uxFlow2
            // 
            this.uxFlow2.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.uxFlow2.Location = new System.Drawing.Point(344, 85);
            this.uxFlow2.Name = "uxFlow2";
            this.uxFlow2.Size = new System.Drawing.Size(286, 663);
            this.uxFlow2.TabIndex = 8;
            // 
            // uxFlow3
            // 
            this.uxFlow3.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.uxFlow3.Location = new System.Drawing.Point(674, 85);
            this.uxFlow3.Name = "uxFlow3";
            this.uxFlow3.Size = new System.Drawing.Size(286, 663);
            this.uxFlow3.TabIndex = 8;
            // 
            // uxLeft1
            // 
            this.uxLeft1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLeft1.Location = new System.Drawing.Point(10, 752);
            this.uxLeft1.Name = "uxLeft1";
            this.uxLeft1.Size = new System.Drawing.Size(134, 63);
            this.uxLeft1.TabIndex = 9;
            this.uxLeft1.Text = "Move Left";
            this.uxLeft1.UseVisualStyleBackColor = true;
            // 
            // uxLeft2
            // 
            this.uxLeft2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLeft2.Location = new System.Drawing.Point(344, 752);
            this.uxLeft2.Name = "uxLeft2";
            this.uxLeft2.Size = new System.Drawing.Size(130, 63);
            this.uxLeft2.TabIndex = 10;
            this.uxLeft2.Text = "Move Left";
            this.uxLeft2.UseVisualStyleBackColor = true;
            // 
            // uxLeft3
            // 
            this.uxLeft3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLeft3.Location = new System.Drawing.Point(674, 752);
            this.uxLeft3.Name = "uxLeft3";
            this.uxLeft3.Size = new System.Drawing.Size(129, 63);
            this.uxLeft3.TabIndex = 11;
            this.uxLeft3.Text = "Move Left";
            this.uxLeft3.UseVisualStyleBackColor = true;
            // 
            // uxRight2
            // 
            this.uxRight2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRight2.Location = new System.Drawing.Point(495, 752);
            this.uxRight2.Name = "uxRight2";
            this.uxRight2.Size = new System.Drawing.Size(134, 63);
            this.uxRight2.TabIndex = 12;
            this.uxRight2.Text = "Move Right";
            this.uxRight2.UseVisualStyleBackColor = true;
            // 
            // uxRight3
            // 
            this.uxRight3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRight3.Location = new System.Drawing.Point(825, 752);
            this.uxRight3.Name = "uxRight3";
            this.uxRight3.Size = new System.Drawing.Size(134, 63);
            this.uxRight3.TabIndex = 13;
            this.uxRight3.Text = "Move Right";
            this.uxRight3.UseVisualStyleBackColor = true;
            // 
            // uxRight1
            // 
            this.uxRight1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRight1.Location = new System.Drawing.Point(164, 752);
            this.uxRight1.Name = "uxRight1";
            this.uxRight1.Size = new System.Drawing.Size(134, 63);
            this.uxRight1.TabIndex = 14;
            this.uxRight1.Text = "Move Right";
            this.uxRight1.UseVisualStyleBackColor = true;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 828);
            this.Controls.Add(this.uxRight1);
            this.Controls.Add(this.uxRight3);
            this.Controls.Add(this.uxRight2);
            this.Controls.Add(this.uxLeft3);
            this.Controls.Add(this.uxLeft2);
            this.Controls.Add(this.uxLeft1);
            this.Controls.Add(this.uxFlow3);
            this.Controls.Add(this.uxFlow2);
            this.Controls.Add(this.uxFlow1);
            this.Controls.Add(this.uxDelay);
            this.Controls.Add(this.uxDelayNumeric);
            this.Controls.Add(this.uxSolve);
            this.Controls.Add(this.uxCount);
            this.Controls.Add(this.uxMoveCount);
            this.Controls.Add(this.uxNewNumeric);
            this.Controls.Add(this.uxNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserInterface";
            this.Text = "Tower of Hanoi";
            ((System.ComponentModel.ISupportInitialize)(this.uxNewNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxDelayNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxNew;
        private System.Windows.Forms.NumericUpDown uxNewNumeric;
        private System.Windows.Forms.Label uxMoveCount;
        private System.Windows.Forms.Label uxCount;
        private System.Windows.Forms.NumericUpDown uxDelayNumeric;
        private System.Windows.Forms.Button uxSolve;
        private System.Windows.Forms.Label uxDelay;
        private System.Windows.Forms.FlowLayoutPanel uxFlow1;
        private System.Windows.Forms.FlowLayoutPanel uxFlow2;
        private System.Windows.Forms.FlowLayoutPanel uxFlow3;
        private System.Windows.Forms.Button uxLeft1;
        private System.Windows.Forms.Button uxLeft2;
        private System.Windows.Forms.Button uxLeft3;
        private System.Windows.Forms.Button uxRight2;
        private System.Windows.Forms.Button uxRight3;
        private System.Windows.Forms.Button uxRight1;
    }
}

