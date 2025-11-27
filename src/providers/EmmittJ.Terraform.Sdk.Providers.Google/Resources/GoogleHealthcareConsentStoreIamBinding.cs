using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for condition in GoogleHealthcareConsentStoreIamBinding.
/// Nesting mode: list
/// </summary>
public class GoogleHealthcareConsentStoreIamBindingConditionBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformValue<string> Expression
    {
        get => new TerraformReference<string>(this, "expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => new TerraformReference<string>(this, "title");
        set => SetArgument("title", value);
    }

}


/// <summary>
/// Represents a google_healthcare_consent_store_iam_binding Terraform resource.
/// Manages a google_healthcare_consent_store_iam_binding resource.
/// </summary>
public partial class GoogleHealthcareConsentStoreIamBinding(string name) : TerraformResource("google_healthcare_consent_store_iam_binding", name)
{
    /// <summary>
    /// The consent_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsentStoreId is required")]
    public required TerraformValue<string> ConsentStoreId
    {
        get => new TerraformReference<string>(this, "consent_store_id");
        set => SetArgument("consent_store_id", value);
    }

    /// <summary>
    /// The dataset attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    public required TerraformValue<string> Dataset
    {
        get => new TerraformReference<string>(this, "dataset");
        set => SetArgument("dataset", value);
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
    /// The members attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Members is required")]
    public required TerraformSet<string> Members
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "members").ResolveNodes(ctx));
        set => SetArgument("members", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformValue<string> Role
    {
        get => new TerraformReference<string>(this, "role");
        set => SetArgument("role", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// Condition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public TerraformList<GoogleHealthcareConsentStoreIamBindingConditionBlock>? Condition
    {
        get => GetArgument<TerraformList<GoogleHealthcareConsentStoreIamBindingConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

}
