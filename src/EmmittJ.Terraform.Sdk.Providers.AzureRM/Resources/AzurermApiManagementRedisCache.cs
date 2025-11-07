using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_api_management_redis_cache resource.
/// </summary>
public class AzurermApiManagementRedisCache : TerraformResource
{
    public AzurermApiManagementRedisCache(string name) : base("azurerm_api_management_redis_cache", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_management_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApiManagementId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_id");
        set => this.WithProperty("api_management_id", value);
    }

    /// <summary>
    /// The cache_location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CacheLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cache_location");
        set => this.WithProperty("cache_location", value);
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ConnectionString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_string");
        set => this.WithProperty("connection_string", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The redis_cache_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RedisCacheId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("redis_cache_id");
        set => this.WithProperty("redis_cache_id", value);
    }

}
