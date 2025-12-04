using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermApiManagementProductPolicy.
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementProductPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_api_management_product_policy Terraform resource.
/// Manages a azurerm_api_management_product_policy resource.
/// </summary>
public partial class AzurermApiManagementProductPolicy(string name) : TerraformResource("azurerm_api_management_product_policy", name)
{
    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    public required TerraformValue<string> ApiManagementName
    {
        get => GetArgument<TerraformValue<string>>("api_management_name");
        set => SetArgument("api_management_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductId is required")]
    public required TerraformValue<string> ProductId
    {
        get => GetArgument<TerraformValue<string>>("product_id");
        set => SetArgument("product_id", value);
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
    /// The xml_content attribute.
    /// </summary>
    public TerraformValue<string>? XmlContent
    {
        get => GetArgument<TerraformValue<string>>("xml_content");
        set => SetArgument("xml_content", value);
    }

    /// <summary>
    /// The xml_link attribute.
    /// </summary>
    public TerraformValue<string>? XmlLink
    {
        get => GetArgument<TerraformValue<string>>("xml_link");
        set => SetArgument("xml_link", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementProductPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementProductPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
