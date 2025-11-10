using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kms_ciphertext.
/// </summary>
public class AwsKmsCiphertextDataSource : TerraformDataSource
{
    public AwsKmsCiphertextDataSource(string name) : base("aws_kms_ciphertext", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("ciphertext_blob");
        SetOutput("context");
        SetOutput("id");
        SetOutput("key_id");
        SetOutput("plaintext");
        SetOutput("region");
    }

    /// <summary>
    /// The context attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Context
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("context");
        set => SetProperty("context", value);
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
    /// The plaintext attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plaintext is required")]
    public required TerraformProperty<string> Plaintext
    {
        get => GetRequiredOutput<TerraformProperty<string>>("plaintext");
        set => SetProperty("plaintext", value);
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
    /// The ciphertext_blob attribute.
    /// </summary>
    public TerraformExpression CiphertextBlob => this["ciphertext_blob"];

}
