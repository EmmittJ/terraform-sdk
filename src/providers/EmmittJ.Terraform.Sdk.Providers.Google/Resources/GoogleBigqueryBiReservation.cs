using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for preferred_tables in GoogleBigqueryBiReservation.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryBiReservationPreferredTablesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "preferred_tables";

    /// <summary>
    /// The ID of the dataset in the above project.
    /// </summary>
    public TerraformValue<string>? DatasetId
    {
        get => GetArgument<TerraformValue<string>>("dataset_id");
        set => SetArgument("dataset_id", value);
    }

    /// <summary>
    /// The assigned project ID of the project.
    /// </summary>
    public TerraformValue<string>? ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// The ID of the table in the above dataset.
    /// </summary>
    public TerraformValue<string>? TableId
    {
        get => GetArgument<TerraformValue<string>>("table_id");
        set => SetArgument("table_id", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBigqueryBiReservation.
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryBiReservationTimeoutsBlock : TerraformBlock
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
/// Represents a google_bigquery_bi_reservation Terraform resource.
/// Manages a google_bigquery_bi_reservation resource.
/// </summary>
public partial class GoogleBigqueryBiReservation(string name) : TerraformResource("google_bigquery_bi_reservation", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// LOCATION_DESCRIPTION
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Size of a reservation, in bytes.
    /// </summary>
    public TerraformValue<double>? Size
    {
        get => GetArgument<TerraformValue<double>>("size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The resource name of the singleton BI reservation. Reservation names have the form &#39;projects/{projectId}/locations/{locationId}/biReservation&#39;.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The last update timestamp of a reservation.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// PreferredTables block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleBigqueryBiReservationPreferredTablesBlock>? PreferredTables
    {
        get => GetArgument<TerraformList<GoogleBigqueryBiReservationPreferredTablesBlock>>("preferred_tables");
        set => SetArgument("preferred_tables", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBigqueryBiReservationTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBigqueryBiReservationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
