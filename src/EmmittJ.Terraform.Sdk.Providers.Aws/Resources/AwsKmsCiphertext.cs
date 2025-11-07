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
    public TerraformLiteralProperty<Dictionary<string, string>>? Context
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("context");
        set => this.WithProperty("context", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_id");
        set => this.WithProperty("key_id", value);
    }

    /// <summary>
    /// The plaintext attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Plaintext
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plaintext");
        set => this.WithProperty("plaintext", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The ciphertext_blob attribute.
    /// </summary>
    public TerraformExpression CiphertextBlob => this["ciphertext_blob"];

}
