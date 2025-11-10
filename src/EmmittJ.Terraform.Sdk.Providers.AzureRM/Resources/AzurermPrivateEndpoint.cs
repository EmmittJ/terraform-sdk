using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermPrivateEndpointIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The member_name attribute.
    /// </summary>
    public TerraformProperty<string>? MemberName
    {
        get => GetProperty<TerraformProperty<string>>("member_name");
        set => WithProperty("member_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateIpAddress is required")]
    public required TerraformProperty<string> PrivateIpAddress
    {
        get => GetProperty<TerraformProperty<string>>("private_ip_address");
        set => WithProperty("private_ip_address", value);
    }

    /// <summary>
    /// The subresource_name attribute.
    /// </summary>
    public TerraformProperty<string>? SubresourceName
    {
        get => GetProperty<TerraformProperty<string>>("subresource_name");
        set => WithProperty("subresource_name", value);
    }

}

/// <summary>
/// Block type for private_dns_zone_group in .
/// Nesting mode: list
/// </summary>
public class AzurermPrivateEndpointPrivateDnsZoneGroupBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The private_dns_zone_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateDnsZoneIds is required")]
    public List<TerraformProperty<string>>? PrivateDnsZoneIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("private_dns_zone_ids");
        set => WithProperty("private_dns_zone_ids", value);
    }

}

/// <summary>
/// Block type for private_service_connection in .
/// Nesting mode: list
/// </summary>
public class AzurermPrivateEndpointPrivateServiceConnectionBlock : TerraformBlock
{
    /// <summary>
    /// The is_manual_connection attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsManualConnection is required")]
    public required TerraformProperty<bool> IsManualConnection
    {
        get => GetProperty<TerraformProperty<bool>>("is_manual_connection");
        set => WithProperty("is_manual_connection", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The private_connection_resource_alias attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateConnectionResourceAlias
    {
        get => GetProperty<TerraformProperty<string>>("private_connection_resource_alias");
        set => WithProperty("private_connection_resource_alias", value);
    }

    /// <summary>
    /// The private_connection_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateConnectionResourceId
    {
        get => GetProperty<TerraformProperty<string>>("private_connection_resource_id");
        set => WithProperty("private_connection_resource_id", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateIpAddress
    {
        get => GetProperty<TerraformProperty<string>>("private_ip_address");
        set => WithProperty("private_ip_address", value);
    }

    /// <summary>
    /// The request_message attribute.
    /// </summary>
    public TerraformProperty<string>? RequestMessage
    {
        get => GetProperty<TerraformProperty<string>>("request_message");
        set => WithProperty("request_message", value);
    }

    /// <summary>
    /// The subresource_names attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SubresourceNames
    {
        get => GetProperty<List<TerraformProperty<string>>>("subresource_names");
        set => WithProperty("subresource_names", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPrivateEndpointTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_private_endpoint resource.
/// </summary>
public class AzurermPrivateEndpoint : TerraformResource
{
    public AzurermPrivateEndpoint(string name) : base("azurerm_private_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("custom_dns_configs");
        this.DeclareOutput("network_interface");
        this.DeclareOutput("private_dns_zone_configs");
    }

    /// <summary>
    /// The custom_network_interface_name attribute.
    /// </summary>
    public TerraformProperty<string>? CustomNetworkInterfaceName
    {
        get => GetProperty<TerraformProperty<string>>("custom_network_interface_name");
        set => this.WithProperty("custom_network_interface_name", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for ip_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermPrivateEndpointIpConfigurationBlock>? IpConfiguration
    {
        get => GetProperty<List<AzurermPrivateEndpointIpConfigurationBlock>>("ip_configuration");
        set => this.WithProperty("ip_configuration", value);
    }

    /// <summary>
    /// Block for private_dns_zone_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateDnsZoneGroup block(s) allowed")]
    public List<AzurermPrivateEndpointPrivateDnsZoneGroupBlock>? PrivateDnsZoneGroup
    {
        get => GetProperty<List<AzurermPrivateEndpointPrivateDnsZoneGroupBlock>>("private_dns_zone_group");
        set => this.WithProperty("private_dns_zone_group", value);
    }

    /// <summary>
    /// Block for private_service_connection.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PrivateServiceConnection block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivateServiceConnection block(s) allowed")]
    public List<AzurermPrivateEndpointPrivateServiceConnectionBlock>? PrivateServiceConnection
    {
        get => GetProperty<List<AzurermPrivateEndpointPrivateServiceConnectionBlock>>("private_service_connection");
        set => this.WithProperty("private_service_connection", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPrivateEndpointTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermPrivateEndpointTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The custom_dns_configs attribute.
    /// </summary>
    public TerraformExpression CustomDnsConfigs => this["custom_dns_configs"];

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    public TerraformExpression NetworkInterface => this["network_interface"];

    /// <summary>
    /// The private_dns_zone_configs attribute.
    /// </summary>
    public TerraformExpression PrivateDnsZoneConfigs => this["private_dns_zone_configs"];

}
