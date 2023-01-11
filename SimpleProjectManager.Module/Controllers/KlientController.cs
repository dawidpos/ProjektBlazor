using System;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using SimpleProjectManager.Module.BusinessObjects.Klient;
namespace SimpleProjectManager.Module.Controllers
{
    public class KlientController : ViewController
    {
        public KlientController()
       {

       


            TargetObjectType = typeof(Klient);
            TargetViewType = ViewType.Any;
            SimpleAction getData = new SimpleAction(
                this, "Get data from GUS",
                DevExpress.Persistent.Base.PredefinedCategory.RecordEdit)
            {
             
            };

           

    
        }
       
     

    }
}
