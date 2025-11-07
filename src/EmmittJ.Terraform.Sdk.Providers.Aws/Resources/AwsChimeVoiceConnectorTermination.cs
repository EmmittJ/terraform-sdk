using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_chime_voice_connector_termination resource.
/// </summary>
public class AwsChimeVoiceConnectorTermination : TerraformResource
{
    public AwsChimeVoiceConnectorTermination(string name) : base("aws_chime_voice_connector_termination", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The calling_regions attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? CallingRegions
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("calling_regions");
        set => this.WithProperty("calling_regions", value);
    }

    /// <summary>
    /// The cidr_allow_list attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? CidrAllowList
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("cidr_allow_list");
        set => this.WithProperty("cidr_allow_list", value);
    }

    /// <summary>
    /// The cps_limit attribute.
    /// </summary>
    public TerraformProperty<double>? CpsLimit
    {
        get => GetProperty<TerraformProperty<double>>("cps_limit");
        set => this.WithProperty("cps_limit", value);
    }

    /// <summary>
    /// The default_phone_number attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultPhoneNumber
    {
        get => GetProperty<TerraformProperty<string>>("default_phone_number");
        set => this.WithProperty("default_phone_number", value);
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The voice_connector_id attribute.
    /// </summary>
    public TerraformProperty<string>? VoiceConnectorId
    {
        get => GetProperty<TerraformProperty<string>>("voice_connector_id");
        set => this.WithProperty("voice_connector_id", value);
    }

}
