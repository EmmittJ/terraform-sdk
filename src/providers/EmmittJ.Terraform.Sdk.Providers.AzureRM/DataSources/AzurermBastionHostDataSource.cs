using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBastionHostDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_bastion_host.
/// </summary>
public class AzurermBastionHostDataSource : TerraformDataSource
{
    public AzurermBastionHostDataSource(string name) : base("azurerm_bastion_host", name)
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermBastionHostDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The copy_paste_enabled attribute.
    /// </summary>
    [TerraformPropertyName("copy_paste_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> CopyPasteEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "copy_paste_enabled");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_name");

    /// <summary>
    /// The file_copy_enabled attribute.
    /// </summary>
    [TerraformPropertyName("file_copy_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> FileCopyEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "file_copy_enabled");

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    [TerraformPropertyName("ip_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> IpConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ip_configuration");

    /// <summary>
    /// The ip_connect_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ip_connect_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IpConnectEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "ip_connect_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The scale_units attribute.
    /// </summary>
    [TerraformPropertyName("scale_units")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ScaleUnits => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "scale_units");

    /// <summary>
    /// The session_recording_enabled attribute.
    /// </summary>
    [TerraformPropertyName("session_recording_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> SessionRecordingEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "session_recording_enabled");

    /// <summary>
    /// The shareable_link_enabled attribute.
    /// </summary>
    [TerraformPropertyName("shareable_link_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ShareableLinkEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "shareable_link_enabled");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Sku => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The tunneling_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tunneling_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> TunnelingEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "tunneling_enabled");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Zones => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "zones");

}
