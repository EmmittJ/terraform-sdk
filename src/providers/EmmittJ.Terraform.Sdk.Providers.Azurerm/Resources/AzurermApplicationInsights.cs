using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermApplicationInsights.
/// Nesting mode: single
/// </summary>
public class AzurermApplicationInsightsTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_application_insights Terraform resource.
/// Manages a azurerm_application_insights resource.
/// </summary>
public partial class AzurermApplicationInsights(string name) : TerraformResource("azurerm_application_insights", name)
{
    /// <summary>
    /// The application_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationType is required")]
    public required TerraformValue<string> ApplicationType
    {
        get => GetArgument<TerraformValue<string>>("application_type");
        set => SetArgument("application_type", value);
    }

    /// <summary>
    /// The daily_data_cap_in_gb attribute.
    /// </summary>
    public TerraformValue<double>? DailyDataCapInGb
    {
        get => GetArgument<TerraformValue<double>>("daily_data_cap_in_gb");
        set => SetArgument("daily_data_cap_in_gb", value);
    }

    /// <summary>
    /// The daily_data_cap_notifications_disabled attribute.
    /// </summary>
    public TerraformValue<bool>? DailyDataCapNotificationsDisabled
    {
        get => GetArgument<TerraformValue<bool>>("daily_data_cap_notifications_disabled");
        set => SetArgument("daily_data_cap_notifications_disabled", value);
    }

    /// <summary>
    /// The disable_ip_masking attribute.
    /// </summary>
    public TerraformValue<bool>? DisableIpMasking
    {
        get => GetArgument<TerraformValue<bool>>("disable_ip_masking");
        set => SetArgument("disable_ip_masking", value);
    }

    /// <summary>
    /// The force_customer_storage_for_profiler attribute.
    /// </summary>
    public TerraformValue<bool>? ForceCustomerStorageForProfiler
    {
        get => GetArgument<TerraformValue<bool>>("force_customer_storage_for_profiler");
        set => SetArgument("force_customer_storage_for_profiler", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The internet_ingestion_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? InternetIngestionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("internet_ingestion_enabled");
        set => SetArgument("internet_ingestion_enabled", value);
    }

    /// <summary>
    /// The internet_query_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? InternetQueryEnabled
    {
        get => GetArgument<TerraformValue<bool>>("internet_query_enabled");
        set => SetArgument("internet_query_enabled", value);
    }

    /// <summary>
    /// The local_authentication_disabled attribute.
    /// </summary>
    public TerraformValue<bool>? LocalAuthenticationDisabled
    {
        get => GetArgument<TerraformValue<bool>>("local_authentication_disabled");
        set => SetArgument("local_authentication_disabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    public TerraformValue<double>? RetentionInDays
    {
        get => GetArgument<TerraformValue<double>>("retention_in_days");
        set => SetArgument("retention_in_days", value);
    }

    /// <summary>
    /// The sampling_percentage attribute.
    /// </summary>
    public TerraformValue<double>? SamplingPercentage
    {
        get => GetArgument<TerraformValue<double>>("sampling_percentage");
        set => SetArgument("sampling_percentage", value);
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
    /// The workspace_id attribute.
    /// </summary>
    public TerraformValue<string>? WorkspaceId
    {
        get => GetArgument<TerraformValue<string>>("workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// The app_id attribute.
    /// </summary>
    public TerraformValue<string> AppId
        => AsReference("app_id");

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformValue<string> ConnectionString
        => AsReference("connection_string");

    /// <summary>
    /// The instrumentation_key attribute.
    /// </summary>
    public TerraformValue<string> InstrumentationKey
        => AsReference("instrumentation_key");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApplicationInsightsTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApplicationInsightsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
