using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
  using System.Data.SqlClient;

namespace WindowsFormsApplication13
{
    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\THARINDU\Documents\Visual Studio 2013\Projects\WindowsFormsApplication13\WindowsFormsApplication13\Database2.mdf;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label19_Click(object sender, EventArgs e)
        {
           

        }

        private void label29_Click(object sender, EventArgs e)
        {
            
        }

        //EXIT BUTTONS

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void pictureBox57_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void pictureBox60_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void pictureBox61_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void pictureBox62_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void label17_Click(object sender, EventArgs e) 
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {
            
        }

        private void label45_Click(object sender, EventArgs e)
        {
            
        }

        private void label55_Click(object sender, EventArgs e)
        {
            
        }

        private void label71_Click(object sender, EventArgs e)
        {
            
        }

        private void label63_Click(object sender, EventArgs e)
        {
            textBox32.Clear();
            textBox33.Clear();
            textBox34.Clear();
            textBox35.Clear();
            textBox36.Clear();
            comboBox6.ResetText();
        }

        private void label64_Click(object sender, EventArgs e)
        {

        }

        //CLEAR ADD VEHICLE TEXTBOXES

        public void clear_vehicle()
        {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                comboBox4.ResetText();
        }

        //CLEAR ADD DRIVER TEXTBOXES

        public void clear_driver()
        {
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox17.Clear();
            textBox7.Clear();
            comboBox1.ResetText();
        }

        private void pictureBox69_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        //SEARCH VEHICLE DETAILS

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            try
            {
                string vechicle_search = textBox5.Text;
                string query = "SELECT * from vehicle_details WHERE vehicle_no = @vehicle_search";
                conn.Open();
                SqlCommand search = new SqlCommand(query, conn);
                search.Parameters.AddWithValue("@vehicle_search", vechicle_search);
                SqlDataReader results = search.ExecuteReader();
                if (results.HasRows)
                {
                    while (results.Read())
                    {
                        textBox1.Text = results[1].ToString();
                        textBox2.Text = results[2].ToString();
                        textBox3.Text = results[3].ToString();
                        textBox4.Text = results[4].ToString();
                        comboBox4.Text = results[5].ToString();
                        textBox11.Text = results[6].ToString();
                        textBox10.Text = results[7].ToString();
                        textBox9.Text = results[8].ToString();

                    }
                }
                else
                {
                    MessageBox.Show("Vehicle number not found!");
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conn.Close();
            }
        }


        private void label20_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {
            
        }

        private void label21_Click(object sender, EventArgs e)
        {
            
        }

        //SEARCH DRIVER DETAILS

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            try
            {
                string driver_search = textBox6.Text;
                string query = "SELECT * from driver_details WHERE nic = @driver_search";
                conn.Open();
                SqlCommand search = new SqlCommand(query, conn);
                search.Parameters.AddWithValue("@driver_search", driver_search);
                SqlDataReader results = search.ExecuteReader();
                if (results.HasRows)
                {
                    while (results.Read())
                    {
                        comboBox1.Text = results[1].ToString();
                        textBox17.Text = results[2].ToString();
                        textBox15.Text = results[3].ToString();
                        textBox14.Text = results[4].ToString();
                        textBox13.Text = results[5].ToString();
                        textBox7.Text = results[6].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("NIC not found!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void label76_Click(object sender, EventArgs e)
        {
  
        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label77_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        //DRIVER DAILY RENT THROUGH COMBOBOX 

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string name = comboBox8.Text;
                string query = "SELECT * FROM driver_details WHERE name = @name";
                conn.Open();
                SqlCommand search = new SqlCommand(query, conn);
                search.Parameters.AddWithValue("@name", name);
                SqlDataReader result = search.ExecuteReader();
                while (result.Read())
                {
                    textBox21.Text = result[6].ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        //VEHICLE RENT DATA THROUGH COMBOBOX 

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string vehicle_no = comboBox7.Text;
                string query = "SELECT * FROM vehicle_details WHERE vehicle_no = @vehicle_no";
                conn.Open();
                SqlCommand search = new SqlCommand(query, conn);
                search.Parameters.AddWithValue("@vehicle_no", vehicle_no);
                SqlDataReader result = search.ExecuteReader();
                while (result.Read())
                {
                    textBox24.Text = result[7].ToString();
                    textBox23.Text = result[8].ToString();

                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void label44_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label46_Click(object sender, EventArgs e)
        {
     
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database2DataSet5.driver_details' table. You can move, or remove it, as needed.
            this.driver_detailsTableAdapter1.Fill(this.database2DataSet5.driver_details);
            // TODO: This line of code loads data into the 'database2DataSet4.vehicle_details' table. You can move, or remove it, as needed.
            this.vehicle_detailsTableAdapter3.Fill(this.database2DataSet4.vehicle_details);
            // TODO: This line of code loads data into the 'database2DataSet3.vehicle_details' table. You can move, or remove it, as needed.
            this.vehicle_detailsTableAdapter2.Fill(this.database2DataSet3.vehicle_details);
            // TODO: This line of code loads data into the 'database2DataSet2.vehicle_details' table. You can move, or remove it, as needed.
            this.vehicle_detailsTableAdapter1.Fill(this.database2DataSet2.vehicle_details);
            // TODO: This line of code loads data into the 'database2DataSet1.driver_details' table. You can move, or remove it, as needed.
            this.driver_detailsTableAdapter.Fill(this.database2DataSet1.driver_details);
            // TODO: This line of code loads data into the 'database2DataSet.vehicle_details' table. You can move, or remove it, as needed.
            this.vehicle_detailsTableAdapter.Fill(this.database2DataSet.vehicle_details);

            //find driver count 
            int count_drivers = A();
            label5.Text = count_drivers.ToString();

            //find vehicle count 
            int count_vehicles = B();
            label6.Text = count_vehicles.ToString();

            //find total earnings hire
            string MyQuery = "SELECT SUM(payment) from hire_details";
            SqlCommand cmd = new SqlCommand(MyQuery, conn);
            conn.Open();
            string hire_earnings = cmd.ExecuteScalar().ToString();
            conn.Close();

            //find total earnings rent
            string MyQuery1 = "SELECT SUM(fee) from rent_details";
            SqlCommand cmd1 = new SqlCommand(MyQuery1, conn);
            conn.Open();
            string rent_earnings = cmd1.ExecuteScalar().ToString();
            conn.Close();

            //sum of total earnings
            label23.Text = (int.Parse(hire_earnings) + int.Parse(rent_earnings)).ToString();


        }

        // CALCULATE NUMBER OF DAYS 

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan difference = (dateTimePicker2.Value - dateTimePicker1.Value);
            double days = (difference.TotalDays) + 1;
            textBox26.Text = days.ToString();
        }

        //CLEAR VEHICLE TEXTBOXES

        private void button1_Click_2(object sender, EventArgs e)
        {
            clear_vehicle();
        }

        //INSERT VEHICLE DETAILS

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                string vehicle_no = textBox1.Text;
                string model = textBox2.Text;
                string capacity = textBox3.Text;
                int seat_count = int.Parse(textBox4.Text);
                string category = comboBox4.Text;
                string cha_no = textBox11.Text;
                float daily_rent = float.Parse(textBox10.Text);
                float weekly_rent = float.Parse(textBox9.Text);
                string query = "INSERT INTO vehicle_details (vehicle_no, model, capacity, seat_count, category, cha_no, daily_rent, weekly_rent) VALUES (@vehicle_no, @model, @capacity, @seat_count, @category, @cha_no, @daily_rent, @weekly_rent)";
                conn.Open();
                SqlCommand ins = new SqlCommand(query, conn);
                ins.Parameters.AddWithValue("@vehicle_no", vehicle_no);
                ins.Parameters.AddWithValue("@model", model);
                ins.Parameters.AddWithValue("@capacity", capacity);
                ins.Parameters.AddWithValue("@seat_count", seat_count);
                ins.Parameters.AddWithValue("@category", category);
                ins.Parameters.AddWithValue("@cha_no", cha_no);
                ins.Parameters.AddWithValue("@daily_rent", daily_rent);
                ins.Parameters.AddWithValue("@weekly_rent", weekly_rent);
                ins.ExecuteNonQuery();
                //data saved
                MessageBox.Show("Data Saved!");
                clear_vehicle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        //UPDATE VEHICLE DETAILS

        private void button3_Click(object sender, EventArgs e)
        {
             try
            {
                string vehicle_search = textBox5.Text;
                string vehicle_no = textBox1.Text;
                string model = textBox2.Text;
                string capacity = textBox3.Text;
                int seat_count = int.Parse(textBox4.Text);
                string category = comboBox4.Text;
                string cha_no = textBox11.Text;
                float daily_rent = float.Parse(textBox10.Text);
                float weekly_rent = float.Parse(textBox9.Text);
                string query = "UPDATE vehicle_details SET vehicle_no = @vehicle_no, model = @model, capacity = @capacity, seat_count = @seat_count, category = @category, cha_no = @cha_no, daily_rent = @daily_rent, weekly_rent = @weekly_rent WHERE @vehicle_search = vehicle_no";
                conn.Open();
                SqlCommand update = new SqlCommand(query, conn);
                update.Parameters.AddWithValue("@vehicle_no", vehicle_no);
                update.Parameters.AddWithValue("@vehicle_search", vehicle_search);
                update.Parameters.AddWithValue("@model", model);
                update.Parameters.AddWithValue("@capacity", capacity);
                update.Parameters.AddWithValue("@seat_count", seat_count);
                update.Parameters.AddWithValue("@category", category);
                update.Parameters.AddWithValue("@cha_no", cha_no);
                update.Parameters.AddWithValue("@daily_rent", daily_rent);
                update.Parameters.AddWithValue("@weekly_rent", weekly_rent);
                update.ExecuteNonQuery();
                MessageBox.Show("Succesfully updated!");
                clear_vehicle();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        //DELETE VEHICLE DETAILS

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string vechicle_search = textBox5.Text;
                string query = "DELETE from vehicle_details WHERE vehicle_no = @vehicle_search";
                conn.Open();
                SqlCommand del = new SqlCommand(query, conn);
                del.Parameters.AddWithValue("@vehicle_search", vechicle_search);
                del.ExecuteNonQuery();
                MessageBox.Show("Data deleted!");
                clear_vehicle();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        //CLEAR DRIVER TEXTBOXES

        private void button5_Click(object sender, EventArgs e)
        {
            clear_driver();
        }

        //INSERT DRIVER DETAILS

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox17.Text;
                string title = comboBox1.Text;
                string contact = textBox15.Text;
                string email = textBox13.Text;
                string nic = textBox14.Text;
                float daily_rent = float.Parse(textBox7.Text);
                string query = "INSERT INTO driver_details (name, title, contact, email, nic, daily_rent) VALUES (@name, @title, @contact, @email, @nic, @daily_rent)";
                conn.Open();
                SqlCommand ins = new SqlCommand(query, conn);
                ins.Parameters.AddWithValue("@name", name);
                ins.Parameters.AddWithValue("@title", title);
                ins.Parameters.AddWithValue("@contact", contact);
                ins.Parameters.AddWithValue("@email", email);
                ins.Parameters.AddWithValue("@nic", nic);
                ins.Parameters.AddWithValue("@daily_rent", daily_rent);
                ins.ExecuteNonQuery();
                //data saved
                MessageBox.Show("Data Saved!");
                clear_driver();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        //UPDATE DRIVER DETAILS

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string search_nic = textBox6.Text;
                string title = comboBox1.Text;
                string name = textBox17.Text;
                int contact = int.Parse(textBox15.Text);
                string nic = textBox14.Text;
                string email = textBox13.Text;
                float daily_rent = float.Parse(textBox7.Text);
                string query = "UPDATE driver_details SET title = @title, name = @name, contact = @contact, nic = @nic, email = @email, daily_rent = @daily_rent WHERE @search_nic = nic";
                conn.Open();
                SqlCommand update = new SqlCommand(query, conn);
                update.Parameters.AddWithValue("@title", title);
                update.Parameters.AddWithValue("@name", name);
                update.Parameters.AddWithValue("@contact", contact);
                update.Parameters.AddWithValue("@nic", nic);
                update.Parameters.AddWithValue("@email", email);
                update.Parameters.AddWithValue("@daily_rent", daily_rent);
                update.Parameters.AddWithValue("@search_nic", search_nic);
                update.ExecuteNonQuery();
                MessageBox.Show("Succesfully updated!");
                clear_driver();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        //DELETE DRIVER DETAILS

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string driver_search = textBox6.Text;
                string query = "DELETE from driver_details WHERE nic = @driver_search";
                conn.Open();
                SqlCommand del = new SqlCommand(query, conn);
                del.Parameters.AddWithValue("@driver_search", driver_search);
                del.ExecuteNonQuery();
                MessageBox.Show("Data deleted!");
                clear_driver();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        //CHECK FEE 

        private void button9_Click(object sender, EventArgs e)
        {
            int total_days = int.Parse(textBox26.Text);
            int fee = ((total_days / 7) * (int.Parse(textBox23.Text))) + ((total_days % 7) * (int.Parse(textBox24.Text))) + (int.Parse(textBox21.Text) * total_days);
            textBox37.Text = fee.ToString();
        }

        //INSERT RENT DETAILS 

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                string cust_name = textBox20.Text;
                string cust_contact = textBox19.Text;
                string cust_nic = textBox8.Text;
                int vehicle_id = (int)comboBox7.SelectedValue;
                int driver_id = (int)comboBox8.SelectedValue;
                DateTime date_from = dateTimePicker1.Value;
                DateTime date_to = dateTimePicker2.Value;
                int total_days = int.Parse(textBox26.Text);
                float fee = float.Parse(textBox37.Text);
                string query = "INSERT INTO rent_details (cust_name, cust_contact, cust_nic, vehicle_id, driver_id, date_from, date_to, total_days, fee) VALUES (@cust_name, @cust_contact, @cust_nic, @vehicle_id, @driver_id, @date_from, @date_to, @total_days, @fee)";
                conn.Open();
                SqlCommand ins = new SqlCommand(query, conn);
                ins.Parameters.AddWithValue("@cust_name", cust_name);
                ins.Parameters.AddWithValue("@cust_contact", cust_contact);
                ins.Parameters.AddWithValue("@cust_nic", cust_nic);
                ins.Parameters.AddWithValue("@vehicle_id", vehicle_id);
                ins.Parameters.AddWithValue("@driver_id", driver_id);
                ins.Parameters.AddWithValue("@date_from", date_from);
                ins.Parameters.AddWithValue("@date_to", date_to);
                ins.Parameters.AddWithValue("@total_days", total_days);
                ins.Parameters.AddWithValue("@fee", fee);
                ins.ExecuteNonQuery();
                //data saved
                MessageBox.Show("Data Saved!");
                textBox19.Clear();
                textBox20.Clear();
                textBox8.Clear();
                textBox26.Clear();
                textBox37.Clear();
                comboBox7.ResetText();
                comboBox8.ResetText();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        //CLEAR RENT DETAILS TEXT BOXES 

        private void button11_Click(object sender, EventArgs e)
        {
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox26.Clear();
            textBox8.Clear();
            textBox37.Clear();
        }

        //CLEAR HIRE DETAILS TEXT BOXES 

        private void button12_Click(object sender, EventArgs e)
        {
            textBox16.Clear();
            textBox22.Clear();
            textBox18.Clear();
            textBox27.Clear();
            comboBox2.ResetText();
            comboBox3.ResetText();
        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void label69_Click(object sender, EventArgs e)
        {

        }

        //CLEAR 100KM TEXT BOXES 

        private void button15_Click(object sender, EventArgs e)
        {
            textBox28.Clear();
            textBox29.Clear();
            textBox30.Clear();
            textBox31.Clear();
            textBox12.Clear();
            comboBox5.ResetText();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //100KM CALCULATE 

        private void button14_Click(object sender, EventArgs e)
        {
            double km_count = double.Parse(textBox28.Text);
            double additional_km;
            double total_fee;
            if (km_count > 100)
            {
                additional_km = km_count - 100;
                total_fee = (50 * 100) + (additional_km * 250);
            }
            else
            {
                additional_km = 0;
                total_fee = km_count * 50;
            }

            textBox12.Text = total_fee.ToString();
        }



        //INSERT HIRE 100KM DETAILS 

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                string cust_name = textBox31.Text;
                string cust_nic = textBox30.Text;
                int cust_contact = int.Parse(textBox29.Text);
                string hire_type = "100 KM";
                DateTime hire_date = dateTimePicker4.Value;
                int vehicle_id = (int)comboBox5.SelectedValue;
                double payment = double.Parse(textBox12.Text);
                string query = "INSERT INTO hire_details VALUES (@cust_name, @cust_contact, @cust_nic, @hire_type, @vehicle_id, @payment, @hire_date)";
                conn.Open();
                SqlCommand ins = new SqlCommand(query, conn);
                ins.Parameters.AddWithValue("@cust_name", cust_name);
                ins.Parameters.AddWithValue("@cust_contact", cust_contact);
                ins.Parameters.AddWithValue("@cust_nic", cust_nic);
                ins.Parameters.AddWithValue("@hire_type", hire_type);
                ins.Parameters.AddWithValue("@vehicle_id", vehicle_id);
                ins.Parameters.AddWithValue("@hire_date", hire_date);
                ins.Parameters.AddWithValue("@payment", payment);
                ins.ExecuteNonQuery();
                // messagebox
                MessageBox.Show("Hire confirmed");
                clear100km();
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public void clear100km()
        {
            textBox31.Clear();
            textBox20.Clear();
            textBox29.Clear();
            textBox12.Clear();
            textBox30.Clear();
            textBox28.Clear();
            comboBox5.ResetText();
        }

        //200KM CALCULATE 

        private void button17_Click(object sender, EventArgs e)
        {
            double km_count = double.Parse(textBox32.Text);
            double additional_km;
            double total_fee;
            if (km_count > 200)
            {
                additional_km = km_count - 200;
                total_fee = (50 * 200) + (additional_km * 250);
            }
            else
            {
                additional_km = 0;
                total_fee = km_count * 50;
            }

            textBox33.Text = total_fee.ToString();
        }

        //INSERT HIRE 200KM DETAILS

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                string cust_name = textBox36.Text;
                DateTime hire_date = dateTimePicker5.Value;
                string cust_nic = textBox35.Text;
                int cust_contact = int.Parse(textBox34.Text);
                string hire_type = "200 KM";
                int vehicle_id = (int)comboBox6.SelectedValue;
                double payment = double.Parse(textBox33.Text);
                string query = "INSERT INTO hire_details VALUES (@cust_name, @cust_contact, @cust_nic, @hire_type, @vehicle_id, @payment, @hire_date)";
                conn.Open();
                SqlCommand ins = new SqlCommand(query, conn);
                ins.Parameters.AddWithValue("@cust_name", cust_name);
                ins.Parameters.AddWithValue("@hire_date", hire_date);
                ins.Parameters.AddWithValue("@cust_contact", cust_contact);
                ins.Parameters.AddWithValue("@cust_nic", cust_nic);
                ins.Parameters.AddWithValue("@hire_type", hire_type);
                ins.Parameters.AddWithValue("@vehicle_id", vehicle_id);
                ins.Parameters.AddWithValue("@payment", payment);
                ins.ExecuteNonQuery();
                // messagebox
                MessageBox.Show("Hire confirmed");
                clear200km();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public void clear200km()
        {
            textBox35.Clear();
            textBox36.Clear();
            textBox34.Clear();
            textBox33.Clear();
            textBox32.Clear();
            comboBox6.ResetText();
        }

       //INSERT HIRE DETAILS

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                string cust_name = textBox22.Text;
                int cust_contact = int.Parse(textBox18.Text);
                string cust_nic = textBox16.Text;
                string hire_type = "";
                if (radioButton1.Checked)
                {
                    hire_type = "Airport Drop";
                }
                if (radioButton2.Checked)
                {
                    hire_type = "Airport Pickup";
                }
                int vehicle_id = (int)comboBox2.SelectedValue;
                int driver_id = (int)comboBox3.SelectedValue;
                double payment = double.Parse(textBox27.Text);
                DateTime hire_date = dateTimePicker3.Value;
                string query = "INSERT INTO hire_details VALUES (@cust_name, @cust_contact, @cust_nic, @hire_type, @vehicle_id, @payment, @hire_date)";
                conn.Open();
                SqlCommand ins = new SqlCommand(query, conn);
                ins.Parameters.AddWithValue("@cust_name", cust_name);
                ins.Parameters.AddWithValue("@cust_contact", cust_contact);
                ins.Parameters.AddWithValue("@cust_nic", cust_nic);
                ins.Parameters.AddWithValue("@hire_type", hire_type);
                ins.Parameters.AddWithValue("@vehicle_id", vehicle_id);
                ins.Parameters.AddWithValue("@payment", payment);
                ins.Parameters.AddWithValue("@hire_date", hire_date);
                ins.ExecuteNonQuery();
                // messagebox
                MessageBox.Show("Hire confirmed");
                clear_hire();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public void clear_hire()
        {
            textBox22.Clear();
            textBox18.Clear();
            textBox16.Clear();
            textBox27.Clear();
            comboBox2.ResetText();
            comboBox3.ResetText();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
        }

        //DASHBOARD COUNT METHODS 

        public int A()
        {
            string stmt = "SELECT COUNT(*) FROM dbo.driver_details";
            int count_drivers = 0;

            using (SqlConnection thisConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\THARINDU\Documents\Visual Studio 2013\Projects\WindowsFormsApplication13\WindowsFormsApplication13\Database2.mdf;Integrated Security=True"))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count_drivers = (int)cmdCount.ExecuteScalar();
                }
            }
            return count_drivers;
        }

        public int B()
        {
            string stmt = "SELECT COUNT(*) FROM dbo.vehicle_details";
            int count_vehicles = 0;

            using (SqlConnection thisConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\THARINDU\Documents\Visual Studio 2013\Projects\WindowsFormsApplication13\WindowsFormsApplication13\Database2.mdf;Integrated Security=True"))
            {
                using (SqlCommand cmdCount = new SqlCommand(stmt, thisConnection))
                {
                    thisConnection.Open();
                    count_vehicles = (int)cmdCount.ExecuteScalar();
                }
            }
            return count_vehicles;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        //CLEAR 200KM TEXT BOXES

        private void button18_Click(object sender, EventArgs e)
        {
            textBox32.Clear();
            textBox33.Clear();
            textBox34.Clear();
            textBox35.Clear();
            textBox36.Clear();
            comboBox6.ResetText();
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
