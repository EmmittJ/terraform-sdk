using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for record in .
/// Nesting mode: set
/// </summary>
public class AzurermDnsCaaRecordRecordBlock : TerraformBlock
{
    /// <summary>
    /// The flags attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Flags is required")]
    public required TerraformProperty<double> Flags
    {
        get => GetProperty<TerraformProperty<double>>("flags");
        set => WithProperty("flags", value);
    }

    /// <summary>
    /// The tag attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tag is required")]
    public required TerraformProperty<string> Tag
    {
        get => GetProperty<TerraformProperty<string>>("tag");
        set => WithProperty("tag", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDnsCaaRecordTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_dns_caa_record resource.
/// </summary>
public class AzurermDnsCaaRecord : TerraformResource
{
    public AzurermDnsCaaRecord(string name) : base("azurerm_dns_caa_record", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("fqdn");
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
    /// The ttl attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ttl is required")]
    public required TerraformProperty<double> Ttl
    {
        get => GetProperty<TerraformProperty<double>>("ttl");
        set => this.WithProperty("ttl", value);
    }

    /// <summary>
    /// The zone_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneName is required")]
    public required TerraformProperty<string> ZoneName
    {
        get => GetProperty<TerraformProperty<string>>("zone_name");
        set => this.WithProperty("zone_name", value);
    }

    /// <summary>
    /// Block for record.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Record block(s) required")]
    public HashSet<AzurermDnsCaaRecordRecordBlock>? Record
    {
        get => GetProperty<HashSet<AzurermDnsCaaRecordRecordBlock>>("record");
        set => this.WithProperty("record", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDnsCaaRecordTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDnsCaaRecordTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

}
