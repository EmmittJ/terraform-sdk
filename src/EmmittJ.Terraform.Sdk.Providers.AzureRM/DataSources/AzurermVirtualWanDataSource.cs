using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_virtual_wan.
/// </summary>
public class AzurermVirtualWanDataSource : TerraformDataSource
{
    public AzurermVirtualWanDataSource(string name) : base("azurerm_virtual_wan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("allow_branch_to_branch_traffic");
        this.DeclareOutput("disable_vpn_encryption");
        this.DeclareOutput("location");
        this.DeclareOutput("office365_local_breakout_category");
        this.DeclareOutput("sku");
        this.DeclareOutput("tags");
        this.DeclareOutput("virtual_hub_ids");
        this.DeclareOutput("vpn_site_ids");
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
    /// The allow_branch_to_branch_traffic attribute.
    /// </summary>
    public TerraformExpression AllowBranchToBranchTraffic => this["allow_branch_to_branch_traffic"];

    /// <summary>
    /// The disable_vpn_encryption attribute.
    /// </summary>
    public TerraformExpression DisableVpnEncryption => this["disable_vpn_encryption"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The office365_local_breakout_category attribute.
    /// </summary>
    public TerraformExpression Office365LocalBreakoutCategory => this["office365_local_breakout_category"];

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformExpression Sku => this["sku"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The virtual_hub_ids attribute.
    /// </summary>
    public TerraformExpression VirtualHubIds => this["virtual_hub_ids"];

    /// <summary>
    /// The vpn_site_ids attribute.
    /// </summary>
    public TerraformExpression VpnSiteIds => this["vpn_site_ids"];

}
