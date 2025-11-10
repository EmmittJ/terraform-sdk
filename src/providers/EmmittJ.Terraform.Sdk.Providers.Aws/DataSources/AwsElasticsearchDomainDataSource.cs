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
        this.WithOutput("access_policies");
        this.WithOutput("advanced_options");
        this.WithOutput("advanced_security_options");
        this.WithOutput("arn");
        this.WithOutput("auto_tune_options");
        this.WithOutput("cluster_config");
        this.WithOutput("cognito_options");
        this.WithOutput("created");
        this.WithOutput("deleted");
        this.WithOutput("domain_id");
        this.WithOutput("ebs_options");
        this.WithOutput("elasticsearch_version");
        this.WithOutput("encryption_at_rest");
        this.WithOutput("endpoint");
        this.WithOutput("kibana_endpoint");
        this.WithOutput("log_publishing_options");
        this.WithOutput("node_to_node_encryption");
        this.WithOutput("processing");
        this.WithOutput("snapshot_options");
        this.WithOutput("vpc_options");
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
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
