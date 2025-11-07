using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshiftserverless_namespace resource.
/// </summary>
public class AwsRedshiftserverlessNamespace : TerraformResource
{
    public AwsRedshiftserverlessNamespace(string name) : base("aws_redshiftserverless_namespace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("admin_password_secret_arn");
        this.DeclareOutput("arn");
        this.DeclareOutput("namespace_id");
    }

    /// <summary>
    /// The admin_password_secret_kms_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AdminPasswordSecretKmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("admin_password_secret_kms_key_id");
        set => this.WithProperty("admin_password_secret_kms_key_id", value);
    }

    /// <summary>
    /// The admin_user_password attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AdminUserPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("admin_user_password");
        set => this.WithProperty("admin_user_password", value);
    }

    /// <summary>
    /// The admin_user_password_wo attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AdminUserPasswordWo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("admin_user_password_wo");
        set => this.WithProperty("admin_user_password_wo", value);
    }

    /// <summary>
    /// The admin_user_password_wo_version attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? AdminUserPasswordWoVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("admin_user_password_wo_version");
        set => this.WithProperty("admin_user_password_wo_version", value);
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AdminUsername
    {
        get => GetProperty<TerraformLiteralProperty<string>>("admin_username");
        set => this.WithProperty("admin_username", value);
    }

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DbName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_name");
        set => this.WithProperty("db_name", value);
    }

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DefaultIamRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_iam_role_arn");
        set => this.WithProperty("default_iam_role_arn", value);
    }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? IamRoles
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("iam_roles");
        set => this.WithProperty("iam_roles", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? LogExports
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("log_exports");
        set => this.WithProperty("log_exports", value);
    }

    /// <summary>
    /// The manage_admin_password attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ManageAdminPassword
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("manage_admin_password");
        set => this.WithProperty("manage_admin_password", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NamespaceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("namespace_name");
        set => this.WithProperty("namespace_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The admin_password_secret_arn attribute.
    /// </summary>
    public TerraformExpression AdminPasswordSecretArn => this["admin_password_secret_arn"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    public TerraformExpression NamespaceId => this["namespace_id"];

}
