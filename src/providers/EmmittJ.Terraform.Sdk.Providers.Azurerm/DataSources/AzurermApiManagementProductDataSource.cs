using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermApiManagementProductDataSource.
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
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_api_management_product Terraform data source.
/// Retrieves information about a azurerm_api_management_product.
/// </summary>
public partial class AzurermApiManagementProductDataSource(string name) : TerraformDataSource("azurerm_api_management_product", name)
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
    /// The approval_required attribute.
    /// </summary>
    public TerraformValue<bool> ApprovalRequired
        => AsReference("approval_required");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// The published attribute.
    /// </summary>
    public TerraformValue<bool> Published
        => AsReference("published");

    /// <summary>
    /// The subscription_required attribute.
    /// </summary>
    public TerraformValue<bool> SubscriptionRequired
        => AsReference("subscription_required");

    /// <summary>
    /// The subscriptions_limit attribute.
    /// </summary>
    public TerraformValue<double> SubscriptionsLimit
        => AsReference("subscriptions_limit");

    /// <summary>
    /// The terms attribute.
    /// </summary>
    public TerraformValue<string> Terms
        => AsReference("terms");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementProductDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementProductDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
