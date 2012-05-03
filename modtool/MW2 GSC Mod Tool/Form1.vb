Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Take All Weapons" Then
            TextBox1.Text = "self takeAllWeapons();"
        ElseIf ComboBox1.Text = "Give Weapon" Then
            TextBox1.Text = "self giveWeapon(" & Chr(34) + ComboBox3.Text & Chr(34) + ", " + TextBox6.Text + ", false" + ");"
        ElseIf ComboBox1.Text = "Switch to Weapon" Then
            TextBox1.Text = "self switchToWeapon(" & Chr(34) + ComboBox3.Text & Chr(34) + ");"
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Take All Weapons" Then
            ComboBox3.Enabled = False
            ComboBox4.Enabled = False
        End If
        If ComboBox1.Text = "Give Weapon" Then
            ComboBox3.Enabled = True
        End If
        If ComboBox1.Text = "Switch to Weapon" Then
            ComboBox3.Enabled = True
        End If
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ComboBox5.Text = "On" Then
            TextBox2.Text = "self ThermalVisionFOFOverlayOn();"
        End If
        If ComboBox5.Text = "Off" Then
            TextBox2.Text = "self ThermalVisionFOFOverlayOff();"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox3.Text = "self setModel(" + ComboBox6.Text + ");"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox5.Text = "self thread maps\mp\gametypes\_hud_message::hintMessage(" & Chr(34) + TextBox4.Text & Chr(34) + ");"
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.Text = "woodland" Then
            TextBox6.Text = "1"
        ElseIf ComboBox4.Text = "desert" Then
            TextBox6.Text = "2"
        ElseIf ComboBox4.Text = "arctic" Then
            TextBox6.Text = "3"
        ElseIf ComboBox4.Text = "digital" Then
            TextBox6.Text = "4"
        ElseIf ComboBox4.Text = "red_urban" Then
            TextBox6.Text = "5"
        ElseIf ComboBox4.Text = "red_tiger" Then
            TextBox6.Text = "6"
        ElseIf ComboBox4.Text = "blue_tiger" Then
            TextBox6.Text = "7"
        ElseIf ComboBox4.Text = "orange_fall" Then
            TextBox6.Text = "8"
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If ComboBox2.Text = "Everyone" Then
            TextBox8.Text = "VisionSetNaked( " + ComboBox7.Text + ", transition_time );"
        End If
        If ComboBox2.Text = "1 Person" Then
            TextBox8.Text = "self VisionSetNakedForPlayer( " + ComboBox7.Text + ", transition_time );"
        End If
    End Sub
End Class
