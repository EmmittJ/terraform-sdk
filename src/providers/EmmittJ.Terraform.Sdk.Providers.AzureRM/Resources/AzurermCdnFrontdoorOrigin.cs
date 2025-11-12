using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for private_link in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCdnFrontdoorOriginPrivateLinkBlock() : TerraformBlock("private_link")
{
    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The private_link_target_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateLinkTargetId is required")]
    [TerraformProperty("private_link_target_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PrivateLinkTargetId { get; set; }

    /// <summary>
    /// The request_message attribute.
    /// </summary>
    [TerraformProperty("request_message")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RequestMessage { get; set; }

    /// <summary>
    /// The target_type attribute.
    /// </summary>
    [TerraformProperty("target_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCdnFrontdoorOriginTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_cdn_frontdoor_origin resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermCdnFrontdoorOrigin : TerraformResource
{
    public AzurermCdnFrontdoorOrigin(string name) : base("azurerm_cdn_frontdoor_origin", name)
    {
    }

    /// <summary>
    /// The cdn_frontdoor_origin_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorOriginGroupId is required")]
    [TerraformProperty("cdn_frontdoor_origin_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CdnFrontdoorOriginGroupId { get; set; }

    /// <summary>
    /// The certificate_name_check_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateNameCheckEnabled is required")]
    [TerraformProperty("certificate_name_check_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> CertificateNameCheckEnabled { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformProperty("host_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HostName { get; set; }

    /// <summary>
    /// The http_port attribute.
    /// </summary>
    [TerraformProperty("http_port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? HttpPort { get; set; }

    /// <summary>
    /// The https_port attribute.
    /// </summary>
    [TerraformProperty("https_port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? HttpsPort { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The origin_host_header attribute.
    /// </summary>
    [TerraformProperty("origin_host_header")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OriginHostHeader { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformProperty("priority")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Priority { get; set; }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [TerraformProperty("weight")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Weight { get; set; }

    /// <summary>
    /// Block for private_link.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateLink block(s) allowed")]
    [TerraformProperty("private_link")]
    public TerraformList<AzurermCdnFrontdoorOriginPrivateLinkBlock> PrivateLink { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermCdnFrontdoorOriginTimeoutsBlock Timeouts { get; set; } = new();

}
