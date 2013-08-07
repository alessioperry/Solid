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
}
