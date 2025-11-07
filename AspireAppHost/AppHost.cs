var builder = DistributedApplication.CreateBuilder(args);

builder.AddViteApp("viteapp", "../vite-project")
    .WithPnpm()
    .WithEnvironment("PATH", Environment.GetEnvironmentVariable("PATH") + ";" + Environment.ExpandEnvironmentVariables("%USERPROFILE%\\AppData\\Roaming\\fnm\\aliases\\default"))
    .WithExternalHttpEndpoints();

builder.Build().Run();
