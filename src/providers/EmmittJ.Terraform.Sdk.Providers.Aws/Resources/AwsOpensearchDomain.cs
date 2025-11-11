using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for advanced_security_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsOpensearchDomainAdvancedSecurityOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The anonymous_auth_enabled attribute.
    /// </summary>
    [TerraformProperty("anonymous_auth_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> AnonymousAuthEnabled { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The internal_user_database_enabled attribute.
    /// </summary>
    [TerraformProperty("internal_user_database_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? InternalUserDatabaseEnabled { get; set; }

}

/// <summary>
/// Block type for aiml_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsOpensearchDomainAimlOptionsBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for auto_tune_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsOpensearchDomainAutoTuneOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The desired_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DesiredState is required")]
    [TerraformProperty("desired_state")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DesiredState { get; set; }

    /// <summary>
    /// The rollback_on_disable attribute.
    /// </summary>
    [TerraformProperty("rollback_on_disable")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RollbackOnDisable { get; set; }

    /// <summary>
    /// The use_off_peak_window attribute.
    /// </summary>
    [TerraformProperty("use_off_peak_window")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UseOffPeakWindow { get; set; }

}

/// <summary>
/// Block type for cluster_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsOpensearchDomainClusterConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The dedicated_master_count attribute.
    /// </summary>
    [TerraformProperty("dedicated_master_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DedicatedMasterCount { get; set; }

    /// <summary>
    /// The dedicated_master_enabled attribute.
    /// </summary>
    [TerraformProperty("dedicated_master_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DedicatedMasterEnabled { get; set; }

    /// <summary>
    /// The dedicated_master_type attribute.
    /// </summary>
    [TerraformProperty("dedicated_master_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DedicatedMasterType { get; set; }

    /// <summary>
    /// The instance_count attribute.
    /// </summary>
    [TerraformProperty("instance_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? InstanceCount { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [TerraformProperty("instance_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InstanceType { get; set; }

    /// <summary>
    /// The multi_az_with_standby_enabled attribute.
    /// </summary>
    [TerraformProperty("multi_az_with_standby_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MultiAzWithStandbyEnabled { get; set; }

    /// <summary>
    /// The warm_count attribute.
    /// </summary>
    [TerraformProperty("warm_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? WarmCount { get; set; }

    /// <summary>
    /// The warm_enabled attribute.
    /// </summary>
    [TerraformProperty("warm_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? WarmEnabled { get; set; }

    /// <summary>
    /// The warm_type attribute.
    /// </summary>
    [TerraformProperty("warm_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WarmType { get; set; }

    /// <summary>
    /// The zone_awareness_enabled attribute.
    /// </summary>
    [TerraformProperty("zone_awareness_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ZoneAwarenessEnabled { get; set; }

}

/// <summary>
/// Block type for cognito_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsOpensearchDomainCognitoOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The identity_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityPoolId is required")]
    [TerraformProperty("identity_pool_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IdentityPoolId { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformProperty("user_pool_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> UserPoolId { get; set; }

}

/// <summary>
/// Block type for domain_endpoint_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsOpensearchDomainDomainEndpointOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The custom_endpoint attribute.
    /// </summary>
    [TerraformProperty("custom_endpoint")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomEndpoint { get; set; }

    /// <summary>
    /// The custom_endpoint_certificate_arn attribute.
    /// </summary>
    [TerraformProperty("custom_endpoint_certificate_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomEndpointCertificateArn { get; set; }

    /// <summary>
    /// The custom_endpoint_enabled attribute.
    /// </summary>
    [TerraformProperty("custom_endpoint_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CustomEndpointEnabled { get; set; }

    /// <summary>
    /// The enforce_https attribute.
    /// </summary>
    [TerraformProperty("enforce_https")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnforceHttps { get; set; }

    /// <summary>
    /// The tls_security_policy attribute.
    /// </summary>
    [TerraformProperty("tls_security_policy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TlsSecurityPolicy { get; set; }

}

/// <summary>
/// Block type for ebs_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsOpensearchDomainEbsOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The ebs_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EbsEnabled is required")]
    [TerraformProperty("ebs_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> EbsEnabled { get; set; }

    /// <summary>
    /// The iops attribute.
    /// </summary>
    [TerraformProperty("iops")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Iops { get; set; }

    /// <summary>
    /// The throughput attribute.
    /// </summary>
    [TerraformProperty("throughput")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Throughput { get; set; }

    /// <summary>
    /// The volume_size attribute.
    /// </summary>
    [TerraformProperty("volume_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? VolumeSize { get; set; }

    /// <summary>
    /// The volume_type attribute.
    /// </summary>
    [TerraformProperty("volume_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> VolumeType { get; set; }

}

/// <summary>
/// Block type for encrypt_at_rest in .
/// Nesting mode: list
/// </summary>
public partial class AwsOpensearchDomainEncryptAtRestBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsKeyId { get; set; }

}

/// <summary>
/// Block type for log_publishing_options in .
/// Nesting mode: set
/// </summary>
public partial class AwsOpensearchDomainLogPublishingOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The cloudwatch_log_group_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudwatchLogGroupArn is required")]
    [TerraformProperty("cloudwatch_log_group_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CloudwatchLogGroupArn { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The log_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogType is required")]
    [TerraformProperty("log_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LogType { get; set; }

}

/// <summary>
/// Block type for node_to_node_encryption in .
/// Nesting mode: list
/// </summary>
public partial class AwsOpensearchDomainNodeToNodeEncryptionBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for off_peak_window_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsOpensearchDomainOffPeakWindowOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for snapshot_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsOpensearchDomainSnapshotOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The automated_snapshot_start_hour attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomatedSnapshotStartHour is required")]
    [TerraformProperty("automated_snapshot_start_hour")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> AutomatedSnapshotStartHour { get; set; }

}

/// <summary>
/// Block type for software_update_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsOpensearchDomainSoftwareUpdateOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The auto_software_update_enabled attribute.
    /// </summary>
    [TerraformProperty("auto_software_update_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> AutoSoftwareUpdateEnabled { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsOpensearchDomainTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for vpc_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsOpensearchDomainVpcOptionsBlock : TerraformBlockBase
{

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SubnetIds { get; set; }


}

/// <summary>
/// Manages a aws_opensearch_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsOpensearchDomain : TerraformResource
{
    public AwsOpensearchDomain(string name) : base("aws_opensearch_domain", name)
    {
    }

    /// <summary>
    /// The access_policies attribute.
    /// </summary>
    [TerraformProperty("access_policies")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AccessPolicies { get; set; }

    /// <summary>
    /// The advanced_options attribute.
    /// </summary>
    [TerraformProperty("advanced_options")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> AdvancedOptions { get; set; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EngineVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformProperty("ip_address_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> IpAddressType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

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
    /// Block for advanced_security_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedSecurityOptions block(s) allowed")]
    [TerraformProperty("advanced_security_options")]
    public partial TerraformList<TerraformBlock<AwsOpensearchDomainAdvancedSecurityOptionsBlock>>? AdvancedSecurityOptions { get; set; }

    /// <summary>
    /// Block for aiml_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AimlOptions block(s) allowed")]
    [TerraformProperty("aiml_options")]
    public partial TerraformList<TerraformBlock<AwsOpensearchDomainAimlOptionsBlock>>? AimlOptions { get; set; }

    /// <summary>
    /// Block for auto_tune_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoTuneOptions block(s) allowed")]
    [TerraformProperty("auto_tune_options")]
    public partial TerraformList<TerraformBlock<AwsOpensearchDomainAutoTuneOptionsBlock>>? AutoTuneOptions { get; set; }

    /// <summary>
    /// Block for cluster_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClusterConfig block(s) allowed")]
    [TerraformProperty("cluster_config")]
    public partial TerraformList<TerraformBlock<AwsOpensearchDomainClusterConfigBlock>>? ClusterConfig { get; set; }

    /// <summary>
    /// Block for cognito_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CognitoOptions block(s) allowed")]
    [TerraformProperty("cognito_options")]
    public partial TerraformList<TerraformBlock<AwsOpensearchDomainCognitoOptionsBlock>>? CognitoOptions { get; set; }

    /// <summary>
    /// Block for domain_endpoint_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DomainEndpointOptions block(s) allowed")]
    [TerraformProperty("domain_endpoint_options")]
    public partial TerraformList<TerraformBlock<AwsOpensearchDomainDomainEndpointOptionsBlock>>? DomainEndpointOptions { get; set; }

    /// <summary>
    /// Block for ebs_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EbsOptions block(s) allowed")]
    [TerraformProperty("ebs_options")]
    public partial TerraformList<TerraformBlock<AwsOpensearchDomainEbsOptionsBlock>>? EbsOptions { get; set; }

    /// <summary>
    /// Block for encrypt_at_rest.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptAtRest block(s) allowed")]
    [TerraformProperty("encrypt_at_rest")]
    public partial TerraformList<TerraformBlock<AwsOpensearchDomainEncryptAtRestBlock>>? EncryptAtRest { get; set; }

    /// <summary>
    /// Block for log_publishing_options.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("log_publishing_options")]
    public partial TerraformSet<TerraformBlock<AwsOpensearchDomainLogPublishingOptionsBlock>>? LogPublishingOptions { get; set; }

    /// <summary>
    /// Block for node_to_node_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NodeToNodeEncryption block(s) allowed")]
    [TerraformProperty("node_to_node_encryption")]
    public partial TerraformList<TerraformBlock<AwsOpensearchDomainNodeToNodeEncryptionBlock>>? NodeToNodeEncryption { get; set; }

    /// <summary>
    /// Block for off_peak_window_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OffPeakWindowOptions block(s) allowed")]
    [TerraformProperty("off_peak_window_options")]
    public partial TerraformList<TerraformBlock<AwsOpensearchDomainOffPeakWindowOptionsBlock>>? OffPeakWindowOptions { get; set; }

    /// <summary>
    /// Block for snapshot_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SnapshotOptions block(s) allowed")]
    [TerraformProperty("snapshot_options")]
    public partial TerraformList<TerraformBlock<AwsOpensearchDomainSnapshotOptionsBlock>>? SnapshotOptions { get; set; }

    /// <summary>
    /// Block for software_update_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftwareUpdateOptions block(s) allowed")]
    [TerraformProperty("software_update_options")]
    public partial TerraformList<TerraformBlock<AwsOpensearchDomainSoftwareUpdateOptionsBlock>>? SoftwareUpdateOptions { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsOpensearchDomainTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for vpc_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcOptions block(s) allowed")]
    [TerraformProperty("vpc_options")]
    public partial TerraformList<TerraformBlock<AwsOpensearchDomainVpcOptionsBlock>>? VpcOptions { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The dashboard_endpoint attribute.
    /// </summary>
    [TerraformProperty("dashboard_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DashboardEndpoint { get; }

    /// <summary>
    /// The dashboard_endpoint_v2 attribute.
    /// </summary>
    [TerraformProperty("dashboard_endpoint_v2")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DashboardEndpointV2 { get; }

    /// <summary>
    /// The domain_endpoint_v2_hosted_zone_id attribute.
    /// </summary>
    [TerraformProperty("domain_endpoint_v2_hosted_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DomainEndpointV2HostedZoneId { get; }

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    [TerraformProperty("domain_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DomainId { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The endpoint_v2 attribute.
    /// </summary>
    [TerraformProperty("endpoint_v2")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EndpointV2 { get; }

}
