using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for destination in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkManagementConnectivityTestDestinationBlock
{
    /// <summary>
    /// A Cloud SQL instance URI.
    /// </summary>
    [TerraformPropertyName("cloud_sql_instance")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CloudSqlInstance { get; set; }

    /// <summary>
    /// Forwarding rule URI. Forwarding rules are frontends for load balancers,
    /// PSC endpoints, and Protocol Forwarding.
    /// </summary>
    [TerraformPropertyName("forwarding_rule")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ForwardingRule { get; set; }

    /// <summary>
    /// A DNS endpoint of Google Kubernetes Engine cluster control plane.
    /// Requires gke_master_cluster to be set, can&#39;t be used simultaneoulsly with
    /// ip_address or network. Applicable only to destination endpoint.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Fqdn { get; set; }

    /// <summary>
    /// A cluster URI for Google Kubernetes Engine cluster control plane.
    /// </summary>
    [TerraformPropertyName("gke_master_cluster")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GkeMasterCluster { get; set; }

    /// <summary>
    /// A Compute Engine instance URI.
    /// </summary>
    [TerraformPropertyName("instance")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Instance { get; set; }

    /// <summary>
    /// The IP address of the endpoint, which can be an external or internal IP.
    /// </summary>
    [TerraformPropertyName("ip_address")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IpAddress { get; set; }

    /// <summary>
    /// A VPC network URI.
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Network { get; set; }

    /// <summary>
    /// The IP protocol port of the endpoint. Only applicable when protocol is
    /// TCP or UDP.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Port { get; set; }

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
    [TerraformPropertyName("project_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ProjectId { get; set; }

    /// <summary>
    /// A Redis Cluster URI.
    /// </summary>
    [TerraformPropertyName("redis_cluster")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RedisCluster { get; set; }

    /// <summary>
    /// A Redis Instance URI.
    /// </summary>
    [TerraformPropertyName("redis_instance")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RedisInstance { get; set; }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class GoogleNetworkManagementConnectivityTestSourceBlock
{
    /// <summary>
    /// A Cloud SQL instance URI.
    /// </summary>
    [TerraformPropertyName("cloud_sql_instance")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CloudSqlInstance { get; set; }

    /// <summary>
    /// A cluster URI for Google Kubernetes Engine cluster control plane.
    /// </summary>
    [TerraformPropertyName("gke_master_cluster")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GkeMasterCluster { get; set; }

    /// <summary>
    /// A Compute Engine instance URI.
    /// </summary>
    [TerraformPropertyName("instance")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Instance { get; set; }

    /// <summary>
    /// The IP address of the endpoint, which can be an external or internal IP.
    /// </summary>
    [TerraformPropertyName("ip_address")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IpAddress { get; set; }

    /// <summary>
    /// A VPC network URI.
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Network { get; set; }

    /// <summary>
    /// Type of the network where the endpoint is located. Possible values: [&amp;quot;GCP_NETWORK&amp;quot;, &amp;quot;NON_GCP_NETWORK&amp;quot;]
    /// </summary>
    [TerraformPropertyName("network_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NetworkType { get; set; }

    /// <summary>
    /// The IP protocol port of the endpoint. Only applicable when protocol is
    /// TCP or UDP.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Port { get; set; }

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
    [TerraformPropertyName("project_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ProjectId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkManagementConnectivityTestTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_network_management_connectivity_test resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleNetworkManagementConnectivityTest : TerraformResource
{
    public GoogleNetworkManagementConnectivityTest(string name) : base("google_network_management_connectivity_test", name)
    {
    }

    /// <summary>
    /// Whether the analysis should skip firewall checking. Default value is false.
    /// </summary>
    [TerraformPropertyName("bypass_firewall_checks")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? BypassFirewallChecks { get; set; }

    /// <summary>
    /// The user-supplied description of the Connectivity Test.
    /// Maximum of 512 characters.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Resource labels to represent user-provided metadata.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Unique name for the connectivity test.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// IP Protocol of the test. When not provided, &amp;quot;TCP&amp;quot; is assumed.
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Protocol { get; set; }

    /// <summary>
    /// Other projects that may be relevant for reachability analysis.
    /// This is applicable to scenarios where a test can cross project
    /// boundaries.
    /// </summary>
    [TerraformPropertyName("related_projects")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? RelatedProjects { get; set; }

    /// <summary>
    /// Whether run analysis for the return path from destination to source.
    /// Default value is false.
    /// </summary>
    [TerraformPropertyName("round_trip")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RoundTrip { get; set; }

    /// <summary>
    /// Block for destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Destination block(s) allowed")]
    [TerraformPropertyName("destination")]
    public TerraformList<TerraformBlock<GoogleNetworkManagementConnectivityTestDestinationBlock>>? Destination { get; set; }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    [TerraformPropertyName("source")]
    public TerraformList<TerraformBlock<GoogleNetworkManagementConnectivityTestSourceBlock>>? Source { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleNetworkManagementConnectivityTestTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

}
