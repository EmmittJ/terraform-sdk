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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Primary disk for asynchronous replication.
    /// </summary>
    public TerraformProperty<string>? PrimaryDisk
    {
        get => GetProperty<TerraformProperty<string>>("primary_disk");
        set => this.WithProperty("primary_disk", value);
    }

}
