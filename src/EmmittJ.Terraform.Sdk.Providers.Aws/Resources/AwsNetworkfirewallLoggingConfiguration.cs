using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_networkfirewall_logging_configuration resource.
/// </summary>
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
    public bool? EnableMonitoringDashboard
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_monitoring_dashboard")?.Value;
        set => this.WithProperty("enable_monitoring_dashboard", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The firewall_arn attribute.
    /// </summary>
    public string? FirewallArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("firewall_arn")?.Value;
        set => this.WithProperty("firewall_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
