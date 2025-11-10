using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomationPython3PackageTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_automation_python3_package resource.
/// </summary>
public class AzurermAutomationPython3Package : TerraformResource
{
    public AzurermAutomationPython3Package(string name) : base("azurerm_automation_python3_package", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("automation_account_name");
        SetOutput("content_uri");
        SetOutput("content_version");
        SetOutput("hash_algorithm");
        SetOutput("hash_value");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("tags");
    }

    /// <summary>
    /// The automation_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountName is required")]
    public required TerraformProperty<string> AutomationAccountName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("automation_account_name");
        set => SetProperty("automation_account_name", value);
    }

    /// <summary>
    /// The content_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentUri is required")]
    public required TerraformProperty<string> ContentUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content_uri");
        set => SetProperty("content_uri", value);
    }

    /// <summary>
    /// The content_version attribute.
    /// </summary>
    public TerraformProperty<string> ContentVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("content_version");
        set => SetProperty("content_version", value);
    }

    /// <summary>
    /// The hash_algorithm attribute.
    /// </summary>
    public TerraformProperty<string> HashAlgorithm
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hash_algorithm");
        set => SetProperty("hash_algorithm", value);
    }

    /// <summary>
    /// The hash_value attribute.
    /// </summary>
    public TerraformProperty<string> HashValue
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hash_value");
        set => SetProperty("hash_value", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAutomationPython3PackageTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
