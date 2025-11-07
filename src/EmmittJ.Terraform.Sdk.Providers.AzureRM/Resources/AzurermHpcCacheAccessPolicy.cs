using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_hpc_cache_access_policy resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermHpcCacheAccessPolicy : TerraformResource
{
    public AzurermHpcCacheAccessPolicy(string name) : base("azurerm_hpc_cache_access_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The hpc_cache_id attribute.
    /// </summary>
    public TerraformProperty<string>? HpcCacheId
    {
        get => GetProperty<TerraformProperty<string>>("hpc_cache_id");
        set => this.WithProperty("hpc_cache_id", value);
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

}
