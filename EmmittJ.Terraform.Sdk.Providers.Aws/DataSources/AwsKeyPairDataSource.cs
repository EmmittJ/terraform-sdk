using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_key_pair.
/// </summary>
public class AwsKeyPairDataSource : TerraformDataSource
{
    public AwsKeyPairDataSource(string name) : base("aws_key_pair", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("create_time");
        this.DeclareOutput("fingerprint");
        this.DeclareOutput("key_type");
        this.DeclareOutput("public_key");
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
    /// The include_public_key attribute.
    /// </summary>
    public bool? IncludePublicKey
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_public_key")?.Value;
        set => this.WithProperty("include_public_key", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public string? KeyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_name")?.Value;
        set => this.WithProperty("key_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The key_pair_id attribute.
    /// </summary>
    public string? KeyPairId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_pair_id")?.Value;
        set => this.WithProperty("key_pair_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The fingerprint attribute.
    /// </summary>
    public TerraformExpression Fingerprint => this["fingerprint"];

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    public TerraformExpression KeyType => this["key_type"];

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    public TerraformExpression PublicKey => this["public_key"];

}
