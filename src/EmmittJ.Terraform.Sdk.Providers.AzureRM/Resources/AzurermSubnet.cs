using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_subnet resource.
/// </summary>
public class AzurermSubnet : TerraformResource
{
    public AzurermSubnet(string name) : base("azurerm_subnet", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? AddressPrefixes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("address_prefixes");
        set => this.WithProperty("address_prefixes", value);
    }

    /// <summary>
    /// The default_outbound_access_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DefaultOutboundAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("default_outbound_access_enabled");
        set => this.WithProperty("default_outbound_access_enabled", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The private_endpoint_network_policies attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PrivateEndpointNetworkPolicies
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_endpoint_network_policies");
        set => this.WithProperty("private_endpoint_network_policies", value);
    }

    /// <summary>
    /// The private_link_service_network_policies_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? PrivateLinkServiceNetworkPoliciesEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("private_link_service_network_policies_enabled");
        set => this.WithProperty("private_link_service_network_policies_enabled", value);
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
    /// The service_endpoint_policy_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? ServiceEndpointPolicyIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("service_endpoint_policy_ids");
        set => this.WithProperty("service_endpoint_policy_ids", value);
    }

    /// <summary>
    /// The service_endpoints attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? ServiceEndpoints
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("service_endpoints");
        set => this.WithProperty("service_endpoints", value);
    }

    /// <summary>
    /// The sharing_scope attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SharingScope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sharing_scope");
        set => this.WithProperty("sharing_scope", value);
    }

    /// <summary>
    /// The virtual_network_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VirtualNetworkName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_network_name");
        set => this.WithProperty("virtual_network_name", value);
    }

}
