namespace LiskowSubstitution
{
    public class SquareViolating : RettangleViolating
    {
        public new void SetHeight(double height)
        {
            base.SetHeight(height);
            base.SetWidth(height);
        }

        public new double GetHeight()
        {
            return base.GetHeight();
        }

        public new void SetWidth(double width)
        {
            base.SetHeight(width);
            base.SetWidth(width);
        }

        public new double GetWidth()
        {
            return base.GetWidth();
        }
    }
}