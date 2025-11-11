using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for entity_population_mechanism in .
/// Nesting mode: list
/// </summary>
public partial class GoogleChronicleWatchlistEntityPopulationMechanismBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleChronicleWatchlistTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for watchlist_user_preferences in .
/// Nesting mode: list
/// </summary>
public partial class GoogleChronicleWatchlistWatchlistUserPreferencesBlock : TerraformBlockBase
{
    /// <summary>
    /// Optional. Whether the watchlist is pinned on the dashboard.
    /// </summary>
    [TerraformProperty("pinned")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Pinned { get; set; }

}

/// <summary>
/// Manages a google_chronicle_watchlist resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleChronicleWatchlist : TerraformResource
{
    public GoogleChronicleWatchlist(string name) : base("google_chronicle_watchlist", name)
    {
    }

    /// <summary>
    /// Optional. Description of the watchlist.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Required. Display name of the watchlist.
    /// Note that it must be at least one character and less than 63 characters
    /// (https://google.aip.dev/148).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformProperty("instance")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Optional. Weight applied to the risk score for entities
    /// in this watchlist.
    /// The default is 1.0 if it is not specified.
    /// </summary>
    [TerraformProperty("multiplying_factor")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MultiplyingFactor { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Optional. The ID to use for the watchlist,
    /// which will become the final component of the watchlist&#39;s resource name.
    /// This value should be 4-63 characters, and valid characters
    /// are /a-z-/.
    /// </summary>
    [TerraformProperty("watchlist_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> WatchlistId { get; set; }

    /// <summary>
    /// Block for entity_population_mechanism.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityPopulationMechanism is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EntityPopulationMechanism block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EntityPopulationMechanism block(s) allowed")]
    [TerraformProperty("entity_population_mechanism")]
    public TerraformList<TerraformBlock<GoogleChronicleWatchlistEntityPopulationMechanismBlock>>? EntityPopulationMechanism { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleChronicleWatchlistTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for watchlist_user_preferences.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WatchlistUserPreferences block(s) allowed")]
    [TerraformProperty("watchlist_user_preferences")]
    public TerraformList<TerraformBlock<GoogleChronicleWatchlistWatchlistUserPreferencesBlock>>? WatchlistUserPreferences { get; set; }

    /// <summary>
    /// Output only. Time the watchlist was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Count of different types of entities in the watchlist.
    /// </summary>
    [TerraformProperty("entity_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> EntityCount { get; }

    /// <summary>
    /// Identifier. Resource name of the watchlist. This unique identifier is generated using values provided for the URL parameters.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. Time the watchlist was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
