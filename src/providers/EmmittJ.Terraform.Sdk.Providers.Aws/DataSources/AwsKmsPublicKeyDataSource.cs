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
        get => GetArgument<TerraformList<string>>("grant_tokens");
        set => SetArgument("grant_tokens", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformValue<string> KeyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_id");
        set => SetArgument("key_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The customer_master_key_spec attribute.
    /// </summary>
    public TerraformValue<string> CustomerMasterKeySpec
        => AsReference("customer_master_key_spec");

    /// <summary>
    /// The encryption_algorithms attribute.
    /// </summary>
    public TerraformList<string> EncryptionAlgorithms
        => AsReference("encryption_algorithms");

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    public TerraformValue<string> KeyUsage
        => AsReference("key_usage");

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    public TerraformValue<string> PublicKey
        => AsReference("public_key");

    /// <summary>
    /// The public_key_pem attribute.
    /// </summary>
    public TerraformValue<string> PublicKeyPem
        => AsReference("public_key_pem");

    /// <summary>
    /// The signing_algorithms attribute.
    /// </summary>
    public TerraformList<string> SigningAlgorithms
        => AsReference("signing_algorithms");

}
