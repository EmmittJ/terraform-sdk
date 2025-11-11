using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_region_network_endpoint_group.
/// </summary>
public class GoogleComputeRegionNetworkEndpointGroupDataSource : TerraformDataSource
{
    public GoogleComputeRegionNetworkEndpointGroupDataSource(string name) : base("google_compute_region_network_endpoint_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

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
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// A reference to the region where the regional NEGs reside.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SelfLink { get; set; }

    /// <summary>
    /// This field is only used for SERVERLESS NEGs.
    /// 
    /// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
    /// </summary>
    [TerraformPropertyName("app_engine")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AppEngine => new TerraformReference(this, "app_engine");

    /// <summary>
    /// This field is only used for SERVERLESS NEGs.
    /// 
    /// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
    /// </summary>
    [TerraformPropertyName("cloud_function")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CloudFunction => new TerraformReference(this, "cloud_function");

    /// <summary>
    /// This field is only used for SERVERLESS NEGs.
    /// 
    /// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
    /// </summary>
    [TerraformPropertyName("cloud_run")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CloudRun => new TerraformReference(this, "cloud_run");

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// This field is only used for PSC and INTERNET NEGs.
    /// 
    /// The URL of the network to which all network endpoints in the NEG belong. Uses
    /// &amp;quot;default&amp;quot; project network if unspecified.
    /// </summary>
    [TerraformPropertyName("network")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Network => new TerraformReference(this, "network");

    /// <summary>
    /// Type of network endpoints in this network endpoint group. Defaults to SERVERLESS. Default value: &amp;quot;SERVERLESS&amp;quot; Possible values: [&amp;quot;SERVERLESS&amp;quot;, &amp;quot;PRIVATE_SERVICE_CONNECT&amp;quot;, &amp;quot;INTERNET_IP_PORT&amp;quot;, &amp;quot;INTERNET_FQDN_PORT&amp;quot;, &amp;quot;GCE_VM_IP_PORTMAP&amp;quot;]
    /// </summary>
    [TerraformPropertyName("network_endpoint_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NetworkEndpointType => new TerraformReference(this, "network_endpoint_type");

    /// <summary>
    /// This field is only used for PSC NEGs.
    /// </summary>
    [TerraformPropertyName("psc_data")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PscData => new TerraformReference(this, "psc_data");

    /// <summary>
    /// This field is only used for PSC and INTERNET NEGs.
    /// 
    /// The target service url used to set up private service connection to
    /// a Google API or a PSC Producer Service Attachment.
    /// </summary>
    [TerraformPropertyName("psc_target_service")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PscTargetService => new TerraformReference(this, "psc_target_service");

    /// <summary>
    /// This field is only used for PSC NEGs.
    /// 
    /// Optional URL of the subnetwork to which all network endpoints in the NEG belong.
    /// </summary>
    [TerraformPropertyName("subnetwork")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Subnetwork => new TerraformReference(this, "subnetwork");

}
