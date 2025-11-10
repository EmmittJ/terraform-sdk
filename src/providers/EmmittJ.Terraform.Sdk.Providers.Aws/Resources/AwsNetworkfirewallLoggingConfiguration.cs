using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for logging_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallLoggingConfigurationLoggingConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_networkfirewall_logging_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsNetworkfirewallLoggingConfiguration : TerraformResource
{
    public AwsNetworkfirewallLoggingConfiguration(string name) : base("aws_networkfirewall_logging_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The enable_monitoring_dashboard attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableMonitoringDashboard
    {
        get => GetProperty<TerraformProperty<bool>>("enable_monitoring_dashboard");
        set => this.WithProperty("enable_monitoring_dashboard", value);
    }

    /// <summary>
    /// The firewall_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallArn is required")]
    public required TerraformProperty<string> FirewallArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("firewall_arn");
        set => this.WithProperty("firewall_arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for logging_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LoggingConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfiguration block(s) allowed")]
    public List<AwsNetworkfirewallLoggingConfigurationLoggingConfigurationBlock>? LoggingConfiguration
    {
        get => GetProperty<List<AwsNetworkfirewallLoggingConfigurationLoggingConfigurationBlock>>("logging_configuration");
        set => this.WithProperty("logging_configuration", value);
    }

}
