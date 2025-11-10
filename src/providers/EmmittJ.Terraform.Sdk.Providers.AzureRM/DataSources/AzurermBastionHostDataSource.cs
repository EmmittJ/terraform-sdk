using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBastionHostDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_bastion_host.
/// </summary>
public class AzurermBastionHostDataSource : TerraformDataSource
{
    public AzurermBastionHostDataSource(string name) : base("azurerm_bastion_host", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("copy_paste_enabled");
        this.DeclareOutput("dns_name");
        this.DeclareOutput("file_copy_enabled");
        this.DeclareOutput("ip_configuration");
        this.DeclareOutput("ip_connect_enabled");
        this.DeclareOutput("location");
        this.DeclareOutput("scale_units");
        this.DeclareOutput("session_recording_enabled");
        this.DeclareOutput("shareable_link_enabled");
        this.DeclareOutput("sku");
        this.DeclareOutput("tags");
        this.DeclareOutput("tunneling_enabled");
        this.DeclareOutput("zones");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBastionHostDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermBastionHostDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The copy_paste_enabled attribute.
    /// </summary>
    public TerraformExpression CopyPasteEnabled => this["copy_paste_enabled"];

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

    /// <summary>
    /// The file_copy_enabled attribute.
    /// </summary>
    public TerraformExpression FileCopyEnabled => this["file_copy_enabled"];

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    public TerraformExpression IpConfiguration => this["ip_configuration"];

    /// <summary>
    /// The ip_connect_enabled attribute.
    /// </summary>
    public TerraformExpression IpConnectEnabled => this["ip_connect_enabled"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The scale_units attribute.
    /// </summary>
    public TerraformExpression ScaleUnits => this["scale_units"];

    /// <summary>
    /// The session_recording_enabled attribute.
    /// </summary>
    public TerraformExpression SessionRecordingEnabled => this["session_recording_enabled"];

    /// <summary>
    /// The shareable_link_enabled attribute.
    /// </summary>
    public TerraformExpression ShareableLinkEnabled => this["shareable_link_enabled"];

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformExpression Sku => this["sku"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The tunneling_enabled attribute.
    /// </summary>
    public TerraformExpression TunnelingEnabled => this["tunneling_enabled"];

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformExpression Zones => this["zones"];

}
