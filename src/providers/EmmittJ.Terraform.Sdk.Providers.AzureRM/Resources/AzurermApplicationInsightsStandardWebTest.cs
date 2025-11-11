using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for request in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationInsightsStandardWebTestRequestBlock
{
    /// <summary>
    /// The body attribute.
    /// </summary>
    [TerraformPropertyName("body")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Body { get; set; }

    /// <summary>
    /// The follow_redirects_enabled attribute.
    /// </summary>
    [TerraformPropertyName("follow_redirects_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? FollowRedirectsEnabled { get; set; }

    /// <summary>
    /// The http_verb attribute.
    /// </summary>
    [TerraformPropertyName("http_verb")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HttpVerb { get; set; }

    /// <summary>
    /// The parse_dependent_requests_enabled attribute.
    /// </summary>
    [TerraformPropertyName("parse_dependent_requests_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ParseDependentRequestsEnabled { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformPropertyName("url")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Url { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApplicationInsightsStandardWebTestTimeoutsBlock
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
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for validation_rules in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationInsightsStandardWebTestValidationRulesBlock
{
    /// <summary>
    /// The expected_status_code attribute.
    /// </summary>
    [TerraformPropertyName("expected_status_code")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? ExpectedStatusCode { get; set; }

    /// <summary>
    /// The ssl_cert_remaining_lifetime attribute.
    /// </summary>
    [TerraformPropertyName("ssl_cert_remaining_lifetime")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? SslCertRemainingLifetime { get; set; }

    /// <summary>
    /// The ssl_check_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ssl_check_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SslCheckEnabled { get; set; }

}

/// <summary>
/// Manages a azurerm_application_insights_standard_web_test resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermApplicationInsightsStandardWebTest : TerraformResource
{
    public AzurermApplicationInsightsStandardWebTest(string name) : base("azurerm_application_insights_standard_web_test", name)
    {
    }

    /// <summary>
    /// The application_insights_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationInsightsId is required")]
    [TerraformPropertyName("application_insights_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ApplicationInsightsId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [TerraformPropertyName("frequency")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Frequency { get; set; }

    /// <summary>
    /// The geo_locations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GeoLocations is required")]
    [TerraformPropertyName("geo_locations")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? GeoLocations { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The retry_enabled attribute.
    /// </summary>
    [TerraformPropertyName("retry_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RetryEnabled { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformPropertyName("timeout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Timeout { get; set; }

    /// <summary>
    /// Block for request.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Request is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Request block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Request block(s) allowed")]
    [TerraformPropertyName("request")]
    public TerraformList<TerraformBlock<AzurermApplicationInsightsStandardWebTestRequestBlock>>? Request { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermApplicationInsightsStandardWebTestTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for validation_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ValidationRules block(s) allowed")]
    [TerraformPropertyName("validation_rules")]
    public TerraformList<TerraformBlock<AzurermApplicationInsightsStandardWebTestValidationRulesBlock>>? ValidationRules { get; set; }

    /// <summary>
    /// The synthetic_monitor_id attribute.
    /// </summary>
    [TerraformPropertyName("synthetic_monitor_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SyntheticMonitorId => new TerraformReference(this, "synthetic_monitor_id");

}
