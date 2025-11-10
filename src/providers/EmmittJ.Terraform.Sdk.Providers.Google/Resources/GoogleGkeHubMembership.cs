using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for authority in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubMembershipAuthorityBlock : TerraformBlock
{
    /// <summary>
    /// A JSON Web Token (JWT) issuer URI. &#39;issuer&#39; must start with &#39;https://&#39; and // be a valid
    /// with length &amp;lt;2000 characters. For example: &#39;https://container.googleapis.com/v1/projects/my-project/locations/us-west1/clusters/my-cluster&#39;. If the cluster is provisioned with Terraform, this is &#39;&amp;quot;https://container.googleapis.com/v1/${google_container_cluster.my-cluster.id}&amp;quot;&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    public required TerraformProperty<string> Issuer
    {
        set => SetProperty("issuer", value);
    }

}

/// <summary>
/// Block type for endpoint in .
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubMembershipEndpointBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleGkeHubMembershipTimeoutsBlock : TerraformBlock
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
/// Manages a google_gke_hub_membership resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleGkeHubMembership : TerraformResource
{
    public GoogleGkeHubMembership(string name) : base("google_gke_hub_membership", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("effective_labels");
        SetOutput("name");
        SetOutput("terraform_labels");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("membership_id");
        SetOutput("project");
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
    /// Labels to apply to this membership.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// Location of the membership.
    /// The default value is &#39;global&#39;.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The client-provided identifier of the membership.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MembershipId is required")]
    public required TerraformProperty<string> MembershipId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("membership_id");
        set => SetProperty("membership_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for authority.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authority block(s) allowed")]
    public List<GoogleGkeHubMembershipAuthorityBlock>? Authority
    {
        set => SetProperty("authority", value);
    }

    /// <summary>
    /// Block for endpoint.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Endpoint block(s) allowed")]
    public List<GoogleGkeHubMembershipEndpointBlock>? Endpoint
    {
        set => SetProperty("endpoint", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleGkeHubMembershipTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The unique identifier of the membership.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
