using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;

namespace CustomActionType.Blazor.Server;

public class CheckableSimpleAction : SimpleAction {
    private bool isChecked = false;
    public event EventHandler CheckedStateChanged;
    public CheckableSimpleAction(Controller owner, string id, PredefinedCategory category) : base(owner, id, category) { }
    public bool Checked {
        get => isChecked;
        set {
            if (isChecked != value) {
                isChecked = value;
                OnCheckedStateChanged();
                if (Enabled.ResultValue && Active.ResultValue) {
                    DoExecute();
                }
            }
        }
    }
    private void OnCheckedStateChanged() {
        if (CheckedStateChanged != null) {
            CheckedStateChanged(this, EventArgs.Empty);
        }
    }
}
