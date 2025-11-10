using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudAppRedisAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("id");
        SetOutput("name");
        SetOutput("redis_access_key");
        SetOutput("redis_cache_id");
        SetOutput("spring_cloud_app_id");
        SetOutput("ssl_enabled");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The redis_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedisAccessKey is required")]
    public required TerraformProperty<string> RedisAccessKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("redis_access_key");
        set => SetProperty("redis_access_key", value);
    }

    /// <summary>
    /// The redis_cache_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedisCacheId is required")]
    public required TerraformProperty<string> RedisCacheId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("redis_cache_id");
        set => SetProperty("redis_cache_id", value);
    }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAppId is required")]
    public required TerraformProperty<string> SpringCloudAppId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("spring_cloud_app_id");
        set => SetProperty("spring_cloud_app_id", value);
    }

    /// <summary>
    /// The ssl_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SslEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ssl_enabled");
        set => SetProperty("ssl_enabled", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudAppRedisAssociationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
