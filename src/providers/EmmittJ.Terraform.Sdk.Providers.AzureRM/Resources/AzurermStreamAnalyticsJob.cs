using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for identity in .
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
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for job_storage_account in .
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
    [TerraformArgument("account_key")]
    public TerraformValue<string>? AccountKey
    {
        get => new TerraformReference<string>(this, "account_key");
        set => SetArgument("account_key", value);
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformArgument("account_name")]
    public required TerraformValue<string> AccountName
    {
        get => new TerraformReference<string>(this, "account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    [TerraformArgument("authentication_mode")]
    public TerraformValue<string>? AuthenticationMode
    {
        get => new TerraformReference<string>(this, "authentication_mode");
        set => SetArgument("authentication_mode", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_stream_analytics_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermStreamAnalyticsJob : TerraformResource
{
    public AzurermStreamAnalyticsJob(string name) : base("azurerm_stream_analytics_job", name)
    {
    }

    /// <summary>
    /// The compatibility_level attribute.
    /// </summary>
    [TerraformArgument("compatibility_level")]
    public TerraformValue<string> CompatibilityLevel
    {
        get => new TerraformReference<string>(this, "compatibility_level");
        set => SetArgument("compatibility_level", value);
    }

    /// <summary>
    /// The content_storage_policy attribute.
    /// </summary>
    [TerraformArgument("content_storage_policy")]
    public TerraformValue<string>? ContentStoragePolicy
    {
        get => new TerraformReference<string>(this, "content_storage_policy");
        set => SetArgument("content_storage_policy", value);
    }

    /// <summary>
    /// The data_locale attribute.
    /// </summary>
    [TerraformArgument("data_locale")]
    public TerraformValue<string>? DataLocale
    {
        get => new TerraformReference<string>(this, "data_locale");
        set => SetArgument("data_locale", value);
    }

    /// <summary>
    /// The events_late_arrival_max_delay_in_seconds attribute.
    /// </summary>
    [TerraformArgument("events_late_arrival_max_delay_in_seconds")]
    public TerraformValue<double>? EventsLateArrivalMaxDelayInSeconds
    {
        get => new TerraformReference<double>(this, "events_late_arrival_max_delay_in_seconds");
        set => SetArgument("events_late_arrival_max_delay_in_seconds", value);
    }

    /// <summary>
    /// The events_out_of_order_max_delay_in_seconds attribute.
    /// </summary>
    [TerraformArgument("events_out_of_order_max_delay_in_seconds")]
    public TerraformValue<double>? EventsOutOfOrderMaxDelayInSeconds
    {
        get => new TerraformReference<double>(this, "events_out_of_order_max_delay_in_seconds");
        set => SetArgument("events_out_of_order_max_delay_in_seconds", value);
    }

    /// <summary>
    /// The events_out_of_order_policy attribute.
    /// </summary>
    [TerraformArgument("events_out_of_order_policy")]
    public TerraformValue<string>? EventsOutOfOrderPolicy
    {
        get => new TerraformReference<string>(this, "events_out_of_order_policy");
        set => SetArgument("events_out_of_order_policy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The output_error_policy attribute.
    /// </summary>
    [TerraformArgument("output_error_policy")]
    public TerraformValue<string>? OutputErrorPolicy
    {
        get => new TerraformReference<string>(this, "output_error_policy");
        set => SetArgument("output_error_policy", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformArgument("sku_name")]
    public TerraformValue<string>? SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
    }

    /// <summary>
    /// The stream_analytics_cluster_id attribute.
    /// </summary>
    [TerraformArgument("stream_analytics_cluster_id")]
    public TerraformValue<string>? StreamAnalyticsClusterId
    {
        get => new TerraformReference<string>(this, "stream_analytics_cluster_id");
        set => SetArgument("stream_analytics_cluster_id", value);
    }

    /// <summary>
    /// The streaming_units attribute.
    /// </summary>
    [TerraformArgument("streaming_units")]
    public TerraformValue<double>? StreamingUnits
    {
        get => new TerraformReference<double>(this, "streaming_units");
        set => SetArgument("streaming_units", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The transformation_query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransformationQuery is required")]
    [TerraformArgument("transformation_query")]
    public required TerraformValue<string> TransformationQuery
    {
        get => new TerraformReference<string>(this, "transformation_query");
        set => SetArgument("transformation_query", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformArgument("type")]
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermStreamAnalyticsJobIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for job_storage_account.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JobStorageAccount block(s) allowed")]
    [TerraformArgument("job_storage_account")]
    public TerraformList<AzurermStreamAnalyticsJobJobStorageAccountBlock> JobStorageAccount { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermStreamAnalyticsJobTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    [TerraformArgument("job_id")]
    public TerraformValue<string> JobId
    {
        get => new TerraformReference<string>(this, "job_id");
    }

}
