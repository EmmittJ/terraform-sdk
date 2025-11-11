using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for custom_header in .
/// Nesting mode: list
/// </summary>
public partial class AzurermTrafficManagerNestedEndpointCustomHeaderBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for subnet in .
/// Nesting mode: list
/// </summary>
public partial class AzurermTrafficManagerNestedEndpointSubnetBlock : TerraformBlockBase
{
    /// <summary>
    /// The first attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "First is required")]
    [TerraformProperty("first")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> First { get; set; }

    /// <summary>
    /// The last attribute.
    /// </summary>
    [TerraformProperty("last")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Last { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformProperty("scope")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Scope { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermTrafficManagerNestedEndpointTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_traffic_manager_nested_endpoint resource.
/// </summary>
public partial class AzurermTrafficManagerNestedEndpoint : TerraformResource
{
    public AzurermTrafficManagerNestedEndpoint(string name) : base("azurerm_traffic_manager_nested_endpoint", name)
    {
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The endpoint_location attribute.
    /// </summary>
    [TerraformProperty("endpoint_location")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EndpointLocation { get; set; }

    /// <summary>
    /// The geo_mappings attribute.
    /// </summary>
    [TerraformProperty("geo_mappings")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? GeoMappings { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The minimum_child_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumChildEndpoints is required")]
    [TerraformProperty("minimum_child_endpoints")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> MinimumChildEndpoints { get; set; }

    /// <summary>
    /// The minimum_required_child_endpoints_ipv4 attribute.
    /// </summary>
    [TerraformProperty("minimum_required_child_endpoints_ipv4")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MinimumRequiredChildEndpointsIpv4 { get; set; }

    /// <summary>
    /// The minimum_required_child_endpoints_ipv6 attribute.
    /// </summary>
    [TerraformProperty("minimum_required_child_endpoints_ipv6")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MinimumRequiredChildEndpointsIpv6 { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformProperty("priority")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> Priority { get; set; }

    /// <summary>
    /// The profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileId is required")]
    [TerraformProperty("profile_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ProfileId { get; set; }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    [TerraformProperty("target_resource_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TargetResourceId { get; set; }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [TerraformProperty("weight")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? Weight { get; set; }

    /// <summary>
    /// Block for custom_header.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("custom_header")]
    public TerraformList<TerraformBlock<AzurermTrafficManagerNestedEndpointCustomHeaderBlock>>? CustomHeader { get; set; }

    /// <summary>
    /// Block for subnet.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("subnet")]
    public TerraformList<TerraformBlock<AzurermTrafficManagerNestedEndpointSubnetBlock>>? Subnet { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermTrafficManagerNestedEndpointTimeoutsBlock>? Timeouts { get; set; }

}
