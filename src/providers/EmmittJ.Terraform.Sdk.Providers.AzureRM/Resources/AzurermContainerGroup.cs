using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for container in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupContainerBlock
{
    /// <summary>
    /// The commands attribute.
    /// </summary>
    [TerraformPropertyName("commands")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> Commands { get; set; } = default!;

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cpu is required")]
    [TerraformPropertyName("cpu")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Cpu { get; set; }

    /// <summary>
    /// The cpu_limit attribute.
    /// </summary>
    [TerraformPropertyName("cpu_limit")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? CpuLimit { get; set; }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformPropertyName("environment_variables")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    [TerraformPropertyName("image")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Image { get; set; }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Memory is required")]
    [TerraformPropertyName("memory")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Memory { get; set; }

    /// <summary>
    /// The memory_limit attribute.
    /// </summary>
    [TerraformPropertyName("memory_limit")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MemoryLimit { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The secure_environment_variables attribute.
    /// </summary>
    [TerraformPropertyName("secure_environment_variables")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? SecureEnvironmentVariables { get; set; }

}

/// <summary>
/// Block type for diagnostics in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupDiagnosticsBlock
{
}

/// <summary>
/// Block type for dns_config in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupDnsConfigBlock
{
    /// <summary>
    /// The nameservers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Nameservers is required")]
    [TerraformPropertyName("nameservers")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? Nameservers { get; set; }

    /// <summary>
    /// The options attribute.
    /// </summary>
    [TerraformPropertyName("options")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Options { get; set; }

    /// <summary>
    /// The search_domains attribute.
    /// </summary>
    [TerraformPropertyName("search_domains")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SearchDomains { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupIdentityBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for image_registry_credential in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupImageRegistryCredentialBlock
{
    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    [TerraformPropertyName("server")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Server { get; set; }

    /// <summary>
    /// The User Assigned Identity to use for Container Registry access.
    /// </summary>
    [TerraformPropertyName("user_assigned_identity_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserAssignedIdentityId { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [TerraformPropertyName("username")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Username { get; set; }

}

/// <summary>
/// Block type for init_container in .
/// Nesting mode: list
/// </summary>
public class AzurermContainerGroupInitContainerBlock
{
    /// <summary>
    /// The commands attribute.
    /// </summary>
    [TerraformPropertyName("commands")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> Commands { get; set; } = default!;

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformPropertyName("environment_variables")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    [TerraformPropertyName("image")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Image { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The secure_environment_variables attribute.
    /// </summary>
    [TerraformPropertyName("secure_environment_variables")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? SecureEnvironmentVariables { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerGroupTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_container_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermContainerGroup : TerraformResource
{
    public AzurermContainerGroup(string name) : base("azurerm_container_group", name)
    {
    }

    /// <summary>
    /// The dns_name_label attribute.
    /// </summary>
    [TerraformPropertyName("dns_name_label")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DnsNameLabel { get; set; }

    /// <summary>
    /// The dns_name_label_reuse_policy attribute.
    /// </summary>
    [TerraformPropertyName("dns_name_label_reuse_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DnsNameLabelReusePolicy { get; set; }

    /// <summary>
    /// The exposed_port attribute.
    /// </summary>
    [TerraformPropertyName("exposed_port")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<object> ExposedPort { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformPropertyName("ip_address_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IpAddressType { get; set; }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KeyVaultKeyId { get; set; }

    /// <summary>
    /// The key_vault_user_assigned_identity_id attribute.
    /// </summary>
    [TerraformPropertyName("key_vault_user_assigned_identity_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KeyVaultUserAssignedIdentityId { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_profile_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("network_profile_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> NetworkProfileId { get; set; } = default!;

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsType is required")]
    [TerraformPropertyName("os_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> OsType { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Priority { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The restart_policy attribute.
    /// </summary>
    [TerraformPropertyName("restart_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RestartPolicy { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Sku { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SubnetIds { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Zones { get; set; }

    /// <summary>
    /// Block for container.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Container is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Container block(s) required")]
    [TerraformPropertyName("container")]
    public TerraformList<TerraformBlock<AzurermContainerGroupContainerBlock>>? Container { get; set; }

    /// <summary>
    /// Block for diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Diagnostics block(s) allowed")]
    [TerraformPropertyName("diagnostics")]
    public TerraformList<TerraformBlock<AzurermContainerGroupDiagnosticsBlock>>? Diagnostics { get; set; }

    /// <summary>
    /// Block for dns_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsConfig block(s) allowed")]
    [TerraformPropertyName("dns_config")]
    public TerraformList<TerraformBlock<AzurermContainerGroupDnsConfigBlock>>? DnsConfig { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermContainerGroupIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for image_registry_credential.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("image_registry_credential")]
    public TerraformList<TerraformBlock<AzurermContainerGroupImageRegistryCredentialBlock>>? ImageRegistryCredential { get; set; }

    /// <summary>
    /// Block for init_container.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("init_container")]
    public TerraformList<TerraformBlock<AzurermContainerGroupInitContainerBlock>>? InitContainer { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermContainerGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Fqdn => new TerraformReference(this, "fqdn");

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformPropertyName("ip_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IpAddress => new TerraformReference(this, "ip_address");

}
