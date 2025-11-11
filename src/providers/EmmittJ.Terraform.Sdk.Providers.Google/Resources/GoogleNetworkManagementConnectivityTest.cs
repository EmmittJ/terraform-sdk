using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for destination in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkManagementConnectivityTestDestinationBlock : TerraformBlockBase
{
    /// <summary>
    /// A Cloud SQL instance URI.
    /// </summary>
    [TerraformProperty("cloud_sql_instance")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CloudSqlInstance { get; set; }

    /// <summary>
    /// Forwarding rule URI. Forwarding rules are frontends for load balancers,
    /// PSC endpoints, and Protocol Forwarding.
    /// </summary>
    [TerraformProperty("forwarding_rule")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ForwardingRule { get; set; }

    /// <summary>
    /// A DNS endpoint of Google Kubernetes Engine cluster control plane.
    /// Requires gke_master_cluster to be set, can&#39;t be used simultaneoulsly with
    /// ip_address or network. Applicable only to destination endpoint.
    /// </summary>
    [TerraformProperty("fqdn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Fqdn { get; set; }

    /// <summary>
    /// A cluster URI for Google Kubernetes Engine cluster control plane.
    /// </summary>
    [TerraformProperty("gke_master_cluster")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GkeMasterCluster { get; set; }

    /// <summary>
    /// A Compute Engine instance URI.
    /// </summary>
    [TerraformProperty("instance")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Instance { get; set; }

    /// <summary>
    /// The IP address of the endpoint, which can be an external or internal IP.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IpAddress { get; set; }

    /// <summary>
    /// A VPC network URI.
    /// </summary>
    [TerraformProperty("network")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Network { get; set; }

    /// <summary>
    /// The IP protocol port of the endpoint. Only applicable when protocol is
    /// TCP or UDP.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// Project ID where the endpoint is located.
    /// The project ID can be derived from the URI if you provide a endpoint or
    /// network URI.
    /// The following are two cases where you may need to provide the project ID:
    /// 1. Only the IP address is specified, and the IP address is within a Google
    /// Cloud project.
    /// 2. When you are using Shared VPC and the IP address that you provide is
    /// from the service project. In this case, the network that the IP address
    /// resides in is defined in the host project.
    /// </summary>
    [TerraformProperty("project_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProjectId { get; set; }

    /// <summary>
    /// A Redis Cluster URI.
    /// </summary>
    [TerraformProperty("redis_cluster")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RedisCluster { get; set; }

    /// <summary>
    /// A Redis Instance URI.
    /// </summary>
    [TerraformProperty("redis_instance")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RedisInstance { get; set; }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public partial class GoogleNetworkManagementConnectivityTestSourceBlock : TerraformBlockBase
{
    /// <summary>
    /// A Cloud SQL instance URI.
    /// </summary>
    [TerraformProperty("cloud_sql_instance")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CloudSqlInstance { get; set; }

    /// <summary>
    /// A cluster URI for Google Kubernetes Engine cluster control plane.
    /// </summary>
    [TerraformProperty("gke_master_cluster")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GkeMasterCluster { get; set; }

    /// <summary>
    /// A Compute Engine instance URI.
    /// </summary>
    [TerraformProperty("instance")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Instance { get; set; }

    /// <summary>
    /// The IP address of the endpoint, which can be an external or internal IP.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IpAddress { get; set; }

    /// <summary>
    /// A VPC network URI.
    /// </summary>
    [TerraformProperty("network")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Network { get; set; }

    /// <summary>
    /// Type of the network where the endpoint is located. Possible values: [&amp;quot;GCP_NETWORK&amp;quot;, &amp;quot;NON_GCP_NETWORK&amp;quot;]
    /// </summary>
    [TerraformProperty("network_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NetworkType { get; set; }

    /// <summary>
    /// The IP protocol port of the endpoint. Only applicable when protocol is
    /// TCP or UDP.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// Project ID where the endpoint is located.
    /// The project ID can be derived from the URI if you provide a endpoint or
    /// network URI.
    /// The following are two cases where you may need to provide the project ID:
    /// 1. Only the IP address is specified, and the IP address is within a Google
    /// Cloud project.
    /// 2. When you are using Shared VPC and the IP address that you provide is
    /// from the service project. In this case, the network that the IP address
    /// resides in is defined in the host project.
    /// </summary>
    [TerraformProperty("project_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProjectId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNetworkManagementConnectivityTestTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_network_management_connectivity_test resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleNetworkManagementConnectivityTest : TerraformResource
{
    public GoogleNetworkManagementConnectivityTest(string name) : base("google_network_management_connectivity_test", name)
    {
    }

    /// <summary>
    /// Whether the analysis should skip firewall checking. Default value is false.
    /// </summary>
    [TerraformProperty("bypass_firewall_checks")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BypassFirewallChecks { get; set; }

    /// <summary>
    /// The user-supplied description of the Connectivity Test.
    /// Maximum of 512 characters.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Resource labels to represent user-provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Unique name for the connectivity test.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// IP Protocol of the test. When not provided, &amp;quot;TCP&amp;quot; is assumed.
    /// </summary>
    [TerraformProperty("protocol")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Protocol { get; set; }

    /// <summary>
    /// Other projects that may be relevant for reachability analysis.
    /// This is applicable to scenarios where a test can cross project
    /// boundaries.
    /// </summary>
    [TerraformProperty("related_projects")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? RelatedProjects { get; set; }

    /// <summary>
    /// Whether run analysis for the return path from destination to source.
    /// Default value is false.
    /// </summary>
    [TerraformProperty("round_trip")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RoundTrip { get; set; }

    /// <summary>
    /// Block for destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    [TerraformProperty("destination")]
    public partial TerraformList<TerraformBlock<GoogleNetworkManagementConnectivityTestDestinationBlock>>? Destination { get; set; }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    [TerraformProperty("source")]
    public partial TerraformList<TerraformBlock<GoogleNetworkManagementConnectivityTestSourceBlock>>? Source { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleNetworkManagementConnectivityTestTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
