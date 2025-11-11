using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadGroupMemberTimeoutsBlock
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

}

/// <summary>
/// Manages a azuread_group_member resource.
/// </summary>
public class AzureadGroupMember : TerraformResource
{
    public AzureadGroupMember(string name) : base("azuread_group_member", name)
    {
    }

    /// <summary>
    /// The object ID of the group you want to add the member to
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupObjectId is required")]
    [TerraformPropertyName("group_object_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GroupObjectId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The object ID of the principal you want to add as a member to the group. Supported object types are Users, Groups or Service Principals
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberObjectId is required")]
    [TerraformPropertyName("member_object_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MemberObjectId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadGroupMemberTimeoutsBlock>? Timeouts { get; set; }

}
