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
    public Dictionary<string, string>? Context
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("context")?.Value;
        set => this.WithProperty("context", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    public string? KeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_id")?.Value;
        set => this.WithProperty("key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The plaintext attribute.
    /// </summary>
    public string? Plaintext
    {
        get => GetProperty<TerraformLiteralProperty<string>>("plaintext")?.Value;
        set => this.WithProperty("plaintext", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ciphertext_blob attribute.
    /// </summary>
    public TerraformExpression CiphertextBlob => this["ciphertext_blob"];

}
