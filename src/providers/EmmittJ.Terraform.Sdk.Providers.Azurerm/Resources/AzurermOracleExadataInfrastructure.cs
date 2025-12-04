using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for maintenance_window in AzurermOracleExadataInfrastructure.
/// Nesting mode: list
/// </summary>
public class AzurermOracleExadataInfrastructureMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_window";

    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    public TerraformList<string> DaysOfWeek
    {
        get => GetArgument<TerraformList<string>>("days_of_week") ?? AsReference("days_of_week");
        set => SetArgument("days_of_week", value);
    }

    /// <summary>
    /// The hours_of_day attribute.
    /// </summary>
    public TerraformList<double> HoursOfDay
    {
        get => GetArgument<TerraformList<double>>("hours_of_day") ?? AsReference("hours_of_day");
        set => SetArgument("hours_of_day", value);
    }

    /// <summary>
    /// The lead_time_in_weeks attribute.
    /// </summary>
    public TerraformValue<double> LeadTimeInWeeks
    {
        get => GetArgument<TerraformValue<double>>("lead_time_in_weeks") ?? AsReference("lead_time_in_weeks");
        set => SetArgument("lead_time_in_weeks", value);
    }

    /// <summary>
    /// The months attribute.
    /// </summary>
    public TerraformList<string> Months
    {
        get => GetArgument<TerraformList<string>>("months") ?? AsReference("months");
        set => SetArgument("months", value);
    }

    /// <summary>
    /// The patching_mode attribute.
    /// </summary>
    public TerraformValue<string> PatchingMode
    {
        get => GetArgument<TerraformValue<string>>("patching_mode") ?? AsReference("patching_mode");
        set => SetArgument("patching_mode", value);
    }

    /// <summary>
    /// The preference attribute.
    /// </summary>
    public TerraformValue<string> Preference
    {
        get => GetArgument<TerraformValue<string>>("preference") ?? AsReference("preference");
        set => SetArgument("preference", value);
    }

    /// <summary>
    /// The weeks_of_month attribute.
    /// </summary>
    public TerraformList<double> WeeksOfMonth
    {
        get => GetArgument<TerraformList<double>>("weeks_of_month") ?? AsReference("weeks_of_month");
        set => SetArgument("weeks_of_month", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermOracleExadataInfrastructure.
/// Nesting mode: single
/// </summary>
public class AzurermOracleExadataInfrastructureTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
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
/// Represents a azurerm_oracle_exadata_infrastructure Terraform resource.
/// Manages a azurerm_oracle_exadata_infrastructure resource.
/// </summary>
public partial class AzurermOracleExadataInfrastructure(string name) : TerraformResource("azurerm_oracle_exadata_infrastructure", name)
{
    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeCount is required")]
    public required TerraformValue<double> ComputeCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("compute_count");
        set => SetArgument("compute_count", value);
    }

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    public TerraformList<string> CustomerContacts
    {
        get => GetArgument<TerraformList<string>>("customer_contacts") ?? AsReference("customer_contacts");
        set => SetArgument("customer_contacts", value);
    }

    /// <summary>
    /// The database_server_type attribute.
    /// </summary>
    public TerraformValue<string> DatabaseServerType
    {
        get => GetArgument<TerraformValue<string>>("database_server_type") ?? AsReference("database_server_type");
        set => SetArgument("database_server_type", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The shape attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Shape is required")]
    public required TerraformValue<string> Shape
    {
        get => GetRequiredArgument<TerraformValue<string>>("shape");
        set => SetArgument("shape", value);
    }

    /// <summary>
    /// The storage_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageCount is required")]
    public required TerraformValue<double> StorageCount
    {
        get => GetRequiredArgument<TerraformValue<double>>("storage_count");
        set => SetArgument("storage_count", value);
    }

    /// <summary>
    /// The storage_server_type attribute.
    /// </summary>
    public TerraformValue<string> StorageServerType
    {
        get => GetArgument<TerraformValue<string>>("storage_server_type") ?? AsReference("storage_server_type");
        set => SetArgument("storage_server_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zones is required")]
    public required TerraformSet<string> Zones
    {
        get => GetRequiredArgument<TerraformSet<string>>("zones");
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// MaintenanceWindow block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermOracleExadataInfrastructureMaintenanceWindowBlock>? MaintenanceWindow
    {
        get => GetArgument<TerraformList<AzurermOracleExadataInfrastructureMaintenanceWindowBlock>>("maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermOracleExadataInfrastructureTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermOracleExadataInfrastructureTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
