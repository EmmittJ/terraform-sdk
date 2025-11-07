using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_hpc_cache_blob_nfs_target resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermHpcCacheBlobNfsTarget : TerraformResource
{
    public AzurermHpcCacheBlobNfsTarget(string name) : base("azurerm_hpc_cache_blob_nfs_target", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The access_policy_name attribute.
    /// </summary>
    public TerraformProperty<string>? AccessPolicyName
    {
        get => GetProperty<TerraformProperty<string>>("access_policy_name");
        set => this.WithProperty("access_policy_name", value);
    }

    /// <summary>
    /// The cache_name attribute.
    /// </summary>
    public TerraformProperty<string>? CacheName
    {
        get => GetProperty<TerraformProperty<string>>("cache_name");
        set => this.WithProperty("cache_name", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The namespace_path attribute.
    /// </summary>
    public TerraformProperty<string>? NamespacePath
    {
        get => GetProperty<TerraformProperty<string>>("namespace_path");
        set => this.WithProperty("namespace_path", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The storage_container_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageContainerId
    {
        get => GetProperty<TerraformProperty<string>>("storage_container_id");
        set => this.WithProperty("storage_container_id", value);
    }

    /// <summary>
    /// The usage_model attribute.
    /// </summary>
    public TerraformProperty<string>? UsageModel
    {
        get => GetProperty<TerraformProperty<string>>("usage_model");
        set => this.WithProperty("usage_model", value);
    }

    /// <summary>
    /// The verification_timer_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? VerificationTimerInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("verification_timer_in_seconds");
        set => this.WithProperty("verification_timer_in_seconds", value);
    }

    /// <summary>
    /// The write_back_timer_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? WriteBackTimerInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("write_back_timer_in_seconds");
        set => this.WithProperty("write_back_timer_in_seconds", value);
    }

}
