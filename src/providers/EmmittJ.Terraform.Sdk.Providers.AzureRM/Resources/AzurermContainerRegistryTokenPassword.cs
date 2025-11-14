using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for password1 in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTokenPasswordPassword1Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "password1";

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    [TerraformArgument("expiry")]
    public TerraformValue<string>? Expiry
    {
        get => new TerraformReference<string>(this, "expiry");
        set => SetArgument("expiry", value);
    }


}

/// <summary>
/// Block type for password2 in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTokenPasswordPassword2Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "password2";

    /// <summary>
    /// The expiry attribute.
    /// </summary>
    [TerraformArgument("expiry")]
    public TerraformValue<string>? Expiry
    {
        get => new TerraformReference<string>(this, "expiry");
        set => SetArgument("expiry", value);
    }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerRegistryTokenPasswordTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

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
    [TerraformArgument("container_registry_token_id")]
    public required TerraformValue<string> ContainerRegistryTokenId
    {
        get => new TerraformReference<string>(this, "container_registry_token_id");
        set => SetArgument("container_registry_token_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Block for password1.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password1 is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Password1 block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Password1 block(s) allowed")]
    [TerraformArgument("password1")]
    public required TerraformList<AzurermContainerRegistryTokenPasswordPassword1Block> Password1 { get; set; } = new();

    /// <summary>
    /// Block for password2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Password2 block(s) allowed")]
    [TerraformArgument("password2")]
    public TerraformList<AzurermContainerRegistryTokenPasswordPassword2Block> Password2 { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermContainerRegistryTokenPasswordTimeoutsBlock Timeouts { get; set; } = new();

}
