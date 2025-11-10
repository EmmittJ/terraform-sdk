using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for preferred_tables in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryBiReservationPreferredTablesBlock : TerraformBlock
{
    /// <summary>
    /// The ID of the dataset in the above project.
    /// </summary>
    public TerraformProperty<string>? DatasetId
    {
        get => GetProperty<TerraformProperty<string>>("dataset_id");
        set => WithProperty("dataset_id", value);
    }

    /// <summary>
    /// The assigned project ID of the project.
    /// </summary>
    public TerraformProperty<string>? ProjectId
    {
        get => GetProperty<TerraformProperty<string>>("project_id");
        set => WithProperty("project_id", value);
    }

    /// <summary>
    /// The ID of the table in the above dataset.
    /// </summary>
    public TerraformProperty<string>? TableId
    {
        get => GetProperty<TerraformProperty<string>>("table_id");
        set => WithProperty("table_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryBiReservationTimeoutsBlock : TerraformBlock
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
/// Manages a google_bigquery_bi_reservation resource.
/// </summary>
public class GoogleBigqueryBiReservation : TerraformResource
{
    public GoogleBigqueryBiReservation(string name) : base("google_bigquery_bi_reservation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("name");
        this.WithOutput("update_time");
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
    /// LOCATION_DESCRIPTION
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// Size of a reservation, in bytes.
    /// </summary>
    public TerraformProperty<double>? Size
    {
        get => GetProperty<TerraformProperty<double>>("size");
        set => this.WithProperty("size", value);
    }

    /// <summary>
    /// Block for preferred_tables.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleBigqueryBiReservationPreferredTablesBlock>? PreferredTables
    {
        get => GetProperty<List<GoogleBigqueryBiReservationPreferredTablesBlock>>("preferred_tables");
        set => this.WithProperty("preferred_tables", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigqueryBiReservationTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleBigqueryBiReservationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The resource name of the singleton BI reservation. Reservation names have the form &#39;projects/{projectId}/locations/{locationId}/biReservation&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The last update timestamp of a reservation.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
