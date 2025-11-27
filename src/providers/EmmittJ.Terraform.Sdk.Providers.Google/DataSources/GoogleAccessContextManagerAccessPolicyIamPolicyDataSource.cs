using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_access_context_manager_access_policy_iam_policy Terraform data source.
/// Retrieves information about a google_access_context_manager_access_policy_iam_policy.
/// </summary>
public partial class GoogleAccessContextManagerAccessPolicyIamPolicyDataSource(string name) : TerraformDataSource("google_access_context_manager_access_policy_iam_policy", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformValue<string> PolicyData
    {
        get => new TerraformReference<string>(this, "policy_data");
    }

}
