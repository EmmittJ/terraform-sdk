using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for request in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationInsightsStandardWebTestRequestBlock : TerraformBlock
{
    /// <summary>
    /// The body attribute.
    /// </summary>
    public TerraformProperty<string>? Body
    {
        get => GetProperty<TerraformProperty<string>>("body");
        set => WithProperty("body", value);
    }

    /// <summary>
    /// The follow_redirects_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FollowRedirectsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("follow_redirects_enabled");
        set => WithProperty("follow_redirects_enabled", value);
    }

    /// <summary>
    /// The http_verb attribute.
    /// </summary>
    public TerraformProperty<string>? HttpVerb
    {
        get => GetProperty<TerraformProperty<string>>("http_verb");
        set => WithProperty("http_verb", value);
    }

    /// <summary>
    /// The parse_dependent_requests_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ParseDependentRequestsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("parse_dependent_requests_enabled");
        set => WithProperty("parse_dependent_requests_enabled", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        get => GetRequiredProperty<TerraformProperty<string>>("url");
        set => WithProperty("url", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApplicationInsightsStandardWebTestTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for validation_rules in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationInsightsStandardWebTestValidationRulesBlock : TerraformBlock
{
    /// <summary>
    /// The expected_status_code attribute.
    /// </summary>
    public TerraformProperty<double>? ExpectedStatusCode
    {
        get => GetProperty<TerraformProperty<double>>("expected_status_code");
        set => WithProperty("expected_status_code", value);
    }

    /// <summary>
    /// The ssl_cert_remaining_lifetime attribute.
    /// </summary>
    public TerraformProperty<double>? SslCertRemainingLifetime
    {
        get => GetProperty<TerraformProperty<double>>("ssl_cert_remaining_lifetime");
        set => WithProperty("ssl_cert_remaining_lifetime", value);
    }

    /// <summary>
    /// The ssl_check_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SslCheckEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("ssl_check_enabled");
        set => WithProperty("ssl_check_enabled", value);
    }

}

/// <summary>
/// Manages a azurerm_application_insights_standard_web_test resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermApplicationInsightsStandardWebTest : TerraformResource
{
    public AzurermApplicationInsightsStandardWebTest(string name) : base("azurerm_application_insights_standard_web_test", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutputynthetic_monitor_id");
    }

    /// <summary>
    /// The application_insights_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationInsightsId is required")]
    public required TerraformProperty<string> ApplicationInsightsId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("application_insights_id");
        set => this.WithProperty("application_insights_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformProperty<double>? Frequency
    {
        get => GetProperty<TerraformProperty<double>>("frequency");
        set => this.WithProperty("frequency", value);
    }

    /// <summary>
    /// The geo_locations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GeoLocations is required")]
    public List<TerraformProperty<string>>? GeoLocations
    {
        get => GetProperty<List<TerraformProperty<string>>>("geo_locations");
        set => this.WithProperty("geo_locations", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The retry_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RetryEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("retry_enabled");
        set => this.WithProperty("retry_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<double>? Timeout
    {
        get => GetProperty<TerraformProperty<double>>("timeout");
        set => this.WithProperty("timeout", value);
    }

    /// <summary>
    /// Block for request.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Request block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Request block(s) allowed")]
    public List<AzurermApplicationInsightsStandardWebTestRequestBlock>? Request
    {
        get => GetProperty<List<AzurermApplicationInsightsStandardWebTestRequestBlock>>("request");
        set => this.WithProperty("request", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApplicationInsightsStandardWebTestTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermApplicationInsightsStandardWebTestTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for validation_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ValidationRules block(s) allowed")]
    public List<AzurermApplicationInsightsStandardWebTestValidationRulesBlock>? ValidationRules
    {
        get => GetProperty<List<AzurermApplicationInsightsStandardWebTestValidationRulesBlock>>("validation_rules");
        set => this.WithProperty("validation_rules", value);
    }

    /// <summary>
    /// The synthetic_monitor_id attribute.
    /// </summary>
    public TerraformExpression SyntheticMonitorId => this["synthetic_monitor_id"];

}
