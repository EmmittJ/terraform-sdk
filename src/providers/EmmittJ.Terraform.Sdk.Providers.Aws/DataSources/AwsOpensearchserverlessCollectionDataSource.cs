using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_opensearchserverless_collection.
/// </summary>
public class AwsOpensearchserverlessCollectionDataSource : TerraformDataSource
{
    public AwsOpensearchserverlessCollectionDataSource(string name) : base("aws_opensearchserverless_collection", name)
    {
    }

    /// <summary>
    /// ID of the collection.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Name of the collection.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// Collection-specific endpoint used to submit index, search, and data upload requests to an OpenSearch Serverless collection.
    /// </summary>
    [TerraformPropertyName("collection_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CollectionEndpoint => new TerraformReference(this, "collection_endpoint");

    /// <summary>
    /// Date the Collection was created.
    /// </summary>
    [TerraformPropertyName("created_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedDate => new TerraformReference(this, "created_date");

    /// <summary>
    /// Collection-specific endpoint used to access OpenSearch Dashboards.
    /// </summary>
    [TerraformPropertyName("dashboard_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DashboardEndpoint => new TerraformReference(this, "dashboard_endpoint");

    /// <summary>
    /// Description of the collection.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// A failure code associated with the collection.
    /// </summary>
    [TerraformPropertyName("failure_code")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FailureCode => new TerraformReference(this, "failure_code");

    /// <summary>
    /// A failure reason associated with the collection.
    /// </summary>
    [TerraformPropertyName("failure_message")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FailureMessage => new TerraformReference(this, "failure_message");

    /// <summary>
    /// The ARN of the Amazon Web Services KMS key used to encrypt the collection.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KmsKeyArn => new TerraformReference(this, "kms_key_arn");

    /// <summary>
    /// Date the Collection was last modified.
    /// </summary>
    [TerraformPropertyName("last_modified_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastModifiedDate => new TerraformReference(this, "last_modified_date");

    /// <summary>
    /// Indicates whether standby replicas should be used for a collection.
    /// </summary>
    [TerraformPropertyName("standby_replicas")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StandbyReplicas => new TerraformReference(this, "standby_replicas");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// Type of collection.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Type => new TerraformReference(this, "type");

}
