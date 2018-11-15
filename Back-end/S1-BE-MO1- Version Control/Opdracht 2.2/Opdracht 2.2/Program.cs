using System;
02
using System.Collections.Generic;
03
using System.ComponentModel;
04
using System.Data;
05
using System.Drawing;
06
using System.Text;
07
using System.Windows.Forms;
08
namespace WindowsApplication1
09
{
10
public partial class Form1 : Form
11
{
12
public Form1()
13
{
14
InitializeComponent();
15
}
16
private void label1_Click(object sender, EventArgs e)
17
{
18
//clear text box
19
 tbFirstBox1.Clear()
20
     
21
}
22
private void button1_Click(object sender, EventArgs e)
23
{
24
double weight = Convert.ToDouble(txtWeight.Text);
25
double height = Convert.ToDouble(txtHeight.Text);
26
double bmi = 703.0 * weight / height / height;
27
lblResults.Text = bmi.ToString("F2");
28
 private void btnExit_Click(object sender, EventArgs e)
29
 {
30
  Application.Exit();
31
 }
32
}
33
}
