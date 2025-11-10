using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_vmwareengine_network_policy.
/// </summary>
public class GoogleVmwareengineNetworkPolicyDataSource : TerraformDataSource
{
    public GoogleVmwareengineNetworkPolicyDataSource(string name) : base("google_vmwareengine_network_policy", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The resource name of the location (region) to create the new network policy in.
    /// Resource names are schemeless URIs that follow the conventions in https://cloud.google.com/apis/design/resource_names.
    /// For example: projects/my-project/locations/us-central1
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The ID of the Network Policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// Creation time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// User-provided description for this network policy.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// IP address range in CIDR notation used to create internet access and external IP access.
    /// An RFC 1918 CIDR block, with a &amp;quot;/26&amp;quot; prefix, is required. The range cannot overlap with any
    /// prefixes either in the consumer VPC network or in use by the private clouds attached to that VPC network.
    /// </summary>
    [TerraformPropertyName("edge_services_cidr")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EdgeServicesCidr => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "edge_services_cidr");

    /// <summary>
    /// Network service that allows External IP addresses to be assigned to VMware workloads.
    /// This service can only be enabled when internetAccess is also enabled.
    /// </summary>
    [TerraformPropertyName("external_ip")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ExternalIp => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "external_ip");

    /// <summary>
    /// Network service that allows VMware workloads to access the internet.
    /// </summary>
    [TerraformPropertyName("internet_access")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> InternetAccess => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "internet_access");

    /// <summary>
    /// System-generated unique identifier for the resource.
    /// </summary>
    [TerraformPropertyName("uid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Uid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "uid");

    /// <summary>
    /// Last updated time of this resource.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

    /// <summary>
    /// The relative resource name of the VMware Engine network. Specify the name in the following form:
    /// projects/{project}/locations/{location}/vmwareEngineNetworks/{vmwareEngineNetworkId} where {project}
    /// can either be a project number or a project ID.
    /// </summary>
    [TerraformPropertyName("vmware_engine_network")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VmwareEngineNetwork => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vmware_engine_network");

    /// <summary>
    /// The canonical name of the VMware Engine network in the form:
    /// projects/{project_number}/locations/{location}/vmwareEngineNetworks/{vmwareEngineNetworkId}
    /// </summary>
    [TerraformPropertyName("vmware_engine_network_canonical")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VmwareEngineNetworkCanonical => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vmware_engine_network_canonical");

}
