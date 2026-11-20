# EmmittJ.Aspire.Hosting.Terraform

Wire Terraform that already lives on disk into an Aspire AppHost. No HCL is generated and the C# Terraform SDK is not required.

```csharp
var environment = builder.AddParameter("environment");

var network = builder.AddTerraformConfiguration("network", "./infra/network")
    .WithVariable("environment", environment);

var app = builder.AddTerraformConfiguration("app", "./infra/app")
    .WithVariable("network_id", network.GetOutput("network_id"));

builder.AddProject<Projects.Api>("api")
    .WithEnvironment("APP_ID", app.GetOutput("app_id"));
```

- `AddTerraformConfiguration(name, path)` points at a root configuration directory of `.tf` files (relative to the AppHost). Terraform's own backend/state configuration is used as-is.
- `WithVariable(name, value)` sets the Terraform `variable` called `name` from a string, parameter, `ReferenceExpression`, or another module's output. Values are passed via `TF_VAR_*` environment variables and are never written to disk.
- `GetOutput(name)` returns an Aspire value for the Terraform `output` called `name` (non-string outputs are raw JSON).

Modules run during `aspire deploy` (`terraform init` → `apply` → `output -json`), ordered by the variables/outputs that link them. They are never applied in run mode, so there `GetOutput(name)` becomes a parameter named `{module}-{output}` that you are prompted for. Alternatively call `RunAsExisting()` on the module (before `GetOutput`) to read outputs from state that was already applied (`terraform init` + `terraform output -json`) instead. Both only affect run mode; deploy always uses real outputs. Note that an output consumed only as another module's variable is also prompted for in run mode, unless that module uses `RunAsExisting()`.

## Three shapes, two entry points

| Shape | Standalone | Publish an existing Aspire resource |
| --- | --- | --- |
| Configuration (root dir with its own backend/state) | `AddTerraformConfiguration(name, dir)` | `resource.PublishAsTerraformConfiguration(dir, configure)` |
| Module (local path, registry or Git source) | `AddTerraformModule(name, source)` | `resource.PublishAsTerraformModule(source, configure)` |
| Template (HCL file or string, like a Bicep template) | `AddTerraformTemplate(name, file)` / `AddTerraformTemplateString(name, hcl)` | `PublishAsTerraformTemplate(file, configure)` / `PublishAsTerraformTemplateString(hcl, configure)` |

Modules and templates are called from a generated root, which needs `AddTerraformEnvironment()`. `PublishAs*` does nothing in run mode, so `RunAsEmulator` and friends are unchanged. When publishing, call `MapEndpoint(name, property, output)` in `configure` to point the resource's endpoints at Terraform outputs.

TypeScript AppHosts get the same API: `addTerraformModule`, `withVariable`, `getOutput`, `runAsExisting`.

See `playground/modules` for a runnable sample.
