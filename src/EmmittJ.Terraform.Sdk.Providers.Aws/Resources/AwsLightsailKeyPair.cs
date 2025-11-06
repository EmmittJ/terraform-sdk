using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lightsail_key_pair resource.
/// </summary>
public class AwsLightsailKeyPair : TerraformResource
{
    public AwsLightsailKeyPair(string name) : base("aws_lightsail_key_pair", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("encrypted_fingerprint");
        this.DeclareOutput("encrypted_private_key");
        this.DeclareOutput("fingerprint");
        this.DeclareOutput("private_key");
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public string? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix")?.Value;
        set => this.WithProperty("name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The pgp_key attribute.
    /// </summary>
    public string? PgpKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pgp_key")?.Value;
        set => this.WithProperty("pgp_key", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The encrypted_fingerprint attribute.
    /// </summary>
    public TerraformExpression EncryptedFingerprint => this["encrypted_fingerprint"];

    /// <summary>
    /// The encrypted_private_key attribute.
    /// </summary>
    public TerraformExpression EncryptedPrivateKey => this["encrypted_private_key"];

    /// <summary>
    /// The fingerprint attribute.
    /// </summary>
    public TerraformExpression Fingerprint => this["fingerprint"];

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    public TerraformExpression PrivateKey => this["private_key"];

}
