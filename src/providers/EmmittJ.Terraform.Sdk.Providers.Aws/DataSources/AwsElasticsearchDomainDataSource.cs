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
        SetOutput("access_policies");
        SetOutput("advanced_options");
        SetOutput("advanced_security_options");
        SetOutput("arn");
        SetOutput("auto_tune_options");
        SetOutput("cluster_config");
        SetOutput("cognito_options");
        SetOutput("created");
        SetOutput("deleted");
        SetOutput("domain_id");
        SetOutput("ebs_options");
        SetOutput("elasticsearch_version");
        SetOutput("encryption_at_rest");
        SetOutput("endpoint");
        SetOutput("kibana_endpoint");
        SetOutput("log_publishing_options");
        SetOutput("node_to_node_encryption");
        SetOutput("processing");
        SetOutput("snapshot_options");
        SetOutput("vpc_options");
        SetOutput("domain_name");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_name");
        set => SetProperty("domain_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
