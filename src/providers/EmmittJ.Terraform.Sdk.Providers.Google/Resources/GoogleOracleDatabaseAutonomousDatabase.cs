using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for properties in .
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseAutonomousDatabasePropertiesBlock
{






    /// <summary>
    /// The retention period for the Autonomous Database. This field is specified
    /// in days, can range from 1 day to 60 days, and has a default value of
    /// 60 days.
    /// </summary>
    [TerraformPropertyName("backup_retention_period_days")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> BackupRetentionPeriodDays { get; set; } = default!;

    /// <summary>
    /// The character set for the Autonomous Database. The default is AL32UTF8.
    /// </summary>
    [TerraformPropertyName("character_set")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CharacterSet { get; set; }

    /// <summary>
    /// The number of compute servers for the Autonomous Database.
    /// </summary>
    [TerraformPropertyName("compute_count")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> ComputeCount { get; set; } = default!;




    /// <summary>
    /// The size of the data stored in the database, in gigabytes.
    /// </summary>
    [TerraformPropertyName("data_storage_size_gb")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DataStorageSizeGb { get; set; } = default!;

    /// <summary>
    /// The size of the data stored in the database, in terabytes.
    /// </summary>
    [TerraformPropertyName("data_storage_size_tb")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> DataStorageSizeTb { get; set; } = default!;


    /// <summary>
    /// The edition of the Autonomous Databases. 
    ///  Possible values:
    ///  DATABASE_EDITION_UNSPECIFIED
    /// STANDARD_EDITION
    /// ENTERPRISE_EDITION
    /// </summary>
    [TerraformPropertyName("db_edition")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DbEdition { get; set; }

    /// <summary>
    /// The Oracle Database version for the Autonomous Database.
    /// </summary>
    [TerraformPropertyName("db_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DbVersion { get; set; }

    /// <summary>
    /// Possible values:
    ///  DB_WORKLOAD_UNSPECIFIED
    /// OLTP
    /// DW
    /// AJD
    /// APEX
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbWorkload is required")]
    [TerraformPropertyName("db_workload")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DbWorkload { get; set; }


    /// <summary>
    /// This field indicates if auto scaling is enabled for the Autonomous Database
    /// CPU core count.
    /// </summary>
    [TerraformPropertyName("is_auto_scaling_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IsAutoScalingEnabled { get; set; }


    /// <summary>
    /// This field indicates if auto scaling is enabled for the Autonomous Database
    /// storage.
    /// </summary>
    [TerraformPropertyName("is_storage_auto_scaling_enabled")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> IsStorageAutoScalingEnabled { get; set; } = default!;

    /// <summary>
    /// The license type used for the Autonomous Database. 
    ///  Possible values:
    ///  LICENSE_TYPE_UNSPECIFIED
    /// LICENSE_INCLUDED
    /// BRING_YOUR_OWN_LICENSE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseType is required")]
    [TerraformPropertyName("license_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LicenseType { get; set; }







    /// <summary>
    /// The maintenance schedule of the Autonomous Database. 
    ///  Possible values:
    ///  MAINTENANCE_SCHEDULE_TYPE_UNSPECIFIED
    /// EARLY
    /// REGULAR
    /// </summary>
    [TerraformPropertyName("maintenance_schedule_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MaintenanceScheduleType { get; set; } = default!;



    /// <summary>
    /// This field specifies if the Autonomous Database requires mTLS connections.
    /// </summary>
    [TerraformPropertyName("mtls_connection_required")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MtlsConnectionRequired { get; set; }

    /// <summary>
    /// The national character set for the Autonomous Database. The default is
    /// AL16UTF16.
    /// </summary>
    [TerraformPropertyName("n_character_set")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NCharacterSet { get; set; }





    /// <summary>
    /// Possible values:
    ///  OPERATIONS_INSIGHTS_STATE_UNSPECIFIED
    /// ENABLING
    /// ENABLED
    /// DISABLING
    /// NOT_ENABLED
    /// FAILED_ENABLING
    /// FAILED_DISABLING
    /// </summary>
    [TerraformPropertyName("operations_insights_state")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OperationsInsightsState { get; set; } = default!;




    /// <summary>
    /// The private endpoint IP address for the Autonomous Database.
    /// </summary>
    [TerraformPropertyName("private_endpoint_ip")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PrivateEndpointIp { get; set; } = default!;

    /// <summary>
    /// The private endpoint label for the Autonomous Database.
    /// </summary>
    [TerraformPropertyName("private_endpoint_label")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PrivateEndpointLabel { get; set; } = default!;










}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleOracleDatabaseAutonomousDatabaseTimeoutsBlock
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
/// Manages a google_oracle_database_autonomous_database resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleOracleDatabaseAutonomousDatabase : TerraformResource
{
    public GoogleOracleDatabaseAutonomousDatabase(string name) : base("google_oracle_database_autonomous_database", name)
    {
    }

    /// <summary>
    /// The password for the default ADMIN user.
    /// </summary>
    [TerraformPropertyName("admin_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AdminPassword { get; set; }

    /// <summary>
    /// The ID of the Autonomous Database to create. This value is restricted
    /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
    /// characters in length. The value must start with a letter and end with
    /// a letter or a number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutonomousDatabaseId is required")]
    [TerraformPropertyName("autonomous_database_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AutonomousDatabaseId { get; set; }

    /// <summary>
    /// The subnet CIDR range for the Autonmous Database.
    /// </summary>
    [TerraformPropertyName("cidr")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Cidr { get; set; }

    /// <summary>
    /// The name of the Autonomous Database. The database name must be unique in
    /// the project. The name must begin with a letter and can
    /// contain a maximum of 30 alphanumeric characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    [TerraformPropertyName("database")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Database { get; set; }

    /// <summary>
    /// Whether or not to allow Terraform to destroy the instance. Unless this field is set to false in Terraform state, a terraform destroy or terraform apply that would delete the instance will fail.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// The display name for the Autonomous Database. The name does not have to
    /// be unique within your project.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DisplayName { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The labels or tags associated with the Autonomous Database. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. See documentation for resource type &#39;oracledatabase.googleapis.com/AutonomousDatabaseBackup&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name of the VPC network used by the Autonomous Database.
    /// Format: projects/{project}/global/networks/{network}
    /// </summary>
    [TerraformPropertyName("network")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Network { get; set; }

    /// <summary>
    /// The name of the OdbNetwork associated with the Autonomous Database.
    /// Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}
    /// It is optional but if specified, this should match the parent ODBNetwork of
    /// the odb_subnet and backup_odb_subnet.
    /// </summary>
    [TerraformPropertyName("odb_network")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OdbNetwork { get; set; } = default!;

    /// <summary>
    /// The name of the OdbSubnet associated with the Autonomous Database for
    /// IP allocation. Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    [TerraformPropertyName("odb_subnet")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OdbSubnet { get; set; } = default!;

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Block for properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Properties is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Properties block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    [TerraformPropertyName("properties")]
    public TerraformList<TerraformBlock<GoogleOracleDatabaseAutonomousDatabasePropertiesBlock>>? Properties { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleOracleDatabaseAutonomousDatabaseTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The date and time that the Autonomous Database was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// The ID of the subscription entitlement associated with the Autonomous
    /// Database.
    /// </summary>
    [TerraformPropertyName("entitlement_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EntitlementId => new TerraformReference(this, "entitlement_id");

    /// <summary>
    /// Identifier. The name of the Autonomous Database resource in the following format:
    /// projects/{project}/locations/{region}/autonomousDatabases/{autonomous_database}
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

}
