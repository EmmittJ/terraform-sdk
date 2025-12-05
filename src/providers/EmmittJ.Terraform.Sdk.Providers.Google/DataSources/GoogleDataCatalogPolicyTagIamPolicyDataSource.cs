using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_data_catalog_policy_tag_iam_policy Terraform data source.
/// Retrieves information about a google_data_catalog_policy_tag_iam_policy.
/// </summary>
public partial class GoogleDataCatalogPolicyTagIamPolicyDataSource(string name) : TerraformDataSource("google_data_catalog_policy_tag_iam_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The policy_tag attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyTag is required")]
    public required TerraformValue<string> PolicyTag
    {
        get => GetRequiredArgument<TerraformValue<string>>("policy_tag");
        set => SetArgument("policy_tag", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
        => CreateReference("etag");

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformValue<string> PolicyData
        => CreateReference("policy_data");

}
