using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for custom_header in .
/// Nesting mode: list
/// </summary>
public class AzurermTrafficManagerNestedEndpointCustomHeaderBlock : ITerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Value { get; set; }

}

/// <summary>
/// Block type for subnet in .
/// Nesting mode: list
/// </summary>
public class AzurermTrafficManagerNestedEndpointSubnetBlock : ITerraformBlock
{
    /// <summary>
    /// The first attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "First is required")]
    [TerraformPropertyName("first")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> First { get; set; }

    /// <summary>
    /// The last attribute.
    /// </summary>
    [TerraformPropertyName("last")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Last { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformPropertyName("scope")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Scope { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermTrafficManagerNestedEndpointTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_traffic_manager_nested_endpoint resource.
/// </summary>
public class AzurermTrafficManagerNestedEndpoint : TerraformResource
{
    public AzurermTrafficManagerNestedEndpoint(string name) : base("azurerm_traffic_manager_nested_endpoint", name)
    {
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The endpoint_location attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_location")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EndpointLocation { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint_location");

    /// <summary>
    /// The geo_mappings attribute.
    /// </summary>
    [TerraformPropertyName("geo_mappings")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? GeoMappings { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The minimum_child_endpoints attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumChildEndpoints is required")]
    [TerraformPropertyName("minimum_child_endpoints")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MinimumChildEndpoints { get; set; }

    /// <summary>
    /// The minimum_required_child_endpoints_ipv4 attribute.
    /// </summary>
    [TerraformPropertyName("minimum_required_child_endpoints_ipv4")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinimumRequiredChildEndpointsIpv4 { get; set; }

    /// <summary>
    /// The minimum_required_child_endpoints_ipv6 attribute.
    /// </summary>
    [TerraformPropertyName("minimum_required_child_endpoints_ipv6")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinimumRequiredChildEndpointsIpv6 { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Priority { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "priority");

    /// <summary>
    /// The profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileId is required")]
    [TerraformPropertyName("profile_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ProfileId { get; set; }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    [TerraformPropertyName("target_resource_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TargetResourceId { get; set; }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [TerraformPropertyName("weight")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Weight { get; set; }

    /// <summary>
    /// Block for custom_header.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("custom_header")]
    public TerraformList<TerraformBlock<AzurermTrafficManagerNestedEndpointCustomHeaderBlock>>? CustomHeader { get; set; } = new();

    /// <summary>
    /// Block for subnet.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("subnet")]
    public TerraformList<TerraformBlock<AzurermTrafficManagerNestedEndpointSubnetBlock>>? Subnet { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermTrafficManagerNestedEndpointTimeoutsBlock>? Timeouts { get; set; } = new();

}
