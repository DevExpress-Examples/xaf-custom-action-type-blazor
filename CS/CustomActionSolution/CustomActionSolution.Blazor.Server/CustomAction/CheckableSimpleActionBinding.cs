using DevExpress.ExpressApp.Blazor.Templates.Toolbar.ActionControls;
using DevExpress.ExpressApp.Templates.ActionControls;
using DevExpress.ExpressApp.Templates.ActionControls.Binding;

namespace CustomActionType.Blazor.Server;

public class CheckableSimpleActionBinding : ActionBinding {
    private void Action_CheckedStateChanged(object sender, EventArgs e) {
        ActionControl.ToolbarItemModel.Checked = Action.Checked;
    }
    private void ActionControl_Execute(object sender, EventArgs e) {
        Action.Checked = !Action.Checked;
    }
    public CheckableSimpleActionBinding(CheckableSimpleAction action, DxToolbarItemSimpleActionControl actionControl)
        : base(action, actionControl) {
        ((ISimpleActionControl)ActionControl).Execute += ActionControl_Execute;
        Action.CheckedStateChanged += Action_CheckedStateChanged;
        ActionControl.ToolbarItemModel.Checked = Action.Checked;
    }
    public override void Dispose() {
        ((ISimpleActionControl)ActionControl).Execute -= ActionControl_Execute;
        Action.CheckedStateChanged -= Action_CheckedStateChanged;
        base.Dispose();
    }
    public new CheckableSimpleAction Action {
        get { return (CheckableSimpleAction)base.Action; }
    }
    public new DxToolbarItemSimpleActionControl ActionControl {
        get { return (DxToolbarItemSimpleActionControl)base.ActionControl; }
    }
}
