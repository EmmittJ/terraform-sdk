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
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "context").ResolveNodes(ctx));
        set => SetArgument("context", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyId is required")]
    public required TerraformValue<string> KeyId
    {
        get => new TerraformReference<string>(this, "key_id");
        set => SetArgument("key_id", value);
    }

    /// <summary>
    /// The plaintext attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plaintext is required")]
    public required TerraformValue<string> Plaintext
    {
        get => new TerraformReference<string>(this, "plaintext");
        set => SetArgument("plaintext", value);
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
    /// The ciphertext_blob attribute.
    /// </summary>
    public TerraformValue<string> CiphertextBlob
    {
        get => new TerraformReference<string>(this, "ciphertext_blob");
    }

}
