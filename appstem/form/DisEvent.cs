using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace appstem
{

	public partial class DisEvent : Form
	{
		SqlConnection connection;
		string connectionString;
		public DisEvent()
		{
			InitializeComponent();
			connectionString = connectionString = ConfigurationManager.ConnectionStrings["appstem.Properties.Settings.StemDBConnectionString"].ConnectionString;
		}

		
		private void DisEvent_Load()
		{
			using (connection = new SqlConnection(connectionString))
			using (SqlDataAdapter adapter = new SqlDataAdapter("func_DisEventGame", connection))
			{
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);
				gridDisEV.DataSource = dataTable;
			}
		}


		private void removeDisEventBTN_Click(object sender, EventArgs e)
		{
			int disID = int.Parse(idDisEventTB.Text);
			using (connection = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand("sp_DeleteDisEvent", connection))
			{
				cmd.CommandType = CommandType.StoredProcedure;
				connection.Open();
				cmd.Parameters.Add("@DisID", SqlDbType.Int).Value = disID;
				cmd.ExecuteNonQuery();
			}
			DisEvent_Load();
		}

		private void editDisEventBTN_Click(object sender, EventArgs e)
		{
			int amount = int.Parse(amountDisEventTB.Text);
			using (connection = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand("sp_UpdateDisEvent", connection))
			{
				cmd.CommandType = CommandType.StoredProcedure;
				connection.Open();
				cmd.Parameters.Add("@DisName", SqlDbType.NVarChar).Value = nameDisEventTB.Text;
				cmd.Parameters.Add("@Amount", SqlDbType.Int).Value = amount;
				cmd.Parameters.Add("@DisType", SqlDbType.NVarChar).Value = typeDisEventTB.Text;
				cmd.ExecuteNonQuery();
			}
			DisEvent_Load();
		}

		private void addDisEventBTN_Click(object sender, EventArgs e)
		{
			int amount = int.Parse(amountDisEventTB.Text);
			using (connection = new SqlConnection(connectionString))
			using (SqlCommand cmd = new SqlCommand("sp_CreateDisEvent", connection))
			{
				cmd.CommandType = CommandType.StoredProcedure;
				connection.Open();
				cmd.Parameters.Add("@DisName", SqlDbType.NVarChar).Value = nameDisEventTB.Text;
				cmd.Parameters.Add("@Amount", SqlDbType.Int).Value = amount;
				cmd.Parameters.Add("@DisType", SqlDbType.NVarChar).Value = typeDisEventTB.Text;
				cmd.ExecuteNonQuery();
			}
			DisEvent_Load();
		}
	}
}
