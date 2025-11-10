using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for discovery_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleDataplexZoneDiscoverySpecBlock : TerraformBlock
{
    /// <summary>
    /// Required. Whether discovery is enabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// Optional. The list of patterns to apply for selecting data to exclude during discovery. For Cloud Storage bucket assets, these are interpreted as glob patterns used to match object names. For BigQuery dataset assets, these are interpreted as patterns to match table names.
    /// </summary>
    public List<TerraformProperty<string>>? ExcludePatterns
    {
        get => GetProperty<List<TerraformProperty<string>>>("exclude_patterns");
        set => WithProperty("exclude_patterns", value);
    }

    /// <summary>
    /// Optional. The list of patterns to apply for selecting data to include during discovery if only a subset of the data should considered. For Cloud Storage bucket assets, these are interpreted as glob patterns used to match object names. For BigQuery dataset assets, these are interpreted as patterns to match table names.
    /// </summary>
    public List<TerraformProperty<string>>? IncludePatterns
    {
        get => GetProperty<List<TerraformProperty<string>>>("include_patterns");
        set => WithProperty("include_patterns", value);
    }

    /// <summary>
    /// Optional. Cron schedule (https://en.wikipedia.org/wiki/Cron) for running discovery periodically. Successive discovery runs must be scheduled at least 60 minutes apart. The default value is to run discovery every 60 minutes. To explicitly set a timezone to the cron tab, apply a prefix in the cron tab: &amp;quot;CRON_TZ=${IANA_TIME_ZONE}&amp;quot; or TZ=${IANA_TIME_ZONE}&amp;quot;. The ${IANA_TIME_ZONE} may only be a valid string from IANA time zone database. For example, &amp;quot;CRON_TZ=America/New_York 1 * * * *&amp;quot;, or &amp;quot;TZ=America/New_York 1 * * * *&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Schedule
    {
        get => GetProperty<TerraformProperty<string>>("schedule");
        set => WithProperty("schedule", value);
    }

}

/// <summary>
/// Block type for resource_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleDataplexZoneResourceSpecBlock : TerraformBlock
{
    /// <summary>
    /// Required. Immutable. The location type of the resources that are allowed to be attached to the assets within this zone. Possible values: LOCATION_TYPE_UNSPECIFIED, SINGLE_REGION, MULTI_REGION
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationType is required")]
    public required TerraformProperty<string> LocationType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location_type");
        set => WithProperty("location_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataplexZoneTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_dataplex_zone resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataplexZone : TerraformResource
{
    public GoogleDataplexZone(string name) : base("google_dataplex_zone", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("asset_status");
        this.WithOutput("create_time");
        this.WithOutput("effective_labels");
        this.WithOutput("state");
        this.WithOutput("terraform_labels");
        this.WithOutput("uid");
        this.WithOutput("update_time");
    }

    /// <summary>
    /// Optional. Description of the zone.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Optional. User friendly display name.
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
    /// Optional. User defined labels for the zone.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field `effective_labels` for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The lake for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lake is required")]
    public required TerraformProperty<string> Lake
    {
        get => GetRequiredProperty<TerraformProperty<string>>("lake");
        set => this.WithProperty("lake", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name of the zone.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project for the resource
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Required. Immutable. The type of the zone. Possible values: TYPE_UNSPECIFIED, RAW, CURATED
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for discovery_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DiscoverySpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DiscoverySpec block(s) allowed")]
    public List<GoogleDataplexZoneDiscoverySpecBlock>? DiscoverySpec
    {
        get => GetProperty<List<GoogleDataplexZoneDiscoverySpecBlock>>("discovery_spec");
        set => this.WithProperty("discovery_spec", value);
    }

    /// <summary>
    /// Block for resource_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ResourceSpec block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceSpec block(s) allowed")]
    public List<GoogleDataplexZoneResourceSpecBlock>? ResourceSpec
    {
        get => GetProperty<List<GoogleDataplexZoneResourceSpecBlock>>("resource_spec");
        set => this.WithProperty("resource_spec", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataplexZoneTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDataplexZoneTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. Aggregated status of the underlying assets of the zone.
    /// </summary>
    public TerraformExpression AssetStatus => this["asset_status"];

    /// <summary>
    /// Output only. The time when the zone was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Output only. Current state of the zone. Possible values: STATE_UNSPECIFIED, ACTIVE, CREATING, DELETING, ACTION_REQUIRED
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Output only. System generated globally unique ID for the zone. This ID will be different if the zone is deleted and re-created with the same name.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Output only. The time when the zone was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
