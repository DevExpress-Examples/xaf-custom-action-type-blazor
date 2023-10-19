<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1101292)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# XAF Blazor - How to create a custom Action type

This example demonstrates how to create a custom Action type with a toggle state. 

<kbd>![chrome_RuP8b15xLx](https://github.com/DevExpress-Examples/xaf-custom-action-type-blazor/assets/14300209/ea644d45-b306-48d5-b6c9-d4230ca5fa03)</kbd>

## Implementation Details

The Action's implementation consists of the following parts:

1. A `SimpleAction` descendant that stores the checked state of the Action ([CheckableSimpleAction.cs](CS/CustomActionSolution/CustomActionSolution.Blazor.Server/CustomAction/CheckableSimpleAction.cs)). 
2. The custom Action binding that binds an abstract Action to its UI representation ([CheckableSimpleActionBinding.cs](CS/CustomActionSolution/CustomActionSolution.Blazor.Server/CustomAction/CheckableSimpleActionBinding.cs)).
3. The Controller that performs the binding operation. ([CheckableSimpleActionController.cs](CS/CustomActionSolution/CustomActionSolution.Blazor.Server/Controllers/CheckableSimpleActionController.cs))
4. The Controller that creates `CheckableSimpleAction` objects in the UI. ([SampleController.cs](CS/CustomActionSolution/CustomActionSolution.Blazor.Server/Controllers/SampleController.cs))

## Files to Review

* [CheckableSimpleAction.cs](CS/CustomActionSolution/CustomActionSolution.Blazor.Server/CustomAction/CheckableSimpleAction.cs) 
* [CheckableSimpleActionBinding.cs](CS/CustomActionSolution/CustomActionSolution.Blazor.Server/CustomAction/CheckableSimpleActionBinding.cs) 
* [CheckableSimpleActionController.cs](CS/CustomActionSolution/CustomActionSolution.Blazor.Server/Controllers/CheckableSimpleActionController.cs) 
* [SampleController.cs](CS/CustomActionSolution/CustomActionSolution.Blazor.Server/Controllers/SampleController.cs)

## Documentation
* [How to: Customize Controls Associated with an Action](https://docs.devexpress.com/eXpressAppFramework/113183/ui-construction/controllers-and-actions/actions/how-to-customize-action-controls)

## More Examples
* [How to create a custom action type with a custom control (BarCheckItem), associated with it](https://github.com/DevExpress-Examples/XAF_how-to-create-a-custom-action-type-with-a-custom-control-barcheckitem-associated-with-it-e1977) (WinForms)
* [How to create a custom action type with a custom control](https://github.com/DevExpress-Examples/XAF_how-to-create-a-custom-action-with-a-custom-control-in-xaf-aspnet-application-e4357) (ASP.NET Web Forms)
