using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codegurureviewer_repository_association resource.
/// </summary>
public class AwsCodegurureviewerRepositoryAssociation : TerraformResource
{
    public AwsCodegurureviewerRepositoryAssociation(string name) : base("aws_codegurureviewer_repository_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("association_id");
        this.DeclareOutput("connection_arn");
        this.DeclareOutput("name");
        this.DeclareOutput("owner");
        this.DeclareOutput("provider_type");
        this.DeclareOutput("s3_repository_details");
        this.DeclareOutput("state");
        this.DeclareOutput("state_reason");
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformExpression AssociationId => this["association_id"];

    /// <summary>
    /// The connection_arn attribute.
    /// </summary>
    public TerraformExpression ConnectionArn => this["connection_arn"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformExpression Owner => this["owner"];

    /// <summary>
    /// The provider_type attribute.
    /// </summary>
    public TerraformExpression ProviderType => this["provider_type"];

    /// <summary>
    /// The s3_repository_details attribute.
    /// </summary>
    public TerraformExpression S3RepositoryDetails => this["s3_repository_details"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The state_reason attribute.
    /// </summary>
    public TerraformExpression StateReason => this["state_reason"];

}
