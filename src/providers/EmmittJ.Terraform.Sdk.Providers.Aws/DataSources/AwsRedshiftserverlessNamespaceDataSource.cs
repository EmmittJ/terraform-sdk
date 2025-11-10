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
        SetOutput("admin_username");
        SetOutput("arn");
        SetOutput("db_name");
        SetOutput("default_iam_role_arn");
        SetOutput("iam_roles");
        SetOutput("kms_key_id");
        SetOutput("log_exports");
        SetOutput("namespace_id");
        SetOutput("id");
        SetOutput("namespace_name");
        SetOutput("region");
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
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    public required TerraformProperty<string> NamespaceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("namespace_name");
        set => SetProperty("namespace_name", value);
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
