using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lightsail_database resource.
/// </summary>
public partial class AwsLightsailDatabase : TerraformResource
{
    public AwsLightsailDatabase(string name) : base("aws_lightsail_database", name)
    {
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    [TerraformProperty("apply_immediately")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> ApplyImmediately { get; set; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AvailabilityZone { get; set; }

    /// <summary>
    /// The backup_retention_enabled attribute.
    /// </summary>
    [TerraformProperty("backup_retention_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? BackupRetentionEnabled { get; set; }

    /// <summary>
    /// The blueprint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlueprintId is required")]
    [TerraformProperty("blueprint_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BlueprintId { get; set; }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BundleId is required")]
    [TerraformProperty("bundle_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> BundleId { get; set; }

    /// <summary>
    /// The final_snapshot_name attribute.
    /// </summary>
    [TerraformProperty("final_snapshot_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? FinalSnapshotName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The master_database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MasterDatabaseName is required")]
    [TerraformProperty("master_database_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MasterDatabaseName { get; set; }

    /// <summary>
    /// The master_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MasterPassword is required")]
    [TerraformProperty("master_password")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MasterPassword { get; set; }

    /// <summary>
    /// The master_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MasterUsername is required")]
    [TerraformProperty("master_username")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MasterUsername { get; set; }

    /// <summary>
    /// The preferred_backup_window attribute.
    /// </summary>
    [TerraformProperty("preferred_backup_window")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PreferredBackupWindow { get; set; }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    [TerraformProperty("preferred_maintenance_window")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PreferredMaintenanceWindow { get; set; }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformProperty("publicly_accessible")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? PubliclyAccessible { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The relational_database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelationalDatabaseName is required")]
    [TerraformProperty("relational_database_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RelationalDatabaseName { get; set; }

    /// <summary>
    /// The skip_final_snapshot attribute.
    /// </summary>
    [TerraformProperty("skip_final_snapshot")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SkipFinalSnapshot { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The ca_certificate_identifier attribute.
    /// </summary>
    [TerraformProperty("ca_certificate_identifier")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CaCertificateIdentifier { get; }

    /// <summary>
    /// The cpu_count attribute.
    /// </summary>
    [TerraformProperty("cpu_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> CpuCount { get; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The disk_size attribute.
    /// </summary>
    [TerraformProperty("disk_size")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DiskSize { get; }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    [TerraformProperty("engine")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Engine { get; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EngineVersion { get; }

    /// <summary>
    /// The master_endpoint_address attribute.
    /// </summary>
    [TerraformProperty("master_endpoint_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MasterEndpointAddress { get; }

    /// <summary>
    /// The master_endpoint_port attribute.
    /// </summary>
    [TerraformProperty("master_endpoint_port")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> MasterEndpointPort { get; }

    /// <summary>
    /// The ram_size attribute.
    /// </summary>
    [TerraformProperty("ram_size")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> RamSize { get; }

    /// <summary>
    /// The secondary_availability_zone attribute.
    /// </summary>
    [TerraformProperty("secondary_availability_zone")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecondaryAvailabilityZone { get; }

    /// <summary>
    /// The support_code attribute.
    /// </summary>
    [TerraformProperty("support_code")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SupportCode { get; }

}
