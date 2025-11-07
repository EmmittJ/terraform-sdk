using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_redis_cache_access_policy resource.
/// </summary>
public class AzurermRedisCacheAccessPolicy : TerraformResource
{
    public AzurermRedisCacheAccessPolicy(string name) : base("azurerm_redis_cache_access_policy", name)
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public TerraformProperty<string>? Permissions
    {
        get => GetProperty<TerraformProperty<string>>("permissions");
        set => this.WithProperty("permissions", value);
    }

    /// <summary>
    /// The redis_cache_id attribute.
    /// </summary>
    public TerraformProperty<string>? RedisCacheId
    {
        get => GetProperty<TerraformProperty<string>>("redis_cache_id");
        set => this.WithProperty("redis_cache_id", value);
    }

}
