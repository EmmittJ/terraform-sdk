using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_region_network_endpoint_group.
/// </summary>
public partial class GoogleComputeRegionNetworkEndpointGroupDataSource : TerraformDataSource
{
    public GoogleComputeRegionNetworkEndpointGroupDataSource(string name) : base("google_compute_region_network_endpoint_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Name of the resource; provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// A reference to the region where the regional NEGs reside.
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SelfLink { get; set; }

    /// <summary>
    /// This field is only used for SERVERLESS NEGs.
    /// 
    /// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
    /// </summary>
    [TerraformProperty("app_engine")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AppEngine { get; }

    /// <summary>
    /// This field is only used for SERVERLESS NEGs.
    /// 
    /// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
    /// </summary>
    [TerraformProperty("cloud_function")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CloudFunction { get; }

    /// <summary>
    /// This field is only used for SERVERLESS NEGs.
    /// 
    /// Only one of cloud_run, app_engine, cloud_function or serverless_deployment may be set.
    /// </summary>
    [TerraformProperty("cloud_run")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CloudRun { get; }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// This field is only used for PSC and INTERNET NEGs.
    /// 
    /// The URL of the network to which all network endpoints in the NEG belong. Uses
    /// &amp;quot;default&amp;quot; project network if unspecified.
    /// </summary>
    [TerraformProperty("network")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Network { get; }

    /// <summary>
    /// Type of network endpoints in this network endpoint group. Defaults to SERVERLESS. Default value: &amp;quot;SERVERLESS&amp;quot; Possible values: [&amp;quot;SERVERLESS&amp;quot;, &amp;quot;PRIVATE_SERVICE_CONNECT&amp;quot;, &amp;quot;INTERNET_IP_PORT&amp;quot;, &amp;quot;INTERNET_FQDN_PORT&amp;quot;, &amp;quot;GCE_VM_IP_PORTMAP&amp;quot;]
    /// </summary>
    [TerraformProperty("network_endpoint_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NetworkEndpointType { get; }

    /// <summary>
    /// This field is only used for PSC NEGs.
    /// </summary>
    [TerraformProperty("psc_data")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PscData { get; }

    /// <summary>
    /// This field is only used for PSC and INTERNET NEGs.
    /// 
    /// The target service url used to set up private service connection to
    /// a Google API or a PSC Producer Service Attachment.
    /// </summary>
    [TerraformProperty("psc_target_service")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PscTargetService { get; }

    /// <summary>
    /// This field is only used for PSC NEGs.
    /// 
    /// Optional URL of the subnetwork to which all network endpoints in the NEG belong.
    /// </summary>
    [TerraformProperty("subnetwork")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Subnetwork { get; }

}
