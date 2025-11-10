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
        get => GetProperty<TerraformProperty<bool>>("allow_cookies");
        set => WithProperty("allow_cookies", value);
    }

    /// <summary>
    /// The enable_xray attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableXray
    {
        get => GetProperty<TerraformProperty<bool>>("enable_xray");
        set => WithProperty("enable_xray", value);
    }

    /// <summary>
    /// The excluded_pages attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExcludedPages
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("excluded_pages");
        set => WithProperty("excluded_pages", value);
    }

    /// <summary>
    /// The favorite_pages attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? FavoritePages
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("favorite_pages");
        set => WithProperty("favorite_pages", value);
    }

    /// <summary>
    /// The guest_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? GuestRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("guest_role_arn");
        set => WithProperty("guest_role_arn", value);
    }

    /// <summary>
    /// The identity_pool_id attribute.
    /// </summary>
    public TerraformProperty<string>? IdentityPoolId
    {
        get => GetProperty<TerraformProperty<string>>("identity_pool_id");
        set => WithProperty("identity_pool_id", value);
    }

    /// <summary>
    /// The included_pages attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IncludedPages
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("included_pages");
        set => WithProperty("included_pages", value);
    }

    /// <summary>
    /// The session_sample_rate attribute.
    /// </summary>
    public TerraformProperty<double>? SessionSampleRate
    {
        get => GetProperty<TerraformProperty<double>>("session_sample_rate");
        set => WithProperty("session_sample_rate", value);
    }

    /// <summary>
    /// The telemetries attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Telemetries
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("telemetries");
        set => WithProperty("telemetries", value);
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
        get => GetProperty<TerraformProperty<string>>("status");
        set => WithProperty("status", value);
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
        this.DeclareOutput("app_monitor_id");
        this.DeclareOutput("arn");
        this.DeclareOutput("cw_log_group");
    }

    /// <summary>
    /// The cw_log_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CwLogEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("cw_log_enabled");
        set => this.WithProperty("cw_log_enabled", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformProperty<string>? Domain
    {
        get => GetProperty<TerraformProperty<string>>("domain");
        set => this.WithProperty("domain", value);
    }

    /// <summary>
    /// The domain_list attribute.
    /// </summary>
    public List<TerraformProperty<string>>? DomainList
    {
        get => GetProperty<List<TerraformProperty<string>>>("domain_list");
        set => this.WithProperty("domain_list", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for app_monitor_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppMonitorConfiguration block(s) allowed")]
    public List<AwsRumAppMonitorAppMonitorConfigurationBlock>? AppMonitorConfiguration
    {
        get => GetProperty<List<AwsRumAppMonitorAppMonitorConfigurationBlock>>("app_monitor_configuration");
        set => this.WithProperty("app_monitor_configuration", value);
    }

    /// <summary>
    /// Block for custom_events.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomEvents block(s) allowed")]
    public List<AwsRumAppMonitorCustomEventsBlock>? CustomEvents
    {
        get => GetProperty<List<AwsRumAppMonitorCustomEventsBlock>>("custom_events");
        set => this.WithProperty("custom_events", value);
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
