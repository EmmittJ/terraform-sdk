using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_termination_policy in .
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterAutoTerminationPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The idle_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? IdleTimeout
    {
        get => GetProperty<TerraformProperty<double>>("idle_timeout");
        set => WithProperty("idle_timeout", value);
    }

}

/// <summary>
/// Block type for bootstrap_action in .
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterBootstrapActionBlock : TerraformBlock
{
    /// <summary>
    /// The args attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Args
    {
        get => GetProperty<List<TerraformProperty<string>>>("args");
        set => WithProperty("args", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        get => GetRequiredProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
    }

}

/// <summary>
/// Block type for core_instance_fleet in .
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterCoreInstanceFleetBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The provisioned_on_demand_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? ProvisionedOnDemandCapacity
    {
        get => GetProperty<TerraformProperty<double>>("provisioned_on_demand_capacity");
        set => WithProperty("provisioned_on_demand_capacity", value);
    }

    /// <summary>
    /// The provisioned_spot_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? ProvisionedSpotCapacity
    {
        get => GetProperty<TerraformProperty<double>>("provisioned_spot_capacity");
        set => WithProperty("provisioned_spot_capacity", value);
    }

    /// <summary>
    /// The target_on_demand_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? TargetOnDemandCapacity
    {
        get => GetProperty<TerraformProperty<double>>("target_on_demand_capacity");
        set => WithProperty("target_on_demand_capacity", value);
    }

    /// <summary>
    /// The target_spot_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? TargetSpotCapacity
    {
        get => GetProperty<TerraformProperty<double>>("target_spot_capacity");
        set => WithProperty("target_spot_capacity", value);
    }

}

/// <summary>
/// Block type for core_instance_group in .
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterCoreInstanceGroupBlock : TerraformBlock
{
    /// <summary>
    /// The autoscaling_policy attribute.
    /// </summary>
    public TerraformProperty<string>? AutoscalingPolicy
    {
        get => GetProperty<TerraformProperty<string>>("autoscaling_policy");
        set => WithProperty("autoscaling_policy", value);
    }

    /// <summary>
    /// The bid_price attribute.
    /// </summary>
    public TerraformProperty<string>? BidPrice
    {
        get => GetProperty<TerraformProperty<string>>("bid_price");
        set => WithProperty("bid_price", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    public TerraformProperty<double>? InstanceCount
    {
        get => GetProperty<TerraformProperty<double>>("instance_count");
        set => WithProperty("instance_count", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformProperty<string> InstanceType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("instance_type");
        set => WithProperty("instance_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for ec2_attributes in .
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterEc2AttributesBlock : TerraformBlock
{
    /// <summary>
    /// The additional_master_security_groups attribute.
    /// </summary>
    public TerraformProperty<string>? AdditionalMasterSecurityGroups
    {
        get => GetProperty<TerraformProperty<string>>("additional_master_security_groups");
        set => WithProperty("additional_master_security_groups", value);
    }

    /// <summary>
    /// The additional_slave_security_groups attribute.
    /// </summary>
    public TerraformProperty<string>? AdditionalSlaveSecurityGroups
    {
        get => GetProperty<TerraformProperty<string>>("additional_slave_security_groups");
        set => WithProperty("additional_slave_security_groups", value);
    }

    /// <summary>
    /// The emr_managed_master_security_group attribute.
    /// </summary>
    public TerraformProperty<string>? EmrManagedMasterSecurityGroup
    {
        get => GetProperty<TerraformProperty<string>>("emr_managed_master_security_group");
        set => WithProperty("emr_managed_master_security_group", value);
    }

    /// <summary>
    /// The emr_managed_slave_security_group attribute.
    /// </summary>
    public TerraformProperty<string>? EmrManagedSlaveSecurityGroup
    {
        get => GetProperty<TerraformProperty<string>>("emr_managed_slave_security_group");
        set => WithProperty("emr_managed_slave_security_group", value);
    }

    /// <summary>
    /// The instance_profile attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceProfile is required")]
    public required TerraformProperty<string> InstanceProfile
    {
        get => GetRequiredProperty<TerraformProperty<string>>("instance_profile");
        set => WithProperty("instance_profile", value);
    }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformProperty<string>? KeyName
    {
        get => GetProperty<TerraformProperty<string>>("key_name");
        set => WithProperty("key_name", value);
    }

    /// <summary>
    /// The service_access_security_group attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceAccessSecurityGroup
    {
        get => GetProperty<TerraformProperty<string>>("service_access_security_group");
        set => WithProperty("service_access_security_group", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => WithProperty("subnet_ids", value);
    }

}

/// <summary>
/// Block type for kerberos_attributes in .
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterKerberosAttributesBlock : TerraformBlock
{
    /// <summary>
    /// The ad_domain_join_password attribute.
    /// </summary>
    public TerraformProperty<string>? AdDomainJoinPassword
    {
        get => GetProperty<TerraformProperty<string>>("ad_domain_join_password");
        set => WithProperty("ad_domain_join_password", value);
    }

    /// <summary>
    /// The ad_domain_join_user attribute.
    /// </summary>
    public TerraformProperty<string>? AdDomainJoinUser
    {
        get => GetProperty<TerraformProperty<string>>("ad_domain_join_user");
        set => WithProperty("ad_domain_join_user", value);
    }

    /// <summary>
    /// The cross_realm_trust_principal_password attribute.
    /// </summary>
    public TerraformProperty<string>? CrossRealmTrustPrincipalPassword
    {
        get => GetProperty<TerraformProperty<string>>("cross_realm_trust_principal_password");
        set => WithProperty("cross_realm_trust_principal_password", value);
    }

    /// <summary>
    /// The kdc_admin_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KdcAdminPassword is required")]
    public required TerraformProperty<string> KdcAdminPassword
    {
        get => GetRequiredProperty<TerraformProperty<string>>("kdc_admin_password");
        set => WithProperty("kdc_admin_password", value);
    }

    /// <summary>
    /// The realm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Realm is required")]
    public required TerraformProperty<string> Realm
    {
        get => GetRequiredProperty<TerraformProperty<string>>("realm");
        set => WithProperty("realm", value);
    }

}

/// <summary>
/// Block type for master_instance_fleet in .
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterMasterInstanceFleetBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The provisioned_on_demand_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? ProvisionedOnDemandCapacity
    {
        get => GetProperty<TerraformProperty<double>>("provisioned_on_demand_capacity");
        set => WithProperty("provisioned_on_demand_capacity", value);
    }

    /// <summary>
    /// The provisioned_spot_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? ProvisionedSpotCapacity
    {
        get => GetProperty<TerraformProperty<double>>("provisioned_spot_capacity");
        set => WithProperty("provisioned_spot_capacity", value);
    }

    /// <summary>
    /// The target_on_demand_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? TargetOnDemandCapacity
    {
        get => GetProperty<TerraformProperty<double>>("target_on_demand_capacity");
        set => WithProperty("target_on_demand_capacity", value);
    }

    /// <summary>
    /// The target_spot_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? TargetSpotCapacity
    {
        get => GetProperty<TerraformProperty<double>>("target_spot_capacity");
        set => WithProperty("target_spot_capacity", value);
    }

}

/// <summary>
/// Block type for master_instance_group in .
/// Nesting mode: list
/// </summary>
public class AwsEmrClusterMasterInstanceGroupBlock : TerraformBlock
{
    /// <summary>
    /// The bid_price attribute.
    /// </summary>
    public TerraformProperty<string>? BidPrice
    {
        get => GetProperty<TerraformProperty<string>>("bid_price");
        set => WithProperty("bid_price", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    public TerraformProperty<double>? InstanceCount
    {
        get => GetProperty<TerraformProperty<double>>("instance_count");
        set => WithProperty("instance_count", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformProperty<string> InstanceType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("instance_type");
        set => WithProperty("instance_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Manages a aws_emr_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEmrCluster : TerraformResource
{
    public AwsEmrCluster(string name) : base("aws_emr_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("cluster_state");
        this.DeclareOutput("master_public_dns");
    }

    /// <summary>
    /// The additional_info attribute.
    /// </summary>
    public TerraformProperty<string>? AdditionalInfo
    {
        get => GetProperty<TerraformProperty<string>>("additional_info");
        set => this.WithProperty("additional_info", value);
    }

    /// <summary>
    /// The applications attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Applications
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("applications");
        set => this.WithProperty("applications", value);
    }

    /// <summary>
    /// The autoscaling_role attribute.
    /// </summary>
    public TerraformProperty<string>? AutoscalingRole
    {
        get => GetProperty<TerraformProperty<string>>("autoscaling_role");
        set => this.WithProperty("autoscaling_role", value);
    }

    /// <summary>
    /// The configurations attribute.
    /// </summary>
    public TerraformProperty<string>? Configurations
    {
        get => GetProperty<TerraformProperty<string>>("configurations");
        set => this.WithProperty("configurations", value);
    }

    /// <summary>
    /// The configurations_json attribute.
    /// </summary>
    public TerraformProperty<string>? ConfigurationsJson
    {
        get => GetProperty<TerraformProperty<string>>("configurations_json");
        set => this.WithProperty("configurations_json", value);
    }

    /// <summary>
    /// The custom_ami_id attribute.
    /// </summary>
    public TerraformProperty<string>? CustomAmiId
    {
        get => GetProperty<TerraformProperty<string>>("custom_ami_id");
        set => this.WithProperty("custom_ami_id", value);
    }

    /// <summary>
    /// The ebs_root_volume_size attribute.
    /// </summary>
    public TerraformProperty<double>? EbsRootVolumeSize
    {
        get => GetProperty<TerraformProperty<double>>("ebs_root_volume_size");
        set => this.WithProperty("ebs_root_volume_size", value);
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
    /// The keep_job_flow_alive_when_no_steps attribute.
    /// </summary>
    public TerraformProperty<bool>? KeepJobFlowAliveWhenNoSteps
    {
        get => GetProperty<TerraformProperty<bool>>("keep_job_flow_alive_when_no_steps");
        set => this.WithProperty("keep_job_flow_alive_when_no_steps", value);
    }

    /// <summary>
    /// The list_steps_states attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ListStepsStates
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("list_steps_states");
        set => this.WithProperty("list_steps_states", value);
    }

    /// <summary>
    /// The log_encryption_kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? LogEncryptionKmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("log_encryption_kms_key_id");
        set => this.WithProperty("log_encryption_kms_key_id", value);
    }

    /// <summary>
    /// The log_uri attribute.
    /// </summary>
    public TerraformProperty<string>? LogUri
    {
        get => GetProperty<TerraformProperty<string>>("log_uri");
        set => this.WithProperty("log_uri", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The os_release_label attribute.
    /// </summary>
    public TerraformProperty<string>? OsReleaseLabel
    {
        get => GetProperty<TerraformProperty<string>>("os_release_label");
        set => this.WithProperty("os_release_label", value);
    }

    /// <summary>
    /// The placement_group_config attribute.
    /// </summary>
    public List<TerraformProperty<object>>? PlacementGroupConfig
    {
        get => GetProperty<List<TerraformProperty<object>>>("placement_group_config");
        set => this.WithProperty("placement_group_config", value);
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
    /// The release_label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReleaseLabel is required")]
    public required TerraformProperty<string> ReleaseLabel
    {
        get => GetRequiredProperty<TerraformProperty<string>>("release_label");
        set => this.WithProperty("release_label", value);
    }

    /// <summary>
    /// The scale_down_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? ScaleDownBehavior
    {
        get => GetProperty<TerraformProperty<string>>("scale_down_behavior");
        set => this.WithProperty("scale_down_behavior", value);
    }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    public TerraformProperty<string>? SecurityConfiguration
    {
        get => GetProperty<TerraformProperty<string>>("security_configuration");
        set => this.WithProperty("security_configuration", value);
    }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRole is required")]
    public required TerraformProperty<string> ServiceRole
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service_role");
        set => this.WithProperty("service_role", value);
    }

    /// <summary>
    /// The step attribute.
    /// </summary>
    public List<TerraformProperty<object>>? Step
    {
        get => GetProperty<List<TerraformProperty<object>>>("step");
        set => this.WithProperty("step", value);
    }

    /// <summary>
    /// The step_concurrency_level attribute.
    /// </summary>
    public TerraformProperty<double>? StepConcurrencyLevel
    {
        get => GetProperty<TerraformProperty<double>>("step_concurrency_level");
        set => this.WithProperty("step_concurrency_level", value);
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
    /// The termination_protection attribute.
    /// </summary>
    public TerraformProperty<bool>? TerminationProtection
    {
        get => GetProperty<TerraformProperty<bool>>("termination_protection");
        set => this.WithProperty("termination_protection", value);
    }

    /// <summary>
    /// The unhealthy_node_replacement attribute.
    /// </summary>
    public TerraformProperty<bool>? UnhealthyNodeReplacement
    {
        get => GetProperty<TerraformProperty<bool>>("unhealthy_node_replacement");
        set => this.WithProperty("unhealthy_node_replacement", value);
    }

    /// <summary>
    /// The visible_to_all_users attribute.
    /// </summary>
    public TerraformProperty<bool>? VisibleToAllUsers
    {
        get => GetProperty<TerraformProperty<bool>>("visible_to_all_users");
        set => this.WithProperty("visible_to_all_users", value);
    }

    /// <summary>
    /// Block for auto_termination_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoTerminationPolicy block(s) allowed")]
    public List<AwsEmrClusterAutoTerminationPolicyBlock>? AutoTerminationPolicy
    {
        get => GetProperty<List<AwsEmrClusterAutoTerminationPolicyBlock>>("auto_termination_policy");
        set => this.WithProperty("auto_termination_policy", value);
    }

    /// <summary>
    /// Block for bootstrap_action.
    /// Nesting mode: list
    /// </summary>
    public List<AwsEmrClusterBootstrapActionBlock>? BootstrapAction
    {
        get => GetProperty<List<AwsEmrClusterBootstrapActionBlock>>("bootstrap_action");
        set => this.WithProperty("bootstrap_action", value);
    }

    /// <summary>
    /// Block for core_instance_fleet.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CoreInstanceFleet block(s) allowed")]
    public List<AwsEmrClusterCoreInstanceFleetBlock>? CoreInstanceFleet
    {
        get => GetProperty<List<AwsEmrClusterCoreInstanceFleetBlock>>("core_instance_fleet");
        set => this.WithProperty("core_instance_fleet", value);
    }

    /// <summary>
    /// Block for core_instance_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CoreInstanceGroup block(s) allowed")]
    public List<AwsEmrClusterCoreInstanceGroupBlock>? CoreInstanceGroup
    {
        get => GetProperty<List<AwsEmrClusterCoreInstanceGroupBlock>>("core_instance_group");
        set => this.WithProperty("core_instance_group", value);
    }

    /// <summary>
    /// Block for ec2_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ec2Attributes block(s) allowed")]
    public List<AwsEmrClusterEc2AttributesBlock>? Ec2Attributes
    {
        get => GetProperty<List<AwsEmrClusterEc2AttributesBlock>>("ec2_attributes");
        set => this.WithProperty("ec2_attributes", value);
    }

    /// <summary>
    /// Block for kerberos_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KerberosAttributes block(s) allowed")]
    public List<AwsEmrClusterKerberosAttributesBlock>? KerberosAttributes
    {
        get => GetProperty<List<AwsEmrClusterKerberosAttributesBlock>>("kerberos_attributes");
        set => this.WithProperty("kerberos_attributes", value);
    }

    /// <summary>
    /// Block for master_instance_fleet.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MasterInstanceFleet block(s) allowed")]
    public List<AwsEmrClusterMasterInstanceFleetBlock>? MasterInstanceFleet
    {
        get => GetProperty<List<AwsEmrClusterMasterInstanceFleetBlock>>("master_instance_fleet");
        set => this.WithProperty("master_instance_fleet", value);
    }

    /// <summary>
    /// Block for master_instance_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MasterInstanceGroup block(s) allowed")]
    public List<AwsEmrClusterMasterInstanceGroupBlock>? MasterInstanceGroup
    {
        get => GetProperty<List<AwsEmrClusterMasterInstanceGroupBlock>>("master_instance_group");
        set => this.WithProperty("master_instance_group", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The cluster_state attribute.
    /// </summary>
    public TerraformExpression ClusterState => this["cluster_state"];

    /// <summary>
    /// The master_public_dns attribute.
    /// </summary>
    public TerraformExpression MasterPublicDns => this["master_public_dns"];

}
