using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for gke_clusters in .
/// Nesting mode: list
/// </summary>
public class GoogleDnsResponsePolicyGkeClustersBlock : ITerraformBlock
{
    /// <summary>
    /// The resource name of the cluster to bind this ManagedZone to.
    /// This should be specified in the format like
    /// &#39;projects/*/locations/*/clusters/*&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GkeClusterName is required")]
    [TerraformPropertyName("gke_cluster_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GkeClusterName { get; set; }

}

/// <summary>
/// Block type for networks in .
/// Nesting mode: list
/// </summary>
public class GoogleDnsResponsePolicyNetworksBlock : ITerraformBlock
{
    /// <summary>
    /// The fully qualified URL of the VPC network to bind to.
    /// This should be formatted like
    /// &#39;https://www.googleapis.com/compute/v1/projects/{project}/global/networks/{network}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkUrl is required")]
    [TerraformPropertyName("network_url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NetworkUrl { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDnsResponsePolicyTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_dns_response_policy resource.
/// </summary>
public class GoogleDnsResponsePolicy : TerraformResource
{
    public GoogleDnsResponsePolicy(string name) : base("google_dns_response_policy", name)
    {
    }

    /// <summary>
    /// The description of the response policy, such as &#39;My new response policy&#39;.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The user assigned name for this Response Policy, such as &#39;myresponsepolicy&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResponsePolicyName is required")]
    [TerraformPropertyName("response_policy_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResponsePolicyName { get; set; }

    /// <summary>
    /// Block for gke_clusters.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("gke_clusters")]
    public TerraformList<TerraformBlock<GoogleDnsResponsePolicyGkeClustersBlock>>? GkeClusters { get; set; } = new();

    /// <summary>
    /// Block for networks.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("networks")]
    public TerraformList<TerraformBlock<GoogleDnsResponsePolicyNetworksBlock>>? Networks { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDnsResponsePolicyTimeoutsBlock>? Timeouts { get; set; } = new();

}
