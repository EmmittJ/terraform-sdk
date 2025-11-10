using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kms_public_key.
/// </summary>
public class AwsKmsPublicKeyDataSource : TerraformDataSource
{
    public AwsKmsPublicKeyDataSource(string name) : base("aws_kms_public_key", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("customer_master_key_spec");
        SetOutput("encryption_algorithms");
        SetOutput("key_usage");
        SetOutput("public_key");
        SetOutput("public_key_pem");
        SetOutput("signing_algorithms");
        SetOutput("grant_tokens");
        SetOutput("id");
        SetOutput("key_id");
        SetOutput("region");
    }

    /// <summary>
    /// The grant_tokens attribute.
    /// </summary>
    public List<TerraformProperty<string>> GrantTokens
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("grant_tokens");
        set => SetProperty("grant_tokens", value);
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
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformProperty<string> KeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_id");
        set => SetProperty("key_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The customer_master_key_spec attribute.
    /// </summary>
    public TerraformExpression CustomerMasterKeySpec => this["customer_master_key_spec"];

    /// <summary>
    /// The encryption_algorithms attribute.
    /// </summary>
    public TerraformExpression EncryptionAlgorithms => this["encryption_algorithms"];

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    public TerraformExpression KeyUsage => this["key_usage"];

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    public TerraformExpression PublicKey => this["public_key"];

    /// <summary>
    /// The public_key_pem attribute.
    /// </summary>
    public TerraformExpression PublicKeyPem => this["public_key_pem"];

    /// <summary>
    /// The signing_algorithms attribute.
    /// </summary>
    public TerraformExpression SigningAlgorithms => this["signing_algorithms"];

}
