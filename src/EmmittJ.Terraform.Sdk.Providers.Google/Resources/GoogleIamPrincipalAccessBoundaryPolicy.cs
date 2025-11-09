using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_iam_principal_access_boundary_policy resource.
/// </summary>
public class GoogleIamPrincipalAccessBoundaryPolicy : TerraformResource
{
    public GoogleIamPrincipalAccessBoundaryPolicy(string name) : base("google_iam_principal_access_boundary_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_annotations");
        this.DeclareOutput("etag");
        this.DeclareOutput("name");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// User defined annotations. See https://google.aip.dev/148#annotations
    /// for more details such as format and size limitations
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the annotations present in your configuration.
    /// Please refer to the field &#39;effective_annotations&#39; for all of the annotations present on the resource.
    /// </summary>
    public TerraformMapProperty<string>? Annotations
    {
        get => GetProperty<TerraformMapProperty<string>>("annotations");
        set => this.WithProperty("annotations", value);
    }

    /// <summary>
    /// The description of the principal access boundary policy. Must be less than or equal to 63 characters.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location the principal access boundary policy is in.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The parent organization of the principal access boundary policy.
    /// </summary>
    public TerraformProperty<string>? Organization
    {
        get => GetProperty<TerraformProperty<string>>("organization");
        set => this.WithProperty("organization", value);
    }

    /// <summary>
    /// The ID to use to create the principal access boundary policy.
    /// This value must start with a lowercase letter followed by up to 62 lowercase letters, numbers, hyphens, or dots. Pattern, /a-z{2,62}/.
    /// </summary>
    public TerraformProperty<string>? PrincipalAccessBoundaryPolicyId
    {
        get => GetProperty<TerraformProperty<string>>("principal_access_boundary_policy_id");
        set => this.WithProperty("principal_access_boundary_policy_id", value);
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
