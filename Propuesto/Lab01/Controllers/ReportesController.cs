using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab01.Models;
using Microsoft.Reporting.WebForms;



namespace Lab01.Controllers
{
    public class ReportesController : Controller
    {
        // GET: Reportes
        public ActionResult ReportesProveedor()
        {
            ReportViewer rvw = new ReportViewer();
            rvw.ProcessingMode = ProcessingMode.Local;
            rvw.SizeToReportContent = true;

            rvw.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Reports\RptProveedor.rdlc";
            
            POOIIEntities bd = new POOIIEntities();

            rvw.LocalReport.DataSources.Add(new ReportDataSource("DataSetProveedor", bd.Proveedores));

            ViewBag.visor = rvw;

            return View();  


        }
    }
}