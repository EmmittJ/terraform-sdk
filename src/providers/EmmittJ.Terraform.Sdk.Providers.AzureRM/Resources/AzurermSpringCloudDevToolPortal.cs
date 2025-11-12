using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for sso in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSpringCloudDevToolPortalSsoBlock() : TerraformBlock("sso")
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformProperty("client_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientId { get; set; }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [TerraformProperty("client_secret")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientSecret { get; set; }

    /// <summary>
    /// The metadata_url attribute.
    /// </summary>
    [TerraformProperty("metadata_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MetadataUrl { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformProperty("scope")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Scope { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSpringCloudDevToolPortalTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_spring_cloud_dev_tool_portal resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSpringCloudDevToolPortal : TerraformResource
{
    public AzurermSpringCloudDevToolPortal(string name) : base("azurerm_spring_cloud_dev_tool_portal", name)
    {
    }

    /// <summary>
    /// The application_accelerator_enabled attribute.
    /// </summary>
    [TerraformProperty("application_accelerator_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> ApplicationAcceleratorEnabled { get; set; }

    /// <summary>
    /// The application_live_view_enabled attribute.
    /// </summary>
    [TerraformProperty("application_live_view_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> ApplicationLiveViewEnabled { get; set; }

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
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    [TerraformProperty("spring_cloud_service_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SpringCloudServiceId { get; set; }

    /// <summary>
    /// Block for sso.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sso block(s) allowed")]
    [TerraformProperty("sso")]
    public TerraformList<AzurermSpringCloudDevToolPortalSsoBlock> Sso { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermSpringCloudDevToolPortalTimeoutsBlock Timeouts { get; set; } = new();

}
