using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_redshiftserverless_namespace.
/// </summary>
public class AwsRedshiftserverlessNamespaceDataSource : TerraformDataSource
{
    public AwsRedshiftserverlessNamespaceDataSource(string name) : base("aws_redshiftserverless_namespace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("admin_username");
        this.DeclareOutput("arn");
        this.DeclareOutput("db_name");
        this.DeclareOutput("default_iam_role_arn");
        this.DeclareOutput("iam_roles");
        this.DeclareOutput("kms_key_id");
        this.DeclareOutput("log_exports");
        this.DeclareOutput("namespace_id");
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
    /// The namespace_name attribute.
    /// </summary>
    public string? NamespaceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("namespace_name")?.Value;
        set => this.WithProperty("namespace_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    public TerraformExpression AdminUsername => this["admin_username"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    public TerraformExpression DbName => this["db_name"];

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    public TerraformExpression DefaultIamRoleArn => this["default_iam_role_arn"];

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public TerraformExpression IamRoles => this["iam_roles"];

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformExpression KmsKeyId => this["kms_key_id"];

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    public TerraformExpression LogExports => this["log_exports"];

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    public TerraformExpression NamespaceId => this["namespace_id"];

}
