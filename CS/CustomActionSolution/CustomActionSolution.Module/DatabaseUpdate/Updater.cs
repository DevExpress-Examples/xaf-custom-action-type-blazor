using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.EF;
using DevExpress.Persistent.BaseImpl.EF;
using dxTestSolution.Module.BusinessObjects;

namespace CustomActionSolution.Module.DatabaseUpdate;

// For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater
public class Updater : ModuleUpdater {
    public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
        base(objectSpace, currentDBVersion) {
    }
    public override void UpdateDatabaseAfterUpdateSchema() {
        base.UpdateDatabaseAfterUpdateSchema();
        //string name = "MyName";
        //EntityObject1 theObject = ObjectSpace.FirstOrDefault<EntityObject1>(u => u.Name == name);
        //if(theObject == null) {
        //    theObject = ObjectSpace.CreateObject<EntityObject1>();
        //    theObject.Name = name;
        //}
        CreateOrder("0001", true, DateTime.Now);
        CreateOrder("0002", true, DateTime.Now.AddDays(-1));
        CreateOrder("0003", false, DateTime.Now.AddDays(-2));
        CreateOrder("0004", false, DateTime.Now);
        CreateOrder("0005", true, DateTime.Now.AddDays(-3));
        ObjectSpace.CommitChanges(); //Uncomment this line to persist created object(s).
    }
    private void CreateOrder(string orderNo, bool isActive, DateTime date) {
        Order order = ObjectSpace.FindObject<Order>(new BinaryOperator("OrderNo", orderNo));
        if (order == null) {
            order = ObjectSpace.CreateObject<Order>();
            order.OrderNo = orderNo;
            order.Active = isActive;
            order.Date = date;
        }
    }
    public override void UpdateDatabaseBeforeUpdateSchema() {
        base.UpdateDatabaseBeforeUpdateSchema();
    }
}
