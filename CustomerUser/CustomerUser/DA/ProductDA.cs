/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CustomerUser.EF;

namespace CustomerUser.DA
{
    public class ProductDA
    {
        string conString = ConfigurationManager.ConnectionStrings["CustomersEntities"].ToString();

        public List<ProductViewModel> GetAllProducts()
        {
            List<ProductViewModel> productList = new List<ProductViewModel>();
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "sp_Products";
                SqlDataAdapter sqlDA = new SqlDataAdapter(command);
                DataTable dtProducts = new DataTable();

                connection.Open();
                sqlDA.Fill(dtProducts);
                connection.Close();

                foreach (DataRow dr in dtProducts.Rows)
                {
                    productList.Add(new ProductViewModel
                    { 
                        ProductID = Convert.ToInt32(dr["ProductID"]),
                        ProductName = dr["ProductName"].ToString(),
                        price = Convert.ToDecimal(dr["Price"]),
                        Qty = Convert.ToInt32(dr["qty"])                        
                    });

                }

            }
                return productList;
        }

    }
}*/