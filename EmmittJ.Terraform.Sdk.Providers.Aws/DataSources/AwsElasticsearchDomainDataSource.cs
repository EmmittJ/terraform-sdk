using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_elasticsearch_domain.
/// </summary>
public class AwsElasticsearchDomainDataSource : TerraformDataSource
{
    public AwsElasticsearchDomainDataSource(string name) : base("aws_elasticsearch_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("access_policies");
        this.DeclareOutput("advanced_options");
        this.DeclareOutput("advanced_security_options");
        this.DeclareOutput("arn");
        this.DeclareOutput("auto_tune_options");
        this.DeclareOutput("cluster_config");
        this.DeclareOutput("cognito_options");
        this.DeclareOutput("created");
        this.DeclareOutput("deleted");
        this.DeclareOutput("domain_id");
        this.DeclareOutput("ebs_options");
        this.DeclareOutput("elasticsearch_version");
        this.DeclareOutput("encryption_at_rest");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("kibana_endpoint");
        this.DeclareOutput("log_publishing_options");
        this.DeclareOutput("node_to_node_encryption");
        this.DeclareOutput("processing");
        this.DeclareOutput("snapshot_options");
        this.DeclareOutput("vpc_options");
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public string? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name")?.Value;
        set => this.WithProperty("domain_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The access_policies attribute.
    /// </summary>
    public TerraformExpression AccessPolicies => this["access_policies"];

    /// <summary>
    /// The advanced_options attribute.
    /// </summary>
    public TerraformExpression AdvancedOptions => this["advanced_options"];

    /// <summary>
    /// The advanced_security_options attribute.
    /// </summary>
    public TerraformExpression AdvancedSecurityOptions => this["advanced_security_options"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The auto_tune_options attribute.
    /// </summary>
    public TerraformExpression AutoTuneOptions => this["auto_tune_options"];

    /// <summary>
    /// The cluster_config attribute.
    /// </summary>
    public TerraformExpression ClusterConfig => this["cluster_config"];

    /// <summary>
    /// The cognito_options attribute.
    /// </summary>
    public TerraformExpression CognitoOptions => this["cognito_options"];

    /// <summary>
    /// The created attribute.
    /// </summary>
    public TerraformExpression Created => this["created"];

    /// <summary>
    /// The deleted attribute.
    /// </summary>
    public TerraformExpression Deleted => this["deleted"];

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    public TerraformExpression DomainId => this["domain_id"];

    /// <summary>
    /// The ebs_options attribute.
    /// </summary>
    public TerraformExpression EbsOptions => this["ebs_options"];

    /// <summary>
    /// The elasticsearch_version attribute.
    /// </summary>
    public TerraformExpression ElasticsearchVersion => this["elasticsearch_version"];

    /// <summary>
    /// The encryption_at_rest attribute.
    /// </summary>
    public TerraformExpression EncryptionAtRest => this["encryption_at_rest"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The kibana_endpoint attribute.
    /// </summary>
    public TerraformExpression KibanaEndpoint => this["kibana_endpoint"];

    /// <summary>
    /// The log_publishing_options attribute.
    /// </summary>
    public TerraformExpression LogPublishingOptions => this["log_publishing_options"];

    /// <summary>
    /// The node_to_node_encryption attribute.
    /// </summary>
    public TerraformExpression NodeToNodeEncryption => this["node_to_node_encryption"];

    /// <summary>
    /// The processing attribute.
    /// </summary>
    public TerraformExpression Processing => this["processing"];

    /// <summary>
    /// The snapshot_options attribute.
    /// </summary>
    public TerraformExpression SnapshotOptions => this["snapshot_options"];

    /// <summary>
    /// The vpc_options attribute.
    /// </summary>
    public TerraformExpression VpcOptions => this["vpc_options"];

}
