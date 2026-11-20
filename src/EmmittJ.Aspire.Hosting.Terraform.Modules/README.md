# EmmittJ.Aspire.Hosting.Terraform.Modules

Wire Terraform that already lives on disk into an Aspire AppHost. No HCL is generated and the C# Terraform SDK is not required.

```csharp
var environment = builder.AddParameter("environment");

var network = builder.AddTerraformModule("network", "./infra/network")
    .WithVariable("environment", environment);

var app = builder.AddTerraformModule("app", "./infra/app")
    .WithVariable("network_id", network.GetOutput("network_id"));

builder.AddProject<Projects.Api>("api")
    .WithEnvironment("APP_ID", app.GetOutput("app_id"));
```

- `AddTerraformModule(name, path)` points at a directory of `.tf` files (relative to the AppHost). Terraform's own backend/state configuration is used as-is.
- `WithVariable(name, value)` sets the Terraform `variable` called `name` from a string, parameter, `ReferenceExpression`, or another module's output. Values are passed via `TF_VAR_*` environment variables and are never written to disk.
- `GetOutput(name)` returns an Aspire value for the Terraform `output` called `name` (non-string outputs are raw JSON).

Modules run during `aspire deploy` (`terraform init` → `apply` → `output -json`), ordered by the variables/outputs that link them. They are never applied in run mode, so there `GetOutput(name)` becomes a parameter named `{module}-{output}` that you are prompted for. Alternatively call `RunAsExisting()` on the module (before `GetOutput`) to read outputs from state that was already applied (`terraform init` + `terraform output -json`) instead. Both only affect run mode; deploy always uses real outputs. Note that an output consumed only as another module's variable is also prompted for in run mode, unless that module uses `RunAsExisting()`.

TypeScript AppHosts get the same API: `addTerraformModule`, `withVariable`, `getOutput`, `runAsExisting`.

See `playground/modules` for a runnable sample.
