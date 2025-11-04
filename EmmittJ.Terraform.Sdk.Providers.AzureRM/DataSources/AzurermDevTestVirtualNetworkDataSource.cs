using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("allowed_subnets");
        this.DeclareOutput("subnet_overrides");
        this.DeclareOutput("unique_identifier");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The lab_name attribute.
    /// </summary>
    public string? LabName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lab_name")?.Value;
        set => this.WithProperty("lab_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
