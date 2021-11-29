
namespace task02
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.butDell = new System.Windows.Forms.Button();
            this.butdefault = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Ezio Auditore da Firenze",
            "Altaïr Ibn-LaʼAhad",
            "Haytham Kenway",
            "Edward James Kenway",
            "Shay Patrick Cormac",
            "Arno Victor Dorian",
            "Eivor Varinsdottir"});
            this.listBox1.Location = new System.Drawing.Point(281, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 274);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // butDell
            // 
            this.butDell.Location = new System.Drawing.Point(93, 180);
            this.butDell.Name = "butDell";
            this.butDell.Size = new System.Drawing.Size(75, 23);
            this.butDell.TabIndex = 1;
            this.butDell.Text = "dell";
            this.butDell.UseVisualStyleBackColor = true;
            this.butDell.Click += new System.EventHandler(this.butDell_Click);
            // 
            // butdefault
            // 
            this.butdefault.Location = new System.Drawing.Point(589, 180);
            this.butdefault.Name = "butdefault";
            this.butdefault.Size = new System.Drawing.Size(75, 23);
            this.butdefault.TabIndex = 2;
            this.butdefault.Text = "default";
            this.butdefault.UseVisualStyleBackColor = true;
            this.butdefault.Click += new System.EventHandler(this.butdefault_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butdefault);
            this.Controls.Add(this.butDell);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button butDell;
        private System.Windows.Forms.Button butdefault;
    }
}

