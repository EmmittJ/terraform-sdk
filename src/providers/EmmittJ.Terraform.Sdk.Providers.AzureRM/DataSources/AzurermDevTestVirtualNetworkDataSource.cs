using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDevTestVirtualNetworkDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_dev_test_virtual_network.
/// </summary>
public class AzurermDevTestVirtualNetworkDataSource : TerraformDataSource
{
    public AzurermDevTestVirtualNetworkDataSource(string name) : base("azurerm_dev_test_virtual_network", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutputllowed_subnets");
        this.WithOutputubnet_overrides");
        this.WithOutputnique_identifier");
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
    /// The lab_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LabName is required")]
    public required TerraformProperty<string> LabName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("lab_name");
        set => this.WithProperty("lab_name", value);
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
    public AzurermDevTestVirtualNetworkDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDevTestVirtualNetworkDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The allowed_subnets attribute.
    /// </summary>
    public TerraformExpression AllowedSubnets => this["allowed_subnets"];

    /// <summary>
    /// The subnet_overrides attribute.
    /// </summary>
    public TerraformExpression SubnetOverrides => this["subnet_overrides"];

    /// <summary>
    /// The unique_identifier attribute.
    /// </summary>
    public TerraformExpression UniqueIdentifier => this["unique_identifier"];

}
