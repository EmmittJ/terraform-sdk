using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for logging_filter in .
/// Nesting mode: list
/// </summary>
public partial class AwsWafv2WebAclLoggingConfigurationLoggingFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The default_behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultBehavior is required")]
    [TerraformProperty("default_behavior")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DefaultBehavior { get; set; }

}

/// <summary>
/// Block type for redacted_fields in .
/// Nesting mode: list
/// </summary>
public partial class AwsWafv2WebAclLoggingConfigurationRedactedFieldsBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_wafv2_web_acl_logging_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsWafv2WebAclLoggingConfiguration : TerraformResource
{
    public AwsWafv2WebAclLoggingConfiguration(string name) : base("aws_wafv2_web_acl_logging_configuration", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// AWS Kinesis Firehose Delivery Stream ARNs
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogDestinationConfigs is required")]
    [TerraformProperty("log_destination_configs")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> LogDestinationConfigs { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// AWS WebACL ARN
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    [TerraformProperty("resource_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceArn { get; set; }

    /// <summary>
    /// Block for logging_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingFilter block(s) allowed")]
    [TerraformProperty("logging_filter")]
    public partial TerraformList<TerraformBlock<AwsWafv2WebAclLoggingConfigurationLoggingFilterBlock>>? LoggingFilter { get; set; }

    /// <summary>
    /// Block for redacted_fields.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 RedactedFields block(s) allowed")]
    [TerraformProperty("redacted_fields")]
    public partial TerraformList<TerraformBlock<AwsWafv2WebAclLoggingConfigurationRedactedFieldsBlock>>? RedactedFields { get; set; }

}
