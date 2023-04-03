# Softgroup .Net Forms Resize 6.0/ 7.0 (.NET)
Softgroup .Net Forms Resize is a fast, small and lightweight .NET component that gives your applications resolution independence. 
Softgroup .Net Forms Resize automatically resize all controls and fonts contained in a .Net Windows Form as they are sized.

## Download Trial
https://www.netresize.net/#download

## Screenshots
https://www.netresize.net/images/netresize.gif

# History

Build 1.0.0

•	First release of Softgroup .Net Forms Resize

Build 1.5.0

•	Optimized resize engine for ActiveX OCX controls
•	Minor bug fixes

Build 2.0.0

•	Added ExcludedControls collection
•	Added AddControlPropertyFont method
•	Added AddControlPropertyHeight method
•	Added AddControlPropertyWidth method
•	Added Visual Studio C# 2005 sample project
•	Improved Visual Studio VB.NET 2005 sample project

Build 2.1.2836

•	From this release .Net Forms Resize is a .Net component that can be used both at design-time and runtime.
•	Removed unnecessary New constructor with form and licenses parameters
•	Added ParentForm property
•	Update component documentation

Build 2.1.2875

•	Changed namespace to Softgroup.NetResize

Build 2.5.2952

•	Fix a bug that cause bad controls resize of inherited forms
•	Add TextBoxesAutoResize property to vertical align text of TextBoxes controls
•	Added AutoSaveLayout property
•	Added DataGridViewAutoResize property to best control resize of columns/rows of DataGridView control 
•	Added resize support for PropertyGrid control
•	Added resize support for Microsoft Visual Basic Power Pack 2.0 controls
•	Improved FAQ documentation

Build 2.5.2963

•	Fixed a bug on resize of VB Power Pack Lines Shape controls

Build 2.5.3050

•	Improved help documentation
•	Added support for Microsoft Visual Studio 2008

Build 2.5.3059

•	Added new LabelsAutoEllipse property to automatically sets AutoEllipse property for all Labels on Form to True for best aspect on resize of this type of control.


Build 3.0.3092

•	Fixed a bug on resize of ComboBox, ListBox and CheckedListBox controls 
•	New Advanced improved resize method more faster than previous Standard method. 
•	Added new ResizeMode  property that allows to set the resizing method (Advanced or Standard). Default is new Advanced method.
•	Optimized resize for special controls (MenuStrip, ToolStrip, ToolBar, StatusStrip, StatusBar and BindingNavigator)
•	Added new OriginalMinimumSize property to keep minimum size of form at original design time size
•	Added resize support for Microsoft Visual Basic Power Pack 3.0 controls
•	Control Flow Obfuscation enhancements
•	Better handling of applications obfuscated with 3rd party tools

Build 3.0.3106

•	Fixed a minor bug on setting form dimensions on decreasing screen resolution.
•	Further increased speed resize using Advanced ResizeMode property settings.

Build 3.0.3132

•	Added support resize for FarPoint Spread control (FarPoint.Win.Spread.FpSpread)

Build 3.0.3183

•	Optimized help documentation
•	Changed licensing system

Build 3.5. 3211

•	Optimized resize of forms with old style MainMenu (System.Windows.Forms.Menu)
•	Added new GradientEnabled property
•	Added new GradientMode property
•	Added new GradientStartColor property
•	Added new GradientEndColor property
•	Added new FormFadeEffect property
•	Added new FormFadeSpeed property
•	Added new CurrentRatioWidth Property
•	Added new CurrentRatioHeight Property
•	Added new CurrentRatioFont Property
•	Added new OriginalControlLocation Property
•	Added new OriginalControlSize Property

Build 3.5. 3237

•	Added new constructor with Form value type parameter (see documentation)
•	From this build ParentForm become a ReadOnly property (to resize o form at runtime you must use new constructor with Form value type parameter)
•	Optimized resize engine
•	Fixed a minor bug in layout save/restore methods with maximized forms

Build 3.5. 3239

•	Fixed a minor bug on resize of TextBox controls 
•	Fixed a minor bug removing controls at runtime

	
Build 3.5.3246

•	Added new property OriginalFormClientSize (see documentation)
•	OrginalFormLeft property is now read/write at runtime
•	OrginalFormTop property is now read/write at runtime
•	OrginalFormWidth property is now read/write at runtime
•	OrginalFormHeight property is now read/write at runtime
•	This version implements ISupportInitialize class (users that upgrade component from earlier version we recommend to cut and paste NetResize component on forms where is placed to force designer generate code for ISupportInitialize class implementation)
•	Improved resize engine more fast than previous versions
•	Fixed a minor bug on resize controls with AutoScroll enabled


Build 3.5.3379

•	Fixed a minor bug on resize of TextBox controls with password char (see new PasswordText sample)
•	Fixed a minor bug on resize controls inside TableLayoutPanel control with absolute or autosize rows or columns
•	Changed behavior of AutoSaveLayout property
•	Fixed minor bug changing Font on DataGrdiView control
•	Optimized font use on DataGridView Control
•	Fixed a minor bug changing multiline property of textbox controls at runtime
•	Optimized resize of TabControl  (more fast and accurate) 
•	Optimized resize of TextBoxes (more fast and accurate)

Build 3.6.3413

•	Further optimized the engine of resize
•	Fixed a minor bug restoring controls during form closing
•	Fixed a regression bug on font resize optimization


Build 3.7. 3448

•	Performed an optimization of resize engine code
•	Fixed a bug on resize of controls that inherits from ScrollableControl
•	Fixed a minor bug on resize of TabControl 
•	Improved speed of controls Font property resize
•	Significantly increased resize speed of TextBox controls 
•	Fixed a bug on resize of controls added at runtime 
•	Optimized resize of controls added at runtime
•	Implemented IextenderProvider class (ResizeControl and ResizeFont properties)
•	Improved compatibility with 3rd party controls
•	Added ResizeChildren property to IextenderProvider implementation 

Build 3.7. 3503

•	Fixed a minor bug on TabControl resize that cause tabs flashing 
•	Fixed a minor bug on TextBox resize that cause incorrect vertical text alignment 
•	Fixed division by zero exception on controls added to TableLayotPanel with 0 size columns
•	Added DPIAutoResize property that make your application DPI resolution independent.
•	Added new DPIDesigneValue design-time property 
•	Added new  DPIFontFactor property
•	Improved sample code and documentation
•	Fixed a minor bug on font resize when DataGridViewAutoResize was enabled
•	Added new DataGridViewAutoResizeHeaders property
•	Added new DataGridViewAutoResizeRows property
•	Added new DataGridViewAutoResizeCols property
•	Optimized some internal engine resize

Build 3.8. 3589

•	Optimized resize of multiline TextBox controls 
•	Added new property TextBoxMultiline
•	Improved compatibility with 3rd party controls
•	Added new DoubleBuffer property
•	Added support for Softgroup.NetCombos controls
•	Fixed a bug on resize user controls added at runtime


Build 4.0.3644

•	Fixed a minor bug on resize of DataGridView control
•	Fixed a minor bug on restore layout of form 
•	Optimized loading speed of forms with .Net Resize
•	Optimized resize of ToolStrip control items
•	Improved compatibility with 3rd party controls
•	Fixed a bug on recalculation of client area on forms with docked controls
•	Fixed a bug on recalculation of client area on forms running on different resolutions
•	Fixed an incompatibility issue when compiling projects with DotFuscator

Build 4.0.3915

•	New installation Setup and minor bug fixes
•	Improved samples code.
•	Fixed a bug when resizing ComboBox controls when DropDownStyle is sets to DropDown

Build 4.0.3953

•	Improved setup for installations on Windows 2008 server
•	Fixed and exception generated in rare cases by ItemSize object of a TabControl
•	Fixed a minor bug on TextBox resizing 
•	Fixed a minor bug on restoring properties after resize of ComboBox controls 

Build 5.0.4185

•	Added support for 64 bit platforms
•	Added support for Windows 7
•	Added support for Visual Studio 2010
•	Added support for .Net Framework 4
•	Fixed a bug in the behaviour of MDI child form activation 
•	Added new ShowForm method for fast MDI child form display
•	Fixed “Collection was modified after the enumerator was instantiated” exception
•	After resizing a multiline TextBox with vertical scrollbar cursor disappear
•	Fixed a bug on TabPage resize with more that one nested TabControls.


Build 6.0.4496

•	Added automatic font cache controls 
•	Minor code optimization 
•	Optimized resize or TextBox controls
•	Further increased of speed resize engine
•	Fixed incorrect resize behavior of some Infragistics WinForms controls
•	Fixed incorrect resize behavior of some DevExpress WinForms controls
•	Added more compatibility with other thirty party controls


Build 7.0.4842

•	Improved resize handling of TextBox controls 
•	Improved resize handling of ListBox and CheckedListBox controls 
•	Improved resize engine that increase performance of 30% 
•	Optimized resize of container controls with docked child controls
•	Added new assembly Softgroup.NetResize45.dll targeting .Net Framework 4.5
•	Added support for Visual Studio 2012 (all editions)
•	Added support for Microsoft Windows 8 and Microsoft Windows Server 2012
•	One single install assemblies for all supported Frameworks (2.x/3.x,4.0 and 4.5)
•	Improved support for DevExpress WinForms  controls)
•	Improved support for ComponentOne Studio WinForms controls)
•	Improved support for Infragistics NetAdvantage WinForms controls
•	Fixed minor licensing issue


Build 7.0 (August 2013)

•	Improved support for resize of controls added at runtime
•	Added a new constructor that inizialize resize of a form at runtime with specified size
•	Added support for multiline TextBox controls with no Scrollbars and WordWrap  (see new design time property ResizeTextBoxMultiline)
•	Improved Multimonitor support 


Build 7.5 (November 2013)

•	Added support for Visual Studio 2013 (all editions)
•	Added support for Microsoft .Net Framework 4.51
•	Added support for Microsoft Windows 8.1 and Microsoft Windows Server 2012 r2
•	Fixed a bug on resize of some DevExpress WinForm controls
•	Fixed a minor bug changing Multiline property of TextBox controls


Build 7.5 (February 2014)

•	Minor bugs fixed
•	Optimized Samples
•	Enhanced Documentation


Build 7.5 (June 2015)

•	Added support for more DevExpress controls
•	Fixed a bug with sizable forms with no Control Box
•	Speed optimizations of internal resize engine
•	Minor bugs fixed

Build 7.5 (September 2015)

•	Added assemblies compiled for .Net Framework 4.52
•	Added assemblies compiled for .Net Framework 4.6
•	Added support for Microsoft Visual Studio 2015
•	Minor bug fix for some Infragistics controls
•	Some documentation fixes
•	Tested on Microsoft Windows 10
•	Removed GAC registration from installer
•	Fixed a bug with Forms that have AutoSize property sets to True


Build 8.0 (February 2016)

•	Code analysis, optimizations and improves to resize engine (20% faster)
•	Events refactoring and standardization 
•	Added new method ChangeFormResolution for proportional adapting of Form to resolution at design/runtime
•	Added New BeforeFormResizing event
•	Added New AfterFormResizing event
•	Fixed a bug with Forms that have ControlBox property sets to False
•	Added new ComboList control: an enhanced resizable DropDownList (standard ComboBox can’t be resized in height)
•	Improved internal font cache now more faster
•	Added support and assemblies compiled for .Net Framework 4.6.1
•	Improves samples code
•	Added New DisableFontsCache property


Build 8.0 (June 2016)

•	Fixed a System.NullReferenceException that occurs in many cases with third-party controls.
•	Optimized font cache disposing
•	Minor speed optimization during form close

Build 8.5 (November 2016)

•	New automatic column width resizing for ListView controls
•	Extended BeforeControlResizeEventArgs with new ratio properities
•	Extended AfterControlResizeEventArgs with new ratio properities
•	Boosts performance

Build 9.0 (October 2017)

•	Added New Extended resize method more faster than Advanced method
•	Added Support for Visual Studio 2017
•	Added support and assemblies compiled for .Net Framework 4.6.2
•	Added support and assemblies compiled for .Net Framework 4.7
•	Improved and optimized resize engine 
•	Improved and optimized memory usage 
•	Minor speed optimization 

Build 9.5 (November 2018)

•	Fixed a minor bug setting editing rectangle of TextBoxes with single border
•	Fixed a minor bug resizing TextBoxes with no border
•	Fixed a minor bug resizing TabControls tabs
•	Improved and optimized resize engine 
•	Added support and assembly for .Net Framework 4.7.1
•	Added support and assembly for .Net Framework 4.7.2

Build 9.6 (July2020)

•	Added support and assembly for .Net Framework 4.8
•	Added support for Microsoft Visual Studio 2019
•	Added support for Microsoft Windows 10
•	Improved and optimize resize engine
•	Added new control ComboList (a resizable dropdown ComboBox)
•	Minor bug fixed


Build 10.0 (January2020)

•	Added support for Microsoft Visual Studio 2019
•	Minor speed Optimization
•	Update ComponentOne and Infragistics WinForm compatibility 

Build 11.0 (October2021)

•	Added support for Microsoft Visual Studio 2017 v15.9 and above
•	Added support for Microsoft Visual Studio 2019 v16.11 and above
•	Added support for Microsoft Windows 11
•	Reduce internal memory per control storage
•	Improved and Optimized Resize Engine
•	Fixed minor bug with some fonts that can cause GDI resource memory leak
•	Update compatibility with new builds of supported third party controls
•	Minor bug resize of ComboList control


Build 12.0 (March2023)

•	Added support for Microsoft Visual Studio 2022 v17.5.3 and above
•	Added support for Microsoft Windows Server 2019
•	Added support for Microsoft Windows Server 2022
•	Improved and Optimized Resize Engine
•	Update compatibility with new builds of supported third party controls
•	Added new Framework 4.8.1 library 
•	Added new .Net 6.0 library
•	Added new .Net 7.0 library
•	Added new NuGet Packages installation for .Net assemblies

## Contact

Softgroup S.r.l.
Via C. Mandelli 3
35128 PADOVA (ITALY)
Tel: +39 049.8935363
Fax: +39 049.8932870
Web: http://www.netresize.com
Facebook: https://www.facebook.com/netresize/
Sales: sales@netresize.com
Support: support@netresize.com

## FAQ

See FAQ.PDF for more informations
