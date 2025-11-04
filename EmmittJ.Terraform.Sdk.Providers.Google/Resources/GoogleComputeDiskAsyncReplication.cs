using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_disk_async_replication resource.
/// </summary>
public class GoogleComputeDiskAsyncReplication : TerraformResource
{
    public GoogleComputeDiskAsyncReplication(string name) : base("google_compute_disk_async_replication", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Primary disk for asynchronous replication.
    /// </summary>
    public string? PrimaryDisk
    {
        get => GetProperty<TerraformLiteralProperty<string>>("primary_disk")?.Value;
        set => this.WithProperty("primary_disk", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
