using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for details in GoogleIamPrincipalAccessBoundaryPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleIamPrincipalAccessBoundaryPolicyDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "details";

    /// <summary>
    /// The version number that indicates which Google Cloud services
    /// are included in the enforcement (e.g. \&amp;quot;latest\&amp;quot;, \&amp;quot;1\&amp;quot;, ...). If empty, the
    /// PAB policy version will be set to the current latest version, and this version
    /// won&#39;t get updated when new versions are released.
    /// </summary>
    public TerraformValue<string> EnforcementVersion
    {
        get => new TerraformReference<string>(this, "enforcement_version");
        set => SetArgument("enforcement_version", value);
    }

    /// <summary>
    /// Rules block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rules block(s) required")]
    public required TerraformList<GoogleIamPrincipalAccessBoundaryPolicyDetailsBlockRulesBlock> Rules
    {
        get => GetRequiredArgument<TerraformList<GoogleIamPrincipalAccessBoundaryPolicyDetailsBlockRulesBlock>>("rules");
        set => SetArgument("rules", value);
    }

}

/// <summary>
/// Block type for rules in GoogleIamPrincipalAccessBoundaryPolicyDetailsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIamPrincipalAccessBoundaryPolicyDetailsBlockRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rules";

    /// <summary>
    /// The description of the principal access boundary policy rule. Must be less than or equal to 256 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The access relationship of principals to the resources in this rule.
    /// Possible values: ALLOW
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Effect is required")]
    public required TerraformValue<string> Effect
    {
        get => new TerraformReference<string>(this, "effect");
        set => SetArgument("effect", value);
    }

    /// <summary>
    /// A list of Cloud Resource Manager resources. The resource
    /// and all the descendants are included. The number of resources in a policy
    /// is limited to 500 across all rules.
    /// The following resource types are supported:
    /// * Organizations, such as &#39;//cloudresourcemanager.googleapis.com/organizations/123&#39;.
    /// * Folders, such as &#39;//cloudresourcemanager.googleapis.com/folders/123&#39;.
    /// * Projects, such as &#39;//cloudresourcemanager.googleapis.com/projects/123&#39;
    /// or &#39;//cloudresourcemanager.googleapis.com/projects/my-project-id&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resources is required")]
    public TerraformList<string>? Resources
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "resources").ResolveNodes(ctx));
        set => SetArgument("resources", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleIamPrincipalAccessBoundaryPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleIamPrincipalAccessBoundaryPolicyTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_iam_principal_access_boundary_policy Terraform resource.
/// Manages a google_iam_principal_access_boundary_policy resource.
/// </summary>
public partial class GoogleIamPrincipalAccessBoundaryPolicy(string name) : TerraformResource("google_iam_principal_access_boundary_policy", name)
{
    /// <summary>
    /// User defined annotations. See https://google.aip.dev/148#annotations
    /// for more details such as format and size limitations
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "annotations").ResolveNodes(ctx));
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// The description of the principal access boundary policy. Must be less than or equal to 63 characters.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location the principal access boundary policy is in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The parent organization of the principal access boundary policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Organization is required")]
    public required TerraformValue<string> Organization
    {
        get => new TerraformReference<string>(this, "organization");
        set => SetArgument("organization", value);
    }

    /// <summary>
    /// The ID to use to create the principal access boundary policy.
    /// This value must start with a lowercase letter followed by up to 62 lowercase letters, numbers, hyphens, or dots. Pattern, /a-z{2,62}/.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalAccessBoundaryPolicyId is required")]
    public required TerraformValue<string> PrincipalAccessBoundaryPolicyId
    {
        get => new TerraformReference<string>(this, "principal_access_boundary_policy_id");
        set => SetArgument("principal_access_boundary_policy_id", value);
    }

    /// <summary>
    /// Output only. The time when the principal access boundary policy was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveAnnotations
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_annotations").ResolveNodes(ctx));
    }

    /// <summary>
    /// The etag for the principal access boundary. If this is provided on update, it must match the server&#39;s etag.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// Identifier. The resource name of the principal access boundary policy.  The following format is supported:
    ///  &#39;organizations/{organization_id}/locations/{location}/principalAccessBoundaryPolicies/{policy_id}&#39;
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Output only. The globally unique ID of the principal access boundary policy.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// Output only. The time when the principal access boundary policy was most recently updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Details block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Details block(s) allowed")]
    public TerraformList<GoogleIamPrincipalAccessBoundaryPolicyDetailsBlock>? Details
    {
        get => GetArgument<TerraformList<GoogleIamPrincipalAccessBoundaryPolicyDetailsBlock>>("details");
        set => SetArgument("details", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleIamPrincipalAccessBoundaryPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleIamPrincipalAccessBoundaryPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
