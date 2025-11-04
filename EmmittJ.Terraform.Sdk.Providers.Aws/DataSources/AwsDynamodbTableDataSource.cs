using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dynamodb_table.
/// </summary>
public class AwsDynamodbTableDataSource : TerraformDataSource
{
    public AwsDynamodbTableDataSource(string name) : base("aws_dynamodb_table", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("attribute");
        this.DeclareOutput("billing_mode");
        this.DeclareOutput("deletion_protection_enabled");
        this.DeclareOutput("global_secondary_index");
        this.DeclareOutput("hash_key");
        this.DeclareOutput("local_secondary_index");
        this.DeclareOutput("on_demand_throughput");
        this.DeclareOutput("point_in_time_recovery");
        this.DeclareOutput("range_key");
        this.DeclareOutput("read_capacity");
        this.DeclareOutput("replica");
        this.DeclareOutput("stream_arn");
        this.DeclareOutput("stream_enabled");
        this.DeclareOutput("stream_label");
        this.DeclareOutput("stream_view_type");
        this.DeclareOutput("table_class");
        this.DeclareOutput("ttl");
        this.DeclareOutput("warm_throughput");
        this.DeclareOutput("write_capacity");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The attribute attribute.
    /// </summary>
    public TerraformExpression Attribute => this["attribute"];

    /// <summary>
    /// The billing_mode attribute.
    /// </summary>
    public TerraformExpression BillingMode => this["billing_mode"];

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    public TerraformExpression DeletionProtectionEnabled => this["deletion_protection_enabled"];

    /// <summary>
    /// The global_secondary_index attribute.
    /// </summary>
    public TerraformExpression GlobalSecondaryIndex => this["global_secondary_index"];

    /// <summary>
    /// The hash_key attribute.
    /// </summary>
    public TerraformExpression HashKey => this["hash_key"];

    /// <summary>
    /// The local_secondary_index attribute.
    /// </summary>
    public TerraformExpression LocalSecondaryIndex => this["local_secondary_index"];

    /// <summary>
    /// The on_demand_throughput attribute.
    /// </summary>
    public TerraformExpression OnDemandThroughput => this["on_demand_throughput"];

    /// <summary>
    /// The point_in_time_recovery attribute.
    /// </summary>
    public TerraformExpression PointInTimeRecovery => this["point_in_time_recovery"];

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    public TerraformExpression RangeKey => this["range_key"];

    /// <summary>
    /// The read_capacity attribute.
    /// </summary>
    public TerraformExpression ReadCapacity => this["read_capacity"];

    /// <summary>
    /// The replica attribute.
    /// </summary>
    public TerraformExpression Replica => this["replica"];

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    public TerraformExpression StreamArn => this["stream_arn"];

    /// <summary>
    /// The stream_enabled attribute.
    /// </summary>
    public TerraformExpression StreamEnabled => this["stream_enabled"];

    /// <summary>
    /// The stream_label attribute.
    /// </summary>
    public TerraformExpression StreamLabel => this["stream_label"];

    /// <summary>
    /// The stream_view_type attribute.
    /// </summary>
    public TerraformExpression StreamViewType => this["stream_view_type"];

    /// <summary>
    /// The table_class attribute.
    /// </summary>
    public TerraformExpression TableClass => this["table_class"];

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformExpression Ttl => this["ttl"];

    /// <summary>
    /// The warm_throughput attribute.
    /// </summary>
    public TerraformExpression WarmThroughput => this["warm_throughput"];

    /// <summary>
    /// The write_capacity attribute.
    /// </summary>
    public TerraformExpression WriteCapacity => this["write_capacity"];

}
