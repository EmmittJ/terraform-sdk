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
        set => SetProperty("dataset_id", value);
    }

    /// <summary>
    /// The assigned project ID of the project.
    /// </summary>
    public TerraformProperty<string>? ProjectId
    {
        set => SetProperty("project_id", value);
    }

    /// <summary>
    /// The ID of the table in the above dataset.
    /// </summary>
    public TerraformProperty<string>? TableId
    {
        set => SetProperty("table_id", value);
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
        SetOutput("name");
        SetOutput("update_time");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project");
        SetOutput("size");
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
    /// LOCATION_DESCRIPTION
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// Size of a reservation, in bytes.
    /// </summary>
    public TerraformProperty<double> Size
    {
        get => GetRequiredOutput<TerraformProperty<double>>("size");
        set => SetProperty("size", value);
    }

    /// <summary>
    /// Block for preferred_tables.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleBigqueryBiReservationPreferredTablesBlock>? PreferredTables
    {
        set => SetProperty("preferred_tables", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigqueryBiReservationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
