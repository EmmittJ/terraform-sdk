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
        get => new TerraformReference<string>(this, "admin_password_secret_kms_key_id");
        set => SetArgument("admin_password_secret_kms_key_id", value);
    }

    /// <summary>
    /// The admin_user_password attribute.
    /// </summary>
    public TerraformValue<string>? AdminUserPassword
    {
        get => new TerraformReference<string>(this, "admin_user_password");
        set => SetArgument("admin_user_password", value);
    }

    /// <summary>
    /// The admin_user_password_wo attribute.
    /// </summary>
    public TerraformValue<string>? AdminUserPasswordWo
    {
        get => new TerraformReference<string>(this, "admin_user_password_wo");
        set => SetArgument("admin_user_password_wo", value);
    }

    /// <summary>
    /// The admin_user_password_wo_version attribute.
    /// </summary>
    public TerraformValue<double>? AdminUserPasswordWoVersion
    {
        get => new TerraformReference<double>(this, "admin_user_password_wo_version");
        set => SetArgument("admin_user_password_wo_version", value);
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    public TerraformValue<string> AdminUsername
    {
        get => new TerraformReference<string>(this, "admin_username");
        set => SetArgument("admin_username", value);
    }

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    public TerraformValue<string> DbName
    {
        get => new TerraformReference<string>(this, "db_name");
        set => SetArgument("db_name", value);
    }

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? DefaultIamRoleArn
    {
        get => new TerraformReference<string>(this, "default_iam_role_arn");
        set => SetArgument("default_iam_role_arn", value);
    }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public TerraformSet<string> IamRoles
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "iam_roles").ResolveNodes(ctx));
        set => SetArgument("iam_roles", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    public TerraformSet<string>? LogExports
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "log_exports").ResolveNodes(ctx));
        set => SetArgument("log_exports", value);
    }

    /// <summary>
    /// The manage_admin_password attribute.
    /// </summary>
    public TerraformValue<bool>? ManageAdminPassword
    {
        get => new TerraformReference<bool>(this, "manage_admin_password");
        set => SetArgument("manage_admin_password", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    public required TerraformValue<string> NamespaceName
    {
        get => new TerraformReference<string>(this, "namespace_name");
        set => SetArgument("namespace_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The admin_password_secret_arn attribute.
    /// </summary>
    public TerraformValue<string> AdminPasswordSecretArn
    {
        get => new TerraformReference<string>(this, "admin_password_secret_arn");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    public TerraformValue<string> NamespaceId
    {
        get => new TerraformReference<string>(this, "namespace_id");
    }

}
