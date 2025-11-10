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
        SetOutput("arn");
        SetOutput("pending_tasks_count");
        SetOutput("registered_container_instances_count");
        SetOutput("running_tasks_count");
        SetOutput("service_connect_defaults");
        SetOutput("setting");
        SetOutput("status");
        SetOutput("cluster_name");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformProperty<string> ClusterName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_name");
        set => SetProperty("cluster_name", value);
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
