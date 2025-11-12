using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for server_side_encryption in .
/// Nesting mode: list
/// </summary>
public partial class AwsDynamodbTableDataSourceServerSideEncryptionBlock() : TerraformBlock("server_side_encryption")
{


}

/// <summary>
/// Retrieves information about a aws_dynamodb_table.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsDynamodbTableDataSource : TerraformDataSource
{
    public AwsDynamodbTableDataSource(string name) : base("aws_dynamodb_table", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// Block for server_side_encryption.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerSideEncryption block(s) allowed")]
    [TerraformProperty("server_side_encryption")]
    public TerraformList<AwsDynamodbTableDataSourceServerSideEncryptionBlock> ServerSideEncryption { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The attribute attribute.
    /// </summary>
    [TerraformProperty("attribute")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> Attribute { get; }

    /// <summary>
    /// The billing_mode attribute.
    /// </summary>
    [TerraformProperty("billing_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BillingMode { get; }

    /// <summary>
    /// The deletion_protection_enabled attribute.
    /// </summary>
    [TerraformProperty("deletion_protection_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DeletionProtectionEnabled { get; }

    /// <summary>
    /// The global_secondary_index attribute.
    /// </summary>
    [TerraformProperty("global_secondary_index")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> GlobalSecondaryIndex { get; }

    /// <summary>
    /// The hash_key attribute.
    /// </summary>
    [TerraformProperty("hash_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HashKey { get; }

    /// <summary>
    /// The local_secondary_index attribute.
    /// </summary>
    [TerraformProperty("local_secondary_index")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> LocalSecondaryIndex { get; }

    /// <summary>
    /// The on_demand_throughput attribute.
    /// </summary>
    [TerraformProperty("on_demand_throughput")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> OnDemandThroughput { get; }

    /// <summary>
    /// The point_in_time_recovery attribute.
    /// </summary>
    [TerraformProperty("point_in_time_recovery")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PointInTimeRecovery { get; }

    /// <summary>
    /// The range_key attribute.
    /// </summary>
    [TerraformProperty("range_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RangeKey { get; }

    /// <summary>
    /// The read_capacity attribute.
    /// </summary>
    [TerraformProperty("read_capacity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ReadCapacity { get; }

    /// <summary>
    /// The replica attribute.
    /// </summary>
    [TerraformProperty("replica")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> Replica { get; }

    /// <summary>
    /// The stream_arn attribute.
    /// </summary>
    [TerraformProperty("stream_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StreamArn { get; }

    /// <summary>
    /// The stream_enabled attribute.
    /// </summary>
    [TerraformProperty("stream_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> StreamEnabled { get; }

    /// <summary>
    /// The stream_label attribute.
    /// </summary>
    [TerraformProperty("stream_label")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StreamLabel { get; }

    /// <summary>
    /// The stream_view_type attribute.
    /// </summary>
    [TerraformProperty("stream_view_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StreamViewType { get; }

    /// <summary>
    /// The table_class attribute.
    /// </summary>
    [TerraformProperty("table_class")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TableClass { get; }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [TerraformProperty("ttl")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> Ttl { get; }

    /// <summary>
    /// The warm_throughput attribute.
    /// </summary>
    [TerraformProperty("warm_throughput")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> WarmThroughput { get; }

    /// <summary>
    /// The write_capacity attribute.
    /// </summary>
    [TerraformProperty("write_capacity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> WriteCapacity { get; }

}
