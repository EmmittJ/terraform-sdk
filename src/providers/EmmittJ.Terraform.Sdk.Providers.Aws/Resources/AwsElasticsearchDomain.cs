using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for advanced_security_options in AwsElasticsearchDomain.
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainAdvancedSecurityOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_security_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The internal_user_database_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? InternalUserDatabaseEnabled
    {
        get => GetArgument<TerraformValue<bool>>("internal_user_database_enabled");
        set => SetArgument("internal_user_database_enabled", value);
    }

    /// <summary>
    /// MasterUserOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MasterUserOptions block(s) allowed")]
    public TerraformList<AwsElasticsearchDomainAdvancedSecurityOptionsBlockMasterUserOptionsBlock>? MasterUserOptions
    {
        get => GetArgument<TerraformList<AwsElasticsearchDomainAdvancedSecurityOptionsBlockMasterUserOptionsBlock>>("master_user_options");
        set => SetArgument("master_user_options", value);
    }

}

/// <summary>
/// Block type for master_user_options in AwsElasticsearchDomainAdvancedSecurityOptionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainAdvancedSecurityOptionsBlockMasterUserOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "master_user_options";

    /// <summary>
    /// The master_user_arn attribute.
    /// </summary>
    public TerraformValue<string>? MasterUserArn
    {
        get => GetArgument<TerraformValue<string>>("master_user_arn");
        set => SetArgument("master_user_arn", value);
    }

    /// <summary>
    /// The master_user_name attribute.
    /// </summary>
    public TerraformValue<string>? MasterUserName
    {
        get => GetArgument<TerraformValue<string>>("master_user_name");
        set => SetArgument("master_user_name", value);
    }

    /// <summary>
    /// The master_user_password attribute.
    /// </summary>
    public TerraformValue<string>? MasterUserPassword
    {
        get => GetArgument<TerraformValue<string>>("master_user_password");
        set => SetArgument("master_user_password", value);
    }

}


/// <summary>
/// Block type for auto_tune_options in AwsElasticsearchDomain.
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainAutoTuneOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_tune_options";

    /// <summary>
    /// The desired_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DesiredState is required")]
    public required TerraformValue<string> DesiredState
    {
        get => GetArgument<TerraformValue<string>>("desired_state");
        set => SetArgument("desired_state", value);
    }

    /// <summary>
    /// The rollback_on_disable attribute.
    /// </summary>
    public TerraformValue<string>? RollbackOnDisable
    {
        get => GetArgument<TerraformValue<string>>("rollback_on_disable");
        set => SetArgument("rollback_on_disable", value);
    }

    /// <summary>
    /// MaintenanceSchedule block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsElasticsearchDomainAutoTuneOptionsBlockMaintenanceScheduleBlock>? MaintenanceSchedule
    {
        get => GetArgument<TerraformSet<AwsElasticsearchDomainAutoTuneOptionsBlockMaintenanceScheduleBlock>>("maintenance_schedule");
        set => SetArgument("maintenance_schedule", value);
    }

}

/// <summary>
/// Block type for maintenance_schedule in AwsElasticsearchDomainAutoTuneOptionsBlock.
/// Nesting mode: set
/// </summary>
public class AwsElasticsearchDomainAutoTuneOptionsBlockMaintenanceScheduleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_schedule";

    /// <summary>
    /// The cron_expression_for_recurrence attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CronExpressionForRecurrence is required")]
    public required TerraformValue<string> CronExpressionForRecurrence
    {
        get => GetArgument<TerraformValue<string>>("cron_expression_for_recurrence");
        set => SetArgument("cron_expression_for_recurrence", value);
    }

    /// <summary>
    /// The start_at attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartAt is required")]
    public required TerraformValue<string> StartAt
    {
        get => GetArgument<TerraformValue<string>>("start_at");
        set => SetArgument("start_at", value);
    }

    /// <summary>
    /// Duration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Duration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Duration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Duration block(s) allowed")]
    public required TerraformList<AwsElasticsearchDomainAutoTuneOptionsBlockMaintenanceScheduleBlockDurationBlock> Duration
    {
        get => GetRequiredArgument<TerraformList<AwsElasticsearchDomainAutoTuneOptionsBlockMaintenanceScheduleBlockDurationBlock>>("duration");
        set => SetArgument("duration", value);
    }

}

/// <summary>
/// Block type for duration in AwsElasticsearchDomainAutoTuneOptionsBlockMaintenanceScheduleBlock.
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainAutoTuneOptionsBlockMaintenanceScheduleBlockDurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "duration";

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Unit is required")]
    public required TerraformValue<string> Unit
    {
        get => GetArgument<TerraformValue<string>>("unit");
        set => SetArgument("unit", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<double> Value
    {
        get => GetArgument<TerraformValue<double>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for cluster_config in AwsElasticsearchDomain.
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainClusterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cluster_config";

    /// <summary>
    /// The dedicated_master_count attribute.
    /// </summary>
    public TerraformValue<double>? DedicatedMasterCount
    {
        get => GetArgument<TerraformValue<double>>("dedicated_master_count");
        set => SetArgument("dedicated_master_count", value);
    }

    /// <summary>
    /// The dedicated_master_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DedicatedMasterEnabled
    {
        get => GetArgument<TerraformValue<bool>>("dedicated_master_enabled");
        set => SetArgument("dedicated_master_enabled", value);
    }

    /// <summary>
    /// The dedicated_master_type attribute.
    /// </summary>
    public TerraformValue<string>? DedicatedMasterType
    {
        get => GetArgument<TerraformValue<string>>("dedicated_master_type");
        set => SetArgument("dedicated_master_type", value);
    }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    public TerraformValue<double>? InstanceCount
    {
        get => GetArgument<TerraformValue<double>>("instance_count");
        set => SetArgument("instance_count", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string>? InstanceType
    {
        get => GetArgument<TerraformValue<string>>("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The warm_count attribute.
    /// </summary>
    public TerraformValue<double>? WarmCount
    {
        get => GetArgument<TerraformValue<double>>("warm_count");
        set => SetArgument("warm_count", value);
    }

    /// <summary>
    /// The warm_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? WarmEnabled
    {
        get => GetArgument<TerraformValue<bool>>("warm_enabled");
        set => SetArgument("warm_enabled", value);
    }

    /// <summary>
    /// The warm_type attribute.
    /// </summary>
    public TerraformValue<string>? WarmType
    {
        get => GetArgument<TerraformValue<string>>("warm_type");
        set => SetArgument("warm_type", value);
    }

    /// <summary>
    /// The zone_awareness_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ZoneAwarenessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("zone_awareness_enabled");
        set => SetArgument("zone_awareness_enabled", value);
    }

    /// <summary>
    /// ColdStorageOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ColdStorageOptions block(s) allowed")]
    public TerraformList<AwsElasticsearchDomainClusterConfigBlockColdStorageOptionsBlock>? ColdStorageOptions
    {
        get => GetArgument<TerraformList<AwsElasticsearchDomainClusterConfigBlockColdStorageOptionsBlock>>("cold_storage_options");
        set => SetArgument("cold_storage_options", value);
    }

    /// <summary>
    /// ZoneAwarenessConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ZoneAwarenessConfig block(s) allowed")]
    public TerraformList<AwsElasticsearchDomainClusterConfigBlockZoneAwarenessConfigBlock>? ZoneAwarenessConfig
    {
        get => GetArgument<TerraformList<AwsElasticsearchDomainClusterConfigBlockZoneAwarenessConfigBlock>>("zone_awareness_config");
        set => SetArgument("zone_awareness_config", value);
    }

}

/// <summary>
/// Block type for cold_storage_options in AwsElasticsearchDomainClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainClusterConfigBlockColdStorageOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cold_storage_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}

/// <summary>
/// Block type for zone_awareness_config in AwsElasticsearchDomainClusterConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainClusterConfigBlockZoneAwarenessConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "zone_awareness_config";

    /// <summary>
    /// The availability_zone_count attribute.
    /// </summary>
    public TerraformValue<double>? AvailabilityZoneCount
    {
        get => GetArgument<TerraformValue<double>>("availability_zone_count");
        set => SetArgument("availability_zone_count", value);
    }

}


/// <summary>
/// Block type for cognito_options in AwsElasticsearchDomain.
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainCognitoOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cognito_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The identity_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityPoolId is required")]
    public required TerraformValue<string> IdentityPoolId
    {
        get => GetArgument<TerraformValue<string>>("identity_pool_id");
        set => SetArgument("identity_pool_id", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => GetArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformValue<string> UserPoolId
    {
        get => GetArgument<TerraformValue<string>>("user_pool_id");
        set => SetArgument("user_pool_id", value);
    }

}


/// <summary>
/// Block type for domain_endpoint_options in AwsElasticsearchDomain.
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainDomainEndpointOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "domain_endpoint_options";

    /// <summary>
    /// The custom_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? CustomEndpoint
    {
        get => GetArgument<TerraformValue<string>>("custom_endpoint");
        set => SetArgument("custom_endpoint", value);
    }

    /// <summary>
    /// The custom_endpoint_certificate_arn attribute.
    /// </summary>
    public TerraformValue<string>? CustomEndpointCertificateArn
    {
        get => GetArgument<TerraformValue<string>>("custom_endpoint_certificate_arn");
        set => SetArgument("custom_endpoint_certificate_arn", value);
    }

    /// <summary>
    /// The custom_endpoint_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CustomEndpointEnabled
    {
        get => GetArgument<TerraformValue<bool>>("custom_endpoint_enabled");
        set => SetArgument("custom_endpoint_enabled", value);
    }

    /// <summary>
    /// The enforce_https attribute.
    /// </summary>
    public TerraformValue<bool>? EnforceHttps
    {
        get => GetArgument<TerraformValue<bool>>("enforce_https");
        set => SetArgument("enforce_https", value);
    }

    /// <summary>
    /// The tls_security_policy attribute.
    /// </summary>
    public TerraformValue<string>? TlsSecurityPolicy
    {
        get => GetArgument<TerraformValue<string>>("tls_security_policy");
        set => SetArgument("tls_security_policy", value);
    }

}


/// <summary>
/// Block type for ebs_options in AwsElasticsearchDomain.
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainEbsOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ebs_options";

    /// <summary>
    /// The ebs_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EbsEnabled is required")]
    public required TerraformValue<bool> EbsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("ebs_enabled");
        set => SetArgument("ebs_enabled", value);
    }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    public TerraformValue<double>? Iops
    {
        get => GetArgument<TerraformValue<double>>("iops");
        set => SetArgument("iops", value);
    }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    public TerraformValue<double>? Throughput
    {
        get => GetArgument<TerraformValue<double>>("throughput");
        set => SetArgument("throughput", value);
    }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    public TerraformValue<double>? VolumeSize
    {
        get => GetArgument<TerraformValue<double>>("volume_size");
        set => SetArgument("volume_size", value);
    }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    public TerraformValue<string>? VolumeType
    {
        get => GetArgument<TerraformValue<string>>("volume_type");
        set => SetArgument("volume_type", value);
    }

}


/// <summary>
/// Block type for encrypt_at_rest in AwsElasticsearchDomain.
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainEncryptAtRestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encrypt_at_rest";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

}


/// <summary>
/// Block type for log_publishing_options in AwsElasticsearchDomain.
/// Nesting mode: set
/// </summary>
public class AwsElasticsearchDomainLogPublishingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "log_publishing_options";

    /// <summary>
    /// The cloudwatch_log_group_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudwatchLogGroupArn is required")]
    public required TerraformValue<string> CloudwatchLogGroupArn
    {
        get => GetArgument<TerraformValue<string>>("cloudwatch_log_group_arn");
        set => SetArgument("cloudwatch_log_group_arn", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The log_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogType is required")]
    public required TerraformValue<string> LogType
    {
        get => GetArgument<TerraformValue<string>>("log_type");
        set => SetArgument("log_type", value);
    }

}


/// <summary>
/// Block type for node_to_node_encryption in AwsElasticsearchDomain.
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainNodeToNodeEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "node_to_node_encryption";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for snapshot_options in AwsElasticsearchDomain.
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainSnapshotOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "snapshot_options";

    /// <summary>
    /// The automated_snapshot_start_hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomatedSnapshotStartHour is required")]
    public required TerraformValue<double> AutomatedSnapshotStartHour
    {
        get => GetArgument<TerraformValue<double>>("automated_snapshot_start_hour");
        set => SetArgument("automated_snapshot_start_hour", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsElasticsearchDomain.
/// Nesting mode: single
/// </summary>
public class AwsElasticsearchDomainTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for vpc_options in AwsElasticsearchDomain.
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainVpcOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_options";

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    public TerraformSet<string> AvailabilityZones
        => AsReference("availability_zones");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string>? SubnetIds
    {
        get => GetArgument<TerraformSet<string>>("subnet_ids");
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => AsReference("vpc_id");

}


/// <summary>
/// Represents a aws_elasticsearch_domain Terraform resource.
/// Manages a aws_elasticsearch_domain resource.
/// </summary>
public partial class AwsElasticsearchDomain(string name) : TerraformResource("aws_elasticsearch_domain", name)
{
    /// <summary>
    /// The access_policies attribute.
    /// </summary>
    public TerraformValue<string>? AccessPolicies
    {
        get => GetArgument<TerraformValue<string>>("access_policies");
        set => SetArgument("access_policies", value);
    }

    /// <summary>
    /// The advanced_options attribute.
    /// </summary>
    public TerraformMap<string>? AdvancedOptions
    {
        get => GetArgument<TerraformMap<string>>("advanced_options");
        set => SetArgument("advanced_options", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => GetArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The elasticsearch_version attribute.
    /// </summary>
    public TerraformValue<string>? ElasticsearchVersion
    {
        get => GetArgument<TerraformValue<string>>("elasticsearch_version");
        set => SetArgument("elasticsearch_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    public TerraformValue<string> DomainId
        => AsReference("domain_id");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// The kibana_endpoint attribute.
    /// </summary>
    public TerraformValue<string> KibanaEndpoint
        => AsReference("kibana_endpoint");

    /// <summary>
    /// AdvancedSecurityOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedSecurityOptions block(s) allowed")]
    public TerraformList<AwsElasticsearchDomainAdvancedSecurityOptionsBlock>? AdvancedSecurityOptions
    {
        get => GetArgument<TerraformList<AwsElasticsearchDomainAdvancedSecurityOptionsBlock>>("advanced_security_options");
        set => SetArgument("advanced_security_options", value);
    }

    /// <summary>
    /// AutoTuneOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoTuneOptions block(s) allowed")]
    public TerraformList<AwsElasticsearchDomainAutoTuneOptionsBlock>? AutoTuneOptions
    {
        get => GetArgument<TerraformList<AwsElasticsearchDomainAutoTuneOptionsBlock>>("auto_tune_options");
        set => SetArgument("auto_tune_options", value);
    }

    /// <summary>
    /// ClusterConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterConfig block(s) allowed")]
    public TerraformList<AwsElasticsearchDomainClusterConfigBlock>? ClusterConfig
    {
        get => GetArgument<TerraformList<AwsElasticsearchDomainClusterConfigBlock>>("cluster_config");
        set => SetArgument("cluster_config", value);
    }

    /// <summary>
    /// CognitoOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CognitoOptions block(s) allowed")]
    public TerraformList<AwsElasticsearchDomainCognitoOptionsBlock>? CognitoOptions
    {
        get => GetArgument<TerraformList<AwsElasticsearchDomainCognitoOptionsBlock>>("cognito_options");
        set => SetArgument("cognito_options", value);
    }

    /// <summary>
    /// DomainEndpointOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DomainEndpointOptions block(s) allowed")]
    public TerraformList<AwsElasticsearchDomainDomainEndpointOptionsBlock>? DomainEndpointOptions
    {
        get => GetArgument<TerraformList<AwsElasticsearchDomainDomainEndpointOptionsBlock>>("domain_endpoint_options");
        set => SetArgument("domain_endpoint_options", value);
    }

    /// <summary>
    /// EbsOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EbsOptions block(s) allowed")]
    public TerraformList<AwsElasticsearchDomainEbsOptionsBlock>? EbsOptions
    {
        get => GetArgument<TerraformList<AwsElasticsearchDomainEbsOptionsBlock>>("ebs_options");
        set => SetArgument("ebs_options", value);
    }

    /// <summary>
    /// EncryptAtRest block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptAtRest block(s) allowed")]
    public TerraformList<AwsElasticsearchDomainEncryptAtRestBlock>? EncryptAtRest
    {
        get => GetArgument<TerraformList<AwsElasticsearchDomainEncryptAtRestBlock>>("encrypt_at_rest");
        set => SetArgument("encrypt_at_rest", value);
    }

    /// <summary>
    /// LogPublishingOptions block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsElasticsearchDomainLogPublishingOptionsBlock>? LogPublishingOptions
    {
        get => GetArgument<TerraformSet<AwsElasticsearchDomainLogPublishingOptionsBlock>>("log_publishing_options");
        set => SetArgument("log_publishing_options", value);
    }

    /// <summary>
    /// NodeToNodeEncryption block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeToNodeEncryption block(s) allowed")]
    public TerraformList<AwsElasticsearchDomainNodeToNodeEncryptionBlock>? NodeToNodeEncryption
    {
        get => GetArgument<TerraformList<AwsElasticsearchDomainNodeToNodeEncryptionBlock>>("node_to_node_encryption");
        set => SetArgument("node_to_node_encryption", value);
    }

    /// <summary>
    /// SnapshotOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapshotOptions block(s) allowed")]
    public TerraformList<AwsElasticsearchDomainSnapshotOptionsBlock>? SnapshotOptions
    {
        get => GetArgument<TerraformList<AwsElasticsearchDomainSnapshotOptionsBlock>>("snapshot_options");
        set => SetArgument("snapshot_options", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsElasticsearchDomainTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsElasticsearchDomainTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VpcOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcOptions block(s) allowed")]
    public TerraformList<AwsElasticsearchDomainVpcOptionsBlock>? VpcOptions
    {
        get => GetArgument<TerraformList<AwsElasticsearchDomainVpcOptionsBlock>>("vpc_options");
        set => SetArgument("vpc_options", value);
    }

}
