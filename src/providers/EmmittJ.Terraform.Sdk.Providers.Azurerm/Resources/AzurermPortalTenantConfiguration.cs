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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The private_markdown_storage_enforced attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateMarkdownStorageEnforced is required")]
    public required TerraformValue<bool> PrivateMarkdownStorageEnforced
    {
        get => new TerraformReference<bool>(this, "private_markdown_storage_enforced");
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
