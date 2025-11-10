using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for preferred_member_key in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudIdentityGroupMembershipPreferredMemberKeyBlock : TerraformBlock
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
    public required TerraformProperty<string> Id
    {
        set => SetProperty("id", value);
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
    public TerraformProperty<string>? Namespace
    {
        set => SetProperty("namespace", value);
    }

}

/// <summary>
/// Block type for roles in .
/// Nesting mode: set
/// </summary>
public class GoogleCloudIdentityGroupMembershipRolesBlock : TerraformBlock
{
    /// <summary>
    /// The name of the MembershipRole. Must be one of OWNER, MANAGER, MEMBER. Possible values: [&amp;quot;OWNER&amp;quot;, &amp;quot;MANAGER&amp;quot;, &amp;quot;MEMBER&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCloudIdentityGroupMembershipTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_cloud_identity_group_membership resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCloudIdentityGroupMembership : TerraformResource
{
    public GoogleCloudIdentityGroupMembership(string name) : base("google_cloud_identity_group_membership", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("name");
        SetOutput("type");
        SetOutput("update_time");
        SetOutput("create_ignore_already_exists");
        SetOutput("group");
        SetOutput("id");
    }

    /// <summary>
    /// If set to true, skip group member creation if a membership with the same name already exists. Defaults to false.
    /// </summary>
    public TerraformProperty<bool> CreateIgnoreAlreadyExists
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("create_ignore_already_exists");
        set => SetProperty("create_ignore_already_exists", value);
    }

    /// <summary>
    /// The name of the Group to create this membership in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Group is required")]
    public required TerraformProperty<string> Group
    {
        get => GetRequiredOutput<TerraformProperty<string>>("group");
        set => SetProperty("group", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Block for preferred_member_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreferredMemberKey block(s) allowed")]
    public List<GoogleCloudIdentityGroupMembershipPreferredMemberKeyBlock>? PreferredMemberKey
    {
        set => SetProperty("preferred_member_key", value);
    }

    /// <summary>
    /// Block for roles.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Roles is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Roles block(s) required")]
    public HashSet<GoogleCloudIdentityGroupMembershipRolesBlock>? Roles
    {
        set => SetProperty("roles", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleCloudIdentityGroupMembershipTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The time when the Membership was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The resource name of the Membership, of the form groups/{group_id}/memberships/{membership_id}.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The type of the membership.
    /// </summary>
    public TerraformExpression Type => this["type"];

    /// <summary>
    /// The time when the Membership was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
