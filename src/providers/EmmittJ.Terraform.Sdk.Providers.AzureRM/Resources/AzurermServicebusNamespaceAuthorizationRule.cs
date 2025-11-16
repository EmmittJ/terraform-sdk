using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermServicebusNamespaceAuthorizationRuleTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_servicebus_namespace_authorization_rule Terraform resource.
/// Manages a azurerm_servicebus_namespace_authorization_rule resource.
/// </summary>
public partial class AzurermServicebusNamespaceAuthorizationRule(string name) : TerraformResource("azurerm_servicebus_namespace_authorization_rule", name)
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
    /// The listen attribute.
    /// </summary>
    public TerraformValue<bool>? Listen
    {
        get => new TerraformReference<bool>(this, "listen");
        set => SetArgument("listen", value);
    }

    /// <summary>
    /// The manage attribute.
    /// </summary>
    public TerraformValue<bool>? Manage
    {
        get => new TerraformReference<bool>(this, "manage");
        set => SetArgument("manage", value);
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
    /// The namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceId is required")]
    public required TerraformValue<string> NamespaceId
    {
        get => new TerraformReference<string>(this, "namespace_id");
        set => SetArgument("namespace_id", value);
    }

    /// <summary>
    /// The send attribute.
    /// </summary>
    public TerraformValue<bool>? Send
    {
        get => new TerraformReference<bool>(this, "send");
        set => SetArgument("send", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermServicebusNamespaceAuthorizationRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermServicebusNamespaceAuthorizationRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
