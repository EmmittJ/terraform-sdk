using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for compute_resources in .
/// Nesting mode: list
/// </summary>
public partial class AwsBatchComputeEnvironmentComputeResourcesBlock : TerraformBlockBase
{
    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    [TerraformProperty("allocation_strategy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AllocationStrategy { get; set; }

    /// <summary>
    /// The bid_percentage attribute.
    /// </summary>
    [TerraformProperty("bid_percentage")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BidPercentage { get; set; }

    /// <summary>
    /// The desired_vcpus attribute.
    /// </summary>
    [TerraformProperty("desired_vcpus")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> DesiredVcpus { get; set; }

    /// <summary>
    /// The ec2_key_pair attribute.
    /// </summary>
    [TerraformProperty("ec2_key_pair")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Ec2KeyPair { get; set; }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [TerraformProperty("image_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ImageId { get; set; }

    /// <summary>
    /// The instance_role attribute.
    /// </summary>
    [TerraformProperty("instance_role")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InstanceRole { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformProperty("instance_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? InstanceType { get; set; }

    /// <summary>
    /// The max_vcpus attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxVcpus is required")]
    [TerraformProperty("max_vcpus")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MaxVcpus { get; set; }

    /// <summary>
    /// The min_vcpus attribute.
    /// </summary>
    [TerraformProperty("min_vcpus")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinVcpus { get; set; }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    [TerraformProperty("placement_group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PlacementGroup { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The spot_iam_fleet_role attribute.
    /// </summary>
    [TerraformProperty("spot_iam_fleet_role")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SpotIamFleetRole { get; set; }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    [TerraformProperty("subnets")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Subnets { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for eks_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsBatchComputeEnvironmentEksConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The eks_cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EksClusterArn is required")]
    [TerraformProperty("eks_cluster_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EksClusterArn { get; set; }

    /// <summary>
    /// The kubernetes_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesNamespace is required")]
    [TerraformProperty("kubernetes_namespace")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KubernetesNamespace { get; set; }

}

/// <summary>
/// Block type for update_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsBatchComputeEnvironmentUpdatePolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The job_execution_timeout_minutes attribute.
    /// </summary>
    [TerraformProperty("job_execution_timeout_minutes")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> JobExecutionTimeoutMinutes { get; set; }

    /// <summary>
    /// The terminate_jobs_on_update attribute.
    /// </summary>
    [TerraformProperty("terminate_jobs_on_update")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> TerminateJobsOnUpdate { get; set; }

}

/// <summary>
/// Manages a aws_batch_compute_environment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsBatchComputeEnvironment : TerraformResource
{
    public AwsBatchComputeEnvironment(string name) : base("aws_batch_compute_environment", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [TerraformProperty("service_role")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ServiceRole { get; set; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? State { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for compute_resources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeResources block(s) allowed")]
    [TerraformProperty("compute_resources")]
    public partial TerraformList<TerraformBlock<AwsBatchComputeEnvironmentComputeResourcesBlock>>? ComputeResources { get; set; }

    /// <summary>
    /// Block for eks_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EksConfiguration block(s) allowed")]
    [TerraformProperty("eks_configuration")]
    public partial TerraformList<TerraformBlock<AwsBatchComputeEnvironmentEksConfigurationBlock>>? EksConfiguration { get; set; }

    /// <summary>
    /// Block for update_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpdatePolicy block(s) allowed")]
    [TerraformProperty("update_policy")]
    public partial TerraformList<TerraformBlock<AwsBatchComputeEnvironmentUpdatePolicyBlock>>? UpdatePolicy { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The ecs_cluster_arn attribute.
    /// </summary>
    [TerraformProperty("ecs_cluster_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EcsClusterArn { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    [TerraformProperty("status_reason")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StatusReason { get; }

}
