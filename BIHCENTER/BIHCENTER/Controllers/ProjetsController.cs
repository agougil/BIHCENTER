using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BIHCENTER;
using PagedList;

namespace BIHCENTER.Controllers
{
    public class ProjetsController : Controller
    {
        private BIHCENTERDBModel db = new BIHCENTERDBModel();

       public ActionResult Index(int? page)
        {
            int pageSize = 12;
            int pageNumber = (page ?? 1);
            var projets = from s in db.Projets select s;
            projets = projets.OrderBy(s => s.idProjet);
            return View(projets.ToPagedList(pageNumber,pageSize));
        }
        // GET: Projets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Projets/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idProjet,NomProjet,dateDepart,dateFin,nomChefProjet")] Projet projet)
        {
            if (ModelState.IsValid)
            {
                db.Projets.Add(projet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(projet);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int idProjet,string NomProjet,DateTime dateDepart,DateTime dateFin,string nomChefProjet)
        {
            Projet projet = db.Projets.Find(idProjet);
            projet.NomProjet = NomProjet;
            projet.dateDepart = dateDepart;
            projet.dateFin = dateFin;
            projet.nomChefProjet = nomChefProjet;
            if (ModelState.IsValid)
            {
                db.Entry(projet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
     
     
    }
}
