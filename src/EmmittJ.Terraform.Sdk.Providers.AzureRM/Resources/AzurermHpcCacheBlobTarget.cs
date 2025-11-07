using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_hpc_cache_blob_target resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermHpcCacheBlobTarget : TerraformResource
{
    public AzurermHpcCacheBlobTarget(string name) : base("azurerm_hpc_cache_blob_target", name)
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

}
