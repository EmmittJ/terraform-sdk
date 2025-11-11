using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNewRelicMonitorIdentityBlock : TerraformBlockBase
{


    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for plan in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNewRelicMonitorPlanBlock : TerraformBlockBase
{
    /// <summary>
    /// The billing_cycle attribute.
    /// </summary>
    [TerraformProperty("billing_cycle")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BillingCycle { get; set; }

    /// <summary>
    /// The effective_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EffectiveDate is required")]
    [TerraformProperty("effective_date")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EffectiveDate { get; set; }

    /// <summary>
    /// The plan_id attribute.
    /// </summary>
    [TerraformProperty("plan_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PlanId { get; set; }

    /// <summary>
    /// The usage_type attribute.
    /// </summary>
    [TerraformProperty("usage_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UsageType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermNewRelicMonitorTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Block type for user in .
/// Nesting mode: list
/// </summary>
public partial class AzurermNewRelicMonitorUserBlock : TerraformBlockBase
{
    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    [TerraformProperty("email")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Email { get; set; }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirstName is required")]
    [TerraformProperty("first_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FirstName { get; set; }

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LastName is required")]
    [TerraformProperty("last_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LastName { get; set; }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    [TerraformProperty("phone_number")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PhoneNumber { get; set; }

}

/// <summary>
/// Manages a azurerm_new_relic_monitor resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermNewRelicMonitor : TerraformResource
{
    public AzurermNewRelicMonitor(string name) : base("azurerm_new_relic_monitor", name)
    {
    }

    /// <summary>
    /// The account_creation_source attribute.
    /// </summary>
    [TerraformProperty("account_creation_source")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AccountCreationSource { get; set; }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformProperty("account_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AccountId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ingestion_key attribute.
    /// </summary>
    [TerraformProperty("ingestion_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IngestionKey { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The org_creation_source attribute.
    /// </summary>
    [TerraformProperty("org_creation_source")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OrgCreationSource { get; set; }

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    [TerraformProperty("organization_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> OrganizationId { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [TerraformProperty("user_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserId { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public partial TerraformList<TerraformBlock<AzurermNewRelicMonitorIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for plan.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plan is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Plan block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Plan block(s) allowed")]
    [TerraformProperty("plan")]
    public partial TerraformList<TerraformBlock<AzurermNewRelicMonitorPlanBlock>>? Plan { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermNewRelicMonitorTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for user.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 User block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 User block(s) allowed")]
    [TerraformProperty("user")]
    public partial TerraformList<TerraformBlock<AzurermNewRelicMonitorUserBlock>>? User { get; set; }

}
