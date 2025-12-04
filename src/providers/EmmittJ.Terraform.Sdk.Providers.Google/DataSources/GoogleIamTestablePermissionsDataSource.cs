using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_iam_testable_permissions Terraform data source.
/// Retrieves information about a google_iam_testable_permissions.
/// </summary>
public partial class GoogleIamTestablePermissionsDataSource(string name) : TerraformDataSource("google_iam_testable_permissions", name)
{
    /// <summary>
    /// The custom_support_level attribute.
    /// </summary>
    public TerraformValue<string>? CustomSupportLevel
    {
        get => GetArgument<TerraformValue<string>>("custom_support_level");
        set => SetArgument("custom_support_level", value);
    }

    /// <summary>
    /// The full_resource_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FullResourceName is required")]
    public required TerraformValue<string> FullResourceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("full_resource_name");
        set => SetArgument("full_resource_name", value);
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
    /// The stages attribute.
    /// </summary>
    public TerraformList<string>? Stages
    {
        get => GetArgument<TerraformList<string>>("stages");
        set => SetArgument("stages", value);
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Permissions
        => AsReference("permissions");

}
