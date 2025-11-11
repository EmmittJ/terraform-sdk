using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_verifiedaccess_instance_trust_provider_attachment resource.
/// </summary>
public partial class AwsVerifiedaccessInstanceTrustProviderAttachment : TerraformResource
{
    public AwsVerifiedaccessInstanceTrustProviderAttachment(string name) : base("aws_verifiedaccess_instance_trust_provider_attachment", name)
    {
    }

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
    /// The verifiedaccess_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifiedaccessInstanceId is required")]
    [TerraformProperty("verifiedaccess_instance_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VerifiedaccessInstanceId { get; set; }

    /// <summary>
    /// The verifiedaccess_trust_provider_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifiedaccessTrustProviderId is required")]
    [TerraformProperty("verifiedaccess_trust_provider_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VerifiedaccessTrustProviderId { get; set; }

}
