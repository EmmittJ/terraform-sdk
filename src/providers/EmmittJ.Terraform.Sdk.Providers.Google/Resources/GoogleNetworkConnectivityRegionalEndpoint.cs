using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleNetworkConnectivityRegionalEndpointTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_network_connectivity_regional_endpoint resource.
/// </summary>
public partial class GoogleNetworkConnectivityRegionalEndpoint : TerraformResource
{
    public GoogleNetworkConnectivityRegionalEndpoint(string name) : base("google_network_connectivity_regional_endpoint", name)
    {
    }

    /// <summary>
    /// The access type of this regional endpoint. This field is reflected in the PSC Forwarding Rule configuration to enable global access. Possible values: [&amp;quot;GLOBAL&amp;quot;, &amp;quot;REGIONAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessType is required")]
    [TerraformProperty("access_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AccessType { get; set; }

    /// <summary>
    /// The IP Address of the Regional Endpoint. When no address is provided, an IP from the subnetwork is allocated. Use one of the following formats: * IPv4 address as in &#39;10.0.0.1&#39; * Address resource URI as in &#39;projects/{project}/regions/{region}/addresses/{address_name}&#39;
    /// 
    /// ~&amp;gt; **Note:** This field accepts both a reference to a Compute Address resource, which is the resource name of which format is given in the description, and IP literal value. If the user chooses to input a reserved address value; they need to make sure that the reserved address is in IPv4 version, its purpose is GCE_ENDPOINT, its type is INTERNAL and its status is RESERVED. If the user chooses to input an IP literal, they need to make sure that it&#39;s a valid IPv4 address (x.x.x.x) within the subnetwork.
    /// </summary>
    [TerraformProperty("address")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Address { get; set; }

    /// <summary>
    /// A description of this resource.
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
    /// User-defined labels.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location of the RegionalEndpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name of the RegionalEndpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name of the VPC network for this private regional endpoint. Format: &#39;projects/{project}/global/networks/{network}&#39;
    /// </summary>
    [TerraformProperty("network")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Network { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The name of the subnetwork from which the IP address will be allocated. Format: &#39;projects/{project}/regions/{region}/subnetworks/{subnetwork}&#39;
    /// </summary>
    [TerraformProperty("subnetwork")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Subnetwork { get; set; }

    /// <summary>
    /// The service endpoint this private regional endpoint connects to. Format: &#39;{apiname}.{region}.rep.googleapis.com&#39; Example: \&amp;quot;cloudkms.us-central1.rep.googleapis.com\&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetGoogleApi is required")]
    [TerraformProperty("target_google_api")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TargetGoogleApi { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleNetworkConnectivityRegionalEndpointTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Time when the RegionalEndpoint was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The resource reference of the PSC Forwarding Rule created on behalf of the customer. Format: &#39;//compute.googleapis.com/projects/{project}/regions/{region}/forwardingRules/{forwarding_rule_name}&#39;
    /// </summary>
    [TerraformProperty("psc_forwarding_rule")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PscForwardingRule { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// Time when the RegionalEndpoint was updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
