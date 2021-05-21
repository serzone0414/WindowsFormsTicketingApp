﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTicketingApp
{
    public partial class Form2 : Form
    {
        //public string enteredRout = "apple";
        public string returnRout;
        List<ListViewItem> listOfWLGAKL = new List<ListViewItem>();
        List<ListViewItem> listOfAKLWLG = new List<ListViewItem>();
        List<ListViewItem> listOfWLGCHC = new List<ListViewItem>();
        List<ListViewItem> listOfCHCWLG = new List<ListViewItem>();
        List<ListViewItem> listOfCHCAKL = new List<ListViewItem>();
        List<ListViewItem> listOfAKLCHC = new List<ListViewItem>();
        List<ListViewItem> displayList = new List<ListViewItem>();
        public Form2()
        {
            InitializeComponent();
            createFlights();

            // label1.Text = "entered: " + enteredRout;

            returnRout = Ticket.Destination + Ticket.Origion;
            SelectDisplayList(returnRout);

            for (int i = 0; i < displayList.Count; i++)
            {
                listView2.Items.Add(displayList[i]);
            }
        }


        public void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Ticket.SecondFlight = displayList[listView2.FocusedItem.Index].Text;
            Ticket.SecondFlightTime = displayList[listView2.FocusedItem.Index].SubItems[1].Text;
            Ticket.SecondFlightPrice = displayList[listView2.FocusedItem.Index].SubItems[2].Text;
            Ticket.Totalprice = int.Parse(Ticket.FirstFlightPrice) + int.Parse(Ticket.SecondFlightPrice);
          //  MessageBox.Show(Ticket.SecondFlight + Ticket.SecondFlightTime + Ticket.SecondFlightPrice);
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        public void createFlights()
        {
            ListViewItem NZ402 = new ListViewItem("NZ402");
            NZ402.SubItems.Add("06:00");
            NZ402.SubItems.Add("180");
            listOfWLGAKL.Add(NZ402);

            ListViewItem NZ414 = new ListViewItem("NZ414");
            NZ414.SubItems.Add("12:00");
            NZ414.SubItems.Add("160");
            listOfWLGAKL.Add(NZ414);

            ListViewItem NZ420 = new ListViewItem("NZ420");
            NZ420.SubItems.Add("19:00");
            NZ420.SubItems.Add("280");
            listOfWLGAKL.Add(NZ420);

            ListViewItem NZ403 = new ListViewItem("NZ403");
            NZ403.SubItems.Add("06:30");
            NZ403.SubItems.Add("100");
            listOfAKLWLG.Add(NZ403);

            ListViewItem NZ415 = new ListViewItem("NZ415");
            NZ415.SubItems.Add("12:30");
            NZ415.SubItems.Add("250");
            listOfAKLWLG.Add(NZ415);

            ListViewItem NZ421 = new ListViewItem("NZ421");
            NZ421.SubItems.Add("19:30");
            NZ421.SubItems.Add("190");
            listOfAKLWLG.Add(NZ421);

            ListViewItem NZ373 = new ListViewItem("NZ373");
            NZ373.SubItems.Add("09:05");
            NZ373.SubItems.Add("255");
            listOfWLGCHC.Add(NZ373);

            ListViewItem NZ5361 = new ListViewItem("NZ5361");
            NZ5361.SubItems.Add("14:15");
            NZ5361.SubItems.Add("343");
            listOfWLGCHC.Add(NZ5361);

            ListViewItem NZ5355 = new ListViewItem("NZ5355");
            NZ5355.SubItems.Add("19:25");
            NZ5355.SubItems.Add("215");
            listOfWLGCHC.Add(NZ5355);

            ListViewItem NZ332 = new ListViewItem("NZ332");
            NZ332.SubItems.Add("06:45");
            NZ332.SubItems.Add("176");
            listOfCHCWLG.Add(NZ332);


            ListViewItem NZ5350 = new ListViewItem("NZ5350");
            NZ5350.SubItems.Add("11:05");
            NZ5350.SubItems.Add("215");
            listOfCHCWLG.Add(NZ5350);

            ListViewItem NZ5356 = new ListViewItem("NZ5356");
            NZ5356.SubItems.Add("18:25");
            NZ5356.SubItems.Add("383");
            listOfCHCWLG.Add(NZ5356);

            ListViewItem NZ563 = new ListViewItem("NZ563");
            NZ563.SubItems.Add("07:00");
            NZ563.SubItems.Add("190");
            listOfAKLCHC.Add(NZ563);

            ListViewItem NZ527 = new ListViewItem("NZ527");
            NZ527.SubItems.Add("11:00");
            NZ527.SubItems.Add("170");
            listOfAKLCHC.Add(NZ527);

            ListViewItem NZ547 = new ListViewItem("NZ547");
            NZ547.SubItems.Add("17:00");
            NZ547.SubItems.Add("270");
            listOfAKLCHC.Add(NZ547);

            ListViewItem NZ526 = new ListViewItem("NZ526");
            NZ526.SubItems.Add("08:00");
            NZ526.SubItems.Add("210");
            listOfCHCAKL.Add(NZ526);

            ListViewItem NZ566 = new ListViewItem("NZ566");
            NZ566.SubItems.Add("14:00");
            NZ566.SubItems.Add("178");
            listOfCHCAKL.Add(NZ566);

            ListViewItem NZ558 = new ListViewItem("NZ558");
            NZ558.SubItems.Add("20:00");
            NZ558.SubItems.Add("293");
            listOfCHCAKL.Add(NZ558);
        }

        private void SelectDisplayList(string enteredRout)
        {
            if (enteredRout.Equals("WellingtonAuckland"))
            {
                displayList = listOfWLGAKL;
            }
            if (enteredRout.Equals("AucklandWellington"))
            {
                displayList = listOfAKLWLG;
            }
            if (enteredRout.Equals("WellingtonChristchurch"))
            {
                displayList = listOfWLGCHC;
            }
            if (enteredRout.Equals("ChristchurchWellington"))
            {
                displayList = listOfCHCWLG;
            }
            if (enteredRout.Equals("ChristchurchAuckland"))
            {
                displayList = listOfCHCAKL;
            }
            if (enteredRout.Equals("AucklandChristchurch"))
            {
                displayList = listOfAKLCHC;
            }
        }
    }
}
