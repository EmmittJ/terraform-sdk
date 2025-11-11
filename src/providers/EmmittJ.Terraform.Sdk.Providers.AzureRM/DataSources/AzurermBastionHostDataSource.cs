using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermBastionHostDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_bastion_host.
/// </summary>
public partial class AzurermBastionHostDataSource : TerraformDataSource
{
    public AzurermBastionHostDataSource(string name) : base("azurerm_bastion_host", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermBastionHostDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The copy_paste_enabled attribute.
    /// </summary>
    [TerraformProperty("copy_paste_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> CopyPasteEnabled { get; }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    [TerraformProperty("dns_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DnsName { get; }

    /// <summary>
    /// The file_copy_enabled attribute.
    /// </summary>
    [TerraformProperty("file_copy_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> FileCopyEnabled { get; }

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    [TerraformProperty("ip_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> IpConfiguration { get; }

    /// <summary>
    /// The ip_connect_enabled attribute.
    /// </summary>
    [TerraformProperty("ip_connect_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> IpConnectEnabled { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The scale_units attribute.
    /// </summary>
    [TerraformProperty("scale_units")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> ScaleUnits { get; }

    /// <summary>
    /// The session_recording_enabled attribute.
    /// </summary>
    [TerraformProperty("session_recording_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> SessionRecordingEnabled { get; }

    /// <summary>
    /// The shareable_link_enabled attribute.
    /// </summary>
    [TerraformProperty("shareable_link_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> ShareableLinkEnabled { get; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Sku { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The tunneling_enabled attribute.
    /// </summary>
    [TerraformProperty("tunneling_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> TunnelingEnabled { get; }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [TerraformProperty("zones")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Zones { get; }

}
