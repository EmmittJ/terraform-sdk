using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for inline_redaction_configuration in AwsWorkspaceswebDataProtectionSettings.
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inline_redaction_configuration";

    /// <summary>
    /// The global_confidence_level attribute.
    /// </summary>
    public TerraformValue<double>? GlobalConfidenceLevel
    {
        get => GetArgument<TerraformValue<double>>("global_confidence_level");
        set => SetArgument("global_confidence_level", value);
    }

    /// <summary>
    /// The global_enforced_urls attribute.
    /// </summary>
    public TerraformList<string>? GlobalEnforcedUrls
    {
        get => GetArgument<TerraformList<string>>("global_enforced_urls");
        set => SetArgument("global_enforced_urls", value);
    }

    /// <summary>
    /// The global_exempt_urls attribute.
    /// </summary>
    public TerraformList<string>? GlobalExemptUrls
    {
        get => GetArgument<TerraformList<string>>("global_exempt_urls");
        set => SetArgument("global_exempt_urls", value);
    }

    /// <summary>
    /// InlineRedactionPattern block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlockInlineRedactionPatternBlock>? InlineRedactionPattern
    {
        get => GetArgument<TerraformList<AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlockInlineRedactionPatternBlock>>("inline_redaction_pattern");
        set => SetArgument("inline_redaction_pattern", value);
    }

}

/// <summary>
/// Block type for inline_redaction_pattern in AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlockInlineRedactionPatternBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inline_redaction_pattern";

    /// <summary>
    /// The built_in_pattern_id attribute.
    /// </summary>
    public TerraformValue<string>? BuiltInPatternId
    {
        get => GetArgument<TerraformValue<string>>("built_in_pattern_id");
        set => SetArgument("built_in_pattern_id", value);
    }

    /// <summary>
    /// The confidence_level attribute.
    /// </summary>
    public TerraformValue<double>? ConfidenceLevel
    {
        get => GetArgument<TerraformValue<double>>("confidence_level");
        set => SetArgument("confidence_level", value);
    }

    /// <summary>
    /// The enforced_urls attribute.
    /// </summary>
    public TerraformList<string>? EnforcedUrls
    {
        get => GetArgument<TerraformList<string>>("enforced_urls");
        set => SetArgument("enforced_urls", value);
    }

    /// <summary>
    /// The exempt_urls attribute.
    /// </summary>
    public TerraformList<string>? ExemptUrls
    {
        get => GetArgument<TerraformList<string>>("exempt_urls");
        set => SetArgument("exempt_urls", value);
    }

    /// <summary>
    /// CustomPattern block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlockInlineRedactionPatternBlockCustomPatternBlock>? CustomPattern
    {
        get => GetArgument<TerraformList<AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlockInlineRedactionPatternBlockCustomPatternBlock>>("custom_pattern");
        set => SetArgument("custom_pattern", value);
    }

    /// <summary>
    /// RedactionPlaceHolder block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlockInlineRedactionPatternBlockRedactionPlaceHolderBlock>? RedactionPlaceHolder
    {
        get => GetArgument<TerraformList<AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlockInlineRedactionPatternBlockRedactionPlaceHolderBlock>>("redaction_place_holder");
        set => SetArgument("redaction_place_holder", value);
    }

}

/// <summary>
/// Block type for custom_pattern in AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlockInlineRedactionPatternBlock.
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlockInlineRedactionPatternBlockCustomPatternBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_pattern";

    /// <summary>
    /// The keyword_regex attribute.
    /// </summary>
    public TerraformValue<string>? KeywordRegex
    {
        get => GetArgument<TerraformValue<string>>("keyword_regex");
        set => SetArgument("keyword_regex", value);
    }

    /// <summary>
    /// The pattern_description attribute.
    /// </summary>
    public TerraformValue<string>? PatternDescription
    {
        get => GetArgument<TerraformValue<string>>("pattern_description");
        set => SetArgument("pattern_description", value);
    }

    /// <summary>
    /// The pattern_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternName is required")]
    public required TerraformValue<string> PatternName
    {
        get => GetRequiredArgument<TerraformValue<string>>("pattern_name");
        set => SetArgument("pattern_name", value);
    }

    /// <summary>
    /// The pattern_regex attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PatternRegex is required")]
    public required TerraformValue<string> PatternRegex
    {
        get => GetRequiredArgument<TerraformValue<string>>("pattern_regex");
        set => SetArgument("pattern_regex", value);
    }

}

/// <summary>
/// Block type for redaction_place_holder in AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlockInlineRedactionPatternBlock.
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlockInlineRedactionPatternBlockRedactionPlaceHolderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redaction_place_holder";

    /// <summary>
    /// The redaction_place_holder_text attribute.
    /// </summary>
    public TerraformValue<string>? RedactionPlaceHolderText
    {
        get => GetArgument<TerraformValue<string>>("redaction_place_holder_text");
        set => SetArgument("redaction_place_holder_text", value);
    }

    /// <summary>
    /// The redaction_place_holder_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedactionPlaceHolderType is required")]
    public required TerraformValue<string> RedactionPlaceHolderType
    {
        get => GetRequiredArgument<TerraformValue<string>>("redaction_place_holder_type");
        set => SetArgument("redaction_place_holder_type", value);
    }

}


/// <summary>
/// Represents a aws_workspacesweb_data_protection_settings Terraform resource.
/// Manages a aws_workspacesweb_data_protection_settings resource.
/// </summary>
public partial class AwsWorkspaceswebDataProtectionSettings(string name) : TerraformResource("aws_workspacesweb_data_protection_settings", name)
{
    /// <summary>
    /// The additional_encryption_context attribute.
    /// </summary>
    public TerraformMap<string>? AdditionalEncryptionContext
    {
        get => GetArgument<TerraformMap<string>>("additional_encryption_context");
        set => SetArgument("additional_encryption_context", value);
    }

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    public TerraformValue<string>? CustomerManagedKey
    {
        get => GetArgument<TerraformValue<string>>("customer_managed_key");
        set => SetArgument("customer_managed_key", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The associated_portal_arns attribute.
    /// </summary>
    public TerraformList<string> AssociatedPortalArns
        => CreateReference("associated_portal_arns");

    /// <summary>
    /// The data_protection_settings_arn attribute.
    /// </summary>
    public TerraformValue<string> DataProtectionSettingsArn
        => CreateReference("data_protection_settings_arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => CreateReference("tags_all");

    /// <summary>
    /// InlineRedactionConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlock>? InlineRedactionConfiguration
    {
        get => GetArgument<TerraformList<AwsWorkspaceswebDataProtectionSettingsInlineRedactionConfigurationBlock>>("inline_redaction_configuration");
        set => SetArgument("inline_redaction_configuration", value);
    }

}
