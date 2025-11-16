using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Body
    {
        get => new TerraformReference<string>(this, "body");
        set => SetArgument("body", value);
    }

    /// <summary>
    /// The follow_redirects_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? FollowRedirectsEnabled
    {
        get => new TerraformReference<bool>(this, "follow_redirects_enabled");
        set => SetArgument("follow_redirects_enabled", value);
    }

    /// <summary>
    /// The http_verb attribute.
    /// </summary>
    public TerraformValue<string>? HttpVerb
    {
        get => new TerraformReference<string>(this, "http_verb");
        set => SetArgument("http_verb", value);
    }

    /// <summary>
    /// The parse_dependent_requests_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ParseDependentRequestsEnabled
    {
        get => new TerraformReference<bool>(this, "parse_dependent_requests_enabled");
        set => SetArgument("parse_dependent_requests_enabled", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
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
    public TerraformValue<double>? ExpectedStatusCode
    {
        get => new TerraformReference<double>(this, "expected_status_code");
        set => SetArgument("expected_status_code", value);
    }

    /// <summary>
    /// The ssl_cert_remaining_lifetime attribute.
    /// </summary>
    public TerraformValue<double>? SslCertRemainingLifetime
    {
        get => new TerraformReference<double>(this, "ssl_cert_remaining_lifetime");
        set => SetArgument("ssl_cert_remaining_lifetime", value);
    }

    /// <summary>
    /// The ssl_check_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SslCheckEnabled
    {
        get => new TerraformReference<bool>(this, "ssl_check_enabled");
        set => SetArgument("ssl_check_enabled", value);
    }

}

/// <summary>
/// Represents a azurerm_application_insights_standard_web_test Terraform resource.
/// Manages a azurerm_application_insights_standard_web_test resource.
/// </summary>
public partial class AzurermApplicationInsightsStandardWebTest(string name) : TerraformResource("azurerm_application_insights_standard_web_test", name)
{
    /// <summary>
    /// The application_insights_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationInsightsId is required")]
    public required TerraformValue<string> ApplicationInsightsId
    {
        get => new TerraformReference<string>(this, "application_insights_id");
        set => SetArgument("application_insights_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformValue<double>? Frequency
    {
        get => new TerraformReference<double>(this, "frequency");
        set => SetArgument("frequency", value);
    }

    /// <summary>
    /// The geo_locations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GeoLocations is required")]
    public TerraformList<string>? GeoLocations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "geo_locations").ResolveNodes(ctx));
        set => SetArgument("geo_locations", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The retry_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RetryEnabled
    {
        get => new TerraformReference<bool>(this, "retry_enabled");
        set => SetArgument("retry_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformValue<double>? Timeout
    {
        get => new TerraformReference<double>(this, "timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// Request block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Request is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Request block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Request block(s) allowed")]
    public required AzurermApplicationInsightsStandardWebTestRequestBlock Request
    {
        get => GetRequiredArgument<AzurermApplicationInsightsStandardWebTestRequestBlock>("request");
        set => SetArgument("request", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApplicationInsightsStandardWebTestTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApplicationInsightsStandardWebTestTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// ValidationRules block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ValidationRules block(s) allowed")]
    public AzurermApplicationInsightsStandardWebTestValidationRulesBlock? ValidationRules
    {
        get => GetArgument<AzurermApplicationInsightsStandardWebTestValidationRulesBlock>("validation_rules");
        set => SetArgument("validation_rules", value);
    }

}
