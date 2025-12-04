using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_cloudfunctions_function_iam_policy Terraform data source.
/// Retrieves information about a google_cloudfunctions_function_iam_policy.
/// </summary>
public partial class GoogleCloudfunctionsFunctionIamPolicyDataSource(string name) : TerraformDataSource("google_cloudfunctions_function_iam_policy", name)
{
    /// <summary>
    /// The cloud_function attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudFunction is required")]
    public required TerraformValue<string> CloudFunction
    {
        get => GetArgument<TerraformValue<string>>("cloud_function");
        set => SetArgument("cloud_function", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
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
