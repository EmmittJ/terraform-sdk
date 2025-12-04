using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_pinpoint_gcm_channel Terraform resource.
/// Manages a aws_pinpoint_gcm_channel resource.
/// </summary>
public partial class AwsPinpointGcmChannel(string name) : TerraformResource("aws_pinpoint_gcm_channel", name)
{
    /// <summary>
    /// The api_key attribute.
    /// </summary>
    public TerraformValue<string>? ApiKey
    {
        get => GetArgument<TerraformValue<string>>("api_key");
        set => SetArgument("api_key", value);
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformValue<string> ApplicationId
    {
        get => GetArgument<TerraformValue<string>>("application_id");
        set => SetArgument("application_id", value);
    }

    /// <summary>
    /// The default_authentication_method attribute.
    /// </summary>
    public TerraformValue<string>? DefaultAuthenticationMethod
    {
        get => GetArgument<TerraformValue<string>>("default_authentication_method");
        set => SetArgument("default_authentication_method", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The service_json attribute.
    /// </summary>
    public TerraformValue<string>? ServiceJson
    {
        get => GetArgument<TerraformValue<string>>("service_json");
        set => SetArgument("service_json", value);
    }

}
