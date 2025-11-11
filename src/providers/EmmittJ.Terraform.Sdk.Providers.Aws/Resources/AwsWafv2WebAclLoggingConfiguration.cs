using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for logging_filter in .
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclLoggingConfigurationLoggingFilterBlock
{
    /// <summary>
    /// The default_behavior attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultBehavior is required")]
    [TerraformPropertyName("default_behavior")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DefaultBehavior { get; set; }

}

/// <summary>
/// Block type for redacted_fields in .
/// Nesting mode: list
/// </summary>
public class AwsWafv2WebAclLoggingConfigurationRedactedFieldsBlock
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
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// AWS Kinesis Firehose Delivery Stream ARNs
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogDestinationConfigs is required")]
    [TerraformPropertyName("log_destination_configs")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> LogDestinationConfigs { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// AWS WebACL ARN
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    [TerraformPropertyName("resource_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceArn { get; set; }

    /// <summary>
    /// Block for logging_filter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingFilter block(s) allowed")]
    [TerraformPropertyName("logging_filter")]
    public TerraformList<TerraformBlock<AwsWafv2WebAclLoggingConfigurationLoggingFilterBlock>>? LoggingFilter { get; set; }

    /// <summary>
    /// Block for redacted_fields.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 RedactedFields block(s) allowed")]
    [TerraformPropertyName("redacted_fields")]
    public TerraformList<TerraformBlock<AwsWafv2WebAclLoggingConfigurationRedactedFieldsBlock>>? RedactedFields { get; set; }

}
