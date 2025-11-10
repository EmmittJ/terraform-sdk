using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for targets in .
/// Nesting mode: list
/// </summary>
public class AwsSsmMaintenanceWindowTaskTargetsBlock : TerraformBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        set => SetProperty("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public List<TerraformProperty<string>>? Values
    {
        set => SetProperty("values", value);
    }

}

/// <summary>
/// Block type for task_invocation_parameters in .
/// Nesting mode: list
/// </summary>
public class AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_ssm_maintenance_window_task resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSsmMaintenanceWindowTask : TerraformResource
{
    public AwsSsmMaintenanceWindowTask(string name) : base("aws_ssm_maintenance_window_task", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("window_task_id");
        SetOutput("cutoff_behavior");
        SetOutput("description");
        SetOutput("id");
        SetOutput("max_concurrency");
        SetOutput("max_errors");
        SetOutput("name");
        SetOutput("priority");
        SetOutput("region");
        SetOutput("service_role_arn");
        SetOutput("task_arn");
        SetOutput("task_type");
        SetOutput("window_id");
    }

    /// <summary>
    /// The cutoff_behavior attribute.
    /// </summary>
    public TerraformProperty<string> CutoffBehavior
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cutoff_behavior");
        set => SetProperty("cutoff_behavior", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The max_concurrency attribute.
    /// </summary>
    public TerraformProperty<string> MaxConcurrency
    {
        get => GetRequiredOutput<TerraformProperty<string>>("max_concurrency");
        set => SetProperty("max_concurrency", value);
    }

    /// <summary>
    /// The max_errors attribute.
    /// </summary>
    public TerraformProperty<string> MaxErrors
    {
        get => GetRequiredOutput<TerraformProperty<string>>("max_errors");
        set => SetProperty("max_errors", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<double> Priority
    {
        get => GetRequiredOutput<TerraformProperty<double>>("priority");
        set => SetProperty("priority", value);
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
    /// The service_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> ServiceRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_role_arn");
        set => SetProperty("service_role_arn", value);
    }

    /// <summary>
    /// The task_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskArn is required")]
    public required TerraformProperty<string> TaskArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("task_arn");
        set => SetProperty("task_arn", value);
    }

    /// <summary>
    /// The task_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskType is required")]
    public required TerraformProperty<string> TaskType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("task_type");
        set => SetProperty("task_type", value);
    }

    /// <summary>
    /// The window_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WindowId is required")]
    public required TerraformProperty<string> WindowId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("window_id");
        set => SetProperty("window_id", value);
    }

    /// <summary>
    /// Block for targets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 Targets block(s) allowed")]
    public List<AwsSsmMaintenanceWindowTaskTargetsBlock>? Targets
    {
        set => SetProperty("targets", value);
    }

    /// <summary>
    /// Block for task_invocation_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TaskInvocationParameters block(s) allowed")]
    public List<AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlock>? TaskInvocationParameters
    {
        set => SetProperty("task_invocation_parameters", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The window_task_id attribute.
    /// </summary>
    public TerraformExpression WindowTaskId => this["window_task_id"];

}
