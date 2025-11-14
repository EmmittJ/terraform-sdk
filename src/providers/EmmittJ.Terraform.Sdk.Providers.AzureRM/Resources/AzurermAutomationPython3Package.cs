using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAutomationPython3PackageTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_automation_python3_package resource.
/// </summary>
public class AzurermAutomationPython3Package : TerraformResource
{
    public AzurermAutomationPython3Package(string name) : base("azurerm_automation_python3_package", name)
    {
    }

    /// <summary>
    /// The automation_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutomationAccountName is required")]
    [TerraformArgument("automation_account_name")]
    public required TerraformValue<string> AutomationAccountName
    {
        get => new TerraformReference<string>(this, "automation_account_name");
        set => SetArgument("automation_account_name", value);
    }

    /// <summary>
    /// The content_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentUri is required")]
    [TerraformArgument("content_uri")]
    public required TerraformValue<string> ContentUri
    {
        get => new TerraformReference<string>(this, "content_uri");
        set => SetArgument("content_uri", value);
    }

    /// <summary>
    /// The content_version attribute.
    /// </summary>
    [TerraformArgument("content_version")]
    public TerraformValue<string>? ContentVersion
    {
        get => new TerraformReference<string>(this, "content_version");
        set => SetArgument("content_version", value);
    }

    /// <summary>
    /// The hash_algorithm attribute.
    /// </summary>
    [TerraformArgument("hash_algorithm")]
    public TerraformValue<string>? HashAlgorithm
    {
        get => new TerraformReference<string>(this, "hash_algorithm");
        set => SetArgument("hash_algorithm", value);
    }

    /// <summary>
    /// The hash_value attribute.
    /// </summary>
    [TerraformArgument("hash_value")]
    public TerraformValue<string>? HashValue
    {
        get => new TerraformReference<string>(this, "hash_value");
        set => SetArgument("hash_value", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermAutomationPython3PackageTimeoutsBlock Timeouts { get; set; } = new();

}
