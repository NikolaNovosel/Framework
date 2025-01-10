
namespace Framework
{
    public class Model
    {
        private readonly string expectedResult;
        public Model(string expectedResult)
        {
            this.expectedResult = expectedResult;
        }
        public string GetExpectedResult => expectedResult;
    }
}
