using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrashCollection.Models;
using System.IO;
using System.Xml;

namespace TrashCollection.Controllers
{
    public class MapsController : Controller
    {
        //try
        //{

        //    sr = new StreamReader(webClient.OpenRead(url));

        //}
        //catch (Exception ex)
        //{
        //    throw new Exception("the error was: " + ex.Message);

        //}
        //try
        //{
        //    var xmlTextReader = new XmlTextReader(sr);
        //    var coordread = false;
        //    var accread = false;

        //    while (xmlTextReader.Read())
        //    {
        //        xmlTextReader.MoveToElement();
        //        switch (xmlTextReader.Name)
        //        {
        //            case "AddressDetails":
        //                while (xmlTextReader.MoveToNextAttribute())
        //                {
        //                    switch (xmlTextReader.Name)
        //                    {
        //                        case "Accuracy":
        //                            if (!accread)
        //                            {


        //                            }
        //                    }
        //                }


        //    public ActionResult Customers()
        //    {

        //    String connectionString = "<The connection string here>";
        //    string sql = "SELECT * FROM CUSTOMERS";
        //    SqlConnection conn = new SqlConnection(connectionString);
        //    SqlCommand Cmd = new SqlCommand(sql, conn);

        //    var model = new List<Customer>();
        //    {
        //        conn.Open();
        //        SqlDataReader rdr = cmd.ExecuteReader();
        //        while(rdr.Read())
        //        {
        //            var customer = new Customer();
        //            customer.FirstName = rdr["Customer's First Name"];
        //            customer.pickUpAddress = rdr["Customer Pickup Address"];
        //            model.Add(customer);

        //        }

        //    }

        //} 

    }