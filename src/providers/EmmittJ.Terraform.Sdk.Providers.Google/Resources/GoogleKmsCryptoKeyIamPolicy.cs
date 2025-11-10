using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_kms_crypto_key_iam_policy resource.
/// </summary>
public class GoogleKmsCryptoKeyIamPolicy : TerraformResource
{
    public GoogleKmsCryptoKeyIamPolicy(string name) : base("google_kms_crypto_key_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("etag");
        SetOutput("crypto_key_id");
        SetOutput("id");
        SetOutput("policy_data");
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
    /// The policy_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyData is required")]
    public required TerraformProperty<string> PolicyData
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_data");
        set => SetProperty("policy_data", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
