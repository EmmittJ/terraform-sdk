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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "calling_regions").ResolveNodes(ctx));
        set => SetArgument("calling_regions", value);
    }

    /// <summary>
    /// The cidr_allow_list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CidrAllowList is required")]
    public required TerraformSet<string> CidrAllowList
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "cidr_allow_list").ResolveNodes(ctx));
        set => SetArgument("cidr_allow_list", value);
    }

    /// <summary>
    /// The cps_limit attribute.
    /// </summary>
    public TerraformValue<double>? CpsLimit
    {
        get => new TerraformReference<double>(this, "cps_limit");
        set => SetArgument("cps_limit", value);
    }

    /// <summary>
    /// The default_phone_number attribute.
    /// </summary>
    public TerraformValue<string>? DefaultPhoneNumber
    {
        get => new TerraformReference<string>(this, "default_phone_number");
        set => SetArgument("default_phone_number", value);
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => new TerraformReference<bool>(this, "disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The voice_connector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VoiceConnectorId is required")]
    public required TerraformValue<string> VoiceConnectorId
    {
        get => new TerraformReference<string>(this, "voice_connector_id");
        set => SetArgument("voice_connector_id", value);
    }

}
