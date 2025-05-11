namespace OOP_Lab_6;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        textBox1 = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        textBox2 = new System.Windows.Forms.TextBox();
        textBox3 = new System.Windows.Forms.TextBox();
        button3 = new System.Windows.Forms.Button();
        textBox4 = new System.Windows.Forms.TextBox();
        panel1 = new System.Windows.Forms.Panel();
        panel2 = new System.Windows.Forms.Panel();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        textBox1.Location = new System.Drawing.Point(12, 30);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(293, 27);
        textBox1.TabIndex = 0;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(12, 9);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 1;
        label1.Text = "Вектор";
        // 
        // button1
        // 
        button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        button1.Location = new System.Drawing.Point(0, 10);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(187, 31);
        button1.TabIndex = 2;
        button1.Text = "Рассчитать сумму";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        button2.Location = new System.Drawing.Point(0, 8);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(187, 31);
        button2.TabIndex = 3;
        button2.Text = "Сгенерировать случ.";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // textBox2
        // 
        textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        textBox2.Location = new System.Drawing.Point(193, 13);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(100, 27);
        textBox2.TabIndex = 4;
        // 
        // textBox3
        // 
        textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        textBox3.Location = new System.Drawing.Point(193, 10);
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(100, 27);
        textBox3.TabIndex = 5;
        // 
        // button3
        // 
        button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        button3.Location = new System.Drawing.Point(12, 168);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(293, 37);
        button3.TabIndex = 6;
        button3.Text = "Получить системное время";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // textBox4
        // 
        textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        textBox4.Location = new System.Drawing.Point(12, 224);
        textBox4.Name = "textBox4";
        textBox4.Size = new System.Drawing.Size(293, 27);
        textBox4.TabIndex = 7;
        // 
        // panel1
        // 
        panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        panel1.Controls.Add(button1);
        panel1.Controls.Add(textBox2);
        panel1.Location = new System.Drawing.Point(12, 114);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(293, 48);
        panel1.TabIndex = 8;
        // 
        // panel2
        // 
        panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        panel2.Controls.Add(button2);
        panel2.Controls.Add(textBox3);
        panel2.Location = new System.Drawing.Point(12, 64);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(293, 44);
        panel2.TabIndex = 9;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(317, 278);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Controls.Add(textBox4);
        Controls.Add(button3);
        Controls.Add(label1);
        Controls.Add(textBox1);
        Text = "Form1";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.TextBox textBox4;

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox textBox1;

    #endregion
}