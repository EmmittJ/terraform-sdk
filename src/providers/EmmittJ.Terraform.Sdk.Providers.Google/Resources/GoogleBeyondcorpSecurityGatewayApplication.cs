using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for endpoint_matchers in .
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayApplicationEndpointMatchersBlock : ITerraformBlock
{
    /// <summary>
    /// Required. Hostname of the application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformPropertyName("hostname")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Hostname { get; set; }

    /// <summary>
    /// Optional. Ports of the application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ports is required")]
    [TerraformPropertyName("ports")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<double>>>? Ports { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBeyondcorpSecurityGatewayApplicationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for upstreams in .
/// Nesting mode: list
/// </summary>
public class GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlock : ITerraformBlock
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
    public required TerraformProperty<TerraformProperty<string>> ApplicationId { get; set; }

    /// <summary>
    /// Optional. An arbitrary user-provided name for the Application resource.
    /// Cannot exceed 64 characters.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Type of the external application. Possible values: [&amp;quot;PROXY_GATEWAY&amp;quot;, &amp;quot;API_GATEWAY&amp;quot;]
    /// </summary>
    [TerraformPropertyName("schema")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Schema { get; set; }

    /// <summary>
    /// ID of the Security Gateway resource this belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGatewayId is required")]
    [TerraformPropertyName("security_gateway_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SecurityGatewayId { get; set; }

    /// <summary>
    /// Block for endpoint_matchers.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("endpoint_matchers")]
    public TerraformList<TerraformBlock<GoogleBeyondcorpSecurityGatewayApplicationEndpointMatchersBlock>>? EndpointMatchers { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBeyondcorpSecurityGatewayApplicationTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for upstreams.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("upstreams")]
    public TerraformList<TerraformBlock<GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlock>>? Upstreams { get; set; } = new();

    /// <summary>
    /// Output only. Timestamp when the resource was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Identifier. Name of the resource.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Output only. Timestamp when the resource was last modified.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
