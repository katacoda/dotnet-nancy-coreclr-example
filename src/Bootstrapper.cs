namespace WebAPIApplication
{
    using System;
    using Nancy;
    
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        public Bootstrapper() { }
        
        public Bootstrapper(AppConfiguration appConfig)
        {
            Console.WriteLine("Bootstrapping...");
        }

        public override void Configure(Nancy.Configuration.INancyEnvironment environment)
        {
          environment.Tracing(enabled: false, displayErrorTraces: true);
        }
    } 
}
