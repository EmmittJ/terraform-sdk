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
        set => SetProperty("commands", value);
    }

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cpu is required")]
    public required TerraformProperty<double> Cpu
    {
        set => SetProperty("cpu", value);
    }

    /// <summary>
    /// The cpu_limit attribute.
    /// </summary>
    public TerraformProperty<double>? CpuLimit
    {
        set => SetProperty("cpu_limit", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EnvironmentVariables
    {
        set => SetProperty("environment_variables", value);
    }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformProperty<string> Image
    {
        set => SetProperty("image", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Memory is required")]
    public required TerraformProperty<double> Memory
    {
        set => SetProperty("memory", value);
    }

    /// <summary>
    /// The memory_limit attribute.
    /// </summary>
    public TerraformProperty<double>? MemoryLimit
    {
        set => SetProperty("memory_limit", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The secure_environment_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? SecureEnvironmentVariables
    {
        set => SetProperty("secure_environment_variables", value);
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
        set => SetProperty("nameservers", value);
    }

    /// <summary>
    /// The options attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Options
    {
        set => SetProperty("options", value);
    }

    /// <summary>
    /// The search_domains attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SearchDomains
    {
        set => SetProperty("search_domains", value);
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
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformProperty<string> Server
    {
        set => SetProperty("server", value);
    }

    /// <summary>
    /// The User Assigned Identity to use for Container Registry access.
    /// </summary>
    public TerraformProperty<string>? UserAssignedIdentityId
    {
        set => SetProperty("user_assigned_identity_id", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        set => SetProperty("username", value);
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
        set => SetProperty("commands", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EnvironmentVariables
    {
        set => SetProperty("environment_variables", value);
    }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformProperty<string> Image
    {
        set => SetProperty("image", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The secure_environment_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? SecureEnvironmentVariables
    {
        set => SetProperty("secure_environment_variables", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_container_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermContainerGroup : TerraformResource
{
    public AzurermContainerGroup(string name) : base("azurerm_container_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("fqdn");
        SetOutput("ip_address");
        SetOutput("dns_name_label");
        SetOutput("dns_name_label_reuse_policy");
        SetOutput("exposed_port");
        SetOutput("id");
        SetOutput("ip_address_type");
        SetOutput("key_vault_key_id");
        SetOutput("key_vault_user_assigned_identity_id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("network_profile_id");
        SetOutput("os_type");
        SetOutput("priority");
        SetOutput("resource_group_name");
        SetOutput("restart_policy");
        SetOutput("sku");
        SetOutput("subnet_ids");
        SetOutput("tags");
        SetOutput("zones");
    }

    /// <summary>
    /// The dns_name_label attribute.
    /// </summary>
    public TerraformProperty<string> DnsNameLabel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dns_name_label");
        set => SetProperty("dns_name_label", value);
    }

    /// <summary>
    /// The dns_name_label_reuse_policy attribute.
    /// </summary>
    public TerraformProperty<string> DnsNameLabelReusePolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dns_name_label_reuse_policy");
        set => SetProperty("dns_name_label_reuse_policy", value);
    }

    /// <summary>
    /// The exposed_port attribute.
    /// </summary>
    public HashSet<TerraformProperty<object>> ExposedPort
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<object>>>("exposed_port");
        set => SetProperty("exposed_port", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string> IpAddressType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_address_type");
        set => SetProperty("ip_address_type", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KeyVaultKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_vault_key_id");
        set => SetProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The key_vault_user_assigned_identity_id attribute.
    /// </summary>
    public TerraformProperty<string> KeyVaultUserAssignedIdentityId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_vault_user_assigned_identity_id");
        set => SetProperty("key_vault_user_assigned_identity_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The network_profile_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string> NetworkProfileId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_profile_id");
        set => SetProperty("network_profile_id", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsType is required")]
    public required TerraformProperty<string> OsType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("os_type");
        set => SetProperty("os_type", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<string> Priority
    {
        get => GetRequiredOutput<TerraformProperty<string>>("priority");
        set => SetProperty("priority", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The restart_policy attribute.
    /// </summary>
    public TerraformProperty<string> RestartPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("restart_policy");
        set => SetProperty("restart_policy", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformProperty<string> Sku
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku");
        set => SetProperty("sku", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SubnetIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => SetProperty("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Zones
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("zones");
        set => SetProperty("zones", value);
    }

    /// <summary>
    /// Block for container.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Container is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Container block(s) required")]
    public List<AzurermContainerGroupContainerBlock>? Container
    {
        set => SetProperty("container", value);
    }

    /// <summary>
    /// Block for diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Diagnostics block(s) allowed")]
    public List<AzurermContainerGroupDiagnosticsBlock>? Diagnostics
    {
        set => SetProperty("diagnostics", value);
    }

    /// <summary>
    /// Block for dns_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsConfig block(s) allowed")]
    public List<AzurermContainerGroupDnsConfigBlock>? DnsConfig
    {
        set => SetProperty("dns_config", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermContainerGroupIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for image_registry_credential.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermContainerGroupImageRegistryCredentialBlock>? ImageRegistryCredential
    {
        set => SetProperty("image_registry_credential", value);
    }

    /// <summary>
    /// Block for init_container.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermContainerGroupInitContainerBlock>? InitContainer
    {
        set => SetProperty("init_container", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermContainerGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
