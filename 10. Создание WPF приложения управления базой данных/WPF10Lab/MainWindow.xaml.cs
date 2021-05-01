using System;
using System.Data;
using System.IO;
using System.Windows;
using Microsoft.SqlServer.Management;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Management.SqlParser.SqlCodeDom;

namespace WPF10Lab
{ 
    public partial class MainWindow : Window
    {
        static SqlTransaction trans;
        static SqlConnection _connection;
        private SqlDataAdapter _adapterClients;
        private SqlDataAdapter _adapterAddresses;
        private const string dbscriptpath = "../../Resources/10.sql";
        DataTable dtClients = null; 
        DataTable dtAddresses = null;
        

        public MainWindow()
        {
            InitializeComponent();
            try
            {
                CreateConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show("Невозможно использовать БД");
            }
        }

        public void CreateConnection()
        {
            try
            {
                _connection = DBConnector.GetConnection("connectASUS");
                //connection.Open();
            }
            catch (SqlException)
            {
                _connection = DBConnector.GetConnection("connectASUSmaster");
                //connection.Open();
                ExecuteScriptFile(dbscriptpath);
            }
        }

        public void ExecuteScriptFile(string scriptfile)
        {
            string script = File.ReadAllText(Path.GetFullPath(scriptfile));
            Server server = new Server(new ServerConnection(_connection));
            server.ConnectionContext.ExecuteNonQuery(script);
        }
        private void MainWindow_OnLoaded(object sender, RoutedEventArgs re)
        {
            try
            {
                _connection.Open();
                //trans = _connection.BeginTransaction();
                
                var selectFromClient = "select * from client";
                var selectFromAddress = "select * from clientsaddress";
                //var command = new SqlCommand("", connection);
                // command = new SqlCommand("select * from client left outer join clientsaddress on client.adressid = clientsaddress.adressid", connection);
                _adapterClients = CreateClientAdapter(selectFromClient, _connection);
                _adapterAddresses = CreateAddressAdapter(selectFromAddress, _connection);
                
                dtClients = new DataTable("Clients");
                dtAddresses = new DataTable("Addresses");
               
                _adapterClients.Fill(dtClients);
                _adapterAddresses.Fill(dtAddresses);
                ClientsGrid.ItemsSource = dtClients.DefaultView;
                AddressesGrid.ItemsSource = dtAddresses.DefaultView;
            }
            catch (Exception e)
            {
                Console.WriteLine("Db connection error" + e.Message);
            }
            finally
            {
                //if (_connection != null) _connection.Close();
            }
        }

        private void UpdateButton_OnClick(object sender, RoutedEventArgs e)
        {
            UpdateDB();
        }
        private void UpdateDB()
        {
            trans = _connection.BeginTransaction();
            _adapterAddresses.InsertCommand.Transaction = trans;
            _adapterAddresses.UpdateCommand.Transaction = trans;
            _adapterClients.InsertCommand.Transaction = trans;
            _adapterClients.UpdateCommand.Transaction = trans;
            try
            {
                _adapterAddresses.Update(dtAddresses);
                _adapterClients.Update(dtClients);
                trans.Commit();
                MessageBox.Show("Изменения сохранены");
            }
            catch (Exception e){
                trans.Rollback();
                dtClients.RejectChanges();  //TODO УРААА ОТМЕНАА
                dtAddresses.RejectChanges();
                MessageBox.Show("Отмена");
            }
        }

        public static SqlDataAdapter CreateClientAdapter(String command, SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
            
            adapter.InsertCommand = new SqlCommand("spAddClient", connection);
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@firstname", SqlDbType.NVarChar, 20, "firstname"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@patronymic", SqlDbType.NVarChar, 20, "patronymic"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@surname", SqlDbType.NVarChar, 20, "surname"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar, 20, "email"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@adressid", SqlDbType.Int, 0, "adressid"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@photo", SqlDbType.Image, 0, "photo"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@contactnumber", SqlDbType.Decimal, 0, "contactnumber"));
            
            adapter.UpdateCommand = new SqlCommand("spUpdateClient", connection);
            adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;
            adapter.UpdateCommand.Parameters.Add(new SqlParameter("@clientid", SqlDbType.Int, 0, "clientid"));
            adapter.UpdateCommand.Parameters.Add(new SqlParameter("@firstname", SqlDbType.NVarChar, 20, "firstname"));
            adapter.UpdateCommand.Parameters.Add(new SqlParameter("@patronymic", SqlDbType.NVarChar, 20, "patronymic"));
            adapter.UpdateCommand.Parameters.Add(new SqlParameter("@surname", SqlDbType.NVarChar, 20, "surname"));
            adapter.UpdateCommand.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar, 20, "email"));
            adapter.UpdateCommand.Parameters.Add(new SqlParameter("@adressid", SqlDbType.Int, 0, "adressid"));
            adapter.UpdateCommand.Parameters.Add(new SqlParameter("@photo", SqlDbType.Image, 0, "photo"));
            adapter.UpdateCommand.Parameters.Add(new SqlParameter("@contactnumber", SqlDbType.Decimal, 0, "contactnumber"));
            
            adapter.DeleteCommand = new SqlCommand("spDeleteClient", connection);
            adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;
            adapter.DeleteCommand.Parameters.Add(new SqlParameter("@clientid", SqlDbType.Int, 0, "clientID"));
            
            // SqlTransaction tran = null;
            // tran = connection.BeginTransaction();
            // adapter.SelectCommand.Transaction = tran;
            //
            // // Update the data source.
            // try
            // {
            //     // Submit the changes.
            //     adapter.Update(dt);
            //
            //     // Success. Commit.
            //     tran.Commit( );
            // }
            // catch (Exception ex)
            // {
            //     // Exception. Roll back.
            //     tran.Rollback( );
            //
            //     MessageBox.Show(ex.Message + Environment.NewLine +
            //                     "Transaction rolled back.");
            // }
            // finally
            // {
            //     connection.Close( );
            // }
            return adapter;
        }
        
        public static SqlDataAdapter CreateAddressAdapter(String command, SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
            
            adapter.InsertCommand = new SqlCommand("spAddAddress", connection);
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@country", SqlDbType.NVarChar, 30, "country"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@city", SqlDbType.NVarChar, 20, "city"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@street", SqlDbType.NVarChar, 30, "street"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@house", SqlDbType.Int, 0, "house"));
            adapter.InsertCommand.Parameters.Add(new SqlParameter("@postalcode", SqlDbType.Int, 0, "postalcode"));
            
            adapter.UpdateCommand = new SqlCommand("spUpdateAddress", connection);
            adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;
            adapter.UpdateCommand.Parameters.Add(new SqlParameter("@adressid", SqlDbType.Int, 0, "adressid"));
            adapter.UpdateCommand.Parameters.Add(new SqlParameter("@country", SqlDbType.NVarChar, 30, "country"));
            adapter.UpdateCommand.Parameters.Add(new SqlParameter("@city", SqlDbType.NVarChar, 20, "city"));
            adapter.UpdateCommand.Parameters.Add(new SqlParameter("@street", SqlDbType.NVarChar, 30, "street"));
            adapter.UpdateCommand.Parameters.Add(new SqlParameter("@house", SqlDbType.Int, 0, "house"));
            adapter.UpdateCommand.Parameters.Add(new SqlParameter("@postalcode", SqlDbType.Int, 0, "postalcode"));
            
            adapter.DeleteCommand = new SqlCommand("spDeleteClient", connection);
            adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;
            adapter.DeleteCommand.Parameters.Add(new SqlParameter("@adressid", SqlDbType.Int, 0, "adressid"));
            
            return adapter;
        }
    }
}