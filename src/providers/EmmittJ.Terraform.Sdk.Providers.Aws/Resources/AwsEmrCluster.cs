using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_termination_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsEmrClusterAutoTerminationPolicyBlock() : TerraformBlock("auto_termination_policy")
{
    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    [TerraformProperty("idle_timeout")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? IdleTimeout { get; set; }

}

/// <summary>
/// Block type for bootstrap_action in .
/// Nesting mode: list
/// </summary>
public partial class AwsEmrClusterBootstrapActionBlock() : TerraformBlock("bootstrap_action")
{
    /// <summary>
    /// The args attribute.
    /// </summary>
    [TerraformProperty("args")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Args { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformProperty("path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Path { get; set; }

}

/// <summary>
/// Block type for core_instance_fleet in .
/// Nesting mode: list
/// </summary>
public partial class AwsEmrClusterCoreInstanceFleetBlock() : TerraformBlock("core_instance_fleet")
{

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }



    /// <summary>
    /// The target_on_demand_capacity attribute.
    /// </summary>
    [TerraformProperty("target_on_demand_capacity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TargetOnDemandCapacity { get; set; }

    /// <summary>
    /// The target_spot_capacity attribute.
    /// </summary>
    [TerraformProperty("target_spot_capacity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TargetSpotCapacity { get; set; }

}

/// <summary>
/// Block type for core_instance_group in .
/// Nesting mode: list
/// </summary>
public partial class AwsEmrClusterCoreInstanceGroupBlock() : TerraformBlock("core_instance_group")
{
    /// <summary>
    /// The autoscaling_policy attribute.
    /// </summary>
    [TerraformProperty("autoscaling_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AutoscalingPolicy { get; set; }

    /// <summary>
    /// The bid_price attribute.
    /// </summary>
    [TerraformProperty("bid_price")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BidPrice { get; set; }


    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [TerraformProperty("instance_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? InstanceCount { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformProperty("instance_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

}

/// <summary>
/// Block type for ec2_attributes in .
/// Nesting mode: list
/// </summary>
public partial class AwsEmrClusterEc2AttributesBlock() : TerraformBlock("ec2_attributes")
{
    /// <summary>
    /// The additional_master_security_groups attribute.
    /// </summary>
    [TerraformProperty("additional_master_security_groups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdditionalMasterSecurityGroups { get; set; }

    /// <summary>
    /// The additional_slave_security_groups attribute.
    /// </summary>
    [TerraformProperty("additional_slave_security_groups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdditionalSlaveSecurityGroups { get; set; }

    /// <summary>
    /// The emr_managed_master_security_group attribute.
    /// </summary>
    [TerraformProperty("emr_managed_master_security_group")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EmrManagedMasterSecurityGroup { get; set; }

    /// <summary>
    /// The emr_managed_slave_security_group attribute.
    /// </summary>
    [TerraformProperty("emr_managed_slave_security_group")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EmrManagedSlaveSecurityGroup { get; set; }

    /// <summary>
    /// The instance_profile attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceProfile is required")]
    [TerraformProperty("instance_profile")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceProfile { get; set; }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformProperty("key_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyName { get; set; }

    /// <summary>
    /// The service_access_security_group attribute.
    /// </summary>
    [TerraformProperty("service_access_security_group")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ServiceAccessSecurityGroup { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SubnetId { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> SubnetIds { get; set; }

}

/// <summary>
/// Block type for kerberos_attributes in .
/// Nesting mode: list
/// </summary>
public partial class AwsEmrClusterKerberosAttributesBlock() : TerraformBlock("kerberos_attributes")
{
    /// <summary>
    /// The ad_domain_join_password attribute.
    /// </summary>
    [TerraformProperty("ad_domain_join_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdDomainJoinPassword { get; set; }

    /// <summary>
    /// The ad_domain_join_user attribute.
    /// </summary>
    [TerraformProperty("ad_domain_join_user")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdDomainJoinUser { get; set; }

    /// <summary>
    /// The cross_realm_trust_principal_password attribute.
    /// </summary>
    [TerraformProperty("cross_realm_trust_principal_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CrossRealmTrustPrincipalPassword { get; set; }

    /// <summary>
    /// The kdc_admin_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KdcAdminPassword is required")]
    [TerraformProperty("kdc_admin_password")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KdcAdminPassword { get; set; }

    /// <summary>
    /// The realm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Realm is required")]
    [TerraformProperty("realm")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Realm { get; set; }

}

/// <summary>
/// Block type for master_instance_fleet in .
/// Nesting mode: list
/// </summary>
public partial class AwsEmrClusterMasterInstanceFleetBlock() : TerraformBlock("master_instance_fleet")
{

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }



    /// <summary>
    /// The target_on_demand_capacity attribute.
    /// </summary>
    [TerraformProperty("target_on_demand_capacity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TargetOnDemandCapacity { get; set; }

    /// <summary>
    /// The target_spot_capacity attribute.
    /// </summary>
    [TerraformProperty("target_spot_capacity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TargetSpotCapacity { get; set; }

}

/// <summary>
/// Block type for master_instance_group in .
/// Nesting mode: list
/// </summary>
public partial class AwsEmrClusterMasterInstanceGroupBlock() : TerraformBlock("master_instance_group")
{
    /// <summary>
    /// The bid_price attribute.
    /// </summary>
    [TerraformProperty("bid_price")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BidPrice { get; set; }


    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [TerraformProperty("instance_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? InstanceCount { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformProperty("instance_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

}

/// <summary>
/// Manages a aws_emr_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEmrCluster : TerraformResource
{
    public AwsEmrCluster(string name) : base("aws_emr_cluster", name)
    {
    }

    /// <summary>
    /// The additional_info attribute.
    /// </summary>
    [TerraformProperty("additional_info")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdditionalInfo { get; set; }

    /// <summary>
    /// The applications attribute.
    /// </summary>
    [TerraformProperty("applications")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Applications { get; set; }

    /// <summary>
    /// The autoscaling_role attribute.
    /// </summary>
    [TerraformProperty("autoscaling_role")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AutoscalingRole { get; set; }

    /// <summary>
    /// The configurations attribute.
    /// </summary>
    [TerraformProperty("configurations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Configurations { get; set; }

    /// <summary>
    /// The configurations_json attribute.
    /// </summary>
    [TerraformProperty("configurations_json")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConfigurationsJson { get; set; }

    /// <summary>
    /// The custom_ami_id attribute.
    /// </summary>
    [TerraformProperty("custom_ami_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomAmiId { get; set; }

    /// <summary>
    /// The ebs_root_volume_size attribute.
    /// </summary>
    [TerraformProperty("ebs_root_volume_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? EbsRootVolumeSize { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The keep_job_flow_alive_when_no_steps attribute.
    /// </summary>
    [TerraformProperty("keep_job_flow_alive_when_no_steps")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> KeepJobFlowAliveWhenNoSteps { get; set; }

    /// <summary>
    /// The list_steps_states attribute.
    /// </summary>
    [TerraformProperty("list_steps_states")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? ListStepsStates { get; set; }

    /// <summary>
    /// The log_encryption_kms_key_id attribute.
    /// </summary>
    [TerraformProperty("log_encryption_kms_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LogEncryptionKmsKeyId { get; set; }

    /// <summary>
    /// The log_uri attribute.
    /// </summary>
    [TerraformProperty("log_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LogUri { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The os_release_label attribute.
    /// </summary>
    [TerraformProperty("os_release_label")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OsReleaseLabel { get; set; }

    /// <summary>
    /// The placement_group_config attribute.
    /// </summary>
    [TerraformProperty("placement_group_config")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<object>? PlacementGroupConfig { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The release_label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReleaseLabel is required")]
    [TerraformProperty("release_label")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ReleaseLabel { get; set; }

    /// <summary>
    /// The scale_down_behavior attribute.
    /// </summary>
    [TerraformProperty("scale_down_behavior")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ScaleDownBehavior { get; set; }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    [TerraformProperty("security_configuration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecurityConfiguration { get; set; }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRole is required")]
    [TerraformProperty("service_role")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceRole { get; set; }

    /// <summary>
    /// The step attribute.
    /// </summary>
    [TerraformProperty("step")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<object> Step { get; set; }

    /// <summary>
    /// The step_concurrency_level attribute.
    /// </summary>
    [TerraformProperty("step_concurrency_level")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? StepConcurrencyLevel { get; set; }

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
    /// The termination_protection attribute.
    /// </summary>
    [TerraformProperty("termination_protection")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> TerminationProtection { get; set; }

    /// <summary>
    /// The unhealthy_node_replacement attribute.
    /// </summary>
    [TerraformProperty("unhealthy_node_replacement")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UnhealthyNodeReplacement { get; set; }

    /// <summary>
    /// The visible_to_all_users attribute.
    /// </summary>
    [TerraformProperty("visible_to_all_users")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? VisibleToAllUsers { get; set; }

    /// <summary>
    /// Block for auto_termination_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoTerminationPolicy block(s) allowed")]
    [TerraformProperty("auto_termination_policy")]
    public TerraformList<AwsEmrClusterAutoTerminationPolicyBlock> AutoTerminationPolicy { get; set; } = new();

    /// <summary>
    /// Block for bootstrap_action.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("bootstrap_action")]
    public TerraformList<AwsEmrClusterBootstrapActionBlock> BootstrapAction { get; set; } = new();

    /// <summary>
    /// Block for core_instance_fleet.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CoreInstanceFleet block(s) allowed")]
    [TerraformProperty("core_instance_fleet")]
    public TerraformList<AwsEmrClusterCoreInstanceFleetBlock> CoreInstanceFleet { get; set; } = new();

    /// <summary>
    /// Block for core_instance_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CoreInstanceGroup block(s) allowed")]
    [TerraformProperty("core_instance_group")]
    public TerraformList<AwsEmrClusterCoreInstanceGroupBlock> CoreInstanceGroup { get; set; } = new();

    /// <summary>
    /// Block for ec2_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ec2Attributes block(s) allowed")]
    [TerraformProperty("ec2_attributes")]
    public TerraformList<AwsEmrClusterEc2AttributesBlock> Ec2Attributes { get; set; } = new();

    /// <summary>
    /// Block for kerberos_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KerberosAttributes block(s) allowed")]
    [TerraformProperty("kerberos_attributes")]
    public TerraformList<AwsEmrClusterKerberosAttributesBlock> KerberosAttributes { get; set; } = new();

    /// <summary>
    /// Block for master_instance_fleet.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MasterInstanceFleet block(s) allowed")]
    [TerraformProperty("master_instance_fleet")]
    public TerraformList<AwsEmrClusterMasterInstanceFleetBlock> MasterInstanceFleet { get; set; } = new();

    /// <summary>
    /// Block for master_instance_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MasterInstanceGroup block(s) allowed")]
    [TerraformProperty("master_instance_group")]
    public TerraformList<AwsEmrClusterMasterInstanceGroupBlock> MasterInstanceGroup { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The cluster_state attribute.
    /// </summary>
    [TerraformProperty("cluster_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ClusterState { get; }

    /// <summary>
    /// The master_public_dns attribute.
    /// </summary>
    [TerraformProperty("master_public_dns")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MasterPublicDns { get; }

}
