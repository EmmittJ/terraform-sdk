using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadDirectoryRoleMemberTimeoutsBlock
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
/// Manages a azuread_directory_role_member resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzureadDirectoryRoleMember : TerraformResource
{
    public AzureadDirectoryRoleMember(string name) : base("azuread_directory_role_member", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The object ID of the member
    /// </summary>
    [TerraformPropertyName("member_object_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MemberObjectId { get; set; }

    /// <summary>
    /// The object ID of the directory role
    /// </summary>
    [TerraformPropertyName("role_object_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RoleObjectId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzureadDirectoryRoleMemberTimeoutsBlock>? Timeouts { get; set; }

}
