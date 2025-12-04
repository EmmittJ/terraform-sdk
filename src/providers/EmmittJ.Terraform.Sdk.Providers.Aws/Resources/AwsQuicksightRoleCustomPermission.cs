using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_quicksight_role_custom_permission Terraform resource.
/// Manages a aws_quicksight_role_custom_permission resource.
/// </summary>
public partial class AwsQuicksightRoleCustomPermission(string name) : TerraformResource("aws_quicksight_role_custom_permission", name)
{
    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformValue<string>? AwsAccountId
    {
        get => GetArgument<TerraformValue<string>>("aws_account_id");
        set => SetArgument("aws_account_id", value);
    }

    /// <summary>
    /// The custom_permissions_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomPermissionsName is required")]
    public required TerraformValue<string> CustomPermissionsName
    {
        get => GetArgument<TerraformValue<string>>("custom_permissions_name");
        set => SetArgument("custom_permissions_name", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformValue<string>? NamespaceAttribute
    {
        get => GetArgument<TerraformValue<string>>("namespace");
        set => SetArgument("namespace", value);
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
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformValue<string> Role
    {
        get => GetArgument<TerraformValue<string>>("role");
        set => SetArgument("role", value);
    }

}
