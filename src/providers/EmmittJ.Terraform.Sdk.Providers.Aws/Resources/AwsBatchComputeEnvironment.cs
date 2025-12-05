using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for compute_resources in AwsBatchComputeEnvironment.
/// Nesting mode: list
/// </summary>
public class AwsBatchComputeEnvironmentComputeResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "compute_resources";

    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    public TerraformValue<string>? AllocationStrategy
    {
        get => GetArgument<TerraformValue<string>>("allocation_strategy");
        set => SetArgument("allocation_strategy", value);
    }

    /// <summary>
    /// The bid_percentage attribute.
    /// </summary>
    public TerraformValue<double>? BidPercentage
    {
        get => GetArgument<TerraformValue<double>>("bid_percentage");
        set => SetArgument("bid_percentage", value);
    }

    /// <summary>
    /// The desired_vcpus attribute.
    /// </summary>
    public TerraformValue<double> DesiredVcpus
    {
        get => GetArgument<TerraformValue<double>>("desired_vcpus") ?? CreateReference("desired_vcpus");
        set => SetArgument("desired_vcpus", value);
    }

    /// <summary>
    /// The ec2_key_pair attribute.
    /// </summary>
    public TerraformValue<string>? Ec2KeyPair
    {
        get => GetArgument<TerraformValue<string>>("ec2_key_pair");
        set => SetArgument("ec2_key_pair", value);
    }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformValue<string>? ImageId
    {
        get => GetArgument<TerraformValue<string>>("image_id");
        set => SetArgument("image_id", value);
    }

    /// <summary>
    /// The instance_role attribute.
    /// </summary>
    public TerraformValue<string>? InstanceRole
    {
        get => GetArgument<TerraformValue<string>>("instance_role");
        set => SetArgument("instance_role", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformSet<string>? InstanceType
    {
        get => GetArgument<TerraformSet<string>>("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The max_vcpus attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxVcpus is required")]
    public required TerraformValue<double> MaxVcpus
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_vcpus");
        set => SetArgument("max_vcpus", value);
    }

    /// <summary>
    /// The min_vcpus attribute.
    /// </summary>
    public TerraformValue<double>? MinVcpus
    {
        get => GetArgument<TerraformValue<double>>("min_vcpus");
        set => SetArgument("min_vcpus", value);
    }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    public TerraformValue<string>? PlacementGroup
    {
        get => GetArgument<TerraformValue<string>>("placement_group");
        set => SetArgument("placement_group", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The spot_iam_fleet_role attribute.
    /// </summary>
    public TerraformValue<string>? SpotIamFleetRole
    {
        get => GetArgument<TerraformValue<string>>("spot_iam_fleet_role");
        set => SetArgument("spot_iam_fleet_role", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subnets is required")]
    public required TerraformSet<string> Subnets
    {
        get => GetRequiredArgument<TerraformSet<string>>("subnets");
        set => SetArgument("subnets", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Ec2Configuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 Ec2Configuration block(s) allowed")]
    public TerraformList<AwsBatchComputeEnvironmentComputeResourcesBlockEc2ConfigurationBlock>? Ec2Configuration
    {
        get => GetArgument<TerraformList<AwsBatchComputeEnvironmentComputeResourcesBlockEc2ConfigurationBlock>>("ec2_configuration");
        set => SetArgument("ec2_configuration", value);
    }

    /// <summary>
    /// LaunchTemplate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchTemplate block(s) allowed")]
    public TerraformList<AwsBatchComputeEnvironmentComputeResourcesBlockLaunchTemplateBlock>? LaunchTemplate
    {
        get => GetArgument<TerraformList<AwsBatchComputeEnvironmentComputeResourcesBlockLaunchTemplateBlock>>("launch_template");
        set => SetArgument("launch_template", value);
    }

}

/// <summary>
/// Block type for ec2_configuration in AwsBatchComputeEnvironmentComputeResourcesBlock.
/// Nesting mode: list
/// </summary>
public class AwsBatchComputeEnvironmentComputeResourcesBlockEc2ConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ec2_configuration";

    /// <summary>
    /// The image_id_override attribute.
    /// </summary>
    public TerraformValue<string> ImageIdOverride
    {
        get => GetArgument<TerraformValue<string>>("image_id_override") ?? CreateReference("image_id_override");
        set => SetArgument("image_id_override", value);
    }

    /// <summary>
    /// The image_kubernetes_version attribute.
    /// </summary>
    public TerraformValue<string>? ImageKubernetesVersion
    {
        get => GetArgument<TerraformValue<string>>("image_kubernetes_version");
        set => SetArgument("image_kubernetes_version", value);
    }

    /// <summary>
    /// The image_type attribute.
    /// </summary>
    public TerraformValue<string>? ImageType
    {
        get => GetArgument<TerraformValue<string>>("image_type");
        set => SetArgument("image_type", value);
    }

}

/// <summary>
/// Block type for launch_template in AwsBatchComputeEnvironmentComputeResourcesBlock.
/// Nesting mode: list
/// </summary>
public class AwsBatchComputeEnvironmentComputeResourcesBlockLaunchTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "launch_template";

    /// <summary>
    /// The launch_template_id attribute.
    /// </summary>
    public TerraformValue<string>? LaunchTemplateId
    {
        get => GetArgument<TerraformValue<string>>("launch_template_id");
        set => SetArgument("launch_template_id", value);
    }

    /// <summary>
    /// The launch_template_name attribute.
    /// </summary>
    public TerraformValue<string>? LaunchTemplateName
    {
        get => GetArgument<TerraformValue<string>>("launch_template_name");
        set => SetArgument("launch_template_name", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => GetArgument<TerraformValue<string>>("version") ?? CreateReference("version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for eks_configuration in AwsBatchComputeEnvironment.
/// Nesting mode: list
/// </summary>
public class AwsBatchComputeEnvironmentEksConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eks_configuration";

    /// <summary>
    /// The eks_cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EksClusterArn is required")]
    public required TerraformValue<string> EksClusterArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("eks_cluster_arn");
        set => SetArgument("eks_cluster_arn", value);
    }

    /// <summary>
    /// The kubernetes_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesNamespace is required")]
    public required TerraformValue<string> KubernetesNamespace
    {
        get => GetRequiredArgument<TerraformValue<string>>("kubernetes_namespace");
        set => SetArgument("kubernetes_namespace", value);
    }

}


/// <summary>
/// Block type for update_policy in AwsBatchComputeEnvironment.
/// Nesting mode: list
/// </summary>
public class AwsBatchComputeEnvironmentUpdatePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "update_policy";

    /// <summary>
    /// The job_execution_timeout_minutes attribute.
    /// </summary>
    public TerraformValue<double> JobExecutionTimeoutMinutes
    {
        get => GetArgument<TerraformValue<double>>("job_execution_timeout_minutes") ?? CreateReference("job_execution_timeout_minutes");
        set => SetArgument("job_execution_timeout_minutes", value);
    }

    /// <summary>
    /// The terminate_jobs_on_update attribute.
    /// </summary>
    public TerraformValue<bool> TerminateJobsOnUpdate
    {
        get => GetArgument<TerraformValue<bool>>("terminate_jobs_on_update") ?? CreateReference("terminate_jobs_on_update");
        set => SetArgument("terminate_jobs_on_update", value);
    }

}


/// <summary>
/// Represents a aws_batch_compute_environment Terraform resource.
/// Manages a aws_batch_compute_environment resource.
/// </summary>
public partial class AwsBatchComputeEnvironment(string name) : TerraformResource("aws_batch_compute_environment", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix") ?? CreateReference("name_prefix");
        set => SetArgument("name_prefix", value);
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
    /// The service_role attribute.
    /// </summary>
    public TerraformValue<string> ServiceRole
    {
        get => GetArgument<TerraformValue<string>>("service_role") ?? CreateReference("service_role");
        set => SetArgument("service_role", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string>? State
    {
        get => GetArgument<TerraformValue<string>>("state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The ecs_cluster_arn attribute.
    /// </summary>
    public TerraformValue<string> EcsClusterArn
        => CreateReference("ecs_cluster_arn");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    public TerraformValue<string> StatusReason
        => CreateReference("status_reason");

    /// <summary>
    /// ComputeResources block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeResources block(s) allowed")]
    public TerraformList<AwsBatchComputeEnvironmentComputeResourcesBlock>? ComputeResources
    {
        get => GetArgument<TerraformList<AwsBatchComputeEnvironmentComputeResourcesBlock>>("compute_resources");
        set => SetArgument("compute_resources", value);
    }

    /// <summary>
    /// EksConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EksConfiguration block(s) allowed")]
    public TerraformList<AwsBatchComputeEnvironmentEksConfigurationBlock>? EksConfiguration
    {
        get => GetArgument<TerraformList<AwsBatchComputeEnvironmentEksConfigurationBlock>>("eks_configuration");
        set => SetArgument("eks_configuration", value);
    }

    /// <summary>
    /// UpdatePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpdatePolicy block(s) allowed")]
    public TerraformList<AwsBatchComputeEnvironmentUpdatePolicyBlock>? UpdatePolicy
    {
        get => GetArgument<TerraformList<AwsBatchComputeEnvironmentUpdatePolicyBlock>>("update_policy");
        set => SetArgument("update_policy", value);
    }

}
