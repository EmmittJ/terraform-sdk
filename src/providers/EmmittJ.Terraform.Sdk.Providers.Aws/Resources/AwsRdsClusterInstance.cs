using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsRdsClusterInstanceTimeoutsBlock : TerraformBlockBase
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
/// Manages a aws_rds_cluster_instance resource.
/// </summary>
public partial class AwsRdsClusterInstance : TerraformResource
{
    public AwsRdsClusterInstance(string name) : base("aws_rds_cluster_instance", name)
    {
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    [TerraformProperty("apply_immediately")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> ApplyImmediately { get; set; }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformProperty("auto_minor_version_upgrade")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoMinorVersionUpgrade { get; set; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AvailabilityZone { get; set; }

    /// <summary>
    /// The ca_cert_identifier attribute.
    /// </summary>
    [TerraformProperty("ca_cert_identifier")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CaCertIdentifier { get; set; }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    [TerraformProperty("cluster_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterIdentifier { get; set; }

    /// <summary>
    /// The copy_tags_to_snapshot attribute.
    /// </summary>
    [TerraformProperty("copy_tags_to_snapshot")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CopyTagsToSnapshot { get; set; }

    /// <summary>
    /// The custom_iam_instance_profile attribute.
    /// </summary>
    [TerraformProperty("custom_iam_instance_profile")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CustomIamInstanceProfile { get; set; }

    /// <summary>
    /// The db_parameter_group_name attribute.
    /// </summary>
    [TerraformProperty("db_parameter_group_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DbParameterGroupName { get; set; }

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    [TerraformProperty("db_subnet_group_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DbSubnetGroupName { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    [TerraformProperty("engine")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Engine { get; set; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> EngineVersion { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformProperty("force_destroy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [TerraformProperty("identifier")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Identifier { get; set; }

    /// <summary>
    /// The identifier_prefix attribute.
    /// </summary>
    [TerraformProperty("identifier_prefix")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> IdentifierPrefix { get; set; }

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceClass is required")]
    [TerraformProperty("instance_class")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceClass { get; set; }

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    [TerraformProperty("monitoring_interval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MonitoringInterval { get; set; }

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    [TerraformProperty("monitoring_role_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MonitoringRoleArn { get; set; }

    /// <summary>
    /// The performance_insights_enabled attribute.
    /// </summary>
    [TerraformProperty("performance_insights_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> PerformanceInsightsEnabled { get; set; }

    /// <summary>
    /// The performance_insights_kms_key_id attribute.
    /// </summary>
    [TerraformProperty("performance_insights_kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PerformanceInsightsKmsKeyId { get; set; }

    /// <summary>
    /// The performance_insights_retention_period attribute.
    /// </summary>
    [TerraformProperty("performance_insights_retention_period")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> PerformanceInsightsRetentionPeriod { get; set; }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    [TerraformProperty("preferred_backup_window")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PreferredBackupWindow { get; set; }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    [TerraformProperty("preferred_maintenance_window")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PreferredMaintenanceWindow { get; set; }

    /// <summary>
    /// The promotion_tier attribute.
    /// </summary>
    [TerraformProperty("promotion_tier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? PromotionTier { get; set; }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformProperty("publicly_accessible")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> PubliclyAccessible { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsRdsClusterInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The dbi_resource_id attribute.
    /// </summary>
    [TerraformProperty("dbi_resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DbiResourceId { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The engine_version_actual attribute.
    /// </summary>
    [TerraformProperty("engine_version_actual")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EngineVersionActual { get; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KmsKeyId { get; }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    [TerraformProperty("network_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NetworkType { get; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Port { get; }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    [TerraformProperty("storage_encrypted")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> StorageEncrypted { get; }

    /// <summary>
    /// The writer attribute.
    /// </summary>
    [TerraformProperty("writer")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Writer { get; }

}
