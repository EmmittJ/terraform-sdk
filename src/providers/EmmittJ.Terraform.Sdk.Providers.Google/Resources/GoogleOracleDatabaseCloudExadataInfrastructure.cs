using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for properties in GoogleOracleDatabaseCloudExadataInfrastructure.
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseCloudExadataInfrastructurePropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "properties";

    /// <summary>
    /// The requested number of additional storage servers activated for the
    /// Exadata Infrastructure.
    /// </summary>
    public TerraformValue<double> ActivatedStorageCount
        => AsReference("activated_storage_count");

    /// <summary>
    /// The requested number of additional storage servers for the Exadata
    /// Infrastructure.
    /// </summary>
    public TerraformValue<double> AdditionalStorageCount
        => AsReference("additional_storage_count");

    /// <summary>
    /// The available storage can be allocated to the Exadata Infrastructure
    /// resource, in gigabytes (GB).
    /// </summary>
    public TerraformValue<double> AvailableStorageSizeGb
        => AsReference("available_storage_size_gb");

    /// <summary>
    /// The number of compute servers for the Exadata Infrastructure.
    /// </summary>
    public TerraformValue<double>? ComputeCount
    {
        get => GetArgument<TerraformValue<double>>("compute_count");
        set => SetArgument("compute_count", value);
    }

    /// <summary>
    /// The number of enabled CPU cores.
    /// </summary>
    public TerraformValue<double> CpuCount
        => AsReference("cpu_count");

    /// <summary>
    /// Size, in terabytes, of the DATA disk group.
    /// </summary>
    public TerraformValue<double> DataStorageSizeTb
        => AsReference("data_storage_size_tb");

    /// <summary>
    /// The local node storage allocated in GBs.
    /// </summary>
    public TerraformValue<double> DbNodeStorageSizeGb
        => AsReference("db_node_storage_size_gb");

    /// <summary>
    /// The software version of the database servers (dom0) in the Exadata
    /// Infrastructure.
    /// </summary>
    public TerraformValue<string> DbServerVersion
        => AsReference("db_server_version");

    /// <summary>
    /// The total number of CPU cores available.
    /// </summary>
    public TerraformValue<double> MaxCpuCount
        => AsReference("max_cpu_count");

    /// <summary>
    /// The total available DATA disk group size.
    /// </summary>
    public TerraformValue<double> MaxDataStorageTb
        => AsReference("max_data_storage_tb");

    /// <summary>
    /// The total local node storage available in GBs.
    /// </summary>
    public TerraformValue<double> MaxDbNodeStorageSizeGb
        => AsReference("max_db_node_storage_size_gb");

    /// <summary>
    /// The total memory available in GBs.
    /// </summary>
    public TerraformValue<double> MaxMemoryGb
        => AsReference("max_memory_gb");

    /// <summary>
    /// The memory allocated in GBs.
    /// </summary>
    public TerraformValue<double> MemorySizeGb
        => AsReference("memory_size_gb");

    /// <summary>
    /// The monthly software version of the database servers (dom0)
    /// in the Exadata Infrastructure. Example: 20.1.15
    /// </summary>
    public TerraformValue<string> MonthlyDbServerVersion
        => AsReference("monthly_db_server_version");

    /// <summary>
    /// The monthly software version of the storage servers (cells)
    /// in the Exadata Infrastructure. Example: 20.1.15
    /// </summary>
    public TerraformValue<string> MonthlyStorageServerVersion
        => AsReference("monthly_storage_server_version");

    /// <summary>
    /// The OCID of the next maintenance run.
    /// </summary>
    public TerraformValue<string> NextMaintenanceRunId
        => AsReference("next_maintenance_run_id");

    /// <summary>
    /// The time when the next maintenance run will occur.
    /// </summary>
    public TerraformValue<string> NextMaintenanceRunTime
        => AsReference("next_maintenance_run_time");

    /// <summary>
    /// The time when the next security maintenance run will occur.
    /// </summary>
    public TerraformValue<string> NextSecurityMaintenanceRunTime
        => AsReference("next_security_maintenance_run_time");

    /// <summary>
    /// Deep link to the OCI console to view this resource.
    /// </summary>
    public TerraformValue<string> OciUrl
        => AsReference("oci_url");

    /// <summary>
    /// OCID of created infra.
    /// https://docs.oracle.com/en-us/iaas/Content/General/Concepts/identifiers.htm#Oracle
    /// </summary>
    public TerraformValue<string> Ocid
        => AsReference("ocid");

    /// <summary>
    /// The shape of the Exadata Infrastructure. The shape determines the
    /// amount of CPU, storage, and memory resources allocated to the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Shape is required")]
    public required TerraformValue<string> Shape
    {
        get => GetRequiredArgument<TerraformValue<string>>("shape");
        set => SetArgument("shape", value);
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
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The number of Cloud Exadata storage servers for the Exadata Infrastructure.
    /// </summary>
    public TerraformValue<double>? StorageCount
    {
        get => GetArgument<TerraformValue<double>>("storage_count");
        set => SetArgument("storage_count", value);
    }

    /// <summary>
    /// The software version of the storage servers (cells) in the Exadata
    /// Infrastructure.
    /// </summary>
    public TerraformValue<string> StorageServerVersion
        => AsReference("storage_server_version");

    /// <summary>
    /// The total storage allocated to the Exadata Infrastructure
    /// resource, in gigabytes (GB).
    /// </summary>
    public TerraformValue<double> TotalStorageSizeGb
    {
        get => GetArgument<TerraformValue<double>>("total_storage_size_gb") ?? AsReference("total_storage_size_gb");
        set => SetArgument("total_storage_size_gb", value);
    }

    /// <summary>
    /// CustomerContacts block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleOracleDatabaseCloudExadataInfrastructurePropertiesBlockCustomerContactsBlock>? CustomerContacts
    {
        get => GetArgument<TerraformList<GoogleOracleDatabaseCloudExadataInfrastructurePropertiesBlockCustomerContactsBlock>>("customer_contacts");
        set => SetArgument("customer_contacts", value);
    }

    /// <summary>
    /// MaintenanceWindow block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    public TerraformList<GoogleOracleDatabaseCloudExadataInfrastructurePropertiesBlockMaintenanceWindowBlock>? MaintenanceWindow
    {
        get => GetArgument<TerraformList<GoogleOracleDatabaseCloudExadataInfrastructurePropertiesBlockMaintenanceWindowBlock>>("maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

}

/// <summary>
/// Block type for customer_contacts in GoogleOracleDatabaseCloudExadataInfrastructurePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseCloudExadataInfrastructurePropertiesBlockCustomerContactsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "customer_contacts";

    /// <summary>
    /// The email address used by Oracle to send notifications regarding databases
    /// and infrastructure.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformValue<string> Email
    {
        get => GetRequiredArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

}

/// <summary>
/// Block type for maintenance_window in GoogleOracleDatabaseCloudExadataInfrastructurePropertiesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleOracleDatabaseCloudExadataInfrastructurePropertiesBlockMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_window";

    /// <summary>
    /// Determines the amount of time the system will wait before the start of each
    /// database server patching operation. Custom action timeout is in minutes and
    /// valid value is between 15 to 120 (inclusive).
    /// </summary>
    public TerraformValue<double> CustomActionTimeoutMins
    {
        get => GetArgument<TerraformValue<double>>("custom_action_timeout_mins") ?? AsReference("custom_action_timeout_mins");
        set => SetArgument("custom_action_timeout_mins", value);
    }

    /// <summary>
    /// Days during the week when maintenance should be performed.
    /// </summary>
    public TerraformList<string> DaysOfWeek
    {
        get => GetArgument<TerraformList<string>>("days_of_week") ?? AsReference("days_of_week");
        set => SetArgument("days_of_week", value);
    }

    /// <summary>
    /// The window of hours during the day when maintenance should be performed.
    /// The window is a 4 hour slot. Valid values are:
    ///   0 - represents time slot 0:00 - 3:59 UTC
    ///   4 - represents time slot 4:00 - 7:59 UTC
    ///   8 - represents time slot 8:00 - 11:59 UTC
    ///   12 - represents time slot 12:00 - 15:59 UTC
    ///   16 - represents time slot 16:00 - 19:59 UTC
    ///   20 - represents time slot 20:00 - 23:59 UTC
    /// </summary>
    public TerraformList<double> HoursOfDay
    {
        get => GetArgument<TerraformList<double>>("hours_of_day") ?? AsReference("hours_of_day");
        set => SetArgument("hours_of_day", value);
    }

    /// <summary>
    /// If true, enables the configuration of a custom action timeout (waiting
    /// period) between database server patching operations.
    /// </summary>
    public TerraformValue<bool> IsCustomActionTimeoutEnabled
    {
        get => GetArgument<TerraformValue<bool>>("is_custom_action_timeout_enabled") ?? AsReference("is_custom_action_timeout_enabled");
        set => SetArgument("is_custom_action_timeout_enabled", value);
    }

    /// <summary>
    /// Lead time window allows user to set a lead time to prepare for a down time.
    /// The lead time is in weeks and valid value is between 1 to 4.
    /// </summary>
    public TerraformValue<double> LeadTimeWeek
    {
        get => GetArgument<TerraformValue<double>>("lead_time_week") ?? AsReference("lead_time_week");
        set => SetArgument("lead_time_week", value);
    }

    /// <summary>
    /// Months during the year when maintenance should be performed.
    /// </summary>
    public TerraformList<string> Months
    {
        get => GetArgument<TerraformList<string>>("months") ?? AsReference("months");
        set => SetArgument("months", value);
    }

    /// <summary>
    /// Cloud CloudExadataInfrastructure node patching method, either &amp;quot;ROLLING&amp;quot;
    ///  or &amp;quot;NONROLLING&amp;quot;. Default value is ROLLING. 
    ///  Possible values:
    ///  PATCHING_MODE_UNSPECIFIED
    /// ROLLING
    /// NON_ROLLING
    /// </summary>
    public TerraformValue<string> PatchingMode
    {
        get => GetArgument<TerraformValue<string>>("patching_mode") ?? AsReference("patching_mode");
        set => SetArgument("patching_mode", value);
    }

    /// <summary>
    /// The maintenance window scheduling preference. 
    ///  Possible values:
    ///  MAINTENANCE_WINDOW_PREFERENCE_UNSPECIFIED
    /// CUSTOM_PREFERENCE
    /// NO_PREFERENCE
    /// </summary>
    public TerraformValue<string> Preference
    {
        get => GetArgument<TerraformValue<string>>("preference") ?? AsReference("preference");
        set => SetArgument("preference", value);
    }

    /// <summary>
    /// Weeks during the month when maintenance should be performed. Weeks start on
    /// the 1st, 8th, 15th, and 22nd days of the month, and have a duration of 7
    /// days. Weeks start and end based on calendar dates, not days of the week.
    /// </summary>
    public TerraformList<double> WeeksOfMonth
    {
        get => GetArgument<TerraformList<double>>("weeks_of_month") ?? AsReference("weeks_of_month");
        set => SetArgument("weeks_of_month", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleOracleDatabaseCloudExadataInfrastructure.
/// Nesting mode: single
/// </summary>
public class GoogleOracleDatabaseCloudExadataInfrastructureTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_oracle_database_cloud_exadata_infrastructure Terraform resource.
/// Manages a google_oracle_database_cloud_exadata_infrastructure resource.
/// </summary>
public partial class GoogleOracleDatabaseCloudExadataInfrastructure(string name) : TerraformResource("google_oracle_database_cloud_exadata_infrastructure", name)
{
    /// <summary>
    /// The ID of the Exadata Infrastructure to create. This value is restricted
    /// to (^[a-z]([a-z0-9-]{0,61}[a-z0-9])?$) and must be a maximum of 63
    /// characters in length. The value must start with a letter and end with
    /// a letter or a number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructureId is required")]
    public required TerraformValue<string> CloudExadataInfrastructureId
    {
        get => GetRequiredArgument<TerraformValue<string>>("cloud_exadata_infrastructure_id");
        set => SetArgument("cloud_exadata_infrastructure_id", value);
    }

    /// <summary>
    /// Whether or not to allow Terraform to destroy the instance. Unless this field is set to false in Terraform state, a terraform destroy or terraform apply that would delete the instance will fail.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => GetArgument<TerraformValue<bool>>("deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// User friendly name for this resource.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// GCP location where Oracle Exadata is hosted.
    /// </summary>
    public TerraformValue<string> GcpOracleZone
    {
        get => GetArgument<TerraformValue<string>>("gcp_oracle_zone") ?? AsReference("gcp_oracle_zone");
        set => SetArgument("gcp_oracle_zone", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Labels or tags associated with the resource. 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. See documentation for resource type &#39;oracledatabase.googleapis.com/DbServer&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The date and time that the Exadata Infrastructure was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// Entitlement ID of the private offer against which this infrastructure
    /// resource is provisioned.
    /// </summary>
    public TerraformValue<string> EntitlementId
        => AsReference("entitlement_id");

    /// <summary>
    /// Identifier. The name of the Exadata Infrastructure resource with the following format:
    /// projects/{project}/locations/{region}/cloudExadataInfrastructures/{cloud_exadata_infrastructure}
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Properties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    public TerraformList<GoogleOracleDatabaseCloudExadataInfrastructurePropertiesBlock>? Properties
    {
        get => GetArgument<TerraformList<GoogleOracleDatabaseCloudExadataInfrastructurePropertiesBlock>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleOracleDatabaseCloudExadataInfrastructureTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleOracleDatabaseCloudExadataInfrastructureTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
