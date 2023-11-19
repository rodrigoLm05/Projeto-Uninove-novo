namespace ProjetoUninove.Model.Forms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using ProjetoUninove.Model;

    public partial class TravelAutonomyForm : Form
    {
        double  priceGasolina, priceAlcool, priceDiesel;
        double  autonomy;
        double  distance, loadWeight, totalprice, calcLoadWeight;
        double  lessValue;
        int     repeatsDelivery;
        Vehicle vehiclelessValue;

        public TravelAutonomyForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                distance   = Convert.ToDouble(txtDistance.Text);
                loadWeight = Convert.ToDouble(txtWeight.Text);
            }
            catch 
            {
                MessageBox.Show("Valores invalidos", "erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.GetFuelPrice();
           
            foreach (var item in Data.VEHICLES)
            {
                switch (item.Fuel.ToLower())
                {
                    case "gasolina":
                        if (priceGasolina == 0)
                        {
                            MessageBox.Show("Valor da Gasolina não cadastrado", "erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            autonomy = priceGasolina / item.Autonomy;
                        }
                        break;

                    case "diesel":
                        if (priceDiesel == 0)
                        {
                            MessageBox.Show("Valor do Diesel não cadastrado", "erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            autonomy = priceDiesel / item.Autonomy;
                        }
                        break;

                    case "alcool":
                        if (priceAlcool == 0)
                        {
                            MessageBox.Show("Valor do Alcool não cadastrado", "erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            autonomy = priceAlcool / item.Autonomy;
                        }
                        break;
                }

                calcLoadWeight = loadWeight;

                while (calcLoadWeight > 0)
                {
                    calcLoadWeight = calcLoadWeight - item.WeightSupported;
                    repeatsDelivery = repeatsDelivery + 1;
                };

                totalprice = autonomy * distance;
                totalprice = totalprice * repeatsDelivery;

                if (lessValue == 0)
                {
                    lessValue = totalprice;
                    vehiclelessValue = item;
                }
                else if (lessValue > totalprice)
                {
                    lessValue = totalprice;
                    vehiclelessValue = item;
                }
            }

            if (vehiclelessValue == null)
            {
                MessageBox.Show("Nenhum veiculo cadastrado", "erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(lessValue > 0)
            {
                MessageBox.Show(" Tipo do Veículo: " + vehiclelessValue.Type() + "\n Marca: " + vehiclelessValue.Brand + "\n Modelo: " + vehiclelessValue.ModelName + "\n Custo do frete: " + lessValue, "\n Veículo ideal para o transporte: ",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void GetFuelPrice() 
        {
            foreach (var fuels in Data.FUEL_PRICES)
            
                switch (fuels.name.ToLower())
                { 
                    case "gasolina":
                        priceGasolina = fuels.price;
                        break;
                    case "diesel": 
                        priceDiesel = fuels.price;
                        break;
                    case "alcool": 
                        priceAlcool = fuels.price;
                        break;
                }
            }
        }
    }
