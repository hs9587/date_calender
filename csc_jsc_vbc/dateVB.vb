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
        Me.Size = New Size(170, 235)

        ' 年/月と曜日用のラベルを作成し、フォントサイズを通常に設定
        LabelYearMonthDayOfWeek = New Label()
        LabelYearMonthDayOfWeek.AutoSize = True
        LabelYearMonthDayOfWeek.Location = New Point(20, 10)
        LabelYearMonthDayOfWeek.Font = New Font("Arial", 12, FontStyle.Regular) ' 通常サイズのフォント
        Me.Controls.Add(LabelYearMonthDayOfWeek)

        ' 日付用のラベルを作成し、フォントサイズを大きく設定
        LabelDay = New Label()
        LabelDay.AutoSize = True
        LabelDay.Location = New Point(00, 20)
        LabelDay.Font = New Font("Arial", 80, FontStyle.Regular) ' 大きなフォント
        'Me.Controls.Add(LabelDay) '日付は一番後ろに配置して時間表示を覆い隠さないように

        ' 時間用のラベルを作成
        LabelTime = New Label()
        LabelTime.AutoSize = True
        LabelTime.Location = New Point(20, 130)
        LabelTime.Font = New Font("Arial", 12, FontStyle.Regular) ' 通常サイズのフォント
        Me.Controls.Add(LabelTime)

        ' UTC時間用のラベルを作成
        LabelUtcTime = New Label()
        LabelUtcTime.AutoSize = True
        LabelUtcTime.Location = New Point(20, 150)
        LabelUtcTime.Font = New Font("Arial", 12, FontStyle.Regular)
        Me.Controls.Add(LabelUtcTime)

        ' PDT時間用のラベルを作成
        LabelPdtTime = New Label()
        LabelPdtTime.AutoSize = True
        LabelPdtTime.Location = New Point(20, 170)
        LabelPdtTime.Font = New Font("Arial", 12, FontStyle.Regular)
        Me.Controls.Add(LabelPdtTime)
        
	Me.Controls.Add(LabelDay) '日付は一番後ろに配置して時間表示を覆い隠さないように

        ' タイマーの設定
        Timer1 = New Timer()
        Timer1.Interval = 1000 ' 1秒ごとに更新
        Timer1.Start()

        ' 初期位置でセンタリング
        CenterLabels()
    End Sub

    ' タイマーのTickイベントで日時を更新
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' 年/月と曜日を通常サイズで表示
        Dim yearMonth As String = DateTime.Now.ToString("yyyy/M/")
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
        LabelUtcTime.Text = "UTC" & utcNow.ToString("/MM/dd HH")

        ' PDTの時間を表示
        Dim pdtZone As TimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time")
        Dim pdtNow As DateTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, pdtZone)
        LabelPdtTime.Text = "PDT" & pdtNow.ToString("/MM/dd HH")

        ' ラベルを再度センタリング
        CenterLabels()
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

    ' ラベルをセンタリングする関数
    Private Sub CenterLabels()
        ' フォームの中央にラベルを配置するため、幅を基準にして Left を調整
        LabelYearMonthDayOfWeek.Left = (Me.ClientSize.Width - LabelYearMonthDayOfWeek.Width) / 2
        LabelDay.Left = (Me.ClientSize.Width - LabelDay.Width) / 2
        LabelTime.Left = (Me.ClientSize.Width - LabelTime.Width) / 2
        LabelUtcTime.Left = (Me.ClientSize.Width - LabelUtcTime.Width) / 2
        LabelPdtTime.Left = (Me.ClientSize.Width - LabelPdtTime.Width) / 2

        ' 垂直方向の位置を設定
        LabelYearMonthDayOfWeek.Top = 10
        LabelDay.Top = 20
        LabelTime.Top = 130
        LabelUtcTime.Top = 150
        LabelPdtTime.Top = 170
    End Sub
End Class

' アプリケーションのエントリーポイント
Public Module MyApp
    Sub Main()
        Application.Run(New MyForm())
    End Sub
End Module
