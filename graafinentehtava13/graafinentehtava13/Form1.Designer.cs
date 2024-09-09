namespace graafinentehtava13
{
    partial class SuosikkiForm
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
            label1 = new Label();
            NimiTB = new TextBox();
            VastausLB = new Label();
            TarkastaBT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(337, 15);
            label1.TabIndex = 0;
            label1.Text = "Anna nimesi, niin tarkastan onko se 50 suosituimman joukossa";
            // 
            // NimiTB
            // 
            NimiTB.Location = new Point(401, 45);
            NimiTB.Name = "NimiTB";
            NimiTB.Size = new Size(156, 23);
            NimiTB.TabIndex = 1;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(12, 106);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(46, 15);
            VastausLB.TabIndex = 2;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // TarkastaBT
            // 
            TarkastaBT.Location = new Point(401, 92);
            TarkastaBT.Name = "TarkastaBT";
            TarkastaBT.Size = new Size(156, 29);
            TarkastaBT.TabIndex = 3;
            TarkastaBT.Text = "Tarkasta";
            TarkastaBT.UseVisualStyleBackColor = true;
            TarkastaBT.Click += TarkastaBT_Click;
            // 
            // SuosikkiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 169);
            Controls.Add(TarkastaBT);
            Controls.Add(VastausLB);
            Controls.Add(NimiTB);
            Controls.Add(label1);
            Name = "SuosikkiForm";
            Text = "Onko nimesi suosittujen nimien joukossa?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NimiTB;
        private Label VastausLB;
        private Button TarkastaBT;
    }
}
