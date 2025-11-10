using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadAdministrativeUnitMemberTimeoutsBlock : ITerraformBlock
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

}

/// <summary>
/// Manages a azuread_administrative_unit_member resource.
/// </summary>
public class AzureadAdministrativeUnitMember : TerraformResource
{
    public AzureadAdministrativeUnitMember(string name) : base("azuread_administrative_unit_member", name)
    {
    }

    /// <summary>
    /// The object ID of the administrative unit
    /// </summary>
    [TerraformPropertyName("administrative_unit_object_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AdministrativeUnitObjectId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The object ID of the member
    /// </summary>
    [TerraformPropertyName("member_object_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MemberObjectId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadAdministrativeUnitMemberTimeoutsBlock>? Timeouts { get; set; } = new();

}
