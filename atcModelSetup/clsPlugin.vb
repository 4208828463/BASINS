Imports atcMwGisUtility

Public Class PlugIn
    Implements MapWindow.Interfaces.IPlugin

    Public pMapWin As MapWindow.Interfaces.IMapWin

    'TODO: get these from BASINS4 or plugInManager?
    Private Const ModelsMenuName As String = "BasinsModels"
    Private Const ModelsMenuString As String = "&Models"

    Public ReadOnly Property Name() As String Implements MapWindow.Interfaces.IPlugin.Name
        Get
            Return "Model Setup (HSPF/AQUATOX)"
        End Get
    End Property

    Public ReadOnly Property Author() As String Implements MapWindow.Interfaces.IPlugin.Author
        Get
            Return "AQUA TERRA Consultants"
        End Get
    End Property

    Public ReadOnly Property SerialNumber() As String Implements MapWindow.Interfaces.IPlugin.SerialNumber
        Get
            Return "G14R/KCU1FOWVVI"
        End Get
    End Property

    Public ReadOnly Property Description() As String Implements MapWindow.Interfaces.IPlugin.Description
        Get
            Return "An interface for initializing two BASINS models: HSPF and AQUATOX."
        End Get
    End Property

    Public ReadOnly Property BuildDate() As String Implements MapWindow.Interfaces.IPlugin.BuildDate
        Get
            Return System.IO.File.GetLastWriteTime(Me.GetType().Assembly.Location)
        End Get
    End Property

    Public ReadOnly Property Version() As String Implements MapWindow.Interfaces.IPlugin.Version
        Get
            Return System.Diagnostics.FileVersionInfo.GetVersionInfo(Me.GetType().Assembly.Location).FileVersion
        End Get
    End Property

    Public Sub Initialize(ByVal MapWin As MapWindow.Interfaces.IMapWin, ByVal ParentHandle As Integer) Implements MapWindow.Interfaces.IPlugin.Initialize
        Dim mnu As MapWindow.Interfaces.MenuItem

        pMapWin = MapWin

        If Not pMapWin.Plugins.PluginIsLoaded(pMapWin.Plugins.GetPluginKey("BASINS 4")) Then
            'pMapWin.Menus.AddMenu(ModelsMenuName, "", Nothing, ModelsMenuString, ToolsMenuName)
            pMapWin.Menus.AddMenu(ModelsMenuName, "", Nothing, ModelsMenuString, "mnuFile")
        End If
        mnu = pMapWin.Menus.AddMenu(ModelsMenuName & "_HSPF", ModelsMenuName, Nothing, "&HSPF")
        mnu = pMapWin.Menus.AddMenu(ModelsMenuName & "_AQUATOX", ModelsMenuName, Nothing, "&AQUATOX")

    End Sub

    Public Sub Terminate() Implements MapWindow.Interfaces.IPlugin.Terminate
        'Remove the custom menus that this plugin added
        If Not pMapWin.Plugins.PluginIsLoaded(pMapWin.Plugins.GetPluginKey("BASINS 4")) Then
            pMapWin.Menus.Remove(ModelsMenuName)
        End If
        pMapWin.Menus.Remove(ModelsMenuName & "_HSPF")
        pMapWin.Menus.Remove(ModelsMenuName & "_AQUATOX")
    End Sub

    Public Sub ItemClicked(ByVal ItemName As String, ByRef Handled As Boolean) Implements MapWindow.Interfaces.IPlugin.ItemClicked
        If ItemName = ModelsMenuName & "_HSPF" Then
            Dim main As New frmModelSetup
            GisUtil.MappingObject = pMapWin
            main.SetModelName("HSPF")
            main.InitializeUI()
            main.Show()
            Handled = True
        ElseIf ItemName = ModelsMenuName & "_AQUATOX" Then
            Dim main As New frmModelSetup
            GisUtil.MappingObject = pMapWin
            main.SetModelName("AQUATOX")
            main.InitializeUI()
            main.Show()
            Handled = True
        End If
    End Sub

    Public Sub LayerRemoved(ByVal Handle As Integer) Implements MapWindow.Interfaces.IPlugin.LayerRemoved
    End Sub

    Public Sub LayersAdded(ByVal Layers() As MapWindow.Interfaces.Layer) Implements MapWindow.Interfaces.IPlugin.LayersAdded
    End Sub

    Public Sub LayersCleared() Implements MapWindow.Interfaces.IPlugin.LayersCleared
    End Sub

    Public Sub LayerSelected(ByVal Handle As Integer) Implements MapWindow.Interfaces.IPlugin.LayerSelected
    End Sub

    Public Sub LegendDoubleClick(ByVal Handle As Integer, ByVal Location As MapWindow.Interfaces.ClickLocation, ByRef Handled As Boolean) Implements MapWindow.Interfaces.IPlugin.LegendDoubleClick
    End Sub

    Public Sub LegendMouseDown(ByVal Handle As Integer, ByVal Button As Integer, ByVal Location As MapWindow.Interfaces.ClickLocation, ByRef Handled As Boolean) Implements MapWindow.Interfaces.IPlugin.LegendMouseDown
    End Sub

    Public Sub LegendMouseUp(ByVal Handle As Integer, ByVal Button As Integer, ByVal Location As MapWindow.Interfaces.ClickLocation, ByRef Handled As Boolean) Implements MapWindow.Interfaces.IPlugin.LegendMouseUp
    End Sub

    Public Sub MapDragFinished(ByVal Bounds As System.Drawing.Rectangle, ByRef Handled As Boolean) Implements MapWindow.Interfaces.IPlugin.MapDragFinished
    End Sub

    Public Sub MapExtentsChanged() Implements MapWindow.Interfaces.IPlugin.MapExtentsChanged
    End Sub

    Public Sub MapMouseDown(ByVal Button As Integer, ByVal Shift As Integer, ByVal x As Integer, ByVal y As Integer, ByRef Handled As Boolean) Implements MapWindow.Interfaces.IPlugin.MapMouseDown
    End Sub

    Public Sub MapMouseMove(ByVal ScreenX As Integer, ByVal ScreenY As Integer, ByRef Handled As Boolean) Implements MapWindow.Interfaces.IPlugin.MapMouseMove
    End Sub

    Public Sub MapMouseUp(ByVal Button As Integer, ByVal Shift As Integer, ByVal x As Integer, ByVal y As Integer, ByRef Handled As Boolean) Implements MapWindow.Interfaces.IPlugin.MapMouseUp
    End Sub

    Public Sub Message(ByVal msg As String, ByRef Handled As Boolean) Implements MapWindow.Interfaces.IPlugin.Message
    End Sub

    Public Sub ProjectLoading(ByVal ProjectFile As String, ByVal SettingsString As String) Implements MapWindow.Interfaces.IPlugin.ProjectLoading
    End Sub

    Public Sub ProjectSaving(ByVal ProjectFile As String, ByRef SettingsString As String) Implements MapWindow.Interfaces.IPlugin.ProjectSaving
    End Sub

    Public Sub ShapesSelected(ByVal Handle As Integer, ByVal SelectInfo As MapWindow.Interfaces.SelectInfo) Implements MapWindow.Interfaces.IPlugin.ShapesSelected
    End Sub

End Class
