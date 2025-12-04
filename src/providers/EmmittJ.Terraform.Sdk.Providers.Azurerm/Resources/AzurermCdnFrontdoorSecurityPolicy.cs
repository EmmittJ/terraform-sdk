using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for security_policies in AzurermCdnFrontdoorSecurityPolicy.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorSecurityPolicySecurityPoliciesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security_policies";

    /// <summary>
    /// Firewall block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Firewall is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Firewall block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Firewall block(s) allowed")]
    public required TerraformList<AzurermCdnFrontdoorSecurityPolicySecurityPoliciesBlockFirewallBlock> Firewall
    {
        get => GetRequiredArgument<TerraformList<AzurermCdnFrontdoorSecurityPolicySecurityPoliciesBlockFirewallBlock>>("firewall");
        set => SetArgument("firewall", value);
    }

}

/// <summary>
/// Block type for firewall in AzurermCdnFrontdoorSecurityPolicySecurityPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorSecurityPolicySecurityPoliciesBlockFirewallBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "firewall";

    /// <summary>
    /// The cdn_frontdoor_firewall_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorFirewallPolicyId is required")]
    public required TerraformValue<string> CdnFrontdoorFirewallPolicyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("cdn_frontdoor_firewall_policy_id");
        set => SetArgument("cdn_frontdoor_firewall_policy_id", value);
    }

    /// <summary>
    /// Association block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Association is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Association block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Association block(s) allowed")]
    public required TerraformList<AzurermCdnFrontdoorSecurityPolicySecurityPoliciesBlockFirewallBlockAssociationBlock> Association
    {
        get => GetRequiredArgument<TerraformList<AzurermCdnFrontdoorSecurityPolicySecurityPoliciesBlockFirewallBlockAssociationBlock>>("association");
        set => SetArgument("association", value);
    }

}

/// <summary>
/// Block type for association in AzurermCdnFrontdoorSecurityPolicySecurityPoliciesBlockFirewallBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorSecurityPolicySecurityPoliciesBlockFirewallBlockAssociationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "association";

    /// <summary>
    /// The patterns_to_match attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternsToMatch is required")]
    public TerraformList<string>? PatternsToMatch
    {
        get => GetArgument<TerraformList<string>>("patterns_to_match");
        set => SetArgument("patterns_to_match", value);
    }

    /// <summary>
    /// Domain block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Domain block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(500, ErrorMessage = "Maximum 500 Domain block(s) allowed")]
    public required TerraformList<AzurermCdnFrontdoorSecurityPolicySecurityPoliciesBlockFirewallBlockAssociationBlockDomainBlock> Domain
    {
        get => GetRequiredArgument<TerraformList<AzurermCdnFrontdoorSecurityPolicySecurityPoliciesBlockFirewallBlockAssociationBlockDomainBlock>>("domain");
        set => SetArgument("domain", value);
    }

}

/// <summary>
/// Block type for domain in AzurermCdnFrontdoorSecurityPolicySecurityPoliciesBlockFirewallBlockAssociationBlock.
/// Nesting mode: list
/// </summary>
public class AzurermCdnFrontdoorSecurityPolicySecurityPoliciesBlockFirewallBlockAssociationBlockDomainBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "domain";

    /// <summary>
    /// The active attribute.
    /// </summary>
    public TerraformValue<bool> Active
        => AsReference("active");

    /// <summary>
    /// The cdn_frontdoor_domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorDomainId is required")]
    public required TerraformValue<string> CdnFrontdoorDomainId
    {
        get => GetRequiredArgument<TerraformValue<string>>("cdn_frontdoor_domain_id");
        set => SetArgument("cdn_frontdoor_domain_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermCdnFrontdoorSecurityPolicy.
/// Nesting mode: single
/// </summary>
public class AzurermCdnFrontdoorSecurityPolicyTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_cdn_frontdoor_security_policy Terraform resource.
/// Manages a azurerm_cdn_frontdoor_security_policy resource.
/// </summary>
public partial class AzurermCdnFrontdoorSecurityPolicy(string name) : TerraformResource("azurerm_cdn_frontdoor_security_policy", name)
{
    /// <summary>
    /// The cdn_frontdoor_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorProfileId is required")]
    public required TerraformValue<string> CdnFrontdoorProfileId
    {
        get => GetRequiredArgument<TerraformValue<string>>("cdn_frontdoor_profile_id");
        set => SetArgument("cdn_frontdoor_profile_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// SecurityPolicies block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityPolicies is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SecurityPolicies block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityPolicies block(s) allowed")]
    public required TerraformList<AzurermCdnFrontdoorSecurityPolicySecurityPoliciesBlock> SecurityPolicies
    {
        get => GetRequiredArgument<TerraformList<AzurermCdnFrontdoorSecurityPolicySecurityPoliciesBlock>>("security_policies");
        set => SetArgument("security_policies", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCdnFrontdoorSecurityPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCdnFrontdoorSecurityPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
