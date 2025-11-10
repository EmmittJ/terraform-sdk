using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for advanced_security_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainAdvancedSecurityOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The anonymous_auth_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AnonymousAuthEnabled
    {
        set => SetProperty("anonymous_auth_enabled", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The internal_user_database_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? InternalUserDatabaseEnabled
    {
        set => SetProperty("internal_user_database_enabled", value);
    }

}

/// <summary>
/// Block type for aiml_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainAimlOptionsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for auto_tune_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainAutoTuneOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The desired_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DesiredState is required")]
    public required TerraformProperty<string> DesiredState
    {
        set => SetProperty("desired_state", value);
    }

    /// <summary>
    /// The rollback_on_disable attribute.
    /// </summary>
    public TerraformProperty<string>? RollbackOnDisable
    {
        set => SetProperty("rollback_on_disable", value);
    }

    /// <summary>
    /// The use_off_peak_window attribute.
    /// </summary>
    public TerraformProperty<bool>? UseOffPeakWindow
    {
        set => SetProperty("use_off_peak_window", value);
    }

}

/// <summary>
/// Block type for cluster_config in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainClusterConfigBlock : TerraformBlock
{
    /// <summary>
    /// The dedicated_master_count attribute.
    /// </summary>
    public TerraformProperty<double>? DedicatedMasterCount
    {
        set => SetProperty("dedicated_master_count", value);
    }

    /// <summary>
    /// The dedicated_master_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DedicatedMasterEnabled
    {
        set => SetProperty("dedicated_master_enabled", value);
    }

    /// <summary>
    /// The dedicated_master_type attribute.
    /// </summary>
    public TerraformProperty<string>? DedicatedMasterType
    {
        set => SetProperty("dedicated_master_type", value);
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
    public TerraformProperty<string>? InstanceType
    {
        set => SetProperty("instance_type", value);
    }

    /// <summary>
    /// The multi_az_with_standby_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MultiAzWithStandbyEnabled
    {
        set => SetProperty("multi_az_with_standby_enabled", value);
    }

    /// <summary>
    /// The warm_count attribute.
    /// </summary>
    public TerraformProperty<double>? WarmCount
    {
        set => SetProperty("warm_count", value);
    }

    /// <summary>
    /// The warm_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? WarmEnabled
    {
        set => SetProperty("warm_enabled", value);
    }

    /// <summary>
    /// The warm_type attribute.
    /// </summary>
    public TerraformProperty<string>? WarmType
    {
        set => SetProperty("warm_type", value);
    }

    /// <summary>
    /// The zone_awareness_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ZoneAwarenessEnabled
    {
        set => SetProperty("zone_awareness_enabled", value);
    }

}

/// <summary>
/// Block type for cognito_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainCognitoOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The identity_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityPoolId is required")]
    public required TerraformProperty<string> IdentityPoolId
    {
        set => SetProperty("identity_pool_id", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformProperty<string> UserPoolId
    {
        set => SetProperty("user_pool_id", value);
    }

}

/// <summary>
/// Block type for domain_endpoint_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainDomainEndpointOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The custom_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? CustomEndpoint
    {
        set => SetProperty("custom_endpoint", value);
    }

    /// <summary>
    /// The custom_endpoint_certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string>? CustomEndpointCertificateArn
    {
        set => SetProperty("custom_endpoint_certificate_arn", value);
    }

    /// <summary>
    /// The custom_endpoint_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CustomEndpointEnabled
    {
        set => SetProperty("custom_endpoint_enabled", value);
    }

    /// <summary>
    /// The enforce_https attribute.
    /// </summary>
    public TerraformProperty<bool>? EnforceHttps
    {
        set => SetProperty("enforce_https", value);
    }

    /// <summary>
    /// The tls_security_policy attribute.
    /// </summary>
    public TerraformProperty<string>? TlsSecurityPolicy
    {
        set => SetProperty("tls_security_policy", value);
    }

}

/// <summary>
/// Block type for ebs_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainEbsOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The ebs_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EbsEnabled is required")]
    public required TerraformProperty<bool> EbsEnabled
    {
        set => SetProperty("ebs_enabled", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformProperty<double>? Iops
    {
        set => SetProperty("iops", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformProperty<double>? Throughput
    {
        set => SetProperty("throughput", value);
    }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformProperty<double>? VolumeSize
    {
        set => SetProperty("volume_size", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformProperty<string>? VolumeType
    {
        set => SetProperty("volume_type", value);
    }

}

/// <summary>
/// Block type for encrypt_at_rest in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainEncryptAtRestBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        set => SetProperty("kms_key_id", value);
    }

}

/// <summary>
/// Block type for log_publishing_options in .
/// Nesting mode: set
/// </summary>
public class AwsOpensearchDomainLogPublishingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The cloudwatch_log_group_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudwatchLogGroupArn is required")]
    public required TerraformProperty<string> CloudwatchLogGroupArn
    {
        set => SetProperty("cloudwatch_log_group_arn", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The log_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogType is required")]
    public required TerraformProperty<string> LogType
    {
        set => SetProperty("log_type", value);
    }

}

/// <summary>
/// Block type for node_to_node_encryption in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainNodeToNodeEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

}

/// <summary>
/// Block type for off_peak_window_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainOffPeakWindowOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

}

/// <summary>
/// Block type for snapshot_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainSnapshotOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The automated_snapshot_start_hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomatedSnapshotStartHour is required")]
    public required TerraformProperty<double> AutomatedSnapshotStartHour
    {
        set => SetProperty("automated_snapshot_start_hour", value);
    }

}

/// <summary>
/// Block type for software_update_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainSoftwareUpdateOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The auto_software_update_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoSoftwareUpdateEnabled
    {
        set => SetProperty("auto_software_update_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsOpensearchDomainTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for vpc_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainVpcOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AvailabilityZones
    {
        set => SetProperty("availability_zones", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        set => SetProperty("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcId
    {
        set => SetProperty("vpc_id", value);
    }

}

/// <summary>
/// Manages a aws_opensearch_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsOpensearchDomain : TerraformResource
{
    public AwsOpensearchDomain(string name) : base("aws_opensearch_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("dashboard_endpoint");
        SetOutput("dashboard_endpoint_v2");
        SetOutput("domain_endpoint_v2_hosted_zone_id");
        SetOutput("domain_id");
        SetOutput("endpoint");
        SetOutput("endpoint_v2");
        SetOutput("access_policies");
        SetOutput("advanced_options");
        SetOutput("domain_name");
        SetOutput("engine_version");
        SetOutput("id");
        SetOutput("ip_address_type");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The access_policies attribute.
    /// </summary>
    public TerraformProperty<string> AccessPolicies
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_policies");
        set => SetProperty("access_policies", value);
    }

    /// <summary>
    /// The advanced_options attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> AdvancedOptions
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("advanced_options");
        set => SetProperty("advanced_options", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_name");
        set => SetProperty("domain_name", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformProperty<string> EngineVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine_version");
        set => SetProperty("engine_version", value);
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
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string> IpAddressType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_address_type");
        set => SetProperty("ip_address_type", value);
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
    /// Block for advanced_security_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedSecurityOptions block(s) allowed")]
    public List<AwsOpensearchDomainAdvancedSecurityOptionsBlock>? AdvancedSecurityOptions
    {
        set => SetProperty("advanced_security_options", value);
    }

    /// <summary>
    /// Block for aiml_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AimlOptions block(s) allowed")]
    public List<AwsOpensearchDomainAimlOptionsBlock>? AimlOptions
    {
        set => SetProperty("aiml_options", value);
    }

    /// <summary>
    /// Block for auto_tune_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoTuneOptions block(s) allowed")]
    public List<AwsOpensearchDomainAutoTuneOptionsBlock>? AutoTuneOptions
    {
        set => SetProperty("auto_tune_options", value);
    }

    /// <summary>
    /// Block for cluster_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterConfig block(s) allowed")]
    public List<AwsOpensearchDomainClusterConfigBlock>? ClusterConfig
    {
        set => SetProperty("cluster_config", value);
    }

    /// <summary>
    /// Block for cognito_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CognitoOptions block(s) allowed")]
    public List<AwsOpensearchDomainCognitoOptionsBlock>? CognitoOptions
    {
        set => SetProperty("cognito_options", value);
    }

    /// <summary>
    /// Block for domain_endpoint_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DomainEndpointOptions block(s) allowed")]
    public List<AwsOpensearchDomainDomainEndpointOptionsBlock>? DomainEndpointOptions
    {
        set => SetProperty("domain_endpoint_options", value);
    }

    /// <summary>
    /// Block for ebs_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EbsOptions block(s) allowed")]
    public List<AwsOpensearchDomainEbsOptionsBlock>? EbsOptions
    {
        set => SetProperty("ebs_options", value);
    }

    /// <summary>
    /// Block for encrypt_at_rest.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptAtRest block(s) allowed")]
    public List<AwsOpensearchDomainEncryptAtRestBlock>? EncryptAtRest
    {
        set => SetProperty("encrypt_at_rest", value);
    }

    /// <summary>
    /// Block for log_publishing_options.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsOpensearchDomainLogPublishingOptionsBlock>? LogPublishingOptions
    {
        set => SetProperty("log_publishing_options", value);
    }

    /// <summary>
    /// Block for node_to_node_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeToNodeEncryption block(s) allowed")]
    public List<AwsOpensearchDomainNodeToNodeEncryptionBlock>? NodeToNodeEncryption
    {
        set => SetProperty("node_to_node_encryption", value);
    }

    /// <summary>
    /// Block for off_peak_window_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OffPeakWindowOptions block(s) allowed")]
    public List<AwsOpensearchDomainOffPeakWindowOptionsBlock>? OffPeakWindowOptions
    {
        set => SetProperty("off_peak_window_options", value);
    }

    /// <summary>
    /// Block for snapshot_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapshotOptions block(s) allowed")]
    public List<AwsOpensearchDomainSnapshotOptionsBlock>? SnapshotOptions
    {
        set => SetProperty("snapshot_options", value);
    }

    /// <summary>
    /// Block for software_update_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftwareUpdateOptions block(s) allowed")]
    public List<AwsOpensearchDomainSoftwareUpdateOptionsBlock>? SoftwareUpdateOptions
    {
        set => SetProperty("software_update_options", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsOpensearchDomainTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpc_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcOptions block(s) allowed")]
    public List<AwsOpensearchDomainVpcOptionsBlock>? VpcOptions
    {
        set => SetProperty("vpc_options", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The dashboard_endpoint attribute.
    /// </summary>
    public TerraformExpression DashboardEndpoint => this["dashboard_endpoint"];

    /// <summary>
    /// The dashboard_endpoint_v2 attribute.
    /// </summary>
    public TerraformExpression DashboardEndpointV2 => this["dashboard_endpoint_v2"];

    /// <summary>
    /// The domain_endpoint_v2_hosted_zone_id attribute.
    /// </summary>
    public TerraformExpression DomainEndpointV2HostedZoneId => this["domain_endpoint_v2_hosted_zone_id"];

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    public TerraformExpression DomainId => this["domain_id"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The endpoint_v2 attribute.
    /// </summary>
    public TerraformExpression EndpointV2 => this["endpoint_v2"];

}
