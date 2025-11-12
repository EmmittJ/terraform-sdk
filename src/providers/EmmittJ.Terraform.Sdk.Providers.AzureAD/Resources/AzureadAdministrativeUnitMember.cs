using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadAdministrativeUnitMemberTimeoutsBlock() : TerraformBlock("timeouts")
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

}

/// <summary>
/// Manages a azuread_administrative_unit_member resource.
/// </summary>
public partial class AzureadAdministrativeUnitMember : TerraformResource
{
    public AzureadAdministrativeUnitMember(string name) : base("azuread_administrative_unit_member", name)
    {
    }

    /// <summary>
    /// The object ID of the administrative unit
    /// </summary>
    [TerraformProperty("administrative_unit_object_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdministrativeUnitObjectId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The object ID of the member
    /// </summary>
    [TerraformProperty("member_object_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MemberObjectId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzureadAdministrativeUnitMemberTimeoutsBlock Timeouts { get; set; } = new();

}
