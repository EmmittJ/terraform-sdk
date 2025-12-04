using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_pinpoint_apns_voip_channel Terraform resource.
/// Manages a aws_pinpoint_apns_voip_channel resource.
/// </summary>
public partial class AwsPinpointApnsVoipChannel(string name) : TerraformResource("aws_pinpoint_apns_voip_channel", name)
{
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
    /// The bundle_id attribute.
    /// </summary>
    public TerraformValue<string>? BundleId
    {
        get => GetArgument<TerraformValue<string>>("bundle_id");
        set => SetArgument("bundle_id", value);
    }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformValue<string>? Certificate
    {
        get => GetArgument<TerraformValue<string>>("certificate");
        set => SetArgument("certificate", value);
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
    /// The private_key attribute.
    /// </summary>
    public TerraformValue<string>? PrivateKey
    {
        get => GetArgument<TerraformValue<string>>("private_key");
        set => SetArgument("private_key", value);
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
    /// The team_id attribute.
    /// </summary>
    public TerraformValue<string>? TeamId
    {
        get => GetArgument<TerraformValue<string>>("team_id");
        set => SetArgument("team_id", value);
    }

    /// <summary>
    /// The token_key attribute.
    /// </summary>
    public TerraformValue<string>? TokenKey
    {
        get => GetArgument<TerraformValue<string>>("token_key");
        set => SetArgument("token_key", value);
    }

    /// <summary>
    /// The token_key_id attribute.
    /// </summary>
    public TerraformValue<string>? TokenKeyId
    {
        get => GetArgument<TerraformValue<string>>("token_key_id");
        set => SetArgument("token_key_id", value);
    }

}
