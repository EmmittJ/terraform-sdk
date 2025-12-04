using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermApiManagementApiTagDescription.
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
        get => GetRequiredArgument<TerraformValue<string>>("api_tag_id");
        set => SetArgument("api_tag_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The external_documentation_description attribute.
    /// </summary>
    public TerraformValue<string>? ExternalDocumentationDescription
    {
        get => GetArgument<TerraformValue<string>>("external_documentation_description");
        set => SetArgument("external_documentation_description", value);
    }

    /// <summary>
    /// The external_documentation_url attribute.
    /// </summary>
    public TerraformValue<string>? ExternalDocumentationUrl
    {
        get => GetArgument<TerraformValue<string>>("external_documentation_url");
        set => SetArgument("external_documentation_url", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementApiTagDescriptionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementApiTagDescriptionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
