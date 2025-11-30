using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermEventhubNamespaceDisasterRecoveryConfig.
/// Nesting mode: single
/// </summary>
public class AzurermEventhubNamespaceDisasterRecoveryConfigTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_eventhub_namespace_disaster_recovery_config Terraform resource.
/// Manages a azurerm_eventhub_namespace_disaster_recovery_config resource.
/// </summary>
public partial class AzurermEventhubNamespaceDisasterRecoveryConfig(string name) : TerraformResource("azurerm_eventhub_namespace_disaster_recovery_config", name)
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
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    public required TerraformValue<string> NamespaceName
    {
        get => new TerraformReference<string>(this, "namespace_name");
        set => SetArgument("namespace_name", value);
    }

    /// <summary>
    /// The partner_namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerNamespaceId is required")]
    public required TerraformValue<string> PartnerNamespaceId
    {
        get => new TerraformReference<string>(this, "partner_namespace_id");
        set => SetArgument("partner_namespace_id", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermEventhubNamespaceDisasterRecoveryConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermEventhubNamespaceDisasterRecoveryConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
