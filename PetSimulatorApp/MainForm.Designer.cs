namespace PetSimulatorApp
{
    partial class MainForm
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
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sampleModePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.oopModeRadioButton = new System.Windows.Forms.RadioButton();
            this.proceduralModeRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.closeButton = new System.Windows.Forms.Button();
            this.mainTableLayoutPanel.SuspendLayout();
            this.sampleModePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.sampleModePanel, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.panel1, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 3;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 516F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(990, 689);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // sampleModePanel
            // 
            this.sampleModePanel.Controls.Add(this.label1);
            this.sampleModePanel.Controls.Add(this.oopModeRadioButton);
            this.sampleModePanel.Controls.Add(this.proceduralModeRadioButton);
            this.sampleModePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sampleModePanel.Location = new System.Drawing.Point(3, 117);
            this.sampleModePanel.Name = "sampleModePanel";
            this.sampleModePanel.Size = new System.Drawing.Size(244, 510);
            this.sampleModePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Sample Mode:";
            // 
            // oopModeRadioButton
            // 
            this.oopModeRadioButton.AutoSize = true;
            this.oopModeRadioButton.Location = new System.Drawing.Point(28, 86);
            this.oopModeRadioButton.Name = "oopModeRadioButton";
            this.oopModeRadioButton.Size = new System.Drawing.Size(122, 29);
            this.oopModeRadioButton.TabIndex = 1;
            this.oopModeRadioButton.TabStop = true;
            this.oopModeRadioButton.Text = "OOP Code";
            this.oopModeRadioButton.UseVisualStyleBackColor = true;
            // 
            // proceduralModeRadioButton
            // 
            this.proceduralModeRadioButton.AutoSize = true;
            this.proceduralModeRadioButton.Location = new System.Drawing.Point(28, 49);
            this.proceduralModeRadioButton.Name = "proceduralModeRadioButton";
            this.proceduralModeRadioButton.Size = new System.Drawing.Size(168, 29);
            this.proceduralModeRadioButton.TabIndex = 0;
            this.proceduralModeRadioButton.TabStop = true;
            this.proceduralModeRadioButton.Text = "Procedural Code";
            this.proceduralModeRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 108);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 65);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pet Simulator";
            // 
            // flowLayoutPanel1
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.closeButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 633);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(984, 53);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(869, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(112, 41);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "&Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 689);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.sampleModePanel.ResumeLayout(false);
            this.sampleModePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel mainTableLayoutPanel;
        private Panel sampleModePanel;
        private RadioButton oopModeRadioButton;
        private RadioButton proceduralModeRadioButton;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button closeButton;
    }
}