<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128642563/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T123000)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WPF MVVM Framework - Validate a View with ValidationErrorsHostBehavior and POCO

The example shows how to use [ValidationErrorsHostBehavior](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ValidationErrorsHostBehavior) and POCO view model to validate a View.

## Overview

You can define [ValidationErrorsHostBehavior](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ValidationErrorsHostBehavior) for the root element to track all validation errors within the View. To enable validation error notifications, set the [NotifyOnValidationError](https://docs.microsoft.com/en-us/dotnet/api/system.windows.data.binding.notifyonvalidationerror) and [ValidatesOnDataErrors](https://docs.microsoft.com/en-us/dotnet/api/system.windows.data.binding.validatesondataerrors) properties to `true`.

Use the [ValidationErrorsHostBehavior.HasErrors](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ValidationErrorsHostBehavior.HasErrors) property to check whether a validation error occured.

![WPF MVVM Framework | ValidationErrorsHostBehavior](https://user-images.githubusercontent.com/12169834/133800151-e06bb37f-8477-4e97-a487-bc66357918de.png)


<!-- default file list --> 
## Files to Look At
- [MainView.xaml](./CS/ValidationErrorHostBehavior/Views/MainView.xaml) (**VB**: [MainView.xaml](./VB/ValidationErrorHostBehavior/Views/MainView.xaml))
- [MainViewMode.cs](./CS/ValidationErrorHostBehavior/ViewModels/MainViewModel.cs) (**VB**: [MainViewMode.vb](./VB/ValidationErrorHostBehavior/ViewModels/MainViewModel.vb))
<!-- default file list end -->

## Documentation

- [ValidationErrorsHostBehavior](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ValidationErrorsHostBehavior)
- [POCO - Automatic IDataErrorInfo Implementation](http://docs.devexpress.devx/WPF/17352/mvvm-framework/viewmodels/runtime-generated-poco-viewmodels?v=21.2#idataerrorinfo)
- [Behaviors](https://docs.devexpress.com/WPF/17442/mvvm-framework/behaviors)

## More Examples

[WPF MVVM Framework - Validate a View with ValidationErrorsHostBehavior and ViewModelBase](https://github.com/DevExpress-Examples/wpf-mvvm-framework-validationerrorshostbehavior)
