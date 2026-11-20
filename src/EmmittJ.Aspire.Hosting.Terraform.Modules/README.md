# EmmittJ.Aspire.Hosting.Terraform.Modules

Wire Terraform that already lives on disk into an Aspire AppHost. No HCL is generated and the C# Terraform SDK is not required.

```csharp
var environment = builder.AddParameter("environment");

var network = builder.AddTerraformModule("network", "./infra/network")
    .WithVariable("environment", environment);

var app = builder.AddTerraformModule("app", "./infra/app")
    .WithVariable("network_id", network.GetOutput("network_id"))
    .RunAsExisting(); // run mode only: read outputs from state already applied

builder.AddProject<Projects.Api>("api")
    .WithEnvironment("APP_ID", app.GetOutput("app_id"));
```

- `AddTerraformModule(name, path)` points at a directory of `.tf` files (relative to the AppHost). Terraform's own backend/state configuration is used as-is.
- `WithVariable(name, value)` sets the Terraform `variable` called `name` from a string, parameter, `ReferenceExpression`, or another module's output. Values are passed via `TF_VAR_*` environment variables and are never written to disk.
- `GetOutput(name)` returns an Aspire value for the Terraform `output` called `name` (non-string outputs are raw JSON).

Modules run during `aspire deploy` (`terraform init` → `apply` → `output -json`), ordered by the variables/outputs that link them. They are never applied in run mode. Call `RunAsExisting()` to read outputs from state that was already applied (`terraform init` + `terraform output -json`); it is ignored when publishing or deploying. Without it, resolving an output in run mode throws a clear error.

TypeScript AppHosts get the same API: `addTerraformModule`, `withVariable`, `getOutput`, `runAsExisting`.

See `playground/modules` for a runnable sample.
