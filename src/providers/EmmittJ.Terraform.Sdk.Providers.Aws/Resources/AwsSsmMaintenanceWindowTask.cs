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
        get => GetRequiredProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public List<TerraformProperty<string>>? Values
    {
        get => GetProperty<List<TerraformProperty<string>>>("values");
        set => WithProperty("values", value);
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
        this.WithOutput("arn");
        this.WithOutput("window_task_id");
    }

    /// <summary>
    /// The cutoff_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? CutoffBehavior
    {
        get => GetProperty<TerraformProperty<string>>("cutoff_behavior");
        set => this.WithProperty("cutoff_behavior", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The max_concurrency attribute.
    /// </summary>
    public TerraformProperty<string>? MaxConcurrency
    {
        get => GetProperty<TerraformProperty<string>>("max_concurrency");
        set => this.WithProperty("max_concurrency", value);
    }

    /// <summary>
    /// The max_errors attribute.
    /// </summary>
    public TerraformProperty<string>? MaxErrors
    {
        get => GetProperty<TerraformProperty<string>>("max_errors");
        set => this.WithProperty("max_errors", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<double>? Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The service_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("service_role_arn");
        set => this.WithProperty("service_role_arn", value);
    }

    /// <summary>
    /// The task_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskArn is required")]
    public required TerraformProperty<string> TaskArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("task_arn");
        set => this.WithProperty("task_arn", value);
    }

    /// <summary>
    /// The task_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskType is required")]
    public required TerraformProperty<string> TaskType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("task_type");
        set => this.WithProperty("task_type", value);
    }

    /// <summary>
    /// The window_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WindowId is required")]
    public required TerraformProperty<string> WindowId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("window_id");
        set => this.WithProperty("window_id", value);
    }

    /// <summary>
    /// Block for targets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 Targets block(s) allowed")]
    public List<AwsSsmMaintenanceWindowTaskTargetsBlock>? Targets
    {
        get => GetProperty<List<AwsSsmMaintenanceWindowTaskTargetsBlock>>("targets");
        set => this.WithProperty("targets", value);
    }

    /// <summary>
    /// Block for task_invocation_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TaskInvocationParameters block(s) allowed")]
    public List<AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlock>? TaskInvocationParameters
    {
        get => GetProperty<List<AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlock>>("task_invocation_parameters");
        set => this.WithProperty("task_invocation_parameters", value);
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
