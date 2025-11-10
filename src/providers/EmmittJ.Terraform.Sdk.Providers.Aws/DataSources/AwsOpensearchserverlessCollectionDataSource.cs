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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Name of the collection.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// Collection-specific endpoint used to submit index, search, and data upload requests to an OpenSearch Serverless collection.
    /// </summary>
    [TerraformPropertyName("collection_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CollectionEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "collection_endpoint");

    /// <summary>
    /// Date the Collection was created.
    /// </summary>
    [TerraformPropertyName("created_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_date");

    /// <summary>
    /// Collection-specific endpoint used to access OpenSearch Dashboards.
    /// </summary>
    [TerraformPropertyName("dashboard_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DashboardEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dashboard_endpoint");

    /// <summary>
    /// Description of the collection.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// A failure code associated with the collection.
    /// </summary>
    [TerraformPropertyName("failure_code")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FailureCode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "failure_code");

    /// <summary>
    /// A failure reason associated with the collection.
    /// </summary>
    [TerraformPropertyName("failure_message")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FailureMessage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "failure_message");

    /// <summary>
    /// The ARN of the Amazon Web Services KMS key used to encrypt the collection.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_arn");

    /// <summary>
    /// Date the Collection was last modified.
    /// </summary>
    [TerraformPropertyName("last_modified_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModifiedDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modified_date");

    /// <summary>
    /// Indicates whether standby replicas should be used for a collection.
    /// </summary>
    [TerraformPropertyName("standby_replicas")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StandbyReplicas => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "standby_replicas");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// Type of collection.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

}
