using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iot_logging_options resource.
/// </summary>
public partial class AwsIotLoggingOptions : TerraformResource
{
    public AwsIotLoggingOptions(string name) : base("aws_iot_logging_options", name)
    {
    }

    /// <summary>
    /// The default_log_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultLogLevel is required")]
    [TerraformProperty("default_log_level")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DefaultLogLevel { get; set; }

    /// <summary>
    /// The disable_all_logs attribute.
    /// </summary>
    [TerraformProperty("disable_all_logs")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableAllLogs { get; set; }

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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

}
