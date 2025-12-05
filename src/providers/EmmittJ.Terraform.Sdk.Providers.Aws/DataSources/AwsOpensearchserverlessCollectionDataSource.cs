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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Name of the collection.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// Collection-specific endpoint used to submit index, search, and data upload requests to an OpenSearch Serverless collection.
    /// </summary>
    public TerraformValue<string> CollectionEndpoint
        => CreateReference("collection_endpoint");

    /// <summary>
    /// Date the Collection was created.
    /// </summary>
    public TerraformValue<string> CreatedDate
        => CreateReference("created_date");

    /// <summary>
    /// Collection-specific endpoint used to access OpenSearch Dashboards.
    /// </summary>
    public TerraformValue<string> DashboardEndpoint
        => CreateReference("dashboard_endpoint");

    /// <summary>
    /// Description of the collection.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// A failure code associated with the collection.
    /// </summary>
    public TerraformValue<string> FailureCode
        => CreateReference("failure_code");

    /// <summary>
    /// A failure reason associated with the collection.
    /// </summary>
    public TerraformValue<string> FailureMessage
        => CreateReference("failure_message");

    /// <summary>
    /// The ARN of the Amazon Web Services KMS key used to encrypt the collection.
    /// </summary>
    public TerraformValue<string> KmsKeyArn
        => CreateReference("kms_key_arn");

    /// <summary>
    /// Date the Collection was last modified.
    /// </summary>
    public TerraformValue<string> LastModifiedDate
        => CreateReference("last_modified_date");

    /// <summary>
    /// Indicates whether standby replicas should be used for a collection.
    /// </summary>
    public TerraformValue<string> StandbyReplicas
        => CreateReference("standby_replicas");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// Type of collection.
    /// </summary>
    public TerraformValue<string> Type
        => CreateReference("type");

}
