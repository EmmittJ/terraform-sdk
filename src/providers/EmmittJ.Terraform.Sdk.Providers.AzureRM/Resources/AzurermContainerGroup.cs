using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for container in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerGroupContainerBlock : TerraformBlockBase
{
    /// <summary>
    /// The commands attribute.
    /// </summary>
    [TerraformProperty("commands")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> Commands { get; set; }

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cpu is required")]
    [TerraformProperty("cpu")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Cpu { get; set; }

    /// <summary>
    /// The cpu_limit attribute.
    /// </summary>
    [TerraformProperty("cpu_limit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? CpuLimit { get; set; }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformProperty("environment_variables")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    [TerraformProperty("image")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Image { get; set; }

    /// <summary>
    /// The memory attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Memory is required")]
    [TerraformProperty("memory")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Memory { get; set; }

    /// <summary>
    /// The memory_limit attribute.
    /// </summary>
    [TerraformProperty("memory_limit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MemoryLimit { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The secure_environment_variables attribute.
    /// </summary>
    [TerraformProperty("secure_environment_variables")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? SecureEnvironmentVariables { get; set; }

}

/// <summary>
/// Block type for diagnostics in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerGroupDiagnosticsBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for dns_config in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerGroupDnsConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The nameservers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Nameservers is required")]
    [TerraformProperty("nameservers")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Nameservers { get; set; }

    /// <summary>
    /// The options attribute.
    /// </summary>
    [TerraformProperty("options")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Options { get; set; }

    /// <summary>
    /// The search_domains attribute.
    /// </summary>
    [TerraformProperty("search_domains")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SearchDomains { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerGroupIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for image_registry_credential in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerGroupImageRegistryCredentialBlock : TerraformBlockBase
{
    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// The server attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Server is required")]
    [TerraformProperty("server")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Server { get; set; }

    /// <summary>
    /// The User Assigned Identity to use for Container Registry access.
    /// </summary>
    [TerraformProperty("user_assigned_identity_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserAssignedIdentityId { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [TerraformProperty("username")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Username { get; set; }

}

/// <summary>
/// Block type for init_container in .
/// Nesting mode: list
/// </summary>
public partial class AzurermContainerGroupInitContainerBlock : TerraformBlockBase
{
    /// <summary>
    /// The commands attribute.
    /// </summary>
    [TerraformProperty("commands")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformList<string> Commands { get; set; }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformProperty("environment_variables")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Image is required")]
    [TerraformProperty("image")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Image { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The secure_environment_variables attribute.
    /// </summary>
    [TerraformProperty("secure_environment_variables")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? SecureEnvironmentVariables { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermContainerGroupTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_container_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermContainerGroup : TerraformResource
{
    public AzurermContainerGroup(string name) : base("azurerm_container_group", name)
    {
    }

    /// <summary>
    /// The dns_name_label attribute.
    /// </summary>
    [TerraformProperty("dns_name_label")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DnsNameLabel { get; set; }

    /// <summary>
    /// The dns_name_label_reuse_policy attribute.
    /// </summary>
    [TerraformProperty("dns_name_label_reuse_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DnsNameLabelReusePolicy { get; set; }

    /// <summary>
    /// The exposed_port attribute.
    /// </summary>
    [TerraformProperty("exposed_port")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<object> ExposedPort { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [TerraformProperty("ip_address_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IpAddressType { get; set; }

    /// <summary>
    /// The key_vault_key_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyVaultKeyId { get; set; }

    /// <summary>
    /// The key_vault_user_assigned_identity_id attribute.
    /// </summary>
    [TerraformProperty("key_vault_user_assigned_identity_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyVaultUserAssignedIdentityId { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The network_profile_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("network_profile_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> NetworkProfileId { get; set; }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsType is required")]
    [TerraformProperty("os_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> OsType { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformProperty("priority")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Priority { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The restart_policy attribute.
    /// </summary>
    [TerraformProperty("restart_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RestartPolicy { get; set; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Sku { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SubnetIds { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Zones { get; set; }

    /// <summary>
    /// Block for container.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Container is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Container block(s) required")]
    [TerraformProperty("container")]
    public partial TerraformList<TerraformBlock<AzurermContainerGroupContainerBlock>>? Container { get; set; }

    /// <summary>
    /// Block for diagnostics.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Diagnostics block(s) allowed")]
    [TerraformProperty("diagnostics")]
    public partial TerraformList<TerraformBlock<AzurermContainerGroupDiagnosticsBlock>>? Diagnostics { get; set; }

    /// <summary>
    /// Block for dns_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsConfig block(s) allowed")]
    [TerraformProperty("dns_config")]
    public partial TerraformList<TerraformBlock<AzurermContainerGroupDnsConfigBlock>>? DnsConfig { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public partial TerraformList<TerraformBlock<AzurermContainerGroupIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for image_registry_credential.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("image_registry_credential")]
    public partial TerraformList<TerraformBlock<AzurermContainerGroupImageRegistryCredentialBlock>>? ImageRegistryCredential { get; set; }

    /// <summary>
    /// Block for init_container.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("init_container")]
    public partial TerraformList<TerraformBlock<AzurermContainerGroupInitContainerBlock>>? InitContainer { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermContainerGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformProperty("fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Fqdn { get; }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformProperty("ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IpAddress { get; }

}
