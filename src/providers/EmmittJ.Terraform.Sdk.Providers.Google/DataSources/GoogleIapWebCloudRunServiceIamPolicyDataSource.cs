using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_iap_web_cloud_run_service_iam_policy Terraform data source.
/// Retrieves information about a google_iap_web_cloud_run_service_iam_policy.
/// </summary>
public partial class GoogleIapWebCloudRunServiceIamPolicyDataSource(string name) : TerraformDataSource("google_iap_web_cloud_run_service_iam_policy", name)
{
    /// <summary>
    /// The cloud_run_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudRunServiceName is required")]
    public required TerraformValue<string> CloudRunServiceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("cloud_run_service_name");
        set => SetArgument("cloud_run_service_name", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location") ?? AsReference("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformValue<string> PolicyData
        => AsReference("policy_data");

}
