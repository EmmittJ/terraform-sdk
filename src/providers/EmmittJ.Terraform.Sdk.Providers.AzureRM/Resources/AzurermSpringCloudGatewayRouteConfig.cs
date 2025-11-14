using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for open_api in .
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
    [TerraformArgument("uri")]
    public TerraformValue<string>? Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for route in .
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
    [TerraformArgument("classification_tags")]
    public TerraformSet<string>? ClassificationTags
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "classification_tags").ResolveNodes(ctx));
        set => SetArgument("classification_tags", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The filters attribute.
    /// </summary>
    [TerraformArgument("filters")]
    public TerraformSet<string>? Filters
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "filters").ResolveNodes(ctx));
        set => SetArgument("filters", value);
    }

    /// <summary>
    /// The order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Order is required")]
    [TerraformArgument("order")]
    public required TerraformValue<double> Order
    {
        get => new TerraformReference<double>(this, "order");
        set => SetArgument("order", value);
    }

    /// <summary>
    /// The predicates attribute.
    /// </summary>
    [TerraformArgument("predicates")]
    public TerraformSet<string>? Predicates
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "predicates").ResolveNodes(ctx));
        set => SetArgument("predicates", value);
    }

    /// <summary>
    /// The sso_validation_enabled attribute.
    /// </summary>
    [TerraformArgument("sso_validation_enabled")]
    public TerraformValue<bool>? SsoValidationEnabled
    {
        get => new TerraformReference<bool>(this, "sso_validation_enabled");
        set => SetArgument("sso_validation_enabled", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [TerraformArgument("title")]
    public TerraformValue<string>? Title
    {
        get => new TerraformReference<string>(this, "title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// The token_relay attribute.
    /// </summary>
    [TerraformArgument("token_relay")]
    public TerraformValue<bool>? TokenRelay
    {
        get => new TerraformReference<bool>(this, "token_relay");
        set => SetArgument("token_relay", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformArgument("uri")]
    public TerraformValue<string>? Uri
    {
        get => new TerraformReference<string>(this, "uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
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
    }

    /// <summary>
    /// The filters attribute.
    /// </summary>
    [TerraformArgument("filters")]
    public TerraformSet<string>? Filters
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "filters").ResolveNodes(ctx));
        set => SetArgument("filters", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The predicates attribute.
    /// </summary>
    [TerraformArgument("predicates")]
    public TerraformSet<string>? Predicates
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "predicates").ResolveNodes(ctx));
        set => SetArgument("predicates", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    [TerraformArgument("protocol")]
    public required TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The spring_cloud_app_id attribute.
    /// </summary>
    [TerraformArgument("spring_cloud_app_id")]
    public TerraformValue<string>? SpringCloudAppId
    {
        get => new TerraformReference<string>(this, "spring_cloud_app_id");
        set => SetArgument("spring_cloud_app_id", value);
    }

    /// <summary>
    /// The spring_cloud_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudGatewayId is required")]
    [TerraformArgument("spring_cloud_gateway_id")]
    public required TerraformValue<string> SpringCloudGatewayId
    {
        get => new TerraformReference<string>(this, "spring_cloud_gateway_id");
        set => SetArgument("spring_cloud_gateway_id", value);
    }

    /// <summary>
    /// The sso_validation_enabled attribute.
    /// </summary>
    [TerraformArgument("sso_validation_enabled")]
    public TerraformValue<bool>? SsoValidationEnabled
    {
        get => new TerraformReference<bool>(this, "sso_validation_enabled");
        set => SetArgument("sso_validation_enabled", value);
    }

    /// <summary>
    /// Block for open_api.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OpenApi block(s) allowed")]
    [TerraformArgument("open_api")]
    public TerraformList<AzurermSpringCloudGatewayRouteConfigOpenApiBlock> OpenApi { get; set; } = new();

    /// <summary>
    /// Block for route.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("route")]
    public TerraformSet<AzurermSpringCloudGatewayRouteConfigRouteBlock> Route { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSpringCloudGatewayRouteConfigTimeoutsBlock Timeouts { get; set; } = new();

}
