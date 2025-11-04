using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecs_task_execution.
/// </summary>
public class AwsEcsTaskExecutionDataSource : TerraformDataSource
{
    public AwsEcsTaskExecutionDataSource(string name) : base("aws_ecs_task_execution", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("task_arns");
    }

    /// <summary>
    /// The client_token attribute.
    /// </summary>
    public string? ClientToken
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_token")?.Value;
        set => this.WithProperty("client_token", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    public string? Cluster
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster")?.Value;
        set => this.WithProperty("cluster", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The desired_count attribute.
    /// </summary>
    public double? DesiredCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("desired_count")?.Value;
        set => this.WithProperty("desired_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The enable_ecs_managed_tags attribute.
    /// </summary>
    public bool? EnableEcsManagedTags
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_ecs_managed_tags")?.Value;
        set => this.WithProperty("enable_ecs_managed_tags", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_execute_command attribute.
    /// </summary>
    public bool? EnableExecuteCommand
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_execute_command")?.Value;
        set => this.WithProperty("enable_execute_command", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The group attribute.
    /// </summary>
    public string? Group
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group")?.Value;
        set => this.WithProperty("group", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The launch_type attribute.
    /// </summary>
    public string? LaunchType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("launch_type")?.Value;
        set => this.WithProperty("launch_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    public string? PlatformVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("platform_version")?.Value;
        set => this.WithProperty("platform_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public string? PropagateTags
    {
        get => GetProperty<TerraformLiteralProperty<string>>("propagate_tags")?.Value;
        set => this.WithProperty("propagate_tags", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The reference_id attribute.
    /// </summary>
    public string? ReferenceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("reference_id")?.Value;
        set => this.WithProperty("reference_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The started_by attribute.
    /// </summary>
    public string? StartedBy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("started_by")?.Value;
        set => this.WithProperty("started_by", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    public string? TaskDefinition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("task_definition")?.Value;
        set => this.WithProperty("task_definition", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The task_arns attribute.
    /// </summary>
    public TerraformExpression TaskArns => this["task_arns"];

}
