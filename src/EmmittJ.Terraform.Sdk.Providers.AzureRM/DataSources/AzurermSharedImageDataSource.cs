using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("accelerated_network_support_enabled");
        this.DeclareOutput("architecture");
        this.DeclareOutput("confidential_vm_enabled");
        this.DeclareOutput("confidential_vm_supported");
        this.DeclareOutput("description");
        this.DeclareOutput("eula");
        this.DeclareOutput("hibernation_enabled");
        this.DeclareOutput("hyper_v_generation");
        this.DeclareOutput("identifier");
        this.DeclareOutput("location");
        this.DeclareOutput("os_type");
        this.DeclareOutput("privacy_statement_uri");
        this.DeclareOutput("purchase_plan");
        this.DeclareOutput("release_note_uri");
        this.DeclareOutput("specialized");
        this.DeclareOutput("tags");
        this.DeclareOutput("trusted_launch_enabled");
        this.DeclareOutput("trusted_launch_supported");
    }

    /// <summary>
    /// The gallery_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? GalleryName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("gallery_name");
        set => this.WithProperty("gallery_name", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
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
