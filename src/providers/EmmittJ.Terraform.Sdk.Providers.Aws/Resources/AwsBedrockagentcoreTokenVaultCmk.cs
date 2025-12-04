using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for kms_configuration in AwsBedrockagentcoreTokenVaultCmk.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreTokenVaultCmkKmsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kms_configuration";

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyType is required")]
    public required TerraformValue<string> KeyType
    {
        get => GetArgument<TerraformValue<string>>("key_type");
        set => SetArgument("key_type", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

}


/// <summary>
/// Represents a aws_bedrockagentcore_token_vault_cmk Terraform resource.
/// Manages a aws_bedrockagentcore_token_vault_cmk resource.
/// </summary>
public partial class AwsBedrockagentcoreTokenVaultCmk(string name) : TerraformResource("aws_bedrockagentcore_token_vault_cmk", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The token_vault_id attribute.
    /// </summary>
    public TerraformValue<string>? TokenVaultId
    {
        get => GetArgument<TerraformValue<string>>("token_vault_id");
        set => SetArgument("token_vault_id", value);
    }

    /// <summary>
    /// KmsConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentcoreTokenVaultCmkKmsConfigurationBlock>? KmsConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentcoreTokenVaultCmkKmsConfigurationBlock>>("kms_configuration");
        set => SetArgument("kms_configuration", value);
    }

}
