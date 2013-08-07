namespace LiskowSubstitution
{
    class ExampleViolationRTTI
    {
        public double calculateAreas(Shape shape)
        {
            var circle = (Circle) shape;
            var rectangle = (Rectangle) shape;

            //test

            return circle == null ? rectangle.Area() : circle.Area();
        }
    }
}
