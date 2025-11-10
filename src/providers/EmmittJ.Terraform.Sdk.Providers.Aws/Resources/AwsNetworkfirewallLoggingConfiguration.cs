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
        SetOutput("enable_monitoring_dashboard");
        SetOutput("firewall_arn");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The enable_monitoring_dashboard attribute.
    /// </summary>
    public TerraformProperty<bool> EnableMonitoringDashboard
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_monitoring_dashboard");
        set => SetProperty("enable_monitoring_dashboard", value);
    }

    /// <summary>
    /// The firewall_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallArn is required")]
    public required TerraformProperty<string> FirewallArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("firewall_arn");
        set => SetProperty("firewall_arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for logging_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoggingConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LoggingConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfiguration block(s) allowed")]
    public List<AwsNetworkfirewallLoggingConfigurationLoggingConfigurationBlock>? LoggingConfiguration
    {
        set => SetProperty("logging_configuration", value);
    }

}
