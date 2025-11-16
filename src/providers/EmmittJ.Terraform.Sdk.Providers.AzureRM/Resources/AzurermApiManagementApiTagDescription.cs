using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementApiTagDescriptionTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_api_management_api_tag_description Terraform resource.
/// Manages a azurerm_api_management_api_tag_description resource.
/// </summary>
public partial class AzurermApiManagementApiTagDescription(string name) : TerraformResource("azurerm_api_management_api_tag_description", name)
{
    /// <summary>
    /// The api_tag_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiTagId is required")]
    public required TerraformValue<string> ApiTagId
    {
        get => new TerraformReference<string>(this, "api_tag_id");
        set => SetArgument("api_tag_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The external_documentation_description attribute.
    /// </summary>
    public TerraformValue<string>? ExternalDocumentationDescription
    {
        get => new TerraformReference<string>(this, "external_documentation_description");
        set => SetArgument("external_documentation_description", value);
    }

    /// <summary>
    /// The external_documentation_url attribute.
    /// </summary>
    public TerraformValue<string>? ExternalDocumentationUrl
    {
        get => new TerraformReference<string>(this, "external_documentation_url");
        set => SetArgument("external_documentation_url", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementApiTagDescriptionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementApiTagDescriptionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
