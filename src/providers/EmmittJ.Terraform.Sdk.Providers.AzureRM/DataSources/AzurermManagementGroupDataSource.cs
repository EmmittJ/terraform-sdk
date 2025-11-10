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
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
        this.WithOutput("all_management_group_ids");
        this.WithOutput("all_subscription_ids");
        this.WithOutput("management_group_ids");
        this.WithOutput("parent_management_group_id");
        this.WithOutput("subscription_ids");
        this.WithOutput("tenant_scoped_id");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermManagementGroupDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermManagementGroupDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
