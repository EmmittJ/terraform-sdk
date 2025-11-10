using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPrivateDnsZoneDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_private_dns_zone.
/// </summary>
public class AzurermPrivateDnsZoneDataSource : TerraformDataSource
{
    public AzurermPrivateDnsZoneDataSource(string name) : base("azurerm_private_dns_zone", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("max_number_of_record_sets");
        SetOutput("max_number_of_virtual_network_links");
        SetOutput("max_number_of_virtual_network_links_with_registration");
        SetOutput("number_of_record_sets");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("tags");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPrivateDnsZoneDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
