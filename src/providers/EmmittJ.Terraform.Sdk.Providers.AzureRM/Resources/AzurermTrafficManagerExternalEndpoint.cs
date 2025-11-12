using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for custom_header in .
/// Nesting mode: list
/// </summary>
public partial class AzurermTrafficManagerExternalEndpointCustomHeaderBlock() : TerraformBlock("custom_header")
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for subnet in .
/// Nesting mode: list
/// </summary>
public partial class AzurermTrafficManagerExternalEndpointSubnetBlock() : TerraformBlock("subnet")
{
    /// <summary>
    /// The first attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "First is required")]
    [TerraformProperty("first")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> First { get; set; }

    /// <summary>
    /// The last attribute.
    /// </summary>
    [TerraformProperty("last")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Last { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformProperty("scope")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Scope { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermTrafficManagerExternalEndpointTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_traffic_manager_external_endpoint resource.
/// </summary>
public partial class AzurermTrafficManagerExternalEndpoint : TerraformResource
{
    public AzurermTrafficManagerExternalEndpoint(string name) : base("azurerm_traffic_manager_external_endpoint", name)
    {
    }

    /// <summary>
    /// The always_serve_enabled attribute.
    /// </summary>
    [TerraformProperty("always_serve_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AlwaysServeEnabled { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The endpoint_location attribute.
    /// </summary>
    [TerraformProperty("endpoint_location")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EndpointLocation { get; set; }

    /// <summary>
    /// The geo_mappings attribute.
    /// </summary>
    [TerraformProperty("geo_mappings")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? GeoMappings { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformProperty("priority")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Priority { get; set; }

    /// <summary>
    /// The profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileId is required")]
    [TerraformProperty("profile_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProfileId { get; set; }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [TerraformProperty("target")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Target { get; set; }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [TerraformProperty("weight")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Weight { get; set; }

    /// <summary>
    /// Block for custom_header.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("custom_header")]
    public TerraformList<AzurermTrafficManagerExternalEndpointCustomHeaderBlock> CustomHeader { get; set; } = new();

    /// <summary>
    /// Block for subnet.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("subnet")]
    public TerraformList<AzurermTrafficManagerExternalEndpointSubnetBlock> Subnet { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermTrafficManagerExternalEndpointTimeoutsBlock Timeouts { get; set; } = new();

}
