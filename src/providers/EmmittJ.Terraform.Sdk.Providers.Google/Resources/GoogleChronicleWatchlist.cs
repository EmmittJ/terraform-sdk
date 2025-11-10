using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for entity_population_mechanism in .
/// Nesting mode: list
/// </summary>
public class GoogleChronicleWatchlistEntityPopulationMechanismBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleChronicleWatchlistTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for watchlist_user_preferences in .
/// Nesting mode: list
/// </summary>
public class GoogleChronicleWatchlistWatchlistUserPreferencesBlock : ITerraformBlock
{
    /// <summary>
    /// Optional. Whether the watchlist is pinned on the dashboard.
    /// </summary>
    [TerraformPropertyName("pinned")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Pinned { get; set; }

}

/// <summary>
/// Manages a google_chronicle_watchlist resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleChronicleWatchlist : TerraformResource
{
    public GoogleChronicleWatchlist(string name) : base("google_chronicle_watchlist", name)
    {
    }

    /// <summary>
    /// Optional. Description of the watchlist.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Required. Display name of the watchlist.
    /// Note that it must be at least one character and less than 63 characters
    /// (https://google.aip.dev/148).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformPropertyName("instance")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Instance { get; set; }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// Optional. Weight applied to the risk score for entities
    /// in this watchlist.
    /// The default is 1.0 if it is not specified.
    /// </summary>
    [TerraformPropertyName("multiplying_factor")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MultiplyingFactor { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Optional. The ID to use for the watchlist,
    /// which will become the final component of the watchlist&#39;s resource name.
    /// This value should be 4-63 characters, and valid characters
    /// are /a-z-/.
    /// </summary>
    [TerraformPropertyName("watchlist_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> WatchlistId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "watchlist_id");

    /// <summary>
    /// Block for entity_population_mechanism.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityPopulationMechanism is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EntityPopulationMechanism block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EntityPopulationMechanism block(s) allowed")]
    [TerraformPropertyName("entity_population_mechanism")]
    public TerraformList<TerraformBlock<GoogleChronicleWatchlistEntityPopulationMechanismBlock>>? EntityPopulationMechanism { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleChronicleWatchlistTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for watchlist_user_preferences.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WatchlistUserPreferences block(s) allowed")]
    [TerraformPropertyName("watchlist_user_preferences")]
    public TerraformList<TerraformBlock<GoogleChronicleWatchlistWatchlistUserPreferencesBlock>>? WatchlistUserPreferences { get; set; } = new();

    /// <summary>
    /// Output only. Time the watchlist was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Count of different types of entities in the watchlist.
    /// </summary>
    [TerraformPropertyName("entity_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EntityCount => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "entity_count");

    /// <summary>
    /// Identifier. Resource name of the watchlist. This unique identifier is generated using values provided for the URL parameters.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Output only. Time the watchlist was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
