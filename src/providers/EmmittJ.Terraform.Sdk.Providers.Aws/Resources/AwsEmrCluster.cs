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
        set => SetProperty("idle_timeout", value);
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
        set => SetProperty("args", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Path is required")]
    public required TerraformProperty<string> Path
    {
        set => SetProperty("path", value);
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
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The provisioned_on_demand_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? ProvisionedOnDemandCapacity
    {
        set => SetProperty("provisioned_on_demand_capacity", value);
    }

    /// <summary>
    /// The provisioned_spot_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? ProvisionedSpotCapacity
    {
        set => SetProperty("provisioned_spot_capacity", value);
    }

    /// <summary>
    /// The target_on_demand_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? TargetOnDemandCapacity
    {
        set => SetProperty("target_on_demand_capacity", value);
    }

    /// <summary>
    /// The target_spot_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? TargetSpotCapacity
    {
        set => SetProperty("target_spot_capacity", value);
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
        set => SetProperty("autoscaling_policy", value);
    }

    /// <summary>
    /// The bid_price attribute.
    /// </summary>
    public TerraformProperty<string>? BidPrice
    {
        set => SetProperty("bid_price", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    public TerraformProperty<double>? InstanceCount
    {
        set => SetProperty("instance_count", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformProperty<string> InstanceType
    {
        set => SetProperty("instance_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
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
        set => SetProperty("additional_master_security_groups", value);
    }

    /// <summary>
    /// The additional_slave_security_groups attribute.
    /// </summary>
    public TerraformProperty<string>? AdditionalSlaveSecurityGroups
    {
        set => SetProperty("additional_slave_security_groups", value);
    }

    /// <summary>
    /// The emr_managed_master_security_group attribute.
    /// </summary>
    public TerraformProperty<string>? EmrManagedMasterSecurityGroup
    {
        set => SetProperty("emr_managed_master_security_group", value);
    }

    /// <summary>
    /// The emr_managed_slave_security_group attribute.
    /// </summary>
    public TerraformProperty<string>? EmrManagedSlaveSecurityGroup
    {
        set => SetProperty("emr_managed_slave_security_group", value);
    }

    /// <summary>
    /// The instance_profile attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceProfile is required")]
    public required TerraformProperty<string> InstanceProfile
    {
        set => SetProperty("instance_profile", value);
    }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformProperty<string>? KeyName
    {
        set => SetProperty("key_name", value);
    }

    /// <summary>
    /// The service_access_security_group attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceAccessSecurityGroup
    {
        set => SetProperty("service_access_security_group", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        set => SetProperty("subnet_id", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        set => SetProperty("subnet_ids", value);
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
        set => SetProperty("ad_domain_join_password", value);
    }

    /// <summary>
    /// The ad_domain_join_user attribute.
    /// </summary>
    public TerraformProperty<string>? AdDomainJoinUser
    {
        set => SetProperty("ad_domain_join_user", value);
    }

    /// <summary>
    /// The cross_realm_trust_principal_password attribute.
    /// </summary>
    public TerraformProperty<string>? CrossRealmTrustPrincipalPassword
    {
        set => SetProperty("cross_realm_trust_principal_password", value);
    }

    /// <summary>
    /// The kdc_admin_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KdcAdminPassword is required")]
    public required TerraformProperty<string> KdcAdminPassword
    {
        set => SetProperty("kdc_admin_password", value);
    }

    /// <summary>
    /// The realm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Realm is required")]
    public required TerraformProperty<string> Realm
    {
        set => SetProperty("realm", value);
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
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The provisioned_on_demand_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? ProvisionedOnDemandCapacity
    {
        set => SetProperty("provisioned_on_demand_capacity", value);
    }

    /// <summary>
    /// The provisioned_spot_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? ProvisionedSpotCapacity
    {
        set => SetProperty("provisioned_spot_capacity", value);
    }

    /// <summary>
    /// The target_on_demand_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? TargetOnDemandCapacity
    {
        set => SetProperty("target_on_demand_capacity", value);
    }

    /// <summary>
    /// The target_spot_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? TargetSpotCapacity
    {
        set => SetProperty("target_spot_capacity", value);
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
        set => SetProperty("bid_price", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    public TerraformProperty<double>? InstanceCount
    {
        set => SetProperty("instance_count", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformProperty<string> InstanceType
    {
        set => SetProperty("instance_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
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
        SetOutput("arn");
        SetOutput("cluster_state");
        SetOutput("master_public_dns");
        SetOutput("additional_info");
        SetOutput("applications");
        SetOutput("autoscaling_role");
        SetOutput("configurations");
        SetOutput("configurations_json");
        SetOutput("custom_ami_id");
        SetOutput("ebs_root_volume_size");
        SetOutput("id");
        SetOutput("keep_job_flow_alive_when_no_steps");
        SetOutput("list_steps_states");
        SetOutput("log_encryption_kms_key_id");
        SetOutput("log_uri");
        SetOutput("name");
        SetOutput("os_release_label");
        SetOutput("placement_group_config");
        SetOutput("region");
        SetOutput("release_label");
        SetOutput("scale_down_behavior");
        SetOutput("security_configuration");
        SetOutput("service_role");
        SetOutput("step");
        SetOutput("step_concurrency_level");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("termination_protection");
        SetOutput("unhealthy_node_replacement");
        SetOutput("visible_to_all_users");
    }

    /// <summary>
    /// The additional_info attribute.
    /// </summary>
    public TerraformProperty<string> AdditionalInfo
    {
        get => GetRequiredOutput<TerraformProperty<string>>("additional_info");
        set => SetProperty("additional_info", value);
    }

    /// <summary>
    /// The applications attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Applications
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("applications");
        set => SetProperty("applications", value);
    }

    /// <summary>
    /// The autoscaling_role attribute.
    /// </summary>
    public TerraformProperty<string> AutoscalingRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("autoscaling_role");
        set => SetProperty("autoscaling_role", value);
    }

    /// <summary>
    /// The configurations attribute.
    /// </summary>
    public TerraformProperty<string> Configurations
    {
        get => GetRequiredOutput<TerraformProperty<string>>("configurations");
        set => SetProperty("configurations", value);
    }

    /// <summary>
    /// The configurations_json attribute.
    /// </summary>
    public TerraformProperty<string> ConfigurationsJson
    {
        get => GetRequiredOutput<TerraformProperty<string>>("configurations_json");
        set => SetProperty("configurations_json", value);
    }

    /// <summary>
    /// The custom_ami_id attribute.
    /// </summary>
    public TerraformProperty<string> CustomAmiId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_ami_id");
        set => SetProperty("custom_ami_id", value);
    }

    /// <summary>
    /// The ebs_root_volume_size attribute.
    /// </summary>
    public TerraformProperty<double> EbsRootVolumeSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("ebs_root_volume_size");
        set => SetProperty("ebs_root_volume_size", value);
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
    /// The keep_job_flow_alive_when_no_steps attribute.
    /// </summary>
    public TerraformProperty<bool> KeepJobFlowAliveWhenNoSteps
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("keep_job_flow_alive_when_no_steps");
        set => SetProperty("keep_job_flow_alive_when_no_steps", value);
    }

    /// <summary>
    /// The list_steps_states attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ListStepsStates
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("list_steps_states");
        set => SetProperty("list_steps_states", value);
    }

    /// <summary>
    /// The log_encryption_kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> LogEncryptionKmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("log_encryption_kms_key_id");
        set => SetProperty("log_encryption_kms_key_id", value);
    }

    /// <summary>
    /// The log_uri attribute.
    /// </summary>
    public TerraformProperty<string> LogUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("log_uri");
        set => SetProperty("log_uri", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The os_release_label attribute.
    /// </summary>
    public TerraformProperty<string> OsReleaseLabel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("os_release_label");
        set => SetProperty("os_release_label", value);
    }

    /// <summary>
    /// The placement_group_config attribute.
    /// </summary>
    public List<TerraformProperty<object>> PlacementGroupConfig
    {
        get => GetRequiredOutput<List<TerraformProperty<object>>>("placement_group_config");
        set => SetProperty("placement_group_config", value);
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
    /// The release_label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReleaseLabel is required")]
    public required TerraformProperty<string> ReleaseLabel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("release_label");
        set => SetProperty("release_label", value);
    }

    /// <summary>
    /// The scale_down_behavior attribute.
    /// </summary>
    public TerraformProperty<string> ScaleDownBehavior
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scale_down_behavior");
        set => SetProperty("scale_down_behavior", value);
    }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    public TerraformProperty<string> SecurityConfiguration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("security_configuration");
        set => SetProperty("security_configuration", value);
    }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRole is required")]
    public required TerraformProperty<string> ServiceRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_role");
        set => SetProperty("service_role", value);
    }

    /// <summary>
    /// The step attribute.
    /// </summary>
    public List<TerraformProperty<object>> Step
    {
        get => GetRequiredOutput<List<TerraformProperty<object>>>("step");
        set => SetProperty("step", value);
    }

    /// <summary>
    /// The step_concurrency_level attribute.
    /// </summary>
    public TerraformProperty<double> StepConcurrencyLevel
    {
        get => GetRequiredOutput<TerraformProperty<double>>("step_concurrency_level");
        set => SetProperty("step_concurrency_level", value);
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
    /// The termination_protection attribute.
    /// </summary>
    public TerraformProperty<bool> TerminationProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("termination_protection");
        set => SetProperty("termination_protection", value);
    }

    /// <summary>
    /// The unhealthy_node_replacement attribute.
    /// </summary>
    public TerraformProperty<bool> UnhealthyNodeReplacement
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("unhealthy_node_replacement");
        set => SetProperty("unhealthy_node_replacement", value);
    }

    /// <summary>
    /// The visible_to_all_users attribute.
    /// </summary>
    public TerraformProperty<bool> VisibleToAllUsers
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("visible_to_all_users");
        set => SetProperty("visible_to_all_users", value);
    }

    /// <summary>
    /// Block for auto_termination_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoTerminationPolicy block(s) allowed")]
    public List<AwsEmrClusterAutoTerminationPolicyBlock>? AutoTerminationPolicy
    {
        set => SetProperty("auto_termination_policy", value);
    }

    /// <summary>
    /// Block for bootstrap_action.
    /// Nesting mode: list
    /// </summary>
    public List<AwsEmrClusterBootstrapActionBlock>? BootstrapAction
    {
        set => SetProperty("bootstrap_action", value);
    }

    /// <summary>
    /// Block for core_instance_fleet.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CoreInstanceFleet block(s) allowed")]
    public List<AwsEmrClusterCoreInstanceFleetBlock>? CoreInstanceFleet
    {
        set => SetProperty("core_instance_fleet", value);
    }

    /// <summary>
    /// Block for core_instance_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CoreInstanceGroup block(s) allowed")]
    public List<AwsEmrClusterCoreInstanceGroupBlock>? CoreInstanceGroup
    {
        set => SetProperty("core_instance_group", value);
    }

    /// <summary>
    /// Block for ec2_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ec2Attributes block(s) allowed")]
    public List<AwsEmrClusterEc2AttributesBlock>? Ec2Attributes
    {
        set => SetProperty("ec2_attributes", value);
    }

    /// <summary>
    /// Block for kerberos_attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KerberosAttributes block(s) allowed")]
    public List<AwsEmrClusterKerberosAttributesBlock>? KerberosAttributes
    {
        set => SetProperty("kerberos_attributes", value);
    }

    /// <summary>
    /// Block for master_instance_fleet.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MasterInstanceFleet block(s) allowed")]
    public List<AwsEmrClusterMasterInstanceFleetBlock>? MasterInstanceFleet
    {
        set => SetProperty("master_instance_fleet", value);
    }

    /// <summary>
    /// Block for master_instance_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MasterInstanceGroup block(s) allowed")]
    public List<AwsEmrClusterMasterInstanceGroupBlock>? MasterInstanceGroup
    {
        set => SetProperty("master_instance_group", value);
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
