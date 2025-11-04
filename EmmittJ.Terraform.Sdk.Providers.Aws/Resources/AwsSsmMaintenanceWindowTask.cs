using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ssm_maintenance_window_task resource.
/// </summary>
public class AwsSsmMaintenanceWindowTask : TerraformResource
{
    public AwsSsmMaintenanceWindowTask(string name) : base("aws_ssm_maintenance_window_task", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("window_task_id");
    }

    /// <summary>
    /// The cutoff_behavior attribute.
    /// </summary>
    public string? CutoffBehavior
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cutoff_behavior")?.Value;
        set => this.WithProperty("cutoff_behavior", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The max_concurrency attribute.
    /// </summary>
    public string? MaxConcurrency
    {
        get => GetProperty<TerraformLiteralProperty<string>>("max_concurrency")?.Value;
        set => this.WithProperty("max_concurrency", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The max_errors attribute.
    /// </summary>
    public string? MaxErrors
    {
        get => GetProperty<TerraformLiteralProperty<string>>("max_errors")?.Value;
        set => this.WithProperty("max_errors", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public double? Priority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("priority")?.Value;
        set => this.WithProperty("priority", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_role_arn attribute.
    /// </summary>
    public string? ServiceRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_role_arn")?.Value;
        set => this.WithProperty("service_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The task_arn attribute.
    /// </summary>
    public string? TaskArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("task_arn")?.Value;
        set => this.WithProperty("task_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The task_type attribute.
    /// </summary>
    public string? TaskType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("task_type")?.Value;
        set => this.WithProperty("task_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The window_id attribute.
    /// </summary>
    public string? WindowId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("window_id")?.Value;
        set => this.WithProperty("window_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
