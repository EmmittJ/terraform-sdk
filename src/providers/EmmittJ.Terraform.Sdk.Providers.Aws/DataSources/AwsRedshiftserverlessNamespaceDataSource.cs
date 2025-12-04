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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    public required TerraformValue<string> NamespaceName
    {
        get => GetArgument<TerraformValue<string>>("namespace_name");
        set => SetArgument("namespace_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    public TerraformValue<string> AdminUsername
        => AsReference("admin_username");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    public TerraformValue<string> DbName
        => AsReference("db_name");

    /// <summary>
    /// The default_iam_role_arn attribute.
    /// </summary>
    public TerraformValue<string> DefaultIamRoleArn
        => AsReference("default_iam_role_arn");

    /// <summary>
    /// The iam_roles attribute.
    /// </summary>
    public TerraformSet<string> IamRoles
        => AsReference("iam_roles");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
        => AsReference("kms_key_id");

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    public TerraformSet<string> LogExports
        => AsReference("log_exports");

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    public TerraformValue<string> NamespaceId
        => AsReference("namespace_id");

}
