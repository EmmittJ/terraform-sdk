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
        get => new TerraformReference<string>(this, "bandwidth");
        set => SetArgument("bandwidth", value);
    }

    /// <summary>
    /// The encryption_mode attribute.
    /// </summary>
    public TerraformValue<string> EncryptionMode
    {
        get => new TerraformReference<string>(this, "encryption_mode");
        set => SetArgument("encryption_mode", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    public TerraformValue<string> ProviderName
    {
        get => new TerraformReference<string>(this, "provider_name");
        set => SetArgument("provider_name", value);
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
    /// The request_macsec attribute.
    /// </summary>
    public TerraformValue<bool>? RequestMacsec
    {
        get => new TerraformReference<bool>(this, "request_macsec");
        set => SetArgument("request_macsec", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? SkipDestroy
    {
        get => new TerraformReference<bool>(this, "skip_destroy");
        set => SetArgument("skip_destroy", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The aws_device attribute.
    /// </summary>
    public TerraformValue<string> AwsDevice
    {
        get => new TerraformReference<string>(this, "aws_device");
    }

    /// <summary>
    /// The has_logical_redundancy attribute.
    /// </summary>
    public TerraformValue<string> HasLogicalRedundancy
    {
        get => new TerraformReference<string>(this, "has_logical_redundancy");
    }

    /// <summary>
    /// The jumbo_frame_capable attribute.
    /// </summary>
    public TerraformValue<bool> JumboFrameCapable
    {
        get => new TerraformReference<bool>(this, "jumbo_frame_capable");
    }

    /// <summary>
    /// The macsec_capable attribute.
    /// </summary>
    public TerraformValue<bool> MacsecCapable
    {
        get => new TerraformReference<bool>(this, "macsec_capable");
    }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerAccountId
    {
        get => new TerraformReference<string>(this, "owner_account_id");
    }

    /// <summary>
    /// The partner_name attribute.
    /// </summary>
    public TerraformValue<string> PartnerName
    {
        get => new TerraformReference<string>(this, "partner_name");
    }

    /// <summary>
    /// The port_encryption_status attribute.
    /// </summary>
    public TerraformValue<string> PortEncryptionStatus
    {
        get => new TerraformReference<string>(this, "port_encryption_status");
    }

    /// <summary>
    /// The vlan_id attribute.
    /// </summary>
    public TerraformValue<double> VlanId
    {
        get => new TerraformReference<double>(this, "vlan_id");
    }

}
