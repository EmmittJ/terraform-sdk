using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_elasticsearch_domain Terraform data source.
/// Retrieves information about a aws_elasticsearch_domain.
/// </summary>
public partial class AwsElasticsearchDomainDataSource(string name) : TerraformDataSource("aws_elasticsearch_domain", name)
{
    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The access_policies attribute.
    /// </summary>
    public TerraformValue<string> AccessPolicies
        => AsReference("access_policies");

    /// <summary>
    /// The advanced_options attribute.
    /// </summary>
    public TerraformMap<string> AdvancedOptions
        => AsReference("advanced_options");

    /// <summary>
    /// The advanced_security_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AdvancedSecurityOptions
        => AsReference("advanced_security_options");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The auto_tune_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AutoTuneOptions
        => AsReference("auto_tune_options");

    /// <summary>
    /// The cluster_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ClusterConfig
        => AsReference("cluster_config");

    /// <summary>
    /// The cognito_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CognitoOptions
        => AsReference("cognito_options");

    /// <summary>
    /// The created attribute.
    /// </summary>
    public TerraformValue<bool> Created
        => AsReference("created");

    /// <summary>
    /// The deleted attribute.
    /// </summary>
    public TerraformValue<bool> Deleted
        => AsReference("deleted");

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    public TerraformValue<string> DomainId
        => AsReference("domain_id");

    /// <summary>
    /// The ebs_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EbsOptions
        => AsReference("ebs_options");

    /// <summary>
    /// The elasticsearch_version attribute.
    /// </summary>
    public TerraformValue<string> ElasticsearchVersion
        => AsReference("elasticsearch_version");

    /// <summary>
    /// The encryption_at_rest attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EncryptionAtRest
        => AsReference("encryption_at_rest");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// The kibana_endpoint attribute.
    /// </summary>
    public TerraformValue<string> KibanaEndpoint
        => AsReference("kibana_endpoint");

    /// <summary>
    /// The log_publishing_options attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> LogPublishingOptions
        => AsReference("log_publishing_options");

    /// <summary>
    /// The node_to_node_encryption attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NodeToNodeEncryption
        => AsReference("node_to_node_encryption");

    /// <summary>
    /// The processing attribute.
    /// </summary>
    public TerraformValue<bool> Processing
        => AsReference("processing");

    /// <summary>
    /// The snapshot_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SnapshotOptions
        => AsReference("snapshot_options");

    /// <summary>
    /// The vpc_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VpcOptions
        => AsReference("vpc_options");

}
