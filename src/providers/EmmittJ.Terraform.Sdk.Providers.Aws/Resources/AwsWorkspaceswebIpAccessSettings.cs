using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ip_rule in AwsWorkspaceswebIpAccessSettings.
/// Nesting mode: list
/// </summary>
public class AwsWorkspaceswebIpAccessSettingsIpRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_rule";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The ip_range attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpRange is required")]
    public required TerraformValue<string> IpRange
    {
        get => GetRequiredArgument<TerraformValue<string>>("ip_range");
        set => SetArgument("ip_range", value);
    }

}


/// <summary>
/// Represents a aws_workspacesweb_ip_access_settings Terraform resource.
/// Manages a aws_workspacesweb_ip_access_settings resource.
/// </summary>
public partial class AwsWorkspaceswebIpAccessSettings(string name) : TerraformResource("aws_workspacesweb_ip_access_settings", name)
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
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
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
        => AsReference("associated_portal_arns");

    /// <summary>
    /// The ip_access_settings_arn attribute.
    /// </summary>
    public TerraformValue<string> IpAccessSettingsArn
        => AsReference("ip_access_settings_arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// IpRule block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsWorkspaceswebIpAccessSettingsIpRuleBlock>? IpRule
    {
        get => GetArgument<TerraformList<AwsWorkspaceswebIpAccessSettingsIpRuleBlock>>("ip_rule");
        set => SetArgument("ip_rule", value);
    }

}
