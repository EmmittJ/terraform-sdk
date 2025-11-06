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
    /// The permissions attribute.
    /// </summary>
    public string? Permissions
    {
        get => GetProperty<TerraformLiteralProperty<string>>("permissions")?.Value;
        set => this.WithProperty("permissions", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The redis_cache_id attribute.
    /// </summary>
    public string? RedisCacheId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("redis_cache_id")?.Value;
        set => this.WithProperty("redis_cache_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
