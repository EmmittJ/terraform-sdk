using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for soa_record in .
/// Nesting mode: list
/// </summary>
public class AzurermPrivateDnsZoneSoaRecordBlock : ITerraformBlock
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    [TerraformPropertyName("email")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Email { get; set; }

    /// <summary>
    /// The expire_time attribute.
    /// </summary>
    [TerraformPropertyName("expire_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? ExpireTime { get; set; }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformPropertyName("fqdn")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Fqdn => new TerraformReferenceProperty<TerraformProperty<string>>("", "fqdn");

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [TerraformPropertyName("host_name")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostName => new TerraformReferenceProperty<TerraformProperty<string>>("", "host_name");

    /// <summary>
    /// The minimum_ttl attribute.
    /// </summary>
    [TerraformPropertyName("minimum_ttl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinimumTtl { get; set; }

    /// <summary>
    /// The refresh_time attribute.
    /// </summary>
    [TerraformPropertyName("refresh_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RefreshTime { get; set; }

    /// <summary>
    /// The retry_time attribute.
    /// </summary>
    [TerraformPropertyName("retry_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RetryTime { get; set; }

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    [TerraformPropertyName("serial_number")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SerialNumber => new TerraformReferenceProperty<TerraformProperty<double>>("", "serial_number");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [TerraformPropertyName("ttl")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Ttl { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPrivateDnsZoneTimeoutsBlock : ITerraformBlock
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
/// Manages a azurerm_private_dns_zone resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermPrivateDnsZone : TerraformResource
{
    public AzurermPrivateDnsZone(string name) : base("azurerm_private_dns_zone", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    /// Block for soa_record.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoaRecord block(s) allowed")]
    [TerraformPropertyName("soa_record")]
    public TerraformList<TerraformBlock<AzurermPrivateDnsZoneSoaRecordBlock>>? SoaRecord { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermPrivateDnsZoneTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The max_number_of_record_sets attribute.
    /// </summary>
    [TerraformPropertyName("max_number_of_record_sets")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxNumberOfRecordSets => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_number_of_record_sets");

    /// <summary>
    /// The max_number_of_virtual_network_links attribute.
    /// </summary>
    [TerraformPropertyName("max_number_of_virtual_network_links")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxNumberOfVirtualNetworkLinks => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_number_of_virtual_network_links");

    /// <summary>
    /// The max_number_of_virtual_network_links_with_registration attribute.
    /// </summary>
    [TerraformPropertyName("max_number_of_virtual_network_links_with_registration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxNumberOfVirtualNetworkLinksWithRegistration => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_number_of_virtual_network_links_with_registration");

    /// <summary>
    /// The number_of_record_sets attribute.
    /// </summary>
    [TerraformPropertyName("number_of_record_sets")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> NumberOfRecordSets => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "number_of_record_sets");

}
