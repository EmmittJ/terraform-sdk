using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermRelayHybridConnection.
/// Nesting mode: single
/// </summary>
public class AzurermRelayHybridConnectionTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_relay_hybrid_connection Terraform resource.
/// Manages a azurerm_relay_hybrid_connection resource.
/// </summary>
public partial class AzurermRelayHybridConnection(string name) : TerraformResource("azurerm_relay_hybrid_connection", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The relay_namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelayNamespaceName is required")]
    public required TerraformValue<string> RelayNamespaceName
    {
        get => new TerraformReference<string>(this, "relay_namespace_name");
        set => SetArgument("relay_namespace_name", value);
    }

    /// <summary>
    /// The requires_client_authorization attribute.
    /// </summary>
    public TerraformValue<bool>? RequiresClientAuthorization
    {
        get => new TerraformReference<bool>(this, "requires_client_authorization");
        set => SetArgument("requires_client_authorization", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The user_metadata attribute.
    /// </summary>
    public TerraformValue<string>? UserMetadata
    {
        get => new TerraformReference<string>(this, "user_metadata");
        set => SetArgument("user_metadata", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermRelayHybridConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermRelayHybridConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
