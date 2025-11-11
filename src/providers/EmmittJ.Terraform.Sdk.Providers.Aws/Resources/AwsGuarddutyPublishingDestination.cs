using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_guardduty_publishing_destination resource.
/// </summary>
public partial class AwsGuarddutyPublishingDestination : TerraformResource
{
    public AwsGuarddutyPublishingDestination(string name) : base("aws_guardduty_publishing_destination", name)
    {
    }

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationArn is required")]
    [TerraformProperty("destination_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DestinationArn { get; set; }

    /// <summary>
    /// The destination_type attribute.
    /// </summary>
    [TerraformProperty("destination_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DestinationType { get; set; }

    /// <summary>
    /// The detector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DetectorId is required")]
    [TerraformProperty("detector_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DetectorId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyArn is required")]
    [TerraformProperty("kms_key_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KmsKeyArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

}
