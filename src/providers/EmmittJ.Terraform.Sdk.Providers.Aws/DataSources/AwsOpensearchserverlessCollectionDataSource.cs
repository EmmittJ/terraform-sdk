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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Name of the collection.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// Collection-specific endpoint used to submit index, search, and data upload requests to an OpenSearch Serverless collection.
    /// </summary>
    public TerraformValue<string> CollectionEndpoint
        => AsReference("collection_endpoint");

    /// <summary>
    /// Date the Collection was created.
    /// </summary>
    public TerraformValue<string> CreatedDate
        => AsReference("created_date");

    /// <summary>
    /// Collection-specific endpoint used to access OpenSearch Dashboards.
    /// </summary>
    public TerraformValue<string> DashboardEndpoint
        => AsReference("dashboard_endpoint");

    /// <summary>
    /// Description of the collection.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// A failure code associated with the collection.
    /// </summary>
    public TerraformValue<string> FailureCode
        => AsReference("failure_code");

    /// <summary>
    /// A failure reason associated with the collection.
    /// </summary>
    public TerraformValue<string> FailureMessage
        => AsReference("failure_message");

    /// <summary>
    /// The ARN of the Amazon Web Services KMS key used to encrypt the collection.
    /// </summary>
    public TerraformValue<string> KmsKeyArn
        => AsReference("kms_key_arn");

    /// <summary>
    /// Date the Collection was last modified.
    /// </summary>
    public TerraformValue<string> LastModifiedDate
        => AsReference("last_modified_date");

    /// <summary>
    /// Indicates whether standby replicas should be used for a collection.
    /// </summary>
    public TerraformValue<string> StandbyReplicas
        => AsReference("standby_replicas");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Type of collection.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

}
