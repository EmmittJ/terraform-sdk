using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for open_api in AzurermSpringCloudGatewayRouteConfig.
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudGatewayRouteConfigOpenApiBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "open_api";

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for route in AzurermSpringCloudGatewayRouteConfig.
/// Nesting mode: set
/// </summary>
public class AzurermSpringCloudGatewayRouteConfigRouteBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "route";

    /// <summary>
    /// The classification_tags attribute.
    /// </summary>
    public TerraformSet<string>? ClassificationTags
    {
        get => GetArgument<TerraformSet<string>>("classification_tags");
        set => SetArgument("classification_tags", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The filters attribute.
    /// </summary>
    public TerraformSet<string>? Filters
    {
        get => GetArgument<TerraformSet<string>>("filters");
        set => SetArgument("filters", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    public required TerraformValue<double> Order
    {
        get => GetRequiredArgument<TerraformValue<double>>("order");
        set => SetArgument("order", value);
    }

    /// <summary>
    /// The predicates attribute.
    /// </summary>
    public TerraformSet<string>? Predicates
    {
        get => GetArgument<TerraformSet<string>>("predicates");
        set => SetArgument("predicates", value);
    }

    /// <summary>
    /// The sso_validation_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SsoValidationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("sso_validation_enabled");
        set => SetArgument("sso_validation_enabled", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => GetArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// The token_relay attribute.
    /// </summary>
    public TerraformValue<bool>? TokenRelay
    {
        get => GetArgument<TerraformValue<bool>>("token_relay");
        set => SetArgument("token_relay", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSpringCloudGatewayRouteConfig.
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudGatewayRouteConfigTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_spring_cloud_gateway_route_config Terraform resource.
/// Manages a azurerm_spring_cloud_gateway_route_config resource.
/// </summary>
public partial class AzurermSpringCloudGatewayRouteConfig(string name) : TerraformResource("azurerm_spring_cloud_gateway_route_config", name)
{
    /// <summary>
    /// The filters attribute.
    /// </summary>
    public TerraformSet<string>? Filters
    {
        get => GetArgument<TerraformSet<string>>("filters");
        set => SetArgument("filters", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The predicates attribute.
    /// </summary>
    public TerraformSet<string>? Predicates
    {
        get => GetArgument<TerraformSet<string>>("predicates");
        set => SetArgument("predicates", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    public TerraformValue<string>? SpringCloudAppId
    {
        get => GetArgument<TerraformValue<string>>("spring_cloud_app_id");
        set => SetArgument("spring_cloud_app_id", value);
    }

    /// <summary>
    /// The spring_cloud_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudGatewayId is required")]
    public required TerraformValue<string> SpringCloudGatewayId
    {
        get => GetRequiredArgument<TerraformValue<string>>("spring_cloud_gateway_id");
        set => SetArgument("spring_cloud_gateway_id", value);
    }

    /// <summary>
    /// The sso_validation_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SsoValidationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("sso_validation_enabled");
        set => SetArgument("sso_validation_enabled", value);
    }

    /// <summary>
    /// OpenApi block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenApi block(s) allowed")]
    public TerraformList<AzurermSpringCloudGatewayRouteConfigOpenApiBlock>? OpenApi
    {
        get => GetArgument<TerraformList<AzurermSpringCloudGatewayRouteConfigOpenApiBlock>>("open_api");
        set => SetArgument("open_api", value);
    }

    /// <summary>
    /// Route block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermSpringCloudGatewayRouteConfigRouteBlock>? Route
    {
        get => GetArgument<TerraformSet<AzurermSpringCloudGatewayRouteConfigRouteBlock>>("route");
        set => SetArgument("route", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSpringCloudGatewayRouteConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSpringCloudGatewayRouteConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
