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
        get => new TerraformReference<string>(this, "global_endpoint_token_version");
        set => SetArgument("global_endpoint_token_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

}
