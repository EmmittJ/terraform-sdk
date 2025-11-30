using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for model in AzurermCognitiveDeployment.
/// Nesting mode: list
/// </summary>
public class AzurermCognitiveDeploymentModelBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "model";

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformValue<string> Format
    {
        get => new TerraformReference<string>(this, "format");
        set => SetArgument("format", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

}


/// <summary>
/// Block type for sku in AzurermCognitiveDeployment.
/// Nesting mode: list
/// </summary>
public class AzurermCognitiveDeploymentSkuBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sku";

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    public TerraformValue<double>? Capacity
    {
        get => new TerraformReference<double>(this, "capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// The family attribute.
    /// </summary>
    public TerraformValue<string>? Family
    {
        get => new TerraformReference<string>(this, "family");
        set => SetArgument("family", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformValue<string>? Size
    {
        get => new TerraformReference<string>(this, "size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformValue<string>? Tier
    {
        get => new TerraformReference<string>(this, "tier");
        set => SetArgument("tier", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermCognitiveDeployment.
/// Nesting mode: single
/// </summary>
public class AzurermCognitiveDeploymentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_cognitive_deployment Terraform resource.
/// Manages a azurerm_cognitive_deployment resource.
/// </summary>
public partial class AzurermCognitiveDeployment(string name) : TerraformResource("azurerm_cognitive_deployment", name)
{
    /// <summary>
    /// The cognitive_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CognitiveAccountId is required")]
    public required TerraformValue<string> CognitiveAccountId
    {
        get => new TerraformReference<string>(this, "cognitive_account_id");
        set => SetArgument("cognitive_account_id", value);
    }

    /// <summary>
    /// The dynamic_throttling_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DynamicThrottlingEnabled
    {
        get => new TerraformReference<bool>(this, "dynamic_throttling_enabled");
        set => SetArgument("dynamic_throttling_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The rai_policy_name attribute.
    /// </summary>
    public TerraformValue<string>? RaiPolicyName
    {
        get => new TerraformReference<string>(this, "rai_policy_name");
        set => SetArgument("rai_policy_name", value);
    }

    /// <summary>
    /// The version_upgrade_option attribute.
    /// </summary>
    public TerraformValue<string>? VersionUpgradeOption
    {
        get => new TerraformReference<string>(this, "version_upgrade_option");
        set => SetArgument("version_upgrade_option", value);
    }

    /// <summary>
    /// Model block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Model is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Model block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Model block(s) allowed")]
    public required TerraformList<AzurermCognitiveDeploymentModelBlock> Model
    {
        get => GetRequiredArgument<TerraformList<AzurermCognitiveDeploymentModelBlock>>("model");
        set => SetArgument("model", value);
    }

    /// <summary>
    /// Sku block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public required TerraformList<AzurermCognitiveDeploymentSkuBlock> Sku
    {
        get => GetRequiredArgument<TerraformList<AzurermCognitiveDeploymentSkuBlock>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCognitiveDeploymentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCognitiveDeploymentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
