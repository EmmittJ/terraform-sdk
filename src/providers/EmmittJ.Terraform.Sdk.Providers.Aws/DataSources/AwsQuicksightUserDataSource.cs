using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_quicksight_user Terraform data source.
/// Retrieves information about a aws_quicksight_user.
/// </summary>
public partial class AwsQuicksightUserDataSource(string name) : TerraformDataSource("aws_quicksight_user", name)
{
    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformValue<string> AwsAccountId
    {
        get => new TerraformReference<string>(this, "aws_account_id");
        set => SetArgument("aws_account_id", value);
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
    /// The namespace attribute.
    /// </summary>
    public TerraformValue<string>? NamespaceAttribute
    {
        get => new TerraformReference<string>(this, "namespace");
        set => SetArgument("namespace", value);
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
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformValue<string> UserName
    {
        get => new TerraformReference<string>(this, "user_name");
        set => SetArgument("user_name", value);
    }

    /// <summary>
    /// The active attribute.
    /// </summary>
    public TerraformValue<bool> Active
    {
        get => new TerraformReference<bool>(this, "active");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The custom_permissions_name attribute.
    /// </summary>
    public TerraformValue<string> CustomPermissionsName
    {
        get => new TerraformReference<string>(this, "custom_permissions_name");
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string> Email
    {
        get => new TerraformReference<string>(this, "email");
    }

    /// <summary>
    /// The identity_type attribute.
    /// </summary>
    public TerraformValue<string> IdentityType
    {
        get => new TerraformReference<string>(this, "identity_type");
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The user_role attribute.
    /// </summary>
    public TerraformValue<string> UserRole
    {
        get => new TerraformReference<string>(this, "user_role");
    }

}
