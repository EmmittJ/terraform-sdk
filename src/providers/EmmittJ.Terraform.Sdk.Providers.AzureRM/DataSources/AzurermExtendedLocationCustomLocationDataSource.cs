using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermExtendedLocationCustomLocationDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_extended_location_custom_location.
/// </summary>
public class AzurermExtendedLocationCustomLocationDataSource : TerraformDataSource
{
    public AzurermExtendedLocationCustomLocationDataSource(string name) : base("azurerm_extended_location_custom_location", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("authentication");
        SetOutput("cluster_extension_ids");
        SetOutput("display_name");
        SetOutput("host_resource_id");
        SetOutput("host_type");
        SetOutput("location");
        SetOutput("namespace");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermExtendedLocationCustomLocationDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The authentication attribute.
    /// </summary>
    public TerraformExpression Authentication => this["authentication"];

    /// <summary>
    /// The cluster_extension_ids attribute.
    /// </summary>
    public TerraformExpression ClusterExtensionIds => this["cluster_extension_ids"];

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The host_resource_id attribute.
    /// </summary>
    public TerraformExpression HostResourceId => this["host_resource_id"];

    /// <summary>
    /// The host_type attribute.
    /// </summary>
    public TerraformExpression HostType => this["host_type"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformExpression Namespace => this["namespace"];

}
