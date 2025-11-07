using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_public_ips.
/// </summary>
public class AzurermPublicIpsDataSource : TerraformDataSource
{
    public AzurermPublicIpsDataSource(string name) : base("azurerm_public_ips", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("public_ips");
    }

    /// <summary>
    /// The allocation_type attribute.
    /// </summary>
    public TerraformProperty<string>? AllocationType
    {
        get => GetProperty<TerraformProperty<string>>("allocation_type");
        set => this.WithProperty("allocation_type", value);
    }

    /// <summary>
    /// The attachment_status attribute.
    /// </summary>
    public TerraformProperty<string>? AttachmentStatus
    {
        get => GetProperty<TerraformProperty<string>>("attachment_status");
        set => this.WithProperty("attachment_status", value);
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
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
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
    /// The public_ips attribute.
    /// </summary>
    public TerraformExpression PublicIps => this["public_ips"];

}
