using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for split in GoogleAppEngineServiceSplitTraffic.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineServiceSplitTrafficSplitBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "split";

    /// <summary>
    /// Mapping from version IDs within the service to fractional (0.000, 1] allocations of traffic for that version. Each version can be specified only once, but some versions in the service may not have any traffic allocation. Services that have traffic allocated cannot be deleted until either the service is deleted or their traffic allocation is removed. Allocations must sum to 1. Up to two decimal place precision is supported for IP-based splits and up to three decimal places is supported for cookie-based splits.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Allocations is required")]
    public required TerraformMap<string> Allocations
    {
        get => GetArgument<TerraformMap<string>>("allocations");
        set => SetArgument("allocations", value);
    }

    /// <summary>
    /// Mechanism used to determine which version a request is sent to. The traffic selection algorithm will be stable for either type until allocations are changed. Possible values: [&amp;quot;UNSPECIFIED&amp;quot;, &amp;quot;COOKIE&amp;quot;, &amp;quot;IP&amp;quot;, &amp;quot;RANDOM&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ShardBy
    {
        get => GetArgument<TerraformValue<string>>("shard_by");
        set => SetArgument("shard_by", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleAppEngineServiceSplitTraffic.
/// Nesting mode: single
/// </summary>
public class GoogleAppEngineServiceSplitTrafficTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_app_engine_service_split_traffic Terraform resource.
/// Manages a google_app_engine_service_split_traffic resource.
/// </summary>
public partial class GoogleAppEngineServiceSplitTraffic(string name) : TerraformResource("google_app_engine_service_split_traffic", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// If set to true traffic will be migrated to this version.
    /// </summary>
    public TerraformValue<bool>? MigrateTraffic
    {
        get => GetArgument<TerraformValue<bool>>("migrate_traffic");
        set => SetArgument("migrate_traffic", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The name of the service these settings apply to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// Split block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Split is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Split block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Split block(s) allowed")]
    public required TerraformList<GoogleAppEngineServiceSplitTrafficSplitBlock> Split
    {
        get => GetRequiredArgument<TerraformList<GoogleAppEngineServiceSplitTrafficSplitBlock>>("split");
        set => SetArgument("split", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleAppEngineServiceSplitTrafficTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleAppEngineServiceSplitTrafficTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
