namespace Hotcups
{
    public partial class Form1 : Form
    {
        private double totalInserted = 0;
        private double totalBought = 0;
        private Dictionary<double, int> insertedCoins = new Dictionary<double, int>();
        private Dictionary<double, int> returnedCoins = new Dictionary<double, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void capuccinoBtn_Click(object sender, EventArgs e) { AddToTotal(0.30); }

        private void chocolateBtn_Click(object sender, EventArgs e) { AddToTotal(0.35); }

        private void coffeeBtn_Click(object sender, EventArgs e) { AddToTotal(0.25); }

        private void teaBtn_Click(object sender, EventArgs e) { AddToTotal(0.20); }

        private void AddToTotal(double cost)
        {
            totalBought += cost;
            totalLabel.Text = $"Custo da Bebida: {totalBought:0.00}€";
        }

        private void fiveCentsBtn_Click(object sender, EventArgs e)
        {
            if (insertedCoins.ContainsKey(0.05))
            {
                insertedCoins[0.05]++;
            }
            else
            {
                insertedCoins.Add(0.05, 1);
            }

            fiveCentsBtn.Text = $"0,05€ (x{insertedCoins[0.05]})";
            updateTotalInserted();
        }

        private void tenCentsBtn_Click(object sender, EventArgs e)
        {
            if (insertedCoins.ContainsKey(0.10))
            {
                insertedCoins[0.10]++;
            }
            else
            {
                insertedCoins.Add(0.10, 1);
            }

            tenCentsBtn.Text = $"0,10€  (x{insertedCoins[0.10]})";
            updateTotalInserted();
        }

        private void twentyCentsBtn_Click(object sender, EventArgs e)
        {
            if (insertedCoins.ContainsKey(0.20))
            {
                insertedCoins[0.20]++;
            }
            else
            {
                insertedCoins.Add(0.20, 1);
            }

            twentyCentsBtn.Text = $"0,20€ (x{insertedCoins[0.20]})";
            updateTotalInserted();
        }

        private void fiftyCentsBtn_Click(object sender, EventArgs e)
        {
            if (insertedCoins.ContainsKey(0.50))
            {
                insertedCoins[0.50]++;
            }
            else
            {
                insertedCoins.Add(0.50, 1);
            }

            fiftyCentsBtn.Text = $"0.50€ (x{insertedCoins[0.50]})";
            updateTotalInserted();
        }

        private void oneEurBtn_Click(object sender, EventArgs e)
        {
            if (insertedCoins.ContainsKey(1))
            {
                insertedCoins[1]++;
            }
            else
            {
                insertedCoins.Add(1, 1);
            }

            oneEurBtn.Text = $"1,00€ (x{insertedCoins[1]})";
            updateTotalInserted();
        }

        private void twoEurBtn_Click(object sender, EventArgs e)
        {
            if (insertedCoins.ContainsKey(2))
            {
                insertedCoins[2]++;
            }
            else
            {
                insertedCoins.Add(2, 1);
            }

            twoEurBtn.Text = $"2,00€ (x{insertedCoins[2]})";
            updateTotalInserted();
        }

        private void totalLabel_Click(object sender, EventArgs e)
        {
            // não se faz nada,
        }

        private void insertedLabel_Click(object sender, EventArgs e)
        {
            // nem aqui,
        }

        private void changeLabel_Click(object sender, EventArgs e)
        {
            // nem aqui.
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            if (totalInserted < totalBought)
            {
                MessageBox.Show("Adiciona mais moedas para completares o teu pedido, se faz favor!", "Inseriste moedas Insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                double change = totalInserted - totalBought;
                if (change > 0)
                {
                    MessageBox.Show($"Obrigado pela compra, desfruta da tua bebida quente! O teu troco é {change:0.00}€.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Obrigado pela compra, desfruta da tua bebida quente!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            resetBtn_Click(sender, e);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            totalInserted = 0;
            totalBought = 0;
            insertedCoins.Clear();
            returnedCoins.Clear();
            totalLabel.Text = "Preço da Bebida: 0,00€";
            insertedLabel.Text = "Total Inserido: 0,00€";
            changeLabel.Text = "Troco: 0,00€";
            fiveCentsBtn.Text = "0,05€";
            tenCentsBtn.Text = "0,10€";
            twentyCentsBtn.Text = "0,20€";
            fiftyCentsBtn.Text = "0,50€";
            oneEurBtn.Text = "1,00€";
            twoEurBtn.Text = "2,00€";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateTotalInserted()
        {
            double total = 0;
            foreach (var coin in insertedCoins)
            {
                total += coin.Key * coin.Value;
            }

            totalInserted = total;
            insertedLabel.Text = $"Total Inserido: {total:0.00}€";

            if (totalInserted >= totalBought)
            {
                double change = totalInserted - totalBought;
                changeLabel.Text = $"Troco: {change:0.00}€";
            }
            else
            {
                changeLabel.Text = "Troco: 0,00€";
            }
        }
    }
}