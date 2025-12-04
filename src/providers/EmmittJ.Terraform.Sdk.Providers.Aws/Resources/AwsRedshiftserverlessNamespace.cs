using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_redshiftserverless_namespace Terraform resource.
/// Manages a aws_redshiftserverless_namespace resource.
/// </summary>
public partial class AwsRedshiftserverlessNamespace(string name) : TerraformResource("aws_redshiftserverless_namespace", name)
{
    /// <summary>
    /// The admin_password_secret_kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> AdminPasswordSecretKmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("admin_password_secret_kms_key_id") ?? AsReference("admin_password_secret_kms_key_id");
        set => SetArgument("admin_password_secret_kms_key_id", value);
    }

    /// <summary>
    /// The admin_user_password attribute.
    /// </summary>
    public TerraformValue<string>? AdminUserPassword
    {
        get => GetArgument<TerraformValue<string>>("admin_user_password");
        set => SetArgument("admin_user_password", value);
    }

    /// <summary>
    /// The admin_user_password_wo attribute.
    /// </summary>
    public TerraformValue<string>? AdminUserPasswordWo
    {
        get => GetArgument<TerraformValue<string>>("admin_user_password_wo");
        set => SetArgument("admin_user_password_wo", value);
    }

    /// <summary>
    /// The admin_user_password_wo_version attribute.
    /// </summary>
    public TerraformValue<double>? AdminUserPasswordWoVersion
    {
        get => GetArgument<TerraformValue<double>>("admin_user_password_wo_version");
        set => SetArgument("admin_user_password_wo_version", value);
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    public TerraformValue<string> AdminUsername
    {
        get => GetArgument<TerraformValue<string>>("admin_username") ?? AsReference("admin_username");
        set => SetArgument("admin_username", value);
    }

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    public TerraformValue<string> DbName
    {
        get => GetArgument<TerraformValue<string>>("db_name") ?? AsReference("db_name");
        set => SetArgument("db_name", value);
    }

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? DefaultIamRoleArn
    {
        get => GetArgument<TerraformValue<string>>("default_iam_role_arn");
        set => SetArgument("default_iam_role_arn", value);
    }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public TerraformSet<string> IamRoles
    {
        get => GetArgument<TerraformSet<string>>("iam_roles") ?? AsReference("iam_roles");
        set => SetArgument("iam_roles", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id") ?? AsReference("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    public TerraformSet<string>? LogExports
    {
        get => GetArgument<TerraformSet<string>>("log_exports");
        set => SetArgument("log_exports", value);
    }

    /// <summary>
    /// The manage_admin_password attribute.
    /// </summary>
    public TerraformValue<bool>? ManageAdminPassword
    {
        get => GetArgument<TerraformValue<bool>>("manage_admin_password");
        set => SetArgument("manage_admin_password", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    public required TerraformValue<string> NamespaceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("namespace_name");
        set => SetArgument("namespace_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The admin_password_secret_arn attribute.
    /// </summary>
    public TerraformValue<string> AdminPasswordSecretArn
        => AsReference("admin_password_secret_arn");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    public TerraformValue<string> NamespaceId
        => AsReference("namespace_id");

}
