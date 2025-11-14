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
/// Block type for release_criteria in .
/// Nesting mode: list
/// </summary>
public class AzurermLogicAppIntegrationAccountBatchConfigurationReleaseCriteriaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "release_criteria";

    /// <summary>
    /// The batch_size attribute.
    /// </summary>
    [TerraformArgument("batch_size")]
    public TerraformValue<double>? BatchSize
    {
        get => new TerraformReference<double>(this, "batch_size");
        set => SetArgument("batch_size", value);
    }

    /// <summary>
    /// The message_count attribute.
    /// </summary>
    [TerraformArgument("message_count")]
    public TerraformValue<double>? MessageCount
    {
        get => new TerraformReference<double>(this, "message_count");
        set => SetArgument("message_count", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermLogicAppIntegrationAccountBatchConfigurationTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_logic_app_integration_account_batch_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermLogicAppIntegrationAccountBatchConfiguration : TerraformResource
{
    public AzurermLogicAppIntegrationAccountBatchConfiguration(string name) : base("azurerm_logic_app_integration_account_batch_configuration", name)
    {
    }

    /// <summary>
    /// The batch_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BatchGroupName is required")]
    [TerraformArgument("batch_group_name")]
    public required TerraformValue<string> BatchGroupName
    {
        get => new TerraformReference<string>(this, "batch_group_name");
        set => SetArgument("batch_group_name", value);
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
    /// The integration_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntegrationAccountName is required")]
    [TerraformArgument("integration_account_name")]
    public required TerraformValue<string> IntegrationAccountName
    {
        get => new TerraformReference<string>(this, "integration_account_name");
        set => SetArgument("integration_account_name", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    [TerraformArgument("metadata")]
    public TerraformMap<string>? Metadata
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "metadata").ResolveNodes(ctx));
        set => SetArgument("metadata", value);
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
    /// Block for release_criteria.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReleaseCriteria is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReleaseCriteria block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReleaseCriteria block(s) allowed")]
    [TerraformArgument("release_criteria")]
    public required TerraformList<AzurermLogicAppIntegrationAccountBatchConfigurationReleaseCriteriaBlock> ReleaseCriteria { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermLogicAppIntegrationAccountBatchConfigurationTimeoutsBlock Timeouts { get; set; } = new();

}
