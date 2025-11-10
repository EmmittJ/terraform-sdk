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
        get => GetRequiredProperty<TerraformProperty<string>>("key_type");
        set => WithProperty("key_type", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_arn");
        set => WithProperty("kms_key_arn", value);
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
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The token_vault_id attribute.
    /// </summary>
    public TerraformProperty<string>? TokenVaultId
    {
        get => GetProperty<TerraformProperty<string>>("token_vault_id");
        set => this.WithProperty("token_vault_id", value);
    }

    /// <summary>
    /// Block for kms_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockagentcoreTokenVaultCmkKmsConfigurationBlock>? KmsConfiguration
    {
        get => GetProperty<List<AwsBedrockagentcoreTokenVaultCmkKmsConfigurationBlock>>("kms_configuration");
        set => this.WithProperty("kms_configuration", value);
    }

}
