using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;
using CustomActionType.Module.BusinessObjects;

namespace CustomActionType.Module.DatabaseUpdate;

// For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Updating.ModuleUpdater
public class Updater : ModuleUpdater {
    public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
        base(objectSpace, currentDBVersion) {
    }
    public override void UpdateDatabaseAfterUpdateSchema() {
        base.UpdateDatabaseAfterUpdateSchema();
        //string name = "MyName";
        //DomainObject1 theObject = ObjectSpace.FirstOrDefault<DomainObject1>(u => u.Name == name);
        //if(theObject == null) {
        //    theObject = ObjectSpace.CreateObject<DomainObject1>();
        //    theObject.Name = name;
        //}

        //ObjectSpace.CommitChanges(); //Uncomment this line to persist created object(s).

        CreateOrder("0001", true, DateTime.Now);
        CreateOrder("0002", true, DateTime.Now.AddDays(-1));
        CreateOrder("0003", false, DateTime.Now.AddDays(-2));
        CreateOrder("0004", false, DateTime.Now);
        CreateOrder("0005", true, DateTime.Now.AddDays(-3));
        ObjectSpace.CommitChanges();
    }
    public override void UpdateDatabaseBeforeUpdateSchema() {
        base.UpdateDatabaseBeforeUpdateSchema();
        //if(CurrentDBVersion < new Version("1.1.0.0") && CurrentDBVersion > new Version("0.0.0.0")) {
        //    RenameColumn("DomainObject1Table", "OldColumnName", "NewColumnName");
        //}
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
}
