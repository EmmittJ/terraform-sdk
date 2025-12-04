using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_iam_workforce_pool_iam_policy Terraform data source.
/// Retrieves information about a google_iam_workforce_pool_iam_policy.
/// </summary>
public partial class GoogleIamWorkforcePoolIamPolicyDataSource(string name) : TerraformDataSource("google_iam_workforce_pool_iam_policy", name)
{
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
    /// The workforce_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkforcePoolId is required")]
    public required TerraformValue<string> WorkforcePoolId
    {
        get => GetRequiredArgument<TerraformValue<string>>("workforce_pool_id");
        set => SetArgument("workforce_pool_id", value);
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
