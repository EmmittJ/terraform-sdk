using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_workspacesweb_browser_settings Terraform resource.
/// Manages a aws_workspacesweb_browser_settings resource.
/// </summary>
public partial class AwsWorkspaceswebBrowserSettings(string name) : TerraformResource("aws_workspacesweb_browser_settings", name)
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
    /// The browser_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BrowserPolicy is required")]
    public required TerraformValue<string> BrowserPolicy
    {
        get => GetRequiredArgument<TerraformValue<string>>("browser_policy");
        set => SetArgument("browser_policy", value);
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
    /// The browser_settings_arn attribute.
    /// </summary>
    public TerraformValue<string> BrowserSettingsArn
        => CreateReference("browser_settings_arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => CreateReference("tags_all");

}
