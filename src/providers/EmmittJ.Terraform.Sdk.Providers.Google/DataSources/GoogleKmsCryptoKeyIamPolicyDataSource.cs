using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_kms_crypto_key_iam_policy Terraform data source.
/// Retrieves information about a google_kms_crypto_key_iam_policy.
/// </summary>
public partial class GoogleKmsCryptoKeyIamPolicyDataSource(string name) : TerraformDataSource("google_kms_crypto_key_iam_policy", name)
{
    /// <summary>
    /// The crypto_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKeyId is required")]
    public required TerraformValue<string> CryptoKeyId
    {
        get => new TerraformReference<string>(this, "crypto_key_id");
        set => SetArgument("crypto_key_id", value);
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
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformValue<string> PolicyData
    {
        get => new TerraformReference<string>(this, "policy_data");
    }

}
