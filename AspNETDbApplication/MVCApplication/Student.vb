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

Partial Public Class Student
    Public Property StudentId As Integer
    Public Property StudentName As String
    Public Property Gender As String
    Public Property Email As String
    Public Property IsActive As Nullable(Of Boolean)
    Public Property CreatedDate As Nullable(Of Date)
    Public Property ModifyDate As Nullable(Of Date)

    Public Overridable Property Event_StudentMapping As ICollection(Of Event_StudentMapping) = New HashSet(Of Event_StudentMapping)

End Class
