using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for condition in AwsBackupSelection.
/// Nesting mode: set
/// </summary>
public class AwsBackupSelectionConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// StringEquals block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsBackupSelectionConditionBlockStringEqualsBlock>? StringEquals
    {
        get => GetArgument<TerraformSet<AwsBackupSelectionConditionBlockStringEqualsBlock>>("string_equals");
        set => SetArgument("string_equals", value);
    }

    /// <summary>
    /// StringLike block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsBackupSelectionConditionBlockStringLikeBlock>? StringLike
    {
        get => GetArgument<TerraformSet<AwsBackupSelectionConditionBlockStringLikeBlock>>("string_like");
        set => SetArgument("string_like", value);
    }

    /// <summary>
    /// StringNotEquals block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsBackupSelectionConditionBlockStringNotEqualsBlock>? StringNotEquals
    {
        get => GetArgument<TerraformSet<AwsBackupSelectionConditionBlockStringNotEqualsBlock>>("string_not_equals");
        set => SetArgument("string_not_equals", value);
    }

    /// <summary>
    /// StringNotLike block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsBackupSelectionConditionBlockStringNotLikeBlock>? StringNotLike
    {
        get => GetArgument<TerraformSet<AwsBackupSelectionConditionBlockStringNotLikeBlock>>("string_not_like");
        set => SetArgument("string_not_like", value);
    }

}

/// <summary>
/// Block type for string_equals in AwsBackupSelectionConditionBlock.
/// Nesting mode: set
/// </summary>
public class AwsBackupSelectionConditionBlockStringEqualsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "string_equals";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for string_like in AwsBackupSelectionConditionBlock.
/// Nesting mode: set
/// </summary>
public class AwsBackupSelectionConditionBlockStringLikeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "string_like";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for string_not_equals in AwsBackupSelectionConditionBlock.
/// Nesting mode: set
/// </summary>
public class AwsBackupSelectionConditionBlockStringNotEqualsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "string_not_equals";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for string_not_like in AwsBackupSelectionConditionBlock.
/// Nesting mode: set
/// </summary>
public class AwsBackupSelectionConditionBlockStringNotLikeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "string_not_like";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for selection_tag in AwsBackupSelection.
/// Nesting mode: set
/// </summary>
public class AwsBackupSelectionSelectionTagBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "selection_tag";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_backup_selection Terraform resource.
/// Manages a aws_backup_selection resource.
/// </summary>
public partial class AwsBackupSelection(string name) : TerraformResource("aws_backup_selection", name)
{
    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRoleArn is required")]
    public required TerraformValue<string> IamRoleArn
    {
        get => GetArgument<TerraformValue<string>>("iam_role_arn");
        set => SetArgument("iam_role_arn", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The not_resources attribute.
    /// </summary>
    public TerraformSet<string>? NotResources
    {
        get => GetArgument<TerraformSet<string>>("not_resources");
        set => SetArgument("not_resources", value);
    }

    /// <summary>
    /// The plan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlanId is required")]
    public required TerraformValue<string> PlanId
    {
        get => GetArgument<TerraformValue<string>>("plan_id");
        set => SetArgument("plan_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resources attribute.
    /// </summary>
    public TerraformSet<string>? Resources
    {
        get => GetArgument<TerraformSet<string>>("resources");
        set => SetArgument("resources", value);
    }

    /// <summary>
    /// Condition block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsBackupSelectionConditionBlock>? Condition
    {
        get => GetArgument<TerraformSet<AwsBackupSelectionConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// SelectionTag block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsBackupSelectionSelectionTagBlock>? SelectionTag
    {
        get => GetArgument<TerraformSet<AwsBackupSelectionSelectionTagBlock>>("selection_tag");
        set => SetArgument("selection_tag", value);
    }

}
