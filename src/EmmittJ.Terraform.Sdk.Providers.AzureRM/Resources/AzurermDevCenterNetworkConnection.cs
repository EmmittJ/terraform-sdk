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
    public TerraformLiteralProperty<string>? DomainJoinType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_join_type");
        set => this.WithProperty("domain_join_type", value);
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
    }

    /// <summary>
    /// The domain_password attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DomainPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_password");
        set => this.WithProperty("domain_password", value);
    }

    /// <summary>
    /// The domain_username attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DomainUsername
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_username");
        set => this.WithProperty("domain_username", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The organization_unit attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OrganizationUnit
    {
        get => GetProperty<TerraformLiteralProperty<string>>("organization_unit");
        set => this.WithProperty("organization_unit", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
