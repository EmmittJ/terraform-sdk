using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kms_public_key.
/// </summary>
public class AwsKmsPublicKeyDataSource : TerraformDataSource
{
    public AwsKmsPublicKeyDataSource(string name) : base("aws_kms_public_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("customer_master_key_spec");
        this.DeclareOutput("encryption_algorithms");
        this.DeclareOutput("key_usage");
        this.DeclareOutput("public_key");
        this.DeclareOutput("public_key_pem");
        this.DeclareOutput("signing_algorithms");
    }

    /// <summary>
    /// The grant_tokens attribute.
    /// </summary>
    public List<string>? GrantTokens
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("grant_tokens")?.Value;
        set => this.WithProperty("grant_tokens", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The customer_master_key_spec attribute.
    /// </summary>
    public TerraformExpression CustomerMasterKeySpec => this["customer_master_key_spec"];

    /// <summary>
    /// The encryption_algorithms attribute.
    /// </summary>
    public TerraformExpression EncryptionAlgorithms => this["encryption_algorithms"];

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    public TerraformExpression KeyUsage => this["key_usage"];

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    public TerraformExpression PublicKey => this["public_key"];

    /// <summary>
    /// The public_key_pem attribute.
    /// </summary>
    public TerraformExpression PublicKeyPem => this["public_key_pem"];

    /// <summary>
    /// The signing_algorithms attribute.
    /// </summary>
    public TerraformExpression SigningAlgorithms => this["signing_algorithms"];

}
