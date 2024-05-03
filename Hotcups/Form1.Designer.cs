namespace Hotcups
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
            teaBtn = new Button();
            doneBtn = new Button();
            capuccinoBtn = new Button();
            chocolateBtn = new Button();
            coffeeBtn = new Button();
            fiveCentsBtn = new Button();
            tenCentsBtn = new Button();
            twentyCentsBtn = new Button();
            twoEurBtn = new Button();
            oneEurBtn = new Button();
            fiftyCentsBtn = new Button();
            resetBtn = new Button();
            cancelBtn = new Button();
            totalLabel = new Label();
            insertedLabel = new Label();
            changeLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // teaBtn
            // 
            teaBtn.BackColor = Color.Tan;
            teaBtn.FlatStyle = FlatStyle.Flat;
            teaBtn.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            teaBtn.ForeColor = Color.FromArgb(152, 117, 84);
            teaBtn.Location = new Point(138, 210);
            teaBtn.Name = "teaBtn";
            teaBtn.Size = new Size(120, 120);
            teaBtn.TabIndex = 3;
            teaBtn.Text = "Chá (0.20€)";
            teaBtn.UseVisualStyleBackColor = false;
            teaBtn.Click += teaBtn_Click;
            // 
            // doneBtn
            // 
            doneBtn.BackColor = Color.FromArgb(152, 117, 84);
            doneBtn.FlatStyle = FlatStyle.Flat;
            doneBtn.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            doneBtn.ForeColor = Color.White;
            doneBtn.Location = new Point(457, 228);
            doneBtn.Name = "doneBtn";
            doneBtn.Size = new Size(331, 45);
            doneBtn.TabIndex = 4;
            doneBtn.Text = "Confirmar";
            doneBtn.UseVisualStyleBackColor = false;
            doneBtn.Click += doneBtn_Click;
            // 
            // capuccinoBtn
            // 
            capuccinoBtn.BackColor = Color.Tan;
            capuccinoBtn.FlatStyle = FlatStyle.Flat;
            capuccinoBtn.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            capuccinoBtn.ForeColor = Color.FromArgb(152, 117, 84);
            capuccinoBtn.Location = new Point(12, 74);
            capuccinoBtn.Name = "capuccinoBtn";
            capuccinoBtn.Size = new Size(120, 120);
            capuccinoBtn.TabIndex = 5;
            capuccinoBtn.Text = "Cappuccino (0.30€)";
            capuccinoBtn.UseVisualStyleBackColor = false;
            capuccinoBtn.Click += capuccinoBtn_Click;
            // 
            // chocolateBtn
            // 
            chocolateBtn.BackColor = Color.Tan;
            chocolateBtn.FlatStyle = FlatStyle.Flat;
            chocolateBtn.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            chocolateBtn.ForeColor = Color.FromArgb(152, 117, 84);
            chocolateBtn.Location = new Point(138, 74);
            chocolateBtn.Name = "chocolateBtn";
            chocolateBtn.Size = new Size(120, 120);
            chocolateBtn.TabIndex = 6;
            chocolateBtn.Text = "Chocolate (0.35€)";
            chocolateBtn.UseVisualStyleBackColor = false;
            chocolateBtn.Click += chocolateBtn_Click;
            // 
            // coffeeBtn
            // 
            coffeeBtn.BackColor = Color.Tan;
            coffeeBtn.FlatStyle = FlatStyle.Flat;
            coffeeBtn.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            coffeeBtn.ForeColor = Color.FromArgb(152, 117, 84);
            coffeeBtn.Location = new Point(12, 210);
            coffeeBtn.Name = "coffeeBtn";
            coffeeBtn.Size = new Size(120, 120);
            coffeeBtn.TabIndex = 7;
            coffeeBtn.Text = "Café (0.25€)";
            coffeeBtn.UseVisualStyleBackColor = false;
            coffeeBtn.Click += coffeeBtn_Click;
            // 
            // fiveCentsBtn
            // 
            fiveCentsBtn.BackColor = Color.Tan;
            fiveCentsBtn.FlatStyle = FlatStyle.Flat;
            fiveCentsBtn.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            fiveCentsBtn.ForeColor = Color.White;
            fiveCentsBtn.Location = new Point(457, 74);
            fiveCentsBtn.Name = "fiveCentsBtn";
            fiveCentsBtn.Size = new Size(157, 45);
            fiveCentsBtn.TabIndex = 8;
            fiveCentsBtn.Text = "0.05€";
            fiveCentsBtn.UseVisualStyleBackColor = false;
            fiveCentsBtn.Click += fiveCentsBtn_Click;
            // 
            // tenCentsBtn
            // 
            tenCentsBtn.BackColor = Color.Tan;
            tenCentsBtn.FlatStyle = FlatStyle.Flat;
            tenCentsBtn.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            tenCentsBtn.ForeColor = Color.White;
            tenCentsBtn.Location = new Point(633, 74);
            tenCentsBtn.Name = "tenCentsBtn";
            tenCentsBtn.Size = new Size(155, 45);
            tenCentsBtn.TabIndex = 9;
            tenCentsBtn.Text = "0.10€";
            tenCentsBtn.UseVisualStyleBackColor = false;
            tenCentsBtn.Click += tenCentsBtn_Click;
            // 
            // twentyCentsBtn
            // 
            twentyCentsBtn.BackColor = Color.Tan;
            twentyCentsBtn.FlatStyle = FlatStyle.Flat;
            twentyCentsBtn.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            twentyCentsBtn.ForeColor = Color.White;
            twentyCentsBtn.Location = new Point(457, 125);
            twentyCentsBtn.Name = "twentyCentsBtn";
            twentyCentsBtn.Size = new Size(157, 45);
            twentyCentsBtn.TabIndex = 10;
            twentyCentsBtn.Text = "0.20€";
            twentyCentsBtn.UseVisualStyleBackColor = false;
            twentyCentsBtn.Click += twentyCentsBtn_Click;
            // 
            // twoEurBtn
            // 
            twoEurBtn.BackColor = Color.Tan;
            twoEurBtn.FlatStyle = FlatStyle.Flat;
            twoEurBtn.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            twoEurBtn.ForeColor = Color.White;
            twoEurBtn.Location = new Point(633, 176);
            twoEurBtn.Name = "twoEurBtn";
            twoEurBtn.Size = new Size(155, 45);
            twoEurBtn.TabIndex = 13;
            twoEurBtn.Text = "2.00€";
            twoEurBtn.UseVisualStyleBackColor = false;
            twoEurBtn.Click += twoEurBtn_Click;
            // 
            // oneEurBtn
            // 
            oneEurBtn.BackColor = Color.Tan;
            oneEurBtn.FlatStyle = FlatStyle.Flat;
            oneEurBtn.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            oneEurBtn.ForeColor = Color.White;
            oneEurBtn.Location = new Point(457, 176);
            oneEurBtn.Name = "oneEurBtn";
            oneEurBtn.Size = new Size(157, 45);
            oneEurBtn.TabIndex = 12;
            oneEurBtn.Text = "1.00€";
            oneEurBtn.UseVisualStyleBackColor = false;
            oneEurBtn.Click += oneEurBtn_Click;
            // 
            // fiftyCentsBtn
            // 
            fiftyCentsBtn.BackColor = Color.Tan;
            fiftyCentsBtn.FlatStyle = FlatStyle.Flat;
            fiftyCentsBtn.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            fiftyCentsBtn.ForeColor = Color.White;
            fiftyCentsBtn.Location = new Point(633, 125);
            fiftyCentsBtn.Name = "fiftyCentsBtn";
            fiftyCentsBtn.Size = new Size(155, 45);
            fiftyCentsBtn.TabIndex = 11;
            fiftyCentsBtn.Text = "0.50€";
            fiftyCentsBtn.UseVisualStyleBackColor = false;
            fiftyCentsBtn.Click += fiftyCentsBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.BackColor = Color.Gold;
            resetBtn.FlatStyle = FlatStyle.Flat;
            resetBtn.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            resetBtn.ForeColor = Color.Black;
            resetBtn.Location = new Point(457, 381);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(170, 57);
            resetBtn.TabIndex = 14;
            resetBtn.Text = "Resetar a Máquina";
            resetBtn.UseVisualStyleBackColor = false;
            resetBtn.Click += resetBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(254, 226, 226);
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            cancelBtn.ForeColor = Color.FromArgb(239, 68, 68);
            cancelBtn.Location = new Point(633, 381);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(155, 57);
            cancelBtn.TabIndex = 15;
            cancelBtn.Text = "Cancelar";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            totalLabel.ForeColor = Color.Black;
            totalLabel.Location = new Point(12, 353);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(148, 17);
            totalLabel.TabIndex = 16;
            totalLabel.Text = "Custo da Bebida: 0,00€";
            totalLabel.Click += totalLabel_Click;
            // 
            // insertedLabel
            // 
            insertedLabel.AutoSize = true;
            insertedLabel.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            insertedLabel.ForeColor = Color.Black;
            insertedLabel.Location = new Point(12, 407);
            insertedLabel.Name = "insertedLabel";
            insertedLabel.Size = new Size(133, 17);
            insertedLabel.TabIndex = 17;
            insertedLabel.Text = "Total Inserido: 0,00€";
            insertedLabel.Click += insertedLabel_Click;
            // 
            // changeLabel
            // 
            changeLabel.AutoSize = true;
            changeLabel.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            changeLabel.ForeColor = Color.Black;
            changeLabel.Location = new Point(12, 381);
            changeLabel.Name = "changeLabel";
            changeLabel.Size = new Size(82, 17);
            changeLabel.TabIndex = 18;
            changeLabel.Text = "Troco: 0,00€";
            changeLabel.Click += changeLabel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(457, 28);
            label1.Name = "label1";
            label1.Size = new Size(331, 30);
            label1.TabIndex = 19;
            label1.Text = "Selecione as Moedas que Inseriu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 28);
            label2.Name = "label2";
            label2.Size = new Size(235, 30);
            label2.TabIndex = 20;
            label2.Text = "Selecione a sua Bebida";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(changeLabel);
            Controls.Add(insertedLabel);
            Controls.Add(totalLabel);
            Controls.Add(cancelBtn);
            Controls.Add(resetBtn);
            Controls.Add(twoEurBtn);
            Controls.Add(oneEurBtn);
            Controls.Add(fiftyCentsBtn);
            Controls.Add(twentyCentsBtn);
            Controls.Add(tenCentsBtn);
            Controls.Add(fiveCentsBtn);
            Controls.Add(coffeeBtn);
            Controls.Add(chocolateBtn);
            Controls.Add(capuccinoBtn);
            Controls.Add(doneBtn);
            Controls.Add(teaBtn);
            Name = "Form1";
            Text = "Hotcups";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button teaBtn;
        private Button doneBtn;
        private Button capuccinoBtn;
        private Button chocolateBtn;
        private Button coffeeBtn;
        private Button fiveCentsBtn;
        private Button tenCentsBtn;
        private Button twentyCentsBtn;
        private Button twoEurBtn;
        private Button oneEurBtn;
        private Button fiftyCentsBtn;
        private Button resetBtn;
        private Button cancelBtn;
        private Label totalLabel;
        private Label insertedLabel;
        private Label changeLabel;
        private Label label1;
        private Label label2;
    }
}
