using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermStreamAnalyticsJob.
/// Nesting mode: list
/// </summary>
public class AzurermStreamAnalyticsJobIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for job_storage_account in AzurermStreamAnalyticsJob.
/// Nesting mode: list
/// </summary>
public class AzurermStreamAnalyticsJobJobStorageAccountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "job_storage_account";

    /// <summary>
    /// The account_key attribute.
    /// </summary>
    public TerraformValue<string>? AccountKey
    {
        get => GetArgument<TerraformValue<string>>("account_key");
        set => SetArgument("account_key", value);
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformValue<string> AccountName
    {
        get => GetArgument<TerraformValue<string>>("account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    public TerraformValue<string>? AuthenticationMode
    {
        get => GetArgument<TerraformValue<string>>("authentication_mode");
        set => SetArgument("authentication_mode", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermStreamAnalyticsJob.
/// Nesting mode: single
/// </summary>
public class AzurermStreamAnalyticsJobTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_stream_analytics_job Terraform resource.
/// Manages a azurerm_stream_analytics_job resource.
/// </summary>
public partial class AzurermStreamAnalyticsJob(string name) : TerraformResource("azurerm_stream_analytics_job", name)
{
    /// <summary>
    /// The compatibility_level attribute.
    /// </summary>
    public TerraformValue<string>? CompatibilityLevel
    {
        get => GetArgument<TerraformValue<string>>("compatibility_level");
        set => SetArgument("compatibility_level", value);
    }

    /// <summary>
    /// The content_storage_policy attribute.
    /// </summary>
    public TerraformValue<string>? ContentStoragePolicy
    {
        get => GetArgument<TerraformValue<string>>("content_storage_policy");
        set => SetArgument("content_storage_policy", value);
    }

    /// <summary>
    /// The data_locale attribute.
    /// </summary>
    public TerraformValue<string>? DataLocale
    {
        get => GetArgument<TerraformValue<string>>("data_locale");
        set => SetArgument("data_locale", value);
    }

    /// <summary>
    /// The events_late_arrival_max_delay_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? EventsLateArrivalMaxDelayInSeconds
    {
        get => GetArgument<TerraformValue<double>>("events_late_arrival_max_delay_in_seconds");
        set => SetArgument("events_late_arrival_max_delay_in_seconds", value);
    }

    /// <summary>
    /// The events_out_of_order_max_delay_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? EventsOutOfOrderMaxDelayInSeconds
    {
        get => GetArgument<TerraformValue<double>>("events_out_of_order_max_delay_in_seconds");
        set => SetArgument("events_out_of_order_max_delay_in_seconds", value);
    }

    /// <summary>
    /// The events_out_of_order_policy attribute.
    /// </summary>
    public TerraformValue<string>? EventsOutOfOrderPolicy
    {
        get => GetArgument<TerraformValue<string>>("events_out_of_order_policy");
        set => SetArgument("events_out_of_order_policy", value);
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
    /// The output_error_policy attribute.
    /// </summary>
    public TerraformValue<string>? OutputErrorPolicy
    {
        get => GetArgument<TerraformValue<string>>("output_error_policy");
        set => SetArgument("output_error_policy", value);
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
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string>? SkuName
    {
        get => GetArgument<TerraformValue<string>>("sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The stream_analytics_cluster_id attribute.
    /// </summary>
    public TerraformValue<string>? StreamAnalyticsClusterId
    {
        get => GetArgument<TerraformValue<string>>("stream_analytics_cluster_id");
        set => SetArgument("stream_analytics_cluster_id", value);
    }

    /// <summary>
    /// The streaming_units attribute.
    /// </summary>
    public TerraformValue<double>? StreamingUnits
    {
        get => GetArgument<TerraformValue<double>>("streaming_units");
        set => SetArgument("streaming_units", value);
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
    /// The transformation_query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransformationQuery is required")]
    public required TerraformValue<string> TransformationQuery
    {
        get => GetArgument<TerraformValue<string>>("transformation_query");
        set => SetArgument("transformation_query", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    public TerraformValue<string> JobId
        => AsReference("job_id");

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermStreamAnalyticsJobIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermStreamAnalyticsJobIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// JobStorageAccount block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JobStorageAccount block(s) allowed")]
    public TerraformList<AzurermStreamAnalyticsJobJobStorageAccountBlock>? JobStorageAccount
    {
        get => GetArgument<TerraformList<AzurermStreamAnalyticsJobJobStorageAccountBlock>>("job_storage_account");
        set => SetArgument("job_storage_account", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStreamAnalyticsJobTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStreamAnalyticsJobTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
