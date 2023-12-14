using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wheel
{
    public partial class Form1 : Form
    {
        private int? _goodId = null;
        public Form1()
        {
            InitializeComponent();
            using(var dbContext = new WheelEntities())
                dataGridView1.DataSource = dbContext.Wheels.Where(good => good.Count > 0).ToArray();
            
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;
            _goodId = null;
            var cur = dataGridView1.HitTest(e.X, e.Y).RowIndex;
            if(cur >= 0 && dataGridView1.Rows[cur].Cells[0].Value is int goodId)
            {
                _goodId = goodId;
                goodContextMenu.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }

        private void goodContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name != "buyOption" && _goodId != null)
                return;
            using (var dbContext = new WheelEntities())
            {
                var good = dbContext.Wheels.FirstOrDefault(dbgood  => dbgood.Id == _goodId);
                
                if(good == null)
                {
                    MessageBox.Show("Такого товара нет в бд");
                    return;
                }

                if(good.Count > 0)
                {
                    if (ShoppingCart.content.ContainsKey(good.Id))
                        ShoppingCart.content[good.Id]++;
                    else
                        ShoppingCart.content.Add(good.Id, 1);
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (var dbContext = new WheelEntities())
                dataGridView1.DataSource = dbContext.Wheels.Where(good => good.Count > 0).ToArray();
        }

        private void shoppingCartButton_Click(object sender, EventArgs e)
        {
            (new ShoppingCartForm()).Show();
        }
    }
}
