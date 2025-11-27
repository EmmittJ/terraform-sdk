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
        get => new TerraformReference<string>(this, "cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The pending_tasks_count attribute.
    /// </summary>
    public TerraformValue<double> PendingTasksCount
    {
        get => new TerraformReference<double>(this, "pending_tasks_count");
    }

    /// <summary>
    /// The registered_container_instances_count attribute.
    /// </summary>
    public TerraformValue<double> RegisteredContainerInstancesCount
    {
        get => new TerraformReference<double>(this, "registered_container_instances_count");
    }

    /// <summary>
    /// The running_tasks_count attribute.
    /// </summary>
    public TerraformValue<double> RunningTasksCount
    {
        get => new TerraformReference<double>(this, "running_tasks_count");
    }

    /// <summary>
    /// The service_connect_defaults attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ServiceConnectDefaults
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "service_connect_defaults").ResolveNodes(ctx));
    }

    /// <summary>
    /// The setting attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Setting
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "setting").ResolveNodes(ctx));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}
