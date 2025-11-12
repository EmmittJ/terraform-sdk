using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for action in .
/// Nesting mode: set
/// </summary>
public partial class AzurermCustomProviderActionBlock() : TerraformBlock("action")
{
    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [TerraformProperty("endpoint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Endpoint { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for resource_type in .
/// Nesting mode: set
/// </summary>
public partial class AzurermCustomProviderResourceTypeBlock() : TerraformBlock("resource_type")
{
    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [TerraformProperty("endpoint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Endpoint { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The routing_type attribute.
    /// </summary>
    [TerraformProperty("routing_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RoutingType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCustomProviderTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Block type for validation in .
/// Nesting mode: set
/// </summary>
public partial class AzurermCustomProviderValidationBlock() : TerraformBlock("validation")
{
    /// <summary>
    /// The specification attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Specification is required")]
    [TerraformProperty("specification")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Specification { get; set; }

}

/// <summary>
/// Manages a azurerm_custom_provider resource.
/// </summary>
public partial class AzurermCustomProvider : TerraformResource
{
    public AzurermCustomProvider(string name) : base("azurerm_custom_provider", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for action.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("action")]
    public TerraformSet<AzurermCustomProviderActionBlock> Action { get; set; } = new();

    /// <summary>
    /// Block for resource_type.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("resource_type")]
    public TerraformSet<AzurermCustomProviderResourceTypeBlock> ResourceType { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermCustomProviderTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for validation.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("validation")]
    public TerraformSet<AzurermCustomProviderValidationBlock> Validation { get; set; } = new();

}
