using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_dev_test_windows_virtual_machine resource.
/// </summary>
public class AzurermDevTestWindowsVirtualMachine : TerraformResource
{
    public AzurermDevTestWindowsVirtualMachine(string name) : base("azurerm_dev_test_windows_virtual_machine", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("fqdn");
        this.DeclareOutput("unique_identifier");
    }

    /// <summary>
    /// The allow_claim attribute.
    /// </summary>
    public bool? AllowClaim
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_claim")?.Value;
        set => this.WithProperty("allow_claim", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The disallow_public_ip_address attribute.
    /// </summary>
    public bool? DisallowPublicIpAddress
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disallow_public_ip_address")?.Value;
        set => this.WithProperty("disallow_public_ip_address", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The lab_name attribute.
    /// </summary>
    public string? LabName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lab_name")?.Value;
        set => this.WithProperty("lab_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The lab_subnet_name attribute.
    /// </summary>
    public string? LabSubnetName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lab_subnet_name")?.Value;
        set => this.WithProperty("lab_subnet_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The lab_virtual_network_id attribute.
    /// </summary>
    public string? LabVirtualNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lab_virtual_network_id")?.Value;
        set => this.WithProperty("lab_virtual_network_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The notes attribute.
    /// </summary>
    public string? Notes
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notes")?.Value;
        set => this.WithProperty("notes", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public string? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password")?.Value;
        set => this.WithProperty("password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    public string? Size
    {
        get => GetProperty<TerraformLiteralProperty<string>>("size")?.Value;
        set => this.WithProperty("size", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public string? StorageType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_type")?.Value;
        set => this.WithProperty("storage_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public string? Username
    {
        get => GetProperty<TerraformLiteralProperty<string>>("username")?.Value;
        set => this.WithProperty("username", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformExpression Fqdn => this["fqdn"];

    /// <summary>
    /// The unique_identifier attribute.
    /// </summary>
    public TerraformExpression UniqueIdentifier => this["unique_identifier"];

}
