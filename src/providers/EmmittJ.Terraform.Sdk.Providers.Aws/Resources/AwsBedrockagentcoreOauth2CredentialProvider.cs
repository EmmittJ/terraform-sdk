using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for oauth2_provider_config in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_bedrockagentcore_oauth2_credential_provider resource.
/// </summary>
public class AwsBedrockagentcoreOauth2CredentialProvider : TerraformResource
{
    public AwsBedrockagentcoreOauth2CredentialProvider(string name) : base("aws_bedrockagentcore_oauth2_credential_provider", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutputlient_secret_arn");
        this.WithOutputredential_provider_arn");
    }

    /// <summary>
    /// The credential_provider_vendor attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CredentialProviderVendor is required")]
    public required TerraformProperty<string> CredentialProviderVendor
    {
        get => GetRequiredProperty<TerraformProperty<string>>("credential_provider_vendor");
        set => this.WithProperty("credential_provider_vendor", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for oauth2_provider_config.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlock>? Oauth2ProviderConfig
    {
        get => GetProperty<List<AwsBedrockagentcoreOauth2CredentialProviderOauth2ProviderConfigBlock>>("oauth2_provider_config");
        set => this.WithProperty("oauth2_provider_config", value);
    }

    /// <summary>
    /// The client_secret_arn attribute.
    /// </summary>
    public TerraformExpression ClientSecretArn => this["client_secret_arn"];

    /// <summary>
    /// The credential_provider_arn attribute.
    /// </summary>
    public TerraformExpression CredentialProviderArn => this["credential_provider_arn"];

}
