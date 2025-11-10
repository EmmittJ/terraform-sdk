using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadUserFlowAttributeTimeoutsBlock : ITerraformBlock
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
/// Manages a azuread_user_flow_attribute resource.
/// </summary>
public class AzureadUserFlowAttribute : TerraformResource
{
    public AzureadUserFlowAttribute(string name) : base("azuread_user_flow_attribute", name)
    {
    }

    /// <summary>
    /// The data type of the user flow attribute
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataType is required")]
    [TerraformPropertyName("data_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataType { get; set; }

    /// <summary>
    /// The description of the user flow attribute that is shown to the user at the time of sign-up
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformPropertyName("description")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Description { get; set; }

    /// <summary>
    /// The display name of the user flow attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadUserFlowAttributeTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The type of the user flow attribute
    /// </summary>
    [TerraformPropertyName("attribute_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AttributeType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "attribute_type");

}
