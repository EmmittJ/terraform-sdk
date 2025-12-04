using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_dx_connection Terraform resource.
/// Manages a aws_dx_connection resource.
/// </summary>
public partial class AwsDxConnection(string name) : TerraformResource("aws_dx_connection", name)
{
    /// <summary>
    /// The bandwidth attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bandwidth is required")]
    public required TerraformValue<string> Bandwidth
    {
        get => GetRequiredArgument<TerraformValue<string>>("bandwidth");
        set => SetArgument("bandwidth", value);
    }

    /// <summary>
    /// The encryption_mode attribute.
    /// </summary>
    public TerraformValue<string> EncryptionMode
    {
        get => GetArgument<TerraformValue<string>>("encryption_mode") ?? AsReference("encryption_mode");
        set => SetArgument("encryption_mode", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    public TerraformValue<string> ProviderName
    {
        get => GetArgument<TerraformValue<string>>("provider_name") ?? AsReference("provider_name");
        set => SetArgument("provider_name", value);
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
    /// The request_macsec attribute.
    /// </summary>
    public TerraformValue<bool>? RequestMacsec
    {
        get => GetArgument<TerraformValue<bool>>("request_macsec");
        set => SetArgument("request_macsec", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? SkipDestroy
    {
        get => GetArgument<TerraformValue<bool>>("skip_destroy");
        set => SetArgument("skip_destroy", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The aws_device attribute.
    /// </summary>
    public TerraformValue<string> AwsDevice
        => AsReference("aws_device");

    /// <summary>
    /// The has_logical_redundancy attribute.
    /// </summary>
    public TerraformValue<string> HasLogicalRedundancy
        => AsReference("has_logical_redundancy");

    /// <summary>
    /// The jumbo_frame_capable attribute.
    /// </summary>
    public TerraformValue<bool> JumboFrameCapable
        => AsReference("jumbo_frame_capable");

    /// <summary>
    /// The macsec_capable attribute.
    /// </summary>
    public TerraformValue<bool> MacsecCapable
        => AsReference("macsec_capable");

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerAccountId
        => AsReference("owner_account_id");

    /// <summary>
    /// The partner_name attribute.
    /// </summary>
    public TerraformValue<string> PartnerName
        => AsReference("partner_name");

    /// <summary>
    /// The port_encryption_status attribute.
    /// </summary>
    public TerraformValue<string> PortEncryptionStatus
        => AsReference("port_encryption_status");

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    public TerraformValue<double> VlanId
        => AsReference("vlan_id");

}
