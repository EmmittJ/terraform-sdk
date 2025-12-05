using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_security_token_service_preferences Terraform resource.
/// Manages a aws_iam_security_token_service_preferences resource.
/// </summary>
public partial class AwsIamSecurityTokenServicePreferences(string name) : TerraformResource("aws_iam_security_token_service_preferences", name)
{
    /// <summary>
    /// The global_endpoint_token_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlobalEndpointTokenVersion is required")]
    public required TerraformValue<string> GlobalEndpointTokenVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("global_endpoint_token_version");
        set => SetArgument("global_endpoint_token_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

}
