using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for soa_record in .
/// Nesting mode: list
/// </summary>
public class AzurermPrivateDnsZoneSoaRecordBlock : TerraformBlock
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformProperty<string> Email
    {
        get => GetProperty<TerraformProperty<string>>("email");
        set => WithProperty("email", value);
    }

    /// <summary>
    /// The expire_time attribute.
    /// </summary>
    public TerraformProperty<double>? ExpireTime
    {
        get => GetProperty<TerraformProperty<double>>("expire_time");
        set => WithProperty("expire_time", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformProperty<string>? Fqdn
    {
        get => GetProperty<TerraformProperty<string>>("fqdn");
        set => WithProperty("fqdn", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformProperty<string>? HostName
    {
        get => GetProperty<TerraformProperty<string>>("host_name");
        set => WithProperty("host_name", value);
    }

    /// <summary>
    /// The minimum_ttl attribute.
    /// </summary>
    public TerraformProperty<double>? MinimumTtl
    {
        get => GetProperty<TerraformProperty<double>>("minimum_ttl");
        set => WithProperty("minimum_ttl", value);
    }

    /// <summary>
    /// The refresh_time attribute.
    /// </summary>
    public TerraformProperty<double>? RefreshTime
    {
        get => GetProperty<TerraformProperty<double>>("refresh_time");
        set => WithProperty("refresh_time", value);
    }

    /// <summary>
    /// The retry_time attribute.
    /// </summary>
    public TerraformProperty<double>? RetryTime
    {
        get => GetProperty<TerraformProperty<double>>("retry_time");
        set => WithProperty("retry_time", value);
    }

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    public TerraformProperty<double>? SerialNumber
    {
        get => GetProperty<TerraformProperty<double>>("serial_number");
        set => WithProperty("serial_number", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => WithProperty("tags", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformProperty<double>? Ttl
    {
        get => GetProperty<TerraformProperty<double>>("ttl");
        set => WithProperty("ttl", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPrivateDnsZoneTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_private_dns_zone resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermPrivateDnsZone : TerraformResource
{
    public AzurermPrivateDnsZone(string name) : base("azurerm_private_dns_zone", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("max_number_of_record_sets");
        this.DeclareOutput("max_number_of_virtual_network_links");
        this.DeclareOutput("max_number_of_virtual_network_links_with_registration");
        this.DeclareOutput("number_of_record_sets");
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
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for soa_record.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoaRecord block(s) allowed")]
    public List<AzurermPrivateDnsZoneSoaRecordBlock>? SoaRecord
    {
        get => GetProperty<List<AzurermPrivateDnsZoneSoaRecordBlock>>("soa_record");
        set => this.WithProperty("soa_record", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPrivateDnsZoneTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermPrivateDnsZoneTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The max_number_of_record_sets attribute.
    /// </summary>
    public TerraformExpression MaxNumberOfRecordSets => this["max_number_of_record_sets"];

    /// <summary>
    /// The max_number_of_virtual_network_links attribute.
    /// </summary>
    public TerraformExpression MaxNumberOfVirtualNetworkLinks => this["max_number_of_virtual_network_links"];

    /// <summary>
    /// The max_number_of_virtual_network_links_with_registration attribute.
    /// </summary>
    public TerraformExpression MaxNumberOfVirtualNetworkLinksWithRegistration => this["max_number_of_virtual_network_links_with_registration"];

    /// <summary>
    /// The number_of_record_sets attribute.
    /// </summary>
    public TerraformExpression NumberOfRecordSets => this["number_of_record_sets"];

}
