using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for endpoint_matchers in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBeyondcorpSecurityGatewayApplicationEndpointMatchersBlock() : TerraformBlock("endpoint_matchers")
{
    /// <summary>
    /// Required. Hostname of the application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformProperty("hostname")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Hostname { get; set; }

    /// <summary>
    /// Optional. Ports of the application.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ports is required")]
    [TerraformProperty("ports")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<double>? Ports { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBeyondcorpSecurityGatewayApplicationTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Block type for upstreams in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlock() : TerraformBlock("upstreams")
{
}

/// <summary>
/// Manages a google_beyondcorp_security_gateway_application resource.
/// </summary>
public partial class GoogleBeyondcorpSecurityGatewayApplication : TerraformResource
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
    [TerraformProperty("application_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApplicationId { get; set; }

    /// <summary>
    /// Optional. An arbitrary user-provided name for the Application resource.
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
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Type of the external application. Possible values: [&amp;quot;PROXY_GATEWAY&amp;quot;, &amp;quot;API_GATEWAY&amp;quot;]
    /// </summary>
    [TerraformProperty("schema")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Schema { get; set; }

    /// <summary>
    /// ID of the Security Gateway resource this belongs to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGatewayId is required")]
    [TerraformProperty("security_gateway_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SecurityGatewayId { get; set; }

    /// <summary>
    /// Block for endpoint_matchers.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("endpoint_matchers")]
    public TerraformList<GoogleBeyondcorpSecurityGatewayApplicationEndpointMatchersBlock> EndpointMatchers { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleBeyondcorpSecurityGatewayApplicationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for upstreams.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("upstreams")]
    public TerraformList<GoogleBeyondcorpSecurityGatewayApplicationUpstreamsBlock> Upstreams { get; set; } = new();

    /// <summary>
    /// Output only. Timestamp when the resource was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Identifier. Name of the resource.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. Timestamp when the resource was last modified.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
