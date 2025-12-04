using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for custom_provider in GoogleNetworkSecurityAuthzPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyCustomProviderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_provider";

    /// <summary>
    /// AuthzExtension block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthzExtension block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityAuthzPolicyCustomProviderBlockAuthzExtensionBlock>? AuthzExtension
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyCustomProviderBlockAuthzExtensionBlock>>("authz_extension");
        set => SetArgument("authz_extension", value);
    }

    /// <summary>
    /// CloudIap block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudIap block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityAuthzPolicyCustomProviderBlockCloudIapBlock>? CloudIap
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyCustomProviderBlockCloudIapBlock>>("cloud_iap");
        set => SetArgument("cloud_iap", value);
    }

}

/// <summary>
/// Block type for authz_extension in GoogleNetworkSecurityAuthzPolicyCustomProviderBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyCustomProviderBlockAuthzExtensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authz_extension";

    /// <summary>
    /// A list of references to authorization extensions that will be invoked for requests matching this policy. Limited to 1 custom provider.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resources is required")]
    public TerraformList<string>? Resources
    {
        get => GetArgument<TerraformList<string>>("resources");
        set => SetArgument("resources", value);
    }

}

/// <summary>
/// Block type for cloud_iap in GoogleNetworkSecurityAuthzPolicyCustomProviderBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyCustomProviderBlockCloudIapBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_iap";

    /// <summary>
    /// Enable Cloud IAP at the AuthzPolicy level.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for http_rules in GoogleNetworkSecurityAuthzPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "http_rules";

    /// <summary>
    /// CEL expression that describes the conditions to be satisfied for the action. The result of the CEL expression is ANDed with the from and to. Refer to the CEL language reference for a list of available attributes.
    /// </summary>
    public TerraformValue<string>? WhenAttribute
    {
        get => GetArgument<TerraformValue<string>>("when");
        set => SetArgument("when", value);
    }

    /// <summary>
    /// From block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 From block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlock>? From
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlock>>("from");
        set => SetArgument("from", value);
    }

    /// <summary>
    /// To block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 To block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlock>? To
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlock>>("to");
        set => SetArgument("to", value);
    }

}

/// <summary>
/// Block type for from in GoogleNetworkSecurityAuthzPolicyHttpRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "from";

    /// <summary>
    /// NotSources block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlock>? NotSources
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlock>>("not_sources");
        set => SetArgument("not_sources", value);
    }

    /// <summary>
    /// Sources block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlock>? Sources
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlock>>("sources");
        set => SetArgument("sources", value);
    }

}

/// <summary>
/// Block type for not_sources in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "not_sources";

    /// <summary>
    /// IpBlocks block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlockIpBlocksBlock>? IpBlocks
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlockIpBlocksBlock>>("ip_blocks");
        set => SetArgument("ip_blocks", value);
    }

    /// <summary>
    /// Principals block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlockPrincipalsBlock>? Principals
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlockPrincipalsBlock>>("principals");
        set => SetArgument("principals", value);
    }

    /// <summary>
    /// Resources block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlockResourcesBlock>? Resources
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlockResourcesBlock>>("resources");
        set => SetArgument("resources", value);
    }

}

/// <summary>
/// Block type for ip_blocks in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlockIpBlocksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_blocks";

    /// <summary>
    /// The length of the address range.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Length is required")]
    public required TerraformValue<double> Length
    {
        get => GetRequiredArgument<TerraformValue<double>>("length");
        set => SetArgument("length", value);
    }

    /// <summary>
    /// The address prefix.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    public required TerraformValue<string> Prefix
    {
        get => GetRequiredArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

}

/// <summary>
/// Block type for principals in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlockPrincipalsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "principals";

    /// <summary>
    /// The input string must have the substring specified here. Note: empty contains match is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value xyz.abc.def
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? ContainsAttribute
    {
        get => GetArgument<TerraformValue<string>>("contains");
        set => SetArgument("contains", value);
    }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// Examples:
    /// * abc only matches the value abc.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? Exact
    {
        get => GetArgument<TerraformValue<string>>("exact");
        set => SetArgument("exact", value);
    }

    /// <summary>
    /// If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher data will match both input string Data and data if set to true.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool>? IgnoreCase
    {
        get => GetArgument<TerraformValue<bool>>("ignore_case");
        set => SetArgument("ignore_case", value);
    }

    /// <summary>
    /// The input string must have the prefix specified here. Note: empty prefix is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value abc.xyz
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// An enum to decide what principal value the principal rule will match against. If not specified, the PrincipalSelector is CLIENT_CERT_URI_SAN. Default value: &amp;quot;CLIENT_CERT_URI_SAN&amp;quot; Possible values: [&amp;quot;PRINCIPAL_SELECTOR_UNSPECIFIED&amp;quot;, &amp;quot;CLIENT_CERT_URI_SAN&amp;quot;, &amp;quot;CLIENT_CERT_DNS_NAME_SAN&amp;quot;, &amp;quot;CLIENT_CERT_COMMON_NAME&amp;quot;]
    /// </summary>
    public TerraformValue<string>? PrincipalSelector
    {
        get => GetArgument<TerraformValue<string>>("principal_selector");
        set => SetArgument("principal_selector", value);
    }

    /// <summary>
    /// The input string must have the suffix specified here. Note: empty prefix is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value xyz.abc
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? Suffix
    {
        get => GetArgument<TerraformValue<string>>("suffix");
        set => SetArgument("suffix", value);
    }

    /// <summary>
    /// Principal block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Principal block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlockPrincipalsBlockPrincipalBlock>? Principal
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlockPrincipalsBlockPrincipalBlock>>("principal");
        set => SetArgument("principal", value);
    }

}

/// <summary>
/// Block type for principal in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlockPrincipalsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlockPrincipalsBlockPrincipalBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "principal";

    /// <summary>
    /// The input string must have the substring specified here. Note: empty contains match is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value xyz.abc.def
    /// </summary>
    public TerraformValue<string>? ContainsAttribute
    {
        get => GetArgument<TerraformValue<string>>("contains");
        set => SetArgument("contains", value);
    }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// Examples:
    /// * abc only matches the value abc.
    /// </summary>
    public TerraformValue<string>? Exact
    {
        get => GetArgument<TerraformValue<string>>("exact");
        set => SetArgument("exact", value);
    }

    /// <summary>
    /// If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher data will match both input string Data and data if set to true.
    /// </summary>
    public TerraformValue<bool>? IgnoreCase
    {
        get => GetArgument<TerraformValue<bool>>("ignore_case");
        set => SetArgument("ignore_case", value);
    }

    /// <summary>
    /// The input string must have the prefix specified here. Note: empty prefix is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value abc.xyz
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The input string must have the suffix specified here. Note: empty prefix is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value xyz.abc
    /// </summary>
    public TerraformValue<string>? Suffix
    {
        get => GetArgument<TerraformValue<string>>("suffix");
        set => SetArgument("suffix", value);
    }

}

/// <summary>
/// Block type for resources in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlockResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resources";

    /// <summary>
    /// IamServiceAccount block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IamServiceAccount block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlockResourcesBlockIamServiceAccountBlock>? IamServiceAccount
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlockResourcesBlockIamServiceAccountBlock>>("iam_service_account");
        set => SetArgument("iam_service_account", value);
    }

    /// <summary>
    /// TagValueIdSet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TagValueIdSet block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlockResourcesBlockTagValueIdSetBlock>? TagValueIdSet
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlockResourcesBlockTagValueIdSetBlock>>("tag_value_id_set");
        set => SetArgument("tag_value_id_set", value);
    }

}

/// <summary>
/// Block type for iam_service_account in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlockResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlockResourcesBlockIamServiceAccountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "iam_service_account";

    /// <summary>
    /// The input string must have the substring specified here. Note: empty contains match is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value xyz.abc.def
    /// </summary>
    public TerraformValue<string>? ContainsAttribute
    {
        get => GetArgument<TerraformValue<string>>("contains");
        set => SetArgument("contains", value);
    }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// Examples:
    /// * abc only matches the value abc.
    /// </summary>
    public TerraformValue<string>? Exact
    {
        get => GetArgument<TerraformValue<string>>("exact");
        set => SetArgument("exact", value);
    }

    /// <summary>
    /// If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher data will match both input string Data and data if set to true.
    /// </summary>
    public TerraformValue<bool>? IgnoreCase
    {
        get => GetArgument<TerraformValue<bool>>("ignore_case");
        set => SetArgument("ignore_case", value);
    }

    /// <summary>
    /// The input string must have the prefix specified here. Note: empty prefix is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value abc.xyz
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The input string must have the suffix specified here. Note: empty prefix is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value xyz.abc
    /// </summary>
    public TerraformValue<string>? Suffix
    {
        get => GetArgument<TerraformValue<string>>("suffix");
        set => SetArgument("suffix", value);
    }

}

/// <summary>
/// Block type for tag_value_id_set in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlockResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockNotSourcesBlockResourcesBlockTagValueIdSetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag_value_id_set";

    /// <summary>
    /// A list of resource tag value permanent IDs to match against the resource manager tags value associated with the source VM of a request. The match follows AND semantics which means all the ids must match.
    /// Limited to 5 matches.
    /// </summary>
    public TerraformList<string>? Ids
    {
        get => GetArgument<TerraformList<string>>("ids");
        set => SetArgument("ids", value);
    }

}

/// <summary>
/// Block type for sources in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sources";

    /// <summary>
    /// IpBlocks block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlockIpBlocksBlock>? IpBlocks
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlockIpBlocksBlock>>("ip_blocks");
        set => SetArgument("ip_blocks", value);
    }

    /// <summary>
    /// Principals block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlockPrincipalsBlock>? Principals
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlockPrincipalsBlock>>("principals");
        set => SetArgument("principals", value);
    }

    /// <summary>
    /// Resources block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlockResourcesBlock>? Resources
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlockResourcesBlock>>("resources");
        set => SetArgument("resources", value);
    }

}

/// <summary>
/// Block type for ip_blocks in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlockIpBlocksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_blocks";

    /// <summary>
    /// The length of the address range.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Length is required")]
    public required TerraformValue<double> Length
    {
        get => GetRequiredArgument<TerraformValue<double>>("length");
        set => SetArgument("length", value);
    }

    /// <summary>
    /// The address prefix.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    public required TerraformValue<string> Prefix
    {
        get => GetRequiredArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

}

/// <summary>
/// Block type for principals in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlockPrincipalsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "principals";

    /// <summary>
    /// The input string must have the substring specified here. Note: empty contains match is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value xyz.abc.def
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? ContainsAttribute
    {
        get => GetArgument<TerraformValue<string>>("contains");
        set => SetArgument("contains", value);
    }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// Examples:
    /// * abc only matches the value abc.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? Exact
    {
        get => GetArgument<TerraformValue<string>>("exact");
        set => SetArgument("exact", value);
    }

    /// <summary>
    /// If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher data will match both input string Data and data if set to true.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool>? IgnoreCase
    {
        get => GetArgument<TerraformValue<bool>>("ignore_case");
        set => SetArgument("ignore_case", value);
    }

    /// <summary>
    /// The input string must have the prefix specified here. Note: empty prefix is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value abc.xyz
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// An enum to decide what principal value the principal rule will match against. If not specified, the PrincipalSelector is CLIENT_CERT_URI_SAN. Default value: &amp;quot;CLIENT_CERT_URI_SAN&amp;quot; Possible values: [&amp;quot;PRINCIPAL_SELECTOR_UNSPECIFIED&amp;quot;, &amp;quot;CLIENT_CERT_URI_SAN&amp;quot;, &amp;quot;CLIENT_CERT_DNS_NAME_SAN&amp;quot;, &amp;quot;CLIENT_CERT_COMMON_NAME&amp;quot;]
    /// </summary>
    public TerraformValue<string>? PrincipalSelector
    {
        get => GetArgument<TerraformValue<string>>("principal_selector");
        set => SetArgument("principal_selector", value);
    }

    /// <summary>
    /// The input string must have the suffix specified here. Note: empty prefix is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value xyz.abc
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? Suffix
    {
        get => GetArgument<TerraformValue<string>>("suffix");
        set => SetArgument("suffix", value);
    }

    /// <summary>
    /// Principal block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Principal block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlockPrincipalsBlockPrincipalBlock>? Principal
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlockPrincipalsBlockPrincipalBlock>>("principal");
        set => SetArgument("principal", value);
    }

}

/// <summary>
/// Block type for principal in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlockPrincipalsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlockPrincipalsBlockPrincipalBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "principal";

    /// <summary>
    /// The input string must have the substring specified here. Note: empty contains match is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value xyz.abc.def
    /// </summary>
    public TerraformValue<string>? ContainsAttribute
    {
        get => GetArgument<TerraformValue<string>>("contains");
        set => SetArgument("contains", value);
    }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// Examples:
    /// * abc only matches the value abc.
    /// </summary>
    public TerraformValue<string>? Exact
    {
        get => GetArgument<TerraformValue<string>>("exact");
        set => SetArgument("exact", value);
    }

    /// <summary>
    /// If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher data will match both input string Data and data if set to true.
    /// </summary>
    public TerraformValue<bool>? IgnoreCase
    {
        get => GetArgument<TerraformValue<bool>>("ignore_case");
        set => SetArgument("ignore_case", value);
    }

    /// <summary>
    /// The input string must have the prefix specified here. Note: empty prefix is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value abc.xyz
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The input string must have the suffix specified here. Note: empty prefix is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value xyz.abc
    /// </summary>
    public TerraformValue<string>? Suffix
    {
        get => GetArgument<TerraformValue<string>>("suffix");
        set => SetArgument("suffix", value);
    }

}

/// <summary>
/// Block type for resources in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlockResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resources";

    /// <summary>
    /// IamServiceAccount block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IamServiceAccount block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlockResourcesBlockIamServiceAccountBlock>? IamServiceAccount
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlockResourcesBlockIamServiceAccountBlock>>("iam_service_account");
        set => SetArgument("iam_service_account", value);
    }

    /// <summary>
    /// TagValueIdSet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TagValueIdSet block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlockResourcesBlockTagValueIdSetBlock>? TagValueIdSet
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlockResourcesBlockTagValueIdSetBlock>>("tag_value_id_set");
        set => SetArgument("tag_value_id_set", value);
    }

}

/// <summary>
/// Block type for iam_service_account in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlockResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlockResourcesBlockIamServiceAccountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "iam_service_account";

    /// <summary>
    /// The input string must have the substring specified here. Note: empty contains match is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value xyz.abc.def
    /// </summary>
    public TerraformValue<string>? ContainsAttribute
    {
        get => GetArgument<TerraformValue<string>>("contains");
        set => SetArgument("contains", value);
    }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// Examples:
    /// * abc only matches the value abc.
    /// </summary>
    public TerraformValue<string>? Exact
    {
        get => GetArgument<TerraformValue<string>>("exact");
        set => SetArgument("exact", value);
    }

    /// <summary>
    /// If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher data will match both input string Data and data if set to true.
    /// </summary>
    public TerraformValue<bool>? IgnoreCase
    {
        get => GetArgument<TerraformValue<bool>>("ignore_case");
        set => SetArgument("ignore_case", value);
    }

    /// <summary>
    /// The input string must have the prefix specified here. Note: empty prefix is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value abc.xyz
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The input string must have the suffix specified here. Note: empty prefix is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value xyz.abc
    /// </summary>
    public TerraformValue<string>? Suffix
    {
        get => GetArgument<TerraformValue<string>>("suffix");
        set => SetArgument("suffix", value);
    }

}

/// <summary>
/// Block type for tag_value_id_set in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlockResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockFromBlockSourcesBlockResourcesBlockTagValueIdSetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag_value_id_set";

    /// <summary>
    /// A list of resource tag value permanent IDs to match against the resource manager tags value associated with the source VM of a request. The match follows AND semantics which means all the ids must match.
    /// Limited to 5 matches.
    /// </summary>
    public TerraformList<string>? Ids
    {
        get => GetArgument<TerraformList<string>>("ids");
        set => SetArgument("ids", value);
    }

}

/// <summary>
/// Block type for to in GoogleNetworkSecurityAuthzPolicyHttpRulesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "to";

    /// <summary>
    /// NotOperations block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockNotOperationsBlock>? NotOperations
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockNotOperationsBlock>>("not_operations");
        set => SetArgument("not_operations", value);
    }

    /// <summary>
    /// Operations block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockOperationsBlock>? Operations
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockOperationsBlock>>("operations");
        set => SetArgument("operations", value);
    }

}

/// <summary>
/// Block type for not_operations in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockNotOperationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "not_operations";

    /// <summary>
    /// A list of HTTP methods to match against. Each entry must be a valid HTTP method name (GET, PUT, POST, HEAD, PATCH, DELETE, OPTIONS). It only allows exact match and is always case sensitive.
    /// </summary>
    public TerraformList<string>? Methods
    {
        get => GetArgument<TerraformList<string>>("methods");
        set => SetArgument("methods", value);
    }

    /// <summary>
    /// HeaderSet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeaderSet block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockNotOperationsBlockHeaderSetBlock>? HeaderSet
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockNotOperationsBlockHeaderSetBlock>>("header_set");
        set => SetArgument("header_set", value);
    }

    /// <summary>
    /// Hosts block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockNotOperationsBlockHostsBlock>? Hosts
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockNotOperationsBlockHostsBlock>>("hosts");
        set => SetArgument("hosts", value);
    }

    /// <summary>
    /// Paths block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockNotOperationsBlockPathsBlock>? Paths
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockNotOperationsBlockPathsBlock>>("paths");
        set => SetArgument("paths", value);
    }

}

/// <summary>
/// Block type for header_set in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockNotOperationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockNotOperationsBlockHeaderSetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header_set";

    /// <summary>
    /// Headers block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockNotOperationsBlockHeaderSetBlockHeadersBlock>? Headers
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockNotOperationsBlockHeaderSetBlockHeadersBlock>>("headers");
        set => SetArgument("headers", value);
    }

}

/// <summary>
/// Block type for headers in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockNotOperationsBlockHeaderSetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockNotOperationsBlockHeaderSetBlockHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "headers";

    /// <summary>
    /// Specifies the name of the header in the request.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Value block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Value block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockNotOperationsBlockHeaderSetBlockHeadersBlockValueBlock>? Value
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockNotOperationsBlockHeaderSetBlockHeadersBlockValueBlock>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for value in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockNotOperationsBlockHeaderSetBlockHeadersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockNotOperationsBlockHeaderSetBlockHeadersBlockValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "value";

    /// <summary>
    /// The input string must have the substring specified here. Note: empty contains match is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value xyz.abc.def
    /// </summary>
    public TerraformValue<string>? ContainsAttribute
    {
        get => GetArgument<TerraformValue<string>>("contains");
        set => SetArgument("contains", value);
    }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// Examples:
    /// * abc only matches the value abc.
    /// </summary>
    public TerraformValue<string>? Exact
    {
        get => GetArgument<TerraformValue<string>>("exact");
        set => SetArgument("exact", value);
    }

    /// <summary>
    /// If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher data will match both input string Data and data if set to true.
    /// </summary>
    public TerraformValue<bool>? IgnoreCase
    {
        get => GetArgument<TerraformValue<bool>>("ignore_case");
        set => SetArgument("ignore_case", value);
    }

    /// <summary>
    /// The input string must have the prefix specified here. Note: empty prefix is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value abc.xyz
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The input string must have the suffix specified here. Note: empty prefix is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value xyz.abc
    /// </summary>
    public TerraformValue<string>? Suffix
    {
        get => GetArgument<TerraformValue<string>>("suffix");
        set => SetArgument("suffix", value);
    }

}

/// <summary>
/// Block type for hosts in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockNotOperationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockNotOperationsBlockHostsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hosts";

    /// <summary>
    /// The input string must have the substring specified here. Note: empty contains match is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value xyz.abc.def
    /// </summary>
    public TerraformValue<string>? ContainsAttribute
    {
        get => GetArgument<TerraformValue<string>>("contains");
        set => SetArgument("contains", value);
    }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// Examples:
    /// * abc only matches the value abc.
    /// </summary>
    public TerraformValue<string>? Exact
    {
        get => GetArgument<TerraformValue<string>>("exact");
        set => SetArgument("exact", value);
    }

    /// <summary>
    /// If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher data will match both input string Data and data if set to true.
    /// </summary>
    public TerraformValue<bool>? IgnoreCase
    {
        get => GetArgument<TerraformValue<bool>>("ignore_case");
        set => SetArgument("ignore_case", value);
    }

    /// <summary>
    /// The input string must have the prefix specified here. Note: empty prefix is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value abc.xyz
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The input string must have the suffix specified here. Note: empty prefix is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value xyz.abc
    /// </summary>
    public TerraformValue<string>? Suffix
    {
        get => GetArgument<TerraformValue<string>>("suffix");
        set => SetArgument("suffix", value);
    }

}

/// <summary>
/// Block type for paths in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockNotOperationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockNotOperationsBlockPathsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "paths";

    /// <summary>
    /// The input string must have the substring specified here. Note: empty contains match is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value xyz.abc.def
    /// </summary>
    public TerraformValue<string>? ContainsAttribute
    {
        get => GetArgument<TerraformValue<string>>("contains");
        set => SetArgument("contains", value);
    }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// Examples:
    /// * abc only matches the value abc.
    /// </summary>
    public TerraformValue<string>? Exact
    {
        get => GetArgument<TerraformValue<string>>("exact");
        set => SetArgument("exact", value);
    }

    /// <summary>
    /// If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher data will match both input string Data and data if set to true.
    /// </summary>
    public TerraformValue<bool>? IgnoreCase
    {
        get => GetArgument<TerraformValue<bool>>("ignore_case");
        set => SetArgument("ignore_case", value);
    }

    /// <summary>
    /// The input string must have the prefix specified here. Note: empty prefix is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value abc.xyz
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The input string must have the suffix specified here. Note: empty prefix is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value xyz.abc
    /// </summary>
    public TerraformValue<string>? Suffix
    {
        get => GetArgument<TerraformValue<string>>("suffix");
        set => SetArgument("suffix", value);
    }

}

/// <summary>
/// Block type for operations in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockOperationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "operations";

    /// <summary>
    /// A list of HTTP methods to match against. Each entry must be a valid HTTP method name (GET, PUT, POST, HEAD, PATCH, DELETE, OPTIONS). It only allows exact match and is always case sensitive.
    /// </summary>
    public TerraformList<string>? Methods
    {
        get => GetArgument<TerraformList<string>>("methods");
        set => SetArgument("methods", value);
    }

    /// <summary>
    /// HeaderSet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HeaderSet block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockOperationsBlockHeaderSetBlock>? HeaderSet
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockOperationsBlockHeaderSetBlock>>("header_set");
        set => SetArgument("header_set", value);
    }

    /// <summary>
    /// Hosts block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockOperationsBlockHostsBlock>? Hosts
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockOperationsBlockHostsBlock>>("hosts");
        set => SetArgument("hosts", value);
    }

    /// <summary>
    /// Paths block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockOperationsBlockPathsBlock>? Paths
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockOperationsBlockPathsBlock>>("paths");
        set => SetArgument("paths", value);
    }

}

/// <summary>
/// Block type for header_set in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockOperationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockOperationsBlockHeaderSetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header_set";

    /// <summary>
    /// Headers block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockOperationsBlockHeaderSetBlockHeadersBlock>? Headers
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockOperationsBlockHeaderSetBlockHeadersBlock>>("headers");
        set => SetArgument("headers", value);
    }

}

/// <summary>
/// Block type for headers in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockOperationsBlockHeaderSetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockOperationsBlockHeaderSetBlockHeadersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "headers";

    /// <summary>
    /// Specifies the name of the header in the request.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Value block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Value block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockOperationsBlockHeaderSetBlockHeadersBlockValueBlock>? Value
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockOperationsBlockHeaderSetBlockHeadersBlockValueBlock>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for value in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockOperationsBlockHeaderSetBlockHeadersBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockOperationsBlockHeaderSetBlockHeadersBlockValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "value";

    /// <summary>
    /// The input string must have the substring specified here. Note: empty contains match is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value xyz.abc.def
    /// </summary>
    public TerraformValue<string>? ContainsAttribute
    {
        get => GetArgument<TerraformValue<string>>("contains");
        set => SetArgument("contains", value);
    }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// Examples:
    /// * abc only matches the value abc.
    /// </summary>
    public TerraformValue<string>? Exact
    {
        get => GetArgument<TerraformValue<string>>("exact");
        set => SetArgument("exact", value);
    }

    /// <summary>
    /// If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher data will match both input string Data and data if set to true.
    /// </summary>
    public TerraformValue<bool>? IgnoreCase
    {
        get => GetArgument<TerraformValue<bool>>("ignore_case");
        set => SetArgument("ignore_case", value);
    }

    /// <summary>
    /// The input string must have the prefix specified here. Note: empty prefix is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value abc.xyz
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The input string must have the suffix specified here. Note: empty prefix is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value xyz.abc
    /// </summary>
    public TerraformValue<string>? Suffix
    {
        get => GetArgument<TerraformValue<string>>("suffix");
        set => SetArgument("suffix", value);
    }

}

/// <summary>
/// Block type for hosts in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockOperationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockOperationsBlockHostsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hosts";

    /// <summary>
    /// The input string must have the substring specified here. Note: empty contains match is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value xyz.abc.def
    /// </summary>
    public TerraformValue<string>? ContainsAttribute
    {
        get => GetArgument<TerraformValue<string>>("contains");
        set => SetArgument("contains", value);
    }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// Examples:
    /// * abc only matches the value abc.
    /// </summary>
    public TerraformValue<string>? Exact
    {
        get => GetArgument<TerraformValue<string>>("exact");
        set => SetArgument("exact", value);
    }

    /// <summary>
    /// If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher data will match both input string Data and data if set to true.
    /// </summary>
    public TerraformValue<bool>? IgnoreCase
    {
        get => GetArgument<TerraformValue<bool>>("ignore_case");
        set => SetArgument("ignore_case", value);
    }

    /// <summary>
    /// The input string must have the prefix specified here. Note: empty prefix is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value abc.xyz
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The input string must have the suffix specified here. Note: empty prefix is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value xyz.abc
    /// </summary>
    public TerraformValue<string>? Suffix
    {
        get => GetArgument<TerraformValue<string>>("suffix");
        set => SetArgument("suffix", value);
    }

}

/// <summary>
/// Block type for paths in GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockOperationsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyHttpRulesBlockToBlockOperationsBlockPathsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "paths";

    /// <summary>
    /// The input string must have the substring specified here. Note: empty contains match is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value xyz.abc.def
    /// </summary>
    public TerraformValue<string>? ContainsAttribute
    {
        get => GetArgument<TerraformValue<string>>("contains");
        set => SetArgument("contains", value);
    }

    /// <summary>
    /// The input string must match exactly the string specified here.
    /// Examples:
    /// * abc only matches the value abc.
    /// </summary>
    public TerraformValue<string>? Exact
    {
        get => GetArgument<TerraformValue<string>>("exact");
        set => SetArgument("exact", value);
    }

    /// <summary>
    /// If true, indicates the exact/prefix/suffix/contains matching should be case insensitive. For example, the matcher data will match both input string Data and data if set to true.
    /// </summary>
    public TerraformValue<bool>? IgnoreCase
    {
        get => GetArgument<TerraformValue<bool>>("ignore_case");
        set => SetArgument("ignore_case", value);
    }

    /// <summary>
    /// The input string must have the prefix specified here. Note: empty prefix is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value abc.xyz
    /// </summary>
    public TerraformValue<string>? Prefix
    {
        get => GetArgument<TerraformValue<string>>("prefix");
        set => SetArgument("prefix", value);
    }

    /// <summary>
    /// The input string must have the suffix specified here. Note: empty prefix is not allowed, please use regex instead.
    /// Examples:
    /// * abc matches the value xyz.abc
    /// </summary>
    public TerraformValue<string>? Suffix
    {
        get => GetArgument<TerraformValue<string>>("suffix");
        set => SetArgument("suffix", value);
    }

}


/// <summary>
/// Block type for target in GoogleNetworkSecurityAuthzPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target";

    /// <summary>
    /// All gateways and forwarding rules referenced by this policy and extensions must share the same load balancing scheme.
    /// For more information, refer to [Backend services overview](https://cloud.google.com/load-balancing/docs/backend-service). Possible values: [&amp;quot;INTERNAL_MANAGED&amp;quot;, &amp;quot;EXTERNAL_MANAGED&amp;quot;, &amp;quot;INTERNAL_SELF_MANAGED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancingScheme is required")]
    public required TerraformValue<string> LoadBalancingScheme
    {
        get => GetRequiredArgument<TerraformValue<string>>("load_balancing_scheme");
        set => SetArgument("load_balancing_scheme", value);
    }

    /// <summary>
    /// A list of references to the Forwarding Rules on which this policy will be applied.
    /// </summary>
    public TerraformList<string>? Resources
    {
        get => GetArgument<TerraformList<string>>("resources");
        set => SetArgument("resources", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleNetworkSecurityAuthzPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecurityAuthzPolicyTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_network_security_authz_policy Terraform resource.
/// Manages a google_network_security_authz_policy resource.
/// </summary>
public partial class GoogleNetworkSecurityAuthzPolicy(string name) : TerraformResource("google_network_security_authz_policy", name)
{
    /// <summary>
    /// When the action is CUSTOM, customProvider must be specified.
    /// When the action is ALLOW, only requests matching the policy will be allowed.
    /// When the action is DENY, only requests matching the policy will be denied.
    /// 
    /// When a request arrives, the policies are evaluated in the following order:
    /// 1. If there is a CUSTOM policy that matches the request, the CUSTOM policy is evaluated using the custom authorization providers and the request is denied if the provider rejects the request.
    /// 2. If there are any DENY policies that match the request, the request is denied.
    /// 3. If there are no ALLOW policies for the resource or if any of the ALLOW policies match the request, the request is allowed.
    /// 4. Else the request is denied by default if none of the configured AuthzPolicies with ALLOW action match the request. Possible values: [&amp;quot;ALLOW&amp;quot;, &amp;quot;DENY&amp;quot;, &amp;quot;CUSTOM&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => GetRequiredArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// A human-readable description of the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// Set of labels associated with the AuthzExtension resource.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location of the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Identifier. Name of the AuthzPolicy resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The timestamp when the resource was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// The timestamp when the resource was updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// CustomProvider block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomProvider block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityAuthzPolicyCustomProviderBlock>? CustomProvider
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyCustomProviderBlock>>("custom_provider");
        set => SetArgument("custom_provider", value);
    }

    /// <summary>
    /// HttpRules block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlock>? HttpRules
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyHttpRulesBlock>>("http_rules");
        set => SetArgument("http_rules", value);
    }

    /// <summary>
    /// Target block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Target block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    public required TerraformList<GoogleNetworkSecurityAuthzPolicyTargetBlock> Target
    {
        get => GetRequiredArgument<TerraformList<GoogleNetworkSecurityAuthzPolicyTargetBlock>>("target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkSecurityAuthzPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkSecurityAuthzPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
