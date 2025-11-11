using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_transfer_profile resource.
/// </summary>
public partial class AwsTransferProfile : TerraformResource
{
    public AwsTransferProfile(string name) : base("aws_transfer_profile", name)
    {
    }

    /// <summary>
    /// The as2_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "As2Id is required")]
    [TerraformProperty("as2_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> As2Id { get; set; }

    /// <summary>
    /// The certificate_ids attribute.
    /// </summary>
    [TerraformProperty("certificate_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? CertificateIds { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The profile_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProfileType is required")]
    [TerraformProperty("profile_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ProfileType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The profile_id attribute.
    /// </summary>
    [TerraformProperty("profile_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ProfileId { get; }

}
