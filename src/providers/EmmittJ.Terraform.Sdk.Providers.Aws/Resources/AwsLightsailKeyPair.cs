using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_lightsail_key_pair Terraform resource.
/// Manages a aws_lightsail_key_pair resource.
/// </summary>
public partial class AwsLightsailKeyPair(string name) : TerraformResource("aws_lightsail_key_pair", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The pgp_key attribute.
    /// </summary>
    public TerraformValue<string>? PgpKey
    {
        get => new TerraformReference<string>(this, "pgp_key");
        set => SetArgument("pgp_key", value);
    }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    public TerraformValue<string> PublicKey
    {
        get => new TerraformReference<string>(this, "public_key");
        set => SetArgument("public_key", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The encrypted_fingerprint attribute.
    /// </summary>
    public TerraformValue<string> EncryptedFingerprint
    {
        get => new TerraformReference<string>(this, "encrypted_fingerprint");
    }

    /// <summary>
    /// The encrypted_private_key attribute.
    /// </summary>
    public TerraformValue<string> EncryptedPrivateKey
    {
        get => new TerraformReference<string>(this, "encrypted_private_key");
    }

    /// <summary>
    /// The fingerprint attribute.
    /// </summary>
    public TerraformValue<string> Fingerprint
    {
        get => new TerraformReference<string>(this, "fingerprint");
    }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    public TerraformValue<string> PrivateKey
    {
        get => new TerraformReference<string>(this, "private_key");
    }

}
