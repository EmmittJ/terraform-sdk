using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for preferred_member_key in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudIdentityGroupMembershipPreferredMemberKeyBlock : ITerraformBlock
{
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
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

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
    [TerraformPropertyName("namespace")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Namespace { get; set; }

}

/// <summary>
/// Block type for roles in .
/// Nesting mode: set
/// </summary>
public class GoogleCloudIdentityGroupMembershipRolesBlock : ITerraformBlock
{
    /// <summary>
    /// The name of the MembershipRole. Must be one of OWNER, MANAGER, MEMBER. Possible values: [&amp;quot;OWNER&amp;quot;, &amp;quot;MANAGER&amp;quot;, &amp;quot;MEMBER&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCloudIdentityGroupMembershipTimeoutsBlock : ITerraformBlock
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
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_cloud_identity_group_membership resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCloudIdentityGroupMembership : TerraformResource
{
    public GoogleCloudIdentityGroupMembership(string name) : base("google_cloud_identity_group_membership", name)
    {
    }

    /// <summary>
    /// If set to true, skip group member creation if a membership with the same name already exists. Defaults to false.
    /// </summary>
    [TerraformPropertyName("create_ignore_already_exists")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CreateIgnoreAlreadyExists { get; set; }

    /// <summary>
    /// The name of the Group to create this membership in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Group is required")]
    [TerraformPropertyName("group")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Group { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Block for preferred_member_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreferredMemberKey block(s) allowed")]
    [TerraformPropertyName("preferred_member_key")]
    public TerraformList<TerraformBlock<GoogleCloudIdentityGroupMembershipPreferredMemberKeyBlock>>? PreferredMemberKey { get; set; } = new();

    /// <summary>
    /// Block for roles.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Roles is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Roles block(s) required")]
    [TerraformPropertyName("roles")]
    public TerraformSet<TerraformBlock<GoogleCloudIdentityGroupMembershipRolesBlock>>? Roles { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleCloudIdentityGroupMembershipTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The time when the Membership was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The resource name of the Membership, of the form groups/{group_id}/memberships/{membership_id}.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The type of the membership.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

    /// <summary>
    /// The time when the Membership was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
