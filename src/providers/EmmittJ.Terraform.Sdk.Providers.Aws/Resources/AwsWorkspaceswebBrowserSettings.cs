using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_workspacesweb_browser_settings resource.
/// </summary>
public class AwsWorkspaceswebBrowserSettings : TerraformResource
{
    public AwsWorkspaceswebBrowserSettings(string name) : base("aws_workspacesweb_browser_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("associated_portal_arns");
        SetOutput("browser_settings_arn");
        SetOutput("tags_all");
        SetOutput("additional_encryption_context");
        SetOutput("browser_policy");
        SetOutput("customer_managed_key");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The additional_encryption_context attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> AdditionalEncryptionContext
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("additional_encryption_context");
        set => SetProperty("additional_encryption_context", value);
    }

    /// <summary>
    /// The browser_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BrowserPolicy is required")]
    public required TerraformProperty<string> BrowserPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("browser_policy");
        set => SetProperty("browser_policy", value);
    }

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    public TerraformProperty<string> CustomerManagedKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customer_managed_key");
        set => SetProperty("customer_managed_key", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The associated_portal_arns attribute.
    /// </summary>
    public TerraformExpression AssociatedPortalArns => this["associated_portal_arns"];

    /// <summary>
    /// The browser_settings_arn attribute.
    /// </summary>
    public TerraformExpression BrowserSettingsArn => this["browser_settings_arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
