namespace WinFormsApp9
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonDraw = new System.Windows.Forms.Button();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.textBoxX3 = new System.Windows.Forms.TextBox();
            this.textBoxY3 = new System.Windows.Forms.TextBox();
            this.textBoxX4 = new System.Windows.Forms.TextBox();
            this.textBoxY4 = new System.Windows.Forms.TextBox();
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.comboBoxShape = new System.Windows.Forms.ComboBox();
            this.textBoxOrder = new System.Windows.Forms.TextBox();
            this.labelOrder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            this.SuspendLayout();

            // buttonDraw
            this.buttonDraw.Location = new System.Drawing.Point(10, 10);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(100, 30);
            this.buttonDraw.TabIndex = 0;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);

            // textBoxX1
            this.textBoxX1.Location = new System.Drawing.Point(10, 50);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(100, 23);
            this.textBoxX1.TabIndex = 1;

            // textBoxY1
            this.textBoxY1.Location = new System.Drawing.Point(120, 50);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(100, 23);
            this.textBoxY1.TabIndex = 2;

            // textBoxX2
            this.textBoxX2.Location = new System.Drawing.Point(10, 80);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(100, 23);
            this.textBoxX2.TabIndex = 3;

            // textBoxY2
            this.textBoxY2.Location = new System.Drawing.Point(120, 80);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(100, 23);
            this.textBoxY2.TabIndex = 4;

            // textBoxX3
            this.textBoxX3.Location = new System.Drawing.Point(10, 110);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.Size = new System.Drawing.Size(100, 23);
            this.textBoxX3.TabIndex = 5;

            // textBoxY3
            this.textBoxY3.Location = new System.Drawing.Point(120, 110);
            this.textBoxY3.Name = "textBoxY3";
            this.textBoxY3.Size = new System.Drawing.Size(100, 23);
            this.textBoxY3.TabIndex = 6;

            // textBoxX4
            this.textBoxX4.Location = new System.Drawing.Point(10, 140);
            this.textBoxX4.Name = "textBoxX4";
            this.textBoxX4.Size = new System.Drawing.Size(100, 23);
            this.textBoxX4.TabIndex = 7;

            // textBoxY4
            this.textBoxY4.Location = new System.Drawing.Point(120, 140);
            this.textBoxY4.Name = "textBoxY4";
            this.textBoxY4.Size = new System.Drawing.Size(100, 23);
            this.textBoxY4.TabIndex = 8;

            // pictureBoxCanvas
            this.pictureBoxCanvas.Location = new System.Drawing.Point(10, 200);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(780, 240);
            this.pictureBoxCanvas.TabIndex = 9;
            this.pictureBoxCanvas.TabStop = false;

            // comboBoxShape
            this.comboBoxShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShape.Items.AddRange(new object[] {
                "Bezier Curve",
                "Koch Fractal"
            });
            this.comboBoxShape.Location = new System.Drawing.Point(10, 170);
            this.comboBoxShape.Name = "comboBoxShape";
            this.comboBoxShape.Size = new System.Drawing.Size(200, 23);
            this.comboBoxShape.TabIndex = 10;

            // textBoxOrder
            this.textBoxOrder.Location = new System.Drawing.Point(320, 170);
            this.textBoxOrder.Name = "textBoxOrder";
            this.textBoxOrder.Size = new System.Drawing.Size(100, 23);
            this.textBoxOrder.TabIndex = 11;

            // labelOrder
            this.labelOrder.AutoSize = true;
            this.labelOrder.Location = new System.Drawing.Point(230, 173);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(84, 15);
            this.labelOrder.TabIndex = 12;
            this.labelOrder.Text = "Fractal Order";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.textBoxOrder);
            this.Controls.Add(this.comboBoxShape);
            this.Controls.Add(this.pictureBoxCanvas);
            this.Controls.Add(this.textBoxY4);
            this.Controls.Add(this.textBoxX4);
            this.Controls.Add(this.textBoxY3);
            this.Controls.Add(this.textBoxX3);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxY1);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.buttonDraw);
            this.Name = "Form1";
            this.Text = "Bezier and Koch Fractal App";
            this.ResumeLayout(false);
            this.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
        }

        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.TextBox textBoxX3;
        private System.Windows.Forms.TextBox textBoxY3;
        private System.Windows.Forms.TextBox textBoxX4;
        private System.Windows.Forms.TextBox textBoxY4;
        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.ComboBox comboBoxShape;
        private System.Windows.Forms.TextBox textBoxOrder;
        private System.Windows.Forms.Label labelOrder;
    }
}
