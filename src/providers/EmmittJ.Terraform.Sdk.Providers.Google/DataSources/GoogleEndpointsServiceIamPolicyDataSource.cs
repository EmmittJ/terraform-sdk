using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_endpoints_service_iam_policy Terraform data source.
/// Retrieves information about a google_endpoints_service_iam_policy.
/// </summary>
public partial class GoogleEndpointsServiceIamPolicyDataSource(string name) : TerraformDataSource("google_endpoints_service_iam_policy", name)
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
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformValue<string> ServiceName
    {
        get => new TerraformReference<string>(this, "service_name");
        set => SetArgument("service_name", value);
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
