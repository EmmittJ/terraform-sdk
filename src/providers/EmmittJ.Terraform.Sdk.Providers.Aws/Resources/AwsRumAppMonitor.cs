using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for app_monitor_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsRumAppMonitorAppMonitorConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The allow_cookies attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowCookies
    {
        set => SetProperty("allow_cookies", value);
    }

    /// <summary>
    /// The enable_xray attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableXray
    {
        set => SetProperty("enable_xray", value);
    }

    /// <summary>
    /// The excluded_pages attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExcludedPages
    {
        set => SetProperty("excluded_pages", value);
    }

    /// <summary>
    /// The favorite_pages attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? FavoritePages
    {
        set => SetProperty("favorite_pages", value);
    }

    /// <summary>
    /// The guest_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? GuestRoleArn
    {
        set => SetProperty("guest_role_arn", value);
    }

    /// <summary>
    /// The identity_pool_id attribute.
    /// </summary>
    public TerraformProperty<string>? IdentityPoolId
    {
        set => SetProperty("identity_pool_id", value);
    }

    /// <summary>
    /// The included_pages attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IncludedPages
    {
        set => SetProperty("included_pages", value);
    }

    /// <summary>
    /// The session_sample_rate attribute.
    /// </summary>
    public TerraformProperty<double>? SessionSampleRate
    {
        set => SetProperty("session_sample_rate", value);
    }

    /// <summary>
    /// The telemetries attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Telemetries
    {
        set => SetProperty("telemetries", value);
    }

}

/// <summary>
/// Block type for custom_events in .
/// Nesting mode: list
/// </summary>
public class AwsRumAppMonitorCustomEventsBlock : TerraformBlock
{
    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        set => SetProperty("status", value);
    }

}

/// <summary>
/// Manages a aws_rum_app_monitor resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsRumAppMonitor : TerraformResource
{
    public AwsRumAppMonitor(string name) : base("aws_rum_app_monitor", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("app_monitor_id");
        SetOutput("arn");
        SetOutput("cw_log_group");
        SetOutput("cw_log_enabled");
        SetOutput("domain");
        SetOutput("domain_list");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The cw_log_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> CwLogEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("cw_log_enabled");
        set => SetProperty("cw_log_enabled", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformProperty<string> Domain
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain");
        set => SetProperty("domain", value);
    }

    /// <summary>
    /// The domain_list attribute.
    /// </summary>
    public List<TerraformProperty<string>> DomainList
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("domain_list");
        set => SetProperty("domain_list", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for app_monitor_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppMonitorConfiguration block(s) allowed")]
    public List<AwsRumAppMonitorAppMonitorConfigurationBlock>? AppMonitorConfiguration
    {
        set => SetProperty("app_monitor_configuration", value);
    }

    /// <summary>
    /// Block for custom_events.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomEvents block(s) allowed")]
    public List<AwsRumAppMonitorCustomEventsBlock>? CustomEvents
    {
        set => SetProperty("custom_events", value);
    }

    /// <summary>
    /// The app_monitor_id attribute.
    /// </summary>
    public TerraformExpression AppMonitorId => this["app_monitor_id"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The cw_log_group attribute.
    /// </summary>
    public TerraformExpression CwLogGroup => this["cw_log_group"];

}
