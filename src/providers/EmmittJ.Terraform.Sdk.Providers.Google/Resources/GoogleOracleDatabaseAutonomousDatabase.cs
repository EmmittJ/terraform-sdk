using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for properties in .
/// Nesting mode: list
/// </summary>
public partial class GoogleOracleDatabaseAutonomousDatabasePropertiesBlock : TerraformBlockBase
{






    /// <summary>
    /// The retention period for the Autonomous Database. This field is specified
    /// in days, can range from 1 day to 60 days, and has a default value of
    /// 60 days.
    /// </summary>
    [TerraformProperty("backup_retention_period_days")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> BackupRetentionPeriodDays { get; set; }

    /// <summary>
    /// The character set for the Autonomous Database. The default is AL32UTF8.
    /// </summary>
    [TerraformProperty("character_set")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CharacterSet { get; set; }

    /// <summary>
    /// The number of compute servers for the Autonomous Database.
    /// </summary>
    [TerraformProperty("compute_count")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> ComputeCount { get; set; }




    /// <summary>
    /// The size of the data stored in the database, in gigabytes.
    /// </summary>
    [TerraformProperty("data_storage_size_gb")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> DataStorageSizeGb { get; set; }

    /// <summary>
    /// The size of the data stored in the database, in terabytes.
    /// </summary>
    [TerraformProperty("data_storage_size_tb")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> DataStorageSizeTb { get; set; }


    /// <summary>
    /// The edition of the Autonomous Databases. 
    ///  Possible values:
    ///  DATABASE_EDITION_UNSPECIFIED
    /// STANDARD_EDITION
    /// ENTERPRISE_EDITION
    /// </summary>
    [TerraformProperty("db_edition")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DbEdition { get; set; }

    /// <summary>
    /// The Oracle Database version for the Autonomous Database.
    /// </summary>
    [TerraformProperty("db_version")]
    // Optional argument - source generator will implement get/set
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
    [TerraformProperty("db_workload")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DbWorkload { get; set; }


    /// <summary>
    /// This field indicates if auto scaling is enabled for the Autonomous Database
    /// CPU core count.
    /// </summary>
    [TerraformProperty("is_auto_scaling_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IsAutoScalingEnabled { get; set; }


    /// <summary>
    /// This field indicates if auto scaling is enabled for the Autonomous Database
    /// storage.
    /// </summary>
    [TerraformProperty("is_storage_auto_scaling_enabled")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> IsStorageAutoScalingEnabled { get; set; }

    /// <summary>
    /// The license type used for the Autonomous Database. 
    ///  Possible values:
    ///  LICENSE_TYPE_UNSPECIFIED
    /// LICENSE_INCLUDED
    /// BRING_YOUR_OWN_LICENSE
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseType is required")]
    [TerraformProperty("license_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LicenseType { get; set; }







    /// <summary>
    /// The maintenance schedule of the Autonomous Database. 
    ///  Possible values:
    ///  MAINTENANCE_SCHEDULE_TYPE_UNSPECIFIED
    /// EARLY
    /// REGULAR
    /// </summary>
    [TerraformProperty("maintenance_schedule_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> MaintenanceScheduleType { get; set; }



    /// <summary>
    /// This field specifies if the Autonomous Database requires mTLS connections.
    /// </summary>
    [TerraformProperty("mtls_connection_required")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? MtlsConnectionRequired { get; set; }

    /// <summary>
    /// The national character set for the Autonomous Database. The default is
    /// AL16UTF16.
    /// </summary>
    [TerraformProperty("n_character_set")]
    // Optional argument - source generator will implement get/set
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
    [TerraformProperty("operations_insights_state")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> OperationsInsightsState { get; set; }




    /// <summary>
    /// The private endpoint IP address for the Autonomous Database.
    /// </summary>
    [TerraformProperty("private_endpoint_ip")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PrivateEndpointIp { get; set; }

    /// <summary>
    /// The private endpoint label for the Autonomous Database.
    /// </summary>
    [TerraformProperty("private_endpoint_label")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PrivateEndpointLabel { get; set; }










}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleOracleDatabaseAutonomousDatabaseTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_oracle_database_autonomous_database resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleOracleDatabaseAutonomousDatabase : TerraformResource
{
    public GoogleOracleDatabaseAutonomousDatabase(string name) : base("google_oracle_database_autonomous_database", name)
    {
    }

    /// <summary>
    /// The password for the default ADMIN user.
    /// </summary>
    [TerraformProperty("admin_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AdminPassword { get; set; }

    /// <summary>
    /// The ID of the Autonomous Database to create. This value is restricted
    /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
    /// characters in length. The value must start with a letter and end with
    /// a letter or a number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutonomousDatabaseId is required")]
    [TerraformProperty("autonomous_database_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AutonomousDatabaseId { get; set; }

    /// <summary>
    /// The subnet CIDR range for the Autonmous Database.
    /// </summary>
    [TerraformProperty("cidr")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Cidr { get; set; }

    /// <summary>
    /// The name of the Autonomous Database. The database name must be unique in
    /// the project. The name must begin with a letter and can
    /// contain a maximum of 30 alphanumeric characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    [TerraformProperty("database")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Database { get; set; }

    /// <summary>
    /// Whether or not to allow Terraform to destroy the instance. Unless this field is set to false in Terraform state, a terraform destroy or terraform apply that would delete the instance will fail.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DeletionProtection { get; set; }

    /// <summary>
    /// The display name for the Autonomous Database. The name does not have to
    /// be unique within your project.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The labels or tags associated with the Autonomous Database. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. See documentation for resource type &#39;oracledatabase.googleapis.com/AutonomousDatabaseBackup&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name of the VPC network used by the Autonomous Database.
    /// Format: projects/{project}/global/networks/{network}
    /// </summary>
    [TerraformProperty("network")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Network { get; set; }

    /// <summary>
    /// The name of the OdbNetwork associated with the Autonomous Database.
    /// Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}
    /// It is optional but if specified, this should match the parent ODBNetwork of
    /// the odb_subnet and backup_odb_subnet.
    /// </summary>
    [TerraformProperty("odb_network")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> OdbNetwork { get; set; }

    /// <summary>
    /// The name of the OdbSubnet associated with the Autonomous Database for
    /// IP allocation. Format:
    /// projects/{project}/locations/{location}/odbNetworks/{odb_network}/odbSubnets/{odb_subnet}
    /// </summary>
    [TerraformProperty("odb_subnet")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> OdbSubnet { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Properties is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Properties block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    [TerraformProperty("properties")]
    public TerraformList<TerraformBlock<GoogleOracleDatabaseAutonomousDatabasePropertiesBlock>>? Properties { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleOracleDatabaseAutonomousDatabaseTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The date and time that the Autonomous Database was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// The ID of the subscription entitlement associated with the Autonomous
    /// Database.
    /// </summary>
    [TerraformProperty("entitlement_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EntitlementId { get; }

    /// <summary>
    /// Identifier. The name of the Autonomous Database resource in the following format:
    /// projects/{project}/locations/{region}/autonomousDatabases/{autonomous_database}
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TerraformLabels { get; }

}
