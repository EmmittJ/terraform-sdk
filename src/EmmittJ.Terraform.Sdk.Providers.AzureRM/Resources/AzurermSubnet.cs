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
    public List<string>? AddressPrefixes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("address_prefixes")?.Value;
        set => this.WithProperty("address_prefixes", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The default_outbound_access_enabled attribute.
    /// </summary>
    public bool? DefaultOutboundAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("default_outbound_access_enabled")?.Value;
        set => this.WithProperty("default_outbound_access_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The private_endpoint_network_policies attribute.
    /// </summary>
    public string? PrivateEndpointNetworkPolicies
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_endpoint_network_policies")?.Value;
        set => this.WithProperty("private_endpoint_network_policies", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The private_link_service_network_policies_enabled attribute.
    /// </summary>
    public bool? PrivateLinkServiceNetworkPoliciesEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("private_link_service_network_policies_enabled")?.Value;
        set => this.WithProperty("private_link_service_network_policies_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The service_endpoint_policy_ids attribute.
    /// </summary>
    public HashSet<string>? ServiceEndpointPolicyIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("service_endpoint_policy_ids")?.Value;
        set => this.WithProperty("service_endpoint_policy_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The service_endpoints attribute.
    /// </summary>
    public HashSet<string>? ServiceEndpoints
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("service_endpoints")?.Value;
        set => this.WithProperty("service_endpoints", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The sharing_scope attribute.
    /// </summary>
    public string? SharingScope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sharing_scope")?.Value;
        set => this.WithProperty("sharing_scope", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The virtual_network_name attribute.
    /// </summary>
    public string? VirtualNetworkName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_network_name")?.Value;
        set => this.WithProperty("virtual_network_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
