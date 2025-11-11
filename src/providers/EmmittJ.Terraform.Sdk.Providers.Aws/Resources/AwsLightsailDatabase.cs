using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lightsail_database resource.
/// </summary>
public class AwsLightsailDatabase : TerraformResource
{
    public AwsLightsailDatabase(string name) : base("aws_lightsail_database", name)
    {
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    [TerraformPropertyName("apply_immediately")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> ApplyImmediately { get; set; } = default!;

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AvailabilityZone { get; set; } = default!;

    /// <summary>
    /// The backup_retention_enabled attribute.
    /// </summary>
    [TerraformPropertyName("backup_retention_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? BackupRetentionEnabled { get; set; }

    /// <summary>
    /// The blueprint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlueprintId is required")]
    [TerraformPropertyName("blueprint_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BlueprintId { get; set; }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BundleId is required")]
    [TerraformPropertyName("bundle_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BundleId { get; set; }

    /// <summary>
    /// The final_snapshot_name attribute.
    /// </summary>
    [TerraformPropertyName("final_snapshot_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FinalSnapshotName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The master_database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MasterDatabaseName is required")]
    [TerraformPropertyName("master_database_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MasterDatabaseName { get; set; }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MasterPassword is required")]
    [TerraformPropertyName("master_password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MasterPassword { get; set; }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MasterUsername is required")]
    [TerraformPropertyName("master_username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MasterUsername { get; set; }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    [TerraformPropertyName("preferred_backup_window")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PreferredBackupWindow { get; set; } = default!;

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("preferred_maintenance_window")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PreferredMaintenanceWindow { get; set; } = default!;

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformPropertyName("publicly_accessible")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PubliclyAccessible { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The relational_database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelationalDatabaseName is required")]
    [TerraformPropertyName("relational_database_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RelationalDatabaseName { get; set; }

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    [TerraformPropertyName("skip_final_snapshot")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SkipFinalSnapshot { get; set; }

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
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The ca_certificate_identifier attribute.
    /// </summary>
    [TerraformPropertyName("ca_certificate_identifier")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CaCertificateIdentifier => new TerraformReference(this, "ca_certificate_identifier");

    /// <summary>
    /// The cpu_count attribute.
    /// </summary>
    [TerraformPropertyName("cpu_count")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> CpuCount => new TerraformReference(this, "cpu_count");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedAt => new TerraformReference(this, "created_at");

    /// <summary>
    /// The disk_size attribute.
    /// </summary>
    [TerraformPropertyName("disk_size")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DiskSize => new TerraformReference(this, "disk_size");

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformPropertyName("engine")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Engine => new TerraformReference(this, "engine");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EngineVersion => new TerraformReference(this, "engine_version");

    /// <summary>
    /// The master_endpoint_address attribute.
    /// </summary>
    [TerraformPropertyName("master_endpoint_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MasterEndpointAddress => new TerraformReference(this, "master_endpoint_address");

    /// <summary>
    /// The master_endpoint_port attribute.
    /// </summary>
    [TerraformPropertyName("master_endpoint_port")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MasterEndpointPort => new TerraformReference(this, "master_endpoint_port");

    /// <summary>
    /// The ram_size attribute.
    /// </summary>
    [TerraformPropertyName("ram_size")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> RamSize => new TerraformReference(this, "ram_size");

    /// <summary>
    /// The secondary_availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("secondary_availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SecondaryAvailabilityZone => new TerraformReference(this, "secondary_availability_zone");

    /// <summary>
    /// The support_code attribute.
    /// </summary>
    [TerraformPropertyName("support_code")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SupportCode => new TerraformReference(this, "support_code");

}
