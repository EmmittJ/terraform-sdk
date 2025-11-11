using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for gke_clusters in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDnsResponsePolicyGkeClustersBlock : TerraformBlockBase
{
    /// <summary>
    /// The resource name of the cluster to bind this ManagedZone to.
    /// This should be specified in the format like
    /// &#39;projects/*/locations/*/clusters/*&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GkeClusterName is required")]
    [TerraformProperty("gke_cluster_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> GkeClusterName { get; set; }

}

/// <summary>
/// Block type for networks in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDnsResponsePolicyNetworksBlock : TerraformBlockBase
{
    /// <summary>
    /// The fully qualified URL of the VPC network to bind to.
    /// This should be formatted like
    /// &#39;https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkUrl is required")]
    [TerraformProperty("network_url")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> NetworkUrl { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDnsResponsePolicyTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_dns_response_policy resource.
/// </summary>
public partial class GoogleDnsResponsePolicy : TerraformResource
{
    public GoogleDnsResponsePolicy(string name) : base("google_dns_response_policy", name)
    {
    }

    /// <summary>
    /// The description of the response policy, such as &#39;My new response policy&#39;.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The user assigned name for this Response Policy, such as &#39;myresponsepolicy&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResponsePolicyName is required")]
    [TerraformProperty("response_policy_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResponsePolicyName { get; set; }

    /// <summary>
    /// Block for gke_clusters.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("gke_clusters")]
    public TerraformList<TerraformBlock<GoogleDnsResponsePolicyGkeClustersBlock>>? GkeClusters { get; set; }

    /// <summary>
    /// Block for networks.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("networks")]
    public TerraformList<TerraformBlock<GoogleDnsResponsePolicyNetworksBlock>>? Networks { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleDnsResponsePolicyTimeoutsBlock>? Timeouts { get; set; }

}
