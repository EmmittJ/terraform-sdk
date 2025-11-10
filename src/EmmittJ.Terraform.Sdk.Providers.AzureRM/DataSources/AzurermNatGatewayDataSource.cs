using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNatGatewayDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_nat_gateway.
/// </summary>
public class AzurermNatGatewayDataSource : TerraformDataSource
{
    public AzurermNatGatewayDataSource(string name) : base("azurerm_nat_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("idle_timeout_in_minutes");
        this.DeclareOutput("location");
        this.DeclareOutput("resource_guid");
        this.DeclareOutput("sku_name");
        this.DeclareOutput("tags");
        this.DeclareOutput("zones");
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
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_ip_address_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PublicIpAddressIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("public_ip_address_ids");
        set => this.WithProperty("public_ip_address_ids", value);
    }

    /// <summary>
    /// The public_ip_prefix_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PublicIpPrefixIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("public_ip_prefix_ids");
        set => this.WithProperty("public_ip_prefix_ids", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNatGatewayDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNatGatewayDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformExpression IdleTimeoutInMinutes => this["idle_timeout_in_minutes"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The resource_guid attribute.
    /// </summary>
    public TerraformExpression ResourceGuid => this["resource_guid"];

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformExpression SkuName => this["sku_name"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformExpression Zones => this["zones"];

}
