using System;
using Cairo;
using Gdk;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    int i = 0;
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        drawingarea2.AddEvents((int)
            (EventMask.ButtonPressMask
            | EventMask.ButtonReleaseMask
            | EventMask.KeyPressMask
            | EventMask.PointerMotionMask));

    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;

    }

    [Obsolete]
    private void OnButton11Clicked(object sender, EventArgs e)
    {
        i++;
        label1.Text = i.ToString();

    }
    
    protected void OnDrawingarea2ButtonPressEvent(object o, ButtonPressEventArgs args)
    {
        DrawingArea area = drawingarea2;
        Context g = Gdk.CairoHelper.Create(area.GdkWindow);

        PointD p1, p2, p3, p4;
        p1 = new PointD(10, 10);
        p2 = new PointD(100, 10);
        p3 = new PointD(100, 100);
        p4 = new PointD(10, 100);

        g.MoveTo(p1);
        g.LineTo(p2);
        g.LineTo(p3);
        g.LineTo(p4);
        g.LineTo(p1);
        g.ClosePath();

        g.Color = new Cairo.Color(0, 0, 0);
        g.FillPreserve();
        g.Color = new Cairo.Color(1, 0, 0);
        g.Stroke();

        g.GetTarget().Dispose();
        g.Dispose();
    }

    protected void OnDragDrop(object o, DragDropArgs args)
    {
        DrawingArea area = drawingarea2;
        Context g = Gdk.CairoHelper.Create(area.GdkWindow);

        PointD p1, p2, p3, p4;
        p1 = new PointD(10, 10);
        p2 = new PointD(100, 10);
        p3 = new PointD(100, 100);
        p4 = new PointD(10, 100);

        g.MoveTo(p1);
        g.LineTo(p2);
        g.LineTo(p3);
        g.LineTo(p4);
        g.LineTo(p1);
        g.ClosePath();

        g.Color = new Cairo.Color(0, 0, 0);
        g.FillPreserve();
        g.Color = new Cairo.Color(1, 0, 0);
        g.Stroke();

        g.GetTarget().Dispose();
        g.Dispose();
    }
}
