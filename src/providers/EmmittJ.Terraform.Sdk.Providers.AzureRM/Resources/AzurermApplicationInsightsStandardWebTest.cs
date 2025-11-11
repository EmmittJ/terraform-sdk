using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for request in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApplicationInsightsStandardWebTestRequestBlock : TerraformBlockBase
{
    /// <summary>
    /// The body attribute.
    /// </summary>
    [TerraformProperty("body")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Body { get; set; }

    /// <summary>
    /// The follow_redirects_enabled attribute.
    /// </summary>
    [TerraformProperty("follow_redirects_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? FollowRedirectsEnabled { get; set; }

    /// <summary>
    /// The http_verb attribute.
    /// </summary>
    [TerraformProperty("http_verb")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HttpVerb { get; set; }

    /// <summary>
    /// The parse_dependent_requests_enabled attribute.
    /// </summary>
    [TerraformProperty("parse_dependent_requests_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ParseDependentRequestsEnabled { get; set; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformProperty("url")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Url { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermApplicationInsightsStandardWebTestTimeoutsBlock : TerraformBlockBase
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
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for validation_rules in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApplicationInsightsStandardWebTestValidationRulesBlock : TerraformBlockBase
{
    /// <summary>
    /// The expected_status_code attribute.
    /// </summary>
    [TerraformProperty("expected_status_code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? ExpectedStatusCode { get; set; }

    /// <summary>
    /// The ssl_cert_remaining_lifetime attribute.
    /// </summary>
    [TerraformProperty("ssl_cert_remaining_lifetime")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SslCertRemainingLifetime { get; set; }

    /// <summary>
    /// The ssl_check_enabled attribute.
    /// </summary>
    [TerraformProperty("ssl_check_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SslCheckEnabled { get; set; }

}

/// <summary>
/// Manages a azurerm_application_insights_standard_web_test resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermApplicationInsightsStandardWebTest : TerraformResource
{
    public AzurermApplicationInsightsStandardWebTest(string name) : base("azurerm_application_insights_standard_web_test", name)
    {
    }

    /// <summary>
    /// The application_insights_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationInsightsId is required")]
    [TerraformProperty("application_insights_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApplicationInsightsId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [TerraformProperty("frequency")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Frequency { get; set; }

    /// <summary>
    /// The geo_locations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GeoLocations is required")]
    [TerraformProperty("geo_locations")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? GeoLocations { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The retry_enabled attribute.
    /// </summary>
    [TerraformProperty("retry_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RetryEnabled { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformProperty("timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Timeout { get; set; }

    /// <summary>
    /// Block for request.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Request is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Request block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Request block(s) allowed")]
    [TerraformProperty("request")]
    public partial TerraformList<TerraformBlock<AzurermApplicationInsightsStandardWebTestRequestBlock>>? Request { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermApplicationInsightsStandardWebTestTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for validation_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ValidationRules block(s) allowed")]
    [TerraformProperty("validation_rules")]
    public partial TerraformList<TerraformBlock<AzurermApplicationInsightsStandardWebTestValidationRulesBlock>>? ValidationRules { get; set; }

    /// <summary>
    /// The synthetic_monitor_id attribute.
    /// </summary>
    [TerraformProperty("synthetic_monitor_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SyntheticMonitorId { get; }

}
