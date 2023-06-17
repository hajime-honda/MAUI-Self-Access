namespace MAUI学習
{
    public class GraphicsDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            canvas.DrawRectangle(dirtyRect.Inflate(-1, -1));

            canvas.FillColor = Colors.DarkBlue;
            canvas.FillCircle(10, 10, 40);
        }
    }
}
