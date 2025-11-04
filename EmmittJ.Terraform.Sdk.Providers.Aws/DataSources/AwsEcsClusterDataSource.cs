using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ecs_cluster.
/// </summary>
public class AwsEcsClusterDataSource : TerraformDataSource
{
    public AwsEcsClusterDataSource(string name) : base("aws_ecs_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("pending_tasks_count");
        this.DeclareOutput("registered_container_instances_count");
        this.DeclareOutput("running_tasks_count");
        this.DeclareOutput("service_connect_defaults");
        this.DeclareOutput("setting");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public string? ClusterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_name")?.Value;
        set => this.WithProperty("cluster_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The pending_tasks_count attribute.
    /// </summary>
    public TerraformExpression PendingTasksCount => this["pending_tasks_count"];

    /// <summary>
    /// The registered_container_instances_count attribute.
    /// </summary>
    public TerraformExpression RegisteredContainerInstancesCount => this["registered_container_instances_count"];

    /// <summary>
    /// The running_tasks_count attribute.
    /// </summary>
    public TerraformExpression RunningTasksCount => this["running_tasks_count"];

    /// <summary>
    /// The service_connect_defaults attribute.
    /// </summary>
    public TerraformExpression ServiceConnectDefaults => this["service_connect_defaults"];

    /// <summary>
    /// The setting attribute.
    /// </summary>
    public TerraformExpression Setting => this["setting"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
