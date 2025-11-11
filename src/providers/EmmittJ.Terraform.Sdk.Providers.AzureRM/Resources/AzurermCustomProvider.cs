using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for action in .
/// Nesting mode: set
/// </summary>
public class AzurermCustomProviderActionBlock
{
    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [TerraformPropertyName("endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Endpoint { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for resource_type in .
/// Nesting mode: set
/// </summary>
public class AzurermCustomProviderResourceTypeBlock
{
    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [TerraformPropertyName("endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Endpoint { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The routing_type attribute.
    /// </summary>
    [TerraformPropertyName("routing_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RoutingType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCustomProviderTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for validation in .
/// Nesting mode: set
/// </summary>
public class AzurermCustomProviderValidationBlock
{
    /// <summary>
    /// The specification attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Specification is required")]
    [TerraformPropertyName("specification")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Specification { get; set; }

}

/// <summary>
/// Manages a azurerm_custom_provider resource.
/// </summary>
public class AzurermCustomProvider : TerraformResource
{
    public AzurermCustomProvider(string name) : base("azurerm_custom_provider", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for action.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("action")]
    public TerraformSet<TerraformBlock<AzurermCustomProviderActionBlock>>? Action { get; set; }

    /// <summary>
    /// Block for resource_type.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("resource_type")]
    public TerraformSet<TerraformBlock<AzurermCustomProviderResourceTypeBlock>>? ResourceType { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermCustomProviderTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for validation.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("validation")]
    public TerraformSet<TerraformBlock<AzurermCustomProviderValidationBlock>>? Validation { get; set; }

}
