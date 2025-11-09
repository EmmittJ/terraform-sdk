using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_logging_metric resource.
/// </summary>
public class GoogleLoggingMetric : TerraformResource
{
    public GoogleLoggingMetric(string name) : base("google_logging_metric", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The resource name of the Log Bucket that owns the Log Metric. Only Log Buckets in projects
    /// are supported. The bucket has to be in the same project as the metric.
    /// </summary>
    public TerraformProperty<string>? BucketName
    {
        get => GetProperty<TerraformProperty<string>>("bucket_name");
        set => this.WithProperty("bucket_name", value);
    }

    /// <summary>
    /// A description of this metric, which is used in documentation. The maximum length of the
    /// description is 8000 characters.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// If set to True, then this metric is disabled and it does not generate any points.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
    }

    /// <summary>
    /// An advanced logs filter (https://cloud.google.com/logging/docs/view/advanced-filters) which
    /// is used to match log entries.
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
    /// A map from a label key string to an extractor expression which is used to extract data from a log
    /// entry field and assign as the label value. Each label key specified in the LabelDescriptor must
    /// have an associated extractor expression in this map. The syntax of the extractor expression is
    /// the same as for the valueExtractor field.
    /// </summary>
    public TerraformMapProperty<string>? LabelExtractors
    {
        get => GetProperty<TerraformMapProperty<string>>("label_extractors");
        set => this.WithProperty("label_extractors", value);
    }

    /// <summary>
    /// The client-assigned metric identifier. Examples - &amp;quot;error_count&amp;quot;, &amp;quot;nginx/requests&amp;quot;.
    /// Metric identifiers are limited to 100 characters and can include only the following
    /// characters A-Z, a-z, 0-9, and the special characters _-.,+!*&#39;,()%/. The forward-slash
    /// character (/) denotes a hierarchy of name pieces, and it cannot be the first character
    /// of the name.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// A valueExtractor is required when using a distribution logs-based metric to extract the values to
    /// record from a log entry. Two functions are supported for value extraction - EXTRACT(field) or
    /// REGEXP_EXTRACT(field, regex). The argument are 1. field - The name of the log entry field from which
    /// the value is to be extracted. 2. regex - A regular expression using the Google RE2 syntax
    /// (https://github.com/google/re2/wiki/Syntax) with a single capture group to extract data from the specified
    /// log entry field. The value of the field is converted to a string before applying the regex. It is an
    /// error to specify a regex that does not include exactly one capture group.
    /// </summary>
    public TerraformProperty<string>? ValueExtractor
    {
        get => GetProperty<TerraformProperty<string>>("value_extractor");
        set => this.WithProperty("value_extractor", value);
    }

}
