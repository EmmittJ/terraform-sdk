using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSccV2ProjectSccBigQueryExportTimeoutsBlock : TerraformBlock
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
/// Manages a google_scc_v2_project_scc_big_query_export resource.
/// </summary>
public class GoogleSccV2ProjectSccBigQueryExport : TerraformResource
{
    public GoogleSccV2ProjectSccBigQueryExport(string name) : base("google_scc_v2_project_scc_big_query_export", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("most_recent_editor");
        this.WithOutput("name");
        this.WithOutput("principal");
        this.WithOutput("update_time");
    }

    /// <summary>
    /// This must be unique within the organization.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BigQueryExportId is required")]
    public required TerraformProperty<string> BigQueryExportId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("big_query_export_id");
        set => this.WithProperty("big_query_export_id", value);
    }

    /// <summary>
    /// The dataset to write findings&#39; updates to.
    /// Its format is &amp;quot;projects/[projectId]/datasets/[bigquery_dataset_id]&amp;quot;.
    /// BigQuery Dataset unique ID must contain only letters (a-z, A-Z), numbers (0-9), or underscores (_).
    /// </summary>
    public TerraformProperty<string>? Dataset
    {
        get => GetProperty<TerraformProperty<string>>("dataset");
        set => this.WithProperty("dataset", value);
    }

    /// <summary>
    /// The description of the notification config (max of 1024 characters).
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Expression that defines the filter to apply across create/update
    /// events of findings. The
    /// expression is a list of zero or more restrictions combined via
    /// logical operators AND and OR. Parentheses are supported, and OR
    /// has higher precedence than AND.
    /// 
    /// Restrictions have the form &amp;lt;field&amp;gt; &amp;lt;operator&amp;gt; &amp;lt;value&amp;gt; and may have
    /// a - character in front of them to indicate negation. The fields
    /// map to those defined in the corresponding resource.
    /// 
    /// The supported operators are:
    /// 
    /// * = for all value types.
    /// * &amp;gt;, &amp;lt;, &amp;gt;=, &amp;lt;= for integer values.
    /// * :, meaning substring matching, for strings.
    /// 
    /// The supported value types are:
    /// 
    /// * string literals in quotes.
    /// * integer literals without quotes.
    /// * boolean literals true and false without quotes.
    /// 
    /// See
    /// [Filtering notifications](https://cloud.google.com/security-command-center/docs/how-to-api-filter-notifications)
    /// for information on how to write a filter.
    /// </summary>
    public TerraformProperty<string>? Filter
    {
        get => GetProperty<TerraformProperty<string>>("filter");
        set => this.WithProperty("filter", value);
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
    /// location Id is provided by organization. If not provided, Use global as default.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleSccV2ProjectSccBigQueryExportTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleSccV2ProjectSccBigQueryExportTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The time at which the BigQuery export was created. This field is set by the server and will be ignored if provided on export on creation.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Email address of the user who last edited the BigQuery export.
    /// This field is set by the server and will be ignored if provided on export creation or update.
    /// </summary>
    public TerraformExpression MostRecentEditor => this["most_recent_editor"];

    /// <summary>
    /// The resource name of this export, in the format
    /// &#39;projects/{{project}}/locations/{{location}}/bigQueryExports/{{big_query_export_id}}&#39;.
    /// This field is provided in responses, and is ignored when provided in create requests.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The service account that needs permission to create table and upload data to the BigQuery dataset.
    /// </summary>
    public TerraformExpression Principal => this["principal"];

    /// <summary>
    /// The most recent time at which the BigQuery export was updated. This field is set by the server and will be ignored if provided on export creation or update.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
