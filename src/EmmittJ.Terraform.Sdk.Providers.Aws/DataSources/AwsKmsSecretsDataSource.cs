using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for secret in .
/// Nesting mode: set
/// </summary>
public class AwsKmsSecretsDataSourceSecretBlock : TerraformBlock
{
    /// <summary>
    /// The context attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Context
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("context");
        set => WithProperty("context", value);
    }

    /// <summary>
    /// The encryption_algorithm attribute.
    /// </summary>
    public TerraformProperty<string>? EncryptionAlgorithm
    {
        get => GetProperty<TerraformProperty<string>>("encryption_algorithm");
        set => WithProperty("encryption_algorithm", value);
    }

    /// <summary>
    /// The grant_tokens attribute.
    /// </summary>
    public List<TerraformProperty<string>>? GrantTokens
    {
        get => GetProperty<List<TerraformProperty<string>>>("grant_tokens");
        set => WithProperty("grant_tokens", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_id");
        set => WithProperty("key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The payload attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Payload is required")]
    public required TerraformProperty<string> Payload
    {
        get => GetProperty<TerraformProperty<string>>("payload");
        set => WithProperty("payload", value);
    }

}

/// <summary>
/// Retrieves information about a aws_kms_secrets.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsKmsSecretsDataSource : TerraformDataSource
{
    public AwsKmsSecretsDataSource(string name) : base("aws_kms_secrets", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("plaintext");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for secret.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Secret block(s) required")]
    public HashSet<AwsKmsSecretsDataSourceSecretBlock>? Secret
    {
        get => GetProperty<HashSet<AwsKmsSecretsDataSourceSecretBlock>>("secret");
        set => this.WithProperty("secret", value);
    }

    /// <summary>
    /// The plaintext attribute.
    /// </summary>
    public TerraformExpression Plaintext => this["plaintext"];

}
