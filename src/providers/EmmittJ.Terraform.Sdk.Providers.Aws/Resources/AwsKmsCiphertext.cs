using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_kms_ciphertext resource.
/// </summary>
public partial class AwsKmsCiphertext : TerraformResource
{
    public AwsKmsCiphertext(string name) : base("aws_kms_ciphertext", name)
    {
    }

    /// <summary>
    /// The context attribute.
    /// </summary>
    [TerraformProperty("context")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Context { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    [TerraformProperty("key_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KeyId { get; set; }

    /// <summary>
    /// The plaintext attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plaintext is required")]
    [TerraformProperty("plaintext")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Plaintext { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The ciphertext_blob attribute.
    /// </summary>
    [TerraformProperty("ciphertext_blob")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CiphertextBlob { get; }

}
