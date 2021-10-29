using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using webszolgaltatas.MnbServiceReference;

namespace webszolgaltatas
{
    public partial class Form1 : Form
    {
        class RateData
        {
            public DateTime Date { get; set; }
            public string Currency { get; set; }
            public decimal Value { get; set; }
        }

        BindingList<RateData> Rates = new BindingList<RateData>(); 
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = Rates;
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };
            var response = mnbService.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;
        }
    }
}
