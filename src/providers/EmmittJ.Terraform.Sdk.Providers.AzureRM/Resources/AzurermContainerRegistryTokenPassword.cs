using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for password1 in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerRegistryTokenPasswordPassword1Block : TerraformBlockBase
{
    /// <summary>
    /// The expiry attribute.
    /// </summary>
    [TerraformProperty("expiry")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Expiry { get; set; }


}

/// <summary>
/// Block type for password2 in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerRegistryTokenPasswordPassword2Block : TerraformBlockBase
{
    /// <summary>
    /// The expiry attribute.
    /// </summary>
    [TerraformProperty("expiry")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Expiry { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermContainerRegistryTokenPasswordTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_container_registry_token_password resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermContainerRegistryTokenPassword : TerraformResource
{
    public AzurermContainerRegistryTokenPassword(string name) : base("azurerm_container_registry_token_password", name)
    {
    }

    /// <summary>
    /// The container_registry_token_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryTokenId is required")]
    [TerraformProperty("container_registry_token_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ContainerRegistryTokenId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for password1.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password1 is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Password1 block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Password1 block(s) allowed")]
    [TerraformProperty("password1")]
    public TerraformList<TerraformBlock<AzurermContainerRegistryTokenPasswordPassword1Block>>? Password1 { get; set; }

    /// <summary>
    /// Block for password2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Password2 block(s) allowed")]
    [TerraformProperty("password2")]
    public TerraformList<TerraformBlock<AzurermContainerRegistryTokenPasswordPassword2Block>>? Password2 { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermContainerRegistryTokenPasswordTimeoutsBlock>? Timeouts { get; set; }

}
