using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkConnectivityRegionalEndpointTimeoutsBlock
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
/// Manages a google_network_connectivity_regional_endpoint resource.
/// </summary>
public class GoogleNetworkConnectivityRegionalEndpoint : TerraformResource
{
    public GoogleNetworkConnectivityRegionalEndpoint(string name) : base("google_network_connectivity_regional_endpoint", name)
    {
    }

    /// <summary>
    /// The access type of this regional endpoint. This field is reflected in the PSC Forwarding Rule configuration to enable global access. Possible values: [&amp;quot;GLOBAL&amp;quot;, &amp;quot;REGIONAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessType is required")]
    [TerraformPropertyName("access_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AccessType { get; set; }

    /// <summary>
    /// The IP Address of the Regional Endpoint. When no address is provided, an IP from the subnetwork is allocated. Use one of the following formats: * IPv4 address as in &#39;10.0.0.1&#39; * Address resource URI as in &#39;projects/{project}/regions/{region}/addresses/{address_name}&#39;
    /// 
    /// ~&amp;gt; **Note:** This field accepts both a reference to a Compute Address resource, which is the resource name of which format is given in the description, and IP literal value. If the user chooses to input a reserved address value; they need to make sure that the reserved address is in IPv4 version, its purpose is GCE_ENDPOINT, its type is INTERNAL and its status is RESERVED. If the user chooses to input an IP literal, they need to make sure that it&#39;s a valid IPv4 address (x.x.x.x) within the subnetwork.
    /// </summary>
    [TerraformPropertyName("address")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Address { get; set; } = default!;

    /// <summary>
    /// A description of this resource.
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
    /// User-defined labels.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The location of the RegionalEndpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name of the RegionalEndpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name of the VPC network for this private regional endpoint. Format: &#39;projects/{project}/global/networks/{network}&#39;
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Network { get; set; } = default!;

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The name of the subnetwork from which the IP address will be allocated. Format: &#39;projects/{project}/regions/{region}/subnetworks/{subnetwork}&#39;
    /// </summary>
    [TerraformPropertyName("subnetwork")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Subnetwork { get; set; } = default!;

    /// <summary>
    /// The service endpoint this private regional endpoint connects to. Format: &#39;{apiname}.{region}.rep.googleapis.com&#39; Example: \&amp;quot;cloudkms.us-central1.rep.googleapis.com\&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetGoogleApi is required")]
    [TerraformPropertyName("target_google_api")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TargetGoogleApi { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleNetworkConnectivityRegionalEndpointTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Time when the RegionalEndpoint was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The resource reference of the PSC Forwarding Rule created on behalf of the customer. Format: &#39;//compute.googleapis.com/projects/{project}/regions/{region}/forwardingRules/{forwarding_rule_name}&#39;
    /// </summary>
    [TerraformPropertyName("psc_forwarding_rule")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PscForwardingRule => new TerraformReference(this, "psc_forwarding_rule");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

    /// <summary>
    /// Time when the RegionalEndpoint was updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
