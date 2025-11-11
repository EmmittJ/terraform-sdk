using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for server_side_encryption in .
/// Nesting mode: list
/// </summary>
public class AwsDynamodbTableDataSourceServerSideEncryptionBlock
{


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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// Block for server_side_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryption block(s) allowed")]
    [TerraformPropertyName("server_side_encryption")]
    public TerraformList<TerraformBlock<AwsDynamodbTableDataSourceServerSideEncryptionBlock>>? ServerSideEncryption { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The attribute attribute.
    /// </summary>
    [TerraformPropertyName("attribute")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> Attribute => new TerraformReference(this, "attribute");

    /// <summary>
    /// The billing_mode attribute.
    /// </summary>
    [TerraformPropertyName("billing_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BillingMode => new TerraformReference(this, "billing_mode");

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    [TerraformPropertyName("deletion_protection_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DeletionProtectionEnabled => new TerraformReference(this, "deletion_protection_enabled");

    /// <summary>
    /// The global_secondary_index attribute.
    /// </summary>
    [TerraformPropertyName("global_secondary_index")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> GlobalSecondaryIndex => new TerraformReference(this, "global_secondary_index");

    /// <summary>
    /// The hash_key attribute.
    /// </summary>
    [TerraformPropertyName("hash_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HashKey => new TerraformReference(this, "hash_key");

    /// <summary>
    /// The local_secondary_index attribute.
    /// </summary>
    [TerraformPropertyName("local_secondary_index")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> LocalSecondaryIndex => new TerraformReference(this, "local_secondary_index");

    /// <summary>
    /// The on_demand_throughput attribute.
    /// </summary>
    [TerraformPropertyName("on_demand_throughput")]
    // Output-only attribute - read-only reference
    public TerraformList<object> OnDemandThroughput => new TerraformReference(this, "on_demand_throughput");

    /// <summary>
    /// The point_in_time_recovery attribute.
    /// </summary>
    [TerraformPropertyName("point_in_time_recovery")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PointInTimeRecovery => new TerraformReference(this, "point_in_time_recovery");

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    [TerraformPropertyName("range_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RangeKey => new TerraformReference(this, "range_key");

    /// <summary>
    /// The read_capacity attribute.
    /// </summary>
    [TerraformPropertyName("read_capacity")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ReadCapacity => new TerraformReference(this, "read_capacity");

    /// <summary>
    /// The replica attribute.
    /// </summary>
    [TerraformPropertyName("replica")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> Replica => new TerraformReference(this, "replica");

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    [TerraformPropertyName("stream_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StreamArn => new TerraformReference(this, "stream_arn");

    /// <summary>
    /// The stream_enabled attribute.
    /// </summary>
    [TerraformPropertyName("stream_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> StreamEnabled => new TerraformReference(this, "stream_enabled");

    /// <summary>
    /// The stream_label attribute.
    /// </summary>
    [TerraformPropertyName("stream_label")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StreamLabel => new TerraformReference(this, "stream_label");

    /// <summary>
    /// The stream_view_type attribute.
    /// </summary>
    [TerraformPropertyName("stream_view_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StreamViewType => new TerraformReference(this, "stream_view_type");

    /// <summary>
    /// The table_class attribute.
    /// </summary>
    [TerraformPropertyName("table_class")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TableClass => new TerraformReference(this, "table_class");

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [TerraformPropertyName("ttl")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> Ttl => new TerraformReference(this, "ttl");

    /// <summary>
    /// The warm_throughput attribute.
    /// </summary>
    [TerraformPropertyName("warm_throughput")]
    // Output-only attribute - read-only reference
    public TerraformList<object> WarmThroughput => new TerraformReference(this, "warm_throughput");

    /// <summary>
    /// The write_capacity attribute.
    /// </summary>
    [TerraformPropertyName("write_capacity")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> WriteCapacity => new TerraformReference(this, "write_capacity");

}
