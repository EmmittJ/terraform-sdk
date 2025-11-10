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
        set => SetProperty("activated_storage_count", value);
    }

    /// <summary>
    /// The requested number of additional storage servers for the Exadata
    /// Infrastructure.
    /// </summary>
    public TerraformProperty<double>? AdditionalStorageCount
    {
        set => SetProperty("additional_storage_count", value);
    }

    /// <summary>
    /// The available storage can be allocated to the Exadata Infrastructure
    /// resource, in gigabytes (GB).
    /// </summary>
    public TerraformProperty<double>? AvailableStorageSizeGb
    {
        set => SetProperty("available_storage_size_gb", value);
    }

    /// <summary>
    /// The number of compute servers for the Exadata Infrastructure.
    /// </summary>
    public TerraformProperty<double>? ComputeCount
    {
        set => SetProperty("compute_count", value);
    }

    /// <summary>
    /// The number of enabled CPU cores.
    /// </summary>
    public TerraformProperty<double>? CpuCount
    {
        set => SetProperty("cpu_count", value);
    }

    /// <summary>
    /// Size, in terabytes, of the DATA disk group.
    /// </summary>
    public TerraformProperty<double>? DataStorageSizeTb
    {
        set => SetProperty("data_storage_size_tb", value);
    }

    /// <summary>
    /// The local node storage allocated in GBs.
    /// </summary>
    public TerraformProperty<double>? DbNodeStorageSizeGb
    {
        set => SetProperty("db_node_storage_size_gb", value);
    }

    /// <summary>
    /// The software version of the database servers (dom0) in the Exadata
    /// Infrastructure.
    /// </summary>
    public TerraformProperty<string>? DbServerVersion
    {
        set => SetProperty("db_server_version", value);
    }

    /// <summary>
    /// The total number of CPU cores available.
    /// </summary>
    public TerraformProperty<double>? MaxCpuCount
    {
        set => SetProperty("max_cpu_count", value);
    }

    /// <summary>
    /// The total available DATA disk group size.
    /// </summary>
    public TerraformProperty<double>? MaxDataStorageTb
    {
        set => SetProperty("max_data_storage_tb", value);
    }

    /// <summary>
    /// The total local node storage available in GBs.
    /// </summary>
    public TerraformProperty<double>? MaxDbNodeStorageSizeGb
    {
        set => SetProperty("max_db_node_storage_size_gb", value);
    }

    /// <summary>
    /// The total memory available in GBs.
    /// </summary>
    public TerraformProperty<double>? MaxMemoryGb
    {
        set => SetProperty("max_memory_gb", value);
    }

    /// <summary>
    /// The memory allocated in GBs.
    /// </summary>
    public TerraformProperty<double>? MemorySizeGb
    {
        set => SetProperty("memory_size_gb", value);
    }

    /// <summary>
    /// The monthly software version of the database servers (dom0)
    /// in the Exadata Infrastructure. Example: 20.1.15
    /// </summary>
    public TerraformProperty<string>? MonthlyDbServerVersion
    {
        set => SetProperty("monthly_db_server_version", value);
    }

    /// <summary>
    /// The monthly software version of the storage servers (cells)
    /// in the Exadata Infrastructure. Example: 20.1.15
    /// </summary>
    public TerraformProperty<string>? MonthlyStorageServerVersion
    {
        set => SetProperty("monthly_storage_server_version", value);
    }

    /// <summary>
    /// The OCID of the next maintenance run.
    /// </summary>
    public TerraformProperty<string>? NextMaintenanceRunId
    {
        set => SetProperty("next_maintenance_run_id", value);
    }

    /// <summary>
    /// The time when the next maintenance run will occur.
    /// </summary>
    public TerraformProperty<string>? NextMaintenanceRunTime
    {
        set => SetProperty("next_maintenance_run_time", value);
    }

    /// <summary>
    /// The time when the next security maintenance run will occur.
    /// </summary>
    public TerraformProperty<string>? NextSecurityMaintenanceRunTime
    {
        set => SetProperty("next_security_maintenance_run_time", value);
    }

    /// <summary>
    /// Deep link to the OCI console to view this resource.
    /// </summary>
    public TerraformProperty<string>? OciUrl
    {
        set => SetProperty("oci_url", value);
    }

    /// <summary>
    /// OCID of created infra.
    /// https://docs.oracle.com/en-us/iaas/Content/General/Concepts/identifiers.htm#Oracle
    /// </summary>
    public TerraformProperty<string>? Ocid
    {
        set => SetProperty("ocid", value);
    }

    /// <summary>
    /// The shape of the Exadata Infrastructure. The shape determines the
    /// amount of CPU, storage, and memory resources allocated to the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Shape is required")]
    public required TerraformProperty<string> Shape
    {
        set => SetProperty("shape", value);
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
        set => SetProperty("state", value);
    }

    /// <summary>
    /// The number of Cloud Exadata storage servers for the Exadata Infrastructure.
    /// </summary>
    public TerraformProperty<double>? StorageCount
    {
        set => SetProperty("storage_count", value);
    }

    /// <summary>
    /// The software version of the storage servers (cells) in the Exadata
    /// Infrastructure.
    /// </summary>
    public TerraformProperty<string>? StorageServerVersion
    {
        set => SetProperty("storage_server_version", value);
    }

    /// <summary>
    /// The total storage allocated to the Exadata Infrastructure
    /// resource, in gigabytes (GB).
    /// </summary>
    public TerraformProperty<double>? TotalStorageSizeGb
    {
        set => SetProperty("total_storage_size_gb", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_oracle_database_cloud_exadata_infrastructure resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleOracleDatabaseCloudExadataInfrastructure : TerraformResource
{
    public GoogleOracleDatabaseCloudExadataInfrastructure(string name) : base("google_oracle_database_cloud_exadata_infrastructure", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("entitlement_id");
        SetOutput("name");
        SetOutput("terraform_labels");
        SetOutput("cloud_exadata_infrastructure_id");
        SetOutput("deletion_protection");
        SetOutput("display_name");
        SetOutput("gcp_oracle_zone");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("project");
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
        get => GetRequiredOutput<TerraformProperty<string>>("cloud_exadata_infrastructure_id");
        set => SetProperty("cloud_exadata_infrastructure_id", value);
    }

    /// <summary>
    /// Whether or not to allow Terraform to destroy the instance. Unless this field is set to false in Terraform state, a terraform destroy or terraform apply that would delete the instance will fail.
    /// </summary>
    public TerraformProperty<bool> DeletionProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("deletion_protection");
        set => SetProperty("deletion_protection", value);
    }

    /// <summary>
    /// User friendly name for this resource.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// GCP location where Oracle Exadata is hosted.
    /// </summary>
    public TerraformProperty<string> GcpOracleZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gcp_oracle_zone");
        set => SetProperty("gcp_oracle_zone", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Labels or tags associated with the resource. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. See documentation for resource type &#39;oracledatabase.googleapis.com/DbServer&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    public List<GoogleOracleDatabaseCloudExadataInfrastructurePropertiesBlock>? Properties
    {
        set => SetProperty("properties", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleOracleDatabaseCloudExadataInfrastructureTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
