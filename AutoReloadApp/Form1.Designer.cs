namespace AutoReloadApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            start = new Button();
            stop = new Button();
            label1 = new Label();
            inputDuration = new TextBox();
            SuspendLayout();
            // 
            // start
            // 
            start.BackColor = Color.FromArgb(0, 205, 151);
            start.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            start.ForeColor = Color.White;
            start.Location = new Point(223, 366);
            start.Name = "start";
            start.Size = new Size(160, 60);
            start.TabIndex = 2;
            start.Text = "start";
            start.UseVisualStyleBackColor = false;
            start.Click += start_Click;
            // 
            // stop
            // 
            stop.BackColor = Color.FromArgb(247, 86, 91);
            stop.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            stop.ForeColor = Color.White;
            stop.Location = new Point(447, 366);
            stop.Name = "stop";
            stop.Size = new Size(160, 60);
            stop.TabIndex = 3;
            stop.Text = "stop";
            stop.UseVisualStyleBackColor = false;
            stop.Click += stop_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(175, 58);
            label1.Name = "label1";
            label1.Size = new Size(848, 217);
            label1.TabIndex = 4;
            label1.Text = "00:00:00";
            // 
            // inputDuration
            // 
            inputDuration.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inputDuration.Location = new Point(679, 366);
            inputDuration.Multiline = true;
            inputDuration.Name = "inputDuration";
            inputDuration.Size = new Size(277, 56);
            inputDuration.TabIndex = 5;
            inputDuration.TextChanged += inputDuration_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 38, 48);
            ClientSize = new Size(1178, 475);
            Controls.Add(inputDuration);
            Controls.Add(label1);
            Controls.Add(stop);
            Controls.Add(start);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AutoReload";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button start;
        private Button stop;
        private Label label1;
        private TextBox inputDuration;
    }
}
