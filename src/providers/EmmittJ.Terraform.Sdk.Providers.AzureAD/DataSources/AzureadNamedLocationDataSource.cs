using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadNamedLocationDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azuread_named_location.
/// </summary>
public class AzureadNamedLocationDataSource : TerraformDataSource
{
    public AzureadNamedLocationDataSource(string name) : base("azuread_named_location", name)
    {
    }

    /// <summary>
    /// The display_name attribute.
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
    public TerraformBlock<AzureadNamedLocationDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The country attribute.
    /// </summary>
    [TerraformPropertyName("country")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Country => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "country");

    /// <summary>
    /// The ip attribute.
    /// </summary>
    [TerraformPropertyName("ip")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Ip => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ip");

    /// <summary>
    /// The object ID of the named location
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ObjectId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "object_id");

}
