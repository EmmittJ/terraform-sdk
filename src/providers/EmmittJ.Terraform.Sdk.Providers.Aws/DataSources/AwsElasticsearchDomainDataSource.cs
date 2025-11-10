using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_elasticsearch_domain.
/// </summary>
public class AwsElasticsearchDomainDataSource : TerraformDataSource
{
    public AwsElasticsearchDomainDataSource(string name) : base("aws_elasticsearch_domain", name)
    {
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DomainName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    /// The access_policies attribute.
    /// </summary>
    [TerraformPropertyName("access_policies")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccessPolicies => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "access_policies");

    /// <summary>
    /// The advanced_options attribute.
    /// </summary>
    [TerraformPropertyName("advanced_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> AdvancedOptions => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "advanced_options");

    /// <summary>
    /// The advanced_security_options attribute.
    /// </summary>
    [TerraformPropertyName("advanced_security_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AdvancedSecurityOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "advanced_security_options");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The auto_tune_options attribute.
    /// </summary>
    [TerraformPropertyName("auto_tune_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AutoTuneOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "auto_tune_options");

    /// <summary>
    /// The cluster_config attribute.
    /// </summary>
    [TerraformPropertyName("cluster_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ClusterConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cluster_config");

    /// <summary>
    /// The cognito_options attribute.
    /// </summary>
    [TerraformPropertyName("cognito_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CognitoOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cognito_options");

    /// <summary>
    /// The created attribute.
    /// </summary>
    [TerraformPropertyName("created")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Created => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "created");

    /// <summary>
    /// The deleted attribute.
    /// </summary>
    [TerraformPropertyName("deleted")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Deleted => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "deleted");

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    [TerraformPropertyName("domain_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DomainId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain_id");

    /// <summary>
    /// The ebs_options attribute.
    /// </summary>
    [TerraformPropertyName("ebs_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EbsOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ebs_options");

    /// <summary>
    /// The elasticsearch_version attribute.
    /// </summary>
    [TerraformPropertyName("elasticsearch_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ElasticsearchVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "elasticsearch_version");

    /// <summary>
    /// The encryption_at_rest attribute.
    /// </summary>
    [TerraformPropertyName("encryption_at_rest")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EncryptionAtRest => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "encryption_at_rest");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The kibana_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("kibana_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KibanaEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kibana_endpoint");

    /// <summary>
    /// The log_publishing_options attribute.
    /// </summary>
    [TerraformPropertyName("log_publishing_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> LogPublishingOptions => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "log_publishing_options");

    /// <summary>
    /// The node_to_node_encryption attribute.
    /// </summary>
    [TerraformPropertyName("node_to_node_encryption")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> NodeToNodeEncryption => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "node_to_node_encryption");

    /// <summary>
    /// The processing attribute.
    /// </summary>
    [TerraformPropertyName("processing")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Processing => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "processing");

    /// <summary>
    /// The snapshot_options attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SnapshotOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "snapshot_options");

    /// <summary>
    /// The vpc_options attribute.
    /// </summary>
    [TerraformPropertyName("vpc_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> VpcOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "vpc_options");

}
