using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_logs in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessInstanceLoggingConfigurationAccessLogsBlock
{
    /// <summary>
    /// The include_trust_context attribute.
    /// </summary>
    [TerraformPropertyName("include_trust_context")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> IncludeTrustContext { get; set; } = default!;

    /// <summary>
    /// The log_version attribute.
    /// </summary>
    [TerraformPropertyName("log_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LogVersion { get; set; } = default!;

}

/// <summary>
/// Manages a aws_verifiedaccess_instance_logging_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsVerifiedaccessInstanceLoggingConfiguration : TerraformResource
{
    public AwsVerifiedaccessInstanceLoggingConfiguration(string name) : base("aws_verifiedaccess_instance_logging_configuration", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The verifiedaccess_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifiedaccessInstanceId is required")]
    [TerraformPropertyName("verifiedaccess_instance_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VerifiedaccessInstanceId { get; set; }

    /// <summary>
    /// Block for access_logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessLogs is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AccessLogs block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogs block(s) allowed")]
    [TerraformPropertyName("access_logs")]
    public TerraformList<TerraformBlock<AwsVerifiedaccessInstanceLoggingConfigurationAccessLogsBlock>>? AccessLogs { get; set; }

}
