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
    public string? DomainJoinType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_join_type")?.Value;
        set => this.WithProperty("domain_join_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public string? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name")?.Value;
        set => this.WithProperty("domain_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain_password attribute.
    /// </summary>
    public string? DomainPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_password")?.Value;
        set => this.WithProperty("domain_password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain_username attribute.
    /// </summary>
    public string? DomainUsername
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_username")?.Value;
        set => this.WithProperty("domain_username", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The organization_unit attribute.
    /// </summary>
    public string? OrganizationUnit
    {
        get => GetProperty<TerraformLiteralProperty<string>>("organization_unit")?.Value;
        set => this.WithProperty("organization_unit", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The subnet_id attribute.
    /// </summary>
    public string? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id")?.Value;
        set => this.WithProperty("subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
