using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementRedisCacheTimeoutsBlock : TerraformBlock
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
        SetOutput("api_management_id");
        SetOutput("cache_location");
        SetOutput("connection_string");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("redis_cache_id");
    }

    /// <summary>
    /// The api_management_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementId is required")]
    public required TerraformProperty<string> ApiManagementId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_management_id");
        set => SetProperty("api_management_id", value);
    }

    /// <summary>
    /// The cache_location attribute.
    /// </summary>
    public TerraformProperty<string> CacheLocation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cache_location");
        set => SetProperty("cache_location", value);
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionString is required")]
    public required TerraformProperty<string> ConnectionString
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_string");
        set => SetProperty("connection_string", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The redis_cache_id attribute.
    /// </summary>
    public TerraformProperty<string> RedisCacheId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("redis_cache_id");
        set => SetProperty("redis_cache_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApiManagementRedisCacheTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
