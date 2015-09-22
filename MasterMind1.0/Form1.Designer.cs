namespace MasterMind1._0
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.neueSpeilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.difficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backdropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cedarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spruceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.MarbleSelectionPB = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarbleSelectionPB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neueSpeilToolStripMenuItem,
            this.difficultyToolStripMenuItem,
            this.backdropToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(362, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // neueSpeilToolStripMenuItem
            // 
            this.neueSpeilToolStripMenuItem.Name = "neueSpeilToolStripMenuItem";
            this.neueSpeilToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.neueSpeilToolStripMenuItem.Text = "Neue Speil";
            this.neueSpeilToolStripMenuItem.Click += new System.EventHandler(this.neueSpeilToolStripMenuItem_Click);
            // 
            // difficultyToolStripMenuItem
            // 
            this.difficultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.hardToolStripMenuItem});
            this.difficultyToolStripMenuItem.Name = "difficultyToolStripMenuItem";
            this.difficultyToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.difficultyToolStripMenuItem.Text = "Difficulty";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.easyToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hardToolStripMenuItem.Text = "Hard";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.hardToolStripMenuItem_Click);
            // 
            // backdropToolStripMenuItem
            // 
            this.backdropToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cedarToolStripMenuItem,
            this.spruceToolStripMenuItem,
            this.pineToolStripMenuItem});
            this.backdropToolStripMenuItem.Name = "backdropToolStripMenuItem";
            this.backdropToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.backdropToolStripMenuItem.Text = "Backdrop";
            // 
            // cedarToolStripMenuItem
            // 
            this.cedarToolStripMenuItem.Name = "cedarToolStripMenuItem";
            this.cedarToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.cedarToolStripMenuItem.Text = "Cedar";
            this.cedarToolStripMenuItem.Click += new System.EventHandler(this.cedarToolStripMenuItem_Click);
            // 
            // spruceToolStripMenuItem
            // 
            this.spruceToolStripMenuItem.Name = "spruceToolStripMenuItem";
            this.spruceToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.spruceToolStripMenuItem.Text = "Spruce";
            this.spruceToolStripMenuItem.Click += new System.EventHandler(this.spruceToolStripMenuItem_Click);
            // 
            // pineToolStripMenuItem
            // 
            this.pineToolStripMenuItem.Name = "pineToolStripMenuItem";
            this.pineToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.pineToolStripMenuItem.Text = "Pine";
            this.pineToolStripMenuItem.Click += new System.EventHandler(this.pineToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wählen einen Marmor";
            // 
            // MarbleSelectionPB
            // 
            this.MarbleSelectionPB.BackColor = System.Drawing.Color.Transparent;
            this.MarbleSelectionPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MarbleSelectionPB.Location = new System.Drawing.Point(77, 65);
            this.MarbleSelectionPB.Name = "MarbleSelectionPB";
            this.MarbleSelectionPB.Size = new System.Drawing.Size(192, 32);
            this.MarbleSelectionPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MarbleSelectionPB.TabIndex = 2;
            this.MarbleSelectionPB.TabStop = false;
            this.MarbleSelectionPB.Click += new System.EventHandler(this.MarbleSelectionPB_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 734);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MarbleSelectionPB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MarbleSelectionPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem neueSpeilToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox MarbleSelectionPB;
        private System.Windows.Forms.ToolStripMenuItem difficultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backdropToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem cedarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spruceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pineToolStripMenuItem;
    }
}

