using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using MainDemo.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainDemo.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class MySimpleActionController : ViewController
    {
        public MySimpleActionController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.

            TargetViewType = ViewType.DetailView;
            TargetObjectType = typeof(Contact);

            SimpleAction mySimpleAction = new SimpleAction(this, "MySimpleAction", "MyCategory")
            {
                Caption = "My Simple Action",
                ConfirmationMessage = "My Simple Action Shows a Message",
            };
            mySimpleAction.Execute += MySimpleAction_Execute;
        }
        private void MySimpleAction_Execute(Object sender, SimpleActionExecuteEventArgs e)
        {
            // ...
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }
    }
}
