using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_opensearchserverless_collection.
/// </summary>
public partial class AwsOpensearchserverlessCollectionDataSource : TerraformDataSource
{
    public AwsOpensearchserverlessCollectionDataSource(string name) : base("aws_opensearchserverless_collection", name)
    {
    }

    /// <summary>
    /// ID of the collection.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Name of the collection.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// Collection-specific endpoint used to submit index, search, and data upload requests to an OpenSearch Serverless collection.
    /// </summary>
    [TerraformProperty("collection_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CollectionEndpoint { get; }

    /// <summary>
    /// Date the Collection was created.
    /// </summary>
    [TerraformProperty("created_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedDate { get; }

    /// <summary>
    /// Collection-specific endpoint used to access OpenSearch Dashboards.
    /// </summary>
    [TerraformProperty("dashboard_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DashboardEndpoint { get; }

    /// <summary>
    /// Description of the collection.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// A failure code associated with the collection.
    /// </summary>
    [TerraformProperty("failure_code")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FailureCode { get; }

    /// <summary>
    /// A failure reason associated with the collection.
    /// </summary>
    [TerraformProperty("failure_message")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FailureMessage { get; }

    /// <summary>
    /// The ARN of the Amazon Web Services KMS key used to encrypt the collection.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KmsKeyArn { get; }

    /// <summary>
    /// Date the Collection was last modified.
    /// </summary>
    [TerraformProperty("last_modified_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastModifiedDate { get; }

    /// <summary>
    /// Indicates whether standby replicas should be used for a collection.
    /// </summary>
    [TerraformProperty("standby_replicas")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StandbyReplicas { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// Type of collection.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

}
