using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_paymentcryptography_key_alias resource.
/// </summary>
public partial class AwsPaymentcryptographyKeyAlias : TerraformResource
{
    public AwsPaymentcryptographyKeyAlias(string name) : base("aws_paymentcryptography_key_alias", name)
    {
    }

    /// <summary>
    /// The alias_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AliasName is required")]
    [TerraformProperty("alias_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AliasName { get; set; }

    /// <summary>
    /// The key_arn attribute.
    /// </summary>
    [TerraformProperty("key_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KeyArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

}
