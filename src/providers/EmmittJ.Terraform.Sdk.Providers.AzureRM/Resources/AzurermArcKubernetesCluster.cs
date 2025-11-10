using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermArcKubernetesClusterIdentityBlock : ITerraformBlock
{
    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>("", "principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>("", "tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermArcKubernetesClusterTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_arc_kubernetes_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermArcKubernetesCluster : TerraformResource
{
    public AzurermArcKubernetesCluster(string name) : base("azurerm_arc_kubernetes_cluster", name)
    {
    }

    /// <summary>
    /// The agent_public_key_certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentPublicKeyCertificate is required")]
    [TerraformPropertyName("agent_public_key_certificate")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AgentPublicKeyCertificate { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Identity block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermArcKubernetesClusterIdentityBlock>>? Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermArcKubernetesClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    [TerraformPropertyName("agent_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AgentVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "agent_version");

    /// <summary>
    /// The distribution attribute.
    /// </summary>
    [TerraformPropertyName("distribution")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Distribution => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "distribution");

    /// <summary>
    /// The infrastructure attribute.
    /// </summary>
    [TerraformPropertyName("infrastructure")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Infrastructure => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "infrastructure");

    /// <summary>
    /// The kubernetes_version attribute.
    /// </summary>
    [TerraformPropertyName("kubernetes_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KubernetesVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kubernetes_version");

    /// <summary>
    /// The offering attribute.
    /// </summary>
    [TerraformPropertyName("offering")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Offering => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "offering");

    /// <summary>
    /// The total_core_count attribute.
    /// </summary>
    [TerraformPropertyName("total_core_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalCoreCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "total_core_count");

    /// <summary>
    /// The total_node_count attribute.
    /// </summary>
    [TerraformPropertyName("total_node_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> TotalNodeCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "total_node_count");

}
