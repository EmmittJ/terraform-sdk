using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_logs in .
/// Nesting mode: list
/// </summary>
public partial class AwsVerifiedaccessInstanceLoggingConfigurationAccessLogsBlock : TerraformBlockBase
{
    /// <summary>
    /// The include_trust_context attribute.
    /// </summary>
    [TerraformProperty("include_trust_context")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> IncludeTrustContext { get; set; }

    /// <summary>
    /// The log_version attribute.
    /// </summary>
    [TerraformProperty("log_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> LogVersion { get; set; }

}

/// <summary>
/// Manages a aws_verifiedaccess_instance_logging_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsVerifiedaccessInstanceLoggingConfiguration : TerraformResource
{
    public AwsVerifiedaccessInstanceLoggingConfiguration(string name) : base("aws_verifiedaccess_instance_logging_configuration", name)
    {
    }

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
    /// The verifiedaccess_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifiedaccessInstanceId is required")]
    [TerraformProperty("verifiedaccess_instance_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VerifiedaccessInstanceId { get; set; }

    /// <summary>
    /// Block for access_logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessLogs is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AccessLogs block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogs block(s) allowed")]
    [TerraformProperty("access_logs")]
    public partial TerraformList<TerraformBlock<AwsVerifiedaccessInstanceLoggingConfigurationAccessLogsBlock>>? AccessLogs { get; set; }

}
