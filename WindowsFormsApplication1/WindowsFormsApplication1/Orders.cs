using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Orders : Form
    {
        //Establish connection class and set counters
        MySqlConnection mcon = new MySqlConnection("datasource=localhost;port= 3306;username= root;password= root");
        MySqlCommand mcd;
        MySqlDataReader mdr;
        string s;
        int clickCounterSearch = 0;
        int clickCounterInfo = 0;


        //Initialise and populate combobox
        public Orders()
        {
            InitializeComponent();
            comboBox1.Items.Add("Pending");
            comboBox1.Items.Add("Being picked");
            comboBox1.Items.Add("Picked");
            comboBox1.Items.Add("Being packed");
            comboBox1.Items.Add("Packed");
            comboBox1.Items.Add("Awaiting dispatch");
            comboBox1.Items.Add("Dispatched");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Function to open the connection
        public void openCon()
        {
            if (mcon.State == ConnectionState.Closed)
            {
                mcon.Open();
            }
        }


        //Function to close the connection
        public void closeCon()
        {
            if (mcon.State == ConnectionState.Open)
            {
                mcon.Close();
            }
        }


        
        //Search the order list
        private void searchBtn_Click_1(object sender, EventArgs e)
        {
            //Only allow one button click
            if (clickCounterSearch < 1)
            {
                try
                {
                    mcon.Open();
                    s = "select * from wots.orders";
                    mcd = new MySqlCommand(s, mcon);
                    mdr = mcd.ExecuteReader();

                    //Populate the list box to show the orders
                    while (mdr.Read())
                    {
                        orderIDList.Items.Add(mdr.GetString("orderID") + "  " + mdr.GetString("orderState") +
                            "  " + mdr.GetString("datePlaced") + "  " + mdr.GetString("customerName"));
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    mdr.Close();
                    mcon.Close();
                }
                clickCounterSearch += 1;
            }

        }


        //Recover order info
        private void infoBtn_Click(object sender, EventArgs e)
        {
            //Only allow one button click
            if (clickCounterInfo < 1)
            {
            try
                {
                    mcon.Open();
                    s = "select * from wots.orderitems where orderID=" + int.Parse(orderIDBox.Text);
                    mcd = new MySqlCommand(s, mcon);
                    mdr = mcd.ExecuteReader();

                    //Populate list box with order details
                    while (mdr.Read())
                    {
                        orderBox.Items.Add(mdr.GetString("orderID") + "        " +
                                    "       " + mdr.GetString("productName") + "        " + mdr.GetString("porousware") +
                            "                   " + mdr.GetString("quantity") + "            " + mdr.GetString("productLocation"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    mdr.Close();
                    mcon.Close();
                }
                clickCounterInfo++;
            }
            
        }

        //Query to update order
        public void ExecuteQuery(string q)
        {
            try
            {
                openCon();
                mcd = new MySqlCommand(q, mcon);
                if (mcd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Order status changed");
                }
                else
                {
                    MessageBox.Show("Query Not Executed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeCon();
            }
        }

        //Update order status
        private void updateBtn_Click(object sender, EventArgs e)
        {
            //Update the table where the ID matches the ID text box
            string query = "update wots.orders set orderState = ' " + comboBox1.Text + " ' where orderID = " + int.Parse(orderIDBox.Text);

            ExecuteQuery(query);
        }

        //Refresh the window
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            //Reset button click counters
            clickCounterSearch = 0;
            clickCounterInfo = 0;

            //Reset boxes
            orderIDBox.Text = "Order ID";
            orderIDList.Items.Clear();
            orderBox.Items.Clear();
            comboBox1.Text = "Status";
        }
    }
    }
