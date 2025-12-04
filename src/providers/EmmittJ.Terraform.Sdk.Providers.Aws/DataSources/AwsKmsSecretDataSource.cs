using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for secret in AwsKmsSecretDataSource.
/// Nesting mode: set
/// </summary>
public class AwsKmsSecretDataSourceSecretBlock : TerraformBlock
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
        get => GetArgument<TerraformMap<string>>("context");
        set => SetArgument("context", value);
    }

    /// <summary>
    /// The grant_tokens attribute.
    /// </summary>
    public TerraformList<string>? GrantTokens
    {
        get => GetArgument<TerraformList<string>>("grant_tokens");
        set => SetArgument("grant_tokens", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The payload attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Payload is required")]
    public required TerraformValue<string> Payload
    {
        get => GetRequiredArgument<TerraformValue<string>>("payload");
        set => SetArgument("payload", value);
    }

}


/// <summary>
/// Represents a aws_kms_secret Terraform data source.
/// Retrieves information about a aws_kms_secret.
/// </summary>
public partial class AwsKmsSecretDataSource(string name) : TerraformDataSource("aws_kms_secret", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Secret block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Secret is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Secret block(s) required")]
    public required TerraformSet<AwsKmsSecretDataSourceSecretBlock> Secret
    {
        get => GetRequiredArgument<TerraformSet<AwsKmsSecretDataSourceSecretBlock>>("secret");
        set => SetArgument("secret", value);
    }

}
