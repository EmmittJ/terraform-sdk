using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermRelayNamespaceAuthorizationRule.
/// Nesting mode: single
/// </summary>
public class AzurermRelayNamespaceAuthorizationRuleTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_relay_namespace_authorization_rule Terraform resource.
/// Manages a azurerm_relay_namespace_authorization_rule resource.
/// </summary>
public partial class AzurermRelayNamespaceAuthorizationRule(string name) : TerraformResource("azurerm_relay_namespace_authorization_rule", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The listen attribute.
    /// </summary>
    public TerraformValue<bool>? Listen
    {
        get => GetArgument<TerraformValue<bool>>("listen");
        set => SetArgument("listen", value);
    }

    /// <summary>
    /// The manage attribute.
    /// </summary>
    public TerraformValue<bool>? Manage
    {
        get => GetArgument<TerraformValue<bool>>("manage");
        set => SetArgument("manage", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    public required TerraformValue<string> NamespaceName
    {
        get => GetArgument<TerraformValue<string>>("namespace_name");
        set => SetArgument("namespace_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The send attribute.
    /// </summary>
    public TerraformValue<bool>? Send
    {
        get => GetArgument<TerraformValue<bool>>("send");
        set => SetArgument("send", value);
    }

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> PrimaryConnectionString
        => AsReference("primary_connection_string");

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryKey
        => AsReference("primary_key");

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    public TerraformValue<string> SecondaryConnectionString
        => AsReference("secondary_connection_string");

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryKey
        => AsReference("secondary_key");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermRelayNamespaceAuthorizationRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermRelayNamespaceAuthorizationRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
