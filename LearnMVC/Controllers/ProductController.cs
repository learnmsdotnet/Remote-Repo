using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data;
using System.Data.SqlClient;
using LearnMVC.Models;

namespace LearnMVC.Controllers
{
    public class ProductController : Controller
    {
        private string _appConnectionString = @"Data Source=PC238395;Initial Catalog=LEARNDBMP01;Integrated Security=true";

        //list or view all the products in table
        //all MVC action method are get request by default
        // GET: Product
        [HttpGet]
        public ActionResult Index()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(_appConnectionString)) {

                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM PRODUCTS", sqlConnection);
                sqlDataAdapter.Fill(dataTable);
            }
            return View(dataTable);
        }

        //this action method is not required, lets comment it
        //// GET: Product/Details/5
        //public ActionResult Details(int id) {
        //    return View();
        //}

        //this action method is of type HttpGet
        //using this action method we will create a new form to enter new products
        // GET: Product/Create
        public ActionResult Create()
        {
            return View(new ProductModel());
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProductModel productModel)
        {
            //inside this method we will save the product details and redirect to action result
            try {
                // TODO: Add insert logic here
                using (SqlConnection sqlConnection = new SqlConnection(_appConnectionString)) {
                    sqlConnection.Open();
                    string query = "INSERT INTO Products VALUES (@Name, @Price, @Date)";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlCommand.Parameters.AddWithValue("@Name", productModel.Name);
                    sqlCommand.Parameters.AddWithValue("@Price", productModel.Price);
                    sqlCommand.Parameters.AddWithValue("@Date", productModel.Date);

                    sqlCommand.ExecuteNonQuery();
                }

                //pass the action method as 'Index' and redirect to Index action (calling Index page)
                return RedirectToAction("Index");
            }
            catch {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            ProductModel productModel = new ProductModel();
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(_appConnectionString)) {
                sqlConnection.Open();
                string query = "SELECT * FROM Products WHERE ID = @ProductID";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ProductID", id);
                sqlDataAdapter.Fill(dataTable);
            }

            //if there is a row with given id
            if (dataTable.Rows.Count == 1) {
                productModel.ID = Convert.ToInt32(dataTable.Rows[0][0].ToString());
                productModel.Name = dataTable.Rows[0][1].ToString();
                productModel.Price = Convert.ToDecimal(dataTable.Rows[0][2].ToString());
                productModel.Date = Convert.ToDateTime(dataTable.Rows[0][3].ToString());

                //So far we have not created View for Edit action method, lets create now a view
                return View(productModel);
            }
            else
                //No matching data hence show the view
                return RedirectToAction("Index");            
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(ProductModel productModel)
        {
            try {
                // TODO: Add update logic here
                using (SqlConnection sqlConnection = new SqlConnection(_appConnectionString)) {
                    sqlConnection.Open();
                    string query = "UPDATE Products SET Name = @name, Price = @price, Date = @date WHERE Id = @id";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@id", productModel.ID);
                    sqlCommand.Parameters.AddWithValue("@name", productModel.Name);
                    sqlCommand.Parameters.AddWithValue("@price", productModel.Price);
                    sqlCommand.Parameters.AddWithValue("@Date", productModel.Date);
                    sqlCommand.ExecuteNonQuery();
                }
                //redirect to Index action method
                return RedirectToAction("Index");
            }
            catch {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id) {
            using (SqlConnection sqlConnection = new SqlConnection(_appConnectionString))
            {
                sqlConnection.Open();
                string query = "DELETE FROM Products WHERE Id = @id";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.ExecuteNonQuery();
            }
            //after the record is deleted from the database redirect to Index action method
            return RedirectToAction("Index");
        }

        //For our current example HttpPost action delete is not required
        // POST: Product/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection) {
        //    try {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch {
        //        return View();
        //    }
        //}
    }
}
