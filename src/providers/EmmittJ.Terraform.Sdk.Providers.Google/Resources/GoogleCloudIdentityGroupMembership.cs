using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for preferred_member_key in GoogleCloudIdentityGroupMembership.
/// Nesting mode: list
/// </summary>
public class GoogleCloudIdentityGroupMembershipPreferredMemberKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "preferred_member_key";

    /// <summary>
    /// The ID of the entity.
    /// 
    /// For Google-managed entities, the id must be the email address of an existing
    /// group or user.
    /// 
    /// For external-identity-mapped entities, the id must be a string conforming
    /// to the Identity Source&#39;s requirements.
    /// 
    /// Must be unique within a namespace.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The namespace in which the entity exists.
    /// 
    /// If not specified, the EntityKey represents a Google-managed entity
    /// such as a Google user or a Google Group.
    /// 
    /// If specified, the EntityKey represents an external-identity-mapped group.
    /// The namespace must correspond to an identity source created in Admin Console
    /// and must be in the form of &#39;identitysources/{identity_source_id}&#39;.
    /// </summary>
    public TerraformValue<string>? NamespaceAttribute
    {
        get => GetArgument<TerraformValue<string>>("namespace");
        set => SetArgument("namespace", value);
    }

}


/// <summary>
/// Block type for roles in GoogleCloudIdentityGroupMembership.
/// Nesting mode: set
/// </summary>
public class GoogleCloudIdentityGroupMembershipRolesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "roles";

    /// <summary>
    /// The name of the MembershipRole. Must be one of OWNER, MANAGER, MEMBER. Possible values: [&amp;quot;OWNER&amp;quot;, &amp;quot;MANAGER&amp;quot;, &amp;quot;MEMBER&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// ExpiryDetail block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExpiryDetail block(s) allowed")]
    public TerraformList<GoogleCloudIdentityGroupMembershipRolesBlockExpiryDetailBlock>? ExpiryDetail
    {
        get => GetArgument<TerraformList<GoogleCloudIdentityGroupMembershipRolesBlockExpiryDetailBlock>>("expiry_detail");
        set => SetArgument("expiry_detail", value);
    }

}

/// <summary>
/// Block type for expiry_detail in GoogleCloudIdentityGroupMembershipRolesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudIdentityGroupMembershipRolesBlockExpiryDetailBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "expiry_detail";

    /// <summary>
    /// The time at which the MembershipRole will expire.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// 
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpireTime is required")]
    public required TerraformValue<string> ExpireTime
    {
        get => GetRequiredArgument<TerraformValue<string>>("expire_time");
        set => SetArgument("expire_time", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleCloudIdentityGroupMembership.
/// Nesting mode: single
/// </summary>
public class GoogleCloudIdentityGroupMembershipTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_cloud_identity_group_membership Terraform resource.
/// Manages a google_cloud_identity_group_membership resource.
/// </summary>
public partial class GoogleCloudIdentityGroupMembership(string name) : TerraformResource("google_cloud_identity_group_membership", name)
{
    /// <summary>
    /// If set to true, skip group member creation if a membership with the same name already exists. Defaults to false.
    /// </summary>
    public TerraformValue<bool>? CreateIgnoreAlreadyExists
    {
        get => GetArgument<TerraformValue<bool>>("create_ignore_already_exists");
        set => SetArgument("create_ignore_already_exists", value);
    }

    /// <summary>
    /// The name of the Group to create this membership in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Group is required")]
    public required TerraformValue<string> Group
    {
        get => GetRequiredArgument<TerraformValue<string>>("group");
        set => SetArgument("group", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The time when the Membership was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// The resource name of the Membership, of the form groups/{group_id}/memberships/{membership_id}.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The type of the membership.
    /// </summary>
    public TerraformValue<string> Type
        => CreateReference("type");

    /// <summary>
    /// The time when the Membership was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// PreferredMemberKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreferredMemberKey block(s) allowed")]
    public TerraformList<GoogleCloudIdentityGroupMembershipPreferredMemberKeyBlock>? PreferredMemberKey
    {
        get => GetArgument<TerraformList<GoogleCloudIdentityGroupMembershipPreferredMemberKeyBlock>>("preferred_member_key");
        set => SetArgument("preferred_member_key", value);
    }

    /// <summary>
    /// Roles block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Roles is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Roles block(s) required")]
    public required TerraformSet<GoogleCloudIdentityGroupMembershipRolesBlock> Roles
    {
        get => GetRequiredArgument<TerraformSet<GoogleCloudIdentityGroupMembershipRolesBlock>>("roles");
        set => SetArgument("roles", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleCloudIdentityGroupMembershipTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleCloudIdentityGroupMembershipTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
