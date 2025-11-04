using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kms_secrets.
/// </summary>
public class AwsKmsSecretsDataSource : TerraformDataSource
{
    public AwsKmsSecretsDataSource(string name) : base("aws_kms_secrets", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("plaintext");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The plaintext attribute.
    /// </summary>
    public TerraformExpression Plaintext => this["plaintext"];

}
