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
    public TerraformProperty<bool>? AllowClaim
    {
        get => GetProperty<TerraformProperty<bool>>("allow_claim");
        set => this.WithProperty("allow_claim", value);
    }

    /// <summary>
    /// The disallow_public_ip_address attribute.
    /// </summary>
    public TerraformProperty<bool>? DisallowPublicIpAddress
    {
        get => GetProperty<TerraformProperty<bool>>("disallow_public_ip_address");
        set => this.WithProperty("disallow_public_ip_address", value);
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
    /// The lab_name attribute.
    /// </summary>
    public TerraformProperty<string>? LabName
    {
        get => GetProperty<TerraformProperty<string>>("lab_name");
        set => this.WithProperty("lab_name", value);
    }

    /// <summary>
    /// The lab_subnet_name attribute.
    /// </summary>
    public TerraformProperty<string>? LabSubnetName
    {
        get => GetProperty<TerraformProperty<string>>("lab_subnet_name");
        set => this.WithProperty("lab_subnet_name", value);
    }

    /// <summary>
    /// The lab_virtual_network_id attribute.
    /// </summary>
    public TerraformProperty<string>? LabVirtualNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("lab_virtual_network_id");
        set => this.WithProperty("lab_virtual_network_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The notes attribute.
    /// </summary>
    public TerraformProperty<string>? Notes
    {
        get => GetProperty<TerraformProperty<string>>("notes");
        set => this.WithProperty("notes", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformProperty<string>? Size
    {
        get => GetProperty<TerraformProperty<string>>("size");
        set => this.WithProperty("size", value);
    }

    /// <summary>
    /// The ssh_key attribute.
    /// </summary>
    public TerraformProperty<string>? SshKey
    {
        get => GetProperty<TerraformProperty<string>>("ssh_key");
        set => this.WithProperty("ssh_key", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformProperty<string>? StorageType
    {
        get => GetProperty<TerraformProperty<string>>("storage_type");
        set => this.WithProperty("storage_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
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
