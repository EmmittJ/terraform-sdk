using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_kms_ciphertext Terraform data source.
/// Retrieves information about a aws_kms_ciphertext.
/// </summary>
public partial class AwsKmsCiphertextDataSource(string name) : TerraformDataSource("aws_kms_ciphertext", name)
{
    /// <summary>
    /// The context attribute.
    /// </summary>
    public TerraformMap<string>? Context
    {
        get => GetArgument<TerraformMap<string>>("context");
        set => SetArgument("context", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformValue<string> KeyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_id");
        set => SetArgument("key_id", value);
    }

    /// <summary>
    /// The plaintext attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plaintext is required")]
    public required TerraformValue<string> Plaintext
    {
        get => GetRequiredArgument<TerraformValue<string>>("plaintext");
        set => SetArgument("plaintext", value);
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
    /// The ciphertext_blob attribute.
    /// </summary>
    public TerraformValue<string> CiphertextBlob
        => AsReference("ciphertext_blob");

}
