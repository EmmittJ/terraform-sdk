using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for split in .
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineServiceSplitTrafficSplitBlock : TerraformBlock
{
    /// <summary>
    /// Mapping from version IDs within the service to fractional (0.000, 1] allocations of traffic for that version. Each version can be specified only once, but some versions in the service may not have any traffic allocation. Services that have traffic allocated cannot be deleted until either the service is deleted or their traffic allocation is removed. Allocations must sum to 1. Up to two decimal place precision is supported for IP-based splits and up to three decimal places is supported for cookie-based splits.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Allocations is required")]
    public Dictionary<string, TerraformProperty<string>>? Allocations
    {
        set => SetProperty("allocations", value);
    }

    /// <summary>
    /// Mechanism used to determine which version a request is sent to. The traffic selection algorithm will be stable for either type until allocations are changed. Possible values: [&amp;quot;UNSPECIFIED&amp;quot;, &amp;quot;COOKIE&amp;quot;, &amp;quot;IP&amp;quot;, &amp;quot;RANDOM&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ShardBy
    {
        set => SetProperty("shard_by", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAppEngineServiceSplitTrafficTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_app_engine_service_split_traffic resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleAppEngineServiceSplitTraffic : TerraformResource
{
    public GoogleAppEngineServiceSplitTraffic(string name) : base("google_app_engine_service_split_traffic", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("migrate_traffic");
        SetOutput("project");
        SetOutput("service");
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
    /// If set to true traffic will be migrated to this version.
    /// </summary>
    public TerraformProperty<bool> MigrateTraffic
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("migrate_traffic");
        set => SetProperty("migrate_traffic", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The name of the service these settings apply to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service");
        set => SetProperty("service", value);
    }

    /// <summary>
    /// Block for split.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Split is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Split block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Split block(s) allowed")]
    public List<GoogleAppEngineServiceSplitTrafficSplitBlock>? Split
    {
        set => SetProperty("split", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleAppEngineServiceSplitTrafficTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
