using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for authentication in .
/// Nesting mode: list
/// </summary>
public partial class AzurermAppServiceConnectionAuthenticationBlock() : TerraformBlock("authentication")
{
    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [TerraformProperty("certificate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Certificate { get; set; }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformProperty("client_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformProperty("principal_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrincipalId { get; set; }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [TerraformProperty("secret")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Secret { get; set; }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [TerraformProperty("subscription_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SubscriptionId { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for secret_store in .
/// Nesting mode: list
/// </summary>
public partial class AzurermAppServiceConnectionSecretStoreBlock() : TerraformBlock("secret_store")
{
    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformProperty("key_vault_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyVaultId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAppServiceConnectionTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_app_service_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermAppServiceConnection : TerraformResource
{
    public AzurermAppServiceConnection(string name) : base("azurerm_app_service_connection", name)
    {
    }

    /// <summary>
    /// The app_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServiceId is required")]
    [TerraformProperty("app_service_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AppServiceId { get; set; }

    /// <summary>
    /// The client_type attribute.
    /// </summary>
    [TerraformProperty("client_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientType { get; set; }

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
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    [TerraformProperty("target_resource_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetResourceId { get; set; }

    /// <summary>
    /// The vnet_solution attribute.
    /// </summary>
    [TerraformProperty("vnet_solution")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VnetSolution { get; set; }

    /// <summary>
    /// Block for authentication.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authentication is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Authentication block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Authentication block(s) allowed")]
    [TerraformProperty("authentication")]
    public required TerraformList<AzurermAppServiceConnectionAuthenticationBlock> Authentication { get; set; } = new();

    /// <summary>
    /// Block for secret_store.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecretStore block(s) allowed")]
    [TerraformProperty("secret_store")]
    public TerraformList<AzurermAppServiceConnectionSecretStoreBlock> SecretStore { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermAppServiceConnectionTimeoutsBlock Timeouts { get; set; } = new();

}
