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
    public TerraformProperty<string>? ApiManagementId
    {
        get => GetProperty<TerraformProperty<string>>("api_management_id");
        set => this.WithProperty("api_management_id", value);
    }

    /// <summary>
    /// The cache_location attribute.
    /// </summary>
    public TerraformProperty<string>? CacheLocation
    {
        get => GetProperty<TerraformProperty<string>>("cache_location");
        set => this.WithProperty("cache_location", value);
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionString
    {
        get => GetProperty<TerraformProperty<string>>("connection_string");
        set => this.WithProperty("connection_string", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The redis_cache_id attribute.
    /// </summary>
    public TerraformProperty<string>? RedisCacheId
    {
        get => GetProperty<TerraformProperty<string>>("redis_cache_id");
        set => this.WithProperty("redis_cache_id", value);
    }

}
