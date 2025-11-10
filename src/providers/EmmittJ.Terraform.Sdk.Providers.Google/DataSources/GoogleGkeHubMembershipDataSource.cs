using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_gke_hub_membership.
/// </summary>
public class GoogleGkeHubMembershipDataSource : TerraformDataSource
{
    public GoogleGkeHubMembershipDataSource(string name) : base("google_gke_hub_membership", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("authority");
        SetOutput("effective_labels");
        SetOutput("endpoint");
        SetOutput("labels");
        SetOutput("name");
        SetOutput("terraform_labels");
        SetOutput("id");
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
    /// Location of the membership.
    /// The default value is &#39;global&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
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
    /// Authority encodes how Google will recognize identities from this Membership.
    /// See the workload identity documentation for more details:
    /// https://cloud.google.com/kubernetes-engine/docs/how-to/workload-identity
    /// </summary>
    public TerraformExpression Authority => this["authority"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// If this Membership is a Kubernetes API server hosted on GKE, this is a self link to its GCP resource.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// Labels to apply to this membership.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

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
