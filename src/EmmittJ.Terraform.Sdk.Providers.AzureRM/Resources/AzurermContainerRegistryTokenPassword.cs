using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for password1 in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTokenPasswordPassword1Block : TerraformBlock
{
    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformProperty<string>? Expiry
    {
        get => GetProperty<TerraformProperty<string>>("expiry");
        set => WithProperty("expiry", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for password2 in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerRegistryTokenPasswordPassword2Block : TerraformBlock
{
    /// <summary>
    /// The expiry attribute.
    /// </summary>
    public TerraformProperty<string>? Expiry
    {
        get => GetProperty<TerraformProperty<string>>("expiry");
        set => WithProperty("expiry", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerRegistryTokenPasswordTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_container_registry_token_password resource.
/// </summary>
public class AzurermContainerRegistryTokenPassword : TerraformResource
{
    public AzurermContainerRegistryTokenPassword(string name) : base("azurerm_container_registry_token_password", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The container_registry_token_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryTokenId is required")]
    public required TerraformProperty<string> ContainerRegistryTokenId
    {
        get => GetProperty<TerraformProperty<string>>("container_registry_token_id");
        set => this.WithProperty("container_registry_token_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Block for password1.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Password1 block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Password1 block(s) allowed")]
    public List<AzurermContainerRegistryTokenPasswordPassword1Block>? Password1
    {
        get => GetProperty<List<AzurermContainerRegistryTokenPasswordPassword1Block>>("password1");
        set => this.WithProperty("password1", value);
    }

    /// <summary>
    /// Block for password2.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Password2 block(s) allowed")]
    public List<AzurermContainerRegistryTokenPasswordPassword2Block>? Password2
    {
        get => GetProperty<List<AzurermContainerRegistryTokenPasswordPassword2Block>>("password2");
        set => this.WithProperty("password2", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerRegistryTokenPasswordTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermContainerRegistryTokenPasswordTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
