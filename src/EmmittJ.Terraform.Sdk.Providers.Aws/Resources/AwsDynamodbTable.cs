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
    public TerraformLiteralProperty<string>? BillingMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("billing_mode");
        set => this.WithProperty("billing_mode", value);
    }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DeletionProtectionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("deletion_protection_enabled");
        set => this.WithProperty("deletion_protection_enabled", value);
    }

    /// <summary>
    /// The hash_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HashKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hash_key");
        set => this.WithProperty("hash_key", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RangeKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("range_key");
        set => this.WithProperty("range_key", value);
    }

    /// <summary>
    /// The read_capacity attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? ReadCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("read_capacity");
        set => this.WithProperty("read_capacity", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The restore_date_time attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RestoreDateTime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("restore_date_time");
        set => this.WithProperty("restore_date_time", value);
    }

    /// <summary>
    /// The restore_source_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RestoreSourceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("restore_source_name");
        set => this.WithProperty("restore_source_name", value);
    }

    /// <summary>
    /// The restore_source_table_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RestoreSourceTableArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("restore_source_table_arn");
        set => this.WithProperty("restore_source_table_arn", value);
    }

    /// <summary>
    /// The restore_to_latest_time attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? RestoreToLatestTime
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("restore_to_latest_time");
        set => this.WithProperty("restore_to_latest_time", value);
    }

    /// <summary>
    /// The stream_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? StreamEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("stream_enabled");
        set => this.WithProperty("stream_enabled", value);
    }

    /// <summary>
    /// The stream_view_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StreamViewType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_view_type");
        set => this.WithProperty("stream_view_type", value);
    }

    /// <summary>
    /// The table_class attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TableClass
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table_class");
        set => this.WithProperty("table_class", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The write_capacity attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? WriteCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("write_capacity");
        set => this.WithProperty("write_capacity", value);
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
