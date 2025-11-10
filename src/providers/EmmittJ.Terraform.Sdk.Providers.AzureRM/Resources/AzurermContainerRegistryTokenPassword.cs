using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for password1 in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTokenPasswordPassword1Block : ITerraformBlock
{
    /// <summary>
    /// The expiry attribute.
    /// </summary>
    [TerraformPropertyName("expiry")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Expiry { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Value => new TerraformReferenceProperty<TerraformProperty<string>>("", "value");

}

/// <summary>
/// Block type for password2 in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTokenPasswordPassword2Block : ITerraformBlock
{
    /// <summary>
    /// The expiry attribute.
    /// </summary>
    [TerraformPropertyName("expiry")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Expiry { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Value => new TerraformReferenceProperty<TerraformProperty<string>>("", "value");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerRegistryTokenPasswordTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_container_registry_token_password resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermContainerRegistryTokenPassword : TerraformResource
{
    public AzurermContainerRegistryTokenPassword(string name) : base("azurerm_container_registry_token_password", name)
    {
    }

    /// <summary>
    /// The container_registry_token_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryTokenId is required")]
    [TerraformPropertyName("container_registry_token_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ContainerRegistryTokenId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Block for password1.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password1 is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Password1 block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Password1 block(s) allowed")]
    [TerraformPropertyName("password1")]
    public TerraformList<TerraformBlock<AzurermContainerRegistryTokenPasswordPassword1Block>>? Password1 { get; set; } = new();

    /// <summary>
    /// Block for password2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Password2 block(s) allowed")]
    [TerraformPropertyName("password2")]
    public TerraformList<TerraformBlock<AzurermContainerRegistryTokenPasswordPassword2Block>>? Password2 { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermContainerRegistryTokenPasswordTimeoutsBlock>? Timeouts { get; set; } = new();

}
