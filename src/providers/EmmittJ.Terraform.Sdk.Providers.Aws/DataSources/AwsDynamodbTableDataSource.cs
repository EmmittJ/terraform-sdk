using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for server_side_encryption in .
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableDataSourceServerSideEncryptionBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Enabled => new TerraformReferenceProperty<TerraformProperty<bool>>("", "enabled");

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyArn => new TerraformReferenceProperty<TerraformProperty<string>>("", "kms_key_arn");

}

/// <summary>
/// Retrieves information about a aws_dynamodb_table.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDynamodbTableDataSource : TerraformDataSource
{
    public AwsDynamodbTableDataSource(string name) : base("aws_dynamodb_table", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// Block for server_side_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryption block(s) allowed")]
    [TerraformPropertyName("server_side_encryption")]
    public TerraformList<TerraformBlock<AwsDynamodbTableDataSourceServerSideEncryptionBlock>>? ServerSideEncryption { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The attribute attribute.
    /// </summary>
    [TerraformPropertyName("attribute")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Attribute => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "attribute");

    /// <summary>
    /// The billing_mode attribute.
    /// </summary>
    [TerraformPropertyName("billing_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BillingMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "billing_mode");

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    [TerraformPropertyName("deletion_protection_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DeletionProtectionEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "deletion_protection_enabled");

    /// <summary>
    /// The global_secondary_index attribute.
    /// </summary>
    [TerraformPropertyName("global_secondary_index")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> GlobalSecondaryIndex => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "global_secondary_index");

    /// <summary>
    /// The hash_key attribute.
    /// </summary>
    [TerraformPropertyName("hash_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HashKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hash_key");

    /// <summary>
    /// The local_secondary_index attribute.
    /// </summary>
    [TerraformPropertyName("local_secondary_index")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> LocalSecondaryIndex => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "local_secondary_index");

    /// <summary>
    /// The on_demand_throughput attribute.
    /// </summary>
    [TerraformPropertyName("on_demand_throughput")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> OnDemandThroughput => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "on_demand_throughput");

    /// <summary>
    /// The point_in_time_recovery attribute.
    /// </summary>
    [TerraformPropertyName("point_in_time_recovery")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PointInTimeRecovery => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "point_in_time_recovery");

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    [TerraformPropertyName("range_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RangeKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "range_key");

    /// <summary>
    /// The read_capacity attribute.
    /// </summary>
    [TerraformPropertyName("read_capacity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ReadCapacity => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "read_capacity");

    /// <summary>
    /// The replica attribute.
    /// </summary>
    [TerraformPropertyName("replica")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Replica => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "replica");

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    [TerraformPropertyName("stream_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StreamArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "stream_arn");

    /// <summary>
    /// The stream_enabled attribute.
    /// </summary>
    [TerraformPropertyName("stream_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> StreamEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "stream_enabled");

    /// <summary>
    /// The stream_label attribute.
    /// </summary>
    [TerraformPropertyName("stream_label")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StreamLabel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "stream_label");

    /// <summary>
    /// The stream_view_type attribute.
    /// </summary>
    [TerraformPropertyName("stream_view_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StreamViewType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "stream_view_type");

    /// <summary>
    /// The table_class attribute.
    /// </summary>
    [TerraformPropertyName("table_class")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TableClass => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "table_class");

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [TerraformPropertyName("ttl")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Ttl => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "ttl");

    /// <summary>
    /// The warm_throughput attribute.
    /// </summary>
    [TerraformPropertyName("warm_throughput")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> WarmThroughput => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "warm_throughput");

    /// <summary>
    /// The write_capacity attribute.
    /// </summary>
    [TerraformPropertyName("write_capacity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> WriteCapacity => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "write_capacity");

}
