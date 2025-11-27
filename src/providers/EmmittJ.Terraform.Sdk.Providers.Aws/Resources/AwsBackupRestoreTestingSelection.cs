using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for protected_resource_conditions in AwsBackupRestoreTestingSelection.
/// Nesting mode: list
/// </summary>
public class AwsBackupRestoreTestingSelectionProtectedResourceConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "protected_resource_conditions";

    /// <summary>
    /// StringEquals block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBackupRestoreTestingSelectionProtectedResourceConditionsBlockStringEqualsBlock>? StringEquals
    {
        get => GetArgument<TerraformList<AwsBackupRestoreTestingSelectionProtectedResourceConditionsBlockStringEqualsBlock>>("string_equals");
        set => SetArgument("string_equals", value);
    }

    /// <summary>
    /// StringNotEquals block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBackupRestoreTestingSelectionProtectedResourceConditionsBlockStringNotEqualsBlock>? StringNotEquals
    {
        get => GetArgument<TerraformList<AwsBackupRestoreTestingSelectionProtectedResourceConditionsBlockStringNotEqualsBlock>>("string_not_equals");
        set => SetArgument("string_not_equals", value);
    }

}

/// <summary>
/// Block type for string_equals in AwsBackupRestoreTestingSelectionProtectedResourceConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsBackupRestoreTestingSelectionProtectedResourceConditionsBlockStringEqualsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for string_not_equals in AwsBackupRestoreTestingSelectionProtectedResourceConditionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsBackupRestoreTestingSelectionProtectedResourceConditionsBlockStringNotEqualsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_backup_restore_testing_selection Terraform resource.
/// Manages a aws_backup_restore_testing_selection resource.
/// </summary>
public partial class AwsBackupRestoreTestingSelection(string name) : TerraformResource("aws_backup_restore_testing_selection", name)
{
    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRoleArn is required")]
    public required TerraformValue<string> IamRoleArn
    {
        get => new TerraformReference<string>(this, "iam_role_arn");
        set => SetArgument("iam_role_arn", value);
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
    /// The protected_resource_arns attribute.
    /// </summary>
    public TerraformSet<string> ProtectedResourceArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "protected_resource_arns").ResolveNodes(ctx));
        set => SetArgument("protected_resource_arns", value);
    }

    /// <summary>
    /// The protected_resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtectedResourceType is required")]
    public required TerraformValue<string> ProtectedResourceType
    {
        get => new TerraformReference<string>(this, "protected_resource_type");
        set => SetArgument("protected_resource_type", value);
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
    /// The restore_metadata_overrides attribute.
    /// </summary>
    public TerraformMap<string> RestoreMetadataOverrides
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "restore_metadata_overrides").ResolveNodes(ctx));
        set => SetArgument("restore_metadata_overrides", value);
    }

    /// <summary>
    /// The restore_testing_plan_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestoreTestingPlanName is required")]
    public required TerraformValue<string> RestoreTestingPlanName
    {
        get => new TerraformReference<string>(this, "restore_testing_plan_name");
        set => SetArgument("restore_testing_plan_name", value);
    }

    /// <summary>
    /// The validation_window_hours attribute.
    /// </summary>
    public TerraformValue<double> ValidationWindowHours
    {
        get => new TerraformReference<double>(this, "validation_window_hours");
        set => SetArgument("validation_window_hours", value);
    }

    /// <summary>
    /// ProtectedResourceConditions block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBackupRestoreTestingSelectionProtectedResourceConditionsBlock>? ProtectedResourceConditions
    {
        get => GetArgument<TerraformList<AwsBackupRestoreTestingSelectionProtectedResourceConditionsBlock>>("protected_resource_conditions");
        set => SetArgument("protected_resource_conditions", value);
    }

}
