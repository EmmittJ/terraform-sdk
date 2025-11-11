using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for endpoint_matchers in .
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayApplicationEndpointMatchersBlock
{
    /// <summary>
    /// Required. Hostname of the application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformPropertyName("hostname")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Hostname { get; set; }

    /// <summary>
    /// Optional. Ports of the application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ports is required")]
    [TerraformPropertyName("ports")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<double>? Ports { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBeyondcorpSecurityGatewayApplicationTimeoutsBlock
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
/// Block type for upstreams in .
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlock
{
}

/// <summary>
/// Manages a google_beyondcorp_security_gateway_application resource.
/// </summary>
public class GoogleBeyondcorpSecurityGatewayApplication : TerraformResource
{
    public GoogleBeyondcorpSecurityGatewayApplication(string name) : base("google_beyondcorp_security_gateway_application", name)
    {
    }

    /// <summary>
    /// User-settable Application resource ID.
    /// * Must start with a letter.
    /// * Must contain between 4-63 characters from &#39;/a-z-/&#39;.
    /// * Must end with a number or letter.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    [TerraformPropertyName("application_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ApplicationId { get; set; }

    /// <summary>
    /// Optional. An arbitrary user-provided name for the Application resource.
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
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Type of the external application. Possible values: [&amp;quot;PROXY_GATEWAY&amp;quot;, &amp;quot;API_GATEWAY&amp;quot;]
    /// </summary>
    [TerraformPropertyName("schema")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Schema { get; set; }

    /// <summary>
    /// ID of the Security Gateway resource this belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGatewayId is required")]
    [TerraformPropertyName("security_gateway_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SecurityGatewayId { get; set; }

    /// <summary>
    /// Block for endpoint_matchers.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("endpoint_matchers")]
    public TerraformList<TerraformBlock<GoogleBeyondcorpSecurityGatewayApplicationEndpointMatchersBlock>>? EndpointMatchers { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBeyondcorpSecurityGatewayApplicationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for upstreams.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("upstreams")]
    public TerraformList<TerraformBlock<GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlock>>? Upstreams { get; set; }

    /// <summary>
    /// Output only. Timestamp when the resource was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// Identifier. Name of the resource.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// Output only. Timestamp when the resource was last modified.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
