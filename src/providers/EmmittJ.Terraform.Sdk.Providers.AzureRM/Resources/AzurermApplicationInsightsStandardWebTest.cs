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
        set => SetProperty("body", value);
    }

    /// <summary>
    /// The follow_redirects_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FollowRedirectsEnabled
    {
        set => SetProperty("follow_redirects_enabled", value);
    }

    /// <summary>
    /// The http_verb attribute.
    /// </summary>
    public TerraformProperty<string>? HttpVerb
    {
        set => SetProperty("http_verb", value);
    }

    /// <summary>
    /// The parse_dependent_requests_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ParseDependentRequestsEnabled
    {
        set => SetProperty("parse_dependent_requests_enabled", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        set => SetProperty("url", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("expected_status_code", value);
    }

    /// <summary>
    /// The ssl_cert_remaining_lifetime attribute.
    /// </summary>
    public TerraformProperty<double>? SslCertRemainingLifetime
    {
        set => SetProperty("ssl_cert_remaining_lifetime", value);
    }

    /// <summary>
    /// The ssl_check_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SslCheckEnabled
    {
        set => SetProperty("ssl_check_enabled", value);
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
        SetOutput("synthetic_monitor_id");
        SetOutput("application_insights_id");
        SetOutput("description");
        SetOutput("enabled");
        SetOutput("frequency");
        SetOutput("geo_locations");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("retry_enabled");
        SetOutput("tags");
        SetOutput("timeout");
    }

    /// <summary>
    /// The application_insights_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationInsightsId is required")]
    public required TerraformProperty<string> ApplicationInsightsId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_insights_id");
        set => SetProperty("application_insights_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformProperty<double> Frequency
    {
        get => GetRequiredOutput<TerraformProperty<double>>("frequency");
        set => SetProperty("frequency", value);
    }

    /// <summary>
    /// The geo_locations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GeoLocations is required")]
    public List<TerraformProperty<string>> GeoLocations
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("geo_locations");
        set => SetProperty("geo_locations", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The retry_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> RetryEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("retry_enabled");
        set => SetProperty("retry_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<double> Timeout
    {
        get => GetRequiredOutput<TerraformProperty<double>>("timeout");
        set => SetProperty("timeout", value);
    }

    /// <summary>
    /// Block for request.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Request is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Request block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Request block(s) allowed")]
    public List<AzurermApplicationInsightsStandardWebTestRequestBlock>? Request
    {
        set => SetProperty("request", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApplicationInsightsStandardWebTestTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for validation_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ValidationRules block(s) allowed")]
    public List<AzurermApplicationInsightsStandardWebTestValidationRulesBlock>? ValidationRules
    {
        set => SetProperty("validation_rules", value);
    }

    /// <summary>
    /// The synthetic_monitor_id attribute.
    /// </summary>
    public TerraformExpression SyntheticMonitorId => this["synthetic_monitor_id"];

}
