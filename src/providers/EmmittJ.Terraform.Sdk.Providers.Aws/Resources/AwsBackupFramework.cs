using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for control in AwsBackupFramework.
/// Nesting mode: set
/// </summary>
public class AwsBackupFrameworkControlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "control";

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
    /// InputParameter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsBackupFrameworkControlBlockInputParameterBlock>? InputParameter
    {
        get => GetArgument<TerraformSet<AwsBackupFrameworkControlBlockInputParameterBlock>>("input_parameter");
        set => SetArgument("input_parameter", value);
    }

    /// <summary>
    /// Scope block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scope block(s) allowed")]
    public TerraformList<AwsBackupFrameworkControlBlockScopeBlock>? Scope
    {
        get => GetArgument<TerraformList<AwsBackupFrameworkControlBlockScopeBlock>>("scope");
        set => SetArgument("scope", value);
    }

}

/// <summary>
/// Block type for input_parameter in AwsBackupFrameworkControlBlock.
/// Nesting mode: set
/// </summary>
public class AwsBackupFrameworkControlBlockInputParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input_parameter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for scope in AwsBackupFrameworkControlBlock.
/// Nesting mode: list
/// </summary>
public class AwsBackupFrameworkControlBlockScopeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scope";

    /// <summary>
    /// The compliance_resource_ids attribute.
    /// </summary>
    public TerraformSet<string>? ComplianceResourceIds
    {
        get => GetArgument<TerraformSet<string>>("compliance_resource_ids");
        set => SetArgument("compliance_resource_ids", value);
    }

    /// <summary>
    /// The compliance_resource_types attribute.
    /// </summary>
    public TerraformSet<string>? ComplianceResourceTypes
    {
        get => GetArgument<TerraformSet<string>>("compliance_resource_types");
        set => SetArgument("compliance_resource_types", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsBackupFramework.
/// Nesting mode: single
/// </summary>
public class AwsBackupFrameworkTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_backup_framework Terraform resource.
/// Manages a aws_backup_framework resource.
/// </summary>
public partial class AwsBackupFramework(string name) : TerraformResource("aws_backup_framework", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
        => AsReference("creation_time");

    /// <summary>
    /// The deployment_status attribute.
    /// </summary>
    public TerraformValue<string> DeploymentStatus
        => AsReference("deployment_status");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// Control block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Control is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Control block(s) required")]
    public required TerraformSet<AwsBackupFrameworkControlBlock> Control
    {
        get => GetRequiredArgument<TerraformSet<AwsBackupFrameworkControlBlock>>("control");
        set => SetArgument("control", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsBackupFrameworkTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsBackupFrameworkTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
