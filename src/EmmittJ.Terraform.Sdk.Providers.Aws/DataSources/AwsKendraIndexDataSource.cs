using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kendra_index.
/// </summary>
public class AwsKendraIndexDataSource : TerraformDataSource
{
    public AwsKendraIndexDataSource(string name) : base("aws_kendra_index", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("capacity_units");
        this.DeclareOutput("created_at");
        this.DeclareOutput("description");
        this.DeclareOutput("document_metadata_configuration_updates");
        this.DeclareOutput("edition");
        this.DeclareOutput("error_message");
        this.DeclareOutput("index_statistics");
        this.DeclareOutput("name");
        this.DeclareOutput("role_arn");
        this.DeclareOutput("server_side_encryption_configuration");
        this.DeclareOutput("status");
        this.DeclareOutput("updated_at");
        this.DeclareOutput("user_context_policy");
        this.DeclareOutput("user_group_resolution_configuration");
        this.DeclareOutput("user_token_configurations");
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The capacity_units attribute.
    /// </summary>
    public TerraformExpression CapacityUnits => this["capacity_units"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The document_metadata_configuration_updates attribute.
    /// </summary>
    public TerraformExpression DocumentMetadataConfigurationUpdates => this["document_metadata_configuration_updates"];

    /// <summary>
    /// The edition attribute.
    /// </summary>
    public TerraformExpression Edition => this["edition"];

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    public TerraformExpression ErrorMessage => this["error_message"];

    /// <summary>
    /// The index_statistics attribute.
    /// </summary>
    public TerraformExpression IndexStatistics => this["index_statistics"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformExpression RoleArn => this["role_arn"];

    /// <summary>
    /// The server_side_encryption_configuration attribute.
    /// </summary>
    public TerraformExpression ServerSideEncryptionConfiguration => this["server_side_encryption_configuration"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformExpression UpdatedAt => this["updated_at"];

    /// <summary>
    /// The user_context_policy attribute.
    /// </summary>
    public TerraformExpression UserContextPolicy => this["user_context_policy"];

    /// <summary>
    /// The user_group_resolution_configuration attribute.
    /// </summary>
    public TerraformExpression UserGroupResolutionConfiguration => this["user_group_resolution_configuration"];

    /// <summary>
    /// The user_token_configurations attribute.
    /// </summary>
    public TerraformExpression UserTokenConfigurations => this["user_token_configurations"];

}
