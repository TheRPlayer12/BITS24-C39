namespace BITS24_C39
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
            flowLayoutPanel = new FlowLayoutPanel();
            timer1 = new System.Windows.Forms.Timer(components);
            Attempts_Lbl = new Label();
            Matches_Lbl = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Location = new Point(329, 33);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(459, 379);
            flowLayoutPanel.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Attempts_Lbl
            // 
            Attempts_Lbl.AutoSize = true;
            Attempts_Lbl.Font = new Font("Segoe UI", 22F);
            Attempts_Lbl.Location = new Point(132, 169);
            Attempts_Lbl.Name = "Attempts_Lbl";
            Attempts_Lbl.Size = new Size(34, 41);
            Attempts_Lbl.TabIndex = 1;
            Attempts_Lbl.Text = "0";
            Attempts_Lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Matches_Lbl
            // 
            Matches_Lbl.AutoSize = true;
            Matches_Lbl.Font = new Font("Segoe UI", 22F);
            Matches_Lbl.Location = new Point(132, 270);
            Matches_Lbl.Name = "Matches_Lbl";
            Matches_Lbl.Size = new Size(34, 41);
            Matches_Lbl.TabIndex = 2;
            Matches_Lbl.Text = "0";
            Matches_Lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(95, 227);
            label1.Name = "label1";
            label1.Size = new Size(104, 32);
            label1.TabIndex = 4;
            label1.Text = "Matches";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(95, 121);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 3;
            label2.Text = "Attempts";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30F);
            label3.Location = new Point(24, 15);
            label3.Name = "label3";
            label3.Size = new Size(285, 54);
            label3.TabIndex = 5;
            label3.Text = "Card Matching";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(12, 377);
            button1.Name = "button1";
            button1.Size = new Size(297, 61);
            button1.TabIndex = 6;
            button1.Text = "Restart";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(Matches_Lbl);
            Controls.Add(Attempts_Lbl);
            Controls.Add(flowLayoutPanel);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Matching Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Timer timer1;
        private Label Attempts_Lbl;
        private Label Matches_Lbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}
