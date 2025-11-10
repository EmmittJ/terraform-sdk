using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for key_registration in .
/// Nesting mode: set
/// </summary>
public class AwsQuicksightKeyRegistrationKeyRegistrationBlock : ITerraformBlock
{
    /// <summary>
    /// The default_key attribute.
    /// </summary>
    [TerraformPropertyName("default_key")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> DefaultKey { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "default_key");

    /// <summary>
    /// The key_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyArn is required")]
    [TerraformPropertyName("key_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyArn { get; set; }

}

/// <summary>
/// Manages a aws_quicksight_key_registration resource.
/// </summary>
public class AwsQuicksightKeyRegistration : TerraformResource
{
    public AwsQuicksightKeyRegistration(string name) : base("aws_quicksight_key_registration", name)
    {
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformPropertyName("aws_account_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AwsAccountId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "aws_account_id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for key_registration.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("key_registration")]
    public TerraformSet<TerraformBlock<AwsQuicksightKeyRegistrationKeyRegistrationBlock>>? KeyRegistration { get; set; } = new();

}
