using System;
using System.Collections.Generic;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using SimpleProjectManager.Module.BusinessObjects.Klient;
using BIRService.Models;
using BIRServiceReference;

namespace SimpleProjectManager.Module.Controllers
{
    public class KlientController : ViewController
    {
        public KlientController()
       {
            BIRService.BIRSearchService request = new BIRService.BIRSearchService("e6286fe6dec142b6bd3d");
           
            
            //

            var danePodmiotu = request.GetCompanyDataByNipIdAsync("6411445540");



            TargetObjectType = typeof(Klient);
            TargetViewType = ViewType.Any;
           
            SimpleAction getData = new SimpleAction(
                this, "Get data from GUS",
                DevExpress.Persistent.Base.PredefinedCategory.RecordEdit);


       
            //View.ObjectSpace.CommitChanges();
          // View.ObjectSpace.Refresh();

        }
       
     

    }
}
