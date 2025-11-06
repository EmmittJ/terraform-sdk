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
    public string? AccessPolicyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_policy_name")?.Value;
        set => this.WithProperty("access_policy_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cache_name attribute.
    /// </summary>
    public string? CacheName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cache_name")?.Value;
        set => this.WithProperty("cache_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The namespace_path attribute.
    /// </summary>
    public string? NamespacePath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("namespace_path")?.Value;
        set => this.WithProperty("namespace_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_container_id attribute.
    /// </summary>
    public string? StorageContainerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_container_id")?.Value;
        set => this.WithProperty("storage_container_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The usage_model attribute.
    /// </summary>
    public string? UsageModel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("usage_model")?.Value;
        set => this.WithProperty("usage_model", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The verification_timer_in_seconds attribute.
    /// </summary>
    public double? VerificationTimerInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("verification_timer_in_seconds")?.Value;
        set => this.WithProperty("verification_timer_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The write_back_timer_in_seconds attribute.
    /// </summary>
    public double? WriteBackTimerInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("write_back_timer_in_seconds")?.Value;
        set => this.WithProperty("write_back_timer_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

}
