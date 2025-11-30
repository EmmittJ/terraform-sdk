using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermGraphServicesAccountDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermGraphServicesAccountDataSourceTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_graph_services_account Terraform data source.
/// Retrieves information about a azurerm_graph_services_account.
/// </summary>
public partial class AzurermGraphServicesAccountDataSource(string name) : TerraformDataSource("azurerm_graph_services_account", name)
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The application_id attribute.
    /// </summary>
    public TerraformValue<string> ApplicationId
    {
        get => new TerraformReference<string>(this, "application_id");
    }

    /// <summary>
    /// The billing_plan_id attribute.
    /// </summary>
    public TerraformValue<string> BillingPlanId
    {
        get => new TerraformReference<string>(this, "billing_plan_id");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermGraphServicesAccountDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermGraphServicesAccountDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
