using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPublicIpsDataSourceTimeoutsBlock : TerraformBlock
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
        SetOutput("public_ips");
        SetOutput("allocation_type");
        SetOutput("attachment_status");
        SetOutput("id");
        SetOutput("name_prefix");
        SetOutput("resource_group_name");
    }

    /// <summary>
    /// The allocation_type attribute.
    /// </summary>
    public TerraformProperty<string> AllocationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("allocation_type");
        set => SetProperty("allocation_type", value);
    }

    /// <summary>
    /// The attachment_status attribute.
    /// </summary>
    public TerraformProperty<string> AttachmentStatus
    {
        get => GetRequiredOutput<TerraformProperty<string>>("attachment_status");
        set => SetProperty("attachment_status", value);
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
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> NamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_prefix");
        set => SetProperty("name_prefix", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPublicIpsDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The public_ips attribute.
    /// </summary>
    public TerraformExpression PublicIps => this["public_ips"];

}
