using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_scc_source_iam_policy Terraform resource.
/// Manages a google_scc_source_iam_policy resource.
/// </summary>
public partial class GoogleSccSourceIamPolicy(string name) : TerraformResource("google_scc_source_iam_policy", name)
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
    /// The organization attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Organization is required")]
    public required TerraformValue<string> Organization
    {
        get => new TerraformReference<string>(this, "organization");
        set => SetArgument("organization", value);
    }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyData is required")]
    public required TerraformValue<string> PolicyData
    {
        get => new TerraformReference<string>(this, "policy_data");
        set => SetArgument("policy_data", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformValue<string> Source
    {
        get => new TerraformReference<string>(this, "source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

}
