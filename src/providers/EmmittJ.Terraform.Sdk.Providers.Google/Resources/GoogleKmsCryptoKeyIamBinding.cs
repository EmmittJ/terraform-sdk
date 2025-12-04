using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for condition in GoogleKmsCryptoKeyIamBinding.
/// Nesting mode: list
/// </summary>
public class GoogleKmsCryptoKeyIamBindingConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformValue<string> Expression
    {
        get => GetArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => GetArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

}


/// <summary>
/// Represents a google_kms_crypto_key_iam_binding Terraform resource.
/// Manages a google_kms_crypto_key_iam_binding resource.
/// </summary>
public partial class GoogleKmsCryptoKeyIamBinding(string name) : TerraformResource("google_kms_crypto_key_iam_binding", name)
{
    /// <summary>
    /// The crypto_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CryptoKeyId is required")]
    public required TerraformValue<string> CryptoKeyId
    {
        get => GetArgument<TerraformValue<string>>("crypto_key_id");
        set => SetArgument("crypto_key_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The members attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Members is required")]
    public required TerraformSet<string> Members
    {
        get => GetArgument<TerraformSet<string>>("members");
        set => SetArgument("members", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformValue<string> Role
    {
        get => GetArgument<TerraformValue<string>>("role");
        set => SetArgument("role", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// Condition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public TerraformList<GoogleKmsCryptoKeyIamBindingConditionBlock>? Condition
    {
        get => GetArgument<TerraformList<GoogleKmsCryptoKeyIamBindingConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

}
