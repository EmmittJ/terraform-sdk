using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermStreamAnalyticsJobIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for job_storage_account in .
/// Nesting mode: list
/// </summary>
public class AzurermStreamAnalyticsJobJobStorageAccountBlock : TerraformBlock
{
    /// <summary>
    /// The account_key attribute.
    /// </summary>
    public TerraformProperty<string>? AccountKey
    {
        set => SetProperty("account_key", value);
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformProperty<string> AccountName
    {
        set => SetProperty("account_name", value);
    }

    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    public TerraformProperty<string>? AuthenticationMode
    {
        set => SetProperty("authentication_mode", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStreamAnalyticsJobTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_stream_analytics_job resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermStreamAnalyticsJob : TerraformResource
{
    public AzurermStreamAnalyticsJob(string name) : base("azurerm_stream_analytics_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("job_id");
        SetOutput("compatibility_level");
        SetOutput("content_storage_policy");
        SetOutput("data_locale");
        SetOutput("events_late_arrival_max_delay_in_seconds");
        SetOutput("events_out_of_order_max_delay_in_seconds");
        SetOutput("events_out_of_order_policy");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("output_error_policy");
        SetOutput("resource_group_name");
        SetOutput("sku_name");
        SetOutput("stream_analytics_cluster_id");
        SetOutput("streaming_units");
        SetOutput("tags");
        SetOutput("transformation_query");
        SetOutput("type");
    }

    /// <summary>
    /// The compatibility_level attribute.
    /// </summary>
    public TerraformProperty<string> CompatibilityLevel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("compatibility_level");
        set => SetProperty("compatibility_level", value);
    }

    /// <summary>
    /// The content_storage_policy attribute.
    /// </summary>
    public TerraformProperty<string> ContentStoragePolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content_storage_policy");
        set => SetProperty("content_storage_policy", value);
    }

    /// <summary>
    /// The data_locale attribute.
    /// </summary>
    public TerraformProperty<string> DataLocale
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_locale");
        set => SetProperty("data_locale", value);
    }

    /// <summary>
    /// The events_late_arrival_max_delay_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double> EventsLateArrivalMaxDelayInSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("events_late_arrival_max_delay_in_seconds");
        set => SetProperty("events_late_arrival_max_delay_in_seconds", value);
    }

    /// <summary>
    /// The events_out_of_order_max_delay_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double> EventsOutOfOrderMaxDelayInSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("events_out_of_order_max_delay_in_seconds");
        set => SetProperty("events_out_of_order_max_delay_in_seconds", value);
    }

    /// <summary>
    /// The events_out_of_order_policy attribute.
    /// </summary>
    public TerraformProperty<string> EventsOutOfOrderPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("events_out_of_order_policy");
        set => SetProperty("events_out_of_order_policy", value);
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
    /// The output_error_policy attribute.
    /// </summary>
    public TerraformProperty<string> OutputErrorPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("output_error_policy");
        set => SetProperty("output_error_policy", value);
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
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string> SkuName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku_name");
        set => SetProperty("sku_name", value);
    }

    /// <summary>
    /// The stream_analytics_cluster_id attribute.
    /// </summary>
    public TerraformProperty<string> StreamAnalyticsClusterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stream_analytics_cluster_id");
        set => SetProperty("stream_analytics_cluster_id", value);
    }

    /// <summary>
    /// The streaming_units attribute.
    /// </summary>
    public TerraformProperty<double> StreamingUnits
    {
        get => GetRequiredOutput<TerraformProperty<double>>("streaming_units");
        set => SetProperty("streaming_units", value);
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
    /// The transformation_query attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransformationQuery is required")]
    public required TerraformProperty<string> TransformationQuery
    {
        get => GetRequiredOutput<TerraformProperty<string>>("transformation_query");
        set => SetProperty("transformation_query", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermStreamAnalyticsJobIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for job_storage_account.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JobStorageAccount block(s) allowed")]
    public List<AzurermStreamAnalyticsJobJobStorageAccountBlock>? JobStorageAccount
    {
        set => SetProperty("job_storage_account", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStreamAnalyticsJobTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    public TerraformExpression JobId => this["job_id"];

}
