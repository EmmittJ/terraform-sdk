using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for app_monitor_configuration in AwsRumAppMonitor.
/// Nesting mode: list
/// </summary>
public class AwsRumAppMonitorAppMonitorConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "app_monitor_configuration";

    /// <summary>
    /// The allow_cookies attribute.
    /// </summary>
    public TerraformValue<bool>? AllowCookies
    {
        get => GetArgument<TerraformValue<bool>>("allow_cookies");
        set => SetArgument("allow_cookies", value);
    }

    /// <summary>
    /// The enable_xray attribute.
    /// </summary>
    public TerraformValue<bool>? EnableXray
    {
        get => GetArgument<TerraformValue<bool>>("enable_xray");
        set => SetArgument("enable_xray", value);
    }

    /// <summary>
    /// The excluded_pages attribute.
    /// </summary>
    public TerraformSet<string>? ExcludedPages
    {
        get => GetArgument<TerraformSet<string>>("excluded_pages");
        set => SetArgument("excluded_pages", value);
    }

    /// <summary>
    /// The favorite_pages attribute.
    /// </summary>
    public TerraformSet<string>? FavoritePages
    {
        get => GetArgument<TerraformSet<string>>("favorite_pages");
        set => SetArgument("favorite_pages", value);
    }

    /// <summary>
    /// The guest_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? GuestRoleArn
    {
        get => GetArgument<TerraformValue<string>>("guest_role_arn");
        set => SetArgument("guest_role_arn", value);
    }

    /// <summary>
    /// The identity_pool_id attribute.
    /// </summary>
    public TerraformValue<string>? IdentityPoolId
    {
        get => GetArgument<TerraformValue<string>>("identity_pool_id");
        set => SetArgument("identity_pool_id", value);
    }

    /// <summary>
    /// The included_pages attribute.
    /// </summary>
    public TerraformSet<string>? IncludedPages
    {
        get => GetArgument<TerraformSet<string>>("included_pages");
        set => SetArgument("included_pages", value);
    }

    /// <summary>
    /// The session_sample_rate attribute.
    /// </summary>
    public TerraformValue<double>? SessionSampleRate
    {
        get => GetArgument<TerraformValue<double>>("session_sample_rate");
        set => SetArgument("session_sample_rate", value);
    }

    /// <summary>
    /// The telemetries attribute.
    /// </summary>
    public TerraformSet<string>? Telemetries
    {
        get => GetArgument<TerraformSet<string>>("telemetries");
        set => SetArgument("telemetries", value);
    }

}


/// <summary>
/// Block type for custom_events in AwsRumAppMonitor.
/// Nesting mode: list
/// </summary>
public class AwsRumAppMonitorCustomEventsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_events";

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

}


/// <summary>
/// Represents a aws_rum_app_monitor Terraform resource.
/// Manages a aws_rum_app_monitor resource.
/// </summary>
public partial class AwsRumAppMonitor(string name) : TerraformResource("aws_rum_app_monitor", name)
{
    /// <summary>
    /// The cw_log_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CwLogEnabled
    {
        get => GetArgument<TerraformValue<bool>>("cw_log_enabled");
        set => SetArgument("cw_log_enabled", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformValue<string>? Domain
    {
        get => GetArgument<TerraformValue<string>>("domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// The domain_list attribute.
    /// </summary>
    public TerraformList<string>? DomainList
    {
        get => GetArgument<TerraformList<string>>("domain_list");
        set => SetArgument("domain_list", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The app_monitor_id attribute.
    /// </summary>
    public TerraformValue<string> AppMonitorId
        => CreateReference("app_monitor_id");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The cw_log_group attribute.
    /// </summary>
    public TerraformValue<string> CwLogGroup
        => CreateReference("cw_log_group");

    /// <summary>
    /// AppMonitorConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppMonitorConfiguration block(s) allowed")]
    public TerraformList<AwsRumAppMonitorAppMonitorConfigurationBlock>? AppMonitorConfiguration
    {
        get => GetArgument<TerraformList<AwsRumAppMonitorAppMonitorConfigurationBlock>>("app_monitor_configuration");
        set => SetArgument("app_monitor_configuration", value);
    }

    /// <summary>
    /// CustomEvents block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomEvents block(s) allowed")]
    public TerraformList<AwsRumAppMonitorCustomEventsBlock>? CustomEvents
    {
        get => GetArgument<TerraformList<AwsRumAppMonitorCustomEventsBlock>>("custom_events");
        set => SetArgument("custom_events", value);
    }

}
