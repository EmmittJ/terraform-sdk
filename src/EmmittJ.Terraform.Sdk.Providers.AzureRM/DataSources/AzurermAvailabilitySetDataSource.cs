using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_availability_set.
/// </summary>
public class AzurermAvailabilitySetDataSource : TerraformDataSource
{
    public AzurermAvailabilitySetDataSource(string name) : base("azurerm_availability_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("location");
        this.DeclareOutput("managed");
        this.DeclareOutput("platform_fault_domain_count");
        this.DeclareOutput("platform_update_domain_count");
        this.DeclareOutput("tags");
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The managed attribute.
    /// </summary>
    public TerraformExpression Managed => this["managed"];

    /// <summary>
    /// The platform_fault_domain_count attribute.
    /// </summary>
    public TerraformExpression PlatformFaultDomainCount => this["platform_fault_domain_count"];

    /// <summary>
    /// The platform_update_domain_count attribute.
    /// </summary>
    public TerraformExpression PlatformUpdateDomainCount => this["platform_update_domain_count"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
