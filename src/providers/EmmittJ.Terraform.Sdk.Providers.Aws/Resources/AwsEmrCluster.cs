using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_termination_policy in .
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterAutoTerminationPolicyBlock
{
    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    [TerraformPropertyName("idle_timeout")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? IdleTimeout { get; set; }

}

/// <summary>
/// Block type for bootstrap_action in .
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterBootstrapActionBlock
{
    /// <summary>
    /// The args attribute.
    /// </summary>
    [TerraformPropertyName("args")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Args { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    [TerraformPropertyName("path")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Path { get; set; }

}

/// <summary>
/// Block type for core_instance_fleet in .
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterCoreInstanceFleetBlock
{

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }



    /// <summary>
    /// The target_on_demand_capacity attribute.
    /// </summary>
    [TerraformPropertyName("target_on_demand_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TargetOnDemandCapacity { get; set; }

    /// <summary>
    /// The target_spot_capacity attribute.
    /// </summary>
    [TerraformPropertyName("target_spot_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TargetSpotCapacity { get; set; }

}

/// <summary>
/// Block type for core_instance_group in .
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterCoreInstanceGroupBlock
{
    /// <summary>
    /// The autoscaling_policy attribute.
    /// </summary>
    [TerraformPropertyName("autoscaling_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AutoscalingPolicy { get; set; }

    /// <summary>
    /// The bid_price attribute.
    /// </summary>
    [TerraformPropertyName("bid_price")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BidPrice { get; set; }


    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [TerraformPropertyName("instance_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? InstanceCount { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformPropertyName("instance_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

}

/// <summary>
/// Block type for ec2_attributes in .
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterEc2AttributesBlock
{
    /// <summary>
    /// The additional_master_security_groups attribute.
    /// </summary>
    [TerraformPropertyName("additional_master_security_groups")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AdditionalMasterSecurityGroups { get; set; }

    /// <summary>
    /// The additional_slave_security_groups attribute.
    /// </summary>
    [TerraformPropertyName("additional_slave_security_groups")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AdditionalSlaveSecurityGroups { get; set; }

    /// <summary>
    /// The emr_managed_master_security_group attribute.
    /// </summary>
    [TerraformPropertyName("emr_managed_master_security_group")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EmrManagedMasterSecurityGroup { get; set; } = default!;

    /// <summary>
    /// The emr_managed_slave_security_group attribute.
    /// </summary>
    [TerraformPropertyName("emr_managed_slave_security_group")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EmrManagedSlaveSecurityGroup { get; set; } = default!;

    /// <summary>
    /// The instance_profile attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceProfile is required")]
    [TerraformPropertyName("instance_profile")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InstanceProfile { get; set; }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformPropertyName("key_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KeyName { get; set; }

    /// <summary>
    /// The service_access_security_group attribute.
    /// </summary>
    [TerraformPropertyName("service_access_security_group")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ServiceAccessSecurityGroup { get; set; } = default!;

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SubnetId { get; set; } = default!;

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> SubnetIds { get; set; } = default!;

}

/// <summary>
/// Block type for kerberos_attributes in .
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterKerberosAttributesBlock
{
    /// <summary>
    /// The ad_domain_join_password attribute.
    /// </summary>
    [TerraformPropertyName("ad_domain_join_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AdDomainJoinPassword { get; set; }

    /// <summary>
    /// The ad_domain_join_user attribute.
    /// </summary>
    [TerraformPropertyName("ad_domain_join_user")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AdDomainJoinUser { get; set; }

    /// <summary>
    /// The cross_realm_trust_principal_password attribute.
    /// </summary>
    [TerraformPropertyName("cross_realm_trust_principal_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CrossRealmTrustPrincipalPassword { get; set; }

    /// <summary>
    /// The kdc_admin_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KdcAdminPassword is required")]
    [TerraformPropertyName("kdc_admin_password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KdcAdminPassword { get; set; }

    /// <summary>
    /// The realm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Realm is required")]
    [TerraformPropertyName("realm")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Realm { get; set; }

}

/// <summary>
/// Block type for master_instance_fleet in .
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterMasterInstanceFleetBlock
{

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }



    /// <summary>
    /// The target_on_demand_capacity attribute.
    /// </summary>
    [TerraformPropertyName("target_on_demand_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TargetOnDemandCapacity { get; set; }

    /// <summary>
    /// The target_spot_capacity attribute.
    /// </summary>
    [TerraformPropertyName("target_spot_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TargetSpotCapacity { get; set; }

}

/// <summary>
/// Block type for master_instance_group in .
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterMasterInstanceGroupBlock
{
    /// <summary>
    /// The bid_price attribute.
    /// </summary>
    [TerraformPropertyName("bid_price")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BidPrice { get; set; }


    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [TerraformPropertyName("instance_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? InstanceCount { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformPropertyName("instance_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

}

/// <summary>
/// Manages a aws_emr_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEmrCluster : TerraformResource
{
    public AwsEmrCluster(string name) : base("aws_emr_cluster", name)
    {
    }

    /// <summary>
    /// The additional_info attribute.
    /// </summary>
    [TerraformPropertyName("additional_info")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AdditionalInfo { get; set; }

    /// <summary>
    /// The applications attribute.
    /// </summary>
    [TerraformPropertyName("applications")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Applications { get; set; }

    /// <summary>
    /// The autoscaling_role attribute.
    /// </summary>
    [TerraformPropertyName("autoscaling_role")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AutoscalingRole { get; set; }

    /// <summary>
    /// The configurations attribute.
    /// </summary>
    [TerraformPropertyName("configurations")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Configurations { get; set; }

    /// <summary>
    /// The configurations_json attribute.
    /// </summary>
    [TerraformPropertyName("configurations_json")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConfigurationsJson { get; set; }

    /// <summary>
    /// The custom_ami_id attribute.
    /// </summary>
    [TerraformPropertyName("custom_ami_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomAmiId { get; set; }

    /// <summary>
    /// The ebs_root_volume_size attribute.
    /// </summary>
    [TerraformPropertyName("ebs_root_volume_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? EbsRootVolumeSize { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The keep_job_flow_alive_when_no_steps attribute.
    /// </summary>
    [TerraformPropertyName("keep_job_flow_alive_when_no_steps")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> KeepJobFlowAliveWhenNoSteps { get; set; } = default!;

    /// <summary>
    /// The list_steps_states attribute.
    /// </summary>
    [TerraformPropertyName("list_steps_states")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ListStepsStates { get; set; }

    /// <summary>
    /// The log_encryption_kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("log_encryption_kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LogEncryptionKmsKeyId { get; set; }

    /// <summary>
    /// The log_uri attribute.
    /// </summary>
    [TerraformPropertyName("log_uri")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LogUri { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The os_release_label attribute.
    /// </summary>
    [TerraformPropertyName("os_release_label")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OsReleaseLabel { get; set; }

    /// <summary>
    /// The placement_group_config attribute.
    /// </summary>
    [TerraformPropertyName("placement_group_config")]
    // Optional argument - user may or may not set a value
    public TerraformList<object>? PlacementGroupConfig { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The release_label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReleaseLabel is required")]
    [TerraformPropertyName("release_label")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ReleaseLabel { get; set; }

    /// <summary>
    /// The scale_down_behavior attribute.
    /// </summary>
    [TerraformPropertyName("scale_down_behavior")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ScaleDownBehavior { get; set; } = default!;

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    [TerraformPropertyName("security_configuration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecurityConfiguration { get; set; }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRole is required")]
    [TerraformPropertyName("service_role")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServiceRole { get; set; }

    /// <summary>
    /// The step attribute.
    /// </summary>
    [TerraformPropertyName("step")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<object> Step { get; set; } = default!;

    /// <summary>
    /// The step_concurrency_level attribute.
    /// </summary>
    [TerraformPropertyName("step_concurrency_level")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? StepConcurrencyLevel { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The termination_protection attribute.
    /// </summary>
    [TerraformPropertyName("termination_protection")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> TerminationProtection { get; set; } = default!;

    /// <summary>
    /// The unhealthy_node_replacement attribute.
    /// </summary>
    [TerraformPropertyName("unhealthy_node_replacement")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UnhealthyNodeReplacement { get; set; }

    /// <summary>
    /// The visible_to_all_users attribute.
    /// </summary>
    [TerraformPropertyName("visible_to_all_users")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? VisibleToAllUsers { get; set; }

    /// <summary>
    /// Block for auto_termination_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoTerminationPolicy block(s) allowed")]
    [TerraformPropertyName("auto_termination_policy")]
    public TerraformList<TerraformBlock<AwsEmrClusterAutoTerminationPolicyBlock>>? AutoTerminationPolicy { get; set; }

    /// <summary>
    /// Block for bootstrap_action.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("bootstrap_action")]
    public TerraformList<TerraformBlock<AwsEmrClusterBootstrapActionBlock>>? BootstrapAction { get; set; }

    /// <summary>
    /// Block for core_instance_fleet.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CoreInstanceFleet block(s) allowed")]
    [TerraformPropertyName("core_instance_fleet")]
    public TerraformList<TerraformBlock<AwsEmrClusterCoreInstanceFleetBlock>>? CoreInstanceFleet { get; set; }

    /// <summary>
    /// Block for core_instance_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CoreInstanceGroup block(s) allowed")]
    [TerraformPropertyName("core_instance_group")]
    public TerraformList<TerraformBlock<AwsEmrClusterCoreInstanceGroupBlock>>? CoreInstanceGroup { get; set; }

    /// <summary>
    /// Block for ec2_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ec2Attributes block(s) allowed")]
    [TerraformPropertyName("ec2_attributes")]
    public TerraformList<TerraformBlock<AwsEmrClusterEc2AttributesBlock>>? Ec2Attributes { get; set; }

    /// <summary>
    /// Block for kerberos_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KerberosAttributes block(s) allowed")]
    [TerraformPropertyName("kerberos_attributes")]
    public TerraformList<TerraformBlock<AwsEmrClusterKerberosAttributesBlock>>? KerberosAttributes { get; set; }

    /// <summary>
    /// Block for master_instance_fleet.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MasterInstanceFleet block(s) allowed")]
    [TerraformPropertyName("master_instance_fleet")]
    public TerraformList<TerraformBlock<AwsEmrClusterMasterInstanceFleetBlock>>? MasterInstanceFleet { get; set; }

    /// <summary>
    /// Block for master_instance_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MasterInstanceGroup block(s) allowed")]
    [TerraformPropertyName("master_instance_group")]
    public TerraformList<TerraformBlock<AwsEmrClusterMasterInstanceGroupBlock>>? MasterInstanceGroup { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The cluster_state attribute.
    /// </summary>
    [TerraformPropertyName("cluster_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClusterState => new TerraformReference(this, "cluster_state");

    /// <summary>
    /// The master_public_dns attribute.
    /// </summary>
    [TerraformPropertyName("master_public_dns")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MasterPublicDns => new TerraformReference(this, "master_public_dns");

}
