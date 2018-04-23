Imports Microsoft.VisualBasic
Imports System
#Region "Copyright (c) 2000-2011 Developer Express Inc."
'
'{*******************************************************************}
'{                                                                   }
'{       Developer Express .NET Component Library                    }
'{                                                                   }
'{                                                                   }
'{       Copyright (c) 2000-2011 Developer Express Inc.              }
'{       ALL RIGHTS RESERVED                                         }
'{                                                                   }
'{   The entire contents of this file is protected by U.S. and       }
'{   International Copyright Laws. Unauthorized reproduction,        }
'{   reverse-engineering, and distribution of all or any portion of  }
'{   the code contained in this file is strictly prohibited and may  }
'{   result in severe civil and criminal penalties and will be       }
'{   prosecuted to the maximum extent possible under the law.        }
'{                                                                   }
'{   RESTRICTIONS                                                    }
'{                                                                   }
'{   THIS SOURCE CODE AND ALL RESULTING INTERMEDIATE FILES           }
'{   ARE CONFIDENTIAL AND PROPRIETARY TRADE                          }
'{   SECRETS OF DEVELOPER EXPRESS INC. THE REGISTERED DEVELOPER IS   }
'{   LICENSED TO DISTRIBUTE THE PRODUCT AND ALL ACCOMPANYING .NET    }
'{   CONTROLS AS PART OF AN EXECUTABLE PROGRAM ONLY.                 }
'{                                                                   }
'{   THE SOURCE CODE CONTAINED WITHIN THIS FILE AND ALL RELATED      }
'{   FILES OR ANY PORTION OF ITS CONTENTS SHALL AT NO TIME BE        }
'{   COPIED, TRANSFERRED, SOLD, DISTRIBUTED, OR OTHERWISE MADE       }
'{   AVAILABLE TO OTHER INDIVIDUALS WITHOUT EXPRESS WRITTEN CONSENT  }
'{   AND PERMISSION FROM DEVELOPER EXPRESS INC.                      }
'{                                                                   }
'{   CONSULT THE END USER LICENSE AGREEMENT FOR INFORMATION ON       }
'{   ADDITIONAL RESTRICTIONS.                                        }
'{                                                                   }
'{*******************************************************************}
'
#End Region ' Copyright (c) 2000-2011 Developer Express Inc.

#If DXCommon Then
Public Class AssemblyInfo
#Else
Namespace DevExpress.Internal
	Friend Class AssemblyInfo
#End If
	Public Const AssemblyCopyright As String = "Copyright (c) 2000-2010 Developer Express Inc."
	Public Const AssemblyCompany As String = "Developer Express Inc."
	Friend Const VersionId As Integer = 102
	Public Const VersionShort As String = "10.2"
#If (Not SILVERLIGHT) Then
		Public Const Version As String = "10.2.5.0"
	Public Const XpfPrefix As String = "WPF"
#Else
		Public Const Version As String = "10.2.5.5"
	Public Const XpfPrefix As String = "SL"
#End If
		Public Const FileVersion As String = "10.2.5.0"
	Public Const MarketingVersion As String = "v2010 vol 2"
	Public Const VirtDirSuffix As String = "_v10_2"
	Public Const SatelliteContractVersion As String = VersionShort & ".0.0"
	Public Const VSuffixWithoutSeparator As String = "v" & VersionShort
	Public Const VSuffix As String = "." & VSuffixWithoutSeparator
	Public Const VSuffixDesign As String = VSuffix & ".Design"
	Public Const VSuffixExport As String = VSuffix & ".Export"
	Public Const SRAssemblyAgScheduler As String = "DevExpress.Xpf.Scheduler" & VSuffix
	Public Const SRAssemblyXpfRichEdit As String = "DevExpress.Xpf.RichEdit" & VSuffix
	Public Const SRAssemblyXpfRichEditExtensions As String = "DevExpress.Xpf.RichEdit" & VSuffix & ".Extensions"
	Public Const SRAssemblyXpfPrintingService As String = "DevExpress.Xpf.Printing" & VSuffix & ".Service"
	Public Const SRAssemblyXpfPrinting As String = "DevExpress.Xpf.Printing" & VSuffix
	Public Const SRAssemblyXpfCore As String = "DevExpress.Xpf.Core" & VSuffix
	Public Const SRAssemblyXpfDemoBase As String = "DevExpress.Xpf.DemoBase" & VSuffix
	Public Const SRAssemblyXpfGrid As String = "DevExpress.Xpf.Grid" & VSuffix
	Public Const SRAssemblyXpfGridCore As String = "DevExpress.Xpf.Grid" & VSuffix & ".Core"
	Public Const SRAssemblyXpfDocking As String = "DevExpress.Xpf.Docking" & VSuffix
	Public Const SRAssemblyXpfLayoutCore As String = "DevExpress.Xpf.Layout" & VSuffix & ".Core"
	Public Const SRAssemblyDXCharts As String = "DevExpress.Xpf.Charts" & VSuffix
	Public Const SRDocumentationLink As String = "http://documentation.devexpress.com/"
	Public Const InstallationRegistryKey As String = "SOFTWARE\DevExpress\Components\" & VSuffixWithoutSeparator
	Public Const InstallationRegistryRootPathValueName As String = "RootDirectory"
	Public Const SRAssemblyXpfPrefix As String = "DevExpress.Xpf"
	Public Const ThemePrefixWithoutSeparator As String = "Themes"
	Public Const ThemePrefix As String = "." & ThemePrefixWithoutSeparator & "."
#If (Not SILVERLIGHT) Then
	Public Const SRAssemblyMVC As String = "DevExpress.Web.Mvc" & VSuffix, SRAssemblyExpressAppWeb As String = "DevExpress.ExpressApp.Web" & VSuffix, SRAssemblyASPxThemes As String = "DevExpress.Web.ASPxThemes" & VSuffix, SRAssemblyASPxGridView As String = "DevExpress.Web.ASPxGridView" & VSuffix, SRAssemblyASPxGridViewExport As String = "DevExpress.Web.ASPxGridView" & VSuffixExport, SRAssemblyASPxPivotGrid As String = "DevExpress.Web.ASPxPivotGrid" & VSuffix, SRAssemblyASPxPivotGridExport As String = "DevExpress.Web.ASPxPivotGrid" & VSuffixExport, SRAssemblyDesign As String = "DevExpress.Design" & VSuffix, SRAssemblyData As String = "DevExpress.Data" & VSuffix, SRAssemblyUtils As String = "DevExpress.Utils" & VSuffix, SRAssemblyParser As String = "DevExpress.Parser" & VSuffix, SRAssemblyPrinting As String = "DevExpress.XtraPrinting" & VSuffix, SRAssemblyPrintingDesign As String = "DevExpress.XtraPrinting" & VSuffixDesign, SRAssemblyEditors As String = "DevExpress.XtraEditors" & VSuffix, SRAssemblyEditorsDesign As String = "DevExpress.XtraEditors" & VSuffixDesign, SRAssemblyNavBar As String = "DevExpress.XtraNavBar" & VSuffix, SRAssemblyNavBarDesign As String = "DevExpress.XtraNavBar" & VSuffixDesign, SRAssemblyBars As String = "DevExpress.XtraBars" & VSuffix, SRAssemblyBarsDesign As String = "DevExpress.XtraBars" & VSuffixDesign, SRAssemblyGrid As String = "DevExpress.XtraGrid" & VSuffix, SRAssemblyGaugesCore As String = "DevExpress.XtraGauges" & VSuffix & ".Core", SRAssemblyGaugesPresets As String = "DevExpress.XtraGauges" & VSuffix & ".Presets", SRAssemblyGaugesWin As String = "DevExpress.XtraGauges" & VSuffix & ".Win", SRAssemblyASPxGauges As String = "DevExpress.Web.ASPxGauges" & VSuffix, SRAssemblyGaugesDesignWin As String = "DevExpress.XtraGauges" & VSuffixDesign & ".Win", SRAssemblyGridDesign As String = "DevExpress.XtraGrid" & VSuffixDesign, SRAssemblyPivotGrid As String = "DevExpress.XtraPivotGrid" & VSuffix, SRAssemblyPivotGridCore As String = "DevExpress.PivotGrid" & VSuffix & ".Core", SRAssemblyPivotGridDesign As String = "DevExpress.XtraPivotGrid" & VSuffixDesign, SRAssemblyTreeList As String = "DevExpress.XtraTreeList" & VSuffix, SRAssemblyTreeListDesign As String = "DevExpress.XtraTreeList" & VSuffixDesign, SRAssemblyVertGrid As String = "DevExpress.XtraVerticalGrid" & VSuffix, SRAssemblyVertGridDesign As String = "DevExpress.XtraVerticalGrid" & VSuffixDesign, SRAssemblyReports As String = "DevExpress.XtraReports" & VSuffix, SRAssemblyReportsService As String = "DevExpress.XtraReports" & VSuffix & ".Service", SRAssemblyReportsDesign As String = "DevExpress.XtraReports" & VSuffixDesign, SRAssemblyReportsImport As String = "DevExpress.XtraReports" & VSuffix & ".Import", SRAssemblyReportsWeb As String = "DevExpress.XtraReports" & VSuffix & ".Web", SRAssemblyReportsExtensions As String = "DevExpress.XtraReports" & VSuffix & ".Extensions", SRAssemblyReportsDesignDelphi8 As String = "DevExpress.XtraReports" & VSuffix & ".Design.Delphi8", SRAssemblyReportsDesignDelphi9 As String = "DevExpress.XtraReports" & VSuffix & ".Design.Delphi9", SRAssemblyReportsDesignDelphi10 As String = "DevExpress.XtraReports" & VSuffix & ".Design.Delphi10", SRAssemblyRichEdit As String = "DevExpress.XtraRichEdit" & VSuffix, SRAssemblyRichEditDesign As String = "DevExpress.XtraRichEdit" & VSuffixDesign, SRAssemblyRichEditExtensions As String = "DevExpress.XtraRichEdit" & VSuffix & ".Extensions", SRAssemblyRichEditPrinting As String = "DevExpress.XtraRichEdit" & VSuffix & ".Printing", SRAssemblyScheduler As String = "DevExpress.XtraScheduler" & VSuffix, SRAssemblySchedulerCore As String = "DevExpress.XtraScheduler" & VSuffix & ".Core", SRAssemblySchedulerDesign As String = "DevExpress.XtraScheduler" & VSuffixDesign, SRAssemblySchedulerWeb As String = "DevExpress.Web.ASPxScheduler" & VSuffix, SRAssemblySchedulerWebDesign As String = "DevExpress.Web.ASPxScheduler" & VSuffixDesign, SRAssemblySchedulerOutlookExchange As String = "DevExpress.XtraScheduler" & VSuffix & ".OutlookExchange", SRAssemblySchedulerVCalendarExchange As String = "DevExpress.XtraScheduler" & VSuffix & ".VCalendarExchange", SRAssemblyScheduleriCalendarExchange As String = "DevExpress.XtraScheduler" & VSuffix & ".iCalendarExchange", SRAssemblySchedulerExtensions As String = "DevExpress.XtraScheduler" & VSuffix & ".Extensions", SRAssemblySchedulerReporting As String = "DevExpress.XtraScheduler" & VSuffix & ".Reporting", SRAssemblySchedulerReportingExtensions As String = "DevExpress.XtraScheduler" & VSuffix & ".Reporting.Extensions", SRAssemblyChartsCore As String = "DevExpress.Charts" & VSuffix & ".Core", SRAssemblyCharts As String = "DevExpress.XtraCharts" & VSuffix, SRAssemblyChartsExtensions As String = "DevExpress.XtraCharts" & VSuffix & ".Extensions", SRAssemblyChartsDesign As String = "DevExpress.XtraCharts" & VSuffixDesign, SRAssemblyChartsWebDesign As String = "DevExpress.XtraCharts" & VSuffix & ".Web.Design", SRAssemblyChartsUI As String = "DevExpress.XtraCharts" & VSuffix & ".UI", SRAssemblyChartsWeb As String = "DevExpress.XtraCharts" & VSuffix & ".Web", SRAssemblyWizard As String = "DevExpress.XtraWizard" & VSuffix, SRAssemblyWizardDesign As String = "DevExpress.XtraWizard" & VSuffixDesign, SRAssemblyXpo As String = "DevExpress.Xpo" & VSuffix, SRAssemblyXpoDesign As String = "DevExpress.Xpo" & VSuffixDesign, SRAssemblyLayoutControl As String = "DevExpress.XtraLayout" & VSuffix, SRAssemblyLayoutControlDesign As String = "DevExpress.XtraLayout" & VSuffixDesign, SRAssemblySpellCheckerCore As String = "DevExpress.SpellChecker" & VSuffix & ".Core", SRAssemblySpellChecker As String = "DevExpress.XtraSpellChecker" & VSuffix, SRAssemblySpellCheckerDesign As String = "DevExpress.XtraSpellChecker" & VSuffixDesign, SRAssemblySpellCheckerWeb As String = "DevExpress.Web.ASPxSpellChecker" & VSuffix, SRAssemblyWeb As String = "DevExpress.Web" & VSuffix, SRAssemblyHtmlEditorWeb As String = "DevExpress.Web.ASPxHtmlEditor" & VSuffix, SRAssemblyEditorsWeb As String = "DevExpress.Web.ASPxEditors" & VSuffix, SRAssemblyTreeListWeb As String = "DevExpress.Web.ASPxTreeList" & VSuffix, SRAssemblyTreeListWebExport As String = "DevExpress.Web.ASPxTreeList" & VSuffixExport, SRAssemblyXpfScheduler As String = "DevExpress.Xpf.Scheduler" & VSuffix, SRAssemblyDXPivotGrid As String = "DevExpress.Xpf.PivotGrid" & VSuffix
#End If
	Public Const DXTabNameComponents As String = "Components", DXTabNameNavigationAndLayout As String = "Navigation & Layout", DXTabNameReporting As String = "Reporting", DXTabNameReportControls As String = "Report Controls", DXTabNameData As String = "Data", DXTabNameScheduling As String = "Scheduling", DXTabNameSchedulerReporting As String = "Scheduler Reporting", DXTabNameRichEdit As String = "Rich Text Editor", DXTabNameCommon As String = "Common Controls", DXTabNameLayoutControl As String = "Layout Control", DXTabPrefix As String = "DX." & VersionShort & ": ", DXTabComponents As String = DXTabPrefix & DXTabNameComponents, DXTabNavigation As String = DXTabPrefix & DXTabNameNavigationAndLayout, DXTabReporting As String = DXTabPrefix & DXTabNameReporting, DXTabReportControls As String = DXTabPrefix & DXTabNameReportControls, DXTabData As String = DXTabPrefix & DXTabNameData, DXTabScheduling As String = DXTabPrefix & DXTabNameScheduling, DXTabSchedulerReporting As String = DXTabPrefix & DXTabNameSchedulerReporting, DXTabRichEdit As String = DXTabPrefix & DXTabNameRichEdit, DXTabCommon As String = DXTabPrefix & DXTabNameCommon
	Public Const DXTabWpfNavigation As String = "DX." & VersionShort & "." & XpfPrefix & ": Navigation & Layout", DXTabWpfReporting As String = "DX." & VersionShort & "." & XpfPrefix & ": Reporting", DXTabWpfLayoutControl As String = "DX." & VersionShort & "." & XpfPrefix & ": Layout", DXTabWpfData As String = "DX." & VersionShort & "." & XpfPrefix & ": Data", DXTabWpfCommon As String = "DX." & VersionShort & "." & XpfPrefix & ": Common Controls", DXTabWpfScheduling As String = "DX." & VersionShort & "." & XpfPrefix & ": Scheduling", DXTabWpfRichEdit As String = "DX." & VersionShort & "." & XpfPrefix & ": Rich Text Editor"
	End Class
#If (Not DXCommon) Then
End Namespace
#End If
