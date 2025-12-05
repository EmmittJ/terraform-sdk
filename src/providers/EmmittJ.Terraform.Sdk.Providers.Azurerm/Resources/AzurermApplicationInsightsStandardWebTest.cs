using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for request in AzurermApplicationInsightsStandardWebTest.
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
        get => GetArgument<TerraformValue<string>>("body");
        set => SetArgument("body", value);
    }

    /// <summary>
    /// The follow_redirects_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? FollowRedirectsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("follow_redirects_enabled");
        set => SetArgument("follow_redirects_enabled", value);
    }

    /// <summary>
    /// The http_verb attribute.
    /// </summary>
    public TerraformValue<string>? HttpVerb
    {
        get => GetArgument<TerraformValue<string>>("http_verb");
        set => SetArgument("http_verb", value);
    }

    /// <summary>
    /// The parse_dependent_requests_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ParseDependentRequestsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("parse_dependent_requests_enabled");
        set => SetArgument("parse_dependent_requests_enabled", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => GetRequiredArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

    /// <summary>
    /// Header block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermApplicationInsightsStandardWebTestRequestBlockHeaderBlock>? Header
    {
        get => GetArgument<TerraformList<AzurermApplicationInsightsStandardWebTestRequestBlockHeaderBlock>>("header");
        set => SetArgument("header", value);
    }

}

/// <summary>
/// Block type for header in AzurermApplicationInsightsStandardWebTestRequestBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApplicationInsightsStandardWebTestRequestBlockHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermApplicationInsightsStandardWebTest.
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for validation_rules in AzurermApplicationInsightsStandardWebTest.
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
        get => GetArgument<TerraformValue<double>>("expected_status_code");
        set => SetArgument("expected_status_code", value);
    }

    /// <summary>
    /// The ssl_cert_remaining_lifetime attribute.
    /// </summary>
    public TerraformValue<double>? SslCertRemainingLifetime
    {
        get => GetArgument<TerraformValue<double>>("ssl_cert_remaining_lifetime");
        set => SetArgument("ssl_cert_remaining_lifetime", value);
    }

    /// <summary>
    /// The ssl_check_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SslCheckEnabled
    {
        get => GetArgument<TerraformValue<bool>>("ssl_check_enabled");
        set => SetArgument("ssl_check_enabled", value);
    }

    /// <summary>
    /// Content block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Content block(s) allowed")]
    public TerraformList<AzurermApplicationInsightsStandardWebTestValidationRulesBlockContentBlock>? Content
    {
        get => GetArgument<TerraformList<AzurermApplicationInsightsStandardWebTestValidationRulesBlockContentBlock>>("content");
        set => SetArgument("content", value);
    }

}

/// <summary>
/// Block type for content in AzurermApplicationInsightsStandardWebTestValidationRulesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermApplicationInsightsStandardWebTestValidationRulesBlockContentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "content";

    /// <summary>
    /// The content_match attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentMatch is required")]
    public required TerraformValue<string> ContentMatch
    {
        get => GetRequiredArgument<TerraformValue<string>>("content_match");
        set => SetArgument("content_match", value);
    }

    /// <summary>
    /// The ignore_case attribute.
    /// </summary>
    public TerraformValue<bool>? IgnoreCase
    {
        get => GetArgument<TerraformValue<bool>>("ignore_case");
        set => SetArgument("ignore_case", value);
    }

    /// <summary>
    /// The pass_if_text_found attribute.
    /// </summary>
    public TerraformValue<bool>? PassIfTextFound
    {
        get => GetArgument<TerraformValue<bool>>("pass_if_text_found");
        set => SetArgument("pass_if_text_found", value);
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
        get => GetRequiredArgument<TerraformValue<string>>("application_insights_id");
        set => SetArgument("application_insights_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The frequency attribute.
    /// </summary>
    public TerraformValue<double>? Frequency
    {
        get => GetArgument<TerraformValue<double>>("frequency");
        set => SetArgument("frequency", value);
    }

    /// <summary>
    /// The geo_locations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GeoLocations is required")]
    public TerraformList<string>? GeoLocations
    {
        get => GetArgument<TerraformList<string>>("geo_locations");
        set => SetArgument("geo_locations", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The retry_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RetryEnabled
    {
        get => GetArgument<TerraformValue<bool>>("retry_enabled");
        set => SetArgument("retry_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformValue<double>? Timeout
    {
        get => GetArgument<TerraformValue<double>>("timeout");
        set => SetArgument("timeout", value);
    }

    /// <summary>
    /// The synthetic_monitor_id attribute.
    /// </summary>
    public TerraformValue<string> SyntheticMonitorId
        => CreateReference("synthetic_monitor_id");

    /// <summary>
    /// Request block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Request is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Request block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Request block(s) allowed")]
    public required TerraformList<AzurermApplicationInsightsStandardWebTestRequestBlock> Request
    {
        get => GetRequiredArgument<TerraformList<AzurermApplicationInsightsStandardWebTestRequestBlock>>("request");
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
    public TerraformList<AzurermApplicationInsightsStandardWebTestValidationRulesBlock>? ValidationRules
    {
        get => GetArgument<TerraformList<AzurermApplicationInsightsStandardWebTestValidationRulesBlock>>("validation_rules");
        set => SetArgument("validation_rules", value);
    }

}
