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
    public string? AllocationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("allocation_type")?.Value;
        set => this.WithProperty("allocation_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The attachment_status attribute.
    /// </summary>
    public string? AttachmentStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("attachment_status")?.Value;
        set => this.WithProperty("attachment_status", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name_prefix attribute.
    /// </summary>
    public string? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix")?.Value;
        set => this.WithProperty("name_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The public_ips attribute.
    /// </summary>
    public TerraformExpression PublicIps => this["public_ips"];

}
