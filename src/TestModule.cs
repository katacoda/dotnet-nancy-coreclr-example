namespace Nancy.Demo.Hosting.Docker
{
    public class TestModule : NancyModule
    {
        public TestModule()
        {
            Get("/", args => {
                System.Console.WriteLine("Visit: / on " + System.Environment.MachineName);
                return "Hello from Nancy running on CoreCLR";
            });

            Get("/machine", args => {
                System.Console.WriteLine("Visit: /machine on " + System.Environment.MachineName);
                return "Request processed by " + System.Environment.MachineName + "\r\n";
            });
        }
    }
}
