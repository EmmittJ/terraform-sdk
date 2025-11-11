using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_apprunner_auto_scaling_configuration_version resource.
/// </summary>
public partial class AwsApprunnerAutoScalingConfigurationVersion : TerraformResource
{
    public AwsApprunnerAutoScalingConfigurationVersion(string name) : base("aws_apprunner_auto_scaling_configuration_version", name)
    {
    }

    /// <summary>
    /// The auto_scaling_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoScalingConfigurationName is required")]
    [TerraformProperty("auto_scaling_configuration_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AutoScalingConfigurationName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The max_concurrency attribute.
    /// </summary>
    [TerraformProperty("max_concurrency")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxConcurrency { get; set; }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    [TerraformProperty("max_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxSize { get; set; }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [TerraformProperty("min_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinSize { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The auto_scaling_configuration_revision attribute.
    /// </summary>
    [TerraformProperty("auto_scaling_configuration_revision")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> AutoScalingConfigurationRevision { get; }

    /// <summary>
    /// The has_associated_service attribute.
    /// </summary>
    [TerraformProperty("has_associated_service")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> HasAssociatedService { get; }

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    [TerraformProperty("is_default")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> IsDefault { get; }

    /// <summary>
    /// The latest attribute.
    /// </summary>
    [TerraformProperty("latest")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Latest { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
