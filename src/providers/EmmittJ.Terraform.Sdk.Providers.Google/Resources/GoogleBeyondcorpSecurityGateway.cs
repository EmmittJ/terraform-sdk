using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for hubs in .
/// Nesting mode: set
/// </summary>
public class GoogleBeyondcorpSecurityGatewayHubsBlock
{
    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    [TerraformPropertyName("region")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Region { get; set; }

}

/// <summary>
/// Block type for proxy_protocol_config in .
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayProxyProtocolConfigBlock
{
    /// <summary>
    /// The configuration for the proxy.
    /// </summary>
    [TerraformPropertyName("allowed_client_headers")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? AllowedClientHeaders { get; set; }

    /// <summary>
    /// Client IP configuration. The client IP address is included if true.
    /// </summary>
    [TerraformPropertyName("client_ip")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ClientIp { get; set; }

    /// <summary>
    /// Gateway identity configuration. Possible values: [&amp;quot;RESOURCE_NAME&amp;quot;]
    /// </summary>
    [TerraformPropertyName("gateway_identity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GatewayIdentity { get; set; }

    /// <summary>
    /// Custom resource specific headers along with the values.
    /// The names should conform to RFC 9110:
    /// &amp;gt; Field names SHOULD constrain themselves to alphanumeric characters, &amp;quot;-&amp;quot;,
    ///   and &amp;quot;.&amp;quot;, and SHOULD begin with a letter.
    /// &amp;gt; Field values SHOULD contain only ASCII printable characters and tab.
    /// </summary>
    [TerraformPropertyName("metadata_headers")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? MetadataHeaders { get; set; }

}

/// <summary>
/// Block type for service_discovery in .
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayServiceDiscoveryBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBeyondcorpSecurityGatewayTimeoutsBlock
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
/// Manages a google_beyondcorp_security_gateway resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBeyondcorpSecurityGateway : TerraformResource
{
    public GoogleBeyondcorpSecurityGateway(string name) : base("google_beyondcorp_security_gateway", name)
    {
    }

    /// <summary>
    /// Optional. An arbitrary user-provided name for the SecurityGateway.
    /// Cannot exceed 64 characters.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122. Must be omitted or set to &#39;global&#39;.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Optional. User-settable SecurityGateway resource ID.
    /// * Must start with a letter.
    /// * Must contain between 4-63 characters from &#39;/a-z-/&#39;.
    /// * Must end with a number or letter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGatewayId is required")]
    [TerraformPropertyName("security_gateway_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SecurityGatewayId { get; set; }

    /// <summary>
    /// Block for hubs.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("hubs")]
    public TerraformSet<TerraformBlock<GoogleBeyondcorpSecurityGatewayHubsBlock>>? Hubs { get; set; }

    /// <summary>
    /// Block for proxy_protocol_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProxyProtocolConfig block(s) allowed")]
    [TerraformPropertyName("proxy_protocol_config")]
    public TerraformList<TerraformBlock<GoogleBeyondcorpSecurityGatewayProxyProtocolConfigBlock>>? ProxyProtocolConfig { get; set; }

    /// <summary>
    /// Block for service_discovery.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceDiscovery block(s) allowed")]
    [TerraformPropertyName("service_discovery")]
    public TerraformList<TerraformBlock<GoogleBeyondcorpSecurityGatewayServiceDiscoveryBlock>>? ServiceDiscovery { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBeyondcorpSecurityGatewayTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. Timestamp when the resource was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// Service account used for operations that involve resources in consumer projects.
    /// </summary>
    [TerraformPropertyName("delegating_service_account")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DelegatingServiceAccount => new TerraformReference(this, "delegating_service_account");

    /// <summary>
    /// Output only. IP addresses that will be used for establishing
    /// connection to the endpoints.
    /// </summary>
    [TerraformPropertyName("external_ips")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ExternalIps => new TerraformReference(this, "external_ips");

    /// <summary>
    /// Identifier. Name of the resource.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

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
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// Output only. Timestamp when the resource was last modified.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
