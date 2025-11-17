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
        get => new TerraformReference<string>(this, "api_management_name");
        set => SetArgument("api_management_name", value);
    }

    /// <summary>
    /// The approval_required attribute.
    /// </summary>
    public TerraformValue<bool>? ApprovalRequired
    {
        get => new TerraformReference<bool>(this, "approval_required");
        set => SetArgument("approval_required", value);
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
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// The product_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductId is required")]
    public required TerraformValue<string> ProductId
    {
        get => new TerraformReference<string>(this, "product_id");
        set => SetArgument("product_id", value);
    }

    /// <summary>
    /// The published attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Published is required")]
    public required TerraformValue<bool> Published
    {
        get => new TerraformReference<bool>(this, "published");
        set => SetArgument("published", value);
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
    /// The subscription_required attribute.
    /// </summary>
    public TerraformValue<bool>? SubscriptionRequired
    {
        get => new TerraformReference<bool>(this, "subscription_required");
        set => SetArgument("subscription_required", value);
    }

    /// <summary>
    /// The subscriptions_limit attribute.
    /// </summary>
    public TerraformValue<double>? SubscriptionsLimit
    {
        get => new TerraformReference<double>(this, "subscriptions_limit");
        set => SetArgument("subscriptions_limit", value);
    }

    /// <summary>
    /// The terms attribute.
    /// </summary>
    public TerraformValue<string>? Terms
    {
        get => new TerraformReference<string>(this, "terms");
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
