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
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
        this.DeclareOutput("authentication");
        this.DeclareOutput("cluster_extension_ids");
        this.DeclareOutput("display_name");
        this.DeclareOutput("host_resource_id");
        this.DeclareOutput("host_type");
        this.DeclareOutput("location");
        this.DeclareOutput("namespace");
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermExtendedLocationCustomLocationDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermExtendedLocationCustomLocationDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
