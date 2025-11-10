using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for compute_resources in .
/// Nesting mode: list
/// </summary>
public class AwsBatchComputeEnvironmentComputeResourcesBlock : ITerraformBlock
{
    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    [TerraformPropertyName("allocation_strategy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AllocationStrategy { get; set; }

    /// <summary>
    /// The bid_percentage attribute.
    /// </summary>
    [TerraformPropertyName("bid_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BidPercentage { get; set; }

    /// <summary>
    /// The desired_vcpus attribute.
    /// </summary>
    [TerraformPropertyName("desired_vcpus")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> DesiredVcpus { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "desired_vcpus");

    /// <summary>
    /// The ec2_key_pair attribute.
    /// </summary>
    [TerraformPropertyName("ec2_key_pair")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Ec2KeyPair { get; set; }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [TerraformPropertyName("image_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ImageId { get; set; }

    /// <summary>
    /// The instance_role attribute.
    /// </summary>
    [TerraformPropertyName("instance_role")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InstanceRole { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? InstanceType { get; set; }

    /// <summary>
    /// The max_vcpus attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxVcpus is required")]
    [TerraformPropertyName("max_vcpus")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxVcpus { get; set; }

    /// <summary>
    /// The min_vcpus attribute.
    /// </summary>
    [TerraformPropertyName("min_vcpus")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinVcpus { get; set; }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    [TerraformPropertyName("placement_group")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PlacementGroup { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The spot_iam_fleet_role attribute.
    /// </summary>
    [TerraformPropertyName("spot_iam_fleet_role")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SpotIamFleetRole { get; set; }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    [TerraformPropertyName("subnets")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Subnets { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for eks_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsBatchComputeEnvironmentEksConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The eks_cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EksClusterArn is required")]
    [TerraformPropertyName("eks_cluster_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EksClusterArn { get; set; }

    /// <summary>
    /// The kubernetes_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesNamespace is required")]
    [TerraformPropertyName("kubernetes_namespace")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KubernetesNamespace { get; set; }

}

/// <summary>
/// Block type for update_policy in .
/// Nesting mode: list
/// </summary>
public class AwsBatchComputeEnvironmentUpdatePolicyBlock : ITerraformBlock
{
    /// <summary>
    /// The job_execution_timeout_minutes attribute.
    /// </summary>
    [TerraformPropertyName("job_execution_timeout_minutes")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> JobExecutionTimeoutMinutes { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "job_execution_timeout_minutes");

    /// <summary>
    /// The terminate_jobs_on_update attribute.
    /// </summary>
    [TerraformPropertyName("terminate_jobs_on_update")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> TerminateJobsOnUpdate { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "terminate_jobs_on_update");

}

/// <summary>
/// Manages a aws_batch_compute_environment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsBatchComputeEnvironment : TerraformResource
{
    public AwsBatchComputeEnvironment(string name) : base("aws_batch_compute_environment", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> NamePrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name_prefix");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [TerraformPropertyName("service_role")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ServiceRole { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_role");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? State { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// Block for compute_resources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeResources block(s) allowed")]
    [TerraformPropertyName("compute_resources")]
    public TerraformList<TerraformBlock<AwsBatchComputeEnvironmentComputeResourcesBlock>>? ComputeResources { get; set; } = new();

    /// <summary>
    /// Block for eks_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EksConfiguration block(s) allowed")]
    [TerraformPropertyName("eks_configuration")]
    public TerraformList<TerraformBlock<AwsBatchComputeEnvironmentEksConfigurationBlock>>? EksConfiguration { get; set; } = new();

    /// <summary>
    /// Block for update_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpdatePolicy block(s) allowed")]
    [TerraformPropertyName("update_policy")]
    public TerraformList<TerraformBlock<AwsBatchComputeEnvironmentUpdatePolicyBlock>>? UpdatePolicy { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The ecs_cluster_arn attribute.
    /// </summary>
    [TerraformPropertyName("ecs_cluster_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EcsClusterArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ecs_cluster_arn");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    [TerraformPropertyName("status_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StatusReason => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status_reason");

}
