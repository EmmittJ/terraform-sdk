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
        set => SetProperty("days_of_week", value);
    }

    /// <summary>
    /// The hours_of_day attribute.
    /// </summary>
    public List<TerraformProperty<double>>? HoursOfDay
    {
        set => SetProperty("hours_of_day", value);
    }

    /// <summary>
    /// The lead_time_in_weeks attribute.
    /// </summary>
    public TerraformProperty<double>? LeadTimeInWeeks
    {
        set => SetProperty("lead_time_in_weeks", value);
    }

    /// <summary>
    /// The months attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Months
    {
        set => SetProperty("months", value);
    }

    /// <summary>
    /// The patching_mode attribute.
    /// </summary>
    public TerraformProperty<string>? PatchingMode
    {
        set => SetProperty("patching_mode", value);
    }

    /// <summary>
    /// The preference attribute.
    /// </summary>
    public TerraformProperty<string>? Preference
    {
        set => SetProperty("preference", value);
    }

    /// <summary>
    /// The weeks_of_month attribute.
    /// </summary>
    public List<TerraformProperty<double>>? WeeksOfMonth
    {
        set => SetProperty("weeks_of_month", value);
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
        SetOutput("compute_count");
        SetOutput("customer_contacts");
        SetOutput("database_server_type");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("shape");
        SetOutput("storage_count");
        SetOutput("storage_server_type");
        SetOutput("tags");
        SetOutput("zones");
    }

    /// <summary>
    /// The compute_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeCount is required")]
    public required TerraformProperty<double> ComputeCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("compute_count");
        set => SetProperty("compute_count", value);
    }

    /// <summary>
    /// The customer_contacts attribute.
    /// </summary>
    public List<TerraformProperty<string>> CustomerContacts
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("customer_contacts");
        set => SetProperty("customer_contacts", value);
    }

    /// <summary>
    /// The database_server_type attribute.
    /// </summary>
    public TerraformProperty<string> DatabaseServerType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_server_type");
        set => SetProperty("database_server_type", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The shape attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Shape is required")]
    public required TerraformProperty<string> Shape
    {
        get => GetRequiredOutput<TerraformProperty<string>>("shape");
        set => SetProperty("shape", value);
    }

    /// <summary>
    /// The storage_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageCount is required")]
    public required TerraformProperty<double> StorageCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("storage_count");
        set => SetProperty("storage_count", value);
    }

    /// <summary>
    /// The storage_server_type attribute.
    /// </summary>
    public TerraformProperty<string> StorageServerType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_server_type");
        set => SetProperty("storage_server_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zones is required")]
    public HashSet<TerraformProperty<string>> Zones
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("zones");
        set => SetProperty("zones", value);
    }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermOracleExadataInfrastructureMaintenanceWindowBlock>? MaintenanceWindow
    {
        set => SetProperty("maintenance_window", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermOracleExadataInfrastructureTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
