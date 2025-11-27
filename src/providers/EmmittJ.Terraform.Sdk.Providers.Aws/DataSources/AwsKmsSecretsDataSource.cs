using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for secret in AwsKmsSecretsDataSource.
/// Nesting mode: set
/// </summary>
public class AwsKmsSecretsDataSourceSecretBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secret";

    /// <summary>
    /// The context attribute.
    /// </summary>
    public TerraformMap<string>? Context
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "context").ResolveNodes(ctx));
        set => SetArgument("context", value);
    }

    /// <summary>
    /// The encryption_algorithm attribute.
    /// </summary>
    public TerraformValue<string>? EncryptionAlgorithm
    {
        get => new TerraformReference<string>(this, "encryption_algorithm");
        set => SetArgument("encryption_algorithm", value);
    }

    /// <summary>
    /// The grant_tokens attribute.
    /// </summary>
    public TerraformList<string>? GrantTokens
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "grant_tokens").ResolveNodes(ctx));
        set => SetArgument("grant_tokens", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyId
    {
        get => new TerraformReference<string>(this, "key_id");
        set => SetArgument("key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The payload attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Payload is required")]
    public required TerraformValue<string> Payload
    {
        get => new TerraformReference<string>(this, "payload");
        set => SetArgument("payload", value);
    }

}


/// <summary>
/// Represents a aws_kms_secrets Terraform data source.
/// Retrieves information about a aws_kms_secrets.
/// </summary>
public partial class AwsKmsSecretsDataSource(string name) : TerraformDataSource("aws_kms_secrets", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The plaintext attribute.
    /// </summary>
    public TerraformMap<string> Plaintext
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "plaintext").ResolveNodes(ctx));
    }

    /// <summary>
    /// Secret block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Secret block(s) required")]
    public required TerraformSet<AwsKmsSecretsDataSourceSecretBlock> Secret
    {
        get => GetRequiredArgument<TerraformSet<AwsKmsSecretsDataSourceSecretBlock>>("secret");
        set => SetArgument("secret", value);
    }

}
