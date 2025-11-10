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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Product is required")]
    public required TerraformProperty<string> Product
    {
        set => SetProperty("product", value);
    }

    /// <summary>
    /// The promotion_code attribute.
    /// </summary>
    public TerraformProperty<string>? PromotionCode
    {
        set => SetProperty("promotion_code", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformProperty<string> Publisher
    {
        set => SetProperty("publisher", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        set => SetProperty("version", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_kubernetes_cluster_extension resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermKubernetesClusterExtension : TerraformResource
{
    public AzurermKubernetesClusterExtension(string name) : base("azurerm_kubernetes_cluster_extension", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("aks_assigned_identity");
        SetOutput("current_version");
        SetOutput("cluster_id");
        SetOutput("configuration_protected_settings");
        SetOutput("configuration_settings");
        SetOutput("extension_type");
        SetOutput("id");
        SetOutput("name");
        SetOutput("release_namespace");
        SetOutput("release_train");
        SetOutput("target_namespace");
        SetOutput("version");
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformProperty<string> ClusterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_id");
        set => SetProperty("cluster_id", value);
    }

    /// <summary>
    /// The configuration_protected_settings attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> ConfigurationProtectedSettings
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("configuration_protected_settings");
        set => SetProperty("configuration_protected_settings", value);
    }

    /// <summary>
    /// The configuration_settings attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> ConfigurationSettings
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("configuration_settings");
        set => SetProperty("configuration_settings", value);
    }

    /// <summary>
    /// The extension_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExtensionType is required")]
    public required TerraformProperty<string> ExtensionType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("extension_type");
        set => SetProperty("extension_type", value);
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
    /// The release_namespace attribute.
    /// </summary>
    public TerraformProperty<string> ReleaseNamespace
    {
        get => GetRequiredOutput<TerraformProperty<string>>("release_namespace");
        set => SetProperty("release_namespace", value);
    }

    /// <summary>
    /// The release_train attribute.
    /// </summary>
    public TerraformProperty<string> ReleaseTrain
    {
        get => GetRequiredOutput<TerraformProperty<string>>("release_train");
        set => SetProperty("release_train", value);
    }

    /// <summary>
    /// The target_namespace attribute.
    /// </summary>
    public TerraformProperty<string> TargetNamespace
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_namespace");
        set => SetProperty("target_namespace", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    public List<AzurermKubernetesClusterExtensionPlanBlock>? Plan
    {
        set => SetProperty("plan", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermKubernetesClusterExtensionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
