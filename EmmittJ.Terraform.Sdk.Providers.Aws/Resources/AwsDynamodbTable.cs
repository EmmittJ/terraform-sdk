using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_dynamodb_table resource.
/// </summary>
public class AwsDynamodbTable : TerraformResource
{
    public AwsDynamodbTable(string name) : base("aws_dynamodb_table", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("stream_arn");
        this.DeclareOutput("stream_label");
    }

    /// <summary>
    /// The billing_mode attribute.
    /// </summary>
    public string? BillingMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("billing_mode")?.Value;
        set => this.WithProperty("billing_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    public bool? DeletionProtectionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("deletion_protection_enabled")?.Value;
        set => this.WithProperty("deletion_protection_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The hash_key attribute.
    /// </summary>
    public string? HashKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hash_key")?.Value;
        set => this.WithProperty("hash_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    public string? RangeKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("range_key")?.Value;
        set => this.WithProperty("range_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The read_capacity attribute.
    /// </summary>
    public double? ReadCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("read_capacity")?.Value;
        set => this.WithProperty("read_capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The restore_date_time attribute.
    /// </summary>
    public string? RestoreDateTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("restore_date_time")?.Value;
        set => this.WithProperty("restore_date_time", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The restore_source_name attribute.
    /// </summary>
    public string? RestoreSourceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("restore_source_name")?.Value;
        set => this.WithProperty("restore_source_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The restore_source_table_arn attribute.
    /// </summary>
    public string? RestoreSourceTableArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("restore_source_table_arn")?.Value;
        set => this.WithProperty("restore_source_table_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The restore_to_latest_time attribute.
    /// </summary>
    public bool? RestoreToLatestTime
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("restore_to_latest_time")?.Value;
        set => this.WithProperty("restore_to_latest_time", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The stream_enabled attribute.
    /// </summary>
    public bool? StreamEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("stream_enabled")?.Value;
        set => this.WithProperty("stream_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The stream_view_type attribute.
    /// </summary>
    public string? StreamViewType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_view_type")?.Value;
        set => this.WithProperty("stream_view_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The table_class attribute.
    /// </summary>
    public string? TableClass
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table_class")?.Value;
        set => this.WithProperty("table_class", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The write_capacity attribute.
    /// </summary>
    public double? WriteCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("write_capacity")?.Value;
        set => this.WithProperty("write_capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    public TerraformExpression StreamArn => this["stream_arn"];

    /// <summary>
    /// The stream_label attribute.
    /// </summary>
    public TerraformExpression StreamLabel => this["stream_label"];

}
