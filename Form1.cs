using System;
using System.Windows.Forms;

namespace CoffeeMachineApp
{
    public partial class Form1 : Form
    {
        private VendingMachine vendingMachine;

        public Form1()
        {
            InitializeComponent();
            vendingMachine = new VendingMachine(5000, 1000, 1000, 1000);
            UpdateStockDisplay();
        }

        // อัปเดต UI แสดงค่าของวัตถุดิบ
        private void UpdateStockDisplay()
        {
            txtWater.Text = vendingMachine.Water.ToString();
            txtCoffee.Text = vendingMachine.Coffee.ToString();
            txtChocolate.Text = vendingMachine.Chocolate.ToString();
            txtMilk.Text = vendingMachine.Milk.ToString();
        }

        // กดปุ่มทำเครื่องดื่ม
        private void btnCoffee_Click(object sender, EventArgs e)
        {
            if (vendingMachine.MakeCoffee())
                MessageBox.Show("กาแฟดำพร้อมเสิร์ฟ!");
            else
                MessageBox.Show("วัตถุดิบไม่เพียงพอ!");
            UpdateStockDisplay();
        }

        private void btnMocha_Click(object sender, EventArgs e)
        {
            if (vendingMachine.MakeMocha())
                MessageBox.Show("มอคค่าพร้อมเสิร์ฟ!");
            else
                MessageBox.Show("วัตถุดิบไม่เพียงพอ!");
            UpdateStockDisplay();
        }

        private void btnLatte_Click(object sender, EventArgs e)
        {
            if (vendingMachine.MakeLatte())
                MessageBox.Show("ลาเต้พร้อมเสิร์ฟ!");
            else
                MessageBox.Show("วัตถุดิบไม่เพียงพอ!");
            UpdateStockDisplay();
        }

        private void btnChocolate_Click(object sender, EventArgs e)
        {
            if (vendingMachine.MakeChocolate())
                MessageBox.Show("ช็อกโกแลตร้อนพร้อมเสิร์ฟ!");
            else
                MessageBox.Show("วัตถุดิบไม่เพียงพอ!");
            UpdateStockDisplay();
        }

        // กดปุ่มเติมวัตถุดิบ
        private void btnRefill_Click(object sender, EventArgs e)
        {
            vendingMachine.Refill();
            MessageBox.Show("เติมวัตถุดิบเรียบร้อย!");
            UpdateStockDisplay();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
