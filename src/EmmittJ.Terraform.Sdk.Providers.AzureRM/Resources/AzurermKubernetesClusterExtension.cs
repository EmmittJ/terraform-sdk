using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public class AzurermKubernetesClusterExtensionPlanBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    public required TerraformProperty<string> Product
    {
        get => GetProperty<TerraformProperty<string>>("product");
        set => WithProperty("product", value);
    }

    /// <summary>
    /// The promotion_code attribute.
    /// </summary>
    public TerraformProperty<string>? PromotionCode
    {
        get => GetProperty<TerraformProperty<string>>("promotion_code");
        set => WithProperty("promotion_code", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformProperty<string> Publisher
    {
        get => GetProperty<TerraformProperty<string>>("publisher");
        set => WithProperty("publisher", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => WithProperty("version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesClusterExtensionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_kubernetes_cluster_extension resource.
/// </summary>
public class AzurermKubernetesClusterExtension : TerraformResource
{
    public AzurermKubernetesClusterExtension(string name) : base("azurerm_kubernetes_cluster_extension", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("aks_assigned_identity");
        this.DeclareOutput("current_version");
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformProperty<string> ClusterId
    {
        get => GetProperty<TerraformProperty<string>>("cluster_id");
        set => this.WithProperty("cluster_id", value);
    }

    /// <summary>
    /// The configuration_protected_settings attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ConfigurationProtectedSettings
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("configuration_protected_settings");
        set => this.WithProperty("configuration_protected_settings", value);
    }

    /// <summary>
    /// The configuration_settings attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ConfigurationSettings
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("configuration_settings");
        set => this.WithProperty("configuration_settings", value);
    }

    /// <summary>
    /// The extension_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExtensionType is required")]
    public required TerraformProperty<string> ExtensionType
    {
        get => GetProperty<TerraformProperty<string>>("extension_type");
        set => this.WithProperty("extension_type", value);
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
    /// The release_namespace attribute.
    /// </summary>
    public TerraformProperty<string>? ReleaseNamespace
    {
        get => GetProperty<TerraformProperty<string>>("release_namespace");
        set => this.WithProperty("release_namespace", value);
    }

    /// <summary>
    /// The release_train attribute.
    /// </summary>
    public TerraformProperty<string>? ReleaseTrain
    {
        get => GetProperty<TerraformProperty<string>>("release_train");
        set => this.WithProperty("release_train", value);
    }

    /// <summary>
    /// The target_namespace attribute.
    /// </summary>
    public TerraformProperty<string>? TargetNamespace
    {
        get => GetProperty<TerraformProperty<string>>("target_namespace");
        set => this.WithProperty("target_namespace", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    public List<AzurermKubernetesClusterExtensionPlanBlock>? Plan
    {
        get => GetProperty<List<AzurermKubernetesClusterExtensionPlanBlock>>("plan");
        set => this.WithProperty("plan", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKubernetesClusterExtensionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermKubernetesClusterExtensionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The aks_assigned_identity attribute.
    /// </summary>
    public TerraformExpression AksAssignedIdentity => this["aks_assigned_identity"];

    /// <summary>
    /// The current_version attribute.
    /// </summary>
    public TerraformExpression CurrentVersion => this["current_version"];

}
