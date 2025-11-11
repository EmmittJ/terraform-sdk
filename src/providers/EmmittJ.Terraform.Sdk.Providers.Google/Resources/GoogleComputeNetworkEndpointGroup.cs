using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeNetworkEndpointGroupTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Manages a google_compute_network_endpoint_group resource.
/// </summary>
public partial class GoogleComputeNetworkEndpointGroup : TerraformResource
{
    public GoogleComputeNetworkEndpointGroup(string name) : base("google_compute_network_endpoint_group", name)
    {
    }

    /// <summary>
    /// The default port used if the port number is not specified in the
    /// network endpoint.
    /// </summary>
    [TerraformProperty("default_port")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? DefaultPort { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
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
    /// Name of the resource; provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network to which all network endpoints in the NEG belong.
    /// Uses &amp;quot;default&amp;quot; project network if unspecified.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformProperty("network")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Network { get; set; }

    /// <summary>
    /// Type of network endpoints in this network endpoint group.
    /// NON_GCP_PRIVATE_IP_PORT is used for hybrid connectivity network
    /// endpoint groups (see https://cloud.google.com/load-balancing/docs/hybrid).
    /// Note that NON_GCP_PRIVATE_IP_PORT can only be used with Backend Services
    /// that 1) have the following load balancing schemes: EXTERNAL, EXTERNAL_MANAGED,
    /// INTERNAL_MANAGED, and INTERNAL_SELF_MANAGED and 2) support the RATE or
    /// CONNECTION balancing modes.
    /// 
    /// Possible values include: GCE_VM_IP, GCE_VM_IP_PORT, NON_GCP_PRIVATE_IP_PORT, INTERNET_IP_PORT, INTERNET_FQDN_PORT, SERVERLESS, and PRIVATE_SERVICE_CONNECT. Default value: &amp;quot;GCE_VM_IP_PORT&amp;quot; Possible values: [&amp;quot;GCE_VM_IP&amp;quot;, &amp;quot;GCE_VM_IP_PORT&amp;quot;, &amp;quot;NON_GCP_PRIVATE_IP_PORT&amp;quot;, &amp;quot;INTERNET_IP_PORT&amp;quot;, &amp;quot;INTERNET_FQDN_PORT&amp;quot;, &amp;quot;SERVERLESS&amp;quot;, &amp;quot;PRIVATE_SERVICE_CONNECT&amp;quot;]
    /// </summary>
    [TerraformProperty("network_endpoint_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NetworkEndpointType { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Optional subnetwork to which all network endpoints in the NEG belong.
    /// </summary>
    [TerraformProperty("subnetwork")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Subnetwork { get; set; }

    /// <summary>
    /// Zone where the network endpoint group is located.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Zone { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleComputeNetworkEndpointGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The uniquely generated identifier for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformProperty("generated_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> GeneratedId { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// Number of network endpoints in the network endpoint group.
    /// </summary>
    [TerraformProperty("size")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> Size { get; }

}
