using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_bedrockagentcore_api_key_credential_provider resource.
/// </summary>
public class AwsBedrockagentcoreApiKeyCredentialProvider : TerraformResource
{
    public AwsBedrockagentcoreApiKeyCredentialProvider(string name) : base("aws_bedrockagentcore_api_key_credential_provider", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("api_key_secret_arn");
        this.DeclareOutput("credential_provider_arn");
    }

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    public string? ApiKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_key")?.Value;
        set => this.WithProperty("api_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The api_key_wo attribute.
    /// </summary>
    public string? ApiKeyWo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_key_wo")?.Value;
        set => this.WithProperty("api_key_wo", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The api_key_wo_version attribute.
    /// </summary>
    public double? ApiKeyWoVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("api_key_wo_version")?.Value;
        set => this.WithProperty("api_key_wo_version", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The api_key_secret_arn attribute.
    /// </summary>
    public TerraformExpression ApiKeySecretArn => this["api_key_secret_arn"];

    /// <summary>
    /// The credential_provider_arn attribute.
    /// </summary>
    public TerraformExpression CredentialProviderArn => this["credential_provider_arn"];

}
