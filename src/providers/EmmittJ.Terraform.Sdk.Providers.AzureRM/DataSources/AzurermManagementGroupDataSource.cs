using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermManagementGroupDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_management_group.
/// </summary>
public class AzurermManagementGroupDataSource : TerraformDataSource
{
    public AzurermManagementGroupDataSource(string name) : base("azurerm_management_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("all_management_group_ids");
        SetOutput("all_subscription_ids");
        SetOutput("management_group_ids");
        SetOutput("parent_management_group_id");
        SetOutput("subscription_ids");
        SetOutput("tenant_scoped_id");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("name");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermManagementGroupDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The all_management_group_ids attribute.
    /// </summary>
    public TerraformExpression AllManagementGroupIds => this["all_management_group_ids"];

    /// <summary>
    /// The all_subscription_ids attribute.
    /// </summary>
    public TerraformExpression AllSubscriptionIds => this["all_subscription_ids"];

    /// <summary>
    /// The management_group_ids attribute.
    /// </summary>
    public TerraformExpression ManagementGroupIds => this["management_group_ids"];

    /// <summary>
    /// The parent_management_group_id attribute.
    /// </summary>
    public TerraformExpression ParentManagementGroupId => this["parent_management_group_id"];

    /// <summary>
    /// The subscription_ids attribute.
    /// </summary>
    public TerraformExpression SubscriptionIds => this["subscription_ids"];

    /// <summary>
    /// The tenant_scoped_id attribute.
    /// </summary>
    public TerraformExpression TenantScopedId => this["tenant_scoped_id"];

}
