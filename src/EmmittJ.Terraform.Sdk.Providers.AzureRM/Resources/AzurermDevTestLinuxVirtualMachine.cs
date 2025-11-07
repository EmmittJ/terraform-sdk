using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_dev_test_linux_virtual_machine resource.
/// </summary>
public class AzurermDevTestLinuxVirtualMachine : TerraformResource
{
    public AzurermDevTestLinuxVirtualMachine(string name) : base("azurerm_dev_test_linux_virtual_machine", name)
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
    public TerraformLiteralProperty<bool>? AllowClaim
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_claim");
        set => this.WithProperty("allow_claim", value);
    }

    /// <summary>
    /// The disallow_public_ip_address attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DisallowPublicIpAddress
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disallow_public_ip_address");
        set => this.WithProperty("disallow_public_ip_address", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The lab_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LabName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lab_name");
        set => this.WithProperty("lab_name", value);
    }

    /// <summary>
    /// The lab_subnet_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LabSubnetName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lab_subnet_name");
        set => this.WithProperty("lab_subnet_name", value);
    }

    /// <summary>
    /// The lab_virtual_network_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LabVirtualNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lab_virtual_network_id");
        set => this.WithProperty("lab_virtual_network_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The notes attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Notes
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notes");
        set => this.WithProperty("notes", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Size
    {
        get => GetProperty<TerraformLiteralProperty<string>>("size");
        set => this.WithProperty("size", value);
    }

    /// <summary>
    /// The ssh_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SshKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ssh_key");
        set => this.WithProperty("ssh_key", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StorageType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_type");
        set => this.WithProperty("storage_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Username
    {
        get => GetProperty<TerraformLiteralProperty<string>>("username");
        set => this.WithProperty("username", value);
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
