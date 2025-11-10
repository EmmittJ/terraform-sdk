using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_guardduty_detector.
/// </summary>
public class AwsGuarddutyDetectorDataSource : TerraformDataSource
{
    public AwsGuarddutyDetectorDataSource(string name) : base("aws_guardduty_detector", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The features attribute.
    /// </summary>
    [TerraformPropertyName("features")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Features => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "features");

    /// <summary>
    /// The finding_publishing_frequency attribute.
    /// </summary>
    [TerraformPropertyName("finding_publishing_frequency")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FindingPublishingFrequency => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "finding_publishing_frequency");

    /// <summary>
    /// The service_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("service_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceRoleArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_role_arn");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
