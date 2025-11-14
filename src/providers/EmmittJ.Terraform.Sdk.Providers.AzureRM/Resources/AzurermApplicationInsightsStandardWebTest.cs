using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for request in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationInsightsStandardWebTestRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "request";

    /// <summary>
    /// The body attribute.
    /// </summary>
    [TerraformArgument("body")]
    public TerraformValue<string>? Body
    {
        get => new TerraformReference<string>(this, "body");
        set => SetArgument("body", value);
    }

    /// <summary>
    /// The follow_redirects_enabled attribute.
    /// </summary>
    [TerraformArgument("follow_redirects_enabled")]
    public TerraformValue<bool>? FollowRedirectsEnabled
    {
        get => new TerraformReference<bool>(this, "follow_redirects_enabled");
        set => SetArgument("follow_redirects_enabled", value);
    }

    /// <summary>
    /// The http_verb attribute.
    /// </summary>
    [TerraformArgument("http_verb")]
    public TerraformValue<string>? HttpVerb
    {
        get => new TerraformReference<string>(this, "http_verb");
        set => SetArgument("http_verb", value);
    }

    /// <summary>
    /// The parse_dependent_requests_enabled attribute.
    /// </summary>
    [TerraformArgument("parse_dependent_requests_enabled")]
    public TerraformValue<bool>? ParseDependentRequestsEnabled
    {
        get => new TerraformReference<bool>(this, "parse_dependent_requests_enabled");
        set => SetArgument("parse_dependent_requests_enabled", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    [TerraformArgument("url")]
    public required TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
        set => SetArgument("url", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApplicationInsightsStandardWebTestTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for validation_rules in .
/// Nesting mode: list
/// </summary>
public class AzurermApplicationInsightsStandardWebTestValidationRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "validation_rules";

    /// <summary>
    /// The expected_status_code attribute.
    /// </summary>
    [TerraformArgument("expected_status_code")]
    public TerraformValue<double>? ExpectedStatusCode
    {
        get => new TerraformReference<double>(this, "expected_status_code");
        set => SetArgument("expected_status_code", value);
    }

    /// <summary>
    /// The ssl_cert_remaining_lifetime attribute.
    /// </summary>
    [TerraformArgument("ssl_cert_remaining_lifetime")]
    public TerraformValue<double>? SslCertRemainingLifetime
    {
        get => new TerraformReference<double>(this, "ssl_cert_remaining_lifetime");
        set => SetArgument("ssl_cert_remaining_lifetime", value);
    }

    /// <summary>
    /// The ssl_check_enabled attribute.
    /// </summary>
    [TerraformArgument("ssl_check_enabled")]
    public TerraformValue<bool>? SslCheckEnabled
    {
        get => new TerraformReference<bool>(this, "ssl_check_enabled");
        set => SetArgument("ssl_check_enabled", value);
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
    }

    /// <summary>
    /// The application_insights_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationInsightsId is required")]
    [TerraformArgument("application_insights_id")]
    public required TerraformValue<string> ApplicationInsightsId
    {
        get => new TerraformReference<string>(this, "application_insights_id");
        set => SetArgument("application_insights_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformArgument("enabled")]
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    [TerraformArgument("frequency")]
    public TerraformValue<double>? Frequency
    {
        get => new TerraformReference<double>(this, "frequency");
        set => SetArgument("frequency", value);
    }

    /// <summary>
    /// The geo_locations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GeoLocations is required")]
    [TerraformArgument("geo_locations")]
    public TerraformList<string>? GeoLocations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "geo_locations").ResolveNodes(ctx));
        set => SetArgument("geo_locations", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The retry_enabled attribute.
    /// </summary>
    [TerraformArgument("retry_enabled")]
    public TerraformValue<bool>? RetryEnabled
    {
        get => new TerraformReference<bool>(this, "retry_enabled");
        set => SetArgument("retry_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformArgument("timeout")]
    public TerraformValue<double>? Timeout
    {
        get => new TerraformReference<double>(this, "timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// Block for request.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Request is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Request block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Request block(s) allowed")]
    [TerraformArgument("request")]
    public required TerraformList<AzurermApplicationInsightsStandardWebTestRequestBlock> Request { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermApplicationInsightsStandardWebTestTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for validation_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ValidationRules block(s) allowed")]
    [TerraformArgument("validation_rules")]
    public TerraformList<AzurermApplicationInsightsStandardWebTestValidationRulesBlock> ValidationRules { get; set; } = new();

    /// <summary>
    /// The synthetic_monitor_id attribute.
    /// </summary>
    [TerraformArgument("synthetic_monitor_id")]
    public TerraformValue<string> SyntheticMonitorId
    {
        get => new TerraformReference<string>(this, "synthetic_monitor_id");
    }

}
