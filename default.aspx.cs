using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox2.Text = TextBox1.Text;
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        var message = "";
     if (CheckBox1.Checked){
       
         message += CheckBox1.Text + " ";
     }
    
     if (CheckBox2.Checked)
     {
         message += CheckBox2.Text + " ";
     }
     if (CheckBox3.Checked)
     {
         message += CheckBox3.Text + " " ;
     }
     if (CheckBox4.Checked)
     {
         message += CheckBox4.Text + " ";
     }
     if (CheckBox5.Checked)
     {
         message += CheckBox5.Text +" ";
     }
     TextBox5.Text = message;
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
     
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
     
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        TextBox5.ForeColor = System.Drawing.Color.Orange;
    }
   
    protected void RadioButton2_CheckedChanged1(object sender, EventArgs e)
    {
        TextBox5.ForeColor = System.Drawing.Color.Blue;
    }
    protected void RadioButton3_CheckedChanged1(object sender, EventArgs e)
    {
        TextBox5.ForeColor = System.Drawing.Color.Green;
    }
    protected void RadioButton4_CheckedChanged1(object sender, EventArgs e)
    {
        TextBox5.ForeColor = System.Drawing.Color.Red;
    }
    protected void RadioButton5_CheckedChanged1(object sender, EventArgs e)
    {
        TextBox5.ForeColor = System.Drawing.Color.Yellow;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        
    }
    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        ListBox1.Items.Add(TextBox7.Text);
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        ListBox1.Items.Remove(ListBox1.SelectedItem);
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Label6.Text = ListBox1.SelectedItem.Text;
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Label6.Text = ListBox1.Items.Count.ToString();
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
            ListBox1.Items.Clear();
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        Label6.Text = ListBox1.SelectedItem.ToString();
    }
    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        Label6.Text = ListBox1.SelectedValue;
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        foreach (ListItem l in ListBox1.Items)
            if (l.Selected)
                Label6.Text += l.Text.ToString();
    }
}
