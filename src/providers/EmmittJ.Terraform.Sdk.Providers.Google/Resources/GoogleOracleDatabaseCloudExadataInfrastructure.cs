using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for properties in .
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseCloudExadataInfrastructurePropertiesBlock : ITerraformBlock
{
    /// <summary>
    /// The requested number of additional storage servers activated for the
    /// Exadata Infrastructure.
    /// </summary>
    [TerraformPropertyName("activated_storage_count")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ActivatedStorageCount => new TerraformReferenceProperty<TerraformProperty<double>>("", "activated_storage_count");

    /// <summary>
    /// The requested number of additional storage servers for the Exadata
    /// Infrastructure.
    /// </summary>
    [TerraformPropertyName("additional_storage_count")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AdditionalStorageCount => new TerraformReferenceProperty<TerraformProperty<double>>("", "additional_storage_count");

    /// <summary>
    /// The available storage can be allocated to the Exadata Infrastructure
    /// resource, in gigabytes (GB).
    /// </summary>
    [TerraformPropertyName("available_storage_size_gb")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AvailableStorageSizeGb => new TerraformReferenceProperty<TerraformProperty<double>>("", "available_storage_size_gb");

    /// <summary>
    /// The number of compute servers for the Exadata Infrastructure.
    /// </summary>
    [TerraformPropertyName("compute_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ComputeCount { get; set; }

    /// <summary>
    /// The number of enabled CPU cores.
    /// </summary>
    [TerraformPropertyName("cpu_count")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> CpuCount => new TerraformReferenceProperty<TerraformProperty<double>>("", "cpu_count");

    /// <summary>
    /// Size, in terabytes, of the DATA disk group.
    /// </summary>
    [TerraformPropertyName("data_storage_size_tb")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DataStorageSizeTb => new TerraformReferenceProperty<TerraformProperty<double>>("", "data_storage_size_tb");

    /// <summary>
    /// The local node storage allocated in GBs.
    /// </summary>
    [TerraformPropertyName("db_node_storage_size_gb")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DbNodeStorageSizeGb => new TerraformReferenceProperty<TerraformProperty<double>>("", "db_node_storage_size_gb");

    /// <summary>
    /// The software version of the database servers (dom0) in the Exadata
    /// Infrastructure.
    /// </summary>
    [TerraformPropertyName("db_server_version")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DbServerVersion => new TerraformReferenceProperty<TerraformProperty<string>>("", "db_server_version");

    /// <summary>
    /// The total number of CPU cores available.
    /// </summary>
    [TerraformPropertyName("max_cpu_count")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxCpuCount => new TerraformReferenceProperty<TerraformProperty<double>>("", "max_cpu_count");

    /// <summary>
    /// The total available DATA disk group size.
    /// </summary>
    [TerraformPropertyName("max_data_storage_tb")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxDataStorageTb => new TerraformReferenceProperty<TerraformProperty<double>>("", "max_data_storage_tb");

    /// <summary>
    /// The total local node storage available in GBs.
    /// </summary>
    [TerraformPropertyName("max_db_node_storage_size_gb")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxDbNodeStorageSizeGb => new TerraformReferenceProperty<TerraformProperty<double>>("", "max_db_node_storage_size_gb");

    /// <summary>
    /// The total memory available in GBs.
    /// </summary>
    [TerraformPropertyName("max_memory_gb")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxMemoryGb => new TerraformReferenceProperty<TerraformProperty<double>>("", "max_memory_gb");

    /// <summary>
    /// The memory allocated in GBs.
    /// </summary>
    [TerraformPropertyName("memory_size_gb")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MemorySizeGb => new TerraformReferenceProperty<TerraformProperty<double>>("", "memory_size_gb");

    /// <summary>
    /// The monthly software version of the database servers (dom0)
    /// in the Exadata Infrastructure. Example: 20.1.15
    /// </summary>
    [TerraformPropertyName("monthly_db_server_version")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MonthlyDbServerVersion => new TerraformReferenceProperty<TerraformProperty<string>>("", "monthly_db_server_version");

    /// <summary>
    /// The monthly software version of the storage servers (cells)
    /// in the Exadata Infrastructure. Example: 20.1.15
    /// </summary>
    [TerraformPropertyName("monthly_storage_server_version")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MonthlyStorageServerVersion => new TerraformReferenceProperty<TerraformProperty<string>>("", "monthly_storage_server_version");

    /// <summary>
    /// The OCID of the next maintenance run.
    /// </summary>
    [TerraformPropertyName("next_maintenance_run_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NextMaintenanceRunId => new TerraformReferenceProperty<TerraformProperty<string>>("", "next_maintenance_run_id");

    /// <summary>
    /// The time when the next maintenance run will occur.
    /// </summary>
    [TerraformPropertyName("next_maintenance_run_time")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NextMaintenanceRunTime => new TerraformReferenceProperty<TerraformProperty<string>>("", "next_maintenance_run_time");

    /// <summary>
    /// The time when the next security maintenance run will occur.
    /// </summary>
    [TerraformPropertyName("next_security_maintenance_run_time")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NextSecurityMaintenanceRunTime => new TerraformReferenceProperty<TerraformProperty<string>>("", "next_security_maintenance_run_time");

    /// <summary>
    /// Deep link to the OCI console to view this resource.
    /// </summary>
    [TerraformPropertyName("oci_url")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OciUrl => new TerraformReferenceProperty<TerraformProperty<string>>("", "oci_url");

    /// <summary>
    /// OCID of created infra.
    /// https://docs.oracle.com/en-us/iaas/Content/General/Concepts/identifiers.htm#Oracle
    /// </summary>
    [TerraformPropertyName("ocid")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Ocid => new TerraformReferenceProperty<TerraformProperty<string>>("", "ocid");

    /// <summary>
    /// The shape of the Exadata Infrastructure. The shape determines the
    /// amount of CPU, storage, and memory resources allocated to the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Shape is required")]
    [TerraformPropertyName("shape")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Shape { get; set; }

    /// <summary>
    /// The current lifecycle state of the Exadata Infrastructure. 
    ///  Possible values:
    ///  STATE_UNSPECIFIED
    /// PROVISIONING
    /// AVAILABLE
    /// UPDATING
    /// TERMINATING
    /// TERMINATED
    /// FAILED
    /// MAINTENANCE_IN_PROGRESS
    /// </summary>
    [TerraformPropertyName("state")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>("", "state");

    /// <summary>
    /// The number of Cloud Exadata storage servers for the Exadata Infrastructure.
    /// </summary>
    [TerraformPropertyName("storage_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? StorageCount { get; set; }

    /// <summary>
    /// The software version of the storage servers (cells) in the Exadata
    /// Infrastructure.
    /// </summary>
    [TerraformPropertyName("storage_server_version")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageServerVersion => new TerraformReferenceProperty<TerraformProperty<string>>("", "storage_server_version");

    /// <summary>
    /// The total storage allocated to the Exadata Infrastructure
    /// resource, in gigabytes (GB).
    /// </summary>
    [TerraformPropertyName("total_storage_size_gb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> TotalStorageSizeGb { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "total_storage_size_gb");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleOracleDatabaseCloudExadataInfrastructureTimeoutsBlock : ITerraformBlock
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
/// Manages a google_oracle_database_cloud_exadata_infrastructure resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleOracleDatabaseCloudExadataInfrastructure : TerraformResource
{
    public GoogleOracleDatabaseCloudExadataInfrastructure(string name) : base("google_oracle_database_cloud_exadata_infrastructure", name)
    {
    }

    /// <summary>
    /// The ID of the Exadata Infrastructure to create. This value is restricted
    /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
    /// characters in length. The value must start with a letter and end with
    /// a letter or a number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    [TerraformPropertyName("cloud_exadata_infrastructure_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CloudExadataInfrastructureId { get; set; }

    /// <summary>
    /// Whether or not to allow Terraform to destroy the instance. Unless this field is set to false in Terraform state, a terraform destroy or terraform apply that would delete the instance will fail.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeletionProtection { get; set; }

    /// <summary>
    /// User friendly name for this resource.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// GCP location where Oracle Exadata is hosted.
    /// </summary>
    [TerraformPropertyName("gcp_oracle_zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> GcpOracleZone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "gcp_oracle_zone");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Labels or tags associated with the resource. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. See documentation for resource type &#39;oracledatabase.googleapis.com/DbServer&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    [TerraformPropertyName("properties")]
    public TerraformList<TerraformBlock<GoogleOracleDatabaseCloudExadataInfrastructurePropertiesBlock>>? Properties { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleOracleDatabaseCloudExadataInfrastructureTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The date and time that the Exadata Infrastructure was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Entitlement ID of the private offer against which this infrastructure
    /// resource is provisioned.
    /// </summary>
    [TerraformPropertyName("entitlement_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EntitlementId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "entitlement_id");

    /// <summary>
    /// Identifier. The name of the Exadata Infrastructure resource with the following format:
    /// projects/{project}/locations/{region}/cloudExadataInfrastructures/{cloud_exadata_infrastructure}
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}
