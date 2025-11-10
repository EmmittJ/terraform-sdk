using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for compute_resources in .
/// Nesting mode: list
/// </summary>
public class AwsBatchComputeEnvironmentComputeResourcesBlock : TerraformBlock
{
    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    public TerraformProperty<string>? AllocationStrategy
    {
        set => SetProperty("allocation_strategy", value);
    }

    /// <summary>
    /// The bid_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? BidPercentage
    {
        set => SetProperty("bid_percentage", value);
    }

    /// <summary>
    /// The desired_vcpus attribute.
    /// </summary>
    public TerraformProperty<double>? DesiredVcpus
    {
        set => SetProperty("desired_vcpus", value);
    }

    /// <summary>
    /// The ec2_key_pair attribute.
    /// </summary>
    public TerraformProperty<string>? Ec2KeyPair
    {
        set => SetProperty("ec2_key_pair", value);
    }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformProperty<string>? ImageId
    {
        set => SetProperty("image_id", value);
    }

    /// <summary>
    /// The instance_role attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceRole
    {
        set => SetProperty("instance_role", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? InstanceType
    {
        set => SetProperty("instance_type", value);
    }

    /// <summary>
    /// The max_vcpus attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxVcpus is required")]
    public required TerraformProperty<double> MaxVcpus
    {
        set => SetProperty("max_vcpus", value);
    }

    /// <summary>
    /// The min_vcpus attribute.
    /// </summary>
    public TerraformProperty<double>? MinVcpus
    {
        set => SetProperty("min_vcpus", value);
    }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    public TerraformProperty<string>? PlacementGroup
    {
        set => SetProperty("placement_group", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The spot_iam_fleet_role attribute.
    /// </summary>
    public TerraformProperty<string>? SpotIamFleetRole
    {
        set => SetProperty("spot_iam_fleet_role", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public HashSet<TerraformProperty<string>>? Subnets
    {
        set => SetProperty("subnets", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for eks_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsBatchComputeEnvironmentEksConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The eks_cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EksClusterArn is required")]
    public required TerraformProperty<string> EksClusterArn
    {
        set => SetProperty("eks_cluster_arn", value);
    }

    /// <summary>
    /// The kubernetes_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesNamespace is required")]
    public required TerraformProperty<string> KubernetesNamespace
    {
        set => SetProperty("kubernetes_namespace", value);
    }

}

/// <summary>
/// Block type for update_policy in .
/// Nesting mode: list
/// </summary>
public class AwsBatchComputeEnvironmentUpdatePolicyBlock : TerraformBlock
{
    /// <summary>
    /// The job_execution_timeout_minutes attribute.
    /// </summary>
    public TerraformProperty<double>? JobExecutionTimeoutMinutes
    {
        set => SetProperty("job_execution_timeout_minutes", value);
    }

    /// <summary>
    /// The terminate_jobs_on_update attribute.
    /// </summary>
    public TerraformProperty<bool>? TerminateJobsOnUpdate
    {
        set => SetProperty("terminate_jobs_on_update", value);
    }

}

/// <summary>
/// Manages a aws_batch_compute_environment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsBatchComputeEnvironment : TerraformResource
{
    public AwsBatchComputeEnvironment(string name) : base("aws_batch_compute_environment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("ecs_cluster_arn");
        SetOutput("status");
        SetOutput("status_reason");
        SetOutput("id");
        SetOutput("name");
        SetOutput("name_prefix");
        SetOutput("region");
        SetOutput("service_role");
        SetOutput("state");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("type");
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
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> NamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_prefix");
        set => SetProperty("name_prefix", value);
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
    /// The service_role attribute.
    /// </summary>
    public TerraformProperty<string> ServiceRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_role");
        set => SetProperty("service_role", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string> State
    {
        get => GetRequiredOutput<TerraformProperty<string>>("state");
        set => SetProperty("state", value);
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for compute_resources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeResources block(s) allowed")]
    public List<AwsBatchComputeEnvironmentComputeResourcesBlock>? ComputeResources
    {
        set => SetProperty("compute_resources", value);
    }

    /// <summary>
    /// Block for eks_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EksConfiguration block(s) allowed")]
    public List<AwsBatchComputeEnvironmentEksConfigurationBlock>? EksConfiguration
    {
        set => SetProperty("eks_configuration", value);
    }

    /// <summary>
    /// Block for update_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpdatePolicy block(s) allowed")]
    public List<AwsBatchComputeEnvironmentUpdatePolicyBlock>? UpdatePolicy
    {
        set => SetProperty("update_policy", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The ecs_cluster_arn attribute.
    /// </summary>
    public TerraformExpression EcsClusterArn => this["ecs_cluster_arn"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    public TerraformExpression StatusReason => this["status_reason"];

}
