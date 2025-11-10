using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for secret in .
/// Nesting mode: set
/// </summary>
public class AwsKmsSecretsEphemeralResourceSecretBlock : TerraformBlock
{
    /// <summary>
    /// The context attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Context
    {
        set => SetProperty("context", value);
    }

    /// <summary>
    /// The encryption_algorithm attribute.
    /// </summary>
    public TerraformProperty<string>? EncryptionAlgorithm
    {
        set => SetProperty("encryption_algorithm", value);
    }

    /// <summary>
    /// The grant_tokens attribute.
    /// </summary>
    public List<TerraformProperty<string>>? GrantTokens
    {
        set => SetProperty("grant_tokens", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyId
    {
        set => SetProperty("key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The payload attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Payload is required")]
    public required TerraformProperty<string> Payload
    {
        set => SetProperty("payload", value);
    }

}

/// <summary>
/// Manages a aws_kms_secrets ephemeral resource (temporary credentials/tokens).
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public class AwsKmsSecretsEphemeralResource : TerraformEphemeralResource
{
    public AwsKmsSecretsEphemeralResource(string name) : base("aws_kms_secrets", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("plaintext");
        SetOutput("region");
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
    /// Block for secret.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsKmsSecretsEphemeralResourceSecretBlock>? Secret
    {
        set => SetProperty("secret", value);
    }

    /// <summary>
    /// The plaintext attribute.
    /// </summary>
    public TerraformExpression Plaintext => this["plaintext"];

}
