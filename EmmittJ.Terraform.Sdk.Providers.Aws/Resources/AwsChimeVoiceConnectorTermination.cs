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
    public HashSet<string>? CallingRegions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("calling_regions")?.Value;
        set => this.WithProperty("calling_regions", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The cidr_allow_list attribute.
    /// </summary>
    public HashSet<string>? CidrAllowList
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("cidr_allow_list")?.Value;
        set => this.WithProperty("cidr_allow_list", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The cps_limit attribute.
    /// </summary>
    public double? CpsLimit
    {
        get => GetProperty<TerraformLiteralProperty<double>>("cps_limit")?.Value;
        set => this.WithProperty("cps_limit", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The default_phone_number attribute.
    /// </summary>
    public string? DefaultPhoneNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_phone_number")?.Value;
        set => this.WithProperty("default_phone_number", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public bool? Disabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disabled")?.Value;
        set => this.WithProperty("disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The voice_connector_id attribute.
    /// </summary>
    public string? VoiceConnectorId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("voice_connector_id")?.Value;
        set => this.WithProperty("voice_connector_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
