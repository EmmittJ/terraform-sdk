using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for container in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupContainerBlock : TerraformBlock
{
    /// <summary>
    /// The commands attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Commands
    {
        get => GetProperty<List<TerraformProperty<string>>>("commands");
        set => WithProperty("commands", value);
    }

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cpu is required")]
    public required TerraformProperty<double> Cpu
    {
        get => GetProperty<TerraformProperty<double>>("cpu");
        set => WithProperty("cpu", value);
    }

    /// <summary>
    /// The cpu_limit attribute.
    /// </summary>
    public TerraformProperty<double>? CpuLimit
    {
        get => GetProperty<TerraformProperty<double>>("cpu_limit");
        set => WithProperty("cpu_limit", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EnvironmentVariables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("environment_variables");
        set => WithProperty("environment_variables", value);
    }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformProperty<string> Image
    {
        get => GetProperty<TerraformProperty<string>>("image");
        set => WithProperty("image", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Memory is required")]
    public required TerraformProperty<double> Memory
    {
        get => GetProperty<TerraformProperty<double>>("memory");
        set => WithProperty("memory", value);
    }

    /// <summary>
    /// The memory_limit attribute.
    /// </summary>
    public TerraformProperty<double>? MemoryLimit
    {
        get => GetProperty<TerraformProperty<double>>("memory_limit");
        set => WithProperty("memory_limit", value);
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
    /// The secure_environment_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? SecureEnvironmentVariables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("secure_environment_variables");
        set => WithProperty("secure_environment_variables", value);
    }

}

/// <summary>
/// Block type for diagnostics in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupDiagnosticsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for dns_config in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupDnsConfigBlock : TerraformBlock
{
    /// <summary>
    /// The nameservers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Nameservers is required")]
    public List<TerraformProperty<string>>? Nameservers
    {
        get => GetProperty<List<TerraformProperty<string>>>("nameservers");
        set => WithProperty("nameservers", value);
    }

    /// <summary>
    /// The options attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Options
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("options");
        set => WithProperty("options", value);
    }

    /// <summary>
    /// The search_domains attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SearchDomains
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("search_domains");
        set => WithProperty("search_domains", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for image_registry_credential in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupImageRegistryCredentialBlock : TerraformBlock
{
    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => WithProperty("password", value);
    }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformProperty<string> Server
    {
        get => GetProperty<TerraformProperty<string>>("server");
        set => WithProperty("server", value);
    }

    /// <summary>
    /// The User Assigned Identity to use for Container Registry access.
    /// </summary>
    public TerraformProperty<string>? UserAssignedIdentityId
    {
        get => GetProperty<TerraformProperty<string>>("user_assigned_identity_id");
        set => WithProperty("user_assigned_identity_id", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
        set => WithProperty("username", value);
    }

}

/// <summary>
/// Block type for init_container in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupInitContainerBlock : TerraformBlock
{
    /// <summary>
    /// The commands attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Commands
    {
        get => GetProperty<List<TerraformProperty<string>>>("commands");
        set => WithProperty("commands", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EnvironmentVariables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("environment_variables");
        set => WithProperty("environment_variables", value);
    }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformProperty<string> Image
    {
        get => GetProperty<TerraformProperty<string>>("image");
        set => WithProperty("image", value);
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
    /// The secure_environment_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? SecureEnvironmentVariables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("secure_environment_variables");
        set => WithProperty("secure_environment_variables", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerGroupTimeoutsBlock : TerraformBlock
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
    public HashSet<TerraformProperty<object>>? ExposedPort
    {
        get => GetProperty<HashSet<TerraformProperty<object>>>("exposed_port");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsType is required")]
    public required TerraformProperty<string> OsType
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
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
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
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
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Zones
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("zones");
        set => this.WithProperty("zones", value);
    }

    /// <summary>
    /// Block for container.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Container block(s) required")]
    public List<AzurermContainerGroupContainerBlock>? Container
    {
        get => GetProperty<List<AzurermContainerGroupContainerBlock>>("container");
        set => this.WithProperty("container", value);
    }

    /// <summary>
    /// Block for diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Diagnostics block(s) allowed")]
    public List<AzurermContainerGroupDiagnosticsBlock>? Diagnostics
    {
        get => GetProperty<List<AzurermContainerGroupDiagnosticsBlock>>("diagnostics");
        set => this.WithProperty("diagnostics", value);
    }

    /// <summary>
    /// Block for dns_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsConfig block(s) allowed")]
    public List<AzurermContainerGroupDnsConfigBlock>? DnsConfig
    {
        get => GetProperty<List<AzurermContainerGroupDnsConfigBlock>>("dns_config");
        set => this.WithProperty("dns_config", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermContainerGroupIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermContainerGroupIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for image_registry_credential.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermContainerGroupImageRegistryCredentialBlock>? ImageRegistryCredential
    {
        get => GetProperty<List<AzurermContainerGroupImageRegistryCredentialBlock>>("image_registry_credential");
        set => this.WithProperty("image_registry_credential", value);
    }

    /// <summary>
    /// Block for init_container.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermContainerGroupInitContainerBlock>? InitContainer
    {
        get => GetProperty<List<AzurermContainerGroupInitContainerBlock>>("init_container");
        set => this.WithProperty("init_container", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermContainerGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
