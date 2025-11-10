using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDevCenterNetworkConnectionDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_dev_center_network_connection.
/// </summary>
public class AzurermDevCenterNetworkConnectionDataSource : TerraformDataSource
{
    public AzurermDevCenterNetworkConnectionDataSource(string name) : base("azurerm_dev_center_network_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("domain_join_type");
        this.WithOutput("domain_name");
        this.WithOutput("domain_username");
        this.WithOutput("location");
        this.WithOutput("organization_unit");
        this.WithOutput("subnet_id");
        this.WithOutput("tags");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDevCenterNetworkConnectionDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDevCenterNetworkConnectionDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The domain_join_type attribute.
    /// </summary>
    public TerraformExpression DomainJoinType => this["domain_join_type"];

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformExpression DomainName => this["domain_name"];

    /// <summary>
    /// The domain_username attribute.
    /// </summary>
    public TerraformExpression DomainUsername => this["domain_username"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The organization_unit attribute.
    /// </summary>
    public TerraformExpression OrganizationUnit => this["organization_unit"];

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformExpression SubnetId => this["subnet_id"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
