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
        this.DeclareOutput("associated_portal_arns");
        this.DeclareOutput("browser_settings_arn");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The additional_encryption_context attribute.
    /// </summary>
    public Dictionary<string, string>? AdditionalEncryptionContext
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("additional_encryption_context")?.Value;
        set => this.WithProperty("additional_encryption_context", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The browser_policy attribute.
    /// </summary>
    public string? BrowserPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("browser_policy")?.Value;
        set => this.WithProperty("browser_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The customer_managed_key attribute.
    /// </summary>
    public string? CustomerManagedKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_managed_key")?.Value;
        set => this.WithProperty("customer_managed_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
