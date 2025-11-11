using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dkim_signing_attributes in .
/// Nesting mode: list
/// </summary>
public partial class AwsSesv2EmailIdentityDkimSigningAttributesBlock : TerraformBlockBase
{

    /// <summary>
    /// The domain_signing_private_key attribute.
    /// </summary>
    [TerraformProperty("domain_signing_private_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DomainSigningPrivateKey { get; set; }

    /// <summary>
    /// The domain_signing_selector attribute.
    /// </summary>
    [TerraformProperty("domain_signing_selector")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DomainSigningSelector { get; set; }


    /// <summary>
    /// The next_signing_key_length attribute.
    /// </summary>
    [TerraformProperty("next_signing_key_length")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NextSigningKeyLength { get; set; }




}

/// <summary>
/// Manages a aws_sesv2_email_identity resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSesv2EmailIdentity : TerraformResource
{
    public AwsSesv2EmailIdentity(string name) : base("aws_sesv2_email_identity", name)
    {
    }

    /// <summary>
    /// The configuration_set_name attribute.
    /// </summary>
    [TerraformProperty("configuration_set_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConfigurationSetName { get; set; }

    /// <summary>
    /// The email_identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailIdentity is required")]
    [TerraformProperty("email_identity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EmailIdentity { get; set; }

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
    /// Block for dkim_signing_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DkimSigningAttributes block(s) allowed")]
    [TerraformProperty("dkim_signing_attributes")]
    public partial TerraformList<TerraformBlock<AwsSesv2EmailIdentityDkimSigningAttributesBlock>>? DkimSigningAttributes { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The identity_type attribute.
    /// </summary>
    [TerraformProperty("identity_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IdentityType { get; }

    /// <summary>
    /// The verification_status attribute.
    /// </summary>
    [TerraformProperty("verification_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VerificationStatus { get; }

    /// <summary>
    /// The verified_for_sending_status attribute.
    /// </summary>
    [TerraformProperty("verified_for_sending_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> VerifiedForSendingStatus { get; }

}
