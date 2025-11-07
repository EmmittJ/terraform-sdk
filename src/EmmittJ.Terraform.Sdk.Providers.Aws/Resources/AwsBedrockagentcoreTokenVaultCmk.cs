using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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

}
