'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class [Event]
    Public Property EventId As Integer
    Public Property EventName As String
    Public Property EventDate As Nullable(Of Date)

    Public Overridable Property Event_StudentMapping As ICollection(Of Event_StudentMapping) = New HashSet(Of Event_StudentMapping)

End Class