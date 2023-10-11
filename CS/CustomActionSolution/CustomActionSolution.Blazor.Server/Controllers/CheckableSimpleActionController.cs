using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Blazor.Templates.Toolbar.ActionControls;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates.ActionControls.Binding;

namespace CustomActionType.Blazor.Server.Controllers;

public class CheckableSimpleActionController : Controller {
    protected override void OnActivated() {
        base.OnActivated();
        ActionControlsSiteController actionControlsSiteController = Frame.GetController<ActionControlsSiteController>();
        if (actionControlsSiteController != null) {
            actionControlsSiteController.CustomBindActionControlToAction += ActionControlsSiteController_CustomBindActionControlToAction;
        }
    }
    protected override void OnDeactivated() {
        ActionControlsSiteController actionControlsSiteController = Frame.GetController<ActionControlsSiteController>();
        if (actionControlsSiteController != null) {
            actionControlsSiteController.CustomBindActionControlToAction -= ActionControlsSiteController_CustomBindActionControlToAction;
        }
        base.OnDeactivated();
    }
    private void ActionControlsSiteController_CustomBindActionControlToAction(object sender, CustomBindEventArgs e) {
        if (e.Action is CheckableSimpleAction checkableSimpleAction && e.ActionControl is DxToolbarItemSimpleActionControl toolbarItemSimpleActionControl) {
            e.Binding = new CheckableSimpleActionBinding(checkableSimpleAction, toolbarItemSimpleActionControl);
        }
    }
}
