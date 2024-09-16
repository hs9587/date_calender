Imports System.Windows.Forms
Imports System.Drawing ' Size や Point を使うために必要

Public Class MyForm
    Inherits Form

    Private LabelYearMonthDayOfWeek As Label ' 年/月と曜日を通常サイズで表示
    Private LabelDay As Label ' 日付を大きく表示
    Private LabelTime As Label ' 時間を通常サイズで表示
    Private LabelUtcTime As Label ' UTCの時間を表示
    Private LabelPdtTime As Label ' PDTの時間を表示
    Private WithEvents Timer1 As Timer

    Public Sub New()
        ' フォームのサイズ設定
        Me.Text = "現在日時"
        Me.Size = New Size(400, 300)

        ' 年/月と曜日用のラベルを作成し、フォントサイズを通常に設定
        LabelYearMonthDayOfWeek = New Label()
        LabelYearMonthDayOfWeek.AutoSize = True
        LabelYearMonthDayOfWeek.Location = New Point(20, 20)
        LabelYearMonthDayOfWeek.Font = New Font("Arial", 14, FontStyle.Regular) ' 通常サイズのフォント
        Me.Controls.Add(LabelYearMonthDayOfWeek)

        ' 日付用のラベルを作成し、フォントサイズを大きく設定
        LabelDay = New Label()
        LabelDay.AutoSize = True
        LabelDay.Location = New Point(20, 60)
        LabelDay.Font = New Font("Arial", 36, FontStyle.Bold) ' 大きなフォント
        Me.Controls.Add(LabelDay)

        ' 時間用のラベルを作成
        LabelTime = New Label()
        LabelTime.AutoSize = True
        LabelTime.Location = New Point(20, 130)
        LabelTime.Font = New Font("Arial", 14, FontStyle.Regular) ' 通常サイズのフォント
        Me.Controls.Add(LabelTime)

        ' UTC時間用のラベルを作成
        LabelUtcTime = New Label()
        LabelUtcTime.AutoSize = True
        LabelUtcTime.Location = New Point(20, 160)
        LabelUtcTime.Font = New Font("Arial", 12, FontStyle.Regular)
        Me.Controls.Add(LabelUtcTime)

        ' PDT時間用のラベルを作成
        LabelPdtTime = New Label()
        LabelPdtTime.AutoSize = True
        LabelPdtTime.Location = New Point(20, 190)
        LabelPdtTime.Font = New Font("Arial", 12, FontStyle.Regular)
        Me.Controls.Add(LabelPdtTime)

        ' タイマーの設定
        Timer1 = New Timer()
        Timer1.Interval = 1000 ' 1秒ごとに更新
        Timer1.Start()
    End Sub

    ' タイマーのTickイベントで日時を更新
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' 年/月と曜日を通常サイズで表示
        Dim yearMonth As String = DateTime.Now.ToString("yyyy/MM")
        Dim dayOfWeek As String = GetJapaneseDayOfWeek(DateTime.Now.DayOfWeek)
        LabelYearMonthDayOfWeek.Text = yearMonth & " (" & dayOfWeek & ")"

        ' 日付部分を大きく表示
        Dim day As String = DateTime.Now.ToString("dd")
        LabelDay.Text = day

        ' 現在の時間を通常サイズで表示
        Dim currentTime As String = DateTime.Now.ToString("HH:mm:ss")
        LabelTime.Text = currentTime

        ' UTCの時間を表示
        Dim utcNow As DateTime = DateTime.UtcNow
        LabelUtcTime.Text = "UTC: " & utcNow.ToString("MM/dd HH:mm")

        ' PDTの時間を表示
        Dim pdtZone As TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time")
        Dim pdtNow As DateTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, pdtZone)
        LabelPdtTime.Text = "PDT: " & pdtNow.ToString("MM/dd HH:mm")
    End Sub

    ' 日本語の曜日を取得する関数
    Private Function GetJapaneseDayOfWeek(dayOfWeek As DayOfWeek) As String
        Select Case dayOfWeek
            Case DayOfWeek.Sunday
                Return "日"
            Case DayOfWeek.Monday
                Return "月"
            Case DayOfWeek.Tuesday
                Return "火"
            Case DayOfWeek.Wednesday
                Return "水"
            Case DayOfWeek.Thursday
                Return "木"
            Case DayOfWeek.Friday
                Return "金"
            Case DayOfWeek.Saturday
                Return "土"
            Case Else
                Return ""
        End Select
    End Function
End Class

' アプリケーションのエントリーポイント
Public Module MyApp
    Sub Main()
        Application.Run(New MyForm())
    End Sub
End Module
