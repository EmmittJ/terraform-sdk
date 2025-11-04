using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_wafv2_web_acl_logging_configuration resource.
/// </summary>
public class AwsWafv2WebAclLoggingConfiguration : TerraformResource
{
    public AwsWafv2WebAclLoggingConfiguration(string name) : base("aws_wafv2_web_acl_logging_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// AWS Kinesis Firehose Delivery Stream ARNs
    /// </summary>
    public HashSet<string>? LogDestinationConfigs
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("log_destination_configs")?.Value;
        set => this.WithProperty("log_destination_configs", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// AWS WebACL ARN
    /// </summary>
    public string? ResourceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_arn")?.Value;
        set => this.WithProperty("resource_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
