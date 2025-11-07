#:sdk Aspire.AppHost.Sdk@13.1.0-preview.1.25556.11
#:package Aspire.Hosting.JavaScript@13.1.0-preview.1.25556.11

var builder = DistributedApplication.CreateBuilder(args);


builder.AddViteApp("vite-pnpm", "vite-project")
    .WithPnpm()
    // Ensure the PATH includes the fnm (Fast Node Manager) default alias directory
    .WithEnvironment("PATH", Environment.GetEnvironmentVariable("PATH") + ";" + Environment.ExpandEnvironmentVariables("%USERPROFILE%\\AppData\\Roaming\\fnm\\aliases\\default"))
    .WithExternalHttpEndpoints();

builder.AddViteApp("vite-npm", "vite-npm-project")
    .WithEnvironment("PATH", Environment.GetEnvironmentVariable("PATH") + ";" + Environment.ExpandEnvironmentVariables("%USERPROFILE%\\AppData\\Roaming\\fnm\\aliases\\default"))
    .WithExternalHttpEndpoints();

builder.Build().Run();
