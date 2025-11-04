using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kms_ciphertext.
/// </summary>
public class AwsKmsCiphertextDataSource : TerraformDataSource
{
    public AwsKmsCiphertextDataSource(string name) : base("aws_kms_ciphertext", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("ciphertext_blob");
    }

    /// <summary>
    /// The context attribute.
    /// </summary>
    public Dictionary<string, string>? Context
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("context")?.Value;
        set => this.WithProperty("context", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// The key_id attribute.
    /// </summary>
    public string? KeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_id")?.Value;
        set => this.WithProperty("key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The plaintext attribute.
    /// </summary>
    public string? Plaintext
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plaintext")?.Value;
        set => this.WithProperty("plaintext", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ciphertext_blob attribute.
    /// </summary>
    public TerraformExpression CiphertextBlob => this["ciphertext_blob"];

}
