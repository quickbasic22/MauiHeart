using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Layouts;

namespace MauiHeart;

public partial class MovingControlPoints : ContentPage
{
    Point startPnt = new Point();

    Point LeftPnt1 = new Point();
    Point LeftPnt2 = new Point();
    Point LeftPnt3 = new Point();

    Point RightPnt1 = new Point();
    Point RightPnt2 = new Point();
    Point RightPnt3 = new Point();
    Microsoft.Maui.Controls.Shapes.Path firstHeart;


    public MovingControlPoints()
	{
		InitializeComponent();
        StartPointX.Increment = 100.0;
        StartPointX.Minimum = -2000.0;
        StartPointY.Minimum = -2000.0;
        StartPointY.Increment = 100.0;
        StartPointX.Maximum = 2000.0;
        StartPointY.Maximum = 2000.0;
        LeftPointX1.Minimum = -2000.0;
        LeftPointX1.Maximum = 2000.0;
        LeftPointY1.Minimum = -2000.0;
        LeftPointY1.Maximum = 2000.0;
        LeftPointX1.Increment = 100.0;
        LeftPointX2.Minimum = -2000.0;
        LeftPointX2.Maximum = 2000.0;
        LeftPointY2.Minimum = -2000.0;
        LeftPointY2.Maximum = 2000.0;
        LeftPointY2.Increment = 100.0;
        LeftPointX3.Minimum = -2000.0;
        LeftPointX3.Maximum = 2000.0;
        LeftPointY3.Minimum = -2000.0;
        LeftPointY3.Maximum = 2000.0;
        LeftPointY3.Increment = 100.0;
        RightPointX1.Minimum = -2000.0;
        RightPointX1.Maximum = 2000.0;
        RightPointY1.Minimum = -2000.0;
        RightPointY1.Maximum = 2000.0;
        RightPointX1.Increment = 100.0;
        RightPointX2.Minimum = -2000.0;
        RightPointX2.Maximum = 2000.0;
        RightPointY2.Minimum = -2000.0;
        RightPointY2.Maximum = 2000.0;
        RightPointY2.Increment = 100.0;
        RightPointX3.Minimum = -2000.0;
        RightPointX3.Maximum = 2000.0;
        RightPointY3.Minimum = -2000.0;
        RightPointY3.Maximum = 2000.0;
        RightPointY3.Increment = 100.0;

        StartPointX.Value = 800.0;
        StartPointY.Value = 400.0;
        LeftPointX1.Value = 625.0;
        LeftPointY1.Value = 0.0;
        LeftPointX2.Value = 444.0;
        LeftPointY2.Value = 224.0;
        LeftPointX3.Value = 800.0;
        LeftPointY3.Value = 700.0;
        RightPointX1.Value = 985.0;
        RightPointY1.Value = 0.0;
        RightPointX2.Value = 1166.0;
        RightPointY2.Value = 221.0;
        RightPointX3.Value = 800.0;
        RightPointY3.Value = 700.0;

        startPnt.X = StartPointX.Value;
        startPnt.Y = StartPointY.Value;
        LeftPnt1.X = LeftPointX1.Value;
        LeftPnt1.Y = LeftPointY1.Value;
        LeftPnt2.X = LeftPointX2.Value;
        LeftPnt2.Y = LeftPointY2.Value;
        LeftPnt3.X = LeftPointX3.Value;
        LeftPnt3.Y = LeftPointY3.Value;

        RightPnt1.X = RightPointX1.Value;
        RightPnt1.Y = RightPointY1.Value;
        RightPnt2.X = RightPointX2.Value;
        RightPnt2.Y = RightPointY2.Value;
        RightPnt3.X = RightPointX3.Value;
        RightPnt3.Y = RightPointY3.Value;
        



        Microsoft.Maui.Controls.Shapes.PathFigure figure1 = new Microsoft.Maui.Controls.Shapes.PathFigure();
        figure1.StartPoint = startPnt;
        figure1.Segments.Add(new BezierSegment(LeftPnt1, LeftPnt2, LeftPnt3));
        figure1.Segments.Add(new BezierSegment(RightPnt1, RightPnt2, RightPnt3));
        figure1.Segments.Add(new LineSegment(RightPnt3));

        Microsoft.Maui.Controls.Shapes.PathFigureCollection figureCollection = new Microsoft.Maui.Controls.Shapes.PathFigureCollection();
        figureCollection.Add(figure1);
        Microsoft.Maui.Controls.Shapes.PathGeometry pathGeometry = new Microsoft.Maui.Controls.Shapes.PathGeometry(figureCollection);
        firstHeart = new Microsoft.Maui.Controls.Shapes.Path(pathGeometry);
        firstHeart.StrokeThickness = 2.0;
        firstHeart.Stroke = Colors.Red;
        // firstHeart.Fill = Colors.Red;
      

        // Set the bounds for the firstHeart element
        AbsoluteLayout.SetLayoutBounds(firstHeart, new Microsoft.Maui.Graphics.Rect(300.0, 0.0, 900.0, 800.0));

        // Add the firstHeart element to the MyAbsoluteLayout
        MyAbsoluteLayout.Children.Add(firstHeart);


    }

    private void LeftPointX1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        Label1.Text = "";
        LeftPnt1.X = e.NewValue;
        Label1.Text += e.NewValue.ToString() + "\n\r";
        RedrawPath();
    }

    private void LeftPointX2_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        Label1.Text = "";
        LeftPnt2.X = e.NewValue;
        Label1.Text += e.NewValue.ToString() + "\n\r";
        RedrawPath();
    }

    private void LeftPointX3_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        Label1.Text = "";
        LeftPnt3.X = e.NewValue;
        Label1.Text += e.NewValue.ToString() + "\n\r";
        RedrawPath();
    }

    private void LeftPointY1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        Label1.Text = "";
        LeftPnt1.Y = e.NewValue;
        Label1.Text += e.NewValue.ToString() + "\n\r";
        RedrawPath();
    }

    private void LeftPointY2_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        Label1.Text = "";
        LeftPnt2.Y = e.NewValue;
        Label1.Text += e.NewValue.ToString() + "\n\r";
        RedrawPath();
    }

    private void LeftPointY3_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        Label1.Text = "";
        LeftPnt3.Y = e.NewValue;
        Label1.Text += e.NewValue.ToString() + "\n\r";
        RedrawPath();
    }

    private void RightPointX1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        Label1.Text = "";
        RightPnt1.X = e.NewValue;
        Label1.Text += e.NewValue.ToString() + "\n\r";
        RedrawPath();
    }

    private void RightPointX2_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        Label1.Text = "";
        RightPnt2.X = e.NewValue;
        Label1.Text += e.NewValue.ToString() + "\n\r";
        RedrawPath();
    }

    private void RightPointX3_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        Label1.Text = "";
        RightPnt3.X = e.NewValue;
        Label1.Text += e.NewValue.ToString() + "\n\r";
        RedrawPath();
    }

    private void RightPointY1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        Label1.Text = "";
        RightPnt1.Y = e.NewValue;
        Label1.Text += e.NewValue.ToString() + "\n\r";
        RedrawPath();
    }

    private void RightPointY2_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        Label1.Text = "";
        RightPnt2.Y = e.NewValue;
        Label1.Text += e.NewValue.ToString() + "\n\r";
        RedrawPath();
    }

    private void RightPointY3_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        Label1.Text = "";
        RightPnt3.Y = e.NewValue;
        Label1.Text += e.NewValue.ToString() + "\n\r";
        RedrawPath();
    }
    private void StartPointX_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        Label1.Text = "";
        startPnt.X = e.NewValue;
        Label1.Text += e.NewValue.ToString() + "\n\r";
        RedrawPath();
    }

    private void StartPointY_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        Label1.Text = "";
        startPnt.Y = e.NewValue;
        Label1.Text += e.NewValue.ToString() + "\n\r";
        RedrawPath();
    }

    void RedrawPath()
    {
        
        MyAbsoluteLayout.Children.Clear();

        Label1 = new Label
        {
            Text = "Heart Bezier Path Example",
            FontSize = 30,
            TextColor = Colors.Red,
            BackgroundColor = Colors.Yellow,
            HorizontalOptions = LayoutOptions.Center
        };

        AbsoluteLayout.SetLayoutBounds(Label1, new Rect(0.5, 0.05, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        AbsoluteLayout.SetLayoutFlags(Label1, AbsoluteLayoutFlags.PositionProportional);

        Label startingPointLabel = new Label
        {
            Text = "Starting Point",
            FontSize = 20,
            TextColor = Colors.Black
        };

        AbsoluteLayout.SetLayoutBounds(startingPointLabel, new Rect(0, 0.15, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        AbsoluteLayout.SetLayoutFlags(startingPointLabel, AbsoluteLayoutFlags.PositionProportional);

        StartPointX = new Stepper
        {
            Minimum = 0.0,
            Maximum = 1000.0,
            Value = 800.0,
            Increment = 100.0
        };

        StartPointX.ValueChanged += StartPointX_ValueChanged;

        AbsoluteLayout.SetLayoutBounds(StartPointX, new Rect(0.3, 0.2, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        AbsoluteLayout.SetLayoutFlags(StartPointX, AbsoluteLayoutFlags.PositionProportional);

        StartPointY = new Stepper
        {
            Minimum = 0.0,
            Maximum = 1000.0,
            Value = 400.0,
            Increment = 100.0
        };
        StartPointY.ValueChanged += StartPointY_ValueChanged;

        AbsoluteLayout.SetLayoutBounds(StartPointY, new Rect(0.7, 0.2, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        AbsoluteLayout.SetLayoutFlags(StartPointY, AbsoluteLayoutFlags.PositionProportional);

        Label leftPoint1Label = new Label
        {
            Text = "Left Point 1",
            FontSize = 20,
            TextColor = Colors.Black
        };

        AbsoluteLayout.SetLayoutBounds(leftPoint1Label, new Rect(0, 0.35, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        AbsoluteLayout.SetLayoutFlags(leftPoint1Label, AbsoluteLayoutFlags.PositionProportional);

        LeftPointX1 = new Stepper
        {
            Minimum = -1500.0,
            Maximum = 1500.0,
            Value = 625.0,
            Increment = 100.0
        };

        LeftPointX1.ValueChanged += LeftPointX1_ValueChanged;

        AbsoluteLayout.SetLayoutBounds(LeftPointX1, new Rect(0.3, 0.4, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        AbsoluteLayout.SetLayoutFlags(LeftPointX1, AbsoluteLayoutFlags.PositionProportional);

        LeftPointY1 = new Stepper
        {
            Minimum = -1500.0,
            Maximum = 1500.0,
            Value = 0.0,
            Increment = 100.0
        };
        LeftPointY1.ValueChanged += LeftPointY1_ValueChanged;

        AbsoluteLayout.SetLayoutBounds(LeftPointY1, new Rect(0.7, 0.4, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        AbsoluteLayout.SetLayoutFlags(LeftPointY1, AbsoluteLayoutFlags.PositionProportional);

        Label leftPoint2Label = new Label
        {
            Text = "Left Point 2",
            FontSize = 20,
            TextColor = Colors.Black
        };

        AbsoluteLayout.SetLayoutBounds(leftPoint2Label, new Rect(0, 0.55, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        AbsoluteLayout.SetLayoutFlags(leftPoint2Label, AbsoluteLayoutFlags.PositionProportional);

        LeftPointX2 = new Stepper
        {
            Minimum = -1500.0,
            Maximum = 1500.0,
            Value = 444.0,
            Increment = 100.0,
        };

        LeftPointX2.ValueChanged += LeftPointX2_ValueChanged;

        AbsoluteLayout.SetLayoutBounds(LeftPointX2, new Rect(0.3, 0.6, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        AbsoluteLayout.SetLayoutFlags(LeftPointX2, AbsoluteLayoutFlags.PositionProportional);

        LeftPointY2 = new Stepper
        {
            Minimum = -1500.0,
            Maximum = 1500.0,
            Value = 224.0,
            Increment = 100.0,
        };
        LeftPointY2.ValueChanged += LeftPointY2_ValueChanged;

        AbsoluteLayout.SetLayoutBounds(LeftPointY2, new Rect(0.3, 0.6, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        AbsoluteLayout.SetLayoutFlags(LeftPointY2, AbsoluteLayoutFlags.PositionProportional);

        Label leftPoint3Label = new Label
        {
            Text = "Left Point 2",
            FontSize = 20,
            TextColor = Colors.Black
        };

        AbsoluteLayout.SetLayoutBounds(leftPoint3Label, new Rect(0, 0.55, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        AbsoluteLayout.SetLayoutFlags(leftPoint3Label, AbsoluteLayoutFlags.PositionProportional);

        LeftPointX3 = new Stepper
        {
            Minimum = -1500.0,
            Maximum = 1500.0,
            Value = 800.0,
            Increment = 100.0,
        };

        LeftPointX3.ValueChanged += LeftPointX3_ValueChanged;

        AbsoluteLayout.SetLayoutBounds(LeftPointX3, new Rect(0.3, 0.6, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        AbsoluteLayout.SetLayoutFlags(LeftPointX3, AbsoluteLayoutFlags.PositionProportional);

        LeftPointY3 = new Stepper
        {
            Minimum = -1500.0,
            Maximum = 1500.0,
            Value = 700.0,
            Increment = 100.0,
        };

        LeftPointY3.ValueChanged += LeftPointY3_ValueChanged;

        AbsoluteLayout.SetLayoutBounds(LeftPointY3, new Rect(0.7, 0.4, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        AbsoluteLayout.SetLayoutFlags(LeftPointY3, AbsoluteLayoutFlags.PositionProportional);

        Label rightPoint1Label = new Label
        {
            Text = "Left Point 1",
            FontSize = 20,
            TextColor = Colors.Black
        };

        AbsoluteLayout.SetLayoutBounds(rightPoint1Label, new Rect(0, 0.35, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        AbsoluteLayout.SetLayoutFlags(rightPoint1Label, AbsoluteLayoutFlags.PositionProportional);

        RightPointX1 = new Stepper
        {
            Minimum = -1500.0,
            Maximum = 1500.0,
            Value = 985.0,
            Increment = 100.0,
        };

        RightPointX1.ValueChanged += RightPointX1_ValueChanged;

        AbsoluteLayout.SetLayoutBounds(RightPointX1, new Rect(0.3, 0.4, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        AbsoluteLayout.SetLayoutFlags(RightPointX1, AbsoluteLayoutFlags.PositionProportional);

        RightPointY1 = new Stepper
        {
            Minimum = -1500.0,
            Maximum = 1500.0,
            Value = 0.0,
            Increment = 100.0
        };

        RightPointY1.ValueChanged += RightPointY1_ValueChanged;

        AbsoluteLayout.SetLayoutBounds(RightPointY1, new Rect(0.7, 0.4, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        AbsoluteLayout.SetLayoutFlags(RightPointY1, AbsoluteLayoutFlags.PositionProportional);

        Label rightPoint2Label = new Label
        {
            Text = "Left Point 2",
            FontSize = 20,
            TextColor = Colors.Black
        };

        AbsoluteLayout.SetLayoutBounds(rightPoint2Label, new Rect(0, 0.55, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        AbsoluteLayout.SetLayoutFlags(rightPoint2Label, AbsoluteLayoutFlags.PositionProportional);

        RightPointX2 = new Stepper
        {
            Minimum = -1500.0,
            Maximum = 1500.0,
            Value = 1166.0,
            Increment = 100.0,
        };

        RightPointX2.ValueChanged += RightPointX2_ValueChanged;

        AbsoluteLayout.SetLayoutBounds(RightPointX2, new Rect(0.3, 0.6, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        AbsoluteLayout.SetLayoutFlags(RightPointX2, AbsoluteLayoutFlags.PositionProportional);

        RightPointY2 = new Stepper
        {
            Minimum = -1500.0,
            Maximum = 1500.0,
            Value = 221.0,
            Increment = 100.0
        };
        RightPointY2.ValueChanged += RightPointY2_ValueChanged;

        AbsoluteLayout.SetLayoutBounds(RightPointY2, new Rect(0.3, 0.6, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        AbsoluteLayout.SetLayoutFlags(RightPointY2, AbsoluteLayoutFlags.PositionProportional);

        Label rightPoint3Label = new Label
        {
            Text = "Left Point 2",
            FontSize = 20,
            TextColor = Colors.Black
        };

        AbsoluteLayout.SetLayoutBounds(rightPoint3Label, new Rect(0, 0.55, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        AbsoluteLayout.SetLayoutFlags(rightPoint3Label, AbsoluteLayoutFlags.PositionProportional);

        RightPointX3 = new Stepper
        {
            Minimum = -1500.0,
            Maximum = 1500.0,
            Value = 800.0,
            Increment = 100.0,
        };

        RightPointX3.ValueChanged += RightPointX3_ValueChanged;

        AbsoluteLayout.SetLayoutBounds(RightPointX3, new Rect(0.3, 0.6, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        AbsoluteLayout.SetLayoutFlags(RightPointX3, AbsoluteLayoutFlags.PositionProportional);

        RightPointY3 = new Stepper
        {
            Minimum = -1500.0,
            Maximum = 1500.0,
            Value = 700.0,
            Increment = 100.0,
        };

        RightPointY3.ValueChanged += RightPointY3_ValueChanged;

        AbsoluteLayout.SetLayoutBounds(RightPointY3, new Rect(0.7, 0.4, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
        AbsoluteLayout.SetLayoutFlags(RightPointY3, AbsoluteLayoutFlags.PositionProportional);

        MyAbsoluteLayout.Children.Add(Label1);
        MyAbsoluteLayout.Children.Add(startingPointLabel);
        MyAbsoluteLayout.Children.Add(StartPointX);
        MyAbsoluteLayout.Children.Add(StartPointY);

        MyAbsoluteLayout.Children.Add(leftPoint1Label);
        MyAbsoluteLayout.Children.Add(LeftPointX1);
        MyAbsoluteLayout.Children.Add(LeftPointY1);

        MyAbsoluteLayout.Children.Add(leftPoint2Label);
        MyAbsoluteLayout.Children.Add(LeftPointX2);
        MyAbsoluteLayout.Children.Add(LeftPointY2);

        MyAbsoluteLayout.Children.Add(leftPoint3Label);
        MyAbsoluteLayout.Children.Add(LeftPointX3);
        MyAbsoluteLayout.Children.Add(LeftPointY3);

        MyAbsoluteLayout.Children.Add(rightPoint1Label);
        MyAbsoluteLayout.Children.Add(RightPointX1);
        MyAbsoluteLayout.Children.Add(RightPointY1);

        MyAbsoluteLayout.Children.Add(rightPoint2Label);
        MyAbsoluteLayout.Children.Add(RightPointX2);
        MyAbsoluteLayout.Children.Add(RightPointY2);

        MyAbsoluteLayout.Children.Add(rightPoint3Label);
        MyAbsoluteLayout.Children.Add(RightPointX3);
        MyAbsoluteLayout.Children.Add(RightPointY3);


        Microsoft.Maui.Controls.Shapes.PathFigure figure1 = new Microsoft.Maui.Controls.Shapes.PathFigure();
        figure1.StartPoint = startPnt;
        figure1.IsClosed = true;
        figure1.Segments.Add(new BezierSegment(LeftPnt1, LeftPnt2, LeftPnt3));
        figure1.Segments.Add(new BezierSegment(RightPnt1, RightPnt2, RightPnt3));
        figure1.Segments.Add(new LineSegment(RightPnt3));

        Microsoft.Maui.Controls.Shapes.PathFigureCollection figureCollection = new Microsoft.Maui.Controls.Shapes.PathFigureCollection();
        figureCollection.Add(figure1);
        Microsoft.Maui.Controls.Shapes.PathGeometry pathGeometry = new Microsoft.Maui.Controls.Shapes.PathGeometry(figureCollection);
        firstHeart = new Microsoft.Maui.Controls.Shapes.Path(pathGeometry);
        firstHeart.StrokeThickness = 2.0;
        firstHeart.Stroke = Colors.Red;
        // firstHeart.Fill = Colors.Red;
        

        // Set the bounds for the firstHeart element
        AbsoluteLayout.SetLayoutBounds(firstHeart, new Microsoft.Maui.Graphics.Rect(300.0, 0.0, 900.0, 800.0));

        
        MyAbsoluteLayout.Children.Add(firstHeart);

    }
}