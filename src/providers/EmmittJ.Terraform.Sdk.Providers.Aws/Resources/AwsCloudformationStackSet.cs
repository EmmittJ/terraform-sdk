using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_deployment in .
/// Nesting mode: list
/// </summary>
public class AwsCloudformationStackSetAutoDeploymentBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The retain_stacks_on_account_removal attribute.
    /// </summary>
    public TerraformProperty<bool>? RetainStacksOnAccountRemoval
    {
        set => SetProperty("retain_stacks_on_account_removal", value);
    }

}

/// <summary>
/// Block type for managed_execution in .
/// Nesting mode: list
/// </summary>
public class AwsCloudformationStackSetManagedExecutionBlock : TerraformBlock
{
    /// <summary>
    /// The active attribute.
    /// </summary>
    public TerraformProperty<bool>? Active
    {
        set => SetProperty("active", value);
    }

}

/// <summary>
/// Block type for operation_preferences in .
/// Nesting mode: list
/// </summary>
public class AwsCloudformationStackSetOperationPreferencesBlock : TerraformBlock
{
    /// <summary>
    /// The failure_tolerance_count attribute.
    /// </summary>
    public TerraformProperty<double>? FailureToleranceCount
    {
        set => SetProperty("failure_tolerance_count", value);
    }

    /// <summary>
    /// The failure_tolerance_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? FailureTolerancePercentage
    {
        set => SetProperty("failure_tolerance_percentage", value);
    }

    /// <summary>
    /// The max_concurrent_count attribute.
    /// </summary>
    public TerraformProperty<double>? MaxConcurrentCount
    {
        set => SetProperty("max_concurrent_count", value);
    }

    /// <summary>
    /// The max_concurrent_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? MaxConcurrentPercentage
    {
        set => SetProperty("max_concurrent_percentage", value);
    }

    /// <summary>
    /// The region_concurrency_type attribute.
    /// </summary>
    public TerraformProperty<string>? RegionConcurrencyType
    {
        set => SetProperty("region_concurrency_type", value);
    }

    /// <summary>
    /// The region_order attribute.
    /// </summary>
    public List<TerraformProperty<string>>? RegionOrder
    {
        set => SetProperty("region_order", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsCloudformationStackSetTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_cloudformation_stack_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudformationStackSet : TerraformResource
{
    public AwsCloudformationStackSet(string name) : base("aws_cloudformation_stack_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("stack_set_id");
        SetOutput("administration_role_arn");
        SetOutput("call_as");
        SetOutput("capabilities");
        SetOutput("description");
        SetOutput("execution_role_name");
        SetOutput("id");
        SetOutput("name");
        SetOutput("parameters");
        SetOutput("permission_model");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("template_body");
        SetOutput("template_url");
    }

    /// <summary>
    /// The administration_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> AdministrationRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("administration_role_arn");
        set => SetProperty("administration_role_arn", value);
    }

    /// <summary>
    /// The call_as attribute.
    /// </summary>
    public TerraformProperty<string> CallAs
    {
        get => GetRequiredOutput<TerraformProperty<string>>("call_as");
        set => SetProperty("call_as", value);
    }

    /// <summary>
    /// The capabilities attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Capabilities
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("capabilities");
        set => SetProperty("capabilities", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The execution_role_name attribute.
    /// </summary>
    public TerraformProperty<string> ExecutionRoleName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("execution_role_name");
        set => SetProperty("execution_role_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Parameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => SetProperty("parameters", value);
    }

    /// <summary>
    /// The permission_model attribute.
    /// </summary>
    public TerraformProperty<string> PermissionModel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("permission_model");
        set => SetProperty("permission_model", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    public TerraformProperty<string> TemplateBody
    {
        get => GetRequiredOutput<TerraformProperty<string>>("template_body");
        set => SetProperty("template_body", value);
    }

    /// <summary>
    /// The template_url attribute.
    /// </summary>
    public TerraformProperty<string> TemplateUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("template_url");
        set => SetProperty("template_url", value);
    }

    /// <summary>
    /// Block for auto_deployment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoDeployment block(s) allowed")]
    public List<AwsCloudformationStackSetAutoDeploymentBlock>? AutoDeployment
    {
        set => SetProperty("auto_deployment", value);
    }

    /// <summary>
    /// Block for managed_execution.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedExecution block(s) allowed")]
    public List<AwsCloudformationStackSetManagedExecutionBlock>? ManagedExecution
    {
        set => SetProperty("managed_execution", value);
    }

    /// <summary>
    /// Block for operation_preferences.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OperationPreferences block(s) allowed")]
    public List<AwsCloudformationStackSetOperationPreferencesBlock>? OperationPreferences
    {
        set => SetProperty("operation_preferences", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsCloudformationStackSetTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The stack_set_id attribute.
    /// </summary>
    public TerraformExpression StackSetId => this["stack_set_id"];

}
