using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_netapp_volume_group_oracle resource.
/// </summary>
public class AzurermNetappVolumeGroupOracle : TerraformResource
{
    public AzurermNetappVolumeGroupOracle(string name) : base("azurerm_netapp_volume_group_oracle", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    public TerraformProperty<string>? AccountName
    {
        get => GetProperty<TerraformProperty<string>>("account_name");
        set => this.WithProperty("account_name", value);
    }

    /// <summary>
    /// The application_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? ApplicationIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("application_identifier");
        set => this.WithProperty("application_identifier", value);
    }

    /// <summary>
    /// The group_description attribute.
    /// </summary>
    public TerraformProperty<string>? GroupDescription
    {
        get => GetProperty<TerraformProperty<string>>("group_description");
        set => this.WithProperty("group_description", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

}
