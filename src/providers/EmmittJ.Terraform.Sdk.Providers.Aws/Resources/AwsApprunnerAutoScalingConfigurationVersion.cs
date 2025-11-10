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
    public required TerraformProperty<TerraformProperty<string>> AutoScalingConfigurationName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The max_concurrency attribute.
    /// </summary>
    [TerraformPropertyName("max_concurrency")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxConcurrency { get; set; }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    [TerraformPropertyName("max_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxSize { get; set; }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    [TerraformPropertyName("min_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinSize { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The auto_scaling_configuration_revision attribute.
    /// </summary>
    [TerraformPropertyName("auto_scaling_configuration_revision")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AutoScalingConfigurationRevision => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "auto_scaling_configuration_revision");

    /// <summary>
    /// The has_associated_service attribute.
    /// </summary>
    [TerraformPropertyName("has_associated_service")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> HasAssociatedService => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "has_associated_service");

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    [TerraformPropertyName("is_default")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IsDefault => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "is_default");

    /// <summary>
    /// The latest attribute.
    /// </summary>
    [TerraformPropertyName("latest")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Latest => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "latest");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
