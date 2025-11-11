using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_log_destination_policy resource.
/// </summary>
public partial class AwsCloudwatchLogDestinationPolicy : TerraformResource
{
    public AwsCloudwatchLogDestinationPolicy(string name) : base("aws_cloudwatch_log_destination_policy", name)
    {
    }

    /// <summary>
    /// The access_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessPolicy is required")]
    [TerraformProperty("access_policy")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AccessPolicy { get; set; }

    /// <summary>
    /// The destination_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationName is required")]
    [TerraformProperty("destination_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DestinationName { get; set; }

    /// <summary>
    /// The force_update attribute.
    /// </summary>
    [TerraformProperty("force_update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ForceUpdate { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

}
