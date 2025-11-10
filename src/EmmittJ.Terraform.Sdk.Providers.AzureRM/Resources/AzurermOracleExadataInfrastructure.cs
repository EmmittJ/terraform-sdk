using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class AzurermOracleExadataInfrastructureMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// The days_of_week attribute.
    /// </summary>
    public List<TerraformProperty<string>>? DaysOfWeek
    {
        get => GetProperty<List<TerraformProperty<string>>>("days_of_week");
        set => WithProperty("days_of_week", value);
    }

    /// <summary>
    /// The hours_of_day attribute.
    /// </summary>
    public List<TerraformProperty<double>>? HoursOfDay
    {
        get => GetProperty<List<TerraformProperty<double>>>("hours_of_day");
        set => WithProperty("hours_of_day", value);
    }

    /// <summary>
    /// The lead_time_in_weeks attribute.
    /// </summary>
    public TerraformProperty<double>? LeadTimeInWeeks
    {
        get => GetProperty<TerraformProperty<double>>("lead_time_in_weeks");
        set => WithProperty("lead_time_in_weeks", value);
    }

    /// <summary>
    /// The months attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Months
    {
        get => GetProperty<List<TerraformProperty<string>>>("months");
        set => WithProperty("months", value);
    }

    /// <summary>
    /// The patching_mode attribute.
    /// </summary>
    public TerraformProperty<string>? PatchingMode
    {
        get => GetProperty<TerraformProperty<string>>("patching_mode");
        set => WithProperty("patching_mode", value);
    }

    /// <summary>
    /// The preference attribute.
    /// </summary>
    public TerraformProperty<string>? Preference
    {
        get => GetProperty<TerraformProperty<string>>("preference");
        set => WithProperty("preference", value);
    }

    /// <summary>
    /// The weeks_of_month attribute.
    /// </summary>
    public List<TerraformProperty<double>>? WeeksOfMonth
    {
        get => GetProperty<List<TerraformProperty<double>>>("weeks_of_month");
        set => WithProperty("weeks_of_month", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermOracleExadataInfrastructureTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
/// Manages a azurerm_oracle_exadata_infrastructure resource.
/// </summary>
public class AzurermOracleExadataInfrastructure : TerraformResource
{
    public AzurermOracleExadataInfrastructure(string name) : base("azurerm_oracle_exadata_infrastructure", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeCount is required")]
    public required TerraformProperty<double> ComputeCount
    {
        get => GetProperty<TerraformProperty<double>>("compute_count");
        set => this.WithProperty("compute_count", value);
    }

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    public List<TerraformProperty<string>>? CustomerContacts
    {
        get => GetProperty<List<TerraformProperty<string>>>("customer_contacts");
        set => this.WithProperty("customer_contacts", value);
    }

    /// <summary>
    /// The database_server_type attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseServerType
    {
        get => GetProperty<TerraformProperty<string>>("database_server_type");
        set => this.WithProperty("database_server_type", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The shape attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Shape is required")]
    public required TerraformProperty<string> Shape
    {
        get => GetProperty<TerraformProperty<string>>("shape");
        set => this.WithProperty("shape", value);
    }

    /// <summary>
    /// The storage_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageCount is required")]
    public required TerraformProperty<double> StorageCount
    {
        get => GetProperty<TerraformProperty<double>>("storage_count");
        set => this.WithProperty("storage_count", value);
    }

    /// <summary>
    /// The storage_server_type attribute.
    /// </summary>
    public TerraformProperty<string>? StorageServerType
    {
        get => GetProperty<TerraformProperty<string>>("storage_server_type");
        set => this.WithProperty("storage_server_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zones is required")]
    public HashSet<TerraformProperty<string>>? Zones
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermOracleExadataInfrastructureMaintenanceWindowBlock>? MaintenanceWindow
    {
        get => GetProperty<List<AzurermOracleExadataInfrastructureMaintenanceWindowBlock>>("maintenance_window");
        set => this.WithProperty("maintenance_window", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermOracleExadataInfrastructureTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermOracleExadataInfrastructureTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
