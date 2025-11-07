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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// AWS Kinesis Firehose Delivery Stream ARNs
    /// </summary>
    public TerraformProperty<HashSet<string>>? LogDestinationConfigs
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("log_destination_configs");
        set => this.WithProperty("log_destination_configs", value);
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
    /// AWS WebACL ARN
    /// </summary>
    public TerraformProperty<string>? ResourceArn
    {
        get => GetProperty<TerraformProperty<string>>("resource_arn");
        set => this.WithProperty("resource_arn", value);
    }

}
