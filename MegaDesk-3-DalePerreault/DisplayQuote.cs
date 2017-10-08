using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace MegaDesk_4_DalePerreault
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
            List<Deskquote> list = GetQuotes();
            DataTable dt = CreateTable(list);
            viewOrdersGridView.Columns.Clear();
            viewOrdersGridView.DataSource = dt;
        }

        private void DisPlayQuote_closing(object sender, FormClosingEventArgs e)
        {
            FormProvider.menu1.Show();
        }

        private static DataTable CreateTable(List<Deskquote> quotes)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("custName");
            dt.Columns.Add("width");
            dt.Columns.Add("depth");
            dt.Columns.Add("drawers");
            dt.Columns.Add("surface");
            dt.Columns.Add("orderDate");
            dt.Columns.Add("price");

            foreach (var quote in quotes)
            {
                var row = dt.NewRow();
                row["custName"] = quote.custName;
                row["width"] = quote.custDesk.width;
                row["depth"] = quote.custDesk.depth;
                row["drawers"] = quote.custDesk.drawers;
                row["surface"] = quote.custDesk.surface;
                row["orderDate"] = quote.orderDate;
                row["price"] = quote.price;

                dt.Rows.Add(row);
            }

            return dt;
        }

        private List<Deskquote> GetQuotes()
        {
            StreamReader sr = new StreamReader("C:\\Users\\Dale\\source\\repos\\MegaDesk-4-DalePerreault\\MegaDesk-3-DalePerreault\\bin\\Debug\\quotes.json");
            List<Deskquote> list = new List<Deskquote>();
            while (!sr.EndOfStream)
            {
                string json = sr.ReadLine();
                Deskquote j1 = JsonConvert.DeserializeObject<Deskquote>(json);
                // MessageBox.Show(j1.custName + " " + j1.orderDate + " " + j1.price);
                list.Add(j1);
            }
            sr.Close();
            return list;
        }
    }
}
