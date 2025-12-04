using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermPortalTenantConfiguration.
/// Nesting mode: single
/// </summary>
public class AzurermPortalTenantConfigurationTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_portal_tenant_configuration Terraform resource.
/// Manages a azurerm_portal_tenant_configuration resource.
/// </summary>
public partial class AzurermPortalTenantConfiguration(string name) : TerraformResource("azurerm_portal_tenant_configuration", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The private_markdown_storage_enforced attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateMarkdownStorageEnforced is required")]
    public required TerraformValue<bool> PrivateMarkdownStorageEnforced
    {
        get => GetRequiredArgument<TerraformValue<bool>>("private_markdown_storage_enforced");
        set => SetArgument("private_markdown_storage_enforced", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPortalTenantConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPortalTenantConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
