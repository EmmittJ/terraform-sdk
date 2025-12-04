using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_chime_voice_connector_termination Terraform resource.
/// Manages a aws_chime_voice_connector_termination resource.
/// </summary>
public partial class AwsChimeVoiceConnectorTermination(string name) : TerraformResource("aws_chime_voice_connector_termination", name)
{
    /// <summary>
    /// The calling_regions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CallingRegions is required")]
    public required TerraformSet<string> CallingRegions
    {
        get => GetRequiredArgument<TerraformSet<string>>("calling_regions");
        set => SetArgument("calling_regions", value);
    }

    /// <summary>
    /// The cidr_allow_list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CidrAllowList is required")]
    public required TerraformSet<string> CidrAllowList
    {
        get => GetRequiredArgument<TerraformSet<string>>("cidr_allow_list");
        set => SetArgument("cidr_allow_list", value);
    }

    /// <summary>
    /// The cps_limit attribute.
    /// </summary>
    public TerraformValue<double>? CpsLimit
    {
        get => GetArgument<TerraformValue<double>>("cps_limit");
        set => SetArgument("cps_limit", value);
    }

    /// <summary>
    /// The default_phone_number attribute.
    /// </summary>
    public TerraformValue<string>? DefaultPhoneNumber
    {
        get => GetArgument<TerraformValue<string>>("default_phone_number");
        set => SetArgument("default_phone_number", value);
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => GetArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The voice_connector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VoiceConnectorId is required")]
    public required TerraformValue<string> VoiceConnectorId
    {
        get => GetRequiredArgument<TerraformValue<string>>("voice_connector_id");
        set => SetArgument("voice_connector_id", value);
    }

}
