using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for auto_scale_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNginxDeploymentAutoScaleProfileBlock() : TerraformBlock("auto_scale_profile")
{
    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxCapacity is required")]
    [TerraformProperty("max_capacity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MaxCapacity { get; set; }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    [TerraformProperty("min_capacity")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MinCapacity { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for frontend_private in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNginxDeploymentFrontendPrivateBlock() : TerraformBlock("frontend_private")
{
    /// <summary>
    /// The allocation_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllocationMethod is required")]
    [TerraformProperty("allocation_method")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AllocationMethod { get; set; }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAddress is required")]
    [TerraformProperty("ip_address")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IpAddress { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubnetId { get; set; }

}

/// <summary>
/// Block type for frontend_public in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNginxDeploymentFrontendPublicBlock() : TerraformBlock("frontend_public")
{
    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? IpAddress { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNginxDeploymentIdentityBlock() : TerraformBlock("identity")
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for logging_storage_account in .
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public partial class AzurermNginxDeploymentLoggingStorageAccountBlock() : TerraformBlock("logging_storage_account")
{
    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [TerraformProperty("container_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContainerName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

}

/// <summary>
/// Block type for network_interface in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNginxDeploymentNetworkInterfaceBlock() : TerraformBlock("network_interface")
{
    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubnetId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNginxDeploymentTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Block type for web_application_firewall in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNginxDeploymentWebApplicationFirewallBlock() : TerraformBlock("web_application_firewall")
{
    /// <summary>
    /// The activation_state_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActivationStateEnabled is required")]
    [TerraformProperty("activation_state_enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> ActivationStateEnabled { get; set; }


}

/// <summary>
/// Manages a azurerm_nginx_deployment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermNginxDeployment : TerraformResource
{
    public AzurermNginxDeployment(string name) : base("azurerm_nginx_deployment", name)
    {
    }

    /// <summary>
    /// The automatic_upgrade_channel attribute.
    /// </summary>
    [TerraformProperty("automatic_upgrade_channel")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AutomaticUpgradeChannel { get; set; }

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [TerraformProperty("capacity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Capacity { get; set; }

    /// <summary>
    /// The diagnose_support_enabled attribute.
    /// </summary>
    [TerraformProperty("diagnose_support_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DiagnoseSupportEnabled { get; set; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformProperty("email")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Email { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The managed_resource_group attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("managed_resource_group")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ManagedResourceGroup { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformProperty("sku")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Sku { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for auto_scale_profile.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("auto_scale_profile")]
    public TerraformList<AzurermNginxDeploymentAutoScaleProfileBlock> AutoScaleProfile { get; set; } = new();

    /// <summary>
    /// Block for frontend_private.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("frontend_private")]
    public TerraformList<AzurermNginxDeploymentFrontendPrivateBlock> FrontendPrivate { get; set; } = new();

    /// <summary>
    /// Block for frontend_public.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FrontendPublic block(s) allowed")]
    [TerraformProperty("frontend_public")]
    public TerraformList<AzurermNginxDeploymentFrontendPublicBlock> FrontendPublic { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermNginxDeploymentIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for logging_storage_account.
    /// Nesting mode: list
    /// </summary>
    [Obsolete("This block is deprecated.")]
    [TerraformProperty("logging_storage_account")]
    public TerraformList<AzurermNginxDeploymentLoggingStorageAccountBlock> LoggingStorageAccount { get; set; } = new();

    /// <summary>
    /// Block for network_interface.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("network_interface")]
    public TerraformList<AzurermNginxDeploymentNetworkInterfaceBlock> NetworkInterface { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermNginxDeploymentTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for web_application_firewall.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebApplicationFirewall block(s) allowed")]
    [TerraformProperty("web_application_firewall")]
    public TerraformList<AzurermNginxDeploymentWebApplicationFirewallBlock> WebApplicationFirewall { get; set; } = new();

    /// <summary>
    /// The dataplane_api_endpoint attribute.
    /// </summary>
    [TerraformProperty("dataplane_api_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DataplaneApiEndpoint { get; }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpAddress { get; }

    /// <summary>
    /// The nginx_version attribute.
    /// </summary>
    [TerraformProperty("nginx_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NginxVersion { get; }

}
