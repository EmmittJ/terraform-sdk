using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDnsCnameRecordDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_dns_cname_record.
/// </summary>
public class AzurermDnsCnameRecordDataSource : TerraformDataSource
{
    public AzurermDnsCnameRecordDataSource(string name) : base("azurerm_dns_cname_record", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("fqdn");
        this.DeclareOutput("record");
        this.DeclareOutput("tags");
        this.DeclareOutput("target_resource_id");
        this.DeclareOutput("ttl");
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
    /// The zone_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneName is required")]
    public required TerraformProperty<string> ZoneName
    {
        get => GetProperty<TerraformProperty<string>>("zone_name");
        set => this.WithProperty("zone_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDnsCnameRecordDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDnsCnameRecordDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

    /// <summary>
    /// The record attribute.
    /// </summary>
    public TerraformExpression Record => this["record"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    public TerraformExpression TargetResourceId => this["target_resource_id"];

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformExpression Ttl => this["ttl"];

}
