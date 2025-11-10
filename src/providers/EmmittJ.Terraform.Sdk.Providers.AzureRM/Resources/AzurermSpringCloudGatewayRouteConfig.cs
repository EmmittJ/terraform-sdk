using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for open_api in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudGatewayRouteConfigOpenApiBlock : TerraformBlock
{
    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformProperty<string>? Uri
    {
        set => SetProperty("uri", value);
    }

}

/// <summary>
/// Block type for route in .
/// Nesting mode: set
/// </summary>
public class AzurermSpringCloudGatewayRouteConfigRouteBlock : TerraformBlock
{
    /// <summary>
    /// The classification_tags attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ClassificationTags
    {
        set => SetProperty("classification_tags", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The filters attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Filters
    {
        set => SetProperty("filters", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    public required TerraformProperty<double> Order
    {
        set => SetProperty("order", value);
    }

    /// <summary>
    /// The predicates attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Predicates
    {
        set => SetProperty("predicates", value);
    }

    /// <summary>
    /// The sso_validation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SsoValidationEnabled
    {
        set => SetProperty("sso_validation_enabled", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformProperty<string>? Title
    {
        set => SetProperty("title", value);
    }

    /// <summary>
    /// The token_relay attribute.
    /// </summary>
    public TerraformProperty<bool>? TokenRelay
    {
        set => SetProperty("token_relay", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformProperty<string>? Uri
    {
        set => SetProperty("uri", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudGatewayRouteConfigTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_spring_cloud_gateway_route_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSpringCloudGatewayRouteConfig : TerraformResource
{
    public AzurermSpringCloudGatewayRouteConfig(string name) : base("azurerm_spring_cloud_gateway_route_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("filters");
        SetOutput("id");
        SetOutput("name");
        SetOutput("predicates");
        SetOutput("protocol");
        SetOutput("spring_cloud_app_id");
        SetOutput("spring_cloud_gateway_id");
        SetOutput("sso_validation_enabled");
    }

    /// <summary>
    /// The filters attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Filters
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("filters");
        set => SetProperty("filters", value);
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
    /// The predicates attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Predicates
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("predicates");
        set => SetProperty("predicates", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protocol");
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    public TerraformProperty<string> SpringCloudAppId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("spring_cloud_app_id");
        set => SetProperty("spring_cloud_app_id", value);
    }

    /// <summary>
    /// The spring_cloud_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudGatewayId is required")]
    public required TerraformProperty<string> SpringCloudGatewayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("spring_cloud_gateway_id");
        set => SetProperty("spring_cloud_gateway_id", value);
    }

    /// <summary>
    /// The sso_validation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SsoValidationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("sso_validation_enabled");
        set => SetProperty("sso_validation_enabled", value);
    }

    /// <summary>
    /// Block for open_api.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenApi block(s) allowed")]
    public List<AzurermSpringCloudGatewayRouteConfigOpenApiBlock>? OpenApi
    {
        set => SetProperty("open_api", value);
    }

    /// <summary>
    /// Block for route.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermSpringCloudGatewayRouteConfigRouteBlock>? Route
    {
        set => SetProperty("route", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudGatewayRouteConfigTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
