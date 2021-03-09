using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Windows.Forms;
using Project.Model;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;


namespace Project.usercontorl
{
    public partial class _userPeople : UserControl
    {
        ClientReq clientReq = new ClientReq();
        string path = "https://localhost:44394/api/People";
        static HttpClient client = new HttpClient();
        DataTable dt;
        public _userPeople()
        {
            InitializeComponent();
            dt = new DataTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _userPeople_Load(object sender, EventArgs e)
        {

        }
        public void refresh()
        {
            try
            {
                dt = clientReq.GetProductAsync(path).ConfigureAwait(true).GetAwaiter().GetResult(); ;

                //dt = GetProductAsync("https://localhost:44394/api/People").GetAwaiter().GetResult();

                _dgv.DataSource = dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //static async Task<DataTable> GetProductAsync(string path)
        //{         
        //    var item = new List<User>();
        //    try
        //    {
        //        // Update port # in the following line.
        //        client.BaseAddress = new Uri(path);
        //        client.DefaultRequestHeaders.Accept.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(
        //            new MediaTypeWithQualityHeaderValue("application/json"));

        //        var response = client.GetAsync(path).ConfigureAwait(true).GetAwaiter().GetResult();

        //        if (response.IsSuccessStatusCode)
        //        {

        //            item = await response.Content.ReadAsAsync<List<User>>();

        //        }
        //    }
        //    catch (Exception e)
        //    {

        //        Console.WriteLine(e.Message);
        //    }


        //    return CreateDataTable(item);
        //}
        // static DataTable CreateDataTable<T>(IEnumerable<T> list)
        //{
        //    Type type = typeof(T);
        //    var properties = type.GetProperties();

        //    DataTable dataTable = new DataTable();
        //    foreach (PropertyInfo info in properties)
        //    {
        //        dataTable.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
        //    }

        //    foreach (T entity in list)
        //    {
        //        object[] values = new object[properties.Length];
        //        for (int i = 0; i < properties.Length; i++)
        //        {
        //            values[i] = properties[i].GetValue(entity);
        //        }

        //        dataTable.Rows.Add(values);
        //    }

        //    return dataTable;
        //}

        private void _dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
