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
public class AzurermApiManagementProductDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_api_management_product.
/// </summary>
public class AzurermApiManagementProductDataSource : TerraformDataSource
{
    public AzurermApiManagementProductDataSource(string name) : base("azurerm_api_management_product", name)
    {
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    [TerraformArgument("api_management_name")]
    public required TerraformValue<string> ApiManagementName
    {
        get => new TerraformReference<string>(this, "api_management_name");
        set => SetArgument("api_management_name", value);
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
    /// The product_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductId is required")]
    [TerraformArgument("product_id")]
    public required TerraformValue<string> ProductId
    {
        get => new TerraformReference<string>(this, "product_id");
        set => SetArgument("product_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermApiManagementProductDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The approval_required attribute.
    /// </summary>
    [TerraformArgument("approval_required")]
    public TerraformValue<bool> ApprovalRequired
    {
        get => new TerraformReference<bool>(this, "approval_required");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformArgument("display_name")]
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The published attribute.
    /// </summary>
    [TerraformArgument("published")]
    public TerraformValue<bool> Published
    {
        get => new TerraformReference<bool>(this, "published");
    }

    /// <summary>
    /// The subscription_required attribute.
    /// </summary>
    [TerraformArgument("subscription_required")]
    public TerraformValue<bool> SubscriptionRequired
    {
        get => new TerraformReference<bool>(this, "subscription_required");
    }

    /// <summary>
    /// The subscriptions_limit attribute.
    /// </summary>
    [TerraformArgument("subscriptions_limit")]
    public TerraformValue<double> SubscriptionsLimit
    {
        get => new TerraformReference<double>(this, "subscriptions_limit");
    }

    /// <summary>
    /// The terms attribute.
    /// </summary>
    [TerraformArgument("terms")]
    public TerraformValue<string> Terms
    {
        get => new TerraformReference<string>(this, "terms");
    }

}
