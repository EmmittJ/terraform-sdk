using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for entity_population_mechanism in .
/// Nesting mode: list
/// </summary>
public class GoogleChronicleWatchlistEntityPopulationMechanismBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleChronicleWatchlistTimeoutsBlock : TerraformBlock
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
/// Block type for watchlist_user_preferences in .
/// Nesting mode: list
/// </summary>
public class GoogleChronicleWatchlistWatchlistUserPreferencesBlock : TerraformBlock
{
    /// <summary>
    /// Optional. Whether the watchlist is pinned on the dashboard.
    /// </summary>
    public TerraformProperty<bool>? Pinned
    {
        set => SetProperty("pinned", value);
    }

}

/// <summary>
/// Manages a google_chronicle_watchlist resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleChronicleWatchlist : TerraformResource
{
    public GoogleChronicleWatchlist(string name) : base("google_chronicle_watchlist", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("entity_count");
        SetOutput("name");
        SetOutput("update_time");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("instance");
        SetOutput("location");
        SetOutput("multiplying_factor");
        SetOutput("project");
        SetOutput("watchlist_id");
    }

    /// <summary>
    /// Optional. Description of the watchlist.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Required. Display name of the watchlist.
    /// Note that it must be at least one character and less than 63 characters
    /// (https://google.aip.dev/148).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformProperty<string> Instance
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance");
        set => SetProperty("instance", value);
    }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Optional. Weight applied to the risk score for entities
    /// in this watchlist.
    /// The default is 1.0 if it is not specified.
    /// </summary>
    public TerraformProperty<double> MultiplyingFactor
    {
        get => GetRequiredOutput<TerraformProperty<double>>("multiplying_factor");
        set => SetProperty("multiplying_factor", value);
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
    /// Optional. The ID to use for the watchlist,
    /// which will become the final component of the watchlist&#39;s resource name.
    /// This value should be 4-63 characters, and valid characters
    /// are /a-z-/.
    /// </summary>
    public TerraformProperty<string> WatchlistId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("watchlist_id");
        set => SetProperty("watchlist_id", value);
    }

    /// <summary>
    /// Block for entity_population_mechanism.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityPopulationMechanism is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EntityPopulationMechanism block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EntityPopulationMechanism block(s) allowed")]
    public List<GoogleChronicleWatchlistEntityPopulationMechanismBlock>? EntityPopulationMechanism
    {
        set => SetProperty("entity_population_mechanism", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleChronicleWatchlistTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for watchlist_user_preferences.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WatchlistUserPreferences block(s) allowed")]
    public List<GoogleChronicleWatchlistWatchlistUserPreferencesBlock>? WatchlistUserPreferences
    {
        set => SetProperty("watchlist_user_preferences", value);
    }

    /// <summary>
    /// Output only. Time the watchlist was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Count of different types of entities in the watchlist.
    /// </summary>
    public TerraformExpression EntityCount => this["entity_count"];

    /// <summary>
    /// Identifier. Resource name of the watchlist. This unique identifier is generated using values provided for the URL parameters.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/watchlists/{watchlist}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. Time the watchlist was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
