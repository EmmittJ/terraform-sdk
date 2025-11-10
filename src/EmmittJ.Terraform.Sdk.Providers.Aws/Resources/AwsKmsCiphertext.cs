using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_kms_ciphertext resource.
/// </summary>
public class AwsKmsCiphertext : TerraformResource
{
    public AwsKmsCiphertext(string name) : base("aws_kms_ciphertext", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("ciphertext_blob");
    }

    /// <summary>
    /// The context attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Context
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("context");
        set => this.WithProperty("context", value);
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
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformProperty<string> KeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_id");
        set => this.WithProperty("key_id", value);
    }

    /// <summary>
    /// The plaintext attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plaintext is required")]
    public required TerraformProperty<string> Plaintext
    {
        get => GetProperty<TerraformProperty<string>>("plaintext");
        set => this.WithProperty("plaintext", value);
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
    /// The ciphertext_blob attribute.
    /// </summary>
    public TerraformExpression CiphertextBlob => this["ciphertext_blob"];

}
