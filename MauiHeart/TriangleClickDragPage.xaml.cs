using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Platform;
using System.Security.Principal;

namespace MauiHeart;

public partial class TriangleClickDragPage : ContentPage
{
    int tapCount = 0;
    private double _startX, _startY;
    private double _startX2, _startY2;

    public TriangleClickDragPage()
	{
		InitializeComponent();
        
      
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        tapCount++;
        var visualElement = (VisualElement)sender;
        var bounds = visualElement.Bounds;
        var tapPosition = e.GetPosition(visualElement);

        // Get the X and Y coordinates of the tap
        var x = tapPosition.Value.X + bounds.X;
        var y = tapPosition.Value.Y + bounds.Y;

        // Do something with the X and Y values, e.g. display them in a label
        MyLabel.Text = $"Tapped at X:{x}, Y:{y}\n\rtapCount = {tapCount}";
    }

    private void Polygon_Focused(object sender, FocusEventArgs e)
    {
        var visualElement = sender as VisualElement;
        var bounds = visualElement.Bounds;

        MyLabel.Text = bounds.ToString();
    }

    private void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
    {
       
        switch (e.StatusType)
        {
            case GestureStatus.Started:
                _startX = MyPolygon.TranslationX;
                _startY = MyPolygon.TranslationY;
                _startX2 = MyPolygon2.TranslationX;
                _startY2 = MyPolygon2.TranslationY;
                break;

            case GestureStatus.Running:
                MyPolygon.TranslationX = _startX + e.TotalX;
                MyPolygon.TranslationY = _startY + e.TotalY;
                MyPolygon2.TranslationX = _startX2 + e.TotalX + 10;
                MyPolygon2.TranslationY = _startY2 + e.TotalY + 10;

                break;

            case GestureStatus.Completed:
                break;
        }
    }
}