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

}
