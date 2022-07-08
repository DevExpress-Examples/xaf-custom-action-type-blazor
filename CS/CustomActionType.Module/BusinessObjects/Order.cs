using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace CustomActionType.Module.BusinessObjects;

[DefaultClassOptions]
public class Order : BaseObject {
    public Order(Session session)
        : base(session) {
    }
    private string _OrderNo;
    public string OrderNo {
        get { return _OrderNo; }
        set { SetPropertyValue("OrderNo", ref _OrderNo, value); }
    }
    private bool _Active;
    public bool Active {
        get { return _Active; }
        set { SetPropertyValue("Active", ref _Active, value); }
    }
    private DateTime _Date;
    public DateTime Date {
        get { return _Date; }
        set { SetPropertyValue("Date", ref _Date, value); }
    }
}
