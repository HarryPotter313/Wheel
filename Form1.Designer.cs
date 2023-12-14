namespace Wheel
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.shoppingCartButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.goodContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buyOption = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.goodContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 397);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // shoppingCartButton
            // 
            this.shoppingCartButton.Location = new System.Drawing.Point(713, 12);
            this.shoppingCartButton.Name = "shoppingCartButton";
            this.shoppingCartButton.Size = new System.Drawing.Size(75, 23);
            this.shoppingCartButton.TabIndex = 1;
            this.shoppingCartButton.Text = "Корзина";
            this.shoppingCartButton.UseMnemonic = false;
            this.shoppingCartButton.UseVisualStyleBackColor = true;
            this.shoppingCartButton.Click += new System.EventHandler(this.shoppingCartButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(12, 12);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Обновить";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // goodContextMenu
            // 
            this.goodContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buyOption});
            this.goodContextMenu.Name = "goodContextMenu";
            this.goodContextMenu.Size = new System.Drawing.Size(173, 26);
            this.goodContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.goodContextMenu_ItemClicked);
            // 
            // buyOption
            // 
            this.buyOption.Name = "buyOption";
            this.buyOption.Size = new System.Drawing.Size(172, 22);
            this.buyOption.Text = "Добавить к заказу";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.shoppingCartButton);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "ООО \"Руль\"";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.goodContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button shoppingCartButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ContextMenuStrip goodContextMenu;
        private System.Windows.Forms.ToolStripMenuItem buyOption;
    }
}

