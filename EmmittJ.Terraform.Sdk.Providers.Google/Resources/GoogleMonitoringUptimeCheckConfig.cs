using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_monitoring_uptime_check_config resource.
/// </summary>
public class GoogleMonitoringUptimeCheckConfig : TerraformResource
{
    public GoogleMonitoringUptimeCheckConfig(string name) : base("google_monitoring_uptime_check_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
        this.DeclareOutput("uptime_check_id");
    }

    /// <summary>
    /// The checker type to use for the check. If the monitored resource type is &#39;servicedirectory_service&#39;, &#39;checker_type&#39; must be set to &#39;VPC_CHECKERS&#39;. Possible values: [&amp;quot;STATIC_IP_CHECKERS&amp;quot;, &amp;quot;VPC_CHECKERS&amp;quot;]
    /// </summary>
    public string? CheckerType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("checker_type")?.Value;
        set => this.WithProperty("checker_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A human-friendly name for the uptime check configuration. The display name should be unique within a Stackdriver Workspace in order to make it easier to identify; however, uniqueness is not enforced.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Specifies whether to log the results of failed probes to Cloud Logging.
    /// </summary>
    public bool? LogCheckFailures
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("log_check_failures")?.Value;
        set => this.WithProperty("log_check_failures", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// How often, in seconds, the uptime check is performed. Currently, the only supported values are 60s (1 minute), 300s (5 minutes), 600s (10 minutes), and 900s (15 minutes). Optional, defaults to 300s.
    /// </summary>
    public string? Period
    {
        get => GetProperty<TerraformLiteralProperty<string>>("period")?.Value;
        set => this.WithProperty("period", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The list of regions from which the check will be run. Some regions contain one location, and others contain more than one. If this field is specified, enough regions to include a minimum of 3 locations must be provided, or an error message is returned. Not specifying this field will result in uptime checks running from all regions.
    /// </summary>
    public List<string>? SelectedRegions
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("selected_regions")?.Value;
        set => this.WithProperty("selected_regions", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The maximum amount of time to wait for the request to complete (must be between 1 and 60 seconds). [See the accepted formats]( https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.Duration)
    /// </summary>
    public string? Timeout
    {
        get => GetProperty<TerraformLiteralProperty<string>>("timeout")?.Value;
        set => this.WithProperty("timeout", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// User-supplied key/value data to be used for organizing and identifying the &#39;UptimeCheckConfig&#39; objects. The field can contain up to 64 entries. Each key and value is limited to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values can contain only lowercase letters, numerals, underscores, and dashes. Keys must begin with a letter.
    /// </summary>
    public Dictionary<string, string>? UserLabels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("user_labels")?.Value;
        set => this.WithProperty("user_labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// A unique resource name for this UptimeCheckConfig. The format is &#39;projects/[PROJECT_ID]/uptimeCheckConfigs/[UPTIME_CHECK_ID]&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The id of the uptime check
    /// </summary>
    public TerraformExpression UptimeCheckId => this["uptime_check_id"];

}
