using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for kms_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreTokenVaultCmkKmsConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyType is required")]
    [TerraformPropertyName("key_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KeyType { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyArn { get; set; }

}

/// <summary>
/// Manages a aws_bedrockagentcore_token_vault_cmk resource.
/// </summary>
public class AwsBedrockagentcoreTokenVaultCmk : TerraformResource
{
    public AwsBedrockagentcoreTokenVaultCmk(string name) : base("aws_bedrockagentcore_token_vault_cmk", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The token_vault_id attribute.
    /// </summary>
    [TerraformPropertyName("token_vault_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TokenVaultId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "token_vault_id");

    /// <summary>
    /// Block for kms_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("kms_configuration")]
    public TerraformList<TerraformBlock<AwsBedrockagentcoreTokenVaultCmkKmsConfigurationBlock>>? KmsConfiguration { get; set; } = new();

}
