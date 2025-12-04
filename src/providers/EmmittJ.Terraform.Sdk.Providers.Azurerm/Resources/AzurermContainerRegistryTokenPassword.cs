using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for password1 in AzurermContainerRegistryTokenPassword.
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
    public TerraformValue<string>? Expiry
    {
        get => GetArgument<TerraformValue<string>>("expiry");
        set => SetArgument("expiry", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string> Value
        => AsReference("value");

}


/// <summary>
/// Block type for password2 in AzurermContainerRegistryTokenPassword.
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
    public TerraformValue<string>? Expiry
    {
        get => GetArgument<TerraformValue<string>>("expiry");
        set => SetArgument("expiry", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string> Value
        => AsReference("value");

}


/// <summary>
/// Block type for timeouts in AzurermContainerRegistryTokenPassword.
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
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_container_registry_token_password Terraform resource.
/// Manages a azurerm_container_registry_token_password resource.
/// </summary>
public partial class AzurermContainerRegistryTokenPassword(string name) : TerraformResource("azurerm_container_registry_token_password", name)
{
    /// <summary>
    /// The container_registry_token_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryTokenId is required")]
    public required TerraformValue<string> ContainerRegistryTokenId
    {
        get => GetRequiredArgument<TerraformValue<string>>("container_registry_token_id");
        set => SetArgument("container_registry_token_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Password1 block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password1 is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Password1 block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Password1 block(s) allowed")]
    public required TerraformList<AzurermContainerRegistryTokenPasswordPassword1Block> Password1
    {
        get => GetRequiredArgument<TerraformList<AzurermContainerRegistryTokenPasswordPassword1Block>>("password1");
        set => SetArgument("password1", value);
    }

    /// <summary>
    /// Password2 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Password2 block(s) allowed")]
    public TerraformList<AzurermContainerRegistryTokenPasswordPassword2Block>? Password2
    {
        get => GetArgument<TerraformList<AzurermContainerRegistryTokenPasswordPassword2Block>>("password2");
        set => SetArgument("password2", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermContainerRegistryTokenPasswordTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermContainerRegistryTokenPasswordTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
