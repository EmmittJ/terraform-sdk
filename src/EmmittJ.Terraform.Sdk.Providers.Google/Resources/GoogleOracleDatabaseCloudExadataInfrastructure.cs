using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for properties in .
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseCloudExadataInfrastructurePropertiesBlock : TerraformBlock
{
    /// <summary>
    /// The requested number of additional storage servers activated for the
    /// Exadata Infrastructure.
    /// </summary>
    public TerraformProperty<double>? ActivatedStorageCount
    {
        get => GetProperty<TerraformProperty<double>>("activated_storage_count");
        set => WithProperty("activated_storage_count", value);
    }

    /// <summary>
    /// The requested number of additional storage servers for the Exadata
    /// Infrastructure.
    /// </summary>
    public TerraformProperty<double>? AdditionalStorageCount
    {
        get => GetProperty<TerraformProperty<double>>("additional_storage_count");
        set => WithProperty("additional_storage_count", value);
    }

    /// <summary>
    /// The available storage can be allocated to the Exadata Infrastructure
    /// resource, in gigabytes (GB).
    /// </summary>
    public TerraformProperty<double>? AvailableStorageSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("available_storage_size_gb");
        set => WithProperty("available_storage_size_gb", value);
    }

    /// <summary>
    /// The number of compute servers for the Exadata Infrastructure.
    /// </summary>
    public TerraformProperty<double>? ComputeCount
    {
        get => GetProperty<TerraformProperty<double>>("compute_count");
        set => WithProperty("compute_count", value);
    }

    /// <summary>
    /// The number of enabled CPU cores.
    /// </summary>
    public TerraformProperty<double>? CpuCount
    {
        get => GetProperty<TerraformProperty<double>>("cpu_count");
        set => WithProperty("cpu_count", value);
    }

    /// <summary>
    /// Size, in terabytes, of the DATA disk group.
    /// </summary>
    public TerraformProperty<double>? DataStorageSizeTb
    {
        get => GetProperty<TerraformProperty<double>>("data_storage_size_tb");
        set => WithProperty("data_storage_size_tb", value);
    }

    /// <summary>
    /// The local node storage allocated in GBs.
    /// </summary>
    public TerraformProperty<double>? DbNodeStorageSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("db_node_storage_size_gb");
        set => WithProperty("db_node_storage_size_gb", value);
    }

    /// <summary>
    /// The software version of the database servers (dom0) in the Exadata
    /// Infrastructure.
    /// </summary>
    public TerraformProperty<string>? DbServerVersion
    {
        get => GetProperty<TerraformProperty<string>>("db_server_version");
        set => WithProperty("db_server_version", value);
    }

    /// <summary>
    /// The total number of CPU cores available.
    /// </summary>
    public TerraformProperty<double>? MaxCpuCount
    {
        get => GetProperty<TerraformProperty<double>>("max_cpu_count");
        set => WithProperty("max_cpu_count", value);
    }

    /// <summary>
    /// The total available DATA disk group size.
    /// </summary>
    public TerraformProperty<double>? MaxDataStorageTb
    {
        get => GetProperty<TerraformProperty<double>>("max_data_storage_tb");
        set => WithProperty("max_data_storage_tb", value);
    }

    /// <summary>
    /// The total local node storage available in GBs.
    /// </summary>
    public TerraformProperty<double>? MaxDbNodeStorageSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("max_db_node_storage_size_gb");
        set => WithProperty("max_db_node_storage_size_gb", value);
    }

    /// <summary>
    /// The total memory available in GBs.
    /// </summary>
    public TerraformProperty<double>? MaxMemoryGb
    {
        get => GetProperty<TerraformProperty<double>>("max_memory_gb");
        set => WithProperty("max_memory_gb", value);
    }

    /// <summary>
    /// The memory allocated in GBs.
    /// </summary>
    public TerraformProperty<double>? MemorySizeGb
    {
        get => GetProperty<TerraformProperty<double>>("memory_size_gb");
        set => WithProperty("memory_size_gb", value);
    }

    /// <summary>
    /// The monthly software version of the database servers (dom0)
    /// in the Exadata Infrastructure. Example: 20.1.15
    /// </summary>
    public TerraformProperty<string>? MonthlyDbServerVersion
    {
        get => GetProperty<TerraformProperty<string>>("monthly_db_server_version");
        set => WithProperty("monthly_db_server_version", value);
    }

    /// <summary>
    /// The monthly software version of the storage servers (cells)
    /// in the Exadata Infrastructure. Example: 20.1.15
    /// </summary>
    public TerraformProperty<string>? MonthlyStorageServerVersion
    {
        get => GetProperty<TerraformProperty<string>>("monthly_storage_server_version");
        set => WithProperty("monthly_storage_server_version", value);
    }

    /// <summary>
    /// The OCID of the next maintenance run.
    /// </summary>
    public TerraformProperty<string>? NextMaintenanceRunId
    {
        get => GetProperty<TerraformProperty<string>>("next_maintenance_run_id");
        set => WithProperty("next_maintenance_run_id", value);
    }

    /// <summary>
    /// The time when the next maintenance run will occur.
    /// </summary>
    public TerraformProperty<string>? NextMaintenanceRunTime
    {
        get => GetProperty<TerraformProperty<string>>("next_maintenance_run_time");
        set => WithProperty("next_maintenance_run_time", value);
    }

    /// <summary>
    /// The time when the next security maintenance run will occur.
    /// </summary>
    public TerraformProperty<string>? NextSecurityMaintenanceRunTime
    {
        get => GetProperty<TerraformProperty<string>>("next_security_maintenance_run_time");
        set => WithProperty("next_security_maintenance_run_time", value);
    }

    /// <summary>
    /// Deep link to the OCI console to view this resource.
    /// </summary>
    public TerraformProperty<string>? OciUrl
    {
        get => GetProperty<TerraformProperty<string>>("oci_url");
        set => WithProperty("oci_url", value);
    }

    /// <summary>
    /// OCID of created infra.
    /// https://docs.oracle.com/en-us/iaas/Content/General/Concepts/identifiers.htm#Oracle
    /// </summary>
    public TerraformProperty<string>? Ocid
    {
        get => GetProperty<TerraformProperty<string>>("ocid");
        set => WithProperty("ocid", value);
    }

    /// <summary>
    /// The shape of the Exadata Infrastructure. The shape determines the
    /// amount of CPU, storage, and memory resources allocated to the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Shape is required")]
    public required TerraformProperty<string> Shape
    {
        get => GetProperty<TerraformProperty<string>>("shape");
        set => WithProperty("shape", value);
    }

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
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => WithProperty("state", value);
    }

    /// <summary>
    /// The number of Cloud Exadata storage servers for the Exadata Infrastructure.
    /// </summary>
    public TerraformProperty<double>? StorageCount
    {
        get => GetProperty<TerraformProperty<double>>("storage_count");
        set => WithProperty("storage_count", value);
    }

    /// <summary>
    /// The software version of the storage servers (cells) in the Exadata
    /// Infrastructure.
    /// </summary>
    public TerraformProperty<string>? StorageServerVersion
    {
        get => GetProperty<TerraformProperty<string>>("storage_server_version");
        set => WithProperty("storage_server_version", value);
    }

    /// <summary>
    /// The total storage allocated to the Exadata Infrastructure
    /// resource, in gigabytes (GB).
    /// </summary>
    public TerraformProperty<double>? TotalStorageSizeGb
    {
        get => GetProperty<TerraformProperty<double>>("total_storage_size_gb");
        set => WithProperty("total_storage_size_gb", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleOracleDatabaseCloudExadataInfrastructureTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_oracle_database_cloud_exadata_infrastructure resource.
/// </summary>
public class GoogleOracleDatabaseCloudExadataInfrastructure : TerraformResource
{
    public GoogleOracleDatabaseCloudExadataInfrastructure(string name) : base("google_oracle_database_cloud_exadata_infrastructure", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("entitlement_id");
        this.DeclareOutput("name");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// The ID of the Exadata Infrastructure to create. This value is restricted
    /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
    /// characters in length. The value must start with a letter and end with
    /// a letter or a number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    public required TerraformProperty<string> CloudExadataInfrastructureId
    {
        get => GetProperty<TerraformProperty<string>>("cloud_exadata_infrastructure_id");
        set => this.WithProperty("cloud_exadata_infrastructure_id", value);
    }

    /// <summary>
    /// Whether or not to allow Terraform to destroy the instance. Unless this field is set to false in Terraform state, a terraform destroy or terraform apply that would delete the instance will fail.
    /// </summary>
    public TerraformProperty<bool>? DeletionProtection
    {
        get => GetProperty<TerraformProperty<bool>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
    }

    /// <summary>
    /// User friendly name for this resource.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// GCP location where Oracle Exadata is hosted.
    /// </summary>
    public TerraformProperty<string>? GcpOracleZone
    {
        get => GetProperty<TerraformProperty<string>>("gcp_oracle_zone");
        set => this.WithProperty("gcp_oracle_zone", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Labels or tags associated with the resource. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. See documentation for resource type &#39;oracledatabase.googleapis.com/DbServer&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    public List<GoogleOracleDatabaseCloudExadataInfrastructurePropertiesBlock>? Properties
    {
        get => GetProperty<List<GoogleOracleDatabaseCloudExadataInfrastructurePropertiesBlock>>("properties");
        set => this.WithProperty("properties", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleOracleDatabaseCloudExadataInfrastructureTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleOracleDatabaseCloudExadataInfrastructureTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The date and time that the Exadata Infrastructure was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Entitlement ID of the private offer against which this infrastructure
    /// resource is provisioned.
    /// </summary>
    public TerraformExpression EntitlementId => this["entitlement_id"];

    /// <summary>
    /// Identifier. The name of the Exadata Infrastructure resource with the following format:
    /// projects/{project}/locations/{region}/cloudExadataInfrastructures/{cloud_exadata_infrastructure}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
