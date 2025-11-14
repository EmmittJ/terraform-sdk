using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_api_management_api_tag_description resource.
/// </summary>
public class AzurermApiManagementApiTagDescription : TerraformResource
{
    public AzurermApiManagementApiTagDescription(string name) : base("azurerm_api_management_api_tag_description", name)
    {
    }

    /// <summary>
    /// The api_tag_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiTagId is required")]
    [TerraformArgument("api_tag_id")]
    public required TerraformValue<string> ApiTagId
    {
        get => new TerraformReference<string>(this, "api_tag_id");
        set => SetArgument("api_tag_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The external_documentation_description attribute.
    /// </summary>
    [TerraformArgument("external_documentation_description")]
    public TerraformValue<string>? ExternalDocumentationDescription
    {
        get => new TerraformReference<string>(this, "external_documentation_description");
        set => SetArgument("external_documentation_description", value);
    }

    /// <summary>
    /// The external_documentation_url attribute.
    /// </summary>
    [TerraformArgument("external_documentation_url")]
    public TerraformValue<string>? ExternalDocumentationUrl
    {
        get => new TerraformReference<string>(this, "external_documentation_url");
        set => SetArgument("external_documentation_url", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermApiManagementApiTagDescriptionTimeoutsBlock Timeouts { get; set; } = new();

}
