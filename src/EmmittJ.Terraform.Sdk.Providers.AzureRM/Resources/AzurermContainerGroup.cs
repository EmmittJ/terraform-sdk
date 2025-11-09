using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_container_group resource.
/// </summary>
public class AzurermContainerGroup : TerraformResource
{
    public AzurermContainerGroup(string name) : base("azurerm_container_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("fqdn");
        this.DeclareOutput("ip_address");
    }

    /// <summary>
    /// The dns_name_label attribute.
    /// </summary>
    public TerraformProperty<string>? DnsNameLabel
    {
        get => GetProperty<TerraformProperty<string>>("dns_name_label");
        set => this.WithProperty("dns_name_label", value);
    }

    /// <summary>
    /// The dns_name_label_reuse_policy attribute.
    /// </summary>
    public TerraformProperty<string>? DnsNameLabelReusePolicy
    {
        get => GetProperty<TerraformProperty<string>>("dns_name_label_reuse_policy");
        set => this.WithProperty("dns_name_label_reuse_policy", value);
    }

    /// <summary>
    /// The exposed_port attribute.
    /// </summary>
    public TerraformProperty<HashSet<object>>? ExposedPort
    {
        get => GetProperty<TerraformProperty<HashSet<object>>>("exposed_port");
        set => this.WithProperty("exposed_port", value);
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
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddressType
    {
        get => GetProperty<TerraformProperty<string>>("ip_address_type");
        set => this.WithProperty("ip_address_type", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultKeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_key_id");
        set => this.WithProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The key_vault_user_assigned_identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultUserAssignedIdentityId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_user_assigned_identity_id");
        set => this.WithProperty("key_vault_user_assigned_identity_id", value);
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
    /// The network_profile_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? NetworkProfileId
    {
        get => GetProperty<TerraformProperty<string>>("network_profile_id");
        set => this.WithProperty("network_profile_id", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformProperty<string>? OsType
    {
        get => GetProperty<TerraformProperty<string>>("os_type");
        set => this.WithProperty("os_type", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<string>? Priority
    {
        get => GetProperty<TerraformProperty<string>>("priority");
        set => this.WithProperty("priority", value);
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
    /// The restart_policy attribute.
    /// </summary>
    public TerraformProperty<string>? RestartPolicy
    {
        get => GetProperty<TerraformProperty<string>>("restart_policy");
        set => this.WithProperty("restart_policy", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string>? Sku
    {
        get => GetProperty<TerraformProperty<string>>("sku");
        set => this.WithProperty("sku", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SubnetIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Zones
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformExpression IpAddress => this["ip_address"];

}
