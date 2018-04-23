' Developer Express Code Central Example:
' How to apply a custom theme to grid elements
' 
' The following example demonstrates how to create a custom theme and apply it to
' DXGrid control elements.
' In this example the custom theme assembly is used to
' customize grid control elements.
' Please notice that this assembly should follow
' this naming rule: DevExpress.Xpf.Themes.CustomAssemblyName.VersionNumber
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2882


Imports Microsoft.VisualBasic
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

Imports System.Windows.Markup
Imports System.Resources
Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports DevExpress.Internal
Imports System.Runtime.CompilerServices

<Assembly: AssemblyDescription("Xpf.Core Library")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("Developer Express Inc.")>
<Assembly: AssemblyProduct("DevExpress.Xpf.Themes.LightGray.Theme")>
<Assembly: AssemblyCopyright("Copyright (c) 2000-2011 Developer Express Inc.")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>
<Assembly: CLSCompliant(True)>

<Assembly: SatelliteContractVersion(AssemblyInfo.SatelliteContractVersion)>
<Assembly: ComVisible(False)>
<Assembly: Guid("4E99E381-22BA-4A62-8F3C-0292A924FBEC")>
<Assembly: AssemblyVersion(AssemblyInfo.Version)>
<Assembly: AssemblyFileVersion(AssemblyInfo.FileVersion)>
'INSTANT VB TODO TASK: There is no equivalent to #pragma directives in VB.NET:
'#pragma warning disable 1699

'INSTANT VB TODO TASK: There is no equivalent to #pragma directives in VB.NET:
'#pragma warning restore 1699
