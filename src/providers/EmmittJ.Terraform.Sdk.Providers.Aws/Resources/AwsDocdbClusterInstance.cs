using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDocdbClusterInstanceTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a aws_docdb_cluster_instance resource.
/// </summary>
public partial class AwsDocdbClusterInstance : TerraformResource
{
    public AwsDocdbClusterInstance(string name) : base("aws_docdb_cluster_instance", name)
    {
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    [TerraformProperty("apply_immediately")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ApplyImmediately { get; set; }

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
    /// The enable_performance_insights attribute.
    /// </summary>
    [TerraformProperty("enable_performance_insights")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnablePerformanceInsights { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformProperty("engine")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Engine { get; set; }

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
    /// The performance_insights_kms_key_id attribute.
    /// </summary>
    [TerraformProperty("performance_insights_kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PerformanceInsightsKmsKeyId { get; set; }

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
    public AwsDocdbClusterInstanceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    [TerraformProperty("db_subnet_group_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DbSubnetGroupName { get; }

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
    /// The engine_version attribute.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EngineVersion { get; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KmsKeyId { get; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Port { get; }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    [TerraformProperty("preferred_backup_window")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PreferredBackupWindow { get; }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformProperty("publicly_accessible")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> PubliclyAccessible { get; }

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
