using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Threading.Tasks;

namespace Project.Model
{
    public class ClientReq
    {
        private static HttpClient client = new HttpClient();

        public static void ShowProduct(User User)
        {
            Console.WriteLine($"id: {User.id}\tname: " +
                $"{User.name}\tlastName: {User.lastName}");
        }

        public async Task<Uri> CreateProductAsync(string path, User User)
        {
            try
            {
                if (client.BaseAddress == null)
                {
                    // Update port # in the following line.
                    client.BaseAddress = new Uri(path);
                }

                // Update port # in the following line.
                //client.BaseAddress = new Uri(path);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));


                var response =  client.PostAsJsonAsync(
       path, User).ConfigureAwait(true).GetAwaiter().GetResult();

                response.EnsureSuccessStatusCode();

                return response.Headers.Location;
            }
            catch (Exception)
            {
                throw;
            }
            // return URI of the created resource.
        }

        public async Task<DataTable> GetProductAsync(string path)
        {
            var item = new List<User>();
            try
            {

                if(client.BaseAddress == null)
                {
                    // Update port # in the following line.
                    client.BaseAddress = new Uri(path);
                }

                // Update port # in the following line.
                //client.BaseAddress = new Uri(path);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.GetAsync(path).ConfigureAwait(true).GetAwaiter().GetResult();

                if (response.IsSuccessStatusCode)
                {
                    item = await response.Content.ReadAsAsync<List<User>>();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return CreateDataTable(item);
        }

        public static async Task<User> UpdateProductAsync(User User)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"api/products/{User.id}", User);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            User = await response.Content.ReadAsAsync<User>();
            return User;
        }

        public static async Task<HttpStatusCode> DeleteProductAsync(string id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"api/products/{id}");
            return response.StatusCode;
        }

        private static DataTable CreateDataTable<T>(IEnumerable<T> list)
        {
            Type type = typeof(T);
            var properties = type.GetProperties();

            DataTable dataTable = new DataTable();
            foreach (PropertyInfo info in properties)
            {
                dataTable.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
            }

            foreach (T entity in list)
            {
                object[] values = new object[properties.Length];
                for (int i = 0; i < properties.Length; i++)
                {
                    values[i] = properties[i].GetValue(entity);
                }

                dataTable.Rows.Add(values);
            }

            return dataTable;
        }
    }
}