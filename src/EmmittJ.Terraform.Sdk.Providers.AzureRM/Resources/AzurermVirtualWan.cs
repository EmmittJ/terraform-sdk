using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_virtual_wan resource.
/// </summary>
public class AzurermVirtualWan : TerraformResource
{
    public AzurermVirtualWan(string name) : base("azurerm_virtual_wan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The allow_branch_to_branch_traffic attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowBranchToBranchTraffic
    {
        get => GetProperty<TerraformProperty<bool>>("allow_branch_to_branch_traffic");
        set => this.WithProperty("allow_branch_to_branch_traffic", value);
    }

    /// <summary>
    /// The disable_vpn_encryption attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableVpnEncryption
    {
        get => GetProperty<TerraformProperty<bool>>("disable_vpn_encryption");
        set => this.WithProperty("disable_vpn_encryption", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The office365_local_breakout_category attribute.
    /// </summary>
    public TerraformProperty<string>? Office365LocalBreakoutCategory
    {
        get => GetProperty<TerraformProperty<string>>("office365_local_breakout_category");
        set => this.WithProperty("office365_local_breakout_category", value);
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
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

}
