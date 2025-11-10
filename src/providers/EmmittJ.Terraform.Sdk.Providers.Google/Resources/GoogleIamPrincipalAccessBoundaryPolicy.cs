using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for details in .
/// Nesting mode: list
/// </summary>
public class GoogleIamPrincipalAccessBoundaryPolicyDetailsBlock : TerraformBlock
{
    /// <summary>
    /// The version number that indicates which Google Cloud services
    /// are included in the enforcement (e.g. \&amp;quot;latest\&amp;quot;, \&amp;quot;1\&amp;quot;, ...). If empty, the
    /// PAB policy version will be set to the current latest version, and this version
    /// won&#39;t get updated when new versions are released.
    /// </summary>
    public TerraformProperty<string>? EnforcementVersion
    {
        set => SetProperty("enforcement_version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIamPrincipalAccessBoundaryPolicyTimeoutsBlock : TerraformBlock
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
/// Manages a google_iam_principal_access_boundary_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleIamPrincipalAccessBoundaryPolicy : TerraformResource
{
    public GoogleIamPrincipalAccessBoundaryPolicy(string name) : base("google_iam_principal_access_boundary_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_annotations");
        SetOutput("etag");
        SetOutput("name");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("annotations");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("location");
        SetOutput("organization");
        SetOutput("principal_access_boundary_policy_id");
    }

    /// <summary>
    /// User defined annotations. See https://google.aip.dev/148#annotations
    /// for more details such as format and size limitations
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Annotations
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => SetProperty("annotations", value);
    }

    /// <summary>
    /// The description of the principal access boundary policy. Must be less than or equal to 63 characters.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// The location the principal access boundary policy is in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The parent organization of the principal access boundary policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Organization is required")]
    public required TerraformProperty<string> Organization
    {
        get => GetRequiredOutput<TerraformProperty<string>>("organization");
        set => SetProperty("organization", value);
    }

    /// <summary>
    /// The ID to use to create the principal access boundary policy.
    /// This value must start with a lowercase letter followed by up to 62 lowercase letters, numbers, hyphens, or dots. Pattern, /a-z{2,62}/.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalAccessBoundaryPolicyId is required")]
    public required TerraformProperty<string> PrincipalAccessBoundaryPolicyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("principal_access_boundary_policy_id");
        set => SetProperty("principal_access_boundary_policy_id", value);
    }

    /// <summary>
    /// Block for details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Details block(s) allowed")]
    public List<GoogleIamPrincipalAccessBoundaryPolicyDetailsBlock>? Details
    {
        set => SetProperty("details", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleIamPrincipalAccessBoundaryPolicyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. The time when the principal access boundary policy was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of annotations (key/value pairs) present on the resource in GCP, including the annotations configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveAnnotations => this["effective_annotations"];

    /// <summary>
    /// The etag for the principal access boundary. If this is provided on update, it must match the server&#39;s etag.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Identifier. The resource name of the principal access boundary policy.  The following format is supported:
    ///  &#39;organizations/{organization_id}/locations/{location}/principalAccessBoundaryPolicies/{policy_id}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. The globally unique ID of the principal access boundary policy.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Output only. The time when the principal access boundary policy was most recently updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
