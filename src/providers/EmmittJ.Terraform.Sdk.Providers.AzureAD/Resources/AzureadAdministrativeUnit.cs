using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadAdministrativeUnitTimeoutsBlock : ITerraformBlock
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
/// Manages a azuread_administrative_unit resource.
/// </summary>
public class AzureadAdministrativeUnit : TerraformResource
{
    public AzureadAdministrativeUnit(string name) : base("azuread_administrative_unit", name)
    {
    }

    /// <summary>
    /// The description for the administrative unit
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The display name for the administrative unit
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// Whether the administrative unit and its members are hidden or publicly viewable in the directory
    /// </summary>
    [TerraformPropertyName("hidden_membership_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? HiddenMembershipEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// A set of object IDs of members who should be present in this administrative unit. Supported object types are Users or Groups
    /// </summary>
    [TerraformPropertyName("members")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> Members { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "members");

    /// <summary>
    /// If `true`, will return an error if an existing administrative unit is found with the same name
    /// </summary>
    [TerraformPropertyName("prevent_duplicate_names")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PreventDuplicateNames { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadAdministrativeUnitTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The object ID of the administrative unit
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ObjectId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "object_id");

}
