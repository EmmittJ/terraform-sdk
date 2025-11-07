using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_chronicle_watchlist resource.
/// </summary>
public class GoogleChronicleWatchlist : TerraformResource
{
    public GoogleChronicleWatchlist(string name) : base("google_chronicle_watchlist", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("entity_count");
        this.DeclareOutput("name");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Optional. Description of the watchlist.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Required. Display name of the watchlist.
    /// Note that it must be at least one character and less than 63 characters
    /// (https://google.aip.dev/148).
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    public TerraformProperty<string>? Instance
    {
        get => GetProperty<TerraformProperty<string>>("instance");
        set => this.WithProperty("instance", value);
    }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Optional. Weight applied to the risk score for entities
    /// in this watchlist.
    /// The default is 1.0 if it is not specified.
    /// </summary>
    public TerraformProperty<double>? MultiplyingFactor
    {
        get => GetProperty<TerraformProperty<double>>("multiplying_factor");
        set => this.WithProperty("multiplying_factor", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Optional. The ID to use for the watchlist,
    /// which will become the final component of the watchlist&#39;s resource name.
    /// This value should be 4-63 characters, and valid characters
    /// are /a-z-/.
    /// </summary>
    public TerraformProperty<string>? WatchlistId
    {
        get => GetProperty<TerraformProperty<string>>("watchlist_id");
        set => this.WithProperty("watchlist_id", value);
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
