using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for nat_ip_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermPrivateLinkServiceNatIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Primary is required")]
    public required TerraformProperty<bool> Primary
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("primary");
        set => WithProperty("primary", value);
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
    /// The private_ip_address_version attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateIpAddressVersion
    {
        get => GetProperty<TerraformProperty<string>>("private_ip_address_version");
        set => WithProperty("private_ip_address_version", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPrivateLinkServiceTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_private_link_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermPrivateLinkService : TerraformResource
{
    public AzurermPrivateLinkService(string name) : base("azurerm_private_link_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("alias");
    }

    /// <summary>
    /// The auto_approval_subscription_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AutoApprovalSubscriptionIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("auto_approval_subscription_ids");
        set => this.WithProperty("auto_approval_subscription_ids", value);
    }

    /// <summary>
    /// The destination_ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? DestinationIpAddress
    {
        get => GetProperty<TerraformProperty<string>>("destination_ip_address");
        set => this.WithProperty("destination_ip_address", value);
    }

    /// <summary>
    /// The enable_proxy_protocol attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableProxyProtocol
    {
        get => GetProperty<TerraformProperty<bool>>("enable_proxy_protocol");
        set => this.WithProperty("enable_proxy_protocol", value);
    }

    /// <summary>
    /// The fqdns attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Fqdns
    {
        get => GetProperty<List<TerraformProperty<string>>>("fqdns");
        set => this.WithProperty("fqdns", value);
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
    /// The load_balancer_frontend_ip_configuration_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? LoadBalancerFrontendIpConfigurationIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("load_balancer_frontend_ip_configuration_ids");
        set => this.WithProperty("load_balancer_frontend_ip_configuration_ids", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
    /// The visibility_subscription_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VisibilitySubscriptionIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("visibility_subscription_ids");
        set => this.WithProperty("visibility_subscription_ids", value);
    }

    /// <summary>
    /// Block for nat_ip_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NatIpConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(8, ErrorMessage = "Maximum 8 NatIpConfiguration block(s) allowed")]
    public List<AzurermPrivateLinkServiceNatIpConfigurationBlock>? NatIpConfiguration
    {
        get => GetProperty<List<AzurermPrivateLinkServiceNatIpConfigurationBlock>>("nat_ip_configuration");
        set => this.WithProperty("nat_ip_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPrivateLinkServiceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermPrivateLinkServiceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformExpression Alias => this["alias"];

}
