Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Windows
Imports System.Windows.Controls

Partial Public Class MainPage
    Inherits Page
    Public Sub New()
        Me.InitializeComponent()

        MyFunc().Wait()
    End Sub

    Public Async Function MyFunc() As Task(Of Integer)
        Dim proxy = New OpenSilverServiceProxy.ServiceProxy()
        Dim requestParam = 1
        Dim results = Await proxy.GetDataAsync(requestParam)
        Console.WriteLine(results)

        Return requestParam
    End Function

End Class