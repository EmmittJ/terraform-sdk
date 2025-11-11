using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for external_ip in .
/// Nesting mode: list
/// </summary>
public partial class GoogleVmwareengineNetworkPolicyExternalIpBlock : TerraformBlockBase
{
    /// <summary>
    /// True if the service is enabled; false otherwise.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }


}

/// <summary>
/// Block type for internet_access in .
/// Nesting mode: list
/// </summary>
public partial class GoogleVmwareengineNetworkPolicyInternetAccessBlock : TerraformBlockBase
{
    /// <summary>
    /// True if the service is enabled; false otherwise.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleVmwareengineNetworkPolicyTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_vmwareengine_network_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleVmwareengineNetworkPolicy : TerraformResource
{
    public GoogleVmwareengineNetworkPolicy(string name) : base("google_vmwareengine_network_policy", name)
    {
    }

    /// <summary>
    /// User-provided description for this network policy.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// IP address range in CIDR notation used to create internet access and external IP access.
    /// An RFC 1918 CIDR block, with a &amp;quot;/26&amp;quot; prefix, is required. The range cannot overlap with any
    /// prefixes either in the consumer VPC network or in use by the private clouds attached to that VPC network.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EdgeServicesCidr is required")]
    [TerraformProperty("edge_services_cidr")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EdgeServicesCidr { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The resource name of the location (region) to create the new network policy in.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-central1
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The ID of the Network Policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The relative resource name of the VMware Engine network. Specify the name in the following form:
    /// projects/{project}/locations/{location}/vmwareEngineNetworks/{vmwareEngineNetworkId} where {project}
    /// can either be a project number or a project ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VmwareEngineNetwork is required")]
    [TerraformProperty("vmware_engine_network")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VmwareEngineNetwork { get; set; }

    /// <summary>
    /// Block for external_ip.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalIp block(s) allowed")]
    [TerraformProperty("external_ip")]
    public TerraformList<TerraformBlock<GoogleVmwareengineNetworkPolicyExternalIpBlock>>? ExternalIp { get; set; }

    /// <summary>
    /// Block for internet_access.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InternetAccess block(s) allowed")]
    [TerraformProperty("internet_access")]
    public TerraformList<TerraformBlock<GoogleVmwareengineNetworkPolicyInternetAccessBlock>>? InternetAccess { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleVmwareengineNetworkPolicyTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uid { get; }

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

    /// <summary>
    /// The canonical name of the VMware Engine network in the form:
    /// projects/{project_number}/locations/{location}/vmwareEngineNetworks/{vmwareEngineNetworkId}
    /// </summary>
    [TerraformProperty("vmware_engine_network_canonical")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> VmwareEngineNetworkCanonical { get; }

}
