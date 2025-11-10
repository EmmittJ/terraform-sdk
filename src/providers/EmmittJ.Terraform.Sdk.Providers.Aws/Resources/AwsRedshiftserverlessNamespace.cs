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
        SetOutput("admin_password_secret_arn");
        SetOutput("arn");
        SetOutput("namespace_id");
        SetOutput("admin_password_secret_kms_key_id");
        SetOutput("admin_user_password");
        SetOutput("admin_user_password_wo");
        SetOutput("admin_user_password_wo_version");
        SetOutput("admin_username");
        SetOutput("db_name");
        SetOutput("default_iam_role_arn");
        SetOutput("iam_roles");
        SetOutput("id");
        SetOutput("kms_key_id");
        SetOutput("log_exports");
        SetOutput("manage_admin_password");
        SetOutput("namespace_name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The admin_password_secret_kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> AdminPasswordSecretKmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("admin_password_secret_kms_key_id");
        set => SetProperty("admin_password_secret_kms_key_id", value);
    }

    /// <summary>
    /// The admin_user_password attribute.
    /// </summary>
    public TerraformProperty<string> AdminUserPassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("admin_user_password");
        set => SetProperty("admin_user_password", value);
    }

    /// <summary>
    /// The admin_user_password_wo attribute.
    /// </summary>
    public TerraformProperty<string> AdminUserPasswordWo
    {
        get => GetRequiredOutput<TerraformProperty<string>>("admin_user_password_wo");
        set => SetProperty("admin_user_password_wo", value);
    }

    /// <summary>
    /// The admin_user_password_wo_version attribute.
    /// </summary>
    public TerraformProperty<double> AdminUserPasswordWoVersion
    {
        get => GetRequiredOutput<TerraformProperty<double>>("admin_user_password_wo_version");
        set => SetProperty("admin_user_password_wo_version", value);
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    public TerraformProperty<string> AdminUsername
    {
        get => GetRequiredOutput<TerraformProperty<string>>("admin_username");
        set => SetProperty("admin_username", value);
    }

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    public TerraformProperty<string> DbName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_name");
        set => SetProperty("db_name", value);
    }

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> DefaultIamRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_iam_role_arn");
        set => SetProperty("default_iam_role_arn", value);
    }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> IamRoles
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("iam_roles");
        set => SetProperty("iam_roles", value);
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
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> LogExports
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("log_exports");
        set => SetProperty("log_exports", value);
    }

    /// <summary>
    /// The manage_admin_password attribute.
    /// </summary>
    public TerraformProperty<bool> ManageAdminPassword
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("manage_admin_password");
        set => SetProperty("manage_admin_password", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
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
