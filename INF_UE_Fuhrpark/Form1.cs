namespace INF_UE_Fuhrpark
{
    public partial class Form1 : Form
    {
        private double priceGes = 0;
        public Form1()
        {
            InitializeComponent();
            cbMarken.Items.Add("-");
            cbMarken.Items.Add("BMW");
            cbMarken.Items.Add("Audi");
            cbMarken.Items.Add("Porsche");

            cbColor.Items.Add("Blau");
            cbColor.Items.Add("Weiﬂ");
            cbColor.Items.Add("Rot");
            cbColor.Items.Add("Racing Green");
        }

        private void cbMarken_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbModel.Items.Clear();
            switch (cbMarken.Text)
            {
                case "BMW":

                    cbModel.Items.Add("M3");
                    cbModel.Items.Add("M4");
                    cbModel.Items.Add("XM");
                    break;
                case "Audi":
                    cbModel.Items.Add("S8");
                    cbModel.Items.Add("A4");
                    cbModel.Items.Add("RS3");
                    break;
                case "Porsche":
                    cbModel.Items.Add("911 Turbo S");
                    cbModel.Items.Add("911 GT3RS");
                    cbModel.Items.Add("911 GT2RS");
                    break;
            }

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            double price = Convert.ToInt32(tbPrice.Text);
            String car = cbMarken.Text + ", " + cbModel.Text + " , "
                       + cbColor.Text + ", " + price + " $";

            lbCars.Items.Add(car);

            priceGes += price;
            lblPriceGes.Text = priceGes.ToString();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            String sCar = lbCars.SelectedItem.ToString();

            String[] help = sCar.Split(",");
            double price = Convert.ToInt32(help[3].Replace("$", ""));
            priceGes -= price;
            lblPriceGes.Text = priceGes.ToString();

            lbCars.Items.Remove(sCar);

        }

        private void btUp_Click(object sender, EventArgs e)
        {
            int sCarIndex = lbCars.SelectedIndex;
            String sCar = lbCars.SelectedItem.ToString();
            String carBefore = lbCars.Items[sCarIndex - 1].ToString();

            lbCars.Items[sCarIndex] = carBefore;
            lbCars.Items[sCarIndex - 1] = sCar;
        }

        private void btDown_Click(object sender, EventArgs e)
        {
            int sCarIndex = lbCars.SelectedIndex;
            String sCar = lbCars.SelectedItem.ToString();
            String carAfter = lbCars.Items[sCarIndex + 1].ToString();

            lbCars.Items[sCarIndex] = carAfter;
            lbCars.Items[sCarIndex + 1] = sCar;

            
        }

        
    }
}
