var builder = DistributedApplication.CreateBuilder(args);

builder.AddViteApp("viteapp", "../vite-project", "pnpm")
.WithExternalHttpEndpoints();

builder.Build().Run();
