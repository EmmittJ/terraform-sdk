using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for private_link in .
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorOriginPrivateLinkBlock : TerraformBlock
{
    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The private_link_target_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateLinkTargetId is required")]
    public required TerraformProperty<string> PrivateLinkTargetId
    {
        set => SetProperty("private_link_target_id", value);
    }

    /// <summary>
    /// The request_message attribute.
    /// </summary>
    public TerraformProperty<string>? RequestMessage
    {
        set => SetProperty("request_message", value);
    }

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    public TerraformProperty<string>? TargetType
    {
        set => SetProperty("target_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorOriginTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_cdn_frontdoor_origin resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermCdnFrontdoorOrigin : TerraformResource
{
    public AzurermCdnFrontdoorOrigin(string name) : base("azurerm_cdn_frontdoor_origin", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("cdn_frontdoor_origin_group_id");
        SetOutput("certificate_name_check_enabled");
        SetOutput("enabled");
        SetOutput("host_name");
        SetOutput("http_port");
        SetOutput("https_port");
        SetOutput("id");
        SetOutput("name");
        SetOutput("origin_host_header");
        SetOutput("priority");
        SetOutput("weight");
    }

    /// <summary>
    /// The cdn_frontdoor_origin_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorOriginGroupId is required")]
    public required TerraformProperty<string> CdnFrontdoorOriginGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cdn_frontdoor_origin_group_id");
        set => SetProperty("cdn_frontdoor_origin_group_id", value);
    }

    /// <summary>
    /// The certificate_name_check_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateNameCheckEnabled is required")]
    public required TerraformProperty<bool> CertificateNameCheckEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("certificate_name_check_enabled");
        set => SetProperty("certificate_name_check_enabled", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformProperty<string> HostName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("host_name");
        set => SetProperty("host_name", value);
    }

    /// <summary>
    /// The http_port attribute.
    /// </summary>
    public TerraformProperty<double> HttpPort
    {
        get => GetRequiredOutput<TerraformProperty<double>>("http_port");
        set => SetProperty("http_port", value);
    }

    /// <summary>
    /// The https_port attribute.
    /// </summary>
    public TerraformProperty<double> HttpsPort
    {
        get => GetRequiredOutput<TerraformProperty<double>>("https_port");
        set => SetProperty("https_port", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The origin_host_header attribute.
    /// </summary>
    public TerraformProperty<string> OriginHostHeader
    {
        get => GetRequiredOutput<TerraformProperty<string>>("origin_host_header");
        set => SetProperty("origin_host_header", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<double> Priority
    {
        get => GetRequiredOutput<TerraformProperty<double>>("priority");
        set => SetProperty("priority", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformProperty<double> Weight
    {
        get => GetRequiredOutput<TerraformProperty<double>>("weight");
        set => SetProperty("weight", value);
    }

    /// <summary>
    /// Block for private_link.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateLink block(s) allowed")]
    public List<AzurermCdnFrontdoorOriginPrivateLinkBlock>? PrivateLink
    {
        set => SetProperty("private_link", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermCdnFrontdoorOriginTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
