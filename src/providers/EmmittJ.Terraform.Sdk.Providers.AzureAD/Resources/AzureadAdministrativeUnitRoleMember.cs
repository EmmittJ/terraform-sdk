using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadAdministrativeUnitRoleMemberTimeoutsBlock : TerraformBlockBase
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
/// Manages a azuread_administrative_unit_role_member resource.
/// </summary>
public partial class AzureadAdministrativeUnitRoleMember : TerraformResource
{
    public AzureadAdministrativeUnitRoleMember(string name) : base("azuread_administrative_unit_role_member", name)
    {
    }

    /// <summary>
    /// The object ID of the administrative unit
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdministrativeUnitObjectId is required")]
    [TerraformProperty("administrative_unit_object_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AdministrativeUnitObjectId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The object ID of the member
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberObjectId is required")]
    [TerraformProperty("member_object_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MemberObjectId { get; set; }

    /// <summary>
    /// The object ID of the directory role
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleObjectId is required")]
    [TerraformProperty("role_object_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleObjectId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzureadAdministrativeUnitRoleMemberTimeoutsBlock>? Timeouts { get; set; }

}
