using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for custom_header in .
/// Nesting mode: list
/// </summary>
public class AzurermTrafficManagerAzureEndpointCustomHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_header";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for subnet in .
/// Nesting mode: list
/// </summary>
public class AzurermTrafficManagerAzureEndpointSubnetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subnet";

    /// <summary>
    /// The first attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "First is required")]
    public required TerraformValue<string> First
    {
        get => new TerraformReference<string>(this, "first");
        set => SetArgument("first", value);
    }

    /// <summary>
    /// The last attribute.
    /// </summary>
    public TerraformValue<string>? Last
    {
        get => new TerraformReference<string>(this, "last");
        set => SetArgument("last", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformValue<double>? Scope
    {
        get => new TerraformReference<double>(this, "scope");
        set => SetArgument("scope", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermTrafficManagerAzureEndpointTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_traffic_manager_azure_endpoint Terraform resource.
/// Manages a azurerm_traffic_manager_azure_endpoint resource.
/// </summary>
public partial class AzurermTrafficManagerAzureEndpoint(string name) : TerraformResource("azurerm_traffic_manager_azure_endpoint", name)
{
    /// <summary>
    /// The always_serve_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AlwaysServeEnabled
    {
        get => new TerraformReference<bool>(this, "always_serve_enabled");
        set => SetArgument("always_serve_enabled", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The geo_mappings attribute.
    /// </summary>
    public TerraformList<string>? GeoMappings
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "geo_mappings").ResolveNodes(ctx));
        set => SetArgument("geo_mappings", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double> Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileId is required")]
    public required TerraformValue<string> ProfileId
    {
        get => new TerraformReference<string>(this, "profile_id");
        set => SetArgument("profile_id", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    public required TerraformValue<string> TargetResourceId
    {
        get => new TerraformReference<string>(this, "target_resource_id");
        set => SetArgument("target_resource_id", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformValue<double>? Weight
    {
        get => new TerraformReference<double>(this, "weight");
        set => SetArgument("weight", value);
    }

    /// <summary>
    /// CustomHeader block (nesting mode: list).
    /// </summary>
    public AzurermTrafficManagerAzureEndpointCustomHeaderBlock? CustomHeader
    {
        get => GetArgument<AzurermTrafficManagerAzureEndpointCustomHeaderBlock>("custom_header");
        set => SetArgument("custom_header", value);
    }

    /// <summary>
    /// Subnet block (nesting mode: list).
    /// </summary>
    public AzurermTrafficManagerAzureEndpointSubnetBlock? Subnet
    {
        get => GetArgument<AzurermTrafficManagerAzureEndpointSubnetBlock>("subnet");
        set => SetArgument("subnet", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermTrafficManagerAzureEndpointTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermTrafficManagerAzureEndpointTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
