using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for hubs in .
/// Nesting mode: set
/// </summary>
public partial class GoogleBeyondcorpSecurityGatewayHubsBlock() : TerraformBlock("hubs")
{
    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    [TerraformProperty("region")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Region { get; set; }

}

/// <summary>
/// Block type for proxy_protocol_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBeyondcorpSecurityGatewayProxyProtocolConfigBlock() : TerraformBlock("proxy_protocol_config")
{
    /// <summary>
    /// The configuration for the proxy.
    /// </summary>
    [TerraformProperty("allowed_client_headers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AllowedClientHeaders { get; set; }

    /// <summary>
    /// Client IP configuration. The client IP address is included if true.
    /// </summary>
    [TerraformProperty("client_ip")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ClientIp { get; set; }

    /// <summary>
    /// Gateway identity configuration. Possible values: [&amp;quot;RESOURCE_NAME&amp;quot;]
    /// </summary>
    [TerraformProperty("gateway_identity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GatewayIdentity { get; set; }

    /// <summary>
    /// Custom resource specific headers along with the values.
    /// The names should conform to RFC 9110:
    /// &amp;gt; Field names SHOULD constrain themselves to alphanumeric characters, &amp;quot;-&amp;quot;,
    ///   and &amp;quot;.&amp;quot;, and SHOULD begin with a letter.
    /// &amp;gt; Field values SHOULD contain only ASCII printable characters and tab.
    /// </summary>
    [TerraformProperty("metadata_headers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? MetadataHeaders { get; set; }

}

/// <summary>
/// Block type for service_discovery in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBeyondcorpSecurityGatewayServiceDiscoveryBlock() : TerraformBlock("service_discovery")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBeyondcorpSecurityGatewayTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_beyondcorp_security_gateway resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleBeyondcorpSecurityGateway : TerraformResource
{
    public GoogleBeyondcorpSecurityGateway(string name) : base("google_beyondcorp_security_gateway", name)
    {
    }

    /// <summary>
    /// Optional. An arbitrary user-provided name for the SecurityGateway.
    /// Cannot exceed 64 characters.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122. Must be omitted or set to &#39;global&#39;.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Optional. User-settable SecurityGateway resource ID.
    /// * Must start with a letter.
    /// * Must contain between 4-63 characters from &#39;/a-z-/&#39;.
    /// * Must end with a number or letter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGatewayId is required")]
    [TerraformProperty("security_gateway_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SecurityGatewayId { get; set; }

    /// <summary>
    /// Block for hubs.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("hubs")]
    public TerraformSet<GoogleBeyondcorpSecurityGatewayHubsBlock> Hubs { get; set; } = new();

    /// <summary>
    /// Block for proxy_protocol_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProxyProtocolConfig block(s) allowed")]
    [TerraformProperty("proxy_protocol_config")]
    public TerraformList<GoogleBeyondcorpSecurityGatewayProxyProtocolConfigBlock> ProxyProtocolConfig { get; set; } = new();

    /// <summary>
    /// Block for service_discovery.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceDiscovery block(s) allowed")]
    [TerraformProperty("service_discovery")]
    public TerraformList<GoogleBeyondcorpSecurityGatewayServiceDiscoveryBlock> ServiceDiscovery { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleBeyondcorpSecurityGatewayTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. Timestamp when the resource was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Service account used for operations that involve resources in consumer projects.
    /// </summary>
    [TerraformProperty("delegating_service_account")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DelegatingServiceAccount { get; }

    /// <summary>
    /// Output only. IP addresses that will be used for establishing
    /// connection to the endpoints.
    /// </summary>
    [TerraformProperty("external_ips")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ExternalIps { get; }

    /// <summary>
    /// Identifier. Name of the resource.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. The operational state of the SecurityGateway.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// CREATING
    /// UPDATING
    /// DELETING
    /// RUNNING
    /// DOWN
    /// ERROR
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// Output only. Timestamp when the resource was last modified.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
