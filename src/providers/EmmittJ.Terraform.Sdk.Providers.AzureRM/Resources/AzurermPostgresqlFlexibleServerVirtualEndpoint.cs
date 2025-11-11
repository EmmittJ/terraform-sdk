using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermPostgresqlFlexibleServerVirtualEndpointTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_postgresql_flexible_server_virtual_endpoint resource.
/// </summary>
public partial class AzurermPostgresqlFlexibleServerVirtualEndpoint : TerraformResource
{
    public AzurermPostgresqlFlexibleServerVirtualEndpoint(string name) : base("azurerm_postgresql_flexible_server_virtual_endpoint", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the Virtual Endpoint
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The Resource ID of the *Replica* Postgres Flexible Server this should be associated with
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicaServerId is required")]
    [TerraformProperty("replica_server_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ReplicaServerId { get; set; }

    /// <summary>
    /// The Resource ID of the *Source* Postgres Flexible Server this should be associated with
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceServerId is required")]
    [TerraformProperty("source_server_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SourceServerId { get; set; }

    /// <summary>
    /// The type of Virtual Endpoint
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermPostgresqlFlexibleServerVirtualEndpointTimeoutsBlock>? Timeouts { get; set; }

}
