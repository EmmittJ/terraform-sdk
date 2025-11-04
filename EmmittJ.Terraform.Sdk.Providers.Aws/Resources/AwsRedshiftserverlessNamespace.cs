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
    public string? AdminPasswordSecretKmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("admin_password_secret_kms_key_id")?.Value;
        set => this.WithProperty("admin_password_secret_kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The admin_user_password attribute.
    /// </summary>
    public string? AdminUserPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("admin_user_password")?.Value;
        set => this.WithProperty("admin_user_password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The admin_user_password_wo attribute.
    /// </summary>
    public string? AdminUserPasswordWo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("admin_user_password_wo")?.Value;
        set => this.WithProperty("admin_user_password_wo", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The admin_user_password_wo_version attribute.
    /// </summary>
    public double? AdminUserPasswordWoVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("admin_user_password_wo_version")?.Value;
        set => this.WithProperty("admin_user_password_wo_version", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    public string? AdminUsername
    {
        get => GetProperty<TerraformLiteralProperty<string>>("admin_username")?.Value;
        set => this.WithProperty("admin_username", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    public string? DbName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("db_name")?.Value;
        set => this.WithProperty("db_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    public string? DefaultIamRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_iam_role_arn")?.Value;
        set => this.WithProperty("default_iam_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public HashSet<string>? IamRoles
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("iam_roles")?.Value;
        set => this.WithProperty("iam_roles", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The kms_key_id attribute.
    /// </summary>
    public string? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id")?.Value;
        set => this.WithProperty("kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    public HashSet<string>? LogExports
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("log_exports")?.Value;
        set => this.WithProperty("log_exports", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The manage_admin_password attribute.
    /// </summary>
    public bool? ManageAdminPassword
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("manage_admin_password")?.Value;
        set => this.WithProperty("manage_admin_password", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
