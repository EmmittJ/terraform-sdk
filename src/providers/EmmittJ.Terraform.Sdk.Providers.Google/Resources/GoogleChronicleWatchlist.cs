using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for entity_population_mechanism in GoogleChronicleWatchlist.
/// Nesting mode: list
/// </summary>
public class GoogleChronicleWatchlistEntityPopulationMechanismBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "entity_population_mechanism";

    /// <summary>
    /// Manual block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Manual block(s) allowed")]
    public TerraformList<GoogleChronicleWatchlistEntityPopulationMechanismBlockManualBlock>? Manual
    {
        get => GetArgument<TerraformList<GoogleChronicleWatchlistEntityPopulationMechanismBlockManualBlock>>("manual");
        set => SetArgument("manual", value);
    }

}

/// <summary>
/// Block type for manual in GoogleChronicleWatchlistEntityPopulationMechanismBlock.
/// Nesting mode: list
/// </summary>
public class GoogleChronicleWatchlistEntityPopulationMechanismBlockManualBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "manual";

}


/// <summary>
/// Block type for timeouts in GoogleChronicleWatchlist.
/// Nesting mode: single
/// </summary>
public class GoogleChronicleWatchlistTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for watchlist_user_preferences in GoogleChronicleWatchlist.
/// Nesting mode: list
/// </summary>
public class GoogleChronicleWatchlistWatchlistUserPreferencesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "watchlist_user_preferences";

    /// <summary>
    /// Optional. Whether the watchlist is pinned on the dashboard.
    /// </summary>
    public TerraformValue<bool>? Pinned
    {
        get => new TerraformReference<bool>(this, "pinned");
        set => SetArgument("pinned", value);
    }

}


/// <summary>
/// Represents a google_chronicle_watchlist Terraform resource.
/// Manages a google_chronicle_watchlist resource.
/// </summary>
public partial class GoogleChronicleWatchlist(string name) : TerraformResource("google_chronicle_watchlist", name)
{
    /// <summary>
    /// Optional. Description of the watchlist.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Required. Display name of the watchlist.
    /// Note that it must be at least one character and less than 63 characters
    /// (https://google.aip.dev/148).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformValue<string> Instance
    {
        get => new TerraformReference<string>(this, "instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Optional. Weight applied to the risk score for entities
    /// in this watchlist.
    /// The default is 1.0 if it is not specified.
    /// </summary>
    public TerraformValue<double>? MultiplyingFactor
    {
        get => new TerraformReference<double>(this, "multiplying_factor");
        set => SetArgument("multiplying_factor", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Optional. The ID to use for the watchlist,
    /// which will become the final component of the watchlist&#39;s resource name.
    /// This value should be 4-63 characters, and valid characters
    /// are /a-z-/.
    /// </summary>
    public TerraformValue<string> WatchlistId
    {
        get => new TerraformReference<string>(this, "watchlist_id");
        set => SetArgument("watchlist_id", value);
    }

    /// <summary>
    /// Output only. Time the watchlist was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Count of different types of entities in the watchlist.
    /// </summary>
    public TerraformList<TerraformMap<object>> EntityCount
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "entity_count").ResolveNodes(ctx));
    }

    /// <summary>
    /// Identifier. Resource name of the watchlist. This unique identifier is generated using values provided for the URL parameters.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Output only. Time the watchlist was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// EntityPopulationMechanism block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityPopulationMechanism is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EntityPopulationMechanism block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EntityPopulationMechanism block(s) allowed")]
    public required TerraformList<GoogleChronicleWatchlistEntityPopulationMechanismBlock> EntityPopulationMechanism
    {
        get => GetRequiredArgument<TerraformList<GoogleChronicleWatchlistEntityPopulationMechanismBlock>>("entity_population_mechanism");
        set => SetArgument("entity_population_mechanism", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleChronicleWatchlistTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleChronicleWatchlistTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// WatchlistUserPreferences block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WatchlistUserPreferences block(s) allowed")]
    public TerraformList<GoogleChronicleWatchlistWatchlistUserPreferencesBlock>? WatchlistUserPreferences
    {
        get => GetArgument<TerraformList<GoogleChronicleWatchlistWatchlistUserPreferencesBlock>>("watchlist_user_preferences");
        set => SetArgument("watchlist_user_preferences", value);
    }

}
