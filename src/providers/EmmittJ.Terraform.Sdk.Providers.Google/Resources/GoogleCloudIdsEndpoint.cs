using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCloudIdsEndpointTimeoutsBlock
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
/// Manages a google_cloud_ids_endpoint resource.
/// </summary>
public class GoogleCloudIdsEndpoint : TerraformResource
{
    public GoogleCloudIdsEndpoint(string name) : base("google_cloud_ids_endpoint", name)
    {
    }

    /// <summary>
    /// An optional description of the endpoint.
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
    /// The location for the endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Name of the endpoint in the format projects/{project_id}/locations/{locationId}/endpoints/{endpointId}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Name of the VPC network that is connected to the IDS endpoint. This can either contain the VPC network name itself (like &amp;quot;src-net&amp;quot;) or the full URL to the network (like &amp;quot;projects/{project_id}/global/networks/src-net&amp;quot;).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    [TerraformPropertyName("network")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Network { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The minimum alert severity level that is reported by the endpoint. Possible values: [&amp;quot;INFORMATIONAL&amp;quot;, &amp;quot;LOW&amp;quot;, &amp;quot;MEDIUM&amp;quot;, &amp;quot;HIGH&amp;quot;, &amp;quot;CRITICAL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Severity is required")]
    [TerraformPropertyName("severity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Severity { get; set; }

    /// <summary>
    /// Configuration for threat IDs excluded from generating alerts. Limit: 99 IDs.
    /// </summary>
    [TerraformPropertyName("threat_exceptions")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? ThreatExceptions { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleCloudIdsEndpointTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Creation timestamp in RFC 3339 text format.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// URL of the endpoint&#39;s network address to which traffic is to be sent by Packet Mirroring.
    /// </summary>
    [TerraformPropertyName("endpoint_forwarding_rule")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EndpointForwardingRule => new TerraformReference(this, "endpoint_forwarding_rule");

    /// <summary>
    /// Internal IP address of the endpoint&#39;s network entry point.
    /// </summary>
    [TerraformPropertyName("endpoint_ip")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EndpointIp => new TerraformReference(this, "endpoint_ip");

    /// <summary>
    /// Last update timestamp in RFC 3339 text format.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
