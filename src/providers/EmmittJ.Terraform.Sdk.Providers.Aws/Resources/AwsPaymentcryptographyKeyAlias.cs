using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_paymentcryptography_key_alias resource.
/// </summary>
public class AwsPaymentcryptographyKeyAlias : TerraformResource
{
    public AwsPaymentcryptographyKeyAlias(string name) : base("aws_paymentcryptography_key_alias", name)
    {
    }

    /// <summary>
    /// The alias_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AliasName is required")]
    [TerraformPropertyName("alias_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AliasName { get; set; }

    /// <summary>
    /// The key_arn attribute.
    /// </summary>
    [TerraformPropertyName("key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

}
