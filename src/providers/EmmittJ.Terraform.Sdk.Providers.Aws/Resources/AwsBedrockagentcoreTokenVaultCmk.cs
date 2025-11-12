using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for kms_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsBedrockagentcoreTokenVaultCmkKmsConfigurationBlock() : TerraformBlock("kms_configuration")
{
    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyType is required")]
    [TerraformProperty("key_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyType { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyArn { get; set; }

}

/// <summary>
/// Manages a aws_bedrockagentcore_token_vault_cmk resource.
/// </summary>
public partial class AwsBedrockagentcoreTokenVaultCmk : TerraformResource
{
    public AwsBedrockagentcoreTokenVaultCmk(string name) : base("aws_bedrockagentcore_token_vault_cmk", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The token_vault_id attribute.
    /// </summary>
    [TerraformProperty("token_vault_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TokenVaultId { get; set; }

    /// <summary>
    /// Block for kms_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("kms_configuration")]
    public TerraformList<AwsBedrockagentcoreTokenVaultCmkKmsConfigurationBlock> KmsConfiguration { get; set; } = new();

}
