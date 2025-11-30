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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "application_type");
        set => SetArgument("application_type", value);
    }

    /// <summary>
    /// The daily_data_cap_in_gb attribute.
    /// </summary>
    public TerraformValue<double>? DailyDataCapInGb
    {
        get => new TerraformReference<double>(this, "daily_data_cap_in_gb");
        set => SetArgument("daily_data_cap_in_gb", value);
    }

    /// <summary>
    /// The daily_data_cap_notifications_disabled attribute.
    /// </summary>
    public TerraformValue<bool>? DailyDataCapNotificationsDisabled
    {
        get => new TerraformReference<bool>(this, "daily_data_cap_notifications_disabled");
        set => SetArgument("daily_data_cap_notifications_disabled", value);
    }

    /// <summary>
    /// The disable_ip_masking attribute.
    /// </summary>
    public TerraformValue<bool>? DisableIpMasking
    {
        get => new TerraformReference<bool>(this, "disable_ip_masking");
        set => SetArgument("disable_ip_masking", value);
    }

    /// <summary>
    /// The force_customer_storage_for_profiler attribute.
    /// </summary>
    public TerraformValue<bool>? ForceCustomerStorageForProfiler
    {
        get => new TerraformReference<bool>(this, "force_customer_storage_for_profiler");
        set => SetArgument("force_customer_storage_for_profiler", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The internet_ingestion_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? InternetIngestionEnabled
    {
        get => new TerraformReference<bool>(this, "internet_ingestion_enabled");
        set => SetArgument("internet_ingestion_enabled", value);
    }

    /// <summary>
    /// The internet_query_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? InternetQueryEnabled
    {
        get => new TerraformReference<bool>(this, "internet_query_enabled");
        set => SetArgument("internet_query_enabled", value);
    }

    /// <summary>
    /// The local_authentication_disabled attribute.
    /// </summary>
    public TerraformValue<bool>? LocalAuthenticationDisabled
    {
        get => new TerraformReference<bool>(this, "local_authentication_disabled");
        set => SetArgument("local_authentication_disabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    public TerraformValue<double>? RetentionInDays
    {
        get => new TerraformReference<double>(this, "retention_in_days");
        set => SetArgument("retention_in_days", value);
    }

    /// <summary>
    /// The sampling_percentage attribute.
    /// </summary>
    public TerraformValue<double>? SamplingPercentage
    {
        get => new TerraformReference<double>(this, "sampling_percentage");
        set => SetArgument("sampling_percentage", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformValue<string> WorkspaceId
    {
        get => new TerraformReference<string>(this, "workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// The app_id attribute.
    /// </summary>
    public TerraformValue<string> AppId
    {
        get => new TerraformReference<string>(this, "app_id");
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformValue<string> ConnectionString
    {
        get => new TerraformReference<string>(this, "connection_string");
    }

    /// <summary>
    /// The instrumentation_key attribute.
    /// </summary>
    public TerraformValue<string> InstrumentationKey
    {
        get => new TerraformReference<string>(this, "instrumentation_key");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApplicationInsightsTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApplicationInsightsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
