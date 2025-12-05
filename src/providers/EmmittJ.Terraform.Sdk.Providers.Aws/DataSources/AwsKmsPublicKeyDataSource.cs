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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
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
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The customer_master_key_spec attribute.
    /// </summary>
    public TerraformValue<string> CustomerMasterKeySpec
        => CreateReference("customer_master_key_spec");

    /// <summary>
    /// The encryption_algorithms attribute.
    /// </summary>
    public TerraformList<string> EncryptionAlgorithms
        => CreateReference("encryption_algorithms");

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    public TerraformValue<string> KeyUsage
        => CreateReference("key_usage");

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    public TerraformValue<string> PublicKey
        => CreateReference("public_key");

    /// <summary>
    /// The public_key_pem attribute.
    /// </summary>
    public TerraformValue<string> PublicKeyPem
        => CreateReference("public_key_pem");

    /// <summary>
    /// The signing_algorithms attribute.
    /// </summary>
    public TerraformList<string> SigningAlgorithms
        => CreateReference("signing_algorithms");

}
