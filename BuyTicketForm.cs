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
    public partial class BuyTicketForm : Form
    {
        public BuyTicketForm(string address, decimal totalPrice, params string[] tot)
        {
            InitializeComponent();
            listLabel.Text = "Номер заказа: " + Guid.NewGuid().ToString();

            listLabel.Text += Environment.NewLine + "Вы приобрели: " + string.Join(",", tot);

            listLabel.Text += Environment.NewLine + "Дата оформления заказа: " + DateTime.Now.ToString("g");

            listLabel.Text += Environment.NewLine + "Дата выдачи заказа: " + DateTime.Now.AddDays(2).ToShortDateString();

            listLabel.Text += Environment.NewLine + "Итоговая сумма: " + totalPrice.ToString("F0") + " руб";

            listLabel.Text += Environment.NewLine + "Код получения: " + string.Join("", Guid.NewGuid().ToString().Where(char.IsDigit).Take(3));

            listLabel.Text += Environment.NewLine + "Доставка по адресу: " + address;



        }

        private void listLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
