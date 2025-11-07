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
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Permissions
    {
        get => GetProperty<TerraformLiteralProperty<string>>("permissions");
        set => this.WithProperty("permissions", value);
    }

    /// <summary>
    /// The redis_cache_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RedisCacheId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("redis_cache_id");
        set => this.WithProperty("redis_cache_id", value);
    }

}
