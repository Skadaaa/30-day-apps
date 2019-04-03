using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Proiect_semestru_VLADU_STEFAN_ALEXANDRU_GRUPA_615
{
    public partial class MainProgram : Form
    {
        public MainProgram()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] cars = File.ReadAllLines("available.txt");
            string[] check = File.ReadAllLines("reserved.txt");

       
            
            boxCars.Visible = true;
            boxCars.Items.Clear();
            foreach (string car in cars)
            {
                boxCars.Items.Add(car);
               
                    }

       

            reservedCars.Visible = true;

            availableBtn.Visible = false;
            hideCars.Visible = true;
            removeCar.Visible = true;
            reserveBtn.Visible = true;


        }

        private void hideCars_Click(object sender, EventArgs e)
        {
            boxCars.Visible = false;
            availableBtn.Visible = true;


        }

        private void reserveBtn_Click(object sender, EventArgs e)
        {
            for (int intCount = boxCars.SelectedItems.Count - 1; intCount >= 0; intCount--)
            {
               reservedCars.Items.Add(boxCars.SelectedItems[intCount]);
                boxCars.Items.Remove(boxCars.SelectedItems[intCount]);
                calendar.Visible = true;
                calendar2.Visible = true;
                labelTo.Visible = true;
                labelFrom.Visible = true;
            }



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int intCount = reservedCars.SelectedItems.Count - 1; intCount >= 0; intCount--)
            {
                boxCars.Items.Add(reservedCars.SelectedItems[intCount]);
                reservedCars.Items.Remove(reservedCars.SelectedItems[intCount]);
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            List<string> x = new List<string>();


            string text = "";

            foreach (var item in reservedCars.Items)
            {
                text += item.ToString() + " reserved from " + calendar.Value +" to "+calendar2.Value + Environment.NewLine;
                x.Add(text);
            }

            File.AppendAllLines("reserved.txt", x);
            


        }

        private void MainProgram_Load(object sender, EventArgs e)
        {

        }
    }
}
