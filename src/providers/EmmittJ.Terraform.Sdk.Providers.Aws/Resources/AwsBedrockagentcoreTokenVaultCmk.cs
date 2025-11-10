using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for kms_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreTokenVaultCmkKmsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The key_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyType is required")]
    public required TerraformProperty<string> KeyType
    {
        set => SetProperty("key_type", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        set => SetProperty("kms_key_arn", value);
    }

}

/// <summary>
/// Manages a aws_bedrockagentcore_token_vault_cmk resource.
/// </summary>
public class AwsBedrockagentcoreTokenVaultCmk : TerraformResource
{
    public AwsBedrockagentcoreTokenVaultCmk(string name) : base("aws_bedrockagentcore_token_vault_cmk", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("region");
        SetOutput("token_vault_id");
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The token_vault_id attribute.
    /// </summary>
    public TerraformProperty<string> TokenVaultId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("token_vault_id");
        set => SetProperty("token_vault_id", value);
    }

    /// <summary>
    /// Block for kms_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockagentcoreTokenVaultCmkKmsConfigurationBlock>? KmsConfiguration
    {
        set => SetProperty("kms_configuration", value);
    }

}
