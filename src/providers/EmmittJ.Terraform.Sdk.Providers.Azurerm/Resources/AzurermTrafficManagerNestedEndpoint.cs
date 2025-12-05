using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for custom_header in AzurermTrafficManagerNestedEndpoint.
/// Nesting mode: list
/// </summary>
public class AzurermTrafficManagerNestedEndpointCustomHeaderBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for subnet in AzurermTrafficManagerNestedEndpoint.
/// Nesting mode: list
/// </summary>
public class AzurermTrafficManagerNestedEndpointSubnetBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("first");
        set => SetArgument("first", value);
    }

    /// <summary>
    /// The last attribute.
    /// </summary>
    public TerraformValue<string>? Last
    {
        get => GetArgument<TerraformValue<string>>("last");
        set => SetArgument("last", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformValue<double>? Scope
    {
        get => GetArgument<TerraformValue<double>>("scope");
        set => SetArgument("scope", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermTrafficManagerNestedEndpoint.
/// Nesting mode: single
/// </summary>
public class AzurermTrafficManagerNestedEndpointTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_traffic_manager_nested_endpoint Terraform resource.
/// Manages a azurerm_traffic_manager_nested_endpoint resource.
/// </summary>
public partial class AzurermTrafficManagerNestedEndpoint(string name) : TerraformResource("azurerm_traffic_manager_nested_endpoint", name)
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The endpoint_location attribute.
    /// </summary>
    public TerraformValue<string> EndpointLocation
    {
        get => GetArgument<TerraformValue<string>>("endpoint_location") ?? CreateReference("endpoint_location");
        set => SetArgument("endpoint_location", value);
    }

    /// <summary>
    /// The geo_mappings attribute.
    /// </summary>
    public TerraformList<string>? GeoMappings
    {
        get => GetArgument<TerraformList<string>>("geo_mappings");
        set => SetArgument("geo_mappings", value);
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
    /// The minimum_child_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumChildEndpoints is required")]
    public required TerraformValue<double> MinimumChildEndpoints
    {
        get => GetRequiredArgument<TerraformValue<double>>("minimum_child_endpoints");
        set => SetArgument("minimum_child_endpoints", value);
    }

    /// <summary>
    /// The minimum_required_child_endpoints_ipv4 attribute.
    /// </summary>
    public TerraformValue<double>? MinimumRequiredChildEndpointsIpv4
    {
        get => GetArgument<TerraformValue<double>>("minimum_required_child_endpoints_ipv4");
        set => SetArgument("minimum_required_child_endpoints_ipv4", value);
    }

    /// <summary>
    /// The minimum_required_child_endpoints_ipv6 attribute.
    /// </summary>
    public TerraformValue<double>? MinimumRequiredChildEndpointsIpv6
    {
        get => GetArgument<TerraformValue<double>>("minimum_required_child_endpoints_ipv6");
        set => SetArgument("minimum_required_child_endpoints_ipv6", value);
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
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double> Priority
    {
        get => GetArgument<TerraformValue<double>>("priority") ?? CreateReference("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileId is required")]
    public required TerraformValue<string> ProfileId
    {
        get => GetRequiredArgument<TerraformValue<string>>("profile_id");
        set => SetArgument("profile_id", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    public required TerraformValue<string> TargetResourceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("target_resource_id");
        set => SetArgument("target_resource_id", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformValue<double>? Weight
    {
        get => GetArgument<TerraformValue<double>>("weight");
        set => SetArgument("weight", value);
    }

    /// <summary>
    /// CustomHeader block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermTrafficManagerNestedEndpointCustomHeaderBlock>? CustomHeader
    {
        get => GetArgument<TerraformList<AzurermTrafficManagerNestedEndpointCustomHeaderBlock>>("custom_header");
        set => SetArgument("custom_header", value);
    }

    /// <summary>
    /// Subnet block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermTrafficManagerNestedEndpointSubnetBlock>? Subnet
    {
        get => GetArgument<TerraformList<AzurermTrafficManagerNestedEndpointSubnetBlock>>("subnet");
        set => SetArgument("subnet", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermTrafficManagerNestedEndpointTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermTrafficManagerNestedEndpointTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
