#region Copyright (c) 2000-2011 Developer Express Inc.
/*
{*******************************************************************}
{                                                                   }
{       Developer Express .NET Component Library                    }
{                                                                   }
{                                                                   }
{       Copyright (c) 2000-2011 Developer Express Inc.              }
{       ALL RIGHTS RESERVED                                         }
{                                                                   }
{   The entire contents of this file is protected by U.S. and       }
{   International Copyright Laws. Unauthorized reproduction,        }
{   reverse-engineering, and distribution of all or any portion of  }
{   the code contained in this file is strictly prohibited and may  }
{   result in severe civil and criminal penalties and will be       }
{   prosecuted to the maximum extent possible under the law.        }
{                                                                   }
{   RESTRICTIONS                                                    }
{                                                                   }
{   THIS SOURCE CODE AND ALL RESULTING INTERMEDIATE FILES           }
{   ARE CONFIDENTIAL AND PROPRIETARY TRADE                          }
{   SECRETS OF DEVELOPER EXPRESS INC. THE REGISTERED DEVELOPER IS   }
{   LICENSED TO DISTRIBUTE THE PRODUCT AND ALL ACCOMPANYING .NET    }
{   CONTROLS AS PART OF AN EXECUTABLE PROGRAM ONLY.                 }
{                                                                   }
{   THE SOURCE CODE CONTAINED WITHIN THIS FILE AND ALL RELATED      }
{   FILES OR ANY PORTION OF ITS CONTENTS SHALL AT NO TIME BE        }
{   COPIED, TRANSFERRED, SOLD, DISTRIBUTED, OR OTHERWISE MADE       }
{   AVAILABLE TO OTHER INDIVIDUALS WITHOUT EXPRESS WRITTEN CONSENT  }
{   AND PERMISSION FROM DEVELOPER EXPRESS INC.                      }
{                                                                   }
{   CONSULT THE END USER LICENSE AGREEMENT FOR INFORMATION ON       }
{   ADDITIONAL RESTRICTIONS.                                        }
{                                                                   }
{*******************************************************************}
*/
#endregion Copyright (c) 2000-2011 Developer Express Inc.

#if DXCommon
public class AssemblyInfo {
#else
namespace DevExpress.Internal {
	internal class AssemblyInfo {
#endif
	public const string AssemblyCopyright = "Copyright (c) 2000-2010 Developer Express Inc.";
	public const string AssemblyCompany = "Developer Express Inc.";
	internal const int VersionId = 102;
	public const string VersionShort = "10.2";
#if !SILVERLIGHT
		public const string Version = "10.2.5.0";
	public const string XpfPrefix = "WPF";
#else
		public const string Version = "10.2.5.5"; 
	public const string XpfPrefix = "SL";
#endif
		public const string FileVersion = "10.2.5.0";
	public const string MarketingVersion = "v2010 vol 2";
	public const string VirtDirSuffix = "_v10_2";
	public const string SatelliteContractVersion = VersionShort + ".0.0";
	public const string VSuffixWithoutSeparator = "v" + VersionShort;
	public const string VSuffix = "." + VSuffixWithoutSeparator;
	public const string VSuffixDesign = VSuffix + ".Design";
	public const string VSuffixExport = VSuffix + ".Export";
	public const string SRAssemblyAgScheduler = "DevExpress.Xpf.Scheduler" + VSuffix;
	public const string SRAssemblyXpfRichEdit = "DevExpress.Xpf.RichEdit" + VSuffix;
	public const string SRAssemblyXpfRichEditExtensions = "DevExpress.Xpf.RichEdit" + VSuffix + ".Extensions";
	public const string SRAssemblyXpfPrintingService = "DevExpress.Xpf.Printing" + VSuffix + ".Service";
	public const string SRAssemblyXpfPrinting = "DevExpress.Xpf.Printing" + VSuffix;
	public const string SRAssemblyXpfCore = "DevExpress.Xpf.Core" + VSuffix;
	public const string SRAssemblyXpfDemoBase = "DevExpress.Xpf.DemoBase" + VSuffix;
	public const string SRAssemblyXpfGrid = "DevExpress.Xpf.Grid" + VSuffix;
	public const string SRAssemblyXpfGridCore = "DevExpress.Xpf.Grid" + VSuffix + ".Core";
	public const string SRAssemblyXpfDocking = "DevExpress.Xpf.Docking" + VSuffix;
	public const string SRAssemblyXpfLayoutCore = "DevExpress.Xpf.Layout" + VSuffix + ".Core";
	public const string SRAssemblyDXCharts = "DevExpress.Xpf.Charts" + VSuffix;
	public const string SRDocumentationLink = "http://documentation.devexpress.com/";
	public const string InstallationRegistryKey = "SOFTWARE\\DevExpress\\Components\\" + VSuffixWithoutSeparator;
	public const string InstallationRegistryRootPathValueName = "RootDirectory";
	public const string SRAssemblyXpfPrefix = "DevExpress.Xpf";
	public const string ThemePrefixWithoutSeparator = "Themes";
	public const string ThemePrefix = "." + ThemePrefixWithoutSeparator + ".";
#if !SILVERLIGHT
	public const string
		SRAssemblyMVC = "DevExpress.Web.Mvc" + VSuffix,
		SRAssemblyExpressAppWeb = "DevExpress.ExpressApp.Web" + VSuffix,
		SRAssemblyASPxThemes = "DevExpress.Web.ASPxThemes" + VSuffix,
		SRAssemblyASPxGridView = "DevExpress.Web.ASPxGridView" + VSuffix,
		SRAssemblyASPxGridViewExport = "DevExpress.Web.ASPxGridView" + VSuffixExport,
		SRAssemblyASPxPivotGrid = "DevExpress.Web.ASPxPivotGrid" + VSuffix,
		SRAssemblyASPxPivotGridExport = "DevExpress.Web.ASPxPivotGrid" + VSuffixExport,
		SRAssemblyDesign = "DevExpress.Design" + VSuffix,
		SRAssemblyData = "DevExpress.Data" + VSuffix,
		SRAssemblyUtils = "DevExpress.Utils" + VSuffix,
		SRAssemblyParser = "DevExpress.Parser" + VSuffix,
		SRAssemblyPrinting = "DevExpress.XtraPrinting" + VSuffix,
		SRAssemblyPrintingDesign = "DevExpress.XtraPrinting" + VSuffixDesign,
		SRAssemblyEditors = "DevExpress.XtraEditors" + VSuffix,
		SRAssemblyEditorsDesign = "DevExpress.XtraEditors" + VSuffixDesign,
		SRAssemblyNavBar = "DevExpress.XtraNavBar" + VSuffix,
		SRAssemblyNavBarDesign = "DevExpress.XtraNavBar" + VSuffixDesign,
		SRAssemblyBars = "DevExpress.XtraBars" + VSuffix,
		SRAssemblyBarsDesign = "DevExpress.XtraBars" + VSuffixDesign,
		SRAssemblyGrid = "DevExpress.XtraGrid" + VSuffix,
		SRAssemblyGaugesCore = "DevExpress.XtraGauges" + VSuffix + ".Core",
		SRAssemblyGaugesPresets = "DevExpress.XtraGauges" + VSuffix + ".Presets",
		SRAssemblyGaugesWin = "DevExpress.XtraGauges" + VSuffix + ".Win",
		SRAssemblyASPxGauges = "DevExpress.Web.ASPxGauges" + VSuffix,
		SRAssemblyGaugesDesignWin = "DevExpress.XtraGauges" + VSuffixDesign + ".Win",
		SRAssemblyGridDesign = "DevExpress.XtraGrid" + VSuffixDesign,
		SRAssemblyPivotGrid = "DevExpress.XtraPivotGrid" + VSuffix,
		SRAssemblyPivotGridCore = "DevExpress.PivotGrid" + VSuffix + ".Core",
		SRAssemblyPivotGridDesign = "DevExpress.XtraPivotGrid" + VSuffixDesign,
		SRAssemblyTreeList = "DevExpress.XtraTreeList" + VSuffix,
		SRAssemblyTreeListDesign = "DevExpress.XtraTreeList" + VSuffixDesign,
		SRAssemblyVertGrid = "DevExpress.XtraVerticalGrid" + VSuffix,
		SRAssemblyVertGridDesign = "DevExpress.XtraVerticalGrid" + VSuffixDesign,
		SRAssemblyReports = "DevExpress.XtraReports" + VSuffix,
		SRAssemblyReportsService = "DevExpress.XtraReports" + VSuffix + ".Service",
		SRAssemblyReportsDesign = "DevExpress.XtraReports" + VSuffixDesign,
		SRAssemblyReportsImport = "DevExpress.XtraReports" + VSuffix + ".Import",
		SRAssemblyReportsWeb = "DevExpress.XtraReports" + VSuffix + ".Web",
		SRAssemblyReportsExtensions = "DevExpress.XtraReports" + VSuffix + ".Extensions",
		SRAssemblyReportsDesignDelphi8 = "DevExpress.XtraReports" + VSuffix + ".Design.Delphi8",
		SRAssemblyReportsDesignDelphi9 = "DevExpress.XtraReports" + VSuffix + ".Design.Delphi9",
		SRAssemblyReportsDesignDelphi10 = "DevExpress.XtraReports" + VSuffix + ".Design.Delphi10",
		SRAssemblyRichEdit = "DevExpress.XtraRichEdit" + VSuffix,
		SRAssemblyRichEditDesign = "DevExpress.XtraRichEdit" + VSuffixDesign,
		SRAssemblyRichEditExtensions = "DevExpress.XtraRichEdit" + VSuffix + ".Extensions",
		SRAssemblyRichEditPrinting = "DevExpress.XtraRichEdit" + VSuffix + ".Printing",
		SRAssemblyScheduler = "DevExpress.XtraScheduler" + VSuffix,
		SRAssemblySchedulerCore = "DevExpress.XtraScheduler" + VSuffix + ".Core",
		SRAssemblySchedulerDesign = "DevExpress.XtraScheduler" + VSuffixDesign,
		SRAssemblySchedulerWeb = "DevExpress.Web.ASPxScheduler" + VSuffix,
		SRAssemblySchedulerWebDesign = "DevExpress.Web.ASPxScheduler" + VSuffixDesign,
		SRAssemblySchedulerOutlookExchange = "DevExpress.XtraScheduler" + VSuffix + ".OutlookExchange",
		SRAssemblySchedulerVCalendarExchange = "DevExpress.XtraScheduler" + VSuffix + ".VCalendarExchange",
		SRAssemblyScheduleriCalendarExchange = "DevExpress.XtraScheduler" + VSuffix + ".iCalendarExchange",
		SRAssemblySchedulerExtensions = "DevExpress.XtraScheduler" + VSuffix + ".Extensions",
		SRAssemblySchedulerReporting = "DevExpress.XtraScheduler" + VSuffix + ".Reporting",
		SRAssemblySchedulerReportingExtensions = "DevExpress.XtraScheduler" + VSuffix + ".Reporting.Extensions",
		SRAssemblyChartsCore = "DevExpress.Charts" + VSuffix + ".Core",
		SRAssemblyCharts = "DevExpress.XtraCharts" + VSuffix,
		SRAssemblyChartsExtensions = "DevExpress.XtraCharts" + VSuffix + ".Extensions",
		SRAssemblyChartsDesign = "DevExpress.XtraCharts" + VSuffixDesign,
		SRAssemblyChartsWebDesign = "DevExpress.XtraCharts" + VSuffix + ".Web.Design",
		SRAssemblyChartsUI = "DevExpress.XtraCharts" + VSuffix + ".UI",
		SRAssemblyChartsWeb = "DevExpress.XtraCharts" + VSuffix + ".Web",
		SRAssemblyWizard = "DevExpress.XtraWizard" + VSuffix,
		SRAssemblyWizardDesign = "DevExpress.XtraWizard" + VSuffixDesign,
		SRAssemblyXpo = "DevExpress.Xpo" + VSuffix,
		SRAssemblyXpoDesign = "DevExpress.Xpo" + VSuffixDesign,
		SRAssemblyLayoutControl = "DevExpress.XtraLayout" + VSuffix,
		SRAssemblyLayoutControlDesign = "DevExpress.XtraLayout" + VSuffixDesign,
		SRAssemblySpellCheckerCore = "DevExpress.SpellChecker" + VSuffix + ".Core",
		SRAssemblySpellChecker = "DevExpress.XtraSpellChecker" + VSuffix,
		SRAssemblySpellCheckerDesign = "DevExpress.XtraSpellChecker" + VSuffixDesign,
		SRAssemblySpellCheckerWeb = "DevExpress.Web.ASPxSpellChecker" + VSuffix,
		SRAssemblyWeb = "DevExpress.Web" + VSuffix,
		SRAssemblyHtmlEditorWeb = "DevExpress.Web.ASPxHtmlEditor" + VSuffix,
		SRAssemblyEditorsWeb = "DevExpress.Web.ASPxEditors" + VSuffix,
		SRAssemblyTreeListWeb = "DevExpress.Web.ASPxTreeList" + VSuffix,
		SRAssemblyTreeListWebExport = "DevExpress.Web.ASPxTreeList" + VSuffixExport,
		SRAssemblyXpfScheduler = "DevExpress.Xpf.Scheduler" + VSuffix,
		SRAssemblyDXPivotGrid = "DevExpress.Xpf.PivotGrid" + VSuffix;
#endif
	public const string
		DXTabNameComponents = "Components",
		DXTabNameNavigationAndLayout = "Navigation & Layout",
		DXTabNameReporting = "Reporting",
		DXTabNameReportControls = "Report Controls",
		DXTabNameData = "Data",
		DXTabNameScheduling = "Scheduling",
		DXTabNameSchedulerReporting = "Scheduler Reporting",
		DXTabNameRichEdit = "Rich Text Editor",
		DXTabNameCommon = "Common Controls",
		DXTabNameLayoutControl = "Layout Control",
		DXTabPrefix = "DX." + VersionShort + ": ",
		DXTabComponents = DXTabPrefix + DXTabNameComponents,
		DXTabNavigation = DXTabPrefix + DXTabNameNavigationAndLayout,
		DXTabReporting = DXTabPrefix + DXTabNameReporting,
		DXTabReportControls = DXTabPrefix + DXTabNameReportControls,
		DXTabData = DXTabPrefix + DXTabNameData,
		DXTabScheduling = DXTabPrefix + DXTabNameScheduling,
		DXTabSchedulerReporting = DXTabPrefix + DXTabNameSchedulerReporting,
		DXTabRichEdit = DXTabPrefix + DXTabNameRichEdit,
		DXTabCommon = DXTabPrefix + DXTabNameCommon;
	public const string
		DXTabWpfNavigation = "DX." + VersionShort + "." + XpfPrefix + ": Navigation & Layout",
		DXTabWpfReporting = "DX." + VersionShort + "." + XpfPrefix + ": Reporting",
		DXTabWpfLayoutControl = "DX." + VersionShort + "." + XpfPrefix + ": Layout",
		DXTabWpfData = "DX." + VersionShort + "." + XpfPrefix + ": Data",
		DXTabWpfCommon = "DX." + VersionShort + "." + XpfPrefix + ": Common Controls",
		DXTabWpfScheduling = "DX." + VersionShort + "." + XpfPrefix + ": Scheduling",
		DXTabWpfRichEdit = "DX." + VersionShort + "." + XpfPrefix + ": Rich Text Editor";
}
#if !DXCommon
}
#endif
