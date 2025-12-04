using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_deployment in AwsCloudformationStackSet.
/// Nesting mode: list
/// </summary>
public class AwsCloudformationStackSetAutoDeploymentBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_deployment";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The retain_stacks_on_account_removal attribute.
    /// </summary>
    public TerraformValue<bool>? RetainStacksOnAccountRemoval
    {
        get => GetArgument<TerraformValue<bool>>("retain_stacks_on_account_removal");
        set => SetArgument("retain_stacks_on_account_removal", value);
    }

}


/// <summary>
/// Block type for managed_execution in AwsCloudformationStackSet.
/// Nesting mode: list
/// </summary>
public class AwsCloudformationStackSetManagedExecutionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "managed_execution";

    /// <summary>
    /// The active attribute.
    /// </summary>
    public TerraformValue<bool>? Active
    {
        get => GetArgument<TerraformValue<bool>>("active");
        set => SetArgument("active", value);
    }

}


/// <summary>
/// Block type for operation_preferences in AwsCloudformationStackSet.
/// Nesting mode: list
/// </summary>
public class AwsCloudformationStackSetOperationPreferencesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "operation_preferences";

    /// <summary>
    /// The failure_tolerance_count attribute.
    /// </summary>
    public TerraformValue<double>? FailureToleranceCount
    {
        get => GetArgument<TerraformValue<double>>("failure_tolerance_count");
        set => SetArgument("failure_tolerance_count", value);
    }

    /// <summary>
    /// The failure_tolerance_percentage attribute.
    /// </summary>
    public TerraformValue<double>? FailureTolerancePercentage
    {
        get => GetArgument<TerraformValue<double>>("failure_tolerance_percentage");
        set => SetArgument("failure_tolerance_percentage", value);
    }

    /// <summary>
    /// The max_concurrent_count attribute.
    /// </summary>
    public TerraformValue<double>? MaxConcurrentCount
    {
        get => GetArgument<TerraformValue<double>>("max_concurrent_count");
        set => SetArgument("max_concurrent_count", value);
    }

    /// <summary>
    /// The max_concurrent_percentage attribute.
    /// </summary>
    public TerraformValue<double>? MaxConcurrentPercentage
    {
        get => GetArgument<TerraformValue<double>>("max_concurrent_percentage");
        set => SetArgument("max_concurrent_percentage", value);
    }

    /// <summary>
    /// The region_concurrency_type attribute.
    /// </summary>
    public TerraformValue<string>? RegionConcurrencyType
    {
        get => GetArgument<TerraformValue<string>>("region_concurrency_type");
        set => SetArgument("region_concurrency_type", value);
    }

    /// <summary>
    /// The region_order attribute.
    /// </summary>
    public TerraformList<string>? RegionOrder
    {
        get => GetArgument<TerraformList<string>>("region_order");
        set => SetArgument("region_order", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsCloudformationStackSet.
/// Nesting mode: single
/// </summary>
public class AwsCloudformationStackSetTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

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
/// Represents a aws_cloudformation_stack_set Terraform resource.
/// Manages a aws_cloudformation_stack_set resource.
/// </summary>
public partial class AwsCloudformationStackSet(string name) : TerraformResource("aws_cloudformation_stack_set", name)
{
    /// <summary>
    /// The administration_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? AdministrationRoleArn
    {
        get => GetArgument<TerraformValue<string>>("administration_role_arn");
        set => SetArgument("administration_role_arn", value);
    }

    /// <summary>
    /// The call_as attribute.
    /// </summary>
    public TerraformValue<string>? CallAs
    {
        get => GetArgument<TerraformValue<string>>("call_as");
        set => SetArgument("call_as", value);
    }

    /// <summary>
    /// The capabilities attribute.
    /// </summary>
    public TerraformSet<string>? Capabilities
    {
        get => GetArgument<TerraformSet<string>>("capabilities");
        set => SetArgument("capabilities", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The execution_role_name attribute.
    /// </summary>
    public TerraformValue<string> ExecutionRoleName
    {
        get => GetArgument<TerraformValue<string>>("execution_role_name") ?? AsReference("execution_role_name");
        set => SetArgument("execution_role_name", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => GetArgument<TerraformMap<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The permission_model attribute.
    /// </summary>
    public TerraformValue<string>? PermissionModel
    {
        get => GetArgument<TerraformValue<string>>("permission_model");
        set => SetArgument("permission_model", value);
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
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    public TerraformValue<string> TemplateBody
    {
        get => GetArgument<TerraformValue<string>>("template_body") ?? AsReference("template_body");
        set => SetArgument("template_body", value);
    }

    /// <summary>
    /// The template_url attribute.
    /// </summary>
    public TerraformValue<string>? TemplateUrl
    {
        get => GetArgument<TerraformValue<string>>("template_url");
        set => SetArgument("template_url", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The stack_set_id attribute.
    /// </summary>
    public TerraformValue<string> StackSetId
        => AsReference("stack_set_id");

    /// <summary>
    /// AutoDeployment block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoDeployment block(s) allowed")]
    public TerraformList<AwsCloudformationStackSetAutoDeploymentBlock>? AutoDeployment
    {
        get => GetArgument<TerraformList<AwsCloudformationStackSetAutoDeploymentBlock>>("auto_deployment");
        set => SetArgument("auto_deployment", value);
    }

    /// <summary>
    /// ManagedExecution block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedExecution block(s) allowed")]
    public TerraformList<AwsCloudformationStackSetManagedExecutionBlock>? ManagedExecution
    {
        get => GetArgument<TerraformList<AwsCloudformationStackSetManagedExecutionBlock>>("managed_execution");
        set => SetArgument("managed_execution", value);
    }

    /// <summary>
    /// OperationPreferences block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OperationPreferences block(s) allowed")]
    public TerraformList<AwsCloudformationStackSetOperationPreferencesBlock>? OperationPreferences
    {
        get => GetArgument<TerraformList<AwsCloudformationStackSetOperationPreferencesBlock>>("operation_preferences");
        set => SetArgument("operation_preferences", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsCloudformationStackSetTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsCloudformationStackSetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
