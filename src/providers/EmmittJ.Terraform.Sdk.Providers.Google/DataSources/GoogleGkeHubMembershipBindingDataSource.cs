using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_gke_hub_membership_binding Terraform data source.
/// Retrieves information about a google_gke_hub_membership_binding.
/// </summary>
public partial class GoogleGkeHubMembershipBindingDataSource(string name) : TerraformDataSource("google_gke_hub_membership_binding", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Location of the membership
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The client-provided identifier of the membership binding.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MembershipBindingId is required")]
    public required TerraformValue<string> MembershipBindingId
    {
        get => new TerraformReference<string>(this, "membership_binding_id");
        set => SetArgument("membership_binding_id", value);
    }

    /// <summary>
    /// Id of the membership
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MembershipId is required")]
    public required TerraformValue<string> MembershipId
    {
        get => new TerraformReference<string>(this, "membership_id");
        set => SetArgument("membership_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Time the MembershipBinding was created in UTC.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Time the MembershipBinding was deleted in UTC.
    /// </summary>
    public TerraformValue<string> DeleteTime
    {
        get => new TerraformReference<string>(this, "delete_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Labels for this Membership binding.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The resource name for the membershipbinding itself
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// A Workspace resource name in the format
    /// &#39;projects/*/locations/*/scopes/*&#39;.
    /// </summary>
    public TerraformValue<string> Scope
    {
        get => new TerraformReference<string>(this, "scope");
    }

    /// <summary>
    /// State of the membership binding resource.
    /// </summary>
    public TerraformList<TerraformMap<object>> State
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "state").ResolveNodes(ctx));
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Google-generated UUID for this resource.
    /// </summary>
    public TerraformValue<string> Uid
    {
        get => new TerraformReference<string>(this, "uid");
    }

    /// <summary>
    /// Time the MembershipBinding was updated in UTC.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

}
