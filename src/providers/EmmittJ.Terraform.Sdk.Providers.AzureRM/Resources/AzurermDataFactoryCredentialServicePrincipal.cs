using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for service_principal_key in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryCredentialServicePrincipalServicePrincipalKeyBlock : TerraformBlockBase
{
    /// <summary>
    /// The linked_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LinkedServiceName is required")]
    [TerraformProperty("linked_service_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LinkedServiceName { get; set; }

    /// <summary>
    /// The secret_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretName is required")]
    [TerraformProperty("secret_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SecretName { get; set; }

    /// <summary>
    /// The secret_version attribute.
    /// </summary>
    [TerraformProperty("secret_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SecretVersion { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataFactoryCredentialServicePrincipalTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_data_factory_credential_service_principal resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermDataFactoryCredentialServicePrincipal : TerraformResource
{
    public AzurermDataFactoryCredentialServicePrincipal(string name) : base("azurerm_data_factory_credential_service_principal", name)
    {
    }

    /// <summary>
    /// (Optional) List of string annotations.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? Annotations { get; set; }

    /// <summary>
    /// The resource ID of the parent Data Factory
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformProperty("data_factory_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DataFactoryId { get; set; }

    /// <summary>
    /// (Optional) Short text description
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The desired name of the credential resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The Client ID of the Service Principal
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalId is required")]
    [TerraformProperty("service_principal_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServicePrincipalId { get; set; }

    /// <summary>
    /// The Tenant ID of the Service Principal
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    [TerraformProperty("tenant_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TenantId { get; set; }

    /// <summary>
    /// Block for service_principal_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServicePrincipalKey block(s) allowed")]
    [TerraformProperty("service_principal_key")]
    public TerraformList<TerraformBlock<AzurermDataFactoryCredentialServicePrincipalServicePrincipalKeyBlock>>? ServicePrincipalKey { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermDataFactoryCredentialServicePrincipalTimeoutsBlock>? Timeouts { get; set; }

}
