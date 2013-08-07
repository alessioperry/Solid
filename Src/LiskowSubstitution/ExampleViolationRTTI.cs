namespace LiskowSubstitution
{
    class ExampleViolationRTTI
    {

        //this is a violation of Liskov Substitution
        //calculateAreas have to know all the derived classes of a shaoe to work well
        public double calculateAreas(Shape shape)
        {
            var circle = (Circle) shape;
            var rectangle = (Rectangle) shape;

            //test

            return circle == null ? rectangle.Area() : circle.Area();
        }
    }


    public class ViolationOfLiskov
    {
        public void violation()
        {
            var square = new SquareViolationg();
            square.SetHeight(30);

            TheViolation(square);

            //the heicht and the width are not the same.
        }

        private void TheViolation(rettangleViolating rectangle)
        {
            rectangle.SetHeight(34);
        }
    }

    public class rettangleViolating
    {
        private double width;
        private double height;

        public void SetHeight(double height)
        {
            this.height = height;
        }

        public double GetHeight()
        {
            return height;
        }

        public void SetWidth(double width)
        {
            this.width = width;
        }

        public double GetWidth()
        {
            return width;
        }
    }

    public class SquareViolationg : rettangleViolating
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
