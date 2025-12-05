using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for logging_configuration in AwsNetworkfirewallLoggingConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallLoggingConfigurationLoggingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_configuration";

    /// <summary>
    /// LogDestinationConfig block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogDestinationConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LogDestinationConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 LogDestinationConfig block(s) allowed")]
    public required TerraformSet<AwsNetworkfirewallLoggingConfigurationLoggingConfigurationBlockLogDestinationConfigBlock> LogDestinationConfig
    {
        get => GetRequiredArgument<TerraformSet<AwsNetworkfirewallLoggingConfigurationLoggingConfigurationBlockLogDestinationConfigBlock>>("log_destination_config");
        set => SetArgument("log_destination_config", value);
    }

}

/// <summary>
/// Block type for log_destination_config in AwsNetworkfirewallLoggingConfigurationLoggingConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AwsNetworkfirewallLoggingConfigurationLoggingConfigurationBlockLogDestinationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_destination_config";

    /// <summary>
    /// The log_destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogDestination is required")]
    public required TerraformMap<string> LogDestination
    {
        get => GetRequiredArgument<TerraformMap<string>>("log_destination");
        set => SetArgument("log_destination", value);
    }

    /// <summary>
    /// The log_destination_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogDestinationType is required")]
    public required TerraformValue<string> LogDestinationType
    {
        get => GetRequiredArgument<TerraformValue<string>>("log_destination_type");
        set => SetArgument("log_destination_type", value);
    }

    /// <summary>
    /// The log_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogType is required")]
    public required TerraformValue<string> LogType
    {
        get => GetRequiredArgument<TerraformValue<string>>("log_type");
        set => SetArgument("log_type", value);
    }

}


/// <summary>
/// Represents a aws_networkfirewall_logging_configuration Terraform resource.
/// Manages a aws_networkfirewall_logging_configuration resource.
/// </summary>
public partial class AwsNetworkfirewallLoggingConfiguration(string name) : TerraformResource("aws_networkfirewall_logging_configuration", name)
{
    /// <summary>
    /// The enable_monitoring_dashboard attribute.
    /// </summary>
    public TerraformValue<bool> EnableMonitoringDashboard
    {
        get => GetArgument<TerraformValue<bool>>("enable_monitoring_dashboard") ?? CreateReference("enable_monitoring_dashboard");
        set => SetArgument("enable_monitoring_dashboard", value);
    }

    /// <summary>
    /// The firewall_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallArn is required")]
    public required TerraformValue<string> FirewallArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("firewall_arn");
        set => SetArgument("firewall_arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// LoggingConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoggingConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LoggingConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfiguration block(s) allowed")]
    public required TerraformList<AwsNetworkfirewallLoggingConfigurationLoggingConfigurationBlock> LoggingConfiguration
    {
        get => GetRequiredArgument<TerraformList<AwsNetworkfirewallLoggingConfigurationLoggingConfigurationBlock>>("logging_configuration");
        set => SetArgument("logging_configuration", value);
    }

}
