using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRdsClusterInstanceTimeoutsBlock : ITerraformBlock
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
/// Manages a aws_rds_cluster_instance resource.
/// </summary>
public class AwsRdsClusterInstance : TerraformResource
{
    public AwsRdsClusterInstance(string name) : base("aws_rds_cluster_instance", name)
    {
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    [TerraformPropertyName("apply_immediately")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ApplyImmediately { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "apply_immediately");

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformPropertyName("auto_minor_version_upgrade")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutoMinorVersionUpgrade { get; set; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone");

    /// <summary>
    /// The ca_cert_identifier attribute.
    /// </summary>
    [TerraformPropertyName("ca_cert_identifier")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CaCertIdentifier { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ca_cert_identifier");

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    [TerraformPropertyName("cluster_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterIdentifier { get; set; }

    /// <summary>
    /// The copy_tags_to_snapshot attribute.
    /// </summary>
    [TerraformPropertyName("copy_tags_to_snapshot")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CopyTagsToSnapshot { get; set; }

    /// <summary>
    /// The custom_iam_instance_profile attribute.
    /// </summary>
    [TerraformPropertyName("custom_iam_instance_profile")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CustomIamInstanceProfile { get; set; }

    /// <summary>
    /// The db_parameter_group_name attribute.
    /// </summary>
    [TerraformPropertyName("db_parameter_group_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DbParameterGroupName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_parameter_group_name");

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    [TerraformPropertyName("db_subnet_group_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DbSubnetGroupName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_subnet_group_name");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Engine is required")]
    [TerraformPropertyName("engine")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Engine { get; set; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EngineVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_version");

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformPropertyName("force_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    [TerraformPropertyName("identifier")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Identifier { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "identifier");

    /// <summary>
    /// The identifier_prefix attribute.
    /// </summary>
    [TerraformPropertyName("identifier_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IdentifierPrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "identifier_prefix");

    /// <summary>
    /// The instance_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceClass is required")]
    [TerraformPropertyName("instance_class")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceClass { get; set; }

    /// <summary>
    /// The monitoring_interval attribute.
    /// </summary>
    [TerraformPropertyName("monitoring_interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MonitoringInterval { get; set; }

    /// <summary>
    /// The monitoring_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("monitoring_role_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MonitoringRoleArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "monitoring_role_arn");

    /// <summary>
    /// The performance_insights_enabled attribute.
    /// </summary>
    [TerraformPropertyName("performance_insights_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> PerformanceInsightsEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "performance_insights_enabled");

    /// <summary>
    /// The performance_insights_kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("performance_insights_kms_key_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PerformanceInsightsKmsKeyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "performance_insights_kms_key_id");

    /// <summary>
    /// The performance_insights_retention_period attribute.
    /// </summary>
    [TerraformPropertyName("performance_insights_retention_period")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> PerformanceInsightsRetentionPeriod { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "performance_insights_retention_period");

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    [TerraformPropertyName("preferred_backup_window")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PreferredBackupWindow { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preferred_backup_window");

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("preferred_maintenance_window")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PreferredMaintenanceWindow { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preferred_maintenance_window");

    /// <summary>
    /// The promotion_tier attribute.
    /// </summary>
    [TerraformPropertyName("promotion_tier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? PromotionTier { get; set; }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformPropertyName("publicly_accessible")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> PubliclyAccessible { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "publicly_accessible");

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsRdsClusterInstanceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The dbi_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("dbi_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DbiResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dbi_resource_id");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The engine_version_actual attribute.
    /// </summary>
    [TerraformPropertyName("engine_version_actual")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EngineVersionActual => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_version_actual");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_id");

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    [TerraformPropertyName("network_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_type");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Port => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "port");

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    [TerraformPropertyName("storage_encrypted")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> StorageEncrypted => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "storage_encrypted");

    /// <summary>
    /// The writer attribute.
    /// </summary>
    [TerraformPropertyName("writer")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Writer => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "writer");

}
