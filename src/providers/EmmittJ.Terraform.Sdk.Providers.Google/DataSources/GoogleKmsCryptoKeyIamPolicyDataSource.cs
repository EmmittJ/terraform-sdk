using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_kms_crypto_key_iam_policy.
/// </summary>
public class GoogleKmsCryptoKeyIamPolicyDataSource : TerraformDataSource
{
    public GoogleKmsCryptoKeyIamPolicyDataSource(string name) : base("google_kms_crypto_key_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("etag");
        SetOutput("policy_data");
        SetOutput("crypto_key_id");
        SetOutput("id");
    }

    /// <summary>
    /// The crypto_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKeyId is required")]
    public required TerraformProperty<string> CryptoKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("crypto_key_id");
        set => SetProperty("crypto_key_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformExpression PolicyData => this["policy_data"];

}
