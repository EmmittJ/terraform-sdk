using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for private_link in AzurermCdnFrontdoorOrigin.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorOriginPrivateLinkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "private_link";

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
    /// The private_link_target_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateLinkTargetId is required")]
    public required TerraformValue<string> PrivateLinkTargetId
    {
        get => new TerraformReference<string>(this, "private_link_target_id");
        set => SetArgument("private_link_target_id", value);
    }

    /// <summary>
    /// The request_message attribute.
    /// </summary>
    public TerraformValue<string>? RequestMessage
    {
        get => new TerraformReference<string>(this, "request_message");
        set => SetArgument("request_message", value);
    }

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    public TerraformValue<string>? TargetType
    {
        get => new TerraformReference<string>(this, "target_type");
        set => SetArgument("target_type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermCdnFrontdoorOrigin.
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorOriginTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_cdn_frontdoor_origin Terraform resource.
/// Manages a azurerm_cdn_frontdoor_origin resource.
/// </summary>
public partial class AzurermCdnFrontdoorOrigin(string name) : TerraformResource("azurerm_cdn_frontdoor_origin", name)
{
    /// <summary>
    /// The cdn_frontdoor_origin_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorOriginGroupId is required")]
    public required TerraformValue<string> CdnFrontdoorOriginGroupId
    {
        get => new TerraformReference<string>(this, "cdn_frontdoor_origin_group_id");
        set => SetArgument("cdn_frontdoor_origin_group_id", value);
    }

    /// <summary>
    /// The certificate_name_check_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateNameCheckEnabled is required")]
    public required TerraformValue<bool> CertificateNameCheckEnabled
    {
        get => new TerraformReference<bool>(this, "certificate_name_check_enabled");
        set => SetArgument("certificate_name_check_enabled", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformValue<string> HostName
    {
        get => new TerraformReference<string>(this, "host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The http_port attribute.
    /// </summary>
    public TerraformValue<double>? HttpPort
    {
        get => new TerraformReference<double>(this, "http_port");
        set => SetArgument("http_port", value);
    }

    /// <summary>
    /// The https_port attribute.
    /// </summary>
    public TerraformValue<double>? HttpsPort
    {
        get => new TerraformReference<double>(this, "https_port");
        set => SetArgument("https_port", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The origin_host_header attribute.
    /// </summary>
    public TerraformValue<string>? OriginHostHeader
    {
        get => new TerraformReference<string>(this, "origin_host_header");
        set => SetArgument("origin_host_header", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => new TerraformReference<double>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformValue<double>? Weight
    {
        get => new TerraformReference<double>(this, "weight");
        set => SetArgument("weight", value);
    }

    /// <summary>
    /// PrivateLink block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateLink block(s) allowed")]
    public TerraformList<AzurermCdnFrontdoorOriginPrivateLinkBlock>? PrivateLink
    {
        get => GetArgument<TerraformList<AzurermCdnFrontdoorOriginPrivateLinkBlock>>("private_link");
        set => SetArgument("private_link", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCdnFrontdoorOriginTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCdnFrontdoorOriginTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
