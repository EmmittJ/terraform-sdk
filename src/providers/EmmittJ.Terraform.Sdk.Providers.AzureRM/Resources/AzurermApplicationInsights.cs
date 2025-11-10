using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApplicationInsightsTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_application_insights resource.
/// </summary>
public class AzurermApplicationInsights : TerraformResource
{
    public AzurermApplicationInsights(string name) : base("azurerm_application_insights", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("app_id");
        SetOutput("connection_string");
        SetOutput("instrumentation_key");
        SetOutput("application_type");
        SetOutput("daily_data_cap_in_gb");
        SetOutput("daily_data_cap_notifications_disabled");
        SetOutput("disable_ip_masking");
        SetOutput("force_customer_storage_for_profiler");
        SetOutput("id");
        SetOutput("internet_ingestion_enabled");
        SetOutput("internet_query_enabled");
        SetOutput("local_authentication_disabled");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("retention_in_days");
        SetOutput("sampling_percentage");
        SetOutput("tags");
        SetOutput("workspace_id");
    }

    /// <summary>
    /// The application_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationType is required")]
    public required TerraformProperty<string> ApplicationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_type");
        set => SetProperty("application_type", value);
    }

    /// <summary>
    /// The daily_data_cap_in_gb attribute.
    /// </summary>
    public TerraformProperty<double> DailyDataCapInGb
    {
        get => GetRequiredOutput<TerraformProperty<double>>("daily_data_cap_in_gb");
        set => SetProperty("daily_data_cap_in_gb", value);
    }

    /// <summary>
    /// The daily_data_cap_notifications_disabled attribute.
    /// </summary>
    public TerraformProperty<bool> DailyDataCapNotificationsDisabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("daily_data_cap_notifications_disabled");
        set => SetProperty("daily_data_cap_notifications_disabled", value);
    }

    /// <summary>
    /// The disable_ip_masking attribute.
    /// </summary>
    public TerraformProperty<bool> DisableIpMasking
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_ip_masking");
        set => SetProperty("disable_ip_masking", value);
    }

    /// <summary>
    /// The force_customer_storage_for_profiler attribute.
    /// </summary>
    public TerraformProperty<bool> ForceCustomerStorageForProfiler
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_customer_storage_for_profiler");
        set => SetProperty("force_customer_storage_for_profiler", value);
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
    /// The internet_ingestion_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> InternetIngestionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("internet_ingestion_enabled");
        set => SetProperty("internet_ingestion_enabled", value);
    }

    /// <summary>
    /// The internet_query_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> InternetQueryEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("internet_query_enabled");
        set => SetProperty("internet_query_enabled", value);
    }

    /// <summary>
    /// The local_authentication_disabled attribute.
    /// </summary>
    public TerraformProperty<bool> LocalAuthenticationDisabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("local_authentication_disabled");
        set => SetProperty("local_authentication_disabled", value);
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
    /// The retention_in_days attribute.
    /// </summary>
    public TerraformProperty<double> RetentionInDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("retention_in_days");
        set => SetProperty("retention_in_days", value);
    }

    /// <summary>
    /// The sampling_percentage attribute.
    /// </summary>
    public TerraformProperty<double> SamplingPercentage
    {
        get => GetRequiredOutput<TerraformProperty<double>>("sampling_percentage");
        set => SetProperty("sampling_percentage", value);
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
    /// The workspace_id attribute.
    /// </summary>
    public TerraformProperty<string> WorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workspace_id");
        set => SetProperty("workspace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermApplicationInsightsTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The app_id attribute.
    /// </summary>
    public TerraformExpression AppId => this["app_id"];

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformExpression ConnectionString => this["connection_string"];

    /// <summary>
    /// The instrumentation_key attribute.
    /// </summary>
    public TerraformExpression InstrumentationKey => this["instrumentation_key"];

}
