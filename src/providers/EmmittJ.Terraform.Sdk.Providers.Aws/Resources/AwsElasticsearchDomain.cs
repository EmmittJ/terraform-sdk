using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for advanced_security_options in .
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainAdvancedSecurityOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The internal_user_database_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? InternalUserDatabaseEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("internal_user_database_enabled");
        set => WithProperty("internal_user_database_enabled", value);
    }

}

/// <summary>
/// Block type for auto_tune_options in .
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainAutoTuneOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The desired_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DesiredState is required")]
    public required TerraformProperty<string> DesiredState
    {
        get => GetRequiredProperty<TerraformProperty<string>>("desired_state");
        set => WithProperty("desired_state", value);
    }

    /// <summary>
    /// The rollback_on_disable attribute.
    /// </summary>
    public TerraformProperty<string>? RollbackOnDisable
    {
        get => GetProperty<TerraformProperty<string>>("rollback_on_disable");
        set => WithProperty("rollback_on_disable", value);
    }

}

/// <summary>
/// Block type for cluster_config in .
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainClusterConfigBlock : TerraformBlock
{
    /// <summary>
    /// The dedicated_master_count attribute.
    /// </summary>
    public TerraformProperty<double>? DedicatedMasterCount
    {
        get => GetProperty<TerraformProperty<double>>("dedicated_master_count");
        set => WithProperty("dedicated_master_count", value);
    }

    /// <summary>
    /// The dedicated_master_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DedicatedMasterEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("dedicated_master_enabled");
        set => WithProperty("dedicated_master_enabled", value);
    }

    /// <summary>
    /// The dedicated_master_type attribute.
    /// </summary>
    public TerraformProperty<string>? DedicatedMasterType
    {
        get => GetProperty<TerraformProperty<string>>("dedicated_master_type");
        set => WithProperty("dedicated_master_type", value);
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
    public TerraformProperty<string>? InstanceType
    {
        get => GetProperty<TerraformProperty<string>>("instance_type");
        set => WithProperty("instance_type", value);
    }

    /// <summary>
    /// The warm_count attribute.
    /// </summary>
    public TerraformProperty<double>? WarmCount
    {
        get => GetProperty<TerraformProperty<double>>("warm_count");
        set => WithProperty("warm_count", value);
    }

    /// <summary>
    /// The warm_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? WarmEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("warm_enabled");
        set => WithProperty("warm_enabled", value);
    }

    /// <summary>
    /// The warm_type attribute.
    /// </summary>
    public TerraformProperty<string>? WarmType
    {
        get => GetProperty<TerraformProperty<string>>("warm_type");
        set => WithProperty("warm_type", value);
    }

    /// <summary>
    /// The zone_awareness_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ZoneAwarenessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("zone_awareness_enabled");
        set => WithProperty("zone_awareness_enabled", value);
    }

}

/// <summary>
/// Block type for cognito_options in .
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainCognitoOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The identity_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityPoolId is required")]
    public required TerraformProperty<string> IdentityPoolId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("identity_pool_id");
        set => WithProperty("identity_pool_id", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformProperty<string> UserPoolId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("user_pool_id");
        set => WithProperty("user_pool_id", value);
    }

}

/// <summary>
/// Block type for domain_endpoint_options in .
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainDomainEndpointOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The custom_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? CustomEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("custom_endpoint");
        set => WithProperty("custom_endpoint", value);
    }

    /// <summary>
    /// The custom_endpoint_certificate_arn attribute.
    /// </summary>
    public TerraformProperty<string>? CustomEndpointCertificateArn
    {
        get => GetProperty<TerraformProperty<string>>("custom_endpoint_certificate_arn");
        set => WithProperty("custom_endpoint_certificate_arn", value);
    }

    /// <summary>
    /// The custom_endpoint_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CustomEndpointEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("custom_endpoint_enabled");
        set => WithProperty("custom_endpoint_enabled", value);
    }

    /// <summary>
    /// The enforce_https attribute.
    /// </summary>
    public TerraformProperty<bool>? EnforceHttps
    {
        get => GetProperty<TerraformProperty<bool>>("enforce_https");
        set => WithProperty("enforce_https", value);
    }

    /// <summary>
    /// The tls_security_policy attribute.
    /// </summary>
    public TerraformProperty<string>? TlsSecurityPolicy
    {
        get => GetProperty<TerraformProperty<string>>("tls_security_policy");
        set => WithProperty("tls_security_policy", value);
    }

}

/// <summary>
/// Block type for ebs_options in .
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainEbsOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The ebs_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EbsEnabled is required")]
    public required TerraformProperty<bool> EbsEnabled
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("ebs_enabled");
        set => WithProperty("ebs_enabled", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformProperty<double>? Iops
    {
        get => GetProperty<TerraformProperty<double>>("iops");
        set => WithProperty("iops", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformProperty<double>? Throughput
    {
        get => GetProperty<TerraformProperty<double>>("throughput");
        set => WithProperty("throughput", value);
    }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformProperty<double>? VolumeSize
    {
        get => GetProperty<TerraformProperty<double>>("volume_size");
        set => WithProperty("volume_size", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformProperty<string>? VolumeType
    {
        get => GetProperty<TerraformProperty<string>>("volume_type");
        set => WithProperty("volume_type", value);
    }

}

/// <summary>
/// Block type for encrypt_at_rest in .
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainEncryptAtRestBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => WithProperty("kms_key_id", value);
    }

}

/// <summary>
/// Block type for log_publishing_options in .
/// Nesting mode: set
/// </summary>
public class AwsElasticsearchDomainLogPublishingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The cloudwatch_log_group_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudwatchLogGroupArn is required")]
    public required TerraformProperty<string> CloudwatchLogGroupArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cloudwatch_log_group_arn");
        set => WithProperty("cloudwatch_log_group_arn", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The log_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogType is required")]
    public required TerraformProperty<string> LogType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("log_type");
        set => WithProperty("log_type", value);
    }

}

/// <summary>
/// Block type for node_to_node_encryption in .
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainNodeToNodeEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

}

/// <summary>
/// Block type for snapshot_options in .
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainSnapshotOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The automated_snapshot_start_hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomatedSnapshotStartHour is required")]
    public required TerraformProperty<double> AutomatedSnapshotStartHour
    {
        get => GetRequiredProperty<TerraformProperty<double>>("automated_snapshot_start_hour");
        set => WithProperty("automated_snapshot_start_hour", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsElasticsearchDomainTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for vpc_options in .
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainVpcOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AvailabilityZones
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("availability_zones");
        set => WithProperty("availability_zones", value);
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
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => WithProperty("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => WithProperty("vpc_id", value);
    }

}

/// <summary>
/// Manages a aws_elasticsearch_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsElasticsearchDomain : TerraformResource
{
    public AwsElasticsearchDomain(string name) : base("aws_elasticsearch_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("domain_id");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("kibana_endpoint");
    }

    /// <summary>
    /// The access_policies attribute.
    /// </summary>
    public TerraformProperty<string>? AccessPolicies
    {
        get => GetProperty<TerraformProperty<string>>("access_policies");
        set => this.WithProperty("access_policies", value);
    }

    /// <summary>
    /// The advanced_options attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? AdvancedOptions
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("advanced_options");
        set => this.WithProperty("advanced_options", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
    }

    /// <summary>
    /// The elasticsearch_version attribute.
    /// </summary>
    public TerraformProperty<string>? ElasticsearchVersion
    {
        get => GetProperty<TerraformProperty<string>>("elasticsearch_version");
        set => this.WithProperty("elasticsearch_version", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
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
    /// Block for advanced_security_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedSecurityOptions block(s) allowed")]
    public List<AwsElasticsearchDomainAdvancedSecurityOptionsBlock>? AdvancedSecurityOptions
    {
        get => GetProperty<List<AwsElasticsearchDomainAdvancedSecurityOptionsBlock>>("advanced_security_options");
        set => this.WithProperty("advanced_security_options", value);
    }

    /// <summary>
    /// Block for auto_tune_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoTuneOptions block(s) allowed")]
    public List<AwsElasticsearchDomainAutoTuneOptionsBlock>? AutoTuneOptions
    {
        get => GetProperty<List<AwsElasticsearchDomainAutoTuneOptionsBlock>>("auto_tune_options");
        set => this.WithProperty("auto_tune_options", value);
    }

    /// <summary>
    /// Block for cluster_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterConfig block(s) allowed")]
    public List<AwsElasticsearchDomainClusterConfigBlock>? ClusterConfig
    {
        get => GetProperty<List<AwsElasticsearchDomainClusterConfigBlock>>("cluster_config");
        set => this.WithProperty("cluster_config", value);
    }

    /// <summary>
    /// Block for cognito_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CognitoOptions block(s) allowed")]
    public List<AwsElasticsearchDomainCognitoOptionsBlock>? CognitoOptions
    {
        get => GetProperty<List<AwsElasticsearchDomainCognitoOptionsBlock>>("cognito_options");
        set => this.WithProperty("cognito_options", value);
    }

    /// <summary>
    /// Block for domain_endpoint_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DomainEndpointOptions block(s) allowed")]
    public List<AwsElasticsearchDomainDomainEndpointOptionsBlock>? DomainEndpointOptions
    {
        get => GetProperty<List<AwsElasticsearchDomainDomainEndpointOptionsBlock>>("domain_endpoint_options");
        set => this.WithProperty("domain_endpoint_options", value);
    }

    /// <summary>
    /// Block for ebs_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EbsOptions block(s) allowed")]
    public List<AwsElasticsearchDomainEbsOptionsBlock>? EbsOptions
    {
        get => GetProperty<List<AwsElasticsearchDomainEbsOptionsBlock>>("ebs_options");
        set => this.WithProperty("ebs_options", value);
    }

    /// <summary>
    /// Block for encrypt_at_rest.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptAtRest block(s) allowed")]
    public List<AwsElasticsearchDomainEncryptAtRestBlock>? EncryptAtRest
    {
        get => GetProperty<List<AwsElasticsearchDomainEncryptAtRestBlock>>("encrypt_at_rest");
        set => this.WithProperty("encrypt_at_rest", value);
    }

    /// <summary>
    /// Block for log_publishing_options.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsElasticsearchDomainLogPublishingOptionsBlock>? LogPublishingOptions
    {
        get => GetProperty<HashSet<AwsElasticsearchDomainLogPublishingOptionsBlock>>("log_publishing_options");
        set => this.WithProperty("log_publishing_options", value);
    }

    /// <summary>
    /// Block for node_to_node_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeToNodeEncryption block(s) allowed")]
    public List<AwsElasticsearchDomainNodeToNodeEncryptionBlock>? NodeToNodeEncryption
    {
        get => GetProperty<List<AwsElasticsearchDomainNodeToNodeEncryptionBlock>>("node_to_node_encryption");
        set => this.WithProperty("node_to_node_encryption", value);
    }

    /// <summary>
    /// Block for snapshot_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapshotOptions block(s) allowed")]
    public List<AwsElasticsearchDomainSnapshotOptionsBlock>? SnapshotOptions
    {
        get => GetProperty<List<AwsElasticsearchDomainSnapshotOptionsBlock>>("snapshot_options");
        set => this.WithProperty("snapshot_options", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsElasticsearchDomainTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsElasticsearchDomainTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpc_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcOptions block(s) allowed")]
    public List<AwsElasticsearchDomainVpcOptionsBlock>? VpcOptions
    {
        get => GetProperty<List<AwsElasticsearchDomainVpcOptionsBlock>>("vpc_options");
        set => this.WithProperty("vpc_options", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    public TerraformExpression DomainId => this["domain_id"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The kibana_endpoint attribute.
    /// </summary>
    public TerraformExpression KibanaEndpoint => this["kibana_endpoint"];

}
