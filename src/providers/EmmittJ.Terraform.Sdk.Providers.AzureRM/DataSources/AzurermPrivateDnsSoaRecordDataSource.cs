using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPrivateDnsSoaRecordDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_private_dns_soa_record.
/// </summary>
public class AzurermPrivateDnsSoaRecordDataSource : TerraformDataSource
{
    public AzurermPrivateDnsSoaRecordDataSource(string name) : base("azurerm_private_dns_soa_record", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("email");
        SetOutput("expire_time");
        SetOutput("fqdn");
        SetOutput("host_name");
        SetOutput("minimum_ttl");
        SetOutput("refresh_time");
        SetOutput("retry_time");
        SetOutput("serial_number");
        SetOutput("tags");
        SetOutput("ttl");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("zone_name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The zone_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneName is required")]
    public required TerraformProperty<string> ZoneName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("zone_name");
        set => SetProperty("zone_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPrivateDnsSoaRecordDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformExpression Email => this["email"];

    /// <summary>
    /// The expire_time attribute.
    /// </summary>
    public TerraformExpression ExpireTime => this["expire_time"];

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformExpression HostName => this["host_name"];

    /// <summary>
    /// The minimum_ttl attribute.
    /// </summary>
    public TerraformExpression MinimumTtl => this["minimum_ttl"];

    /// <summary>
    /// The refresh_time attribute.
    /// </summary>
    public TerraformExpression RefreshTime => this["refresh_time"];

    /// <summary>
    /// The retry_time attribute.
    /// </summary>
    public TerraformExpression RetryTime => this["retry_time"];

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    public TerraformExpression SerialNumber => this["serial_number"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformExpression Ttl => this["ttl"];

}
