using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermAdvisorSuppression.
/// Nesting mode: single
/// </summary>
public class AzurermAdvisorSuppressionTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a azurerm_advisor_suppression Terraform resource.
/// Manages a azurerm_advisor_suppression resource.
/// </summary>
public partial class AzurermAdvisorSuppression(string name) : TerraformResource("azurerm_advisor_suppression", name)
{
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
    /// The recommendation_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RecommendationId is required")]
    public required TerraformValue<string> RecommendationId
    {
        get => new TerraformReference<string>(this, "recommendation_id");
        set => SetArgument("recommendation_id", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformValue<string> ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformValue<string>? Ttl
    {
        get => new TerraformReference<string>(this, "ttl");
        set => SetArgument("ttl", value);
    }

    /// <summary>
    /// The suppression_id attribute.
    /// </summary>
    public TerraformValue<string> SuppressionId
    {
        get => new TerraformReference<string>(this, "suppression_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAdvisorSuppressionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAdvisorSuppressionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
