using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_guardduty_finding_ids.
/// </summary>
public class AwsGuarddutyFindingIdsDataSource : TerraformDataSource
{
    public AwsGuarddutyFindingIdsDataSource(string name) : base("aws_guardduty_finding_ids", name)
    {
    }

    /// <summary>
    /// The detector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DetectorId is required")]
    [TerraformPropertyName("detector_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DetectorId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The finding_ids attribute.
    /// </summary>
    [TerraformPropertyName("finding_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> FindingIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "finding_ids");

    /// <summary>
    /// The has_findings attribute.
    /// </summary>
    [TerraformPropertyName("has_findings")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> HasFindings => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "has_findings");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

}
