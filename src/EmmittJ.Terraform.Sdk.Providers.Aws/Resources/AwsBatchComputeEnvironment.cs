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
        get => GetProperty<TerraformProperty<string>>("allocation_strategy");
        set => WithProperty("allocation_strategy", value);
    }

    /// <summary>
    /// The bid_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? BidPercentage
    {
        get => GetProperty<TerraformProperty<double>>("bid_percentage");
        set => WithProperty("bid_percentage", value);
    }

    /// <summary>
    /// The desired_vcpus attribute.
    /// </summary>
    public TerraformProperty<double>? DesiredVcpus
    {
        get => GetProperty<TerraformProperty<double>>("desired_vcpus");
        set => WithProperty("desired_vcpus", value);
    }

    /// <summary>
    /// The ec2_key_pair attribute.
    /// </summary>
    public TerraformProperty<string>? Ec2KeyPair
    {
        get => GetProperty<TerraformProperty<string>>("ec2_key_pair");
        set => WithProperty("ec2_key_pair", value);
    }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformProperty<string>? ImageId
    {
        get => GetProperty<TerraformProperty<string>>("image_id");
        set => WithProperty("image_id", value);
    }

    /// <summary>
    /// The instance_role attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceRole
    {
        get => GetProperty<TerraformProperty<string>>("instance_role");
        set => WithProperty("instance_role", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? InstanceType
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("instance_type");
        set => WithProperty("instance_type", value);
    }

    /// <summary>
    /// The max_vcpus attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxVcpus is required")]
    public required TerraformProperty<double> MaxVcpus
    {
        get => GetProperty<TerraformProperty<double>>("max_vcpus");
        set => WithProperty("max_vcpus", value);
    }

    /// <summary>
    /// The min_vcpus attribute.
    /// </summary>
    public TerraformProperty<double>? MinVcpus
    {
        get => GetProperty<TerraformProperty<double>>("min_vcpus");
        set => WithProperty("min_vcpus", value);
    }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    public TerraformProperty<string>? PlacementGroup
    {
        get => GetProperty<TerraformProperty<string>>("placement_group");
        set => WithProperty("placement_group", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The spot_iam_fleet_role attribute.
    /// </summary>
    public TerraformProperty<string>? SpotIamFleetRole
    {
        get => GetProperty<TerraformProperty<string>>("spot_iam_fleet_role");
        set => WithProperty("spot_iam_fleet_role", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public HashSet<TerraformProperty<string>>? Subnets
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnets");
        set => WithProperty("subnets", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => WithProperty("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
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
        get => GetProperty<TerraformProperty<string>>("eks_cluster_arn");
        set => WithProperty("eks_cluster_arn", value);
    }

    /// <summary>
    /// The kubernetes_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesNamespace is required")]
    public required TerraformProperty<string> KubernetesNamespace
    {
        get => GetProperty<TerraformProperty<string>>("kubernetes_namespace");
        set => WithProperty("kubernetes_namespace", value);
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
        get => GetProperty<TerraformProperty<double>>("job_execution_timeout_minutes");
        set => WithProperty("job_execution_timeout_minutes", value);
    }

    /// <summary>
    /// The terminate_jobs_on_update attribute.
    /// </summary>
    public TerraformProperty<bool>? TerminateJobsOnUpdate
    {
        get => GetProperty<TerraformProperty<bool>>("terminate_jobs_on_update");
        set => WithProperty("terminate_jobs_on_update", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("ecs_cluster_arn");
        this.DeclareOutput("status");
        this.DeclareOutput("status_reason");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
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
    /// The service_role attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceRole
    {
        get => GetProperty<TerraformProperty<string>>("service_role");
        set => this.WithProperty("service_role", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => this.WithProperty("state", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for compute_resources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeResources block(s) allowed")]
    public List<AwsBatchComputeEnvironmentComputeResourcesBlock>? ComputeResources
    {
        get => GetProperty<List<AwsBatchComputeEnvironmentComputeResourcesBlock>>("compute_resources");
        set => this.WithProperty("compute_resources", value);
    }

    /// <summary>
    /// Block for eks_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EksConfiguration block(s) allowed")]
    public List<AwsBatchComputeEnvironmentEksConfigurationBlock>? EksConfiguration
    {
        get => GetProperty<List<AwsBatchComputeEnvironmentEksConfigurationBlock>>("eks_configuration");
        set => this.WithProperty("eks_configuration", value);
    }

    /// <summary>
    /// Block for update_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpdatePolicy block(s) allowed")]
    public List<AwsBatchComputeEnvironmentUpdatePolicyBlock>? UpdatePolicy
    {
        get => GetProperty<List<AwsBatchComputeEnvironmentUpdatePolicyBlock>>("update_policy");
        set => this.WithProperty("update_policy", value);
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
