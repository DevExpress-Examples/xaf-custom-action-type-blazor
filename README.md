<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/511874854/22.1.3%2B)
![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)
![](https://img.shields.io/badge/%C3%B0%C5%B8%E2%80%9C%E2%80%93_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)
<!-- default badges end -->

# XAF Blazor - Implement a custom Action type
This example demonstrates how to create a custom Action type with toggleable state. The Action implementation consists of the following parts:

1. [CheckableSimpleAction.cs](./CS/CustomActionType.Blazor.Server/CheckableSimpleAction.cs) - The SimpleAction descendant that saves the Action's checked state.
2. [CheckableSimpleActionBinding.cs](./CS/CustomActionType.Blazor.Server/CheckableSimpleActionBinding.cs) - The custom Action binding that binds an abstract Action to its UI representation.
3. [CheckableSimpleActionController.cs](./CS/CustomActionType.Blazor.Server/Controllers/CheckableSimpleActionController.cs) - The Controller that performs the binding operation.
4. [SampleController.cs](./CS/CustomActionType.Blazor.Server/Controllers/SampleController.cs) - The Controller that creates `CheckableSimpleAction`s in the UI.

## More Examples
* [How to create a custom action type with a custom control (BarCheckItem), associated with it](https://github.com/DevExpress-Examples/XAF_how-to-create-a-custom-action-type-with-a-custom-control-barcheckitem-associated-with-it-e1977) (WinForms)
* [How to create a custom action type with a custom control](https://github.com/DevExpress-Examples/XAF_how-to-create-a-custom-action-with-a-custom-control-in-xaf-aspnet-application-e4357) (ASP.NET Web Forms)

## See Also
[How to: Customize Controls Associated with an Action](https://docs.devexpress.com/eXpressAppFramework/113183/ui-construction/controllers-and-actions/actions/how-to-customize-action-controls)
