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
        this.WithOutput("arn");
        this.WithOutput("encrypted_fingerprint");
        this.WithOutput("encrypted_private_key");
        this.WithOutput("fingerprint");
        this.WithOutput("private_key");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The pgp_key attribute.
    /// </summary>
    public TerraformProperty<string>? PgpKey
    {
        get => GetProperty<TerraformProperty<string>>("pgp_key");
        set => this.WithProperty("pgp_key", value);
    }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    public TerraformProperty<string>? PublicKey
    {
        get => GetProperty<TerraformProperty<string>>("public_key");
        set => this.WithProperty("public_key", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
