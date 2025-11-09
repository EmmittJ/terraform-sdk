using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_private_dns_zone resource.
/// </summary>
public class AzurermPrivateDnsZone : TerraformResource
{
    public AzurermPrivateDnsZone(string name) : base("azurerm_private_dns_zone", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("max_number_of_record_sets");
        this.DeclareOutput("max_number_of_virtual_network_links");
        this.DeclareOutput("max_number_of_virtual_network_links_with_registration");
        this.DeclareOutput("number_of_record_sets");
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
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The max_number_of_record_sets attribute.
    /// </summary>
    public TerraformExpression MaxNumberOfRecordSets => this["max_number_of_record_sets"];

    /// <summary>
    /// The max_number_of_virtual_network_links attribute.
    /// </summary>
    public TerraformExpression MaxNumberOfVirtualNetworkLinks => this["max_number_of_virtual_network_links"];

    /// <summary>
    /// The max_number_of_virtual_network_links_with_registration attribute.
    /// </summary>
    public TerraformExpression MaxNumberOfVirtualNetworkLinksWithRegistration => this["max_number_of_virtual_network_links_with_registration"];

    /// <summary>
    /// The number_of_record_sets attribute.
    /// </summary>
    public TerraformExpression NumberOfRecordSets => this["number_of_record_sets"];

}
