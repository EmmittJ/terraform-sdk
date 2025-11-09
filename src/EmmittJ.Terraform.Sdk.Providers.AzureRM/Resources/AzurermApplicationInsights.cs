using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("app_id");
        this.DeclareOutput("connection_string");
        this.DeclareOutput("instrumentation_key");
    }

    /// <summary>
    /// The application_type attribute.
    /// </summary>
    public TerraformProperty<string>? ApplicationType
    {
        get => GetProperty<TerraformProperty<string>>("application_type");
        set => this.WithProperty("application_type", value);
    }

    /// <summary>
    /// The daily_data_cap_in_gb attribute.
    /// </summary>
    public TerraformProperty<double>? DailyDataCapInGb
    {
        get => GetProperty<TerraformProperty<double>>("daily_data_cap_in_gb");
        set => this.WithProperty("daily_data_cap_in_gb", value);
    }

    /// <summary>
    /// The daily_data_cap_notifications_disabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DailyDataCapNotificationsDisabled
    {
        get => GetProperty<TerraformProperty<bool>>("daily_data_cap_notifications_disabled");
        set => this.WithProperty("daily_data_cap_notifications_disabled", value);
    }

    /// <summary>
    /// The disable_ip_masking attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableIpMasking
    {
        get => GetProperty<TerraformProperty<bool>>("disable_ip_masking");
        set => this.WithProperty("disable_ip_masking", value);
    }

    /// <summary>
    /// The force_customer_storage_for_profiler attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceCustomerStorageForProfiler
    {
        get => GetProperty<TerraformProperty<bool>>("force_customer_storage_for_profiler");
        set => this.WithProperty("force_customer_storage_for_profiler", value);
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
    /// The internet_ingestion_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? InternetIngestionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("internet_ingestion_enabled");
        set => this.WithProperty("internet_ingestion_enabled", value);
    }

    /// <summary>
    /// The internet_query_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? InternetQueryEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("internet_query_enabled");
        set => this.WithProperty("internet_query_enabled", value);
    }

    /// <summary>
    /// The local_authentication_disabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LocalAuthenticationDisabled
    {
        get => GetProperty<TerraformProperty<bool>>("local_authentication_disabled");
        set => this.WithProperty("local_authentication_disabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    public TerraformProperty<double>? RetentionInDays
    {
        get => GetProperty<TerraformProperty<double>>("retention_in_days");
        set => this.WithProperty("retention_in_days", value);
    }

    /// <summary>
    /// The sampling_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? SamplingPercentage
    {
        get => GetProperty<TerraformProperty<double>>("sampling_percentage");
        set => this.WithProperty("sampling_percentage", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? WorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
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
