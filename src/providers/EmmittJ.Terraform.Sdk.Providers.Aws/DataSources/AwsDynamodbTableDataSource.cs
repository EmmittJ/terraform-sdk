using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for server_side_encryption in .
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableDataSourceServerSideEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        set => SetProperty("kms_key_arn", value);
    }

}

/// <summary>
/// Retrieves information about a aws_dynamodb_table.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDynamodbTableDataSource : TerraformDataSource
{
    public AwsDynamodbTableDataSource(string name) : base("aws_dynamodb_table", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("attribute");
        SetOutput("billing_mode");
        SetOutput("deletion_protection_enabled");
        SetOutput("global_secondary_index");
        SetOutput("hash_key");
        SetOutput("local_secondary_index");
        SetOutput("on_demand_throughput");
        SetOutput("point_in_time_recovery");
        SetOutput("range_key");
        SetOutput("read_capacity");
        SetOutput("replica");
        SetOutput("stream_arn");
        SetOutput("stream_enabled");
        SetOutput("stream_label");
        SetOutput("stream_view_type");
        SetOutput("table_class");
        SetOutput("ttl");
        SetOutput("warm_throughput");
        SetOutput("write_capacity");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for server_side_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryption block(s) allowed")]
    public List<AwsDynamodbTableDataSourceServerSideEncryptionBlock>? ServerSideEncryption
    {
        set => SetProperty("server_side_encryption", value);
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
