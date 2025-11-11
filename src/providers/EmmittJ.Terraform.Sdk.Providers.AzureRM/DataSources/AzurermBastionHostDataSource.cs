using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBastionHostDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermBastionHostDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The copy_paste_enabled attribute.
    /// </summary>
    [TerraformPropertyName("copy_paste_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> CopyPasteEnabled => new TerraformReference(this, "copy_paste_enabled");

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformPropertyName("dns_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsName => new TerraformReference(this, "dns_name");

    /// <summary>
    /// The file_copy_enabled attribute.
    /// </summary>
    [TerraformPropertyName("file_copy_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> FileCopyEnabled => new TerraformReference(this, "file_copy_enabled");

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    [TerraformPropertyName("ip_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> IpConfiguration => new TerraformReference(this, "ip_configuration");

    /// <summary>
    /// The ip_connect_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ip_connect_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> IpConnectEnabled => new TerraformReference(this, "ip_connect_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The scale_units attribute.
    /// </summary>
    [TerraformPropertyName("scale_units")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ScaleUnits => new TerraformReference(this, "scale_units");

    /// <summary>
    /// The session_recording_enabled attribute.
    /// </summary>
    [TerraformPropertyName("session_recording_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> SessionRecordingEnabled => new TerraformReference(this, "session_recording_enabled");

    /// <summary>
    /// The shareable_link_enabled attribute.
    /// </summary>
    [TerraformPropertyName("shareable_link_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ShareableLinkEnabled => new TerraformReference(this, "shareable_link_enabled");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Sku => new TerraformReference(this, "sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The tunneling_enabled attribute.
    /// </summary>
    [TerraformPropertyName("tunneling_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> TunnelingEnabled => new TerraformReference(this, "tunneling_enabled");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformPropertyName("zones")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Zones => new TerraformReference(this, "zones");

}
