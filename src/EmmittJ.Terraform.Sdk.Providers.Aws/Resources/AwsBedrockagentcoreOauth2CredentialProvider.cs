using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("client_secret_arn");
        this.DeclareOutput("credential_provider_arn");
    }

    /// <summary>
    /// The credential_provider_vendor attribute.
    /// </summary>
    public string? CredentialProviderVendor
    {
        get => GetProperty<TerraformLiteralProperty<string>>("credential_provider_vendor")?.Value;
        set => this.WithProperty("credential_provider_vendor", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
