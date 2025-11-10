using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_network_endpoint_group.
/// </summary>
public class GoogleComputeNetworkEndpointGroupDataSource : TerraformDataSource
{
    public GoogleComputeNetworkEndpointGroupDataSource(string name) : base("google_compute_network_endpoint_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Name of the resource; provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SelfLink { get; set; }

    /// <summary>
    /// Zone where the network endpoint group is located.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Zone { get; set; }

    /// <summary>
    /// The default port used if the port number is not specified in the
    /// network endpoint.
    /// </summary>
    [TerraformPropertyName("default_port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DefaultPort => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "default_port");

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The uniquely generated identifier for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformPropertyName("generated_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> GeneratedId => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "generated_id");

    /// <summary>
    /// The network to which all network endpoints in the NEG belong.
    /// Uses &amp;quot;default&amp;quot; project network if unspecified.
    /// </summary>
    [TerraformPropertyName("network")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Network => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network");

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
    [TerraformPropertyName("network_endpoint_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkEndpointType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_endpoint_type");

    /// <summary>
    /// Number of network endpoints in the network endpoint group.
    /// </summary>
    [TerraformPropertyName("size")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Size => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "size");

    /// <summary>
    /// Optional subnetwork to which all network endpoints in the NEG belong.
    /// </summary>
    [TerraformPropertyName("subnetwork")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Subnetwork => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subnetwork");

}
