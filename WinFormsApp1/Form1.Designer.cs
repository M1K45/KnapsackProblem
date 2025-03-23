namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            itemsNumberBox = new TextBox();
            capacityBox = new TextBox();
            seedBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            runButton = new Button();
            instanceBox = new TextBox();
            resultBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            errorProvider1 = new ErrorProvider(components);
            itemsNumberValidation = new Label();
            capacityValidate = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // itemsNumberBox
            // 
            itemsNumberBox.Location = new Point(112, 73);
            itemsNumberBox.Name = "itemsNumberBox";
            itemsNumberBox.Size = new Size(100, 23);
            itemsNumberBox.TabIndex = 0;
            itemsNumberBox.TextChanged += itemsNumberBox_TextChanged;
            // 
            // capacityBox
            // 
            capacityBox.Location = new Point(112, 217);
            capacityBox.Name = "capacityBox";
            capacityBox.Size = new Size(100, 23);
            capacityBox.TabIndex = 1;
            capacityBox.TextChanged += capacityBox_TextChanged;
            // 
            // seedBox
            // 
            seedBox.Location = new Point(112, 147);
            seedBox.Name = "seedBox";
            seedBox.Size = new Size(100, 23);
            seedBox.TabIndex = 2;
            seedBox.TextChanged += seedBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 55);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 3;
            label1.Text = "number of items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 129);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "seed";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 199);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "capacity";
            // 
            // runButton
            // 
            runButton.Location = new Point(112, 262);
            runButton.Name = "runButton";
            runButton.Size = new Size(75, 23);
            runButton.TabIndex = 6;
            runButton.Text = "run";
            runButton.UseVisualStyleBackColor = true;
            runButton.Click += runButton_Click;
            // 
            // instanceBox
            // 
            instanceBox.Location = new Point(426, 76);
            instanceBox.Multiline = true;
            instanceBox.Name = "instanceBox";
            instanceBox.ReadOnly = true;
            instanceBox.Size = new Size(190, 326);
            instanceBox.TabIndex = 7;
            // 
            // resultBox
            // 
            resultBox.Location = new Point(659, 76);
            resultBox.Multiline = true;
            resultBox.Name = "resultBox";
            resultBox.ReadOnly = true;
            resultBox.Size = new Size(190, 326);
            resultBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(659, 44);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 9;
            label4.Text = "result";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(426, 44);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 10;
            label5.Text = "instance";
            label5.Click += label5_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // itemsNumberValidation
            // 
            itemsNumberValidation.AutoSize = true;
            itemsNumberValidation.Location = new Point(218, 76);
            itemsNumberValidation.Name = "itemsNumberValidation";
            itemsNumberValidation.Size = new Size(204, 15);
            itemsNumberValidation.TabIndex = 11;
            itemsNumberValidation.Text = "Number of items cannot be negative!";
            // 
            // capacityValidate
            // 
            capacityValidate.AutoSize = true;
            capacityValidate.Location = new Point(218, 220);
            capacityValidate.Name = "capacityValidate";
            capacityValidate.Size = new Size(160, 15);
            capacityValidate.TabIndex = 12;
            capacityValidate.Text = "Capacity cannot be negative!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 604);
            Controls.Add(capacityValidate);
            Controls.Add(itemsNumberValidation);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(resultBox);
            Controls.Add(instanceBox);
            Controls.Add(runButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(seedBox);
            Controls.Add(capacityBox);
            Controls.Add(itemsNumberBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox itemsNumberBox;
        private TextBox capacityBox;
        private TextBox seedBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button runButton;
        private TextBox instanceBox;
        private TextBox resultBox;
        private Label label4;
        private Label label5;
        private ErrorProvider errorProvider1;
        private Label capacityValidate;
        private Label itemsNumberValidation;
    }
}
