using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_endpoints_service_consumers_iam_policy Terraform data source.
/// Retrieves information about a google_endpoints_service_consumers_iam_policy.
/// </summary>
public partial class GoogleEndpointsServiceConsumersIamPolicyDataSource(string name) : TerraformDataSource("google_endpoints_service_consumers_iam_policy", name)
{
    /// <summary>
    /// The consumer_project attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerProject is required")]
    public required TerraformValue<string> ConsumerProject
    {
        get => GetArgument<TerraformValue<string>>("consumer_project");
        set => SetArgument("consumer_project", value);
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
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformValue<string> ServiceName
    {
        get => GetArgument<TerraformValue<string>>("service_name");
        set => SetArgument("service_name", value);
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
