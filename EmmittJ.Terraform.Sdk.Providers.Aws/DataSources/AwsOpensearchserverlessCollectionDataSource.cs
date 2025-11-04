using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_opensearchserverless_collection.
/// </summary>
public class AwsOpensearchserverlessCollectionDataSource : TerraformDataSource
{
    public AwsOpensearchserverlessCollectionDataSource(string name) : base("aws_opensearchserverless_collection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("collection_endpoint");
        this.DeclareOutput("created_date");
        this.DeclareOutput("dashboard_endpoint");
        this.DeclareOutput("description");
        this.DeclareOutput("failure_code");
        this.DeclareOutput("failure_message");
        this.DeclareOutput("kms_key_arn");
        this.DeclareOutput("last_modified_date");
        this.DeclareOutput("standby_replicas");
        this.DeclareOutput("tags");
        this.DeclareOutput("type");
    }

    /// <summary>
    /// ID of the collection.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Name of the collection.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// Collection-specific endpoint used to submit index, search, and data upload requests to an OpenSearch Serverless collection.
    /// </summary>
    public TerraformExpression CollectionEndpoint => this["collection_endpoint"];

    /// <summary>
    /// Date the Collection was created.
    /// </summary>
    public TerraformExpression CreatedDate => this["created_date"];

    /// <summary>
    /// Collection-specific endpoint used to access OpenSearch Dashboards.
    /// </summary>
    public TerraformExpression DashboardEndpoint => this["dashboard_endpoint"];

    /// <summary>
    /// Description of the collection.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// A failure code associated with the collection.
    /// </summary>
    public TerraformExpression FailureCode => this["failure_code"];

    /// <summary>
    /// A failure reason associated with the collection.
    /// </summary>
    public TerraformExpression FailureMessage => this["failure_message"];

    /// <summary>
    /// The ARN of the Amazon Web Services KMS key used to encrypt the collection.
    /// </summary>
    public TerraformExpression KmsKeyArn => this["kms_key_arn"];

    /// <summary>
    /// Date the Collection was last modified.
    /// </summary>
    public TerraformExpression LastModifiedDate => this["last_modified_date"];

    /// <summary>
    /// Indicates whether standby replicas should be used for a collection.
    /// </summary>
    public TerraformExpression StandbyReplicas => this["standby_replicas"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// Type of collection.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
