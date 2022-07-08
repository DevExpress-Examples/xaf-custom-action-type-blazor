using CustomActionType.Module.BusinessObjects;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;

namespace CustomActionType.Blazor.Server.Controllers;

public class SampleController : ObjectViewController<ListView, Order> {
    private readonly CheckableSimpleAction activeFilterAction;
    private readonly CheckableSimpleAction todayFilterAction;
    public SampleController() {
        activeFilterAction = new CheckableSimpleAction(this, "ActiveFilterAction", PredefinedCategory.Filters);
        activeFilterAction.Caption = "Active";
        activeFilterAction.Execute += ActiveFilterAction_Execute; ;
        todayFilterAction = new CheckableSimpleAction(this, "TodayFilterAction", PredefinedCategory.Filters);
        todayFilterAction.Caption = "Today";
        todayFilterAction.Execute += TodayFilterAction_Execute; ;
    }
    protected override void OnActivated() {
        EnsureActiveFilterApplied();
        EnsureTodayFilterApplied();
    }
    private void ActiveFilterAction_Execute(object sender, DevExpress.ExpressApp.Actions.SimpleActionExecuteEventArgs e) {
        EnsureActiveFilterApplied();
    }
    private void TodayFilterAction_Execute(object sender, DevExpress.ExpressApp.Actions.SimpleActionExecuteEventArgs e) {
        EnsureTodayFilterApplied();
    }
    private void EnsureActiveFilterApplied() {
        bool applyFilter = activeFilterAction.Checked;
        if (applyFilter) {
            View.CollectionSource.Criteria["IsActive"] = new OperandProperty("Active");
        } else {
            View.CollectionSource.Criteria.Remove("IsActive");
        }
    }
    private void EnsureTodayFilterApplied() {
        bool applyFilter = todayFilterAction.Checked;
        if (applyFilter) {
            View.CollectionSource.Criteria["IsToday"] = new FunctionOperator(FunctionOperatorType.IsOutlookIntervalToday, new OperandProperty("Date"));
        } else {
            View.CollectionSource.Criteria.Remove("IsToday");
        }
    }
}
