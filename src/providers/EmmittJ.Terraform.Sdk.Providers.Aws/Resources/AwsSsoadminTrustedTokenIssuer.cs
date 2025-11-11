using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for trusted_token_issuer_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsSsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationBlock
{
}

/// <summary>
/// Manages a aws_ssoadmin_trusted_token_issuer resource.
/// </summary>
public class AwsSsoadminTrustedTokenIssuer : TerraformResource
{
    public AwsSsoadminTrustedTokenIssuer(string name) : base("aws_ssoadmin_trusted_token_issuer", name)
    {
    }

    /// <summary>
    /// The client_token attribute.
    /// </summary>
    [TerraformPropertyName("client_token")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClientToken { get; set; }

    /// <summary>
    /// The instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceArn is required")]
    [TerraformPropertyName("instance_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InstanceArn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The trusted_token_issuer_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustedTokenIssuerType is required")]
    [TerraformPropertyName("trusted_token_issuer_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TrustedTokenIssuerType { get; set; }

    /// <summary>
    /// Block for trusted_token_issuer_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("trusted_token_issuer_configuration")]
    public TerraformList<TerraformBlock<AwsSsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationBlock>>? TrustedTokenIssuerConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

}
