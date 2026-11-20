# existing-terraform

Runs Terraform you already wrote from an Aspire AppHost with `EmmittJ.Aspire.Hosting.Terraform`. Every `.tf` file only uses `terraform_data`, so no cloud account is needed. Requires the `terraform` CLI.

| Shape | API used | Source |
| --- | --- | --- |
| Configuration (root dir, own state) | `AddTerraformConfiguration` | `infra/network` |
| Module | `AddTerraformModule` | `infra/queue` |
| Template (single HCL file) | `AddTerraformTemplate` | `infra/cache/cache.tf` |
| Publish an Aspire resource | `PublishAsTerraformModule` + `MapEndpoint` | `infra/api` |

The `api` container runs locally as a normal container. When publishing, it is deployed by the `infra/api` module instead, and `worker`'s `API_URL` resolves to that module's `url` output.

## Try it

```bash
# Run mode: nothing is applied; GetOutput values are prompted as parameters
dotnet run

# Apply everything (init -> apply -> output)
Parameters__environment=dev dotnet run -- --operation publish --output-path ./out
```

`aspire deploy` runs the same steps.

In run mode only outputs used directly by a resource become parameters (`network-network-id`, `cache-cache-id`). Outputs used only inside a `PublishAs*` callback, like `queue_id`, are not requested until you publish.
