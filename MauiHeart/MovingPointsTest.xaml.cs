using Microsoft.Maui.Controls.Shapes;

namespace MauiHeart;

public partial class MovingPointsTest : ContentPage
{
    Microsoft.Maui.Controls.Shapes.Path firstHeart;
    Point startPnt = new Point();

    Point LeftPnt1 = new Point();
    Point LeftPnt2 = new Point();
    Point LeftPnt3 = new Point();

    Point RightPnt1 = new Point();
    Point RightPnt2 = new Point();
    Point RightPnt3 = new Point();
    int tapCount = 0;  
        
    public MovingPointsTest()
	{
		InitializeComponent();
        
        startPnt.X = 800.0;
        startPnt.Y = 100.0;
        LeftPnt1.X = 1400.0;
        LeftPnt1.Y = 100.0;
        LeftPnt2.X = 1400.0;
        LeftPnt2.Y = 450.0;
        LeftPnt3.X = 800.0;
        LeftPnt3.Y = 750.0;
        RightPnt1.X = 200.0;
        RightPnt1.Y = 450.0;
        RightPnt2.X = 200.0;
        RightPnt2.Y = 100.0;
        RightPnt3.X = 800.0;
        RightPnt3.Y = 100.0;

        Microsoft.Maui.Controls.Shapes.PathFigure figure1 = new Microsoft.Maui.Controls.Shapes.PathFigure();
        figure1.StartPoint = startPnt;
        figure1.Segments.Add(new BezierSegment(LeftPnt1, LeftPnt2, LeftPnt3));
        figure1.Segments.Add(new BezierSegment(RightPnt1, RightPnt2, RightPnt3));
        figure1.Segments.Add(new LineSegment(new Point(800.0, 850.0)));

        Microsoft.Maui.Controls.Shapes.PathFigureCollection figureCollection = new Microsoft.Maui.Controls.Shapes.PathFigureCollection();
        figureCollection.Add(figure1);
        Microsoft.Maui.Controls.Shapes.PathGeometry pathGeometry = new Microsoft.Maui.Controls.Shapes.PathGeometry(figureCollection);
        firstHeart = new Microsoft.Maui.Controls.Shapes.Path(pathGeometry);
        firstHeart.StrokeThickness = 2.0;
        firstHeart.Stroke = Colors.Red;
        // firstHeart.Fill = Colors.Red;


        // Set the bounds for the firstHeart element
        AbsoluteLayout.SetLayoutBounds(firstHeart, new Microsoft.Maui.Graphics.Rect(0.0, 0.0, 1600.0, 880.0));
        AbsoluteLayout.SetLayoutFlags(firstHeart, Microsoft.Maui.Layouts.AbsoluteLayoutFlags.None);

        // Add the firstHeart element to the MyAbsoluteLayout
        MyLayout.Children.Add(firstHeart);

        GestureRecognizer gesture = new GestureRecognizer();
        TapGestureRecognizer tap = new TapGestureRecognizer();
        tap.Tapped += Tap_Tapped;

        MyLayout.GestureRecognizers.Add(tap);

    }

    private void Tap_Tapped(object sender, TappedEventArgs e)
    {
        var visualElement = (VisualElement)sender;
        var bounds = visualElement.Bounds;
        var tapPosition = e.GetPosition(visualElement);

        // Get the X and Y coordinates of the tap
        var x = tapPosition.Value.X + bounds.X;
        var y = tapPosition.Value.Y + bounds.Y;

        // Do something with the X and Y values, e.g. display them in a label
        myLabel.Text = $"Tapped at X:{x}, Y:{y}\n\rtapCount = {tapCount}";
        tapCount++;
        if (tapCount == 1)
        {
            startPnt.X = x;
            startPnt.Y = y;
        }
        else if (tapCount == 2)
        {
            LeftPnt1.X = x;
            LeftPnt1.Y = y;
        }
        else if (tapCount == 3)
        {
            LeftPnt2.X = x;
            LeftPnt2.Y = y;
        }
        else if (tapCount == 4)
        {
            LeftPnt3.X = x;
            LeftPnt3.Y = y;
        }
        else if (tapCount == 5)
        {
            RightPnt1.X = x;
            RightPnt1.Y = y;
        }
        else if (tapCount == 6)
        {
            RightPnt2.X = x;
            RightPnt2.Y = y;
        }
        else if (tapCount == 7)
        {
            RightPnt3.X = x;
            RightPnt3.Y = y;

            MyLayout.Children.Clear();

            Label myLabel = new Label()
            {
                FontSize = 24.0,
            };
            myLabel.Text = $"Tapped at X:{x}, Y:{y}\n\rtapCount = {tapCount}";

            AbsoluteLayout.SetLayoutBounds(myLabel, new Microsoft.Maui.Graphics.Rect(0.0, 0.2, 250.0, 250.0));
            AbsoluteLayout.SetLayoutFlags(myLabel, Microsoft.Maui.Layouts.AbsoluteLayoutFlags.PositionProportional);
            MyLayout.Children.Add(myLabel);

            Microsoft.Maui.Controls.Shapes.PathFigure figure1 = new Microsoft.Maui.Controls.Shapes.PathFigure();
            figure1.StartPoint = startPnt;
            figure1.Segments.Add(new BezierSegment(LeftPnt1, LeftPnt2, LeftPnt3));
            figure1.Segments.Add(new BezierSegment(RightPnt1, RightPnt2, RightPnt3));
            figure1.Segments.Add(new LineSegment(new Point(800.0, 850.0)));

            Microsoft.Maui.Controls.Shapes.PathFigureCollection figureCollection = new Microsoft.Maui.Controls.Shapes.PathFigureCollection();
            figureCollection.Add(figure1);
            Microsoft.Maui.Controls.Shapes.PathGeometry pathGeometry = new Microsoft.Maui.Controls.Shapes.PathGeometry(figureCollection);
            firstHeart = new Microsoft.Maui.Controls.Shapes.Path(pathGeometry);
            firstHeart.StrokeThickness = 2.0;
            firstHeart.Stroke = Colors.Red;
            // firstHeart.Fill = Colors.Red;


            // Set the bounds for the firstHeart element
            AbsoluteLayout.SetLayoutBounds(firstHeart, new Microsoft.Maui.Graphics.Rect(0.0, 0.0, 1600.0, 880.0));
            AbsoluteLayout.SetLayoutFlags(firstHeart, Microsoft.Maui.Layouts.AbsoluteLayoutFlags.None);

            // Add the firstHeart element to the MyAbsoluteLayout
            
            MyLayout.Children.Add(firstHeart);


            GestureRecognizer gesture = new GestureRecognizer();
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;

            MyLayout.GestureRecognizers.Add(tap);
            tapCount = 0;
        }
    }
}