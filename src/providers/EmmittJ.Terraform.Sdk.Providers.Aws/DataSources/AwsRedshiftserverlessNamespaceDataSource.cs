using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_redshiftserverless_namespace Terraform data source.
/// Retrieves information about a aws_redshiftserverless_namespace.
/// </summary>
public partial class AwsRedshiftserverlessNamespaceDataSource(string name) : TerraformDataSource("aws_redshiftserverless_namespace", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The admin_username attribute.
    /// </summary>
    public TerraformValue<string> AdminUsername
    {
        get => new TerraformReference<string>(this, "admin_username");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    public TerraformValue<string> DbName
    {
        get => new TerraformReference<string>(this, "db_name");
    }

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    public TerraformValue<string> DefaultIamRoleArn
    {
        get => new TerraformReference<string>(this, "default_iam_role_arn");
    }

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public TerraformSet<string> IamRoles
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "iam_roles").ResolveNodes(ctx));
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
    }

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    public TerraformSet<string> LogExports
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "log_exports").ResolveNodes(ctx));
    }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    public TerraformValue<string> NamespaceId
    {
        get => new TerraformReference<string>(this, "namespace_id");
    }

}
