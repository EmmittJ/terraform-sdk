using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_key_pair resource.
/// </summary>
public class AwsKeyPair : TerraformResource
{
    public AwsKeyPair(string name) : base("aws_key_pair", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("fingerprint");
        this.DeclareOutput("key_pair_id");
        this.DeclareOutput("key_type");
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
    /// The key_name attribute.
    /// </summary>
    public string? KeyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_name")?.Value;
        set => this.WithProperty("key_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The key_name_prefix attribute.
    /// </summary>
    public string? KeyNamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_name_prefix")?.Value;
        set => this.WithProperty("key_name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    public string? PublicKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_key")?.Value;
        set => this.WithProperty("public_key", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The fingerprint attribute.
    /// </summary>
    public TerraformExpression Fingerprint => this["fingerprint"];

    /// <summary>
    /// The key_pair_id attribute.
    /// </summary>
    public TerraformExpression KeyPairId => this["key_pair_id"];

    /// <summary>
    /// The key_type attribute.
    /// </summary>
    public TerraformExpression KeyType => this["key_type"];

}
