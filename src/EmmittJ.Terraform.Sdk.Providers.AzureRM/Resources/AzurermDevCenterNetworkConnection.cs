using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_dev_center_network_connection resource.
/// </summary>
public class AzurermDevCenterNetworkConnection : TerraformResource
{
    public AzurermDevCenterNetworkConnection(string name) : base("azurerm_dev_center_network_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The domain_join_type attribute.
    /// </summary>
    public TerraformProperty<string>? DomainJoinType
    {
        get => GetProperty<TerraformProperty<string>>("domain_join_type");
        set => this.WithProperty("domain_join_type", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformProperty<string>? DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
    }

    /// <summary>
    /// The domain_password attribute.
    /// </summary>
    public TerraformProperty<string>? DomainPassword
    {
        get => GetProperty<TerraformProperty<string>>("domain_password");
        set => this.WithProperty("domain_password", value);
    }

    /// <summary>
    /// The domain_username attribute.
    /// </summary>
    public TerraformProperty<string>? DomainUsername
    {
        get => GetProperty<TerraformProperty<string>>("domain_username");
        set => this.WithProperty("domain_username", value);
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
    /// The organization_unit attribute.
    /// </summary>
    public TerraformProperty<string>? OrganizationUnit
    {
        get => GetProperty<TerraformProperty<string>>("organization_unit");
        set => this.WithProperty("organization_unit", value);
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
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
