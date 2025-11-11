using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_apprunner_auto_scaling_configuration_version resource.
/// </summary>
public class AwsApprunnerAutoScalingConfigurationVersion : TerraformResource
{
    public AwsApprunnerAutoScalingConfigurationVersion(string name) : base("aws_apprunner_auto_scaling_configuration_version", name)
    {
    }

    /// <summary>
    /// The auto_scaling_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoScalingConfigurationName is required")]
    [TerraformPropertyName("auto_scaling_configuration_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AutoScalingConfigurationName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The max_concurrency attribute.
    /// </summary>
    [TerraformPropertyName("max_concurrency")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxConcurrency { get; set; }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    [TerraformPropertyName("max_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxSize { get; set; }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [TerraformPropertyName("min_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MinSize { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The auto_scaling_configuration_revision attribute.
    /// </summary>
    [TerraformPropertyName("auto_scaling_configuration_revision")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AutoScalingConfigurationRevision => new TerraformReference(this, "auto_scaling_configuration_revision");

    /// <summary>
    /// The has_associated_service attribute.
    /// </summary>
    [TerraformPropertyName("has_associated_service")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> HasAssociatedService => new TerraformReference(this, "has_associated_service");

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    [TerraformPropertyName("is_default")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> IsDefault => new TerraformReference(this, "is_default");

    /// <summary>
    /// The latest attribute.
    /// </summary>
    [TerraformPropertyName("latest")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Latest => new TerraformReference(this, "latest");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
