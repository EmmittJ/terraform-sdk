using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermApiManagementProduct.
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementProductTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_api_management_product Terraform resource.
/// Manages a azurerm_api_management_product resource.
/// </summary>
public partial class AzurermApiManagementProduct(string name) : TerraformResource("azurerm_api_management_product", name)
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
    /// The approval_required attribute.
    /// </summary>
    public TerraformValue<bool>? ApprovalRequired
    {
        get => GetArgument<TerraformValue<bool>>("approval_required");
        set => SetArgument("approval_required", value);
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
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
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
    /// The published attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Published is required")]
    public required TerraformValue<bool> Published
    {
        get => GetArgument<TerraformValue<bool>>("published");
        set => SetArgument("published", value);
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
    /// The subscription_required attribute.
    /// </summary>
    public TerraformValue<bool>? SubscriptionRequired
    {
        get => GetArgument<TerraformValue<bool>>("subscription_required");
        set => SetArgument("subscription_required", value);
    }

    /// <summary>
    /// The subscriptions_limit attribute.
    /// </summary>
    public TerraformValue<double>? SubscriptionsLimit
    {
        get => GetArgument<TerraformValue<double>>("subscriptions_limit");
        set => SetArgument("subscriptions_limit", value);
    }

    /// <summary>
    /// The terms attribute.
    /// </summary>
    public TerraformValue<string>? Terms
    {
        get => GetArgument<TerraformValue<string>>("terms");
        set => SetArgument("terms", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementProductTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementProductTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
