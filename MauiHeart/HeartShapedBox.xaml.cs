using Microsoft.Maui.Controls;
using System.Windows.Input;

namespace MauiHeart;

public partial class HeartShapedBox : ContentPage
{
	public HeartShapedBox()
	{
		InitializeComponent();
	}

    private void PointerGestureRecognizer_PointerMoved(object sender, PointerEventArgs e)
    {
       // Label1.Text = e.GetPosition(MyVerticalStackLayout).Value.ToString();
    }

    private void PointerGestureRecognizer_PointerMoved_1(object sender, PointerEventArgs e)
    {
        Label1.Text = e.GetPosition(this).ToString();
    }

    private void PointerGestureRecognizer_PointerMoved_2(object sender, PointerEventArgs e)
    {
        Label2.Text = e.GetPosition(this).ToString();
    }

    private void PointerGestureRecognizer_PointerMoved_3(object sender, PointerEventArgs e)
    {
        Label3.Text = e.GetPosition(this).ToString();
    }
}