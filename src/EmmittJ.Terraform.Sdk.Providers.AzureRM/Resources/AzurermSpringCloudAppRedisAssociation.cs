using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_spring_cloud_app_redis_association resource.
/// </summary>
public class AzurermSpringCloudAppRedisAssociation : TerraformResource
{
    public AzurermSpringCloudAppRedisAssociation(string name) : base("azurerm_spring_cloud_app_redis_association", name)
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
    /// The redis_access_key attribute.
    /// </summary>
    public TerraformProperty<string>? RedisAccessKey
    {
        get => GetProperty<TerraformProperty<string>>("redis_access_key");
        set => this.WithProperty("redis_access_key", value);
    }

    /// <summary>
    /// The redis_cache_id attribute.
    /// </summary>
    public TerraformProperty<string>? RedisCacheId
    {
        get => GetProperty<TerraformProperty<string>>("redis_cache_id");
        set => this.WithProperty("redis_cache_id", value);
    }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    public TerraformProperty<string>? SpringCloudAppId
    {
        get => GetProperty<TerraformProperty<string>>("spring_cloud_app_id");
        set => this.WithProperty("spring_cloud_app_id", value);
    }

    /// <summary>
    /// The ssl_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SslEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("ssl_enabled");
        set => this.WithProperty("ssl_enabled", value);
    }

}
