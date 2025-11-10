using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_gke_hub_membership_binding.
/// </summary>
public class GoogleGkeHubMembershipBindingDataSource : TerraformDataSource
{
    public GoogleGkeHubMembershipBindingDataSource(string name) : base("google_gke_hub_membership_binding", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("delete_time");
        SetOutput("effective_labels");
        SetOutput("labels");
        SetOutput("name");
        SetOutput("scope");
        SetOutput("state");
        SetOutput("terraform_labels");
        SetOutput("uid");
        SetOutput("update_time");
        SetOutput("id");
        SetOutput("location");
        SetOutput("membership_binding_id");
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
    /// Location of the membership
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The client-provided identifier of the membership binding.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MembershipBindingId is required")]
    public required TerraformProperty<string> MembershipBindingId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("membership_binding_id");
        set => SetProperty("membership_binding_id", value);
    }

    /// <summary>
    /// Id of the membership
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
    /// Time the MembershipBinding was created in UTC.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Time the MembershipBinding was deleted in UTC.
    /// </summary>
    public TerraformExpression DeleteTime => this["delete_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Labels for this Membership binding.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

    /// <summary>
    /// The resource name for the membershipbinding itself
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// A Workspace resource name in the format
    /// &#39;projects/*/locations/*/scopes/*&#39;.
    /// </summary>
    public TerraformExpression Scope => this["scope"];

    /// <summary>
    /// State of the membership binding resource.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Google-generated UUID for this resource.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Time the MembershipBinding was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
