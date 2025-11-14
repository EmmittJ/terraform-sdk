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
public class AzurermSubscriptionPolicyRemediationTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_subscription_policy_remediation resource.
/// </summary>
public class AzurermSubscriptionPolicyRemediation : TerraformResource
{
    public AzurermSubscriptionPolicyRemediation(string name) : base("azurerm_subscription_policy_remediation", name)
    {
    }

    /// <summary>
    /// The failure_percentage attribute.
    /// </summary>
    [TerraformArgument("failure_percentage")]
    public TerraformValue<double>? FailurePercentage
    {
        get => new TerraformReference<double>(this, "failure_percentage");
        set => SetArgument("failure_percentage", value);
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
    /// The location_filters attribute.
    /// </summary>
    [TerraformArgument("location_filters")]
    public TerraformList<string>? LocationFilters
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "location_filters").ResolveNodes(ctx));
        set => SetArgument("location_filters", value);
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
    /// The parallel_deployments attribute.
    /// </summary>
    [TerraformArgument("parallel_deployments")]
    public TerraformValue<double>? ParallelDeployments
    {
        get => new TerraformReference<double>(this, "parallel_deployments");
        set => SetArgument("parallel_deployments", value);
    }

    /// <summary>
    /// The policy_assignment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyAssignmentId is required")]
    [TerraformArgument("policy_assignment_id")]
    public required TerraformValue<string> PolicyAssignmentId
    {
        get => new TerraformReference<string>(this, "policy_assignment_id");
        set => SetArgument("policy_assignment_id", value);
    }

    /// <summary>
    /// The policy_definition_reference_id attribute.
    /// </summary>
    [TerraformArgument("policy_definition_reference_id")]
    public TerraformValue<string>? PolicyDefinitionReferenceId
    {
        get => new TerraformReference<string>(this, "policy_definition_reference_id");
        set => SetArgument("policy_definition_reference_id", value);
    }

    /// <summary>
    /// The resource_count attribute.
    /// </summary>
    [TerraformArgument("resource_count")]
    public TerraformValue<double>? ResourceCount
    {
        get => new TerraformReference<double>(this, "resource_count");
        set => SetArgument("resource_count", value);
    }

    /// <summary>
    /// The resource_discovery_mode attribute.
    /// </summary>
    [TerraformArgument("resource_discovery_mode")]
    public TerraformValue<string>? ResourceDiscoveryMode
    {
        get => new TerraformReference<string>(this, "resource_discovery_mode");
        set => SetArgument("resource_discovery_mode", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriptionId is required")]
    [TerraformArgument("subscription_id")]
    public required TerraformValue<string> SubscriptionId
    {
        get => new TerraformReference<string>(this, "subscription_id");
        set => SetArgument("subscription_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSubscriptionPolicyRemediationTimeoutsBlock Timeouts { get; set; } = new();

}
