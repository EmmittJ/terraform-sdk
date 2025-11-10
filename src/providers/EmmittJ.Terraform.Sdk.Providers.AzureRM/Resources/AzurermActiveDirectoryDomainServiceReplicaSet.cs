using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermActiveDirectoryDomainServiceReplicaSetTimeoutsBlock : ITerraformBlock
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

}

/// <summary>
/// Manages a azurerm_active_directory_domain_service_replica_set resource.
/// </summary>
public class AzurermActiveDirectoryDomainServiceReplicaSet : TerraformResource
{
    public AzurermActiveDirectoryDomainServiceReplicaSet(string name) : base("azurerm_active_directory_domain_service_replica_set", name)
    {
    }

    /// <summary>
    /// The domain_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainServiceId is required")]
    [TerraformPropertyName("domain_service_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DomainServiceId { get; set; }

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
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubnetId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermActiveDirectoryDomainServiceReplicaSetTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The domain_controller_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("domain_controller_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> DomainControllerIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "domain_controller_ip_addresses");

    /// <summary>
    /// The external_access_ip_address attribute.
    /// </summary>
    [TerraformPropertyName("external_access_ip_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExternalAccessIpAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "external_access_ip_address");

    /// <summary>
    /// The service_status attribute.
    /// </summary>
    [TerraformPropertyName("service_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_status");

}
