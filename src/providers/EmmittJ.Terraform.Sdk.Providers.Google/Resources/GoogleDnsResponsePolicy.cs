using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for gke_clusters in GoogleDnsResponsePolicy.
/// Nesting mode: list
/// </summary>
public class GoogleDnsResponsePolicyGkeClustersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "gke_clusters";

    /// <summary>
    /// The resource name of the cluster to bind this ManagedZone to.
    /// This should be specified in the format like
    /// &#39;projects/*/locations/*/clusters/*&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GkeClusterName is required")]
    public required TerraformValue<string> GkeClusterName
    {
        get => new TerraformReference<string>(this, "gke_cluster_name");
        set => SetArgument("gke_cluster_name", value);
    }

}


/// <summary>
/// Block type for networks in GoogleDnsResponsePolicy.
/// Nesting mode: list
/// </summary>
public class GoogleDnsResponsePolicyNetworksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "networks";

    /// <summary>
    /// The fully qualified URL of the VPC network to bind to.
    /// This should be formatted like
    /// &#39;https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkUrl is required")]
    public required TerraformValue<string> NetworkUrl
    {
        get => new TerraformReference<string>(this, "network_url");
        set => SetArgument("network_url", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDnsResponsePolicy.
/// Nesting mode: single
/// </summary>
public class GoogleDnsResponsePolicyTimeoutsBlock : TerraformBlock
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
/// Represents a google_dns_response_policy Terraform resource.
/// Manages a google_dns_response_policy resource.
/// </summary>
public partial class GoogleDnsResponsePolicy(string name) : TerraformResource("google_dns_response_policy", name)
{
    /// <summary>
    /// The description of the response policy, such as &#39;My new response policy&#39;.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The user assigned name for this Response Policy, such as &#39;myresponsepolicy&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResponsePolicyName is required")]
    public required TerraformValue<string> ResponsePolicyName
    {
        get => new TerraformReference<string>(this, "response_policy_name");
        set => SetArgument("response_policy_name", value);
    }

    /// <summary>
    /// GkeClusters block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDnsResponsePolicyGkeClustersBlock>? GkeClusters
    {
        get => GetArgument<TerraformList<GoogleDnsResponsePolicyGkeClustersBlock>>("gke_clusters");
        set => SetArgument("gke_clusters", value);
    }

    /// <summary>
    /// Networks block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDnsResponsePolicyNetworksBlock>? Networks
    {
        get => GetArgument<TerraformList<GoogleDnsResponsePolicyNetworksBlock>>("networks");
        set => SetArgument("networks", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDnsResponsePolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDnsResponsePolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
