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
    public TerraformLiteralProperty<string>? ClientToken
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_token");
        set => this.WithProperty("client_token", value);
    }

    /// <summary>
    /// The cluster attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Cluster
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster");
        set => this.WithProperty("cluster", value);
    }

    /// <summary>
    /// The desired_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? DesiredCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("desired_count");
        set => this.WithProperty("desired_count", value);
    }

    /// <summary>
    /// The enable_ecs_managed_tags attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableEcsManagedTags
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_ecs_managed_tags");
        set => this.WithProperty("enable_ecs_managed_tags", value);
    }

    /// <summary>
    /// The enable_execute_command attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableExecuteCommand
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_execute_command");
        set => this.WithProperty("enable_execute_command", value);
    }

    /// <summary>
    /// The group attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Group
    {
        get => GetProperty<TerraformLiteralProperty<string>>("group");
        set => this.WithProperty("group", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The launch_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LaunchType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("launch_type");
        set => this.WithProperty("launch_type", value);
    }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PlatformVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("platform_version");
        set => this.WithProperty("platform_version", value);
    }

    /// <summary>
    /// The propagate_tags attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PropagateTags
    {
        get => GetProperty<TerraformLiteralProperty<string>>("propagate_tags");
        set => this.WithProperty("propagate_tags", value);
    }

    /// <summary>
    /// The reference_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ReferenceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("reference_id");
        set => this.WithProperty("reference_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The started_by attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StartedBy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("started_by");
        set => this.WithProperty("started_by", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The task_definition attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TaskDefinition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("task_definition");
        set => this.WithProperty("task_definition", value);
    }

    /// <summary>
    /// The task_arns attribute.
    /// </summary>
    public TerraformExpression TaskArns => this["task_arns"];

}
