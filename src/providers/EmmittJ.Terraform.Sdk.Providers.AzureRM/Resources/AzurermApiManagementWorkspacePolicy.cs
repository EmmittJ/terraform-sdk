using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementWorkspacePolicyTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_api_management_workspace_policy Terraform resource.
/// Manages a azurerm_api_management_workspace_policy resource.
/// </summary>
public partial class AzurermApiManagementWorkspacePolicy(string name) : TerraformResource("azurerm_api_management_workspace_policy", name)
{
    /// <summary>
    /// The api_management_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementWorkspaceId is required")]
    public required TerraformValue<string> ApiManagementWorkspaceId
    {
        get => new TerraformReference<string>(this, "api_management_workspace_id");
        set => SetArgument("api_management_workspace_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The xml_content attribute.
    /// </summary>
    public TerraformValue<string> XmlContent
    {
        get => new TerraformReference<string>(this, "xml_content");
        set => SetArgument("xml_content", value);
    }

    /// <summary>
    /// The xml_link attribute.
    /// </summary>
    public TerraformValue<string>? XmlLink
    {
        get => new TerraformReference<string>(this, "xml_link");
        set => SetArgument("xml_link", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementWorkspacePolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementWorkspacePolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
