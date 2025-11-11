using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for advanced_security_options in .
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainAdvancedSecurityOptionsBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The internal_user_database_enabled attribute.
    /// </summary>
    [TerraformPropertyName("internal_user_database_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? InternalUserDatabaseEnabled { get; set; }

}

/// <summary>
/// Block type for auto_tune_options in .
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainAutoTuneOptionsBlock
{
    /// <summary>
    /// The desired_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DesiredState is required")]
    [TerraformPropertyName("desired_state")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DesiredState { get; set; }

    /// <summary>
    /// The rollback_on_disable attribute.
    /// </summary>
    [TerraformPropertyName("rollback_on_disable")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RollbackOnDisable { get; set; } = default!;

}

/// <summary>
/// Block type for cluster_config in .
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainClusterConfigBlock
{
    /// <summary>
    /// The dedicated_master_count attribute.
    /// </summary>
    [TerraformPropertyName("dedicated_master_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DedicatedMasterCount { get; set; }

    /// <summary>
    /// The dedicated_master_enabled attribute.
    /// </summary>
    [TerraformPropertyName("dedicated_master_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DedicatedMasterEnabled { get; set; }

    /// <summary>
    /// The dedicated_master_type attribute.
    /// </summary>
    [TerraformPropertyName("dedicated_master_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DedicatedMasterType { get; set; }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [TerraformPropertyName("instance_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? InstanceCount { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InstanceType { get; set; }

    /// <summary>
    /// The warm_count attribute.
    /// </summary>
    [TerraformPropertyName("warm_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? WarmCount { get; set; }

    /// <summary>
    /// The warm_enabled attribute.
    /// </summary>
    [TerraformPropertyName("warm_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? WarmEnabled { get; set; }

    /// <summary>
    /// The warm_type attribute.
    /// </summary>
    [TerraformPropertyName("warm_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WarmType { get; set; }

    /// <summary>
    /// The zone_awareness_enabled attribute.
    /// </summary>
    [TerraformPropertyName("zone_awareness_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ZoneAwarenessEnabled { get; set; }

}

/// <summary>
/// Block type for cognito_options in .
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainCognitoOptionsBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The identity_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityPoolId is required")]
    [TerraformPropertyName("identity_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IdentityPoolId { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformPropertyName("user_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> UserPoolId { get; set; }

}

/// <summary>
/// Block type for domain_endpoint_options in .
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainDomainEndpointOptionsBlock
{
    /// <summary>
    /// The custom_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("custom_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomEndpoint { get; set; }

    /// <summary>
    /// The custom_endpoint_certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("custom_endpoint_certificate_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomEndpointCertificateArn { get; set; }

    /// <summary>
    /// The custom_endpoint_enabled attribute.
    /// </summary>
    [TerraformPropertyName("custom_endpoint_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CustomEndpointEnabled { get; set; }

    /// <summary>
    /// The enforce_https attribute.
    /// </summary>
    [TerraformPropertyName("enforce_https")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EnforceHttps { get; set; }

    /// <summary>
    /// The tls_security_policy attribute.
    /// </summary>
    [TerraformPropertyName("tls_security_policy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TlsSecurityPolicy { get; set; } = default!;

}

/// <summary>
/// Block type for ebs_options in .
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainEbsOptionsBlock
{
    /// <summary>
    /// The ebs_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EbsEnabled is required")]
    [TerraformPropertyName("ebs_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> EbsEnabled { get; set; }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformPropertyName("iops")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Iops { get; set; } = default!;

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    [TerraformPropertyName("throughput")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Throughput { get; set; } = default!;

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    [TerraformPropertyName("volume_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? VolumeSize { get; set; }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    [TerraformPropertyName("volume_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> VolumeType { get; set; } = default!;

}

/// <summary>
/// Block type for encrypt_at_rest in .
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainEncryptAtRestBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsKeyId { get; set; } = default!;

}

/// <summary>
/// Block type for log_publishing_options in .
/// Nesting mode: set
/// </summary>
public class AwsElasticsearchDomainLogPublishingOptionsBlock
{
    /// <summary>
    /// The cloudwatch_log_group_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudwatchLogGroupArn is required")]
    [TerraformPropertyName("cloudwatch_log_group_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CloudwatchLogGroupArn { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The log_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogType is required")]
    [TerraformPropertyName("log_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LogType { get; set; }

}

/// <summary>
/// Block type for node_to_node_encryption in .
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainNodeToNodeEncryptionBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for snapshot_options in .
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainSnapshotOptionsBlock
{
    /// <summary>
    /// The automated_snapshot_start_hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomatedSnapshotStartHour is required")]
    [TerraformPropertyName("automated_snapshot_start_hour")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> AutomatedSnapshotStartHour { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsElasticsearchDomainTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for vpc_options in .
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainVpcOptionsBlock
{

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SubnetIds { get; set; }


}

/// <summary>
/// Manages a aws_elasticsearch_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsElasticsearchDomain : TerraformResource
{
    public AwsElasticsearchDomain(string name) : base("aws_elasticsearch_domain", name)
    {
    }

    /// <summary>
    /// The access_policies attribute.
    /// </summary>
    [TerraformPropertyName("access_policies")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AccessPolicies { get; set; } = default!;

    /// <summary>
    /// The advanced_options attribute.
    /// </summary>
    [TerraformPropertyName("advanced_options")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> AdvancedOptions { get; set; } = default!;

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The elasticsearch_version attribute.
    /// </summary>
    [TerraformPropertyName("elasticsearch_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ElasticsearchVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

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
    /// Block for advanced_security_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedSecurityOptions block(s) allowed")]
    [TerraformPropertyName("advanced_security_options")]
    public TerraformList<TerraformBlock<AwsElasticsearchDomainAdvancedSecurityOptionsBlock>>? AdvancedSecurityOptions { get; set; }

    /// <summary>
    /// Block for auto_tune_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoTuneOptions block(s) allowed")]
    [TerraformPropertyName("auto_tune_options")]
    public TerraformList<TerraformBlock<AwsElasticsearchDomainAutoTuneOptionsBlock>>? AutoTuneOptions { get; set; }

    /// <summary>
    /// Block for cluster_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterConfig block(s) allowed")]
    [TerraformPropertyName("cluster_config")]
    public TerraformList<TerraformBlock<AwsElasticsearchDomainClusterConfigBlock>>? ClusterConfig { get; set; }

    /// <summary>
    /// Block for cognito_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CognitoOptions block(s) allowed")]
    [TerraformPropertyName("cognito_options")]
    public TerraformList<TerraformBlock<AwsElasticsearchDomainCognitoOptionsBlock>>? CognitoOptions { get; set; }

    /// <summary>
    /// Block for domain_endpoint_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DomainEndpointOptions block(s) allowed")]
    [TerraformPropertyName("domain_endpoint_options")]
    public TerraformList<TerraformBlock<AwsElasticsearchDomainDomainEndpointOptionsBlock>>? DomainEndpointOptions { get; set; }

    /// <summary>
    /// Block for ebs_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EbsOptions block(s) allowed")]
    [TerraformPropertyName("ebs_options")]
    public TerraformList<TerraformBlock<AwsElasticsearchDomainEbsOptionsBlock>>? EbsOptions { get; set; }

    /// <summary>
    /// Block for encrypt_at_rest.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptAtRest block(s) allowed")]
    [TerraformPropertyName("encrypt_at_rest")]
    public TerraformList<TerraformBlock<AwsElasticsearchDomainEncryptAtRestBlock>>? EncryptAtRest { get; set; }

    /// <summary>
    /// Block for log_publishing_options.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("log_publishing_options")]
    public TerraformSet<TerraformBlock<AwsElasticsearchDomainLogPublishingOptionsBlock>>? LogPublishingOptions { get; set; }

    /// <summary>
    /// Block for node_to_node_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeToNodeEncryption block(s) allowed")]
    [TerraformPropertyName("node_to_node_encryption")]
    public TerraformList<TerraformBlock<AwsElasticsearchDomainNodeToNodeEncryptionBlock>>? NodeToNodeEncryption { get; set; }

    /// <summary>
    /// Block for snapshot_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapshotOptions block(s) allowed")]
    [TerraformPropertyName("snapshot_options")]
    public TerraformList<TerraformBlock<AwsElasticsearchDomainSnapshotOptionsBlock>>? SnapshotOptions { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsElasticsearchDomainTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for vpc_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcOptions block(s) allowed")]
    [TerraformPropertyName("vpc_options")]
    public TerraformList<TerraformBlock<AwsElasticsearchDomainVpcOptionsBlock>>? VpcOptions { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    [TerraformPropertyName("domain_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DomainId => new TerraformReference(this, "domain_id");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Endpoint => new TerraformReference(this, "endpoint");

    /// <summary>
    /// The kibana_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("kibana_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KibanaEndpoint => new TerraformReference(this, "kibana_endpoint");

}
