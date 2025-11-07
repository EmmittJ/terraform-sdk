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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Primary disk for asynchronous replication.
    /// </summary>
    public TerraformLiteralProperty<string>? PrimaryDisk
    {
        get => GetProperty<TerraformLiteralProperty<string>>("primary_disk");
        set => this.WithProperty("primary_disk", value);
    }

}
