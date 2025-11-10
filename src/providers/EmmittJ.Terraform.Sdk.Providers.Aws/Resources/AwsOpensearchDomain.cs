using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for advanced_security_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainAdvancedSecurityOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The anonymous_auth_enabled attribute.
    /// </summary>
    [TerraformPropertyName("anonymous_auth_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> AnonymousAuthEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "anonymous_auth_enabled");

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The internal_user_database_enabled attribute.
    /// </summary>
    [TerraformPropertyName("internal_user_database_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? InternalUserDatabaseEnabled { get; set; }

}

/// <summary>
/// Block type for aiml_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainAimlOptionsBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for auto_tune_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainAutoTuneOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The desired_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DesiredState is required")]
    [TerraformPropertyName("desired_state")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DesiredState { get; set; }

    /// <summary>
    /// The rollback_on_disable attribute.
    /// </summary>
    [TerraformPropertyName("rollback_on_disable")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RollbackOnDisable { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "rollback_on_disable");

    /// <summary>
    /// The use_off_peak_window attribute.
    /// </summary>
    [TerraformPropertyName("use_off_peak_window")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseOffPeakWindow { get; set; }

}

/// <summary>
/// Block type for cluster_config in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainClusterConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The dedicated_master_count attribute.
    /// </summary>
    [TerraformPropertyName("dedicated_master_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DedicatedMasterCount { get; set; }

    /// <summary>
    /// The dedicated_master_enabled attribute.
    /// </summary>
    [TerraformPropertyName("dedicated_master_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DedicatedMasterEnabled { get; set; }

    /// <summary>
    /// The dedicated_master_type attribute.
    /// </summary>
    [TerraformPropertyName("dedicated_master_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DedicatedMasterType { get; set; }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [TerraformPropertyName("instance_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? InstanceCount { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformPropertyName("instance_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InstanceType { get; set; }

    /// <summary>
    /// The multi_az_with_standby_enabled attribute.
    /// </summary>
    [TerraformPropertyName("multi_az_with_standby_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MultiAzWithStandbyEnabled { get; set; }

    /// <summary>
    /// The warm_count attribute.
    /// </summary>
    [TerraformPropertyName("warm_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? WarmCount { get; set; }

    /// <summary>
    /// The warm_enabled attribute.
    /// </summary>
    [TerraformPropertyName("warm_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? WarmEnabled { get; set; }

    /// <summary>
    /// The warm_type attribute.
    /// </summary>
    [TerraformPropertyName("warm_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WarmType { get; set; }

    /// <summary>
    /// The zone_awareness_enabled attribute.
    /// </summary>
    [TerraformPropertyName("zone_awareness_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ZoneAwarenessEnabled { get; set; }

}

/// <summary>
/// Block type for cognito_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainCognitoOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The identity_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityPoolId is required")]
    [TerraformPropertyName("identity_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IdentityPoolId { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformPropertyName("user_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UserPoolId { get; set; }

}

/// <summary>
/// Block type for domain_endpoint_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainDomainEndpointOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The custom_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("custom_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomEndpoint { get; set; }

    /// <summary>
    /// The custom_endpoint_certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("custom_endpoint_certificate_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomEndpointCertificateArn { get; set; }

    /// <summary>
    /// The custom_endpoint_enabled attribute.
    /// </summary>
    [TerraformPropertyName("custom_endpoint_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CustomEndpointEnabled { get; set; }

    /// <summary>
    /// The enforce_https attribute.
    /// </summary>
    [TerraformPropertyName("enforce_https")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnforceHttps { get; set; }

    /// <summary>
    /// The tls_security_policy attribute.
    /// </summary>
    [TerraformPropertyName("tls_security_policy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TlsSecurityPolicy { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "tls_security_policy");

}

/// <summary>
/// Block type for ebs_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainEbsOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The ebs_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EbsEnabled is required")]
    [TerraformPropertyName("ebs_enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> EbsEnabled { get; set; }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformPropertyName("iops")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Iops { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "iops");

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    [TerraformPropertyName("throughput")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Throughput { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "throughput");

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    [TerraformPropertyName("volume_size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? VolumeSize { get; set; }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    [TerraformPropertyName("volume_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> VolumeType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "volume_type");

}

/// <summary>
/// Block type for encrypt_at_rest in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainEncryptAtRestBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "kms_key_id");

}

/// <summary>
/// Block type for log_publishing_options in .
/// Nesting mode: set
/// </summary>
public class AwsOpensearchDomainLogPublishingOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The cloudwatch_log_group_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudwatchLogGroupArn is required")]
    [TerraformPropertyName("cloudwatch_log_group_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CloudwatchLogGroupArn { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The log_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogType is required")]
    [TerraformPropertyName("log_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LogType { get; set; }

}

/// <summary>
/// Block type for node_to_node_encryption in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainNodeToNodeEncryptionBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

}

/// <summary>
/// Block type for off_peak_window_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainOffPeakWindowOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> Enabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "enabled");

}

/// <summary>
/// Block type for snapshot_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainSnapshotOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The automated_snapshot_start_hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomatedSnapshotStartHour is required")]
    [TerraformPropertyName("automated_snapshot_start_hour")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> AutomatedSnapshotStartHour { get; set; }

}

/// <summary>
/// Block type for software_update_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainSoftwareUpdateOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The auto_software_update_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auto_software_update_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> AutoSoftwareUpdateEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "auto_software_update_enabled");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsOpensearchDomainTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for vpc_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainVpcOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("availability_zones")]
    // Computed attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> AvailabilityZones => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "availability_zones");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SubnetIds { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>("", "vpc_id");

}

/// <summary>
/// Manages a aws_opensearch_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsOpensearchDomain : TerraformResource
{
    public AwsOpensearchDomain(string name) : base("aws_opensearch_domain", name)
    {
    }

    /// <summary>
    /// The access_policies attribute.
    /// </summary>
    [TerraformPropertyName("access_policies")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AccessPolicies { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "access_policies");

    /// <summary>
    /// The advanced_options attribute.
    /// </summary>
    [TerraformPropertyName("advanced_options")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> AdvancedOptions { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "advanced_options");

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DomainName { get; set; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EngineVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_version");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("ip_address_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IpAddressType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_address_type");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

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
    /// Block for advanced_security_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedSecurityOptions block(s) allowed")]
    [TerraformPropertyName("advanced_security_options")]
    public TerraformList<TerraformBlock<AwsOpensearchDomainAdvancedSecurityOptionsBlock>>? AdvancedSecurityOptions { get; set; } = new();

    /// <summary>
    /// Block for aiml_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AimlOptions block(s) allowed")]
    [TerraformPropertyName("aiml_options")]
    public TerraformList<TerraformBlock<AwsOpensearchDomainAimlOptionsBlock>>? AimlOptions { get; set; } = new();

    /// <summary>
    /// Block for auto_tune_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoTuneOptions block(s) allowed")]
    [TerraformPropertyName("auto_tune_options")]
    public TerraformList<TerraformBlock<AwsOpensearchDomainAutoTuneOptionsBlock>>? AutoTuneOptions { get; set; } = new();

    /// <summary>
    /// Block for cluster_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterConfig block(s) allowed")]
    [TerraformPropertyName("cluster_config")]
    public TerraformList<TerraformBlock<AwsOpensearchDomainClusterConfigBlock>>? ClusterConfig { get; set; } = new();

    /// <summary>
    /// Block for cognito_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CognitoOptions block(s) allowed")]
    [TerraformPropertyName("cognito_options")]
    public TerraformList<TerraformBlock<AwsOpensearchDomainCognitoOptionsBlock>>? CognitoOptions { get; set; } = new();

    /// <summary>
    /// Block for domain_endpoint_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DomainEndpointOptions block(s) allowed")]
    [TerraformPropertyName("domain_endpoint_options")]
    public TerraformList<TerraformBlock<AwsOpensearchDomainDomainEndpointOptionsBlock>>? DomainEndpointOptions { get; set; } = new();

    /// <summary>
    /// Block for ebs_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EbsOptions block(s) allowed")]
    [TerraformPropertyName("ebs_options")]
    public TerraformList<TerraformBlock<AwsOpensearchDomainEbsOptionsBlock>>? EbsOptions { get; set; } = new();

    /// <summary>
    /// Block for encrypt_at_rest.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptAtRest block(s) allowed")]
    [TerraformPropertyName("encrypt_at_rest")]
    public TerraformList<TerraformBlock<AwsOpensearchDomainEncryptAtRestBlock>>? EncryptAtRest { get; set; } = new();

    /// <summary>
    /// Block for log_publishing_options.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("log_publishing_options")]
    public TerraformSet<TerraformBlock<AwsOpensearchDomainLogPublishingOptionsBlock>>? LogPublishingOptions { get; set; } = new();

    /// <summary>
    /// Block for node_to_node_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeToNodeEncryption block(s) allowed")]
    [TerraformPropertyName("node_to_node_encryption")]
    public TerraformList<TerraformBlock<AwsOpensearchDomainNodeToNodeEncryptionBlock>>? NodeToNodeEncryption { get; set; } = new();

    /// <summary>
    /// Block for off_peak_window_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OffPeakWindowOptions block(s) allowed")]
    [TerraformPropertyName("off_peak_window_options")]
    public TerraformList<TerraformBlock<AwsOpensearchDomainOffPeakWindowOptionsBlock>>? OffPeakWindowOptions { get; set; } = new();

    /// <summary>
    /// Block for snapshot_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapshotOptions block(s) allowed")]
    [TerraformPropertyName("snapshot_options")]
    public TerraformList<TerraformBlock<AwsOpensearchDomainSnapshotOptionsBlock>>? SnapshotOptions { get; set; } = new();

    /// <summary>
    /// Block for software_update_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftwareUpdateOptions block(s) allowed")]
    [TerraformPropertyName("software_update_options")]
    public TerraformList<TerraformBlock<AwsOpensearchDomainSoftwareUpdateOptionsBlock>>? SoftwareUpdateOptions { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsOpensearchDomainTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for vpc_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcOptions block(s) allowed")]
    [TerraformPropertyName("vpc_options")]
    public TerraformList<TerraformBlock<AwsOpensearchDomainVpcOptionsBlock>>? VpcOptions { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The dashboard_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("dashboard_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DashboardEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dashboard_endpoint");

    /// <summary>
    /// The dashboard_endpoint_v2 attribute.
    /// </summary>
    [TerraformPropertyName("dashboard_endpoint_v2")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DashboardEndpointV2 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dashboard_endpoint_v2");

    /// <summary>
    /// The domain_endpoint_v2_hosted_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("domain_endpoint_v2_hosted_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DomainEndpointV2HostedZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain_endpoint_v2_hosted_zone_id");

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    [TerraformPropertyName("domain_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DomainId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain_id");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The endpoint_v2 attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_v2")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EndpointV2 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint_v2");

}
