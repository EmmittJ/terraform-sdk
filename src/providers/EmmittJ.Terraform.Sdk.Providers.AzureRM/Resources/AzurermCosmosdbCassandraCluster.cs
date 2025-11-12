using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermCosmosdbCassandraClusterIdentityBlock() : TerraformBlock("identity")
{


    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermCosmosdbCassandraClusterTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_cosmosdb_cassandra_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermCosmosdbCassandraCluster : TerraformResource
{
    public AzurermCosmosdbCassandraCluster(string name) : base("azurerm_cosmosdb_cassandra_cluster", name)
    {
    }

    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    [TerraformProperty("authentication_method")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthenticationMethod { get; set; }

    /// <summary>
    /// The client_certificate_pems attribute.
    /// </summary>
    [TerraformProperty("client_certificate_pems")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ClientCertificatePems { get; set; }

    /// <summary>
    /// The default_admin_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultAdminPassword is required")]
    [TerraformProperty("default_admin_password")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DefaultAdminPassword { get; set; }

    /// <summary>
    /// The delegated_management_subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DelegatedManagementSubnetId is required")]
    [TerraformProperty("delegated_management_subnet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DelegatedManagementSubnetId { get; set; }

    /// <summary>
    /// The external_gossip_certificate_pems attribute.
    /// </summary>
    [TerraformProperty("external_gossip_certificate_pems")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ExternalGossipCertificatePems { get; set; }

    /// <summary>
    /// The external_seed_node_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("external_seed_node_ip_addresses")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ExternalSeedNodeIpAddresses { get; set; }

    /// <summary>
    /// The hours_between_backups attribute.
    /// </summary>
    [TerraformProperty("hours_between_backups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? HoursBetweenBackups { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// The repair_enabled attribute.
    /// </summary>
    [TerraformProperty("repair_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RepairEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Version { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermCosmosdbCassandraClusterIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermCosmosdbCassandraClusterTimeoutsBlock Timeouts { get; set; } = new();

}
