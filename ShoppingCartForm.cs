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
    public partial class ShoppingCartForm : Form
    {
        public ShoppingCartForm()
        {
            InitializeComponent();
           comboBox1.SelectedIndex = 0;
            using (var dbContext = new WheelEntities())
                dataGridView1.DataSource = dbContext.Wheels.ToArray().Where(good => ShoppingCart.content.ContainsKey(good.Id) && good.Count > 0).ToArray();
            
            
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            var tot = new List<string>();
            decimal totalPrice = 0;
            if (ShoppingCart.content.Count == 0)
            {
                MessageBox.Show("Ты еблан, товаров не добавил");
                return;
            }
            using (var dbContext = new WheelEntities())
            {
                foreach (var good in dbContext.Wheels)
                {
                    if(ShoppingCart.content.ContainsKey(good.Id))
                    {
                        var amount = ShoppingCart.content[good.Id];
                        good.Count -= amount;
                        totalPrice += amount * good.Price.Value;
                        tot.Add(good.Name);
                    }
                }
                dbContext.SaveChanges();
                ShoppingCart.content.Clear();
            }
            (new BuyTicketForm(comboBox1.SelectedItem.ToString(), totalPrice, tot.ToArray())).Show();
            
        }
    }
}
