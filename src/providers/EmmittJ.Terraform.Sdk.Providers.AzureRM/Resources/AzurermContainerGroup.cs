using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for container in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupContainerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "container";

    /// <summary>
    /// The commands attribute.
    /// </summary>
    public TerraformList<string> Commands
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "commands").ResolveNodes(ctx));
        set => SetArgument("commands", value);
    }

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cpu is required")]
    public required TerraformValue<double> Cpu
    {
        get => new TerraformReference<double>(this, "cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// The cpu_limit attribute.
    /// </summary>
    public TerraformValue<double>? CpuLimit
    {
        get => new TerraformReference<double>(this, "cpu_limit");
        set => SetArgument("cpu_limit", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public TerraformMap<string>? EnvironmentVariables
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "environment_variables").ResolveNodes(ctx));
        set => SetArgument("environment_variables", value);
    }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformValue<string> Image
    {
        get => new TerraformReference<string>(this, "image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Memory is required")]
    public required TerraformValue<double> Memory
    {
        get => new TerraformReference<double>(this, "memory");
        set => SetArgument("memory", value);
    }

    /// <summary>
    /// The memory_limit attribute.
    /// </summary>
    public TerraformValue<double>? MemoryLimit
    {
        get => new TerraformReference<double>(this, "memory_limit");
        set => SetArgument("memory_limit", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The secure_environment_variables attribute.
    /// </summary>
    public TerraformMap<string>? SecureEnvironmentVariables
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "secure_environment_variables").ResolveNodes(ctx));
        set => SetArgument("secure_environment_variables", value);
    }

}

/// <summary>
/// Block type for diagnostics in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupDiagnosticsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "diagnostics";

}

/// <summary>
/// Block type for dns_config in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupDnsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dns_config";

    /// <summary>
    /// The nameservers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Nameservers is required")]
    public TerraformList<string>? Nameservers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "nameservers").ResolveNodes(ctx));
        set => SetArgument("nameservers", value);
    }

    /// <summary>
    /// The options attribute.
    /// </summary>
    public TerraformSet<string>? Options
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "options").ResolveNodes(ctx));
        set => SetArgument("options", value);
    }

    /// <summary>
    /// The search_domains attribute.
    /// </summary>
    public TerraformSet<string>? SearchDomains
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "search_domains").ResolveNodes(ctx));
        set => SetArgument("search_domains", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for image_registry_credential in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupImageRegistryCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "image_registry_credential";

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    public required TerraformValue<string> Server
    {
        get => new TerraformReference<string>(this, "server");
        set => SetArgument("server", value);
    }

    /// <summary>
    /// The User Assigned Identity to use for Container Registry access.
    /// </summary>
    public TerraformValue<string>? UserAssignedIdentityId
    {
        get => new TerraformReference<string>(this, "user_assigned_identity_id");
        set => SetArgument("user_assigned_identity_id", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformValue<string>? Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

}

/// <summary>
/// Block type for init_container in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupInitContainerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "init_container";

    /// <summary>
    /// The commands attribute.
    /// </summary>
    public TerraformList<string> Commands
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "commands").ResolveNodes(ctx));
        set => SetArgument("commands", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public TerraformMap<string>? EnvironmentVariables
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "environment_variables").ResolveNodes(ctx));
        set => SetArgument("environment_variables", value);
    }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    public required TerraformValue<string> Image
    {
        get => new TerraformReference<string>(this, "image");
        set => SetArgument("image", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The secure_environment_variables attribute.
    /// </summary>
    public TerraformMap<string>? SecureEnvironmentVariables
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "secure_environment_variables").ResolveNodes(ctx));
        set => SetArgument("secure_environment_variables", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_container_group Terraform resource.
/// Manages a azurerm_container_group resource.
/// </summary>
public partial class AzurermContainerGroup(string name) : TerraformResource("azurerm_container_group", name)
{
    /// <summary>
    /// The dns_name_label attribute.
    /// </summary>
    public TerraformValue<string>? DnsNameLabel
    {
        get => new TerraformReference<string>(this, "dns_name_label");
        set => SetArgument("dns_name_label", value);
    }

    /// <summary>
    /// The dns_name_label_reuse_policy attribute.
    /// </summary>
    public TerraformValue<string>? DnsNameLabelReusePolicy
    {
        get => new TerraformReference<string>(this, "dns_name_label_reuse_policy");
        set => SetArgument("dns_name_label_reuse_policy", value);
    }

    /// <summary>
    /// The exposed_port attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> ExposedPort
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "exposed_port").ResolveNodes(ctx));
        set => SetArgument("exposed_port", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string>? IpAddressType
    {
        get => new TerraformReference<string>(this, "ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "key_vault_key_id");
        set => SetArgument("key_vault_key_id", value);
    }

    /// <summary>
    /// The key_vault_user_assigned_identity_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultUserAssignedIdentityId
    {
        get => new TerraformReference<string>(this, "key_vault_user_assigned_identity_id");
        set => SetArgument("key_vault_user_assigned_identity_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_profile_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> NetworkProfileId
    {
        get => new TerraformReference<string>(this, "network_profile_id");
        set => SetArgument("network_profile_id", value);
    }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsType is required")]
    public required TerraformValue<string> OsType
    {
        get => new TerraformReference<string>(this, "os_type");
        set => SetArgument("os_type", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<string>? Priority
    {
        get => new TerraformReference<string>(this, "priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The restart_policy attribute.
    /// </summary>
    public TerraformValue<string>? RestartPolicy
    {
        get => new TerraformReference<string>(this, "restart_policy");
        set => SetArgument("restart_policy", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string>? Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string>? SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformSet<string>? Zones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "zones").ResolveNodes(ctx));
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformValue<string> IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
    }

    /// <summary>
    /// Container block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Container is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Container block(s) required")]
    public required TerraformList<AzurermContainerGroupContainerBlock> Container
    {
        get => GetRequiredArgument<TerraformList<AzurermContainerGroupContainerBlock>>("container");
        set => SetArgument("container", value);
    }

    /// <summary>
    /// Diagnostics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Diagnostics block(s) allowed")]
    public TerraformList<AzurermContainerGroupDiagnosticsBlock>? Diagnostics
    {
        get => GetArgument<TerraformList<AzurermContainerGroupDiagnosticsBlock>>("diagnostics");
        set => SetArgument("diagnostics", value);
    }

    /// <summary>
    /// DnsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsConfig block(s) allowed")]
    public TerraformList<AzurermContainerGroupDnsConfigBlock>? DnsConfig
    {
        get => GetArgument<TerraformList<AzurermContainerGroupDnsConfigBlock>>("dns_config");
        set => SetArgument("dns_config", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermContainerGroupIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermContainerGroupIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// ImageRegistryCredential block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerGroupImageRegistryCredentialBlock>? ImageRegistryCredential
    {
        get => GetArgument<TerraformList<AzurermContainerGroupImageRegistryCredentialBlock>>("image_registry_credential");
        set => SetArgument("image_registry_credential", value);
    }

    /// <summary>
    /// InitContainer block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermContainerGroupInitContainerBlock>? InitContainer
    {
        get => GetArgument<TerraformList<AzurermContainerGroupInitContainerBlock>>("init_container");
        set => SetArgument("init_container", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermContainerGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermContainerGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
