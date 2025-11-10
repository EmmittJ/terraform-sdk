using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for logging_filter in .
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclLoggingConfigurationLoggingFilterBlock : TerraformBlock
{
    /// <summary>
    /// The default_behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultBehavior is required")]
    public required TerraformProperty<string> DefaultBehavior
    {
        set => SetProperty("default_behavior", value);
    }

}

/// <summary>
/// Block type for redacted_fields in .
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclLoggingConfigurationRedactedFieldsBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_wafv2_web_acl_logging_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsWafv2WebAclLoggingConfiguration : TerraformResource
{
    public AwsWafv2WebAclLoggingConfiguration(string name) : base("aws_wafv2_web_acl_logging_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("log_destination_configs");
        SetOutput("region");
        SetOutput("resource_arn");
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
    /// AWS Kinesis Firehose Delivery Stream ARNs
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogDestinationConfigs is required")]
    public HashSet<TerraformProperty<string>> LogDestinationConfigs
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("log_destination_configs");
        set => SetProperty("log_destination_configs", value);
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
    /// AWS WebACL ARN
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformProperty<string> ResourceArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_arn");
        set => SetProperty("resource_arn", value);
    }

    /// <summary>
    /// Block for logging_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingFilter block(s) allowed")]
    public List<AwsWafv2WebAclLoggingConfigurationLoggingFilterBlock>? LoggingFilter
    {
        set => SetProperty("logging_filter", value);
    }

    /// <summary>
    /// Block for redacted_fields.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 RedactedFields block(s) allowed")]
    public List<AwsWafv2WebAclLoggingConfigurationRedactedFieldsBlock>? RedactedFields
    {
        set => SetProperty("redacted_fields", value);
    }

}
