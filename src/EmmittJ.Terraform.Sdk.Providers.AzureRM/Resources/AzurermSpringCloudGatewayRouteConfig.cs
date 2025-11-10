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
        get => GetProperty<TerraformProperty<string>>("uri");
        set => WithProperty("uri", value);
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
        get => GetProperty<HashSet<TerraformProperty<string>>>("classification_tags");
        set => WithProperty("classification_tags", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The filters attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Filters
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("filters");
        set => WithProperty("filters", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    public required TerraformProperty<double> Order
    {
        get => GetProperty<TerraformProperty<double>>("order");
        set => WithProperty("order", value);
    }

    /// <summary>
    /// The predicates attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Predicates
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("predicates");
        set => WithProperty("predicates", value);
    }

    /// <summary>
    /// The sso_validation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SsoValidationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("sso_validation_enabled");
        set => WithProperty("sso_validation_enabled", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformProperty<string>? Title
    {
        get => GetProperty<TerraformProperty<string>>("title");
        set => WithProperty("title", value);
    }

    /// <summary>
    /// The token_relay attribute.
    /// </summary>
    public TerraformProperty<bool>? TokenRelay
    {
        get => GetProperty<TerraformProperty<bool>>("token_relay");
        set => WithProperty("token_relay", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformProperty<string>? Uri
    {
        get => GetProperty<TerraformProperty<string>>("uri");
        set => WithProperty("uri", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
    }

    /// <summary>
    /// The filters attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Filters
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("filters");
        set => this.WithProperty("filters", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The predicates attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Predicates
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("predicates");
        set => this.WithProperty("predicates", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => this.WithProperty("protocol", value);
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
    /// The spring_cloud_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudGatewayId is required")]
    public required TerraformProperty<string> SpringCloudGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("spring_cloud_gateway_id");
        set => this.WithProperty("spring_cloud_gateway_id", value);
    }

    /// <summary>
    /// The sso_validation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SsoValidationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("sso_validation_enabled");
        set => this.WithProperty("sso_validation_enabled", value);
    }

    /// <summary>
    /// Block for open_api.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenApi block(s) allowed")]
    public List<AzurermSpringCloudGatewayRouteConfigOpenApiBlock>? OpenApi
    {
        get => GetProperty<List<AzurermSpringCloudGatewayRouteConfigOpenApiBlock>>("open_api");
        set => this.WithProperty("open_api", value);
    }

    /// <summary>
    /// Block for route.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermSpringCloudGatewayRouteConfigRouteBlock>? Route
    {
        get => GetProperty<HashSet<AzurermSpringCloudGatewayRouteConfigRouteBlock>>("route");
        set => this.WithProperty("route", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudGatewayRouteConfigTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSpringCloudGatewayRouteConfigTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
