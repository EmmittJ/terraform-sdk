using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSharedImageDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_shared_image.
/// </summary>
public class AzurermSharedImageDataSource : TerraformDataSource
{
    public AzurermSharedImageDataSource(string name) : base("azurerm_shared_image", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("accelerated_network_support_enabled");
        SetOutput("architecture");
        SetOutput("confidential_vm_enabled");
        SetOutput("confidential_vm_supported");
        SetOutput("description");
        SetOutput("eula");
        SetOutput("hibernation_enabled");
        SetOutput("hyper_v_generation");
        SetOutput("identifier");
        SetOutput("location");
        SetOutput("os_type");
        SetOutput("privacy_statement_uri");
        SetOutput("purchase_plan");
        SetOutput("release_note_uri");
        SetOutput("specialized");
        SetOutput("tags");
        SetOutput("trusted_launch_enabled");
        SetOutput("trusted_launch_supported");
        SetOutput("gallery_name");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
    }

    /// <summary>
    /// The gallery_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GalleryName is required")]
    public required TerraformProperty<string> GalleryName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("gallery_name");
        set => SetProperty("gallery_name", value);
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
    public AzurermSharedImageDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The accelerated_network_support_enabled attribute.
    /// </summary>
    public TerraformExpression AcceleratedNetworkSupportEnabled => this["accelerated_network_support_enabled"];

    /// <summary>
    /// The architecture attribute.
    /// </summary>
    public TerraformExpression Architecture => this["architecture"];

    /// <summary>
    /// The confidential_vm_enabled attribute.
    /// </summary>
    public TerraformExpression ConfidentialVmEnabled => this["confidential_vm_enabled"];

    /// <summary>
    /// The confidential_vm_supported attribute.
    /// </summary>
    public TerraformExpression ConfidentialVmSupported => this["confidential_vm_supported"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The eula attribute.
    /// </summary>
    public TerraformExpression Eula => this["eula"];

    /// <summary>
    /// The hibernation_enabled attribute.
    /// </summary>
    public TerraformExpression HibernationEnabled => this["hibernation_enabled"];

    /// <summary>
    /// The hyper_v_generation attribute.
    /// </summary>
    public TerraformExpression HyperVGeneration => this["hyper_v_generation"];

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    public TerraformExpression Identifier => this["identifier"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    public TerraformExpression OsType => this["os_type"];

    /// <summary>
    /// The privacy_statement_uri attribute.
    /// </summary>
    public TerraformExpression PrivacyStatementUri => this["privacy_statement_uri"];

    /// <summary>
    /// The purchase_plan attribute.
    /// </summary>
    public TerraformExpression PurchasePlan => this["purchase_plan"];

    /// <summary>
    /// The release_note_uri attribute.
    /// </summary>
    public TerraformExpression ReleaseNoteUri => this["release_note_uri"];

    /// <summary>
    /// The specialized attribute.
    /// </summary>
    public TerraformExpression Specialized => this["specialized"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The trusted_launch_enabled attribute.
    /// </summary>
    public TerraformExpression TrustedLaunchEnabled => this["trusted_launch_enabled"];

    /// <summary>
    /// The trusted_launch_supported attribute.
    /// </summary>
    public TerraformExpression TrustedLaunchSupported => this["trusted_launch_supported"];

}
