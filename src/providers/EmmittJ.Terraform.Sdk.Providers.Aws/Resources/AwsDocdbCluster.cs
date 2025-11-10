using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for restore_to_point_in_time in .
/// Nesting mode: list
/// </summary>
public class AwsDocdbClusterRestoreToPointInTimeBlock : ITerraformBlock
{
    /// <summary>
    /// The restore_to_time attribute.
    /// </summary>
    [TerraformPropertyName("restore_to_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RestoreToTime { get; set; }

    /// <summary>
    /// The restore_type attribute.
    /// </summary>
    [TerraformPropertyName("restore_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RestoreType { get; set; }

    /// <summary>
    /// The source_cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceClusterIdentifier is required")]
    [TerraformPropertyName("source_cluster_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SourceClusterIdentifier { get; set; }

    /// <summary>
    /// The use_latest_restorable_time attribute.
    /// </summary>
    [TerraformPropertyName("use_latest_restorable_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseLatestRestorableTime { get; set; }

}

/// <summary>
/// Block type for serverless_v2_scaling_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsDocdbClusterServerlessV2ScalingConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxCapacity is required")]
    [TerraformPropertyName("max_capacity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxCapacity { get; set; }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    [TerraformPropertyName("min_capacity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MinCapacity { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDocdbClusterTimeoutsBlock : ITerraformBlock
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
/// Manages a aws_docdb_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDocdbCluster : TerraformResource
{
    public AwsDocdbCluster(string name) : base("aws_docdb_cluster", name)
    {
    }

    /// <summary>
    /// The allow_major_version_upgrade attribute.
    /// </summary>
    [TerraformPropertyName("allow_major_version_upgrade")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowMajorVersionUpgrade { get; set; }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    [TerraformPropertyName("apply_immediately")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ApplyImmediately { get; set; }

    /// <summary>
    /// The availability_zones attribute.
    /// </summary>
    [TerraformPropertyName("availability_zones")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> AvailabilityZones { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "availability_zones");

    /// <summary>
    /// The backup_retention_period attribute.
    /// </summary>
    [TerraformPropertyName("backup_retention_period")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BackupRetentionPeriod { get; set; }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [TerraformPropertyName("cluster_identifier")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClusterIdentifier { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_identifier");

    /// <summary>
    /// The cluster_identifier_prefix attribute.
    /// </summary>
    [TerraformPropertyName("cluster_identifier_prefix")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ClusterIdentifierPrefix { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_identifier_prefix");

    /// <summary>
    /// The cluster_members attribute.
    /// </summary>
    [TerraformPropertyName("cluster_members")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> ClusterMembers { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "cluster_members");

    /// <summary>
    /// The db_cluster_parameter_group_name attribute.
    /// </summary>
    [TerraformPropertyName("db_cluster_parameter_group_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DbClusterParameterGroupName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_cluster_parameter_group_name");

    /// <summary>
    /// The db_subnet_group_name attribute.
    /// </summary>
    [TerraformPropertyName("db_subnet_group_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DbSubnetGroupName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "db_subnet_group_name");

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeletionProtection { get; set; }

    /// <summary>
    /// The enabled_cloudwatch_logs_exports attribute.
    /// </summary>
    [TerraformPropertyName("enabled_cloudwatch_logs_exports")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? EnabledCloudwatchLogsExports { get; set; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Engine { get; set; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> EngineVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_version");

    /// <summary>
    /// The final_snapshot_identifier attribute.
    /// </summary>
    [TerraformPropertyName("final_snapshot_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FinalSnapshotIdentifier { get; set; }

    /// <summary>
    /// The global_cluster_identifier attribute.
    /// </summary>
    [TerraformPropertyName("global_cluster_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GlobalClusterIdentifier { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_id");

    /// <summary>
    /// The manage_master_user_password attribute.
    /// </summary>
    [TerraformPropertyName("manage_master_user_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ManageMasterUserPassword { get; set; }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    [TerraformPropertyName("master_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MasterPassword { get; set; }

    /// <summary>
    /// The master_password_wo attribute.
    /// </summary>
    [TerraformPropertyName("master_password_wo")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MasterPasswordWo { get; set; }

    /// <summary>
    /// The master_password_wo_version attribute.
    /// </summary>
    [TerraformPropertyName("master_password_wo_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MasterPasswordWoVersion { get; set; }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    [TerraformPropertyName("master_username")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> MasterUsername { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "master_username");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    [TerraformPropertyName("skip_final_snapshot")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SkipFinalSnapshot { get; set; }

    /// <summary>
    /// The snapshot_identifier attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SnapshotIdentifier { get; set; }

    /// <summary>
    /// The storage_encrypted attribute.
    /// </summary>
    [TerraformPropertyName("storage_encrypted")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? StorageEncrypted { get; set; }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StorageType { get; set; }

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
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_group_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> VpcSecurityGroupIds { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "vpc_security_group_ids");

    /// <summary>
    /// Block for restore_to_point_in_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RestoreToPointInTime block(s) allowed")]
    [TerraformPropertyName("restore_to_point_in_time")]
    public TerraformList<TerraformBlock<AwsDocdbClusterRestoreToPointInTimeBlock>>? RestoreToPointInTime { get; set; } = new();

    /// <summary>
    /// Block for serverless_v2_scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerlessV2ScalingConfiguration block(s) allowed")]
    [TerraformPropertyName("serverless_v2_scaling_configuration")]
    public TerraformList<TerraformBlock<AwsDocdbClusterServerlessV2ScalingConfigurationBlock>>? ServerlessV2ScalingConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDocdbClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The cluster_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("cluster_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClusterResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "cluster_resource_id");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("hosted_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostedZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hosted_zone_id");

    /// <summary>
    /// The master_user_secret attribute.
    /// </summary>
    [TerraformPropertyName("master_user_secret")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MasterUserSecret => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "master_user_secret");

    /// <summary>
    /// The reader_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("reader_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ReaderEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "reader_endpoint");

}
