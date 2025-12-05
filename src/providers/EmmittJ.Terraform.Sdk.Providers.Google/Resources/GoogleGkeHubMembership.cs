using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for authority in GoogleGkeHubMembership.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubMembershipAuthorityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authority";

    /// <summary>
    /// A JSON Web Token (JWT) issuer URI. &#39;issuer&#39; must start with &#39;https://&#39; and // be a valid
    /// with length &amp;lt;2000 characters. For example: &#39;https://container.googleapis.com/v1/projects/my-project/locations/us-west1/clusters/my-cluster&#39;. If the cluster is provisioned with Terraform, this is &#39;&amp;quot;https://container.googleapis.com/v1/${google_container_cluster.my-cluster.id}&amp;quot;&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    public required TerraformValue<string> Issuer
    {
        get => GetRequiredArgument<TerraformValue<string>>("issuer");
        set => SetArgument("issuer", value);
    }

}


/// <summary>
/// Block type for endpoint in GoogleGkeHubMembership.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubMembershipEndpointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "endpoint";

    /// <summary>
    /// GkeCluster block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GkeCluster block(s) allowed")]
    public TerraformList<GoogleGkeHubMembershipEndpointBlockGkeClusterBlock>? GkeCluster
    {
        get => GetArgument<TerraformList<GoogleGkeHubMembershipEndpointBlockGkeClusterBlock>>("gke_cluster");
        set => SetArgument("gke_cluster", value);
    }

}

/// <summary>
/// Block type for gke_cluster in GoogleGkeHubMembershipEndpointBlock.
/// Nesting mode: list
/// </summary>
public class GoogleGkeHubMembershipEndpointBlockGkeClusterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gke_cluster";

    /// <summary>
    /// Self-link of the GCP resource for the GKE cluster.
    /// For example: &#39;//container.googleapis.com/projects/my-project/locations/us-west1-a/clusters/my-cluster&#39;.
    /// It can be at the most 1000 characters in length. If the cluster is provisioned with Terraform,
    /// this can be &#39;&amp;quot;//container.googleapis.com/${google_container_cluster.my-cluster.id}&amp;quot;&#39; or
    /// &#39;google_container_cluster.my-cluster.id&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceLink is required")]
    public required TerraformValue<string> ResourceLink
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_link");
        set => SetArgument("resource_link", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleGkeHubMembership.
/// Nesting mode: single
/// </summary>
public class GoogleGkeHubMembershipTimeoutsBlock : TerraformBlock
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
/// Represents a google_gke_hub_membership Terraform resource.
/// Manages a google_gke_hub_membership resource.
/// </summary>
public partial class GoogleGkeHubMembership(string name) : TerraformResource("google_gke_hub_membership", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Labels to apply to this membership.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Location of the membership.
    /// The default value is &#39;global&#39;.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The client-provided identifier of the membership.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MembershipId is required")]
    public required TerraformValue<string> MembershipId
    {
        get => GetRequiredArgument<TerraformValue<string>>("membership_id");
        set => SetArgument("membership_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => CreateReference("effective_labels");

    /// <summary>
    /// The unique identifier of the membership.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => CreateReference("terraform_labels");

    /// <summary>
    /// Authority block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authority block(s) allowed")]
    public TerraformList<GoogleGkeHubMembershipAuthorityBlock>? Authority
    {
        get => GetArgument<TerraformList<GoogleGkeHubMembershipAuthorityBlock>>("authority");
        set => SetArgument("authority", value);
    }

    /// <summary>
    /// Endpoint block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Endpoint block(s) allowed")]
    public TerraformList<GoogleGkeHubMembershipEndpointBlock>? Endpoint
    {
        get => GetArgument<TerraformList<GoogleGkeHubMembershipEndpointBlock>>("endpoint");
        set => SetArgument("endpoint", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleGkeHubMembershipTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleGkeHubMembershipTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
