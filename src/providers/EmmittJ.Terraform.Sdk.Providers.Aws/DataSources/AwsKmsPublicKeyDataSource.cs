using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_kms_public_key Terraform data source.
/// Retrieves information about a aws_kms_public_key.
/// </summary>
public partial class AwsKmsPublicKeyDataSource(string name) : TerraformDataSource("aws_kms_public_key", name)
{
    /// <summary>
    /// The grant_tokens attribute.
    /// </summary>
    public TerraformList<string>? GrantTokens
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "grant_tokens").ResolveNodes(ctx));
        set => SetArgument("grant_tokens", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformValue<string> KeyId
    {
        get => new TerraformReference<string>(this, "key_id");
        set => SetArgument("key_id", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The customer_master_key_spec attribute.
    /// </summary>
    public TerraformValue<string> CustomerMasterKeySpec
    {
        get => new TerraformReference<string>(this, "customer_master_key_spec");
    }

    /// <summary>
    /// The encryption_algorithms attribute.
    /// </summary>
    public TerraformList<string> EncryptionAlgorithms
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "encryption_algorithms").ResolveNodes(ctx));
    }

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    public TerraformValue<string> KeyUsage
    {
        get => new TerraformReference<string>(this, "key_usage");
    }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    public TerraformValue<string> PublicKey
    {
        get => new TerraformReference<string>(this, "public_key");
    }

    /// <summary>
    /// The public_key_pem attribute.
    /// </summary>
    public TerraformValue<string> PublicKeyPem
    {
        get => new TerraformReference<string>(this, "public_key_pem");
    }

    /// <summary>
    /// The signing_algorithms attribute.
    /// </summary>
    public TerraformList<string> SigningAlgorithms
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "signing_algorithms").ResolveNodes(ctx));
    }

}
