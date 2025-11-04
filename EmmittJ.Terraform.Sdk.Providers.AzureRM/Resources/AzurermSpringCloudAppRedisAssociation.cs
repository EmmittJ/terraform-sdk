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
    /// The redis_access_key attribute.
    /// </summary>
    public string? RedisAccessKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("redis_access_key")?.Value;
        set => this.WithProperty("redis_access_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The redis_cache_id attribute.
    /// </summary>
    public string? RedisCacheId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("redis_cache_id")?.Value;
        set => this.WithProperty("redis_cache_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    public string? SpringCloudAppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spring_cloud_app_id")?.Value;
        set => this.WithProperty("spring_cloud_app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ssl_enabled attribute.
    /// </summary>
    public bool? SslEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ssl_enabled")?.Value;
        set => this.WithProperty("ssl_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}
