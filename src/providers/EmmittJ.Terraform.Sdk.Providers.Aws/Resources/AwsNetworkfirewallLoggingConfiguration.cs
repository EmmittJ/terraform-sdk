using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for logging_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsNetworkfirewallLoggingConfigurationLoggingConfigurationBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_networkfirewall_logging_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsNetworkfirewallLoggingConfiguration : TerraformResource
{
    public AwsNetworkfirewallLoggingConfiguration(string name) : base("aws_networkfirewall_logging_configuration", name)
    {
    }

    /// <summary>
    /// The enable_monitoring_dashboard attribute.
    /// </summary>
    [TerraformProperty("enable_monitoring_dashboard")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EnableMonitoringDashboard { get; set; }

    /// <summary>
    /// The firewall_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallArn is required")]
    [TerraformProperty("firewall_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FirewallArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for logging_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoggingConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 LoggingConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfiguration block(s) allowed")]
    [TerraformProperty("logging_configuration")]
    public partial TerraformList<TerraformBlock<AwsNetworkfirewallLoggingConfigurationLoggingConfigurationBlock>>? LoggingConfiguration { get; set; }

}
