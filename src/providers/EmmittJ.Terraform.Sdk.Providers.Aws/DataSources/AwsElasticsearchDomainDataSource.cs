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
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

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
    /// The access_policies attribute.
    /// </summary>
    [TerraformPropertyName("access_policies")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AccessPolicies => new TerraformReference(this, "access_policies");

    /// <summary>
    /// The advanced_options attribute.
    /// </summary>
    [TerraformPropertyName("advanced_options")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> AdvancedOptions => new TerraformReference(this, "advanced_options");

    /// <summary>
    /// The advanced_security_options attribute.
    /// </summary>
    [TerraformPropertyName("advanced_security_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AdvancedSecurityOptions => new TerraformReference(this, "advanced_security_options");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The auto_tune_options attribute.
    /// </summary>
    [TerraformPropertyName("auto_tune_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AutoTuneOptions => new TerraformReference(this, "auto_tune_options");

    /// <summary>
    /// The cluster_config attribute.
    /// </summary>
    [TerraformPropertyName("cluster_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ClusterConfig => new TerraformReference(this, "cluster_config");

    /// <summary>
    /// The cognito_options attribute.
    /// </summary>
    [TerraformPropertyName("cognito_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CognitoOptions => new TerraformReference(this, "cognito_options");

    /// <summary>
    /// The created attribute.
    /// </summary>
    [TerraformPropertyName("created")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Created => new TerraformReference(this, "created");

    /// <summary>
    /// The deleted attribute.
    /// </summary>
    [TerraformPropertyName("deleted")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Deleted => new TerraformReference(this, "deleted");

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    [TerraformPropertyName("domain_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DomainId => new TerraformReference(this, "domain_id");

    /// <summary>
    /// The ebs_options attribute.
    /// </summary>
    [TerraformPropertyName("ebs_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EbsOptions => new TerraformReference(this, "ebs_options");

    /// <summary>
    /// The elasticsearch_version attribute.
    /// </summary>
    [TerraformPropertyName("elasticsearch_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ElasticsearchVersion => new TerraformReference(this, "elasticsearch_version");

    /// <summary>
    /// The encryption_at_rest attribute.
    /// </summary>
    [TerraformPropertyName("encryption_at_rest")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EncryptionAtRest => new TerraformReference(this, "encryption_at_rest");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Endpoint => new TerraformReference(this, "endpoint");

    /// <summary>
    /// The kibana_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("kibana_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KibanaEndpoint => new TerraformReference(this, "kibana_endpoint");

    /// <summary>
    /// The log_publishing_options attribute.
    /// </summary>
    [TerraformPropertyName("log_publishing_options")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> LogPublishingOptions => new TerraformReference(this, "log_publishing_options");

    /// <summary>
    /// The node_to_node_encryption attribute.
    /// </summary>
    [TerraformPropertyName("node_to_node_encryption")]
    // Output-only attribute - read-only reference
    public TerraformList<object> NodeToNodeEncryption => new TerraformReference(this, "node_to_node_encryption");

    /// <summary>
    /// The processing attribute.
    /// </summary>
    [TerraformPropertyName("processing")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Processing => new TerraformReference(this, "processing");

    /// <summary>
    /// The snapshot_options attribute.
    /// </summary>
    [TerraformPropertyName("snapshot_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SnapshotOptions => new TerraformReference(this, "snapshot_options");

    /// <summary>
    /// The vpc_options attribute.
    /// </summary>
    [TerraformPropertyName("vpc_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> VpcOptions => new TerraformReference(this, "vpc_options");

}
