using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ecs_cluster Terraform data source.
/// Retrieves information about a aws_ecs_cluster.
/// </summary>
public partial class AwsEcsClusterDataSource(string name) : TerraformDataSource("aws_ecs_cluster", name)
{
    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformValue<string> ClusterName
    {
        get => GetRequiredArgument<TerraformValue<string>>("cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The pending_tasks_count attribute.
    /// </summary>
    public TerraformValue<double> PendingTasksCount
        => CreateReference("pending_tasks_count");

    /// <summary>
    /// The registered_container_instances_count attribute.
    /// </summary>
    public TerraformValue<double> RegisteredContainerInstancesCount
        => CreateReference("registered_container_instances_count");

    /// <summary>
    /// The running_tasks_count attribute.
    /// </summary>
    public TerraformValue<double> RunningTasksCount
        => CreateReference("running_tasks_count");

    /// <summary>
    /// The service_connect_defaults attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServiceConnectDefaults
        => CreateReference("service_connect_defaults");

    /// <summary>
    /// The setting attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Setting
        => CreateReference("setting");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

}
