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
    public string? ApplicationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_type")?.Value;
        set => this.WithProperty("application_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The daily_data_cap_in_gb attribute.
    /// </summary>
    public double? DailyDataCapInGb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("daily_data_cap_in_gb")?.Value;
        set => this.WithProperty("daily_data_cap_in_gb", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The daily_data_cap_notifications_disabled attribute.
    /// </summary>
    public bool? DailyDataCapNotificationsDisabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("daily_data_cap_notifications_disabled")?.Value;
        set => this.WithProperty("daily_data_cap_notifications_disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The disable_ip_masking attribute.
    /// </summary>
    public bool? DisableIpMasking
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_ip_masking")?.Value;
        set => this.WithProperty("disable_ip_masking", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The force_customer_storage_for_profiler attribute.
    /// </summary>
    public bool? ForceCustomerStorageForProfiler
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_customer_storage_for_profiler")?.Value;
        set => this.WithProperty("force_customer_storage_for_profiler", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The internet_ingestion_enabled attribute.
    /// </summary>
    public bool? InternetIngestionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("internet_ingestion_enabled")?.Value;
        set => this.WithProperty("internet_ingestion_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The internet_query_enabled attribute.
    /// </summary>
    public bool? InternetQueryEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("internet_query_enabled")?.Value;
        set => this.WithProperty("internet_query_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The local_authentication_disabled attribute.
    /// </summary>
    public bool? LocalAuthenticationDisabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("local_authentication_disabled")?.Value;
        set => this.WithProperty("local_authentication_disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    public double? RetentionInDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("retention_in_days")?.Value;
        set => this.WithProperty("retention_in_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The sampling_percentage attribute.
    /// </summary>
    public double? SamplingPercentage
    {
        get => GetProperty<TerraformLiteralProperty<double>>("sampling_percentage")?.Value;
        set => this.WithProperty("sampling_percentage", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public string? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id")?.Value;
        set => this.WithProperty("workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
