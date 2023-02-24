using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LAB2.Models;
namespace LAB2.Controllers
{
    public class ProduitController : Controller
    {
        // GET: Produit
        public ActionResult Index()
        {
            ViewBag.Message="Hello to the home page of TP3";
            return View();
        }
        public ActionResult DisplayOneproduct()
        {
            ViewBag.Title  = "DisplayOneProduct";
            Produit produit = new Produit()
            {
                Id = 1,
                Name= "Test",
                Prix=12

            };
            return View(produit);
        }
        public ActionResult DisplayManyproducts() {
            ViewBag.Title = "DisplayManyproducts";

            IList<Produit> Produitlist = new List<Produit>();
            Produitlist.Add(new Produit() { Id = 1, Name = "a", Prix = 14 });
            Produitlist.Add(new Produit() { Id = 2, Name = "b", Prix = 13 });
            Produitlist.Add(new Produit() { Id = 3, Name = "c", Prix = 12 });
            ViewData.Add("listeProduit", Produitlist);
            return View();
        }
    }
}