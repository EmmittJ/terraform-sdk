using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for datasources in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class AwsGuarddutyDetectorDatasourcesBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_guardduty_detector resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsGuarddutyDetector : TerraformResource
{
    public AwsGuarddutyDetector(string name) : base("aws_guardduty_detector", name)
    {
    }

    /// <summary>
    /// The enable attribute.
    /// </summary>
    [TerraformProperty("enable")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enable { get; set; }

    /// <summary>
    /// The finding_publishing_frequency attribute.
    /// </summary>
    [TerraformProperty("finding_publishing_frequency")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> FindingPublishingFrequency { get; set; }

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
    /// Block for datasources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Datasources block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("datasources")]
    public partial TerraformList<TerraformBlock<AwsGuarddutyDetectorDatasourcesBlock>>? Datasources { get; set; }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformProperty("account_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AccountId { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
