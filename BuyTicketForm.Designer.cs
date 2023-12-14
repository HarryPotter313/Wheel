namespace Wheel
{
    partial class BuyTicketForm
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
            this.listLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listLabel
            // 
            this.listLabel.Location = new System.Drawing.Point(12, 9);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(273, 186);
            this.listLabel.TabIndex = 0;
            this.listLabel.Text = "label1";
            this.listLabel.Click += new System.EventHandler(this.listLabel_Click);
            // 
            // BuyTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 204);
            this.Controls.Add(this.listLabel);
            this.MaximumSize = new System.Drawing.Size(313, 243);
            this.MinimumSize = new System.Drawing.Size(313, 243);
            this.Name = "BuyTicketForm";
            this.Text = "Талон";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label listLabel;
    }
}