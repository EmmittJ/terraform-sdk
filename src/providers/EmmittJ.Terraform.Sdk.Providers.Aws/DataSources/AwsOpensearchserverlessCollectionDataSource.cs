using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_opensearchserverless_collection Terraform data source.
/// Retrieves information about a aws_opensearchserverless_collection.
/// </summary>
public partial class AwsOpensearchserverlessCollectionDataSource(string name) : TerraformDataSource("aws_opensearchserverless_collection", name)
{
    /// <summary>
    /// ID of the collection.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Name of the collection.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// Collection-specific endpoint used to submit index, search, and data upload requests to an OpenSearch Serverless collection.
    /// </summary>
    public TerraformValue<string> CollectionEndpoint
    {
        get => new TerraformReference<string>(this, "collection_endpoint");
    }

    /// <summary>
    /// Date the Collection was created.
    /// </summary>
    public TerraformValue<string> CreatedDate
    {
        get => new TerraformReference<string>(this, "created_date");
    }

    /// <summary>
    /// Collection-specific endpoint used to access OpenSearch Dashboards.
    /// </summary>
    public TerraformValue<string> DashboardEndpoint
    {
        get => new TerraformReference<string>(this, "dashboard_endpoint");
    }

    /// <summary>
    /// Description of the collection.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// A failure code associated with the collection.
    /// </summary>
    public TerraformValue<string> FailureCode
    {
        get => new TerraformReference<string>(this, "failure_code");
    }

    /// <summary>
    /// A failure reason associated with the collection.
    /// </summary>
    public TerraformValue<string> FailureMessage
    {
        get => new TerraformReference<string>(this, "failure_message");
    }

    /// <summary>
    /// The ARN of the Amazon Web Services KMS key used to encrypt the collection.
    /// </summary>
    public TerraformValue<string> KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
    }

    /// <summary>
    /// Date the Collection was last modified.
    /// </summary>
    public TerraformValue<string> LastModifiedDate
    {
        get => new TerraformReference<string>(this, "last_modified_date");
    }

    /// <summary>
    /// Indicates whether standby replicas should be used for a collection.
    /// </summary>
    public TerraformValue<string> StandbyReplicas
    {
        get => new TerraformReference<string>(this, "standby_replicas");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// Type of collection.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

}
